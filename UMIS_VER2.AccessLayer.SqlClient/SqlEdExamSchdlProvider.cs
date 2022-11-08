#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using System.Data.SqlClient;
using System.Configuration;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdExamSchdl"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdExamSchdlProvider: SqlEdExamSchdlProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdExamSchdlProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdExamSchdlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override decimal InsertWithIdOut(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamSchdl entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.EdExamSchdlInsertWithIdOut", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdExamSchdlId", DbType.Decimal, 6);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseAssessId", DbType.Decimal, (entity.EdCodeCourseAssessId.HasValue ? (object)entity.EdCodeCourseAssessId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@ExamDate", DbType.Date, (entity.ExamDate.HasValue ? (object)entity.ExamDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, (entity.FromTime.HasValue ? (object)entity.FromTime : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, (entity.ToTime.HasValue ? (object)entity.ToTime : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);

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


            entity.OriginalEdExamSchdlId = entity.EdExamSchdlId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToDecimal(commandWrapper.Parameters["@EdExamSchdlId"].Value);
        }

        public override DataTable GetStudExamSchedule(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal _AsFacultyInfoId, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudExamSchedule", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EXAM_DATE");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("DayDescrEn");
            table.Columns.Add("DayDescrAr");
            table.Columns.Add("Hours");
            table.Columns.Add("Minutes");
            table.Columns.Add("COURSE_ASSESS_DESCR_AR");
            table.Columns.Add("COURSE_ASSESS_DESCR_EN");
            table.Columns.Add("HALL_DESCR_EN");
            table.Columns.Add("HALL_DESCR_AR");
            table.Columns.Add("STUD_SEAT_NUM");

            try
            {
                //Provider Data Requesting Command Event
                // OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudExamSchedule", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()
                                        ,reader[8].ToString(),reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(),reader[13].ToString(), reader[14].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()
                                         ,reader[8].ToString(),reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(),reader[13].ToString(), reader[14].ToString()};
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

        public override DataTable GetSchedule(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemesterId, decimal asFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudExamSchedule", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoId);

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetSchedule"));

                if (transactionManager != null)
                    return Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                else
                    return Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }
            finally
            {
                commandWrapper = null;
            }
            
            return null;
        }

        public override DataTable GetCourseExamPlaces(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId,
            System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCourseId,decimal? edCodeCourseAssessId,
            DateTime? Date1, decimal? GenderId, decimal? _EdExamTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseExamPlacesWithDept", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseAssessId", DbType.Decimal, edCodeCourseAssessId);
            database.AddInParameter(commandWrapper, "@Date1", DbType.DateTime, Date1);
            //kamela, 12071, add gender to search in case sysparam 67 = 1 
            if(GenderId.HasValue)
                database.AddInParameter(commandWrapper, "@GenderId", DbType.Decimal, GenderId);
            //end
            database.AddInParameter(commandWrapper, "@EDEXAMTYPEID", DbType.Decimal, _EdExamTypeId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_EXAM_SCHDL_ID");
            table.Columns.Add("CO_EXAM_SCHDL_PLACE_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("BUILDING_DESCR_AR");
            table.Columns.Add("BUILDING_DESCR_EN");
            table.Columns.Add("HALL_DESCR_AR");
            table.Columns.Add("HALL_DESCR_EN");
            table.Columns.Add("STUD_COUNT");
            table.Columns.Add("EXAM_DATE");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("Course_Code");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ED_CODE_COURSE_ASSESS_ID");
            table.Columns.Add("CrsAssDescAr");
            table.Columns.Add("CrsAssDescEn");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("SC_HALL_ID");
            //kamela, 12071, select gender to dispaly it in grid 
            table.Columns.Add("Gender_Id");
            table.Columns.Add("Gender_AR");
            table.Columns.Add("Gender_EN");
            //end
            table.Columns.Add("SC_BUILDING_ID");  // Kamela, ECU, 10-8-2022, (fix bug of check on exam-hall-capacity) Procedure have column building Id with this order so put it to prevent take BuildId as studs distributed at this place(coPlaceId)
            table.Columns.Add("Studs");
            table.Columns.Add("Studs_course");
            table.Columns.Add("Tot_Count_Available");
            //Kamela, 13721, T display Number of available seat not occupied seat 
            table.Columns.Add("AvailableNumberOfSeat");
            //end
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()
                                        ,reader[8].ToString(),reader[9].ToString(),reader[10].ToString() ,reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),reader[22].ToString()
                                     ,reader[23].ToString(),reader[24].ToString(),reader[25].ToString(),reader[26].ToString(), reader[27].ToString()
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
        public override TList<EdExamSchdl> GetByEdAcadYearIdEdCodeSemesterIdEdCourseId(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);

            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_EXAM_SCHDL_GetByEdAcadYearIdEdCodeSemesterIdEdCourseId", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            IDataReader reader = null;

            //Create Collection
            TList<EdExamSchdl> rows = new TList<EdExamSchdl>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_EXAM_SCHDL_GetByEdAcadYearIdEdCodeSemesterIdEdCourseId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }
                int count = 0;
                //Create Collection
                Fill(reader, rows, 0, 2000);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GraduatedStudFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }//end getall
		
        public override DataTable GetCourseExamPlaces(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseExamPlaces", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_EXAM_SCHDL_ID");
            table.Columns.Add("CO_EXAM_SCHDL_PLACE_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("BUILDING_DESCR_AR");
            table.Columns.Add("BUILDING_DESCR_EN");
            table.Columns.Add("HALL_DESCR_AR");
            table.Columns.Add("HALL_DESCR_EN");
            table.Columns.Add("STUD_COUNT");
            table.Columns.Add("EXAM_DATE");
            table.Columns.Add("Studs");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()
                                        ,reader[8].ToString(),reader[9].ToString() };
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

        //Angham 08/12/2020 15680
        public override DataTable GetCourseExamCommPlaces(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCourseId, System.Decimal _EdExamTypeId, System.Decimal _EdCodeCourseAssess)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseExamCommPlacesWithDept", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EDEXAMTYPEID", DbType.Decimal, _EdExamTypeId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseAssess", DbType.Decimal, _EdCodeCourseAssess);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_EXAM_SCHDL_ID");
            table.Columns.Add("CO_EXAM_SCHDL_PLACE_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("BUILDING_DESCR_AR");
            table.Columns.Add("BUILDING_DESCR_EN");
            table.Columns.Add("HALL_DESCR_AR");
            table.Columns.Add("HALL_DESCR_EN");
            table.Columns.Add("STUD_COUNT");
            table.Columns.Add("EXAM_DATE");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("Course_Code");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ED_CODE_COURSE_ASSESS_ID");
            table.Columns.Add("CrsAssDescAr");
            table.Columns.Add("CrsAssDescEn");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("SC_HALL_ID");
            table.Columns.Add("CO_EXAM_COMMITTEE_ID");
            table.Columns.Add("COMM_NAME_EN");
            table.Columns.Add("COMM_NAME_AR");
            table.Columns.Add("Committee_Capacity");
            table.Columns.Add("Studs");
            table.Columns.Add("Studs_course");
            table.Columns.Add("Tot_Count_Available");


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()
                                        ,reader[8].ToString(),reader[9].ToString(),reader[10].ToString() ,reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),reader[22].ToString(),
                                     reader[23].ToString(),reader[24].ToString(),reader[25].ToString(),reader[26].ToString()};
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

        //End Angham 08/12/2020 15680

        /*---custom Method --added by maha 06-6-2021   task 16766--*/
        public override DataTable GetTotalCapacityCourseExam(decimal ExamSchudleID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("dbo.GetTotalCapacityCommiteeForExamCourse", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ExamSchudleID", DbType.Decimal).Value = ExamSchudleID;

            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            return table;
        }
        //----- مواعيد الامتحان للمقرر وكل اللجان لنفس المقرر وطريقة التقييم لها العام والفصل ===//
        public override DataSet GetALLCourseExamCommittee_and_CourseExamDates(decimal ExamSchudleID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("dbo.GetCourseExamCommittee_and_CourseExamDates", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ExamSchudleID", DbType.Decimal).Value = ExamSchudleID;

            conn.Open();
            DataSet table = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            return table;
        }

        //Hesham 6-09-2022
        public override void EdExamSchdl_InsertExamDatesByOrder(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("InsertExamDatesByOrder_EdExamSchdl", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@AcadYearId", DbType.Decimal).Value = EdAcadYearID;
            command.Parameters.Add("@SemesterId", DbType.Decimal).Value = EdCodeSemesterId;
            command.Parameters.Add("@AsFacultyInfoId", DbType.Decimal).Value = AsFacultyInfoId;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public override void EdExamSchdl_DeleteExamDates(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("DeleteExamDates_EdExamSchdl", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@AcadYearId", DbType.Decimal).Value = EdAcadYearID;
            command.Parameters.Add("@SemesterId", DbType.Decimal).Value = EdCodeSemesterId;
            command.Parameters.Add("@AsFacultyInfoId", DbType.Decimal).Value = AsFacultyInfoId;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        //Hesham 13-09-2022 19069
        public override DataTable ED_EXAM_SCHDL_GetExamDate(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId, System.Decimal EdCourseId)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("ED_EXAM_SCHDL_GetExamDate", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@FacultyId", DbType.Decimal).Value = AsFacultyInfoId;
            command.Parameters.Add("@AcadYearId", DbType.Decimal).Value = EdAcadYearID;
            command.Parameters.Add("@SemesterId", DbType.Decimal).Value = EdCodeSemesterId;
            command.Parameters.Add("@CourseId", DbType.Decimal).Value = EdCourseId;
            //command.Parameters.Add("@DeptId", DbType.Decimal).Value = EdDeptId;

            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            return table;
        }

	}
}