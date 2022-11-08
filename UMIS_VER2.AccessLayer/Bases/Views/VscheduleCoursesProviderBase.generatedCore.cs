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
	/// This class is the base class for any <see cref="VscheduleCoursesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VscheduleCoursesProviderBaseCore : EntityViewProviderBase<VscheduleCourses>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VscheduleCourses&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VscheduleCourses&gt;"/></returns>
		protected static VList&lt;VscheduleCourses&gt; Fill(DataSet dataSet, VList<VscheduleCourses> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VscheduleCourses>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VscheduleCourses&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VscheduleCourses>"/></returns>
		protected static VList&lt;VscheduleCourses&gt; Fill(DataTable dataTable, VList<VscheduleCourses> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VscheduleCourses c = new VscheduleCourses();
					c.ScScheduleHdrId = (Convert.IsDBNull(row["SC_SCHEDULE_HDR_ID"]))?0.0m:(System.Decimal)row["SC_SCHEDULE_HDR_ID"];
					c.EdOfferingCourseId = (Convert.IsDBNull(row["ED_OFFERING_COURSE_ID"]))?0.0m:(System.Decimal)row["ED_OFFERING_COURSE_ID"];
					c.EdCourseId = (Convert.IsDBNull(row["ED_COURSE_ID"]))?0.0m:(System.Decimal?)row["ED_COURSE_ID"];
					c.CourseCode = (Convert.IsDBNull(row["COURSE_CODE"]))?string.Empty:(System.String)row["COURSE_CODE"];
					c.CourseDescrAr = (Convert.IsDBNull(row["COURSE_DESCR_AR"]))?string.Empty:(System.String)row["COURSE_DESCR_AR"];
					c.CourseDescrEn = (Convert.IsDBNull(row["COURSE_DESCR_EN"]))?string.Empty:(System.String)row["COURSE_DESCR_EN"];
					c.EdOfferingId = (Convert.IsDBNull(row["ED_OFFERING_ID"]))?0.0m:(System.Decimal?)row["ED_OFFERING_ID"];
					c.AsFacultyInfoId = (Convert.IsDBNull(row["AS_FACULTY_INFO_ID"]))?0.0m:(System.Decimal?)row["AS_FACULTY_INFO_ID"];
					c.EdAcadYearId = (Convert.IsDBNull(row["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal)row["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (Convert.IsDBNull(row["ED_CODE_SEMESTER_ID"]))?0.0m:(System.Decimal?)row["ED_CODE_SEMESTER_ID"];
					c.EntMainId = (Convert.IsDBNull(row["ENT_MAIN_ID"]))?0.0m:(System.Decimal)row["ENT_MAIN_ID"];
					c.EdCodeCourseTeachingId = (Convert.IsDBNull(row["ED_CODE_COURSE_TEACHING_ID"]))?0.0m:(System.Decimal?)row["ED_CODE_COURSE_TEACHING_ID"];
					c.EdCdeTchngMthdId = (Convert.IsDBNull(row["ED_CDE_TCHNG_MTHD_ID"]))?0.0m:(System.Decimal?)row["ED_CDE_TCHNG_MTHD_ID"];
					c.TchngMthdDescrAr = (Convert.IsDBNull(row["TchngMthdDescrAr"]))?string.Empty:(System.String)row["TchngMthdDescrAr"];
					c.TchngMthdDescrEn = (Convert.IsDBNull(row["TchngMthdDescrEn"]))?string.Empty:(System.String)row["TchngMthdDescrEn"];
					c.ScScheduleDtlId = (Convert.IsDBNull(row["SC_SCHEDULE_DTL_ID"]))?0.0m:(System.Decimal)row["SC_SCHEDULE_DTL_ID"];
					c.GroupDescrAr = (Convert.IsDBNull(row["GROUP_DESCR_AR"]))?string.Empty:(System.String)row["GROUP_DESCR_AR"];
					c.GroupDescrEn = (Convert.IsDBNull(row["GROUP_DESCR_EN"]))?string.Empty:(System.String)row["GROUP_DESCR_EN"];
					c.GroupOrder = (Convert.IsDBNull(row["GROUP_ORDER"]))?0.0m:(System.Decimal?)row["GROUP_ORDER"];
					c.IsResultApproved = (Convert.IsDBNull(row["IS_RESULT_APPROVED"]))?0.0m:(System.Decimal)row["IS_RESULT_APPROVED"];
					c.NoStudents = (Convert.IsDBNull(row["NO_STUDENTS"]))?0.0m:(System.Decimal?)row["NO_STUDENTS"];
					c.NoStudWait = (Convert.IsDBNull(row["NO_STUD_WAIT"]))?0.0m:(System.Decimal?)row["NO_STUD_WAIT"];
					c.NoStudMax = (Convert.IsDBNull(row["NO_STUD_MAX"]))?0.0m:(System.Decimal?)row["NO_STUD_MAX"];
					c.GsCodeGenderId = (Convert.IsDBNull(row["GS_CODE_GENDER_ID"]))?0.0m:(System.Decimal?)row["GS_CODE_GENDER_ID"];
					c.GenderDescrAr = (Convert.IsDBNull(row["GENDER_DESCR_AR"]))?string.Empty:(System.String)row["GENDER_DESCR_AR"];
					c.GenderDescrEn = (Convert.IsDBNull(row["GENDER_DESCR_EN"]))?string.Empty:(System.String)row["GENDER_DESCR_EN"];
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
		/// Fill an <see cref="VList&lt;VscheduleCourses&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VscheduleCourses&gt;"/></returns>
		protected VList<VscheduleCourses> Fill(IDataReader reader, VList<VscheduleCourses> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VscheduleCourses entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VscheduleCourses>("VscheduleCourses",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VscheduleCourses();
					}
					
					entity.SuppressEntityEvents = true;

					entity.ScScheduleHdrId = (System.Decimal)reader[((int)VscheduleCoursesColumn.ScScheduleHdrId)];
					//entity.ScScheduleHdrId = (Convert.IsDBNull(reader["SC_SCHEDULE_HDR_ID"]))?0.0m:(System.Decimal)reader["SC_SCHEDULE_HDR_ID"];
					entity.EdOfferingCourseId = (System.Decimal)reader[((int)VscheduleCoursesColumn.EdOfferingCourseId)];
					//entity.EdOfferingCourseId = (Convert.IsDBNull(reader["ED_OFFERING_COURSE_ID"]))?0.0m:(System.Decimal)reader["ED_OFFERING_COURSE_ID"];
					entity.EdCourseId = (reader.IsDBNull(((int)VscheduleCoursesColumn.EdCourseId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.EdCourseId)];
					//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal?)reader["ED_COURSE_ID"];
					entity.CourseCode = (System.String)reader[((int)VscheduleCoursesColumn.CourseCode)];
					//entity.CourseCode = (Convert.IsDBNull(reader["COURSE_CODE"]))?string.Empty:(System.String)reader["COURSE_CODE"];
					entity.CourseDescrAr = (System.String)reader[((int)VscheduleCoursesColumn.CourseDescrAr)];
					//entity.CourseDescrAr = (Convert.IsDBNull(reader["COURSE_DESCR_AR"]))?string.Empty:(System.String)reader["COURSE_DESCR_AR"];
					entity.CourseDescrEn = (System.String)reader[((int)VscheduleCoursesColumn.CourseDescrEn)];
					//entity.CourseDescrEn = (Convert.IsDBNull(reader["COURSE_DESCR_EN"]))?string.Empty:(System.String)reader["COURSE_DESCR_EN"];
					entity.EdOfferingId = (reader.IsDBNull(((int)VscheduleCoursesColumn.EdOfferingId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.EdOfferingId)];
					//entity.EdOfferingId = (Convert.IsDBNull(reader["ED_OFFERING_ID"]))?0.0m:(System.Decimal?)reader["ED_OFFERING_ID"];
					entity.AsFacultyInfoId = (reader.IsDBNull(((int)VscheduleCoursesColumn.AsFacultyInfoId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.AsFacultyInfoId)];
					//entity.AsFacultyInfoId = (Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]))?0.0m:(System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					entity.EdAcadYearId = (System.Decimal)reader[((int)VscheduleCoursesColumn.EdAcadYearId)];
					//entity.EdAcadYearId = (Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal)reader["ED_ACAD_YEAR_ID"];
					entity.EdCodeSemesterId = (reader.IsDBNull(((int)VscheduleCoursesColumn.EdCodeSemesterId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.EdCodeSemesterId)];
					//entity.EdCodeSemesterId = (Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]))?0.0m:(System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					entity.EntMainId = (System.Decimal)reader[((int)VscheduleCoursesColumn.EntMainId)];
					//entity.EntMainId = (Convert.IsDBNull(reader["ENT_MAIN_ID"]))?0.0m:(System.Decimal)reader["ENT_MAIN_ID"];
					entity.EdCodeCourseTeachingId = (reader.IsDBNull(((int)VscheduleCoursesColumn.EdCodeCourseTeachingId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.EdCodeCourseTeachingId)];
					//entity.EdCodeCourseTeachingId = (Convert.IsDBNull(reader["ED_CODE_COURSE_TEACHING_ID"]))?0.0m:(System.Decimal?)reader["ED_CODE_COURSE_TEACHING_ID"];
					entity.EdCdeTchngMthdId = (reader.IsDBNull(((int)VscheduleCoursesColumn.EdCdeTchngMthdId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.EdCdeTchngMthdId)];
					//entity.EdCdeTchngMthdId = (Convert.IsDBNull(reader["ED_CDE_TCHNG_MTHD_ID"]))?0.0m:(System.Decimal?)reader["ED_CDE_TCHNG_MTHD_ID"];
					entity.TchngMthdDescrAr = (System.String)reader[((int)VscheduleCoursesColumn.TchngMthdDescrAr)];
					//entity.TchngMthdDescrAr = (Convert.IsDBNull(reader["TchngMthdDescrAr"]))?string.Empty:(System.String)reader["TchngMthdDescrAr"];
					entity.TchngMthdDescrEn = (System.String)reader[((int)VscheduleCoursesColumn.TchngMthdDescrEn)];
					//entity.TchngMthdDescrEn = (Convert.IsDBNull(reader["TchngMthdDescrEn"]))?string.Empty:(System.String)reader["TchngMthdDescrEn"];
					entity.ScScheduleDtlId = (System.Decimal)reader[((int)VscheduleCoursesColumn.ScScheduleDtlId)];
					//entity.ScScheduleDtlId = (Convert.IsDBNull(reader["SC_SCHEDULE_DTL_ID"]))?0.0m:(System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
					entity.GroupDescrAr = (System.String)reader[((int)VscheduleCoursesColumn.GroupDescrAr)];
					//entity.GroupDescrAr = (Convert.IsDBNull(reader["GROUP_DESCR_AR"]))?string.Empty:(System.String)reader["GROUP_DESCR_AR"];
					entity.GroupDescrEn = (System.String)reader[((int)VscheduleCoursesColumn.GroupDescrEn)];
					//entity.GroupDescrEn = (Convert.IsDBNull(reader["GROUP_DESCR_EN"]))?string.Empty:(System.String)reader["GROUP_DESCR_EN"];
					entity.GroupOrder = (reader.IsDBNull(((int)VscheduleCoursesColumn.GroupOrder)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.GroupOrder)];
					//entity.GroupOrder = (Convert.IsDBNull(reader["GROUP_ORDER"]))?0.0m:(System.Decimal?)reader["GROUP_ORDER"];
					entity.IsResultApproved = (System.Decimal)reader[((int)VscheduleCoursesColumn.IsResultApproved)];
					//entity.IsResultApproved = (Convert.IsDBNull(reader["IS_RESULT_APPROVED"]))?0.0m:(System.Decimal)reader["IS_RESULT_APPROVED"];
					entity.NoStudents = (reader.IsDBNull(((int)VscheduleCoursesColumn.NoStudents)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.NoStudents)];
					//entity.NoStudents = (Convert.IsDBNull(reader["NO_STUDENTS"]))?0.0m:(System.Decimal?)reader["NO_STUDENTS"];
					entity.NoStudWait = (reader.IsDBNull(((int)VscheduleCoursesColumn.NoStudWait)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.NoStudWait)];
					//entity.NoStudWait = (Convert.IsDBNull(reader["NO_STUD_WAIT"]))?0.0m:(System.Decimal?)reader["NO_STUD_WAIT"];
					entity.NoStudMax = (reader.IsDBNull(((int)VscheduleCoursesColumn.NoStudMax)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.NoStudMax)];
					//entity.NoStudMax = (Convert.IsDBNull(reader["NO_STUD_MAX"]))?0.0m:(System.Decimal?)reader["NO_STUD_MAX"];
					entity.GsCodeGenderId = (reader.IsDBNull(((int)VscheduleCoursesColumn.GsCodeGenderId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.GsCodeGenderId)];
					//entity.GsCodeGenderId = (Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]))?0.0m:(System.Decimal?)reader["GS_CODE_GENDER_ID"];
					entity.GenderDescrAr = (System.String)reader[((int)VscheduleCoursesColumn.GenderDescrAr)];
					//entity.GenderDescrAr = (Convert.IsDBNull(reader["GENDER_DESCR_AR"]))?string.Empty:(System.String)reader["GENDER_DESCR_AR"];
					entity.GenderDescrEn = (System.String)reader[((int)VscheduleCoursesColumn.GenderDescrEn)];
					//entity.GenderDescrEn = (Convert.IsDBNull(reader["GENDER_DESCR_EN"]))?string.Empty:(System.String)reader["GENDER_DESCR_EN"];
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
		/// Refreshes the <see cref="VscheduleCourses"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VscheduleCourses"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VscheduleCourses entity)
		{
			reader.Read();
			entity.ScScheduleHdrId = (System.Decimal)reader[((int)VscheduleCoursesColumn.ScScheduleHdrId)];
			//entity.ScScheduleHdrId = (Convert.IsDBNull(reader["SC_SCHEDULE_HDR_ID"]))?0.0m:(System.Decimal)reader["SC_SCHEDULE_HDR_ID"];
			entity.EdOfferingCourseId = (System.Decimal)reader[((int)VscheduleCoursesColumn.EdOfferingCourseId)];
			//entity.EdOfferingCourseId = (Convert.IsDBNull(reader["ED_OFFERING_COURSE_ID"]))?0.0m:(System.Decimal)reader["ED_OFFERING_COURSE_ID"];
			entity.EdCourseId = (reader.IsDBNull(((int)VscheduleCoursesColumn.EdCourseId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.EdCourseId)];
			//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal?)reader["ED_COURSE_ID"];
			entity.CourseCode = (System.String)reader[((int)VscheduleCoursesColumn.CourseCode)];
			//entity.CourseCode = (Convert.IsDBNull(reader["COURSE_CODE"]))?string.Empty:(System.String)reader["COURSE_CODE"];
			entity.CourseDescrAr = (System.String)reader[((int)VscheduleCoursesColumn.CourseDescrAr)];
			//entity.CourseDescrAr = (Convert.IsDBNull(reader["COURSE_DESCR_AR"]))?string.Empty:(System.String)reader["COURSE_DESCR_AR"];
			entity.CourseDescrEn = (System.String)reader[((int)VscheduleCoursesColumn.CourseDescrEn)];
			//entity.CourseDescrEn = (Convert.IsDBNull(reader["COURSE_DESCR_EN"]))?string.Empty:(System.String)reader["COURSE_DESCR_EN"];
			entity.EdOfferingId = (reader.IsDBNull(((int)VscheduleCoursesColumn.EdOfferingId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.EdOfferingId)];
			//entity.EdOfferingId = (Convert.IsDBNull(reader["ED_OFFERING_ID"]))?0.0m:(System.Decimal?)reader["ED_OFFERING_ID"];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)VscheduleCoursesColumn.AsFacultyInfoId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.AsFacultyInfoId)];
			//entity.AsFacultyInfoId = (Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]))?0.0m:(System.Decimal?)reader["AS_FACULTY_INFO_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)VscheduleCoursesColumn.EdAcadYearId)];
			//entity.EdAcadYearId = (Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal)reader["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)VscheduleCoursesColumn.EdCodeSemesterId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.EdCodeSemesterId)];
			//entity.EdCodeSemesterId = (Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]))?0.0m:(System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)VscheduleCoursesColumn.EntMainId)];
			//entity.EntMainId = (Convert.IsDBNull(reader["ENT_MAIN_ID"]))?0.0m:(System.Decimal)reader["ENT_MAIN_ID"];
			entity.EdCodeCourseTeachingId = (reader.IsDBNull(((int)VscheduleCoursesColumn.EdCodeCourseTeachingId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.EdCodeCourseTeachingId)];
			//entity.EdCodeCourseTeachingId = (Convert.IsDBNull(reader["ED_CODE_COURSE_TEACHING_ID"]))?0.0m:(System.Decimal?)reader["ED_CODE_COURSE_TEACHING_ID"];
			entity.EdCdeTchngMthdId = (reader.IsDBNull(((int)VscheduleCoursesColumn.EdCdeTchngMthdId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.EdCdeTchngMthdId)];
			//entity.EdCdeTchngMthdId = (Convert.IsDBNull(reader["ED_CDE_TCHNG_MTHD_ID"]))?0.0m:(System.Decimal?)reader["ED_CDE_TCHNG_MTHD_ID"];
			entity.TchngMthdDescrAr = (System.String)reader[((int)VscheduleCoursesColumn.TchngMthdDescrAr)];
			//entity.TchngMthdDescrAr = (Convert.IsDBNull(reader["TchngMthdDescrAr"]))?string.Empty:(System.String)reader["TchngMthdDescrAr"];
			entity.TchngMthdDescrEn = (System.String)reader[((int)VscheduleCoursesColumn.TchngMthdDescrEn)];
			//entity.TchngMthdDescrEn = (Convert.IsDBNull(reader["TchngMthdDescrEn"]))?string.Empty:(System.String)reader["TchngMthdDescrEn"];
			entity.ScScheduleDtlId = (System.Decimal)reader[((int)VscheduleCoursesColumn.ScScheduleDtlId)];
			//entity.ScScheduleDtlId = (Convert.IsDBNull(reader["SC_SCHEDULE_DTL_ID"]))?0.0m:(System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
			entity.GroupDescrAr = (System.String)reader[((int)VscheduleCoursesColumn.GroupDescrAr)];
			//entity.GroupDescrAr = (Convert.IsDBNull(reader["GROUP_DESCR_AR"]))?string.Empty:(System.String)reader["GROUP_DESCR_AR"];
			entity.GroupDescrEn = (System.String)reader[((int)VscheduleCoursesColumn.GroupDescrEn)];
			//entity.GroupDescrEn = (Convert.IsDBNull(reader["GROUP_DESCR_EN"]))?string.Empty:(System.String)reader["GROUP_DESCR_EN"];
			entity.GroupOrder = (reader.IsDBNull(((int)VscheduleCoursesColumn.GroupOrder)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.GroupOrder)];
			//entity.GroupOrder = (Convert.IsDBNull(reader["GROUP_ORDER"]))?0.0m:(System.Decimal?)reader["GROUP_ORDER"];
			entity.IsResultApproved = (System.Decimal)reader[((int)VscheduleCoursesColumn.IsResultApproved)];
			//entity.IsResultApproved = (Convert.IsDBNull(reader["IS_RESULT_APPROVED"]))?0.0m:(System.Decimal)reader["IS_RESULT_APPROVED"];
			entity.NoStudents = (reader.IsDBNull(((int)VscheduleCoursesColumn.NoStudents)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.NoStudents)];
			//entity.NoStudents = (Convert.IsDBNull(reader["NO_STUDENTS"]))?0.0m:(System.Decimal?)reader["NO_STUDENTS"];
			entity.NoStudWait = (reader.IsDBNull(((int)VscheduleCoursesColumn.NoStudWait)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.NoStudWait)];
			//entity.NoStudWait = (Convert.IsDBNull(reader["NO_STUD_WAIT"]))?0.0m:(System.Decimal?)reader["NO_STUD_WAIT"];
			entity.NoStudMax = (reader.IsDBNull(((int)VscheduleCoursesColumn.NoStudMax)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.NoStudMax)];
			//entity.NoStudMax = (Convert.IsDBNull(reader["NO_STUD_MAX"]))?0.0m:(System.Decimal?)reader["NO_STUD_MAX"];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)VscheduleCoursesColumn.GsCodeGenderId)))?null:(System.Decimal?)reader[((int)VscheduleCoursesColumn.GsCodeGenderId)];
			//entity.GsCodeGenderId = (Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]))?0.0m:(System.Decimal?)reader["GS_CODE_GENDER_ID"];
			entity.GenderDescrAr = (System.String)reader[((int)VscheduleCoursesColumn.GenderDescrAr)];
			//entity.GenderDescrAr = (Convert.IsDBNull(reader["GENDER_DESCR_AR"]))?string.Empty:(System.String)reader["GENDER_DESCR_AR"];
			entity.GenderDescrEn = (System.String)reader[((int)VscheduleCoursesColumn.GenderDescrEn)];
			//entity.GenderDescrEn = (Convert.IsDBNull(reader["GENDER_DESCR_EN"]))?string.Empty:(System.String)reader["GENDER_DESCR_EN"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VscheduleCourses"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VscheduleCourses"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VscheduleCourses entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScScheduleHdrId = (Convert.IsDBNull(dataRow["SC_SCHEDULE_HDR_ID"]))?0.0m:(System.Decimal)dataRow["SC_SCHEDULE_HDR_ID"];
			entity.EdOfferingCourseId = (Convert.IsDBNull(dataRow["ED_OFFERING_COURSE_ID"]))?0.0m:(System.Decimal)dataRow["ED_OFFERING_COURSE_ID"];
			entity.EdCourseId = (Convert.IsDBNull(dataRow["ED_COURSE_ID"]))?0.0m:(System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.CourseCode = (Convert.IsDBNull(dataRow["COURSE_CODE"]))?string.Empty:(System.String)dataRow["COURSE_CODE"];
			entity.CourseDescrAr = (Convert.IsDBNull(dataRow["COURSE_DESCR_AR"]))?string.Empty:(System.String)dataRow["COURSE_DESCR_AR"];
			entity.CourseDescrEn = (Convert.IsDBNull(dataRow["COURSE_DESCR_EN"]))?string.Empty:(System.String)dataRow["COURSE_DESCR_EN"];
			entity.EdOfferingId = (Convert.IsDBNull(dataRow["ED_OFFERING_ID"]))?0.0m:(System.Decimal?)dataRow["ED_OFFERING_ID"];
			entity.AsFacultyInfoId = (Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]))?0.0m:(System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdAcadYearId = (Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]))?0.0m:(System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EntMainId = (Convert.IsDBNull(dataRow["ENT_MAIN_ID"]))?0.0m:(System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdCodeCourseTeachingId = (Convert.IsDBNull(dataRow["ED_CODE_COURSE_TEACHING_ID"]))?0.0m:(System.Decimal?)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.EdCdeTchngMthdId = (Convert.IsDBNull(dataRow["ED_CDE_TCHNG_MTHD_ID"]))?0.0m:(System.Decimal?)dataRow["ED_CDE_TCHNG_MTHD_ID"];
			entity.TchngMthdDescrAr = (Convert.IsDBNull(dataRow["TchngMthdDescrAr"]))?string.Empty:(System.String)dataRow["TchngMthdDescrAr"];
			entity.TchngMthdDescrEn = (Convert.IsDBNull(dataRow["TchngMthdDescrEn"]))?string.Empty:(System.String)dataRow["TchngMthdDescrEn"];
			entity.ScScheduleDtlId = (Convert.IsDBNull(dataRow["SC_SCHEDULE_DTL_ID"]))?0.0m:(System.Decimal)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.GroupDescrAr = (Convert.IsDBNull(dataRow["GROUP_DESCR_AR"]))?string.Empty:(System.String)dataRow["GROUP_DESCR_AR"];
			entity.GroupDescrEn = (Convert.IsDBNull(dataRow["GROUP_DESCR_EN"]))?string.Empty:(System.String)dataRow["GROUP_DESCR_EN"];
			entity.GroupOrder = (Convert.IsDBNull(dataRow["GROUP_ORDER"]))?0.0m:(System.Decimal?)dataRow["GROUP_ORDER"];
			entity.IsResultApproved = (Convert.IsDBNull(dataRow["IS_RESULT_APPROVED"]))?0.0m:(System.Decimal)dataRow["IS_RESULT_APPROVED"];
			entity.NoStudents = (Convert.IsDBNull(dataRow["NO_STUDENTS"]))?0.0m:(System.Decimal?)dataRow["NO_STUDENTS"];
			entity.NoStudWait = (Convert.IsDBNull(dataRow["NO_STUD_WAIT"]))?0.0m:(System.Decimal?)dataRow["NO_STUD_WAIT"];
			entity.NoStudMax = (Convert.IsDBNull(dataRow["NO_STUD_MAX"]))?0.0m:(System.Decimal?)dataRow["NO_STUD_MAX"];
			entity.GsCodeGenderId = (Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]))?0.0m:(System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.GenderDescrAr = (Convert.IsDBNull(dataRow["GENDER_DESCR_AR"]))?string.Empty:(System.String)dataRow["GENDER_DESCR_AR"];
			entity.GenderDescrEn = (Convert.IsDBNull(dataRow["GENDER_DESCR_EN"]))?string.Empty:(System.String)dataRow["GENDER_DESCR_EN"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VscheduleCoursesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VscheduleCourses"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VscheduleCoursesFilterBuilder : SqlFilterBuilder<VscheduleCoursesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VscheduleCoursesFilterBuilder class.
		/// </summary>
		public VscheduleCoursesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VscheduleCoursesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VscheduleCoursesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VscheduleCoursesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VscheduleCoursesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VscheduleCoursesFilterBuilder

	#region VscheduleCoursesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VscheduleCourses"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VscheduleCoursesParameterBuilder : ParameterizedSqlFilterBuilder<VscheduleCoursesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VscheduleCoursesParameterBuilder class.
		/// </summary>
		public VscheduleCoursesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VscheduleCoursesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VscheduleCoursesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VscheduleCoursesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VscheduleCoursesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VscheduleCoursesParameterBuilder
	
	#region VscheduleCoursesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VscheduleCourses"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VscheduleCoursesSortBuilder : SqlSortBuilder<VscheduleCoursesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VscheduleCoursesSqlSortBuilder class.
		/// </summary>
		public VscheduleCoursesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VscheduleCoursesSortBuilder

} // end namespace
