#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScScheduleDtl"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScScheduleDtlProvider: SqlScScheduleDtlProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScScheduleDtlProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScScheduleDtlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        public override DataTable GetCourseSectionStudentsAbsence(TransactionManager transactionManager, decimal? asCodeDegreeClassId, decimal edAcadYearId,
           decimal edCodeSemesterId, decimal? edCourseId, decimal? entityMainId, decimal? scScheduleDtlId, decimal? saStfMemberId, decimal? absenceSeqNo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseSectionStudentsAbsence", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AsCodeClassDegreeId", DbType.Decimal, asCodeDegreeClassId.HasValue ? (object)asCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, edCourseId.HasValue ? (object)edCourseId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, entityMainId.HasValue ? (object)entityMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, scScheduleDtlId.HasValue ? (object)scScheduleDtlId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, saStfMemberId.HasValue ? (object)saStfMemberId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@SeqNo", DbType.Decimal, absenceSeqNo.HasValue ? (object)absenceSeqNo : DBNull.Value);

            //Create Collection
            DataSet ds = null;

            try
            {
                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public override DataTable GetCourseSectionStudents(TransactionManager transactionManager, decimal? asCodeDegreeClassId, decimal edAcadYearId,
            decimal edCodeSemesterId, decimal? edCourseId, decimal? entityMainId, decimal? scScheduleDtlId, decimal? saStfMemberId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseSectionStudents", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AsCodeClassDegreeId", DbType.Decimal, asCodeDegreeClassId.HasValue ? (object)asCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, edCourseId.HasValue ? (object)edCourseId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, entityMainId.HasValue ? (object)entityMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, scScheduleDtlId.HasValue ? (object)scScheduleDtlId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, saStfMemberId.HasValue ? (object)saStfMemberId : DBNull.Value);

            //Create Collection
            DataSet ds = null;

            try
            {
                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public override DataTable GetCourseSectionsForRegisterEarly(TransactionManager transactionManager, decimal EdStudId, decimal AsFacultyInfoId, decimal As_Code_Degree_Id, decimal ED_ACAD_YEAR_ID, decimal ED_CODE_SEMESTER_ID, decimal edCourseId, decimal userType, decimal actionType, decimal? AsCodeDegreeClassId, decimal? CrsRegTypeID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseSectionsForRegisterEarly", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, EdStudId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@As_Code_Degree_Id", DbType.Decimal, As_Code_Degree_Id);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@EdCrsRegTypeID", DbType.Decimal, CrsRegTypeID);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, edCourseId);
            database.AddInParameter(commandWrapper, "@USER_TYPE", DbType.Decimal, userType);
            database.AddInParameter(commandWrapper, "@ActionType", DbType.Decimal, actionType);
            
            if (AsCodeDegreeClassId.HasValue)
              database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId.Value);


            //Create Collection
            DataSet ds = null;

            try
            {
                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public override DataTable GetCourseSectionsForRegister(TransactionManager transactionManager, decimal edStudSemesterId, decimal edCourseId, decimal userType, decimal actionType, decimal? AsCodeDegreeClassId, decimal? CrsRegTypeID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseSectionsForRegister", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, edStudSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, edCourseId);
            database.AddInParameter(commandWrapper, "@USER_TYPE", DbType.Decimal, userType);
            database.AddInParameter(commandWrapper, "@ActionType", DbType.Decimal, actionType);
            //database.AddInParameter(commandWrapper, "@EdCrsRegTypeID", DbType.Decimal, CrsRegTypeID);
            if (AsCodeDegreeClassId.HasValue)
              database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId.Value);


            //Create Collection
            DataSet ds = null;

            try
            {
                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }


        public override DataTable CrsRegisterFindSections(TransactionManager transactionManager, decimal edStudSemesterId, decimal edCourseId, decimal userType, decimal EntCrsPkgHdrID, decimal? EdAcadYearId, decimal? EdCodeSemesterID, decimal? ActionType, decimal? CrsRegTypeID, decimal? edCourseExpHdrID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CrsRegisterFindSections", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, edStudSemesterId);
            database.AddInParameter(commandWrapper, "@USER_TYPE", DbType.Decimal, userType);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, edCourseId);
            database.AddInParameter(commandWrapper, "@EntCrsPkgHdrID", DbType.Decimal, EntCrsPkgHdrID);
            //if (AsCodeDegreeClassId.HasValue)
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@ActionType", DbType.Decimal, ActionType);
            database.AddInParameter(commandWrapper, "@EdCrsRegTypeID", DbType.Decimal, CrsRegTypeID);
            database.AddInParameter(commandWrapper, "@EdCourseExpHdrID", DbType.Decimal, edCourseExpHdrID);
            //Create Collection

            DataSet ds = null;

            try
            {
                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }


        public override DataTable GetAllForReport(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId, decimal EdCourseId,decimal GroupCodeId=0, string EdCoursesIds = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SCHEDULE_DTL_SearchForReport", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);

            database.AddInParameter(commandWrapper, "@EdCourseIds", DbType.String, EdCoursesIds);
            //eman  date:16-5-2022 tfs:18415
            
            database.AddInParameter(commandWrapper, "@GroupCodeId", DbType.Decimal, GroupCodeId);
            
            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");

            table.Columns.Add("ScheduleName_TeachingMethod_AR");
            table.Columns.Add("ScheduleName_TeachingMethod_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }
        //kamela,12924, Overload for function GetAllCourseGroups to take gender in css case.
        public override DataTable GetAllCourseGroups(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EdCourseId, decimal TeachingMethodId,decimal? GenderId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CourseGroups", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);          
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@TeachingMethodId", DbType.Decimal, TeachingMethodId);
            database.AddInParameter(commandWrapper, "@Gender", DbType.Decimal, GenderId.HasValue ? GenderId : null);


            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("ED_CDE_TCHNG_MTHD_ID");
            table.Columns.Add("TEACHING_DESCR_AR");
            table.Columns.Add("TEACHING_DESCR_EN");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_ID");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("NoSeats");
            table.Columns.Add("NO_STUD_MAX");
            table.Columns.Add("NO_STUDENTS");
            table.Columns.Add("NoSeatsOcupied");
            table.Columns.Add("SA_STF_MAMBER_ID");
            table.Columns.Add("Gender_AR");
            table.Columns.Add("Gender_EN");
            table.Columns.Add("GenderID");


            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        public override DataTable GetAllCourseGroups(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EdCourseId, decimal TeachingMethodId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CourseGroups", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@TeachingMethodId", DbType.Decimal, TeachingMethodId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("ED_CDE_TCHNG_MTHD_ID");
            table.Columns.Add("TEACHING_DESCR_AR");
            table.Columns.Add("TEACHING_DESCR_EN");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_ID");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("NoSeats");
            table.Columns.Add("NO_STUD_MAX");
            table.Columns.Add("NO_STUDENTS");
            table.Columns.Add("NoSeatsOcupied");
            table.Columns.Add("SA_STF_MAMBER_ID");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }
        public override DataTable GetAllCourseGroups(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EdCourseId,decimal TeachingMethodId, decimal? IsClosed, decimal ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CourseGroups", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@TeachingMethodId", DbType.Decimal, TeachingMethodId);
            if (IsClosed.HasValue)
            database.AddInParameter(commandWrapper, "@IsClosed", DbType.Decimal, IsClosed);
            if(ScScheduleDtlId!=0)
                database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("ED_CDE_TCHNG_MTHD_ID");
            table.Columns.Add("TEACHING_DESCR_AR");
            table.Columns.Add("TEACHING_DESCR_EN");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_ID");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("NoSeats");
            table.Columns.Add("NO_STUD_MAX");
            table.Columns.Add("NO_STUDENTS");
            table.Columns.Add("NoSeatsOcupied");
            table.Columns.Add("SA_STF_MAMBER_ID");
            //ADDED BY esraa yousef 17890 tfs cat 17-2-2022 as return from stored so serial and date from and date to not display 
            table.Columns.Add("Gender_AR");
            table.Columns.Add("Gender_EN");
            table.Columns.Add("GenderID");
            //end 
            table.Columns.Add("Serial_NO");
            table.Columns.Add("FROM_DATE");
            table.Columns.Add("TO_DATE");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString()
                                         , reader[11].ToString()  , reader[12].ToString() , reader[13].ToString() , reader[14].ToString() , reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString()};
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }
        public override DataTable GetAllStudGroups(TransactionManager transactionManager, decimal ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudGroups", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("StudCode");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("LEVEL_AR");
            table.Columns.Add("LEVEL_EN");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("EdStudId");
            table.Columns.Add("ED_STUD_GROUP_ID");
            table.Columns.Add("IsCourseApproved");
            //kamela , Get Major and minor of studnt if exist 
            table.Columns.Add("Major_AR");
            table.Columns.Add("Major_EN");
            table.Columns.Add("MINOR_AR");
            table.Columns.Add("MINOR_EN");
            //end

            table.Columns.Add("Mother_ID");//added by esraa yousef 18786 22-6-2022 eue 



            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                while (reader.Read())
                {
                    object[] items = { reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()
                                         , reader[6].ToString(), reader[7].ToString(), reader[0].ToString(), reader[8].ToString(), reader[9].ToString()
                                     , reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(),reader[14].ToString()
                                     };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }
        public override DataTable GetAllStudsInCourseGroups(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EdCourseId, decimal EdCodeCourseTeachingId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudsInCourseGroups", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseTeachingId", DbType.Decimal, EdCodeCourseTeachingId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }
        public override DataTable GetCourseDays(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal EdCourseID, decimal ScScheduleDtlID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SCHEDULE_DTL_GetCourseDays", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, EdCourseID);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlID", DbType.Decimal, ScScheduleDtlID);

            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }
        public override DataTable GetStaffDays(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal SaStfMemberId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SCHEDULE_DTL_GetStaffDays", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, SaStfMemberId);

            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }
        public override string IsGroupValidToAllocate(TransactionManager transactionManager, decimal ScScheduleDtlId, decimal CheckOnNumbers)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.IsGroupValidToAllocate", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@CheckOnNumbers", DbType.Decimal, CheckOnNumbers);
            database.AddOutParameter(commandWrapper, "@Result", DbType.String, 1000);



            int results = 0;

            //Provider Data Requesting Command Event
            //OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_STUD_InsertWithIdOut", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return commandWrapper.Parameters["@Result"].Value.ToString();
        }

        public override DataTable GetAllForScheduleMaintain(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal EdCourseID, decimal EntMainID, decimal ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SCHEDULE_DTL_SearchForMaintain", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, EdCourseID);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainID);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);

            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }
        public override DataTable ReplaceDropScSchedule(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, 
            decimal AsFacultyInfoID, decimal EntMainID, decimal ScScheduleDtlId,decimal ACCUM_CH1, decimal  ACCUM_CH2 ,decimal PAY_FLG, decimal? AsCodeDegreeClassId=null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ReplaceDropScSchedule", this.UseStoredProcedure);
        
            
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, EdCodeSemesterID);

            if (AsFacultyInfoID != -1)
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, AsFacultyInfoID);
            if (EntMainID!=0)
            database.AddInParameter(commandWrapper, "@ENT_MAIN_ID", DbType.Decimal, EntMainID);

            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_DTL_ID", DbType.Decimal, ScScheduleDtlId);

            if (ACCUM_CH1 != 0 && ACCUM_CH2 != 0)
            {
                database.AddInParameter(commandWrapper, "@ACCUM_CH1", DbType.Decimal, ACCUM_CH1);
                database.AddInParameter(commandWrapper, "@ACCUM_CH2", DbType.Decimal, ACCUM_CH2);
            }
            if (PAY_FLG!=-1)
            database.AddInParameter(commandWrapper, "@PAY_FLG", DbType.Decimal, PAY_FLG);
            if(AsCodeDegreeClassId.HasValue)//walaa 12/10/2022
                database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);
            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        public override DataTable GetScheduleExamPlaces(TransactionManager transactionManager, decimal ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetScheduleExamPlaces", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);

            

            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }
        public override DataTable GetSEctioStudCount(TransactionManager transactionManager, decimal ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSEctioStudCount", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_DTL_ID", DbType.Decimal, ScScheduleDtlId);



            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        public override DataTable GetStudsOnSectionByCourseStatus(TransactionManager transactionManager, decimal ScScheduleDtlId, decimal ED_CODE_COURSE_STATUS_ID,
            decimal ED_CODE_SEMESTER_ID, decimal ED_ACAD_YEAR_ID, decimal AS_FACULTY_INFO_ID, decimal OrderBy)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudsOnSectionByCourseStatus", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_DTL_ID", DbType.Decimal, ScScheduleDtlId);

            database.AddInParameter(commandWrapper, "@ED_CODE_COURSE_STATUS_ID", DbType.Decimal, ED_CODE_COURSE_STATUS_ID);

            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, ED_CODE_SEMESTER_ID);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, ED_ACAD_YEAR_ID);

         //   database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, AS_FACULTY_INFO_ID);

            database.AddInParameter(commandWrapper, "@OrderBy", DbType.Decimal, OrderBy);





            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }
        public override TList<ScScheduleDtl> SP_GetGroupByTchngMethd(TransactionManager transactionManager, decimal _EdCodeCourseTchng)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SP_GetGroupByTchngMethd", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ED_CODE_COURSE_TEACHING_ID", DbType.Decimal, _EdCodeCourseTchng);

            IDataReader reader = null;
            TList<ScScheduleDtl> rows = new TList<ScScheduleDtl>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SP_GetGroupByTchngMethd", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }
                int start = 0;
                int pageLength = int.MaxValue;
                int count = int.MaxValue;
                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "SP_GetGroupByTchngMethd", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        //Esraa Ali     27-5-2020     13648
        public override DataTable INTEG_GetSection(System.Decimal _FacID, System.Decimal _YearID, System.Decimal _SemID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.INTEG_GetSection", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FacID", DbType.Decimal, _FacID);
            database.AddInParameter(commandWrapper, "@YearID", DbType.Decimal, _YearID);
            database.AddInParameter(commandWrapper, "@SemID", DbType.Decimal, _SemID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SIS ID");
            table.Columns.Add("School SIS ID");
            table.Columns.Add("Section Name");
            
            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWrapper = null;
            }
            return table;
        }

        // manar 19-01-2022- tfs #17575
        public override DataTable GetSchduleDates(TransactionManager transactionManager, decimal ScScheduleDtlID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SCHEDULE_DTL_GetSchduleDates", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlID", DbType.Decimal, ScScheduleDtlID);
            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        // Menna 31012022
        public override DataTable CheckScheduleDateConflict(TransactionManager transactionManager, DateTime RegDateFrom, DateTime RegDateTo, decimal _StudSemesterId, decimal _ScheduleDtlID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CheckScheduleDateConflict", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@RegDateFrom", DbType.DateTime, RegDateFrom);
            database.AddInParameter(commandWrapper, "@RegDateTo", DbType.DateTime, RegDateTo);
            database.AddInParameter(commandWrapper, "@StudSemesterId", DbType.Decimal, _StudSemesterId);
            database.AddInParameter(commandWrapper, "@ScheduleDtlID", DbType.Decimal, _ScheduleDtlID);
            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        public override DataTable GetCourseRegPreSections(TransactionManager transactionManager, decimal _EdStudID,decimal _EdAcadYearId, decimal _EdCodeSemesterID, decimal _AsFacultyInfoID, decimal _AsCodeDegreeID, decimal _USER_TYPE, decimal _EdCourseID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GET_STD_CRS_REG_PLN_SEC_PRE", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, _EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, _AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeID", DbType.Decimal, _AsCodeDegreeID);
            database.AddInParameter(commandWrapper, "@USER_TYPE", DbType.Decimal, _USER_TYPE);
            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _EdCourseID);
            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }
        #endregion

        #region Updated Method
        /*
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtl entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SCHEDULE_DTL_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@ScScheduleHdrId", DbType.Decimal, entity.ScScheduleHdrId);
            database.AddInParameter(commandWrapper, "@GroupDescrAr", DbType.String, entity.GroupDescrAr);
            database.AddInParameter(commandWrapper, "@GroupDescrEn", DbType.String, entity.GroupDescrEn);
            database.AddInParameter(commandWrapper, "@GroupOrder", DbType.Decimal, entity.GroupOrder);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object)entity.GsCodeGenderId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsResultApproved", DbType.Decimal, entity.IsResultApproved);
            database.AddInParameter(commandWrapper, "@NoStudents", DbType.Decimal, (entity.NoStudents.HasValue ? (object)entity.NoStudents : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NoStudWait", DbType.Decimal, (entity.NoStudWait.HasValue ? (object)entity.NoStudWait : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@OnlineFlg", DbType.Decimal, entity.OnlineFlg);
            database.AddInParameter(commandWrapper, "@IsClosed", DbType.Decimal, (entity.IsClosed.HasValue ? (object)entity.IsClosed : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NotesEmp", DbType.String, entity.NotesEmp);
            database.AddInParameter(commandWrapper, "@NoStudMax", DbType.Decimal, (entity.NoStudMax.HasValue ? (object)entity.NoStudMax : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@InternalFlg", DbType.Decimal, entity.InternalFlg);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            entity.ScScheduleDtlId = decimal.Parse(commandWrapper.Parameters["@ScScheduleDtlId"].Value.ToString());
            entity.OriginalScScheduleDtlId = entity.ScScheduleDtlId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	
        */
        #endregion
    }
}
