#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="VmGetOfferingInCurrentAcadYearSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VmGetOfferingInCurrentAcadYearSemesterProviderBaseCore : EntityViewProviderBase<VmGetOfferingInCurrentAcadYearSemester>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VmGetOfferingInCurrentAcadYearSemester&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VmGetOfferingInCurrentAcadYearSemester&gt;"/></returns>
		protected static VList&lt;VmGetOfferingInCurrentAcadYearSemester&gt; Fill(DataSet dataSet, VList<VmGetOfferingInCurrentAcadYearSemester> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VmGetOfferingInCurrentAcadYearSemester>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VmGetOfferingInCurrentAcadYearSemester&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VmGetOfferingInCurrentAcadYearSemester>"/></returns>
		protected static VList&lt;VmGetOfferingInCurrentAcadYearSemester&gt; Fill(DataTable dataTable, VList<VmGetOfferingInCurrentAcadYearSemester> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VmGetOfferingInCurrentAcadYearSemester c = new VmGetOfferingInCurrentAcadYearSemester();
					c.OfferingCrsId = (Convert.IsDBNull(row["OfferingCrsId"]))?0.0m:(System.Decimal)row["OfferingCrsId"];
					c.CurrentAcadYearId = (Convert.IsDBNull(row["CurrentAcadYearId"]))?0.0m:(System.Decimal)row["CurrentAcadYearId"];
					c.CurrentCodeSemesterId = (Convert.IsDBNull(row["CurrentCodeSemesterId"]))?0.0m:(System.Decimal?)row["CurrentCodeSemesterId"];
					c.AcceptChanges();
					rows.Add(c);
					pagelen -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		*/	
						
		///<summary>
		/// Fill an <see cref="VList&lt;VmGetOfferingInCurrentAcadYearSemester&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VmGetOfferingInCurrentAcadYearSemester&gt;"/></returns>
		protected VList<VmGetOfferingInCurrentAcadYearSemester> Fill(IDataReader reader, VList<VmGetOfferingInCurrentAcadYearSemester> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VmGetOfferingInCurrentAcadYearSemester entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VmGetOfferingInCurrentAcadYearSemester>("VmGetOfferingInCurrentAcadYearSemester",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VmGetOfferingInCurrentAcadYearSemester();
					}
					
					entity.SuppressEntityEvents = true;

					entity.OfferingCrsId = (System.Decimal)reader[((int)VmGetOfferingInCurrentAcadYearSemesterColumn.OfferingCrsId)];
					//entity.OfferingCrsId = (Convert.IsDBNull(reader["OfferingCrsId"]))?0.0m:(System.Decimal)reader["OfferingCrsId"];
					entity.CurrentAcadYearId = (System.Decimal)reader[((int)VmGetOfferingInCurrentAcadYearSemesterColumn.CurrentAcadYearId)];
					//entity.CurrentAcadYearId = (Convert.IsDBNull(reader["CurrentAcadYearId"]))?0.0m:(System.Decimal)reader["CurrentAcadYearId"];
					entity.CurrentCodeSemesterId = (reader.IsDBNull(((int)VmGetOfferingInCurrentAcadYearSemesterColumn.CurrentCodeSemesterId)))?null:(System.Decimal?)reader[((int)VmGetOfferingInCurrentAcadYearSemesterColumn.CurrentCodeSemesterId)];
					//entity.CurrentCodeSemesterId = (Convert.IsDBNull(reader["CurrentCodeSemesterId"]))?0.0m:(System.Decimal?)reader["CurrentCodeSemesterId"];
					entity.AcceptChanges();
					entity.SuppressEntityEvents = false;
					
					rows.Add(entity);
					pageLength -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		
		
		/// <summary>
		/// Refreshes the <see cref="VmGetOfferingInCurrentAcadYearSemester"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VmGetOfferingInCurrentAcadYearSemester"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VmGetOfferingInCurrentAcadYearSemester entity)
		{
			reader.Read();
			entity.OfferingCrsId = (System.Decimal)reader[((int)VmGetOfferingInCurrentAcadYearSemesterColumn.OfferingCrsId)];
			//entity.OfferingCrsId = (Convert.IsDBNull(reader["OfferingCrsId"]))?0.0m:(System.Decimal)reader["OfferingCrsId"];
			entity.CurrentAcadYearId = (System.Decimal)reader[((int)VmGetOfferingInCurrentAcadYearSemesterColumn.CurrentAcadYearId)];
			//entity.CurrentAcadYearId = (Convert.IsDBNull(reader["CurrentAcadYearId"]))?0.0m:(System.Decimal)reader["CurrentAcadYearId"];
			entity.CurrentCodeSemesterId = (reader.IsDBNull(((int)VmGetOfferingInCurrentAcadYearSemesterColumn.CurrentCodeSemesterId)))?null:(System.Decimal?)reader[((int)VmGetOfferingInCurrentAcadYearSemesterColumn.CurrentCodeSemesterId)];
			//entity.CurrentCodeSemesterId = (Convert.IsDBNull(reader["CurrentCodeSemesterId"]))?0.0m:(System.Decimal?)reader["CurrentCodeSemesterId"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VmGetOfferingInCurrentAcadYearSemester"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VmGetOfferingInCurrentAcadYearSemester"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VmGetOfferingInCurrentAcadYearSemester entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.OfferingCrsId = (Convert.IsDBNull(dataRow["OfferingCrsId"]))?0.0m:(System.Decimal)dataRow["OfferingCrsId"];
			entity.CurrentAcadYearId = (Convert.IsDBNull(dataRow["CurrentAcadYearId"]))?0.0m:(System.Decimal)dataRow["CurrentAcadYearId"];
			entity.CurrentCodeSemesterId = (Convert.IsDBNull(dataRow["CurrentCodeSemesterId"]))?0.0m:(System.Decimal?)dataRow["CurrentCodeSemesterId"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VmGetOfferingInCurrentAcadYearSemesterFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VmGetOfferingInCurrentAcadYearSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VmGetOfferingInCurrentAcadYearSemesterFilterBuilder : SqlFilterBuilder<VmGetOfferingInCurrentAcadYearSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VmGetOfferingInCurrentAcadYearSemesterFilterBuilder class.
		/// </summary>
		public VmGetOfferingInCurrentAcadYearSemesterFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VmGetOfferingInCurrentAcadYearSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VmGetOfferingInCurrentAcadYearSemesterFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VmGetOfferingInCurrentAcadYearSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VmGetOfferingInCurrentAcadYearSemesterFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VmGetOfferingInCurrentAcadYearSemesterFilterBuilder

	#region VmGetOfferingInCurrentAcadYearSemesterParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VmGetOfferingInCurrentAcadYearSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VmGetOfferingInCurrentAcadYearSemesterParameterBuilder : ParameterizedSqlFilterBuilder<VmGetOfferingInCurrentAcadYearSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VmGetOfferingInCurrentAcadYearSemesterParameterBuilder class.
		/// </summary>
		public VmGetOfferingInCurrentAcadYearSemesterParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VmGetOfferingInCurrentAcadYearSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VmGetOfferingInCurrentAcadYearSemesterParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VmGetOfferingInCurrentAcadYearSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VmGetOfferingInCurrentAcadYearSemesterParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VmGetOfferingInCurrentAcadYearSemesterParameterBuilder
	
	#region VmGetOfferingInCurrentAcadYearSemesterSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VmGetOfferingInCurrentAcadYearSemester"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VmGetOfferingInCurrentAcadYearSemesterSortBuilder : SqlSortBuilder<VmGetOfferingInCurrentAcadYearSemesterColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VmGetOfferingInCurrentAcadYearSemesterSqlSortBuilder class.
		/// </summary>
		public VmGetOfferingInCurrentAcadYearSemesterSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VmGetOfferingInCurrentAcadYearSemesterSortBuilder

} // end namespace
