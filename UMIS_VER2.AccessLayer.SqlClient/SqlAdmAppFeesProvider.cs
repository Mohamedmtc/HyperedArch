#region Using directives

using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using UMIS_VER2.BusinessLyer;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
    ///<summary>
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppFees"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlAdmAppFeesProvider : SqlAdmAppFeesProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlAdmAppFeesProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlAdmAppFeesProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }
        public override DataTable AdmAppFees_GetAllApplicants(TransactionManager transactionManager, System.Decimal _AdmOpenAcadSemesterId, System.Decimal _AsFacultyInfoId, string _AdmAppCode, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _PayFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_FEES_GetAllApplicants", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemesterId", DbType.Decimal, _AdmOpenAcadSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@AdmAppCode", DbType.String, _AdmAppCode);
            database.AddInParameter(commandWrapper, "@DateFrom", DbType.DateTime, _DateFrom);
            database.AddInParameter(commandWrapper, "@DateTo", DbType.DateTime, _DateTo);
            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, _PayFlg);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_APP_FEES_ID");
            table.Columns.Add("ADM_CDE_FEE_ID");
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("IS_PAYED");
            table.Columns.Add("ADM_OPEN_ACAD_SEMESTER_ID");
            table.Columns.Add("ADM_APP_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("AMOUNT");
            table.Columns.Add("CURRENCY_CODE");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString()
                                     , reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), 
                                     reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                     reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString()};
                    table.Rows.Add(items);
                }
            }
            finally
            {
                commandWrapper = null;
            }

            return table;
        }

        //added by mmq at 24-07-2016 
        public override DataTable AdmAppFees_GetAllApplicants(TransactionManager transactionManager, System.Decimal _AdmOpenAcadSemesterId, System.Decimal _AsFacultyInfoId, string _AdmAppCode, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _PayFlg, System.DateTime? _RegDateFrom, System.DateTime? _RegDateTo, System.Decimal? _ReciptNum)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_FEES_GetAllApplicants", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemesterId", DbType.Decimal, _AdmOpenAcadSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@AdmAppCode", DbType.String, _AdmAppCode);
            database.AddInParameter(commandWrapper, "@DateFrom", DbType.DateTime, _DateFrom);
            database.AddInParameter(commandWrapper, "@DateTo", DbType.DateTime, _DateTo);
            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, _PayFlg);

            database.AddInParameter(commandWrapper, "@RegDateFrom", DbType.DateTime, _RegDateFrom);
            database.AddInParameter(commandWrapper, "@RegDateTo", DbType.DateTime, _RegDateTo);
            database.AddInParameter(commandWrapper, "@ReciptNum", DbType.Decimal, _ReciptNum);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_APP_FEES_ID");
            table.Columns.Add("ADM_CDE_FEE_ID");
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("IS_PAYED");
            table.Columns.Add("ADM_OPEN_ACAD_SEMESTER_ID");
            table.Columns.Add("ADM_APP_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("AMOUNT");
            table.Columns.Add("CURRENCY_CODE");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("RECEIPT_DATE");  //added by mmq at 28-07-2016
            table.Columns.Add("serial_number");  //added by mmq at 28-07-2016
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
                    object[] items = { reader[0].ToString(), reader[1].ToString()
                                     , reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), 
                                     reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                     reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(),reader[14].ToString(),reader[15].ToString()};
                    table.Rows.Add(items);
                }
            }
            finally
            {
                commandWrapper = null;
            }

            return table;
        }

        public override void UpdateAdmAppFees(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal ApplicantID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UpdateAdmAppFees", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ApplicantID", DbType.Decimal, ApplicantID);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
           
            try
            {
                Utility.ExecuteNonQuery(database, commandWrapper);
            }
            finally
            {
                commandWrapper = null;
            }
           
        }
        #region Task No:9955,Made By:eman moustafa,Desc: Delete placement exam  and  fees on applicant ,Date:27/5/2019
        public override void DeleteAdmAppFees(decimal AppExamID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_DeleteFeesAndPLaceExam_OnApplicant", this.UseStoredProcedure);
          
            database.AddInParameter(commandWrapper, "@AppExamID", DbType.Decimal, AppExamID);

            try
            {
                Utility.ExecuteNonQuery(database, commandWrapper);
            }
            finally
            {
                commandWrapper = null;
            }
        }
        #endregion
        public override int ADM_APP_FEES_Cancel_FOR_ADM_APP_PREF(TransactionManager transactionManager,decimal AdmApplicantID, decimal AsFacultyInfoId)//added by hoda at 14 / 9 / 2022 for merit task 19067
        {
            int count = 0;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("ADM_APP_FEES_Cancel_FOR_ADM_APP_PREF", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("AdmApplicantID", SqlDbType.Decimal).Value = AdmApplicantID;
            command.Parameters.Add("AsFacultyInfoId", SqlDbType.Decimal).Value = AsFacultyInfoId;
            conn.Open();
            count = int.Parse(command.ExecuteScalar().ToString());
            conn.Close();
            return count;
        }
    }
}