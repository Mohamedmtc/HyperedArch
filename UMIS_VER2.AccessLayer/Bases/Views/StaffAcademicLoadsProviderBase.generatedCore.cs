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
	/// This class is the base class for any <see cref="StaffAcademicLoadsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class StaffAcademicLoadsProviderBaseCore : EntityViewProviderBase<StaffAcademicLoads>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;StaffAcademicLoads&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;StaffAcademicLoads&gt;"/></returns>
		protected static VList&lt;StaffAcademicLoads&gt; Fill(DataSet dataSet, VList<StaffAcademicLoads> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<StaffAcademicLoads>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;StaffAcademicLoads&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<StaffAcademicLoads>"/></returns>
		protected static VList&lt;StaffAcademicLoads&gt; Fill(DataTable dataTable, VList<StaffAcademicLoads> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					StaffAcademicLoads c = new StaffAcademicLoads();
					c.YearDescrEn = (Convert.IsDBNull(row["YEAR_DESCR_EN"]))?string.Empty:(System.String)row["YEAR_DESCR_EN"];
					c.SemesterDescrEn = (Convert.IsDBNull(row["SEMESTER_DESCR_EN"]))?string.Empty:(System.String)row["SEMESTER_DESCR_EN"];
					c.FacultyDescrEn = (Convert.IsDBNull(row["FACULTY_DESCR_EN"]))?string.Empty:(System.String)row["FACULTY_DESCR_EN"];
					c.DepartmentDescrEn = (Convert.IsDBNull(row["DEPARTMENT_DESCR_EN"]))?string.Empty:(System.String)row["DEPARTMENT_DESCR_EN"];
					c.StfFullNameAr = (Convert.IsDBNull(row["STF_FULL_NAME_AR"]))?string.Empty:(System.String)row["STF_FULL_NAME_AR"];
					c.StfFullNameEn = (Convert.IsDBNull(row["STF_FULL_NAME_EN"]))?string.Empty:(System.String)row["STF_FULL_NAME_EN"];
					c.StfCode = (Convert.IsDBNull(row["STF_CODE"]))?string.Empty:(System.String)row["STF_CODE"];
					c.NormalLoad = (Convert.IsDBNull(row["NORMAL_LOAD"]))?0.0m:(System.Decimal)row["NORMAL_LOAD"];
					c.ExtraLoad = (Convert.IsDBNull(row["EXTRA_LOAD"]))?0.0m:(System.Decimal?)row["EXTRA_LOAD"];
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
		/// Fill an <see cref="VList&lt;StaffAcademicLoads&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;StaffAcademicLoads&gt;"/></returns>
		protected VList<StaffAcademicLoads> Fill(IDataReader reader, VList<StaffAcademicLoads> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					StaffAcademicLoads entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<StaffAcademicLoads>("StaffAcademicLoads",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new StaffAcademicLoads();
					}
					
					entity.SuppressEntityEvents = true;

					entity.YearDescrEn = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.YearDescrEn)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.YearDescrEn)];
					//entity.YearDescrEn = (Convert.IsDBNull(reader["YEAR_DESCR_EN"]))?string.Empty:(System.String)reader["YEAR_DESCR_EN"];
					entity.SemesterDescrEn = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.SemesterDescrEn)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.SemesterDescrEn)];
					//entity.SemesterDescrEn = (Convert.IsDBNull(reader["SEMESTER_DESCR_EN"]))?string.Empty:(System.String)reader["SEMESTER_DESCR_EN"];
					entity.FacultyDescrEn = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.FacultyDescrEn)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.FacultyDescrEn)];
					//entity.FacultyDescrEn = (Convert.IsDBNull(reader["FACULTY_DESCR_EN"]))?string.Empty:(System.String)reader["FACULTY_DESCR_EN"];
					entity.DepartmentDescrEn = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.DepartmentDescrEn)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.DepartmentDescrEn)];
					//entity.DepartmentDescrEn = (Convert.IsDBNull(reader["DEPARTMENT_DESCR_EN"]))?string.Empty:(System.String)reader["DEPARTMENT_DESCR_EN"];
					entity.StfFullNameAr = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.StfFullNameAr)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.StfFullNameAr)];
					//entity.StfFullNameAr = (Convert.IsDBNull(reader["STF_FULL_NAME_AR"]))?string.Empty:(System.String)reader["STF_FULL_NAME_AR"];
					entity.StfFullNameEn = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.StfFullNameEn)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.StfFullNameEn)];
					//entity.StfFullNameEn = (Convert.IsDBNull(reader["STF_FULL_NAME_EN"]))?string.Empty:(System.String)reader["STF_FULL_NAME_EN"];
					entity.StfCode = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.StfCode)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.StfCode)];
					//entity.StfCode = (Convert.IsDBNull(reader["STF_CODE"]))?string.Empty:(System.String)reader["STF_CODE"];
					entity.NormalLoad = (System.Decimal)reader[((int)StaffAcademicLoadsColumn.NormalLoad)];
					//entity.NormalLoad = (Convert.IsDBNull(reader["NORMAL_LOAD"]))?0.0m:(System.Decimal)reader["NORMAL_LOAD"];
					entity.ExtraLoad = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.ExtraLoad)))?null:(System.Decimal?)reader[((int)StaffAcademicLoadsColumn.ExtraLoad)];
					//entity.ExtraLoad = (Convert.IsDBNull(reader["EXTRA_LOAD"]))?0.0m:(System.Decimal?)reader["EXTRA_LOAD"];
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
		/// Refreshes the <see cref="StaffAcademicLoads"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="StaffAcademicLoads"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, StaffAcademicLoads entity)
		{
			reader.Read();
			entity.YearDescrEn = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.YearDescrEn)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.YearDescrEn)];
			//entity.YearDescrEn = (Convert.IsDBNull(reader["YEAR_DESCR_EN"]))?string.Empty:(System.String)reader["YEAR_DESCR_EN"];
			entity.SemesterDescrEn = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.SemesterDescrEn)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.SemesterDescrEn)];
			//entity.SemesterDescrEn = (Convert.IsDBNull(reader["SEMESTER_DESCR_EN"]))?string.Empty:(System.String)reader["SEMESTER_DESCR_EN"];
			entity.FacultyDescrEn = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.FacultyDescrEn)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.FacultyDescrEn)];
			//entity.FacultyDescrEn = (Convert.IsDBNull(reader["FACULTY_DESCR_EN"]))?string.Empty:(System.String)reader["FACULTY_DESCR_EN"];
			entity.DepartmentDescrEn = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.DepartmentDescrEn)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.DepartmentDescrEn)];
			//entity.DepartmentDescrEn = (Convert.IsDBNull(reader["DEPARTMENT_DESCR_EN"]))?string.Empty:(System.String)reader["DEPARTMENT_DESCR_EN"];
			entity.StfFullNameAr = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.StfFullNameAr)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.StfFullNameAr)];
			//entity.StfFullNameAr = (Convert.IsDBNull(reader["STF_FULL_NAME_AR"]))?string.Empty:(System.String)reader["STF_FULL_NAME_AR"];
			entity.StfFullNameEn = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.StfFullNameEn)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.StfFullNameEn)];
			//entity.StfFullNameEn = (Convert.IsDBNull(reader["STF_FULL_NAME_EN"]))?string.Empty:(System.String)reader["STF_FULL_NAME_EN"];
			entity.StfCode = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.StfCode)))?null:(System.String)reader[((int)StaffAcademicLoadsColumn.StfCode)];
			//entity.StfCode = (Convert.IsDBNull(reader["STF_CODE"]))?string.Empty:(System.String)reader["STF_CODE"];
			entity.NormalLoad = (System.Decimal)reader[((int)StaffAcademicLoadsColumn.NormalLoad)];
			//entity.NormalLoad = (Convert.IsDBNull(reader["NORMAL_LOAD"]))?0.0m:(System.Decimal)reader["NORMAL_LOAD"];
			entity.ExtraLoad = (reader.IsDBNull(((int)StaffAcademicLoadsColumn.ExtraLoad)))?null:(System.Decimal?)reader[((int)StaffAcademicLoadsColumn.ExtraLoad)];
			//entity.ExtraLoad = (Convert.IsDBNull(reader["EXTRA_LOAD"]))?0.0m:(System.Decimal?)reader["EXTRA_LOAD"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="StaffAcademicLoads"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="StaffAcademicLoads"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, StaffAcademicLoads entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.YearDescrEn = (Convert.IsDBNull(dataRow["YEAR_DESCR_EN"]))?string.Empty:(System.String)dataRow["YEAR_DESCR_EN"];
			entity.SemesterDescrEn = (Convert.IsDBNull(dataRow["SEMESTER_DESCR_EN"]))?string.Empty:(System.String)dataRow["SEMESTER_DESCR_EN"];
			entity.FacultyDescrEn = (Convert.IsDBNull(dataRow["FACULTY_DESCR_EN"]))?string.Empty:(System.String)dataRow["FACULTY_DESCR_EN"];
			entity.DepartmentDescrEn = (Convert.IsDBNull(dataRow["DEPARTMENT_DESCR_EN"]))?string.Empty:(System.String)dataRow["DEPARTMENT_DESCR_EN"];
			entity.StfFullNameAr = (Convert.IsDBNull(dataRow["STF_FULL_NAME_AR"]))?string.Empty:(System.String)dataRow["STF_FULL_NAME_AR"];
			entity.StfFullNameEn = (Convert.IsDBNull(dataRow["STF_FULL_NAME_EN"]))?string.Empty:(System.String)dataRow["STF_FULL_NAME_EN"];
			entity.StfCode = (Convert.IsDBNull(dataRow["STF_CODE"]))?string.Empty:(System.String)dataRow["STF_CODE"];
			entity.NormalLoad = (Convert.IsDBNull(dataRow["NORMAL_LOAD"]))?0.0m:(System.Decimal)dataRow["NORMAL_LOAD"];
			entity.ExtraLoad = (Convert.IsDBNull(dataRow["EXTRA_LOAD"]))?0.0m:(System.Decimal?)dataRow["EXTRA_LOAD"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region StaffAcademicLoadsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="StaffAcademicLoads"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StaffAcademicLoadsFilterBuilder : SqlFilterBuilder<StaffAcademicLoadsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaffAcademicLoadsFilterBuilder class.
		/// </summary>
		public StaffAcademicLoadsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the StaffAcademicLoadsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StaffAcademicLoadsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StaffAcademicLoadsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StaffAcademicLoadsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StaffAcademicLoadsFilterBuilder

	#region StaffAcademicLoadsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="StaffAcademicLoads"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StaffAcademicLoadsParameterBuilder : ParameterizedSqlFilterBuilder<StaffAcademicLoadsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaffAcademicLoadsParameterBuilder class.
		/// </summary>
		public StaffAcademicLoadsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the StaffAcademicLoadsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StaffAcademicLoadsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StaffAcademicLoadsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StaffAcademicLoadsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StaffAcademicLoadsParameterBuilder
	
	#region StaffAcademicLoadsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="StaffAcademicLoads"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class StaffAcademicLoadsSortBuilder : SqlSortBuilder<StaffAcademicLoadsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaffAcademicLoadsSqlSortBuilder class.
		/// </summary>
		public StaffAcademicLoadsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion StaffAcademicLoadsSortBuilder

} // end namespace
