#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScScheduleHdr"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScScheduleHdrProvider: SqlScScheduleHdrProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScScheduleHdrProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScScheduleHdrProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        public override DataTable GetScheduleCourses(TransactionManager transactionManager, System.Decimal asFacultyInfoId, System.Decimal? entityMainId, System.Decimal EdAcadYearFromId, System.Decimal EdCodeSemesterFromId, System.Decimal EdAcadYearToId, System.Decimal EdCodeSemesterToId, System.Decimal SC_SCHEDULE_HDR_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetScheduleCourses", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, entityMainId.HasValue ? (object)entityMainId.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearFromId", DbType.Decimal, EdAcadYearFromId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterFromId", DbType.Decimal, EdCodeSemesterFromId);
            database.AddInParameter(commandWrapper, "@EdAcadYearToId", DbType.Decimal, EdAcadYearToId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterToId", DbType.Decimal, EdCodeSemesterToId);
            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_HDR_ID", DbType.Decimal, SC_SCHEDULE_HDR_ID);

            

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_OFFERING_COURSE_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_En");
            table.Columns.Add("SC_SCHEDULE_HDR_ID");



            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override DataTable BulkCopyCourseSection(TransactionManager transactionManager, System.Decimal asFacultyInfoId, System.Decimal? entityMainId, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal? edCourseId, bool staffFlg, bool hallFlg, bool examFlg, bool examSupervisorFlg, System.Decimal CurrentEdCodeSemesterId, System.Decimal CurrentEdAcadYearId, System.Decimal AsCodeDegreeClassID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Bulk_Copy_Course_Section", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, entityMainId.HasValue ? (object)entityMainId.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, edCourseId.HasValue ? (object)edCourseId.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@StaffFlg", DbType.Decimal, staffFlg ? 1 : 0);
            database.AddInParameter(commandWrapper, "@HallsFlg", DbType.Decimal, hallFlg ? 1 : 0);
            database.AddInParameter(commandWrapper, "@ExamFlg", DbType.Decimal, examFlg ? 1 : 0);
            database.AddInParameter(commandWrapper, "@ExamSupervisorFlg", DbType.Decimal, examSupervisorFlg ? 1 : 0);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterIdNew", DbType.Decimal, CurrentEdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearIdNew", DbType.Decimal, CurrentEdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassID", DbType.Decimal, AsCodeDegreeClassID);

            IDataReader reader = null;
            //DataTable table = new DataTable();
            //table.Columns.Add("CourseCode");
            //table.Columns.Add("TchngMthdAr");
            //table.Columns.Add("TchngMthEn");
            //table.Columns.Add("OperationName");
            //table.Columns.Add("MsgAr");
            //table.Columns.Add("MsgEn");
            //table.Columns.Add("flag");

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

        public override DataTable GetFreeHallsForVS(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.Decimal campusId, System.Decimal buildingId, System.Decimal hallTypeId, System.String datesTimes)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHK_ADD_HALL_TO_VS", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, edCodeSemId);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, edCourseId);
            database.AddInParameter(commandWrapper, "@GS_CDE_CAMPUS_ID", DbType.Decimal, campusId);
            database.AddInParameter(commandWrapper, "@SC_BUILDING_ID", DbType.Decimal, buildingId);
            database.AddInParameter(commandWrapper, "@SC_CDE_HALL_TYPE_ID", DbType.Decimal, hallTypeId);
            database.AddInParameter(commandWrapper, "@DATES_TIMES", DbType.Xml, datesTimes);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_BUILDING_ID");
            table.Columns.Add("BUILD_CODE");
            table.Columns.Add("BuildingAr");
            table.Columns.Add("BuildingEn");
            table.Columns.Add("SC_HALL_ID");
            table.Columns.Add("HALL_CODE");
            table.Columns.Add("HallAr");
            table.Columns.Add("CAPACITY");
            table.Columns.Add("IS_SHARED");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("HallEn");
            table.Columns.Add("EXM_CAPCITY");
            table.Columns.Add("CAPACITY_MAX");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString() };
                        table.Rows.Add(items);
                    }
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
        public override DataTable GetFreeHallsForSection(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.Decimal campusId, 
            System.Decimal hallTypeId, System.String datesTimes,System.Decimal Building_ID,DateTime? DateFrom,DateTime? DateTo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHK_ADD_HALL_TO_Section", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, edCodeSemId);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, edCourseId);
            database.AddInParameter(commandWrapper, "@GS_CDE_CAMPUS_ID", DbType.Decimal, campusId);
            database.AddInParameter(commandWrapper, "@SC_CDE_HALL_TYPE_ID", DbType.Decimal, hallTypeId);
            database.AddInParameter(commandWrapper, "@DATES_TIMES", DbType.Xml, datesTimes);
            database.AddInParameter(commandWrapper, "@Building_ID", DbType.Decimal, Building_ID);
            database.AddInParameter(commandWrapper, "@Datefrom", DbType.DateTime,DateFrom);
            database.AddInParameter(commandWrapper, "@DateTo", DbType.DateTime, DateTo);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_BUILDING_ID");
            table.Columns.Add("BUILD_CODE");
            table.Columns.Add("BuildingAr");
            table.Columns.Add("BuildingEn");
            table.Columns.Add("SC_HALL_ID");
            table.Columns.Add("HALL_CODE");
            table.Columns.Add("HallAr");
            table.Columns.Add("CAPACITY");
            table.Columns.Add("IS_SHARED");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("HallEn");
            table.Columns.Add("EXM_CAPCITY");
            table.Columns.Add("CAPACITY_MAX");

            table.Columns.Add("CampusEn");

            table.Columns.Add("CampusAr");

            table.Columns.Add("TypeEn");

            table.Columns.Add("TypeAr");



            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                             reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                             reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString() };

                        table.Rows.Add(items);
                    }
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

        public override DataTable GetFreeHallsForExam(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.DateTime ExamDate, System.Decimal campusId, System.Decimal hallTypeId, System.Decimal Building_ID, System.DateTime FromTime, System.DateTime ToTime)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHK_ADD_HALL_TO_EXAM", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, edCodeSemId);
            database.AddInParameter(commandWrapper, "@GS_CDE_CAMPUS_ID", DbType.Decimal, campusId);
            database.AddInParameter(commandWrapper, "@SC_CDE_HALL_TYPE_ID", DbType.Decimal, hallTypeId);
            database.AddInParameter(commandWrapper, "@Building_ID", DbType.Decimal, Building_ID);
            database.AddInParameter(commandWrapper, "@ExamDate", DbType.Date, ExamDate);
            database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, FromTime);
            database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, ToTime);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_BUILDING_ID");
            table.Columns.Add("BUILD_CODE");
            table.Columns.Add("BuildingAr");
            table.Columns.Add("BuildingEn");
            table.Columns.Add("SC_HALL_ID");
            table.Columns.Add("HALL_CODE");
            table.Columns.Add("HallAr");
            table.Columns.Add("CAPACITY");
            table.Columns.Add("IS_SHARED");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("HallEn");
            table.Columns.Add("EXM_CAPCITY");
            table.Columns.Add("CAPACITY_MAX");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override DataTable GetWaitStudsForVS(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.String datesTimes)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHK_ADD_WAIT_STUD_TO_VS", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, edCodeSemId);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, edCourseId);
            database.AddInParameter(commandWrapper, "@DATES_TIMES", DbType.Xml, datesTimes);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("AS_FACULTY_INFO_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override int GetWaitStudsNumbers(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemId, System.Decimal edCourseId, System.Decimal EntMainId, System.Decimal AsFacultyInfoId, System.Decimal ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetNumberOfStudentsInWaitingList", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, edCourseId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);
            int count = 0;

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("WaitingStuds");

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

                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString()};
                    table.Rows.Add(items);
                }

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            
            if (table.Rows.Count > 0)
            {
                count = int.Parse(table.Rows[0][0].ToString());
            }

            return count;
        }

        public override DataTable CheckSchedule(TransactionManager transactionManager, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, 
            System.Decimal EntMainId, System.Decimal AsCodeDegreeClassId , decimal AsFacultyID = 0)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CheckSchedule", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.String, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.String, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.String, EntMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.String, AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.String, AsFacultyID);
            

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("course_code");
            table.Columns.Add("Descr_en");
            table.Columns.Add("Descr_ar");
          

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString()};
                        table.Rows.Add(items);
                    }
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
        public override DataTable CheckExamSchedule_New(TransactionManager transactionManager, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal EntMainId, System.Decimal AsCodeDegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CheckExamSchedule_New", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.String, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.String, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.String, EntMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.String, AsCodeDegreeClassId);

            

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("course_code");
            table.Columns.Add("Descr_en");
            table.Columns.Add("Descr_ar");
          

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString()};
                        table.Rows.Add(items);
                    }
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
        
        public override TList<ScScheduleHdr> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCodeCourseTeachingId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SCHEDULE_HDR_GetByEdCourseId", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseTeachingId", DbType.Decimal, _edCodeCourseTeachingId);

            IDataReader reader = null;
            TList<ScScheduleHdr> rows = new TList<ScScheduleHdr>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEdCourseId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);
                
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdOfferingCourseId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }	

        #endregion

        #region Updated Methods

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleHdr entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SCHEDULE_HDR_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@ScScheduleHdrId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@EdOfferingCourseId", DbType.Decimal, entity.EdOfferingCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseTeachingId", DbType.Decimal, (entity.EdCodeCourseTeachingId.HasValue ? (object)entity.EdCodeCourseTeachingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NoSlots", DbType.Decimal, (entity.NoSlots.HasValue ? (object)entity.NoSlots : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NoGroups", DbType.Decimal, (entity.NoGroups.HasValue ? (object)entity.NoGroups : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NoStudents", DbType.Decimal, (entity.NoStudents.HasValue ? (object)entity.NoStudents : System.DBNull.Value));

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

            entity.ScScheduleHdrId = decimal.Parse(commandWrapper.Parameters["@ScScheduleHdrId"].Value.ToString());
            entity.OriginalScScheduleHdrId = entity.ScScheduleHdrId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        #endregion
    }
}