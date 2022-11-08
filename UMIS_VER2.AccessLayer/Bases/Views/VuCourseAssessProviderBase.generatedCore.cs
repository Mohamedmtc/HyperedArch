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
	/// This class is the base class for any <see cref="VuCourseAssessProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VuCourseAssessProviderBaseCore : EntityViewProviderBase<VuCourseAssess>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VuCourseAssess&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VuCourseAssess&gt;"/></returns>
		protected static VList&lt;VuCourseAssess&gt; Fill(DataSet dataSet, VList<VuCourseAssess> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VuCourseAssess>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VuCourseAssess&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VuCourseAssess>"/></returns>
		protected static VList&lt;VuCourseAssess&gt; Fill(DataTable dataTable, VList<VuCourseAssess> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VuCourseAssess c = new VuCourseAssess();
					c.EdAcadYearId = (Convert.IsDBNull(row["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal)row["ED_ACAD_YEAR_ID"];
					c.AsFacultyInfoId = (Convert.IsDBNull(row["AS_FACULTY_INFO_ID"]))?0.0m:(System.Decimal)row["AS_FACULTY_INFO_ID"];
					c.EdCodeLevelId = (Convert.IsDBNull(row["ED_CODE_LEVEL_ID"]))?0.0m:(System.Decimal?)row["ED_CODE_LEVEL_ID"];
					c.EdSemesterOpenId = (Convert.IsDBNull(row["ED_SEMESTER_OPEN_ID"]))?0.0m:(System.Decimal)row["ED_SEMESTER_OPEN_ID"];
					c.EdCourseId = (Convert.IsDBNull(row["ED_COURSE_ID"]))?0.0m:(System.Decimal)row["ED_COURSE_ID"];
					c.CourseCode = (Convert.IsDBNull(row["CourseCode"]))?string.Empty:(System.String)row["CourseCode"];
					c.CourseDescEn = (Convert.IsDBNull(row["CourseDescEn"]))?string.Empty:(System.String)row["CourseDescEn"];
					c.CourseDescAr = (Convert.IsDBNull(row["CourseDescAr"]))?string.Empty:(System.String)row["CourseDescAr"];
					c.CourseMax = (Convert.IsDBNull(row["CourseMax"]))?0.0m:(System.Decimal?)row["CourseMax"];
					c.CourseMin = (Convert.IsDBNull(row["CourseMin"]))?0.0m:(System.Decimal?)row["CourseMin"];
					c.AssessMaxRate = (Convert.IsDBNull(row["AssessMaxRate"]))?0.0m:(System.Decimal)row["AssessMaxRate"];
					c.AssessMinRate = (Convert.IsDBNull(row["AssessMinRate"]))?0.0m:(System.Decimal)row["AssessMinRate"];
					c.AssessDescEn = (Convert.IsDBNull(row["AssessDescEn"]))?string.Empty:(System.String)row["AssessDescEn"];
					c.AssessDescAr = (Convert.IsDBNull(row["AssessDescAr"]))?string.Empty:(System.String)row["AssessDescAr"];
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
		/// Fill an <see cref="VList&lt;VuCourseAssess&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VuCourseAssess&gt;"/></returns>
		protected VList<VuCourseAssess> Fill(IDataReader reader, VList<VuCourseAssess> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VuCourseAssess entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VuCourseAssess>("VuCourseAssess",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VuCourseAssess();
					}
					
					entity.SuppressEntityEvents = true;

					entity.EdAcadYearId = (System.Decimal)reader[((int)VuCourseAssessColumn.EdAcadYearId)];
					//entity.EdAcadYearId = (Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal)reader["ED_ACAD_YEAR_ID"];
					entity.AsFacultyInfoId = (System.Decimal)reader[((int)VuCourseAssessColumn.AsFacultyInfoId)];
					//entity.AsFacultyInfoId = (Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]))?0.0m:(System.Decimal)reader["AS_FACULTY_INFO_ID"];
					entity.EdCodeLevelId = (reader.IsDBNull(((int)VuCourseAssessColumn.EdCodeLevelId)))?null:(System.Decimal?)reader[((int)VuCourseAssessColumn.EdCodeLevelId)];
					//entity.EdCodeLevelId = (Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]))?0.0m:(System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					entity.EdSemesterOpenId = (System.Decimal)reader[((int)VuCourseAssessColumn.EdSemesterOpenId)];
					//entity.EdSemesterOpenId = (Convert.IsDBNull(reader["ED_SEMESTER_OPEN_ID"]))?0.0m:(System.Decimal)reader["ED_SEMESTER_OPEN_ID"];
					entity.EdCourseId = (System.Decimal)reader[((int)VuCourseAssessColumn.EdCourseId)];
					//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal)reader["ED_COURSE_ID"];
					entity.CourseCode = (System.String)reader[((int)VuCourseAssessColumn.CourseCode)];
					//entity.CourseCode = (Convert.IsDBNull(reader["CourseCode"]))?string.Empty:(System.String)reader["CourseCode"];
					entity.CourseDescEn = (System.String)reader[((int)VuCourseAssessColumn.CourseDescEn)];
					//entity.CourseDescEn = (Convert.IsDBNull(reader["CourseDescEn"]))?string.Empty:(System.String)reader["CourseDescEn"];
					entity.CourseDescAr = (System.String)reader[((int)VuCourseAssessColumn.CourseDescAr)];
					//entity.CourseDescAr = (Convert.IsDBNull(reader["CourseDescAr"]))?string.Empty:(System.String)reader["CourseDescAr"];
					entity.CourseMax = (reader.IsDBNull(((int)VuCourseAssessColumn.CourseMax)))?null:(System.Decimal?)reader[((int)VuCourseAssessColumn.CourseMax)];
					//entity.CourseMax = (Convert.IsDBNull(reader["CourseMax"]))?0.0m:(System.Decimal?)reader["CourseMax"];
					entity.CourseMin = (reader.IsDBNull(((int)VuCourseAssessColumn.CourseMin)))?null:(System.Decimal?)reader[((int)VuCourseAssessColumn.CourseMin)];
					//entity.CourseMin = (Convert.IsDBNull(reader["CourseMin"]))?0.0m:(System.Decimal?)reader["CourseMin"];
					entity.AssessMaxRate = (System.Decimal)reader[((int)VuCourseAssessColumn.AssessMaxRate)];
					//entity.AssessMaxRate = (Convert.IsDBNull(reader["AssessMaxRate"]))?0.0m:(System.Decimal)reader["AssessMaxRate"];
					entity.AssessMinRate = (System.Decimal)reader[((int)VuCourseAssessColumn.AssessMinRate)];
					//entity.AssessMinRate = (Convert.IsDBNull(reader["AssessMinRate"]))?0.0m:(System.Decimal)reader["AssessMinRate"];
					entity.AssessDescEn = (reader.IsDBNull(((int)VuCourseAssessColumn.AssessDescEn)))?null:(System.String)reader[((int)VuCourseAssessColumn.AssessDescEn)];
					//entity.AssessDescEn = (Convert.IsDBNull(reader["AssessDescEn"]))?string.Empty:(System.String)reader["AssessDescEn"];
					entity.AssessDescAr = (System.String)reader[((int)VuCourseAssessColumn.AssessDescAr)];
					//entity.AssessDescAr = (Convert.IsDBNull(reader["AssessDescAr"]))?string.Empty:(System.String)reader["AssessDescAr"];
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
		/// Refreshes the <see cref="VuCourseAssess"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VuCourseAssess"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VuCourseAssess entity)
		{
			reader.Read();
			entity.EdAcadYearId = (System.Decimal)reader[((int)VuCourseAssessColumn.EdAcadYearId)];
			//entity.EdAcadYearId = (Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal)reader["ED_ACAD_YEAR_ID"];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)VuCourseAssessColumn.AsFacultyInfoId)];
			//entity.AsFacultyInfoId = (Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]))?0.0m:(System.Decimal)reader["AS_FACULTY_INFO_ID"];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)VuCourseAssessColumn.EdCodeLevelId)))?null:(System.Decimal?)reader[((int)VuCourseAssessColumn.EdCodeLevelId)];
			//entity.EdCodeLevelId = (Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]))?0.0m:(System.Decimal?)reader["ED_CODE_LEVEL_ID"];
			entity.EdSemesterOpenId = (System.Decimal)reader[((int)VuCourseAssessColumn.EdSemesterOpenId)];
			//entity.EdSemesterOpenId = (Convert.IsDBNull(reader["ED_SEMESTER_OPEN_ID"]))?0.0m:(System.Decimal)reader["ED_SEMESTER_OPEN_ID"];
			entity.EdCourseId = (System.Decimal)reader[((int)VuCourseAssessColumn.EdCourseId)];
			//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal)reader["ED_COURSE_ID"];
			entity.CourseCode = (System.String)reader[((int)VuCourseAssessColumn.CourseCode)];
			//entity.CourseCode = (Convert.IsDBNull(reader["CourseCode"]))?string.Empty:(System.String)reader["CourseCode"];
			entity.CourseDescEn = (System.String)reader[((int)VuCourseAssessColumn.CourseDescEn)];
			//entity.CourseDescEn = (Convert.IsDBNull(reader["CourseDescEn"]))?string.Empty:(System.String)reader["CourseDescEn"];
			entity.CourseDescAr = (System.String)reader[((int)VuCourseAssessColumn.CourseDescAr)];
			//entity.CourseDescAr = (Convert.IsDBNull(reader["CourseDescAr"]))?string.Empty:(System.String)reader["CourseDescAr"];
			entity.CourseMax = (reader.IsDBNull(((int)VuCourseAssessColumn.CourseMax)))?null:(System.Decimal?)reader[((int)VuCourseAssessColumn.CourseMax)];
			//entity.CourseMax = (Convert.IsDBNull(reader["CourseMax"]))?0.0m:(System.Decimal?)reader["CourseMax"];
			entity.CourseMin = (reader.IsDBNull(((int)VuCourseAssessColumn.CourseMin)))?null:(System.Decimal?)reader[((int)VuCourseAssessColumn.CourseMin)];
			//entity.CourseMin = (Convert.IsDBNull(reader["CourseMin"]))?0.0m:(System.Decimal?)reader["CourseMin"];
			entity.AssessMaxRate = (System.Decimal)reader[((int)VuCourseAssessColumn.AssessMaxRate)];
			//entity.AssessMaxRate = (Convert.IsDBNull(reader["AssessMaxRate"]))?0.0m:(System.Decimal)reader["AssessMaxRate"];
			entity.AssessMinRate = (System.Decimal)reader[((int)VuCourseAssessColumn.AssessMinRate)];
			//entity.AssessMinRate = (Convert.IsDBNull(reader["AssessMinRate"]))?0.0m:(System.Decimal)reader["AssessMinRate"];
			entity.AssessDescEn = (reader.IsDBNull(((int)VuCourseAssessColumn.AssessDescEn)))?null:(System.String)reader[((int)VuCourseAssessColumn.AssessDescEn)];
			//entity.AssessDescEn = (Convert.IsDBNull(reader["AssessDescEn"]))?string.Empty:(System.String)reader["AssessDescEn"];
			entity.AssessDescAr = (System.String)reader[((int)VuCourseAssessColumn.AssessDescAr)];
			//entity.AssessDescAr = (Convert.IsDBNull(reader["AssessDescAr"]))?string.Empty:(System.String)reader["AssessDescAr"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VuCourseAssess"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VuCourseAssess"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VuCourseAssess entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdAcadYearId = (Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.AsFacultyInfoId = (Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]))?0.0m:(System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCodeLevelId = (Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]))?0.0m:(System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.EdSemesterOpenId = (Convert.IsDBNull(dataRow["ED_SEMESTER_OPEN_ID"]))?0.0m:(System.Decimal)dataRow["ED_SEMESTER_OPEN_ID"];
			entity.EdCourseId = (Convert.IsDBNull(dataRow["ED_COURSE_ID"]))?0.0m:(System.Decimal)dataRow["ED_COURSE_ID"];
			entity.CourseCode = (Convert.IsDBNull(dataRow["CourseCode"]))?string.Empty:(System.String)dataRow["CourseCode"];
			entity.CourseDescEn = (Convert.IsDBNull(dataRow["CourseDescEn"]))?string.Empty:(System.String)dataRow["CourseDescEn"];
			entity.CourseDescAr = (Convert.IsDBNull(dataRow["CourseDescAr"]))?string.Empty:(System.String)dataRow["CourseDescAr"];
			entity.CourseMax = (Convert.IsDBNull(dataRow["CourseMax"]))?0.0m:(System.Decimal?)dataRow["CourseMax"];
			entity.CourseMin = (Convert.IsDBNull(dataRow["CourseMin"]))?0.0m:(System.Decimal?)dataRow["CourseMin"];
			entity.AssessMaxRate = (Convert.IsDBNull(dataRow["AssessMaxRate"]))?0.0m:(System.Decimal)dataRow["AssessMaxRate"];
			entity.AssessMinRate = (Convert.IsDBNull(dataRow["AssessMinRate"]))?0.0m:(System.Decimal)dataRow["AssessMinRate"];
			entity.AssessDescEn = (Convert.IsDBNull(dataRow["AssessDescEn"]))?string.Empty:(System.String)dataRow["AssessDescEn"];
			entity.AssessDescAr = (Convert.IsDBNull(dataRow["AssessDescAr"]))?string.Empty:(System.String)dataRow["AssessDescAr"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VuCourseAssessFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VuCourseAssess"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VuCourseAssessFilterBuilder : SqlFilterBuilder<VuCourseAssessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VuCourseAssessFilterBuilder class.
		/// </summary>
		public VuCourseAssessFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VuCourseAssessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VuCourseAssessFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VuCourseAssessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VuCourseAssessFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VuCourseAssessFilterBuilder

	#region VuCourseAssessParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VuCourseAssess"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VuCourseAssessParameterBuilder : ParameterizedSqlFilterBuilder<VuCourseAssessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VuCourseAssessParameterBuilder class.
		/// </summary>
		public VuCourseAssessParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VuCourseAssessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VuCourseAssessParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VuCourseAssessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VuCourseAssessParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VuCourseAssessParameterBuilder
	
	#region VuCourseAssessSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VuCourseAssess"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VuCourseAssessSortBuilder : SqlSortBuilder<VuCourseAssessColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VuCourseAssessSqlSortBuilder class.
		/// </summary>
		public VuCourseAssessSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VuCourseAssessSortBuilder

} // end namespace
