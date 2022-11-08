#region Using directives

using System;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using UMIS_VER2.AccessLayer.Bases;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmPlaceExamDatetime"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmPlaceExamDatetimeProvider: SqlAdmPlaceExamDatetimeProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmPlaceExamDatetimeProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmPlaceExamDatetimeProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}


        public override DataTable GetPlacementExams(TransactionManager transactionManager, string _acadOpenSemesterId, decimal AsFacultyID, decimal AS_CODE_DEGREE_CLASS_ID, decimal AS_CODE_DEGREE_ID, decimal? COMPTATIVE_RATE_FLG, decimal? Foreign_FLG, decimal? Gender_Type_ID, decimal? Sv_HDR_ID, decimal? App_Type, decimal? ADM_CDE_PLACEMENT_EXAM_ID, DateTime? ExamDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetPlacementExams", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemesterId", DbType.String, string.IsNullOrEmpty(_acadOpenSemesterId) ? (object)DBNull.Value : _acadOpenSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyID", DbType.Decimal, AsFacultyID);
            database.AddInParameter(commandWrapper, "@AS_CODE_DEGREE_CLASS_ID", DbType.Decimal, AS_CODE_DEGREE_CLASS_ID);
            database.AddInParameter(commandWrapper, "@AS_CODE_DEGREE_ID", DbType.Decimal, AS_CODE_DEGREE_ID);

            database.AddInParameter(commandWrapper, "@COMPTATIVE_RATE_FLG", DbType.Decimal, COMPTATIVE_RATE_FLG);
            database.AddInParameter(commandWrapper, "@Foreign_FLG", DbType.Decimal, Foreign_FLG);
            //added by eman moustafa 15-7-2019 task num:10147
            database.AddInParameter(commandWrapper, "@Gender_Type_ID", DbType.Decimal, Gender_Type_ID);
            database.AddInParameter(commandWrapper, "@App_Type_ID", DbType.Decimal, App_Type);
            database.AddInParameter(commandWrapper, "@SV_SRVY_HDR_ID", DbType.Int32, Sv_HDR_ID);
            database.AddInParameter(commandWrapper, "@ADM_CDE_PLACEMENT_EXAM_ID", DbType.Decimal, ADM_CDE_PLACEMENT_EXAM_ID);
            database.AddInParameter(commandWrapper, "@EXAM_DATE", DbType.Date, ExamDate);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_PLACE_EXAM_DATETIME_ID");
            table.Columns.Add("EXAM_DATE");
            table.Columns.Add("EXAM_TIME_FROM");
            table.Columns.Add("EXAM_TIME_TO");
            table.Columns.Add("DEGREE_DESCR_AR");
            table.Columns.Add("DEGREE_DESCR_EN");
            table.Columns.Add("CLASS_DESCR_AR");
            table.Columns.Add("CLASS_DESCR_EN");
            table.Columns.Add("Exam_DESCR_AR");
            table.Columns.Add("Exam_DESCR_En");
            table.Columns.Add("ADM_CDE_PLACEMENT_EXAM_ID");
            table.Columns.Add("AS_CODE_DEGREE_CLASS_ID");
            table.Columns.Add("AS_CODE_DEGREE_ID");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("IS_OPTIONAL_EXAM");
            table.Columns.Add("RELATED_To_PROGRAM");
            table.Columns.Add("Stud_Count");
            table.Columns.Add("LOCATION");
            //Edit by nashassan 27/7/2016
            table.Columns.Add("EXM_CAPCITY");
            table.Columns.Add("APPROVE_FLG");
            table.Columns.Add("FOREIGN_FLG");
            //added by eman moustafa 15-7-2019 task num:10147
            table.Columns.Add("Gender_Type_ID");
            table.Columns.Add("App_Type_ID");
            table.Columns.Add("SV_SRVY_HDR_ID");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), 
                                           reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), 
                                           reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(),
                                           reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),reader[22].ToString(),reader[23].ToString(),reader[24].ToString(),reader[25].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), 
                                           reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), 
                                           reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(),
                                           reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),reader[22].ToString()};
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

        public override DataTable GetNewApplicantIDsForAnExam(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetNewApplicantIds", this.UseStoredProcedure);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_APPLICANT_ID");


            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString()};
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

        public override DataTable GetNewApplicantIDsForAnExam(TransactionManager transactionManager, System.Decimal _AdmPlaceExamDatetimeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetNewApplicantIdsForExam", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ADM_PLACE_EXAM_DATETIME_ID", DbType.Decimal, _AdmPlaceExamDatetimeId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_APPLICANT_ID");


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
        #region added by mmq at 25/05/2016
        //
        public override DataTable GetAdmPlaceExamDatetimeByExamDateAndADM_CDE_PLACEMENT_EXAM_Id(TransactionManager transactionManager, System.Decimal ADM_CDE_PLACEMENT_EXAM_Id, DateTime ExamDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "getADM_PLACE_EXAM_DATETIMEByExamDateAndExamID", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ADM_CDE_PLACEMENT_EXAM_Id", DbType.Decimal, ADM_CDE_PLACEMENT_EXAM_Id);
            database.AddInParameter(commandWrapper, "@ExamDate", DbType.Date, ExamDate);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("AdmPlaceExamDatetimeId");
            table.Columns.Add("ExamTimeFrom");
            table.Columns.Add("ExamTimeTo");
            table.Columns.Add("Location");
        
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()};
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
        //

        public override DataTable GetAdmPlaceExamDatetimeByExamDateAndADM_CDE_PLACEMENT_EXAM_Id_New(TransactionManager transactionManager, System.Decimal ADM_CDE_PLACEMENT_EXAM_Id, DateTime ExamDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "getADM_PLACE_EXAM_DATETIMEByExamDateAndExamID_New", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ADM_CDE_PLACEMENT_EXAM_Id", DbType.Decimal, ADM_CDE_PLACEMENT_EXAM_Id);
            database.AddInParameter(commandWrapper, "@ExamDate", DbType.Date, ExamDate);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("AdmPlaceExamDatetimeId");
            table.Columns.Add("ExamTimeFrom");
            table.Columns.Add("ExamTimeTo");
            table.Columns.Add("Location");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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
        //
        //added by Yassmin Gamal at 28/07/2016
        public override DataTable GetPlacementExamTimesWithCapacity(TransactionManager transactionManager, System.Decimal _AdmCdePlacementExam )
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "C_GetPlacementExamTimesWithCapacity", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AdmCdePlacementExam", DbType.Decimal, _AdmCdePlacementExam);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("AdmPlaceExamDatetimeId");
            table.Columns.Add("ExamDate");
        
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
                    object[] items = { reader[0].ToString(), reader[1].ToString()};
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
        //


        
        public override DataTable GetExamApplicantResults(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, decimal AdmPlaceExamDatetimeId, DateTime ExamDate, decimal pageIndex, decimal pageSize, string appCodes, decimal PassFail)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetResultExamApplicantResults", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ExamId", DbType.Decimal, _admCdePlacementExamId);
           //Edit by Menna  9528
            string ApplicantIds = appCodes.Replace('-', ',');
            database.AddInParameter(commandWrapper, "@ApplicantIds", DbType.String, ApplicantIds);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);
            database.AddInParameter(commandWrapper, "@ExamDate", DbType.Date, ExamDate);
            database.AddInParameter(commandWrapper, "@AdmPlaceExamDatetimeId", DbType.Decimal, AdmPlaceExamDatetimeId);
            //added by olivia 6 / 5 / 2021 Task: 16637
            database.AddInParameter(commandWrapper, "@PassFail", DbType.Decimal, PassFail);
            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("sn");
            table.Columns.Add("ADM_APP_CODE");
            table.Columns.Add("DESCRAR");
            table.Columns.Add("DESCREN");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");

            table.Columns.Add("EXAM_DATE");
            table.Columns.Add("ExamTimeFromEn");

             // table.Columns.Add("CPR"); Commented By Ahmed Ali 09-01-2018  Due to Some Requiremenets of NU 
            table.Columns.Add("EXAM_TYPE_FLG");

            table.Columns.Add("MARK");
            table.Columns.Add("PASS_FLG");
            table.Columns.Add("ABSENT_FLG");


            table.Columns.Add("MAX_MARK");
            table.Columns.Add("MIN_MARK");
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("ADM_APP_PLACEMENT_EXAM_ID");
            table.Columns.Add("ADM_CDE_PLACEMENT_EXAM_ID");
            table.Columns.Add("ADM_PLACE_EXAM_DATETIME_ID");


            table.Columns.Add("ADM_CDE_EXAM_GRDNG_ID");
            table.Columns.Add("GS_CDE_OPERATOR");
            table.Columns.Add("Course_Code");
            table.Columns.Add("OUT_FLG");
            table.Columns.Add("ParentId");
            table.Columns.Add("CertPath");
            table.Columns.Add("ExemptCourse_Code");
            table.Columns.Add("ONLINE_FLG"); //Added by Menna 
            table.Columns.Add("RE_EXAM_FLG");
            table.Columns.Add("APPROVE_FLG"); //added by olivia 6 / 5 / 2021 Task: 16637
            table.Columns.Add("RowsTotCount");
            
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(), reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),
                                       reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),
                                       reader[14].ToString(),reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),
                                       reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),reader[22].ToString(),reader[23].ToString(),
                                       reader[24].ToString(),reader[25].ToString(),reader[26].ToString(),reader[27].ToString(),reader[28].ToString()};
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


        #endregion



        public override DataTable GetExamApplicantResults(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId,  decimal pageIndex, decimal pageSize, string appCodes)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetExamApplicantResults", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ExamId", DbType.Decimal, _admCdePlacementExamId);
            database.AddInParameter(commandWrapper, "@ApplicantIds", DbType.String, appCodes);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);
       
         
            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("sn");
            table.Columns.Add("ADM_APP_CODE");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("CPR");
            table.Columns.Add("EXAM_TYPE_FLG");

            table.Columns.Add("MARK");
            table.Columns.Add("PASS_FLG");
            table.Columns.Add("ABSENT_FLG");
            

            table.Columns.Add("MAX_MARK");
            table.Columns.Add("MIN_MARK");
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("ADM_APP_PLACEMENT_EXAM_ID");
            table.Columns.Add("ADM_CDE_PLACEMENT_EXAM_ID");
            table.Columns.Add("ADM_PLACE_EXAM_DATETIME_ID");
            
            
            
            table.Columns.Add("GS_CDE_OPERATOR");
            table.Columns.Add("RowsTotCount");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(), reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),
                                       reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString()};
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

        public override DataTable GetAcceptedRejectedApplicants(TransactionManager transactionManager, System.Decimal _asCodeClassDegree, System.Decimal _asCodeDegree, System.Decimal _admaAcadOpen, System.Decimal _acceptStatus, System.String _appCode, decimal _applicantType, decimal _pageIndex, decimal _pageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetAcceptedRejectedApplicants", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@DegreeClassId", DbType.Decimal, _asCodeClassDegree);
            database.AddInParameter(commandWrapper, "@DegreeId", DbType.Decimal, _asCodeDegree);
            database.AddInParameter(commandWrapper, "@AcadOpenId", DbType.Decimal, _admaAcadOpen);
            database.AddInParameter(commandWrapper, "@AcceptStatus", DbType.Decimal, _acceptStatus);
            database.AddInParameter(commandWrapper, "@AppCode", DbType.String, _appCode);
            database.AddInParameter(commandWrapper, "@ADM_CDE_APP_TYPE_ID", DbType.Decimal, _applicantType);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, _pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, _pageSize);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("ADM_APP_CODE");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("CPR");
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("OVER_ALL_ACCEPTANCE_FLG");
            table.Columns.Add("ADM_OPEN_ACAD_SEMESTER_ID");
            table.Columns.Add("ADM_APP_REG_HISTORY_ID");
            table.Columns.Add("ADM_CDE_STATUS_ID");
            table.Columns.Add("RowsTotCount");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(), reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
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

        //Menna
        public override TList<AdmPlaceExamDatetime> GetByAdmCdePlacementExamDatetimeId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_ADM_PLACE_EXAM_DATETIME_GetByAdmCdePlacementExamId", true);

            database.AddInParameter(commandWrapper, "@AdmCdePlacExamDateTimeId", DbType.Decimal, _admCdePlacementExamId);

            IDataReader reader = null;
            TList<AdmPlaceExamDatetime> rows = new TList<AdmPlaceExamDatetime>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByAdmCdePlacementExamId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                ////Create Collection
                Fill(reader, rows, 0, 10000);
                //count = -1;
                //if (reader.NextResult())
                //{
                //    if (reader.Read())
                //    {
                //        count = reader.GetInt32(0);
                //    }
                //}

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByAdmCdePlacementExamId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }	
		
	}
}