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
	/// This class is the base class for any <see cref="TeachingLoadDistributionPerProgramProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class TeachingLoadDistributionPerProgramProviderBaseCore : EntityViewProviderBase<TeachingLoadDistributionPerProgram>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;TeachingLoadDistributionPerProgram&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;TeachingLoadDistributionPerProgram&gt;"/></returns>
		protected static VList&lt;TeachingLoadDistributionPerProgram&gt; Fill(DataSet dataSet, VList<TeachingLoadDistributionPerProgram> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<TeachingLoadDistributionPerProgram>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;TeachingLoadDistributionPerProgram&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<TeachingLoadDistributionPerProgram>"/></returns>
		protected static VList&lt;TeachingLoadDistributionPerProgram&gt; Fill(DataTable dataTable, VList<TeachingLoadDistributionPerProgram> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					TeachingLoadDistributionPerProgram c = new TeachingLoadDistributionPerProgram();
					c.YearDescrEn = (Convert.IsDBNull(row["YEAR_DESCR_EN"]))?string.Empty:(System.String)row["YEAR_DESCR_EN"];
					c.SemesterDescrEn = (Convert.IsDBNull(row["SEMESTER_DESCR_EN"]))?string.Empty:(System.String)row["SEMESTER_DESCR_EN"];
					c.FacultyDescrEn = (Convert.IsDBNull(row["FACULTY_DESCR_EN"]))?string.Empty:(System.String)row["FACULTY_DESCR_EN"];
					c.StfFullNameAr = (Convert.IsDBNull(row["STF_FULL_NAME_AR"]))?string.Empty:(System.String)row["STF_FULL_NAME_AR"];
					c.StfFullNameEn = (Convert.IsDBNull(row["STF_FULL_NAME_EN"]))?string.Empty:(System.String)row["STF_FULL_NAME_EN"];
					c.StfCode = (Convert.IsDBNull(row["STF_CODE"]))?string.Empty:(System.String)row["STF_CODE"];
					c.CourseCode = (Convert.IsDBNull(row["COURSE_CODE"]))?string.Empty:(System.String)row["COURSE_CODE"];
					c.ProgramName = (Convert.IsDBNull(row["PROGRAM_NAME"]))?string.Empty:(System.String)row["PROGRAM_NAME"];
					c.TotalStudNum = (Convert.IsDBNull(row["TOTAL_STUD_NUM"]))?(int)0:(System.Int32?)row["TOTAL_STUD_NUM"];
					c.ProgramStudNum = (Convert.IsDBNull(row["PROGRAM_STUD_NUM"]))?(int)0:(System.Int32?)row["PROGRAM_STUD_NUM"];
					c.LoadPercentage = (Convert.IsDBNull(row["LOAD_PERCENTAGE"]))?0.0m:(System.Decimal?)row["LOAD_PERCENTAGE"];
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
		/// Fill an <see cref="VList&lt;TeachingLoadDistributionPerProgram&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;TeachingLoadDistributionPerProgram&gt;"/></returns>
		protected VList<TeachingLoadDistributionPerProgram> Fill(IDataReader reader, VList<TeachingLoadDistributionPerProgram> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					TeachingLoadDistributionPerProgram entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<TeachingLoadDistributionPerProgram>("TeachingLoadDistributionPerProgram",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new TeachingLoadDistributionPerProgram();
					}
					
					entity.SuppressEntityEvents = true;

					entity.YearDescrEn = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.YearDescrEn)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.YearDescrEn)];
					//entity.YearDescrEn = (Convert.IsDBNull(reader["YEAR_DESCR_EN"]))?string.Empty:(System.String)reader["YEAR_DESCR_EN"];
					entity.SemesterDescrEn = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.SemesterDescrEn)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.SemesterDescrEn)];
					//entity.SemesterDescrEn = (Convert.IsDBNull(reader["SEMESTER_DESCR_EN"]))?string.Empty:(System.String)reader["SEMESTER_DESCR_EN"];
					entity.FacultyDescrEn = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.FacultyDescrEn)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.FacultyDescrEn)];
					//entity.FacultyDescrEn = (Convert.IsDBNull(reader["FACULTY_DESCR_EN"]))?string.Empty:(System.String)reader["FACULTY_DESCR_EN"];
					entity.StfFullNameAr = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.StfFullNameAr)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.StfFullNameAr)];
					//entity.StfFullNameAr = (Convert.IsDBNull(reader["STF_FULL_NAME_AR"]))?string.Empty:(System.String)reader["STF_FULL_NAME_AR"];
					entity.StfFullNameEn = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.StfFullNameEn)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.StfFullNameEn)];
					//entity.StfFullNameEn = (Convert.IsDBNull(reader["STF_FULL_NAME_EN"]))?string.Empty:(System.String)reader["STF_FULL_NAME_EN"];
					entity.StfCode = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.StfCode)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.StfCode)];
					//entity.StfCode = (Convert.IsDBNull(reader["STF_CODE"]))?string.Empty:(System.String)reader["STF_CODE"];
					entity.CourseCode = (System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.CourseCode)];
					//entity.CourseCode = (Convert.IsDBNull(reader["COURSE_CODE"]))?string.Empty:(System.String)reader["COURSE_CODE"];
					entity.ProgramName = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.ProgramName)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.ProgramName)];
					//entity.ProgramName = (Convert.IsDBNull(reader["PROGRAM_NAME"]))?string.Empty:(System.String)reader["PROGRAM_NAME"];
					entity.TotalStudNum = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.TotalStudNum)))?null:(System.Int32?)reader[((int)TeachingLoadDistributionPerProgramColumn.TotalStudNum)];
					//entity.TotalStudNum = (Convert.IsDBNull(reader["TOTAL_STUD_NUM"]))?(int)0:(System.Int32?)reader["TOTAL_STUD_NUM"];
					entity.ProgramStudNum = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.ProgramStudNum)))?null:(System.Int32?)reader[((int)TeachingLoadDistributionPerProgramColumn.ProgramStudNum)];
					//entity.ProgramStudNum = (Convert.IsDBNull(reader["PROGRAM_STUD_NUM"]))?(int)0:(System.Int32?)reader["PROGRAM_STUD_NUM"];
					entity.LoadPercentage = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.LoadPercentage)))?null:(System.Decimal?)reader[((int)TeachingLoadDistributionPerProgramColumn.LoadPercentage)];
					//entity.LoadPercentage = (Convert.IsDBNull(reader["LOAD_PERCENTAGE"]))?0.0m:(System.Decimal?)reader["LOAD_PERCENTAGE"];
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
		/// Refreshes the <see cref="TeachingLoadDistributionPerProgram"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="TeachingLoadDistributionPerProgram"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, TeachingLoadDistributionPerProgram entity)
		{
			reader.Read();
			entity.YearDescrEn = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.YearDescrEn)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.YearDescrEn)];
			//entity.YearDescrEn = (Convert.IsDBNull(reader["YEAR_DESCR_EN"]))?string.Empty:(System.String)reader["YEAR_DESCR_EN"];
			entity.SemesterDescrEn = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.SemesterDescrEn)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.SemesterDescrEn)];
			//entity.SemesterDescrEn = (Convert.IsDBNull(reader["SEMESTER_DESCR_EN"]))?string.Empty:(System.String)reader["SEMESTER_DESCR_EN"];
			entity.FacultyDescrEn = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.FacultyDescrEn)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.FacultyDescrEn)];
			//entity.FacultyDescrEn = (Convert.IsDBNull(reader["FACULTY_DESCR_EN"]))?string.Empty:(System.String)reader["FACULTY_DESCR_EN"];
			entity.StfFullNameAr = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.StfFullNameAr)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.StfFullNameAr)];
			//entity.StfFullNameAr = (Convert.IsDBNull(reader["STF_FULL_NAME_AR"]))?string.Empty:(System.String)reader["STF_FULL_NAME_AR"];
			entity.StfFullNameEn = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.StfFullNameEn)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.StfFullNameEn)];
			//entity.StfFullNameEn = (Convert.IsDBNull(reader["STF_FULL_NAME_EN"]))?string.Empty:(System.String)reader["STF_FULL_NAME_EN"];
			entity.StfCode = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.StfCode)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.StfCode)];
			//entity.StfCode = (Convert.IsDBNull(reader["STF_CODE"]))?string.Empty:(System.String)reader["STF_CODE"];
			entity.CourseCode = (System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.CourseCode)];
			//entity.CourseCode = (Convert.IsDBNull(reader["COURSE_CODE"]))?string.Empty:(System.String)reader["COURSE_CODE"];
			entity.ProgramName = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.ProgramName)))?null:(System.String)reader[((int)TeachingLoadDistributionPerProgramColumn.ProgramName)];
			//entity.ProgramName = (Convert.IsDBNull(reader["PROGRAM_NAME"]))?string.Empty:(System.String)reader["PROGRAM_NAME"];
			entity.TotalStudNum = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.TotalStudNum)))?null:(System.Int32?)reader[((int)TeachingLoadDistributionPerProgramColumn.TotalStudNum)];
			//entity.TotalStudNum = (Convert.IsDBNull(reader["TOTAL_STUD_NUM"]))?(int)0:(System.Int32?)reader["TOTAL_STUD_NUM"];
			entity.ProgramStudNum = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.ProgramStudNum)))?null:(System.Int32?)reader[((int)TeachingLoadDistributionPerProgramColumn.ProgramStudNum)];
			//entity.ProgramStudNum = (Convert.IsDBNull(reader["PROGRAM_STUD_NUM"]))?(int)0:(System.Int32?)reader["PROGRAM_STUD_NUM"];
			entity.LoadPercentage = (reader.IsDBNull(((int)TeachingLoadDistributionPerProgramColumn.LoadPercentage)))?null:(System.Decimal?)reader[((int)TeachingLoadDistributionPerProgramColumn.LoadPercentage)];
			//entity.LoadPercentage = (Convert.IsDBNull(reader["LOAD_PERCENTAGE"]))?0.0m:(System.Decimal?)reader["LOAD_PERCENTAGE"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="TeachingLoadDistributionPerProgram"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="TeachingLoadDistributionPerProgram"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, TeachingLoadDistributionPerProgram entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.YearDescrEn = (Convert.IsDBNull(dataRow["YEAR_DESCR_EN"]))?string.Empty:(System.String)dataRow["YEAR_DESCR_EN"];
			entity.SemesterDescrEn = (Convert.IsDBNull(dataRow["SEMESTER_DESCR_EN"]))?string.Empty:(System.String)dataRow["SEMESTER_DESCR_EN"];
			entity.FacultyDescrEn = (Convert.IsDBNull(dataRow["FACULTY_DESCR_EN"]))?string.Empty:(System.String)dataRow["FACULTY_DESCR_EN"];
			entity.StfFullNameAr = (Convert.IsDBNull(dataRow["STF_FULL_NAME_AR"]))?string.Empty:(System.String)dataRow["STF_FULL_NAME_AR"];
			entity.StfFullNameEn = (Convert.IsDBNull(dataRow["STF_FULL_NAME_EN"]))?string.Empty:(System.String)dataRow["STF_FULL_NAME_EN"];
			entity.StfCode = (Convert.IsDBNull(dataRow["STF_CODE"]))?string.Empty:(System.String)dataRow["STF_CODE"];
			entity.CourseCode = (Convert.IsDBNull(dataRow["COURSE_CODE"]))?string.Empty:(System.String)dataRow["COURSE_CODE"];
			entity.ProgramName = (Convert.IsDBNull(dataRow["PROGRAM_NAME"]))?string.Empty:(System.String)dataRow["PROGRAM_NAME"];
			entity.TotalStudNum = (Convert.IsDBNull(dataRow["TOTAL_STUD_NUM"]))?(int)0:(System.Int32?)dataRow["TOTAL_STUD_NUM"];
			entity.ProgramStudNum = (Convert.IsDBNull(dataRow["PROGRAM_STUD_NUM"]))?(int)0:(System.Int32?)dataRow["PROGRAM_STUD_NUM"];
			entity.LoadPercentage = (Convert.IsDBNull(dataRow["LOAD_PERCENTAGE"]))?0.0m:(System.Decimal?)dataRow["LOAD_PERCENTAGE"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region TeachingLoadDistributionPerProgramFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TeachingLoadDistributionPerProgram"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TeachingLoadDistributionPerProgramFilterBuilder : SqlFilterBuilder<TeachingLoadDistributionPerProgramColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TeachingLoadDistributionPerProgramFilterBuilder class.
		/// </summary>
		public TeachingLoadDistributionPerProgramFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TeachingLoadDistributionPerProgramFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TeachingLoadDistributionPerProgramFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TeachingLoadDistributionPerProgramFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TeachingLoadDistributionPerProgramFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TeachingLoadDistributionPerProgramFilterBuilder

	#region TeachingLoadDistributionPerProgramParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TeachingLoadDistributionPerProgram"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TeachingLoadDistributionPerProgramParameterBuilder : ParameterizedSqlFilterBuilder<TeachingLoadDistributionPerProgramColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TeachingLoadDistributionPerProgramParameterBuilder class.
		/// </summary>
		public TeachingLoadDistributionPerProgramParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TeachingLoadDistributionPerProgramParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TeachingLoadDistributionPerProgramParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TeachingLoadDistributionPerProgramParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TeachingLoadDistributionPerProgramParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TeachingLoadDistributionPerProgramParameterBuilder
	
	#region TeachingLoadDistributionPerProgramSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TeachingLoadDistributionPerProgram"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TeachingLoadDistributionPerProgramSortBuilder : SqlSortBuilder<TeachingLoadDistributionPerProgramColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TeachingLoadDistributionPerProgramSqlSortBuilder class.
		/// </summary>
		public TeachingLoadDistributionPerProgramSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TeachingLoadDistributionPerProgramSortBuilder

} // end namespace
