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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmApplicantAcceptance"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmApplicantAcceptanceProvider: SqlAdmApplicantAcceptanceProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmApplicantAcceptanceProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmApplicantAcceptanceProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Custom Procedure

        public override int ApplyAcceptanceCriteria(TransactionManager transactionManager, decimal _admApplicantId, decimal _edAcadYearId, decimal _edCodeSemesterId)
        {
            IDataReader reader = null;
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ApplyAcceptanceCriteria", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Selected_AdmApplicantId", DbType.Decimal, _admApplicantId);
            database.AddInParameter(commandWrapper, "@edAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@edCodeSemesterId", DbType.Decimal, _edCodeSemesterId);

            int results = 0;
            try
            {
                if (transactionManager != null)
                {
                    //results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    //results = Utility.ExecuteNonQuery(database, commandWrapper);
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                while (reader.Read())
                {
                    results = int.Parse(reader[0].ToString());
                    break;
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            //return Convert.ToBoolean(results);
            return results;
        }

        public override DataTable GetAppAcceptanceCriteria(TransactionManager transactionManager, System.Decimal _AdmAppRegHistoryId, System.Decimal _CategoryType, System.Decimal _OrientationFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAppAcceptanceCriteria", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@admAppRegHistoryId", DbType.Decimal, _AdmAppRegHistoryId);
            database.AddInParameter(commandWrapper, "@CategoryType", DbType.Decimal, _CategoryType);
            database.AddInParameter(commandWrapper, "@OrientationFlg", DbType.Decimal, _OrientationFlg);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_APPLICANTACCEPTANCE_ID");
            table.Columns.Add("ADM_ACCEPTANCE_CATEGORY_ID");
            table.Columns.Add("ADM_APP_REG_HISTORY_ID");
            table.Columns.Add("CATEGORY_NAME_AR");
            table.Columns.Add("CATEGORY_NAME_EN");
            table.Columns.Add("ABBREVIATION_AR");
            table.Columns.Add("ABBREVIATION_EN");
            table.Columns.Add("CATEGORY_VALUE");
            table.Columns.Add("ACCEPTANCE_FLG");
            table.Columns.Add("ChkFlg");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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

        public override DataTable GetApplicantAcceptanceData(TransactionManager transactionManager, System.Decimal _AdmApplicantId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetApplicantAcceptanceData", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);
            database.AddInParameter(commandWrapper, "@edAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@edCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmAcceptanceCategoryId");
            table.Columns.Add("AppValue");

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

        #endregion
    }
}