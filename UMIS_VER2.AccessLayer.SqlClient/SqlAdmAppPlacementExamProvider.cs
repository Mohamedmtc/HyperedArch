#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppPlacementExam"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAppPlacementExamProvider: SqlAdmAppPlacementExamProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAppPlacementExamProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>


       
        
        public SqlAdmAppPlacementExamProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods
        public override DataTable CheckAcceptanceCategory(TransactionManager transactionManager, System.Decimal AdmApplicantId)
        {
            //Menna 17-04-2019
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHECK_ACCEPTANCE_CATEGORY", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ADM_APPLICANT_ID", DbType.Decimal, AdmApplicantId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ORIENTATION_FLG");
            table.Columns.Add("EXAM_LOAD_FLG");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString() };
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
        public override DataTable GetExamDates(TransactionManager transactionManager, int? _ExamCodeId, string _examDate, int? _DegClassCodeID, int? _EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_PLACEMENT_EXAM_GetExamDates", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ExamCodeId", DbType.Decimal, _ExamCodeId);
            database.AddInParameter(commandWrapper, "@ExamDate", DbType.String, _examDate);
            database.AddInParameter(commandWrapper, "@DegClassCodeID", DbType.Decimal, _DegClassCodeID);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_PLACE_EXAM_DATETIME_ID");
            table.Columns.Add("ADM_CDE_PLACEMENT_EXAM_ID");
            table.Columns.Add("EXAM_DATETIME");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

        public override DataTable GetApplicantPlacementExams(TransactionManager transactionManager, System.Decimal AdmApplicantId)
        {
        DataTable table_Check = new DataTable();
        table_Check = CheckAcceptanceCategory(transactionManager, AdmApplicantId);
            
            
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_PlaceMentExam_Get", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, AdmApplicantId);
                
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_CDE_PLACEMENT_EXAM_ID");
            table.Columns.Add("ADM_PLACE_EXAM_DATETIME_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("EXAM_DATE");
            table.Columns.Add("EXAM_TIME_FROM");
            table.Columns.Add("EXAM_TIME_TO");
            table.Columns.Add("PASS_FLG");
            table.Columns.Add("ABSENT_FLG");
            //Edited by nahassan 13/7/2016: return  course code 
            table.Columns.Add("COURSE_CODE");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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

        public override DataTable GetPlacementExamApplicants(TransactionManager transactionManager, System.Decimal AdmPlacementExamDateTimeId,decimal pageIndex,decimal pageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetPlacementExamApplicants", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AdmPlacementExamDateTimeId", DbType.Decimal, AdmPlacementExamDateTimeId);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("ADM_APP_PLACEMENT_EXAM_ID");
            table.Columns.Add("ADM_APP_CODE");
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("CPR");
            table.Columns.Add("NATION_DESCR_AR");
            table.Columns.Add("NATION_DESCR_EN");
            table.Columns.Add("ADM_PLACE_EXAM_DATETIME_ID");
            table.Columns.Add("RE_EXAM_FLG"); 
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
       

        public override DataTable GetForViewByDate(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, System.String _examDate, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_PLACEMENT_EXAM_GetForViewByDate", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AdmCdePlacementExamId", DbType.Decimal, _admCdePlacementExamId);
            database.AddInParameter(commandWrapper, "@ExamDate", DbType.String, _examDate);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmAppPlacementExamId");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("AppDate");
            table.Columns.Add("NationalityDescrAr");
            table.Columns.Add("NationalityDescrEn");
            table.Columns.Add("BirthDate");
            table.Columns.Add("AdmCdePlacementExamId");
            table.Columns.Add("ExamDate");
            table.Columns.Add("Mark");
            table.Columns.Add("PassFlg");

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

        public override DataTable GetAppExamDates(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_PLACEMENT_EXAM_GetAppExamDates", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AdmCdePlacementExamId", DbType.Decimal, _admCdePlacementExamId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
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

        public override DataTable GetApplicantExternalPlacementExams(TransactionManager transactionManager, System.Decimal AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_External_PlaceMentExam_Get", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, AdmApplicantId);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_CDE_PLACEMENT_EXAM_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            //Edited by nahassan 13/7/2016: return  course code 
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("EXEMPT_FLG");

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
                    object[] items = { reader["ADM_CDE_PLACEMENT_EXAM_ID"].ToString(), 
                                         reader["DESCR_AR"].ToString(), 
                                         reader["DESCR_EN"].ToString(), 
                                         reader["COURSE_CODE"].ToString(),
                                     reader["EXEMPT_FLG"].ToString()};
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