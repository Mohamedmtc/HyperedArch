#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppTransReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAppTransReqProvider: SqlAdmAppTransReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAppTransReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmAppTransReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods
        public override decimal InsertWithOutputAdmAppTransReqId(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransReq entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_TRANS_REQ_Insert", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@AdmAppTransReqId", DbType.Decimal, 9);
            //database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, entity.AdmApplicantId);
            //database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            //database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            //database.AddInParameter(commandWrapper, "@ReqDate", DbType.DateTime, (entity.ReqDate.HasValue ? (object)entity.ReqDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeReqStatusId", DbType.Decimal, entity.GsCodeReqStatusId);
            database.AddInParameter(commandWrapper, "@ReqStatusDate", DbType.DateTime, (entity.ReqStatusDate.HasValue ? (object)entity.ReqStatusDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@TransferReason", DbType.String, entity.TransferReason);
            //database.AddInParameter(commandWrapper, "@UnivName", DbType.String, entity.UnivName);
            //database.AddInParameter(commandWrapper, "@FacName", DbType.String, entity.FacName);
            database.AddInParameter(commandWrapper, "@PrvSemesterNo", DbType.Decimal, (entity.PrvSemesterNo.HasValue ? (object)entity.PrvSemesterNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PrvChNo", DbType.Decimal, (entity.PrvChNo.HasValue ? (object)entity.PrvChNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PrvCgpa", DbType.Decimal, (entity.PrvCgpa.HasValue ? (object)entity.PrvCgpa : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            //database.AddInParameter(commandWrapper, "@EdCodeLevelReqId", DbType.Decimal, entity.EdCodeLevelReqId);
            //database.AddInParameter(commandWrapper, "@EdCodeLevelAppId", DbType.Decimal, (entity.EdCodeLevelAppId.HasValue ? (object)entity.EdCodeLevelAppId : System.DBNull.Value));
            //database.AddInParameter(commandWrapper, "@CourseBalanceAppFlg", DbType.Decimal, entity.CourseBalanceAppFlg);
            //database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, entity.AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@IsApplied", DbType.Decimal, entity.IsApplied);
            //database.AddInParameter(commandWrapper, "@IncludeGpaFlg", DbType.Decimal, entity.IncludeGpaFlg);

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


            entity.OriginalAdmAppTransReqId = entity.AdmAppTransReqId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToDecimal(commandWrapper.Parameters["@AdmAppTransReqId"].Value);
        }


        public override DataTable GetExternalTransferRequests(TransactionManager transactionManager, decimal edAcadYearID, decimal edCodeSemesterId, decimal asFacultyInfoId, decimal entMainId,

            DateTime? reqFromDate, DateTime? reqToDate, string admAppCode, string admAppCPR, decimal langNum, decimal namePolicy, string applicantName, decimal isApplied)
           
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SP_Get_ExtTransReq", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, edAcadYearID);

            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entMainId);
            database.AddInParameter(commandWrapper, "@ReqFromDate", DbType.DateTime, reqFromDate  );
            database.AddInParameter(commandWrapper, "@ReqToDate", DbType.DateTime, reqToDate );
            //database.AddInParameter(commandWrapper, "@ReqFromDate", DbType.DateTime, reqFromDate != DateTime.MinValue ? (object)reqFromDate : System.DBNull.Value);
            //database.AddInParameter(commandWrapper, "@ReqToDate", DbType.DateTime, reqToDate != DateTime.MinValue ? (object)reqToDate : System.DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmAppCode", DbType.String, admAppCode);
            database.AddInParameter(commandWrapper, "@AdmAppCPR", DbType.String, admAppCPR);

            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, langNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, namePolicy);
            database.AddInParameter(commandWrapper, "@ApplicantName", DbType.String, applicantName);
            database.AddInParameter(commandWrapper, "@IsApplied", DbType.Decimal, isApplied!=-1?(object)isApplied : System.DBNull.Value);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("ADM_APP_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("CPR");
            table.Columns.Add("MajorAr");
            table.Columns.Add("MajorEn");
            table.Columns.Add("APP_DATE");
            table.Columns.Add("IS_APPLIED");
           

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString(),  reader[8].ToString()};
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


      
	
	
        public override DataTable GetInternalTransferRequests(TransactionManager transactionManager, decimal edAcadYearID, decimal edCodeSemesterId, decimal asFacultyInfoFromId, decimal entMainFromId,
            decimal asFacultyInfoToId, decimal entMainToId,decimal admTrnsTypeId,
            DateTime reqFromDate, DateTime reqToDate, string studCode, string studCPR, decimal langNum, decimal namePolicy, string studName, decimal isApplied,decimal? AsCodeDegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SP_Get_IntTransReq", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, edAcadYearID);

            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoFromId", DbType.Decimal, asFacultyInfoFromId);
            database.AddInParameter(commandWrapper, "@EntMainFromId", DbType.Decimal, entMainFromId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoToId", DbType.Decimal, asFacultyInfoToId);
            database.AddInParameter(commandWrapper, "@EntMainToId", DbType.Decimal, entMainToId);
            database.AddInParameter(commandWrapper, "@AdmTrnsTypeId", DbType.Decimal, admTrnsTypeId);

            database.AddInParameter(commandWrapper, "@ReqFromDate", DbType.DateTime, reqFromDate != DateTime.MinValue ? (object)reqFromDate : System.DBNull.Value);
            database.AddInParameter(commandWrapper, "@ReqToDate", DbType.DateTime, reqToDate != DateTime.MinValue ? (object)reqToDate : System.DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, studCode);
            database.AddInParameter(commandWrapper, "@StudCPR", DbType.String, studCPR);

            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, langNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, namePolicy);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, studName);
            database.AddInParameter(commandWrapper, "@IsApplied", DbType.Decimal, isApplied != -1 ? (object)isApplied : System.DBNull.Value);
            //database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId);
            database.AddInParameter(commandWrapper, "@AscodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);//walaa 09062022-18423
            IDataReader reader = null;
            DataTable table = new DataTable();
            
                
                table.Columns.Add("ED_STUD_ID");
                table.Columns.Add("ED_STUD_INT_TRNS_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("NATIONAL_NUMBER");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("MAJOR_FROM_AR");
            table.Columns.Add("MAJOR_FROM_EN");
            table.Columns.Add("MAJOR_TO_AR");
            table.Columns.Add("MAJOR_TO_EN");
            table.Columns.Add("REQ_DATE");
            table.Columns.Add("IS_APPLIED");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString(),  
                                     reader[8].ToString(),  reader[9].ToString(),  reader[10].ToString(),  reader[11].ToString()};
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

        public override DataTable GetTransferStuds(TransactionManager transactionManager, decimal edAcadYearID, decimal edCodeSemesterId, decimal asFacultyInfoFromId, decimal entMainFromId,
          decimal asFacultyInfoToId, decimal entMainToId, decimal AsCodeDegreeFromId,
          decimal AsCodeDegreeToId,string studCode, decimal isApplied)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "C_GetTransferStud", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, edAcadYearID);

            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoFromId", DbType.Decimal, asFacultyInfoFromId);
            database.AddInParameter(commandWrapper, "@EntMainFromId", DbType.Decimal, entMainFromId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoToId", DbType.Decimal, asFacultyInfoToId);
            database.AddInParameter(commandWrapper, "@EntMainToId", DbType.Decimal, entMainToId);

            database.AddInParameter(commandWrapper, "@AsCodeDegreeFromId", DbType.Decimal, AsCodeDegreeFromId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeToId", DbType.Decimal, AsCodeDegreeToId);

            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, studCode);
            database.AddInParameter(commandWrapper, "@IsApproved", DbType.Decimal, isApplied);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("NATIONAL_NUMBER");

            table.Columns.Add("ENT_MAIN_TO_ID");
            table.Columns.Add("PLAN_YEAR_TO_ID");

            table.Columns.Add("MAJOR_TO_AR");
            table.Columns.Add("MAJOR_TO_EN");
            table.Columns.Add("ENT_MAIN_FROM_ID");
            table.Columns.Add("PLAN_YEAR_FROM_ID");

            table.Columns.Add("MAJOR_FROM_AR");
            table.Columns.Add("MAJOR_FROM_EN");

            table.Columns.Add("IS_COURSE_APPROVED");
            table.Columns.Add("COURSE_APPROVE_DATE");

            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("ED_STUD_SEMESTER_ID");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString(),  
                                     reader[8].ToString(),  reader[9].ToString(),  reader[10].ToString(),  reader[11].ToString(),
                                     reader[12].ToString(),  reader[13].ToString(),  reader[14].ToString(),  reader[15].ToString(),
                                     reader[16].ToString(),reader[17].ToString()};

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
        //Added by Menna 06-08-2019 task 10714
        public override DataTable C_GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetByAdmAppRegHistoryId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmAppRegHistoryId", DbType.Decimal, _admAppRegHistoryId);


            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ADM_APP_TRANS_REQ_ID");
            table.Columns.Add("ADM_APP_REG_HISTORY_ID");
            table.Columns.Add("UNIV_NAME");
            table.Columns.Add("FAC_NAME");
            table.Columns.Add("PRV_SEMESTER_NO");
            table.Columns.Add("PRV_CH_NO");

            table.Columns.Add("PRV_CGPA");
            table.Columns.Add("ENT_MAIN_ID");

            table.Columns.Add("TRANSFER_REASON");
            table.Columns.Add("GS_CODE_REQ_STATUS_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("REQ_STATUS_DATE");
            table.Columns.Add("IS_APPLIED");
            table.Columns.Add("ADM_CODE_TRANSFER_TYPE_ID");
            table.Columns.Add("ED_CODE_LEVEL_REQ_ID");
            table.Columns.Add("ED_CODE_LEVEL_APP_ID");
            table.Columns.Add("AS_FACULTY_INFO_ID");

            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("yearName");

            
            TList<AdmAppTransReq> rows = new TList<AdmAppTransReq>();

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString(),  
                                     reader[8].ToString(),  reader[9].ToString(),  reader[10].ToString(),  reader[11].ToString(),
                                     reader[12].ToString(),  reader[13].ToString(),  reader[14].ToString(),  reader[15].ToString(),
                                     reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString()};

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


	}
}