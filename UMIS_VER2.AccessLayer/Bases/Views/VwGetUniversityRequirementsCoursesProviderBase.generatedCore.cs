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
	/// This class is the base class for any <see cref="VwGetUniversityRequirementsCoursesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwGetUniversityRequirementsCoursesProviderBaseCore : EntityViewProviderBase<VwGetUniversityRequirementsCourses>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwGetUniversityRequirementsCourses&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwGetUniversityRequirementsCourses&gt;"/></returns>
		protected static VList&lt;VwGetUniversityRequirementsCourses&gt; Fill(DataSet dataSet, VList<VwGetUniversityRequirementsCourses> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwGetUniversityRequirementsCourses>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwGetUniversityRequirementsCourses&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwGetUniversityRequirementsCourses>"/></returns>
		protected static VList&lt;VwGetUniversityRequirementsCourses&gt; Fill(DataTable dataTable, VList<VwGetUniversityRequirementsCourses> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwGetUniversityRequirementsCourses c = new VwGetUniversityRequirementsCourses();
					c.EdCourseId = (Convert.IsDBNull(row["ED_COURSE_ID"]))?0.0m:(System.Decimal?)row["ED_COURSE_ID"];
					c.CourseCode = (Convert.IsDBNull(row["COURSE_CODE"]))?string.Empty:(System.String)row["COURSE_CODE"];
					c.CourseDescrAr = (Convert.IsDBNull(row["COURSE_DESCR_AR"]))?string.Empty:(System.String)row["COURSE_DESCR_AR"];
					c.EntCoursePkgHdrId = (Convert.IsDBNull(row["ENT_COURSE_PKG_HDR_ID"]))?0.0m:(System.Decimal)row["ENT_COURSE_PKG_HDR_ID"];
					c.MajorId = (Convert.IsDBNull(row["MajorID"]))?0.0m:(System.Decimal)row["MajorID"];
					c.AcadPlanYearId = (Convert.IsDBNull(row["AcadPlanYearID"]))?0.0m:(System.Decimal?)row["AcadPlanYearID"];
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
		/// Fill an <see cref="VList&lt;VwGetUniversityRequirementsCourses&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwGetUniversityRequirementsCourses&gt;"/></returns>
		protected VList<VwGetUniversityRequirementsCourses> Fill(IDataReader reader, VList<VwGetUniversityRequirementsCourses> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwGetUniversityRequirementsCourses entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwGetUniversityRequirementsCourses>("VwGetUniversityRequirementsCourses",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwGetUniversityRequirementsCourses();
					}
					
					entity.SuppressEntityEvents = true;

					entity.EdCourseId = (reader.IsDBNull(((int)VwGetUniversityRequirementsCoursesColumn.EdCourseId)))?null:(System.Decimal?)reader[((int)VwGetUniversityRequirementsCoursesColumn.EdCourseId)];
					//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal?)reader["ED_COURSE_ID"];
					entity.CourseCode = (System.String)reader[((int)VwGetUniversityRequirementsCoursesColumn.CourseCode)];
					//entity.CourseCode = (Convert.IsDBNull(reader["COURSE_CODE"]))?string.Empty:(System.String)reader["COURSE_CODE"];
					entity.CourseDescrAr = (System.String)reader[((int)VwGetUniversityRequirementsCoursesColumn.CourseDescrAr)];
					//entity.CourseDescrAr = (Convert.IsDBNull(reader["COURSE_DESCR_AR"]))?string.Empty:(System.String)reader["COURSE_DESCR_AR"];
					entity.EntCoursePkgHdrId = (System.Decimal)reader[((int)VwGetUniversityRequirementsCoursesColumn.EntCoursePkgHdrId)];
					//entity.EntCoursePkgHdrId = (Convert.IsDBNull(reader["ENT_COURSE_PKG_HDR_ID"]))?0.0m:(System.Decimal)reader["ENT_COURSE_PKG_HDR_ID"];
					entity.MajorId = (System.Decimal)reader[((int)VwGetUniversityRequirementsCoursesColumn.MajorId)];
					//entity.MajorId = (Convert.IsDBNull(reader["MajorID"]))?0.0m:(System.Decimal)reader["MajorID"];
					entity.AcadPlanYearId = (reader.IsDBNull(((int)VwGetUniversityRequirementsCoursesColumn.AcadPlanYearId)))?null:(System.Decimal?)reader[((int)VwGetUniversityRequirementsCoursesColumn.AcadPlanYearId)];
					//entity.AcadPlanYearId = (Convert.IsDBNull(reader["AcadPlanYearID"]))?0.0m:(System.Decimal?)reader["AcadPlanYearID"];
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
		/// Refreshes the <see cref="VwGetUniversityRequirementsCourses"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwGetUniversityRequirementsCourses"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwGetUniversityRequirementsCourses entity)
		{
			reader.Read();
			entity.EdCourseId = (reader.IsDBNull(((int)VwGetUniversityRequirementsCoursesColumn.EdCourseId)))?null:(System.Decimal?)reader[((int)VwGetUniversityRequirementsCoursesColumn.EdCourseId)];
			//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal?)reader["ED_COURSE_ID"];
			entity.CourseCode = (System.String)reader[((int)VwGetUniversityRequirementsCoursesColumn.CourseCode)];
			//entity.CourseCode = (Convert.IsDBNull(reader["COURSE_CODE"]))?string.Empty:(System.String)reader["COURSE_CODE"];
			entity.CourseDescrAr = (System.String)reader[((int)VwGetUniversityRequirementsCoursesColumn.CourseDescrAr)];
			//entity.CourseDescrAr = (Convert.IsDBNull(reader["COURSE_DESCR_AR"]))?string.Empty:(System.String)reader["COURSE_DESCR_AR"];
			entity.EntCoursePkgHdrId = (System.Decimal)reader[((int)VwGetUniversityRequirementsCoursesColumn.EntCoursePkgHdrId)];
			//entity.EntCoursePkgHdrId = (Convert.IsDBNull(reader["ENT_COURSE_PKG_HDR_ID"]))?0.0m:(System.Decimal)reader["ENT_COURSE_PKG_HDR_ID"];
			entity.MajorId = (System.Decimal)reader[((int)VwGetUniversityRequirementsCoursesColumn.MajorId)];
			//entity.MajorId = (Convert.IsDBNull(reader["MajorID"]))?0.0m:(System.Decimal)reader["MajorID"];
			entity.AcadPlanYearId = (reader.IsDBNull(((int)VwGetUniversityRequirementsCoursesColumn.AcadPlanYearId)))?null:(System.Decimal?)reader[((int)VwGetUniversityRequirementsCoursesColumn.AcadPlanYearId)];
			//entity.AcadPlanYearId = (Convert.IsDBNull(reader["AcadPlanYearID"]))?0.0m:(System.Decimal?)reader["AcadPlanYearID"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwGetUniversityRequirementsCourses"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwGetUniversityRequirementsCourses"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwGetUniversityRequirementsCourses entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseId = (Convert.IsDBNull(dataRow["ED_COURSE_ID"]))?0.0m:(System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.CourseCode = (Convert.IsDBNull(dataRow["COURSE_CODE"]))?string.Empty:(System.String)dataRow["COURSE_CODE"];
			entity.CourseDescrAr = (Convert.IsDBNull(dataRow["COURSE_DESCR_AR"]))?string.Empty:(System.String)dataRow["COURSE_DESCR_AR"];
			entity.EntCoursePkgHdrId = (Convert.IsDBNull(dataRow["ENT_COURSE_PKG_HDR_ID"]))?0.0m:(System.Decimal)dataRow["ENT_COURSE_PKG_HDR_ID"];
			entity.MajorId = (Convert.IsDBNull(dataRow["MajorID"]))?0.0m:(System.Decimal)dataRow["MajorID"];
			entity.AcadPlanYearId = (Convert.IsDBNull(dataRow["AcadPlanYearID"]))?0.0m:(System.Decimal?)dataRow["AcadPlanYearID"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwGetUniversityRequirementsCoursesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwGetUniversityRequirementsCourses"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwGetUniversityRequirementsCoursesFilterBuilder : SqlFilterBuilder<VwGetUniversityRequirementsCoursesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwGetUniversityRequirementsCoursesFilterBuilder class.
		/// </summary>
		public VwGetUniversityRequirementsCoursesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwGetUniversityRequirementsCoursesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwGetUniversityRequirementsCoursesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwGetUniversityRequirementsCoursesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwGetUniversityRequirementsCoursesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwGetUniversityRequirementsCoursesFilterBuilder

	#region VwGetUniversityRequirementsCoursesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwGetUniversityRequirementsCourses"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwGetUniversityRequirementsCoursesParameterBuilder : ParameterizedSqlFilterBuilder<VwGetUniversityRequirementsCoursesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwGetUniversityRequirementsCoursesParameterBuilder class.
		/// </summary>
		public VwGetUniversityRequirementsCoursesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwGetUniversityRequirementsCoursesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwGetUniversityRequirementsCoursesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwGetUniversityRequirementsCoursesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwGetUniversityRequirementsCoursesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwGetUniversityRequirementsCoursesParameterBuilder
	
	#region VwGetUniversityRequirementsCoursesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwGetUniversityRequirementsCourses"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwGetUniversityRequirementsCoursesSortBuilder : SqlSortBuilder<VwGetUniversityRequirementsCoursesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwGetUniversityRequirementsCoursesSqlSortBuilder class.
		/// </summary>
		public VwGetUniversityRequirementsCoursesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwGetUniversityRequirementsCoursesSortBuilder

} // end namespace
