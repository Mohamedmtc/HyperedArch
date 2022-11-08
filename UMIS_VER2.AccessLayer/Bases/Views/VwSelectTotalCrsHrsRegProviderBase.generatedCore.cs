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
	/// This class is the base class for any <see cref="VwSelectTotalCrsHrsRegProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwSelectTotalCrsHrsRegProviderBaseCore : EntityViewProviderBase<VwSelectTotalCrsHrsReg>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwSelectTotalCrsHrsReg&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwSelectTotalCrsHrsReg&gt;"/></returns>
		protected static VList&lt;VwSelectTotalCrsHrsReg&gt; Fill(DataSet dataSet, VList<VwSelectTotalCrsHrsReg> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwSelectTotalCrsHrsReg>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwSelectTotalCrsHrsReg&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwSelectTotalCrsHrsReg>"/></returns>
		protected static VList&lt;VwSelectTotalCrsHrsReg&gt; Fill(DataTable dataTable, VList<VwSelectTotalCrsHrsReg> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwSelectTotalCrsHrsReg c = new VwSelectTotalCrsHrsReg();
					c.AccumRegHrs = (Convert.IsDBNull(row["AccumRegHrs"]))?0.0m:(System.Decimal?)row["AccumRegHrs"];
					c.EdStudId = (Convert.IsDBNull(row["ED_STUD_ID"]))?0.0m:(System.Decimal)row["ED_STUD_ID"];
					c.Faculty = (Convert.IsDBNull(row["Faculty"]))?0.0m:(System.Decimal?)row["Faculty"];
					c.GradRegHrs = (Convert.IsDBNull(row["GradRegHrs"]))?0.0m:(System.Decimal?)row["GradRegHrs"];
					c.InCompleteCourse = (Convert.IsDBNull(row["InCompleteCourse"]))?0.0m:(System.Decimal?)row["InCompleteCourse"];
					c.RegsHrsLastSemester = (Convert.IsDBNull(row["RegsHrs_LastSemester"]))?0.0m:(System.Decimal?)row["RegsHrs_LastSemester"];
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
		/// Fill an <see cref="VList&lt;VwSelectTotalCrsHrsReg&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwSelectTotalCrsHrsReg&gt;"/></returns>
		protected VList<VwSelectTotalCrsHrsReg> Fill(IDataReader reader, VList<VwSelectTotalCrsHrsReg> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwSelectTotalCrsHrsReg entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwSelectTotalCrsHrsReg>("VwSelectTotalCrsHrsReg",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwSelectTotalCrsHrsReg();
					}
					
					entity.SuppressEntityEvents = true;

					entity.AccumRegHrs = (reader.IsDBNull(((int)VwSelectTotalCrsHrsRegColumn.AccumRegHrs)))?null:(System.Decimal?)reader[((int)VwSelectTotalCrsHrsRegColumn.AccumRegHrs)];
					//entity.AccumRegHrs = (Convert.IsDBNull(reader["AccumRegHrs"]))?0.0m:(System.Decimal?)reader["AccumRegHrs"];
					entity.EdStudId = (System.Decimal)reader[((int)VwSelectTotalCrsHrsRegColumn.EdStudId)];
					//entity.EdStudId = (Convert.IsDBNull(reader["ED_STUD_ID"]))?0.0m:(System.Decimal)reader["ED_STUD_ID"];
					entity.Faculty = (reader.IsDBNull(((int)VwSelectTotalCrsHrsRegColumn.Faculty)))?null:(System.Decimal?)reader[((int)VwSelectTotalCrsHrsRegColumn.Faculty)];
					//entity.Faculty = (Convert.IsDBNull(reader["Faculty"]))?0.0m:(System.Decimal?)reader["Faculty"];
					entity.GradRegHrs = (reader.IsDBNull(((int)VwSelectTotalCrsHrsRegColumn.GradRegHrs)))?null:(System.Decimal?)reader[((int)VwSelectTotalCrsHrsRegColumn.GradRegHrs)];
					//entity.GradRegHrs = (Convert.IsDBNull(reader["GradRegHrs"]))?0.0m:(System.Decimal?)reader["GradRegHrs"];
					entity.InCompleteCourse = (reader.IsDBNull(((int)VwSelectTotalCrsHrsRegColumn.InCompleteCourse)))?null:(System.Decimal?)reader[((int)VwSelectTotalCrsHrsRegColumn.InCompleteCourse)];
					//entity.InCompleteCourse = (Convert.IsDBNull(reader["InCompleteCourse"]))?0.0m:(System.Decimal?)reader["InCompleteCourse"];
					entity.RegsHrsLastSemester = (reader.IsDBNull(((int)VwSelectTotalCrsHrsRegColumn.RegsHrsLastSemester)))?null:(System.Decimal?)reader[((int)VwSelectTotalCrsHrsRegColumn.RegsHrsLastSemester)];
					//entity.RegsHrsLastSemester = (Convert.IsDBNull(reader["RegsHrs_LastSemester"]))?0.0m:(System.Decimal?)reader["RegsHrs_LastSemester"];
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
		/// Refreshes the <see cref="VwSelectTotalCrsHrsReg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwSelectTotalCrsHrsReg"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwSelectTotalCrsHrsReg entity)
		{
			reader.Read();
			entity.AccumRegHrs = (reader.IsDBNull(((int)VwSelectTotalCrsHrsRegColumn.AccumRegHrs)))?null:(System.Decimal?)reader[((int)VwSelectTotalCrsHrsRegColumn.AccumRegHrs)];
			//entity.AccumRegHrs = (Convert.IsDBNull(reader["AccumRegHrs"]))?0.0m:(System.Decimal?)reader["AccumRegHrs"];
			entity.EdStudId = (System.Decimal)reader[((int)VwSelectTotalCrsHrsRegColumn.EdStudId)];
			//entity.EdStudId = (Convert.IsDBNull(reader["ED_STUD_ID"]))?0.0m:(System.Decimal)reader["ED_STUD_ID"];
			entity.Faculty = (reader.IsDBNull(((int)VwSelectTotalCrsHrsRegColumn.Faculty)))?null:(System.Decimal?)reader[((int)VwSelectTotalCrsHrsRegColumn.Faculty)];
			//entity.Faculty = (Convert.IsDBNull(reader["Faculty"]))?0.0m:(System.Decimal?)reader["Faculty"];
			entity.GradRegHrs = (reader.IsDBNull(((int)VwSelectTotalCrsHrsRegColumn.GradRegHrs)))?null:(System.Decimal?)reader[((int)VwSelectTotalCrsHrsRegColumn.GradRegHrs)];
			//entity.GradRegHrs = (Convert.IsDBNull(reader["GradRegHrs"]))?0.0m:(System.Decimal?)reader["GradRegHrs"];
			entity.InCompleteCourse = (reader.IsDBNull(((int)VwSelectTotalCrsHrsRegColumn.InCompleteCourse)))?null:(System.Decimal?)reader[((int)VwSelectTotalCrsHrsRegColumn.InCompleteCourse)];
			//entity.InCompleteCourse = (Convert.IsDBNull(reader["InCompleteCourse"]))?0.0m:(System.Decimal?)reader["InCompleteCourse"];
			entity.RegsHrsLastSemester = (reader.IsDBNull(((int)VwSelectTotalCrsHrsRegColumn.RegsHrsLastSemester)))?null:(System.Decimal?)reader[((int)VwSelectTotalCrsHrsRegColumn.RegsHrsLastSemester)];
			//entity.RegsHrsLastSemester = (Convert.IsDBNull(reader["RegsHrs_LastSemester"]))?0.0m:(System.Decimal?)reader["RegsHrs_LastSemester"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwSelectTotalCrsHrsReg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwSelectTotalCrsHrsReg"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwSelectTotalCrsHrsReg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccumRegHrs = (Convert.IsDBNull(dataRow["AccumRegHrs"]))?0.0m:(System.Decimal?)dataRow["AccumRegHrs"];
			entity.EdStudId = (Convert.IsDBNull(dataRow["ED_STUD_ID"]))?0.0m:(System.Decimal)dataRow["ED_STUD_ID"];
			entity.Faculty = (Convert.IsDBNull(dataRow["Faculty"]))?0.0m:(System.Decimal?)dataRow["Faculty"];
			entity.GradRegHrs = (Convert.IsDBNull(dataRow["GradRegHrs"]))?0.0m:(System.Decimal?)dataRow["GradRegHrs"];
			entity.InCompleteCourse = (Convert.IsDBNull(dataRow["InCompleteCourse"]))?0.0m:(System.Decimal?)dataRow["InCompleteCourse"];
			entity.RegsHrsLastSemester = (Convert.IsDBNull(dataRow["RegsHrs_LastSemester"]))?0.0m:(System.Decimal?)dataRow["RegsHrs_LastSemester"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwSelectTotalCrsHrsRegFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSelectTotalCrsHrsReg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwSelectTotalCrsHrsRegFilterBuilder : SqlFilterBuilder<VwSelectTotalCrsHrsRegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSelectTotalCrsHrsRegFilterBuilder class.
		/// </summary>
		public VwSelectTotalCrsHrsRegFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwSelectTotalCrsHrsRegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwSelectTotalCrsHrsRegFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwSelectTotalCrsHrsRegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwSelectTotalCrsHrsRegFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwSelectTotalCrsHrsRegFilterBuilder

	#region VwSelectTotalCrsHrsRegParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSelectTotalCrsHrsReg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwSelectTotalCrsHrsRegParameterBuilder : ParameterizedSqlFilterBuilder<VwSelectTotalCrsHrsRegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSelectTotalCrsHrsRegParameterBuilder class.
		/// </summary>
		public VwSelectTotalCrsHrsRegParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwSelectTotalCrsHrsRegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwSelectTotalCrsHrsRegParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwSelectTotalCrsHrsRegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwSelectTotalCrsHrsRegParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwSelectTotalCrsHrsRegParameterBuilder
	
	#region VwSelectTotalCrsHrsRegSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSelectTotalCrsHrsReg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwSelectTotalCrsHrsRegSortBuilder : SqlSortBuilder<VwSelectTotalCrsHrsRegColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSelectTotalCrsHrsRegSqlSortBuilder class.
		/// </summary>
		public VwSelectTotalCrsHrsRegSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwSelectTotalCrsHrsRegSortBuilder

} // end namespace
