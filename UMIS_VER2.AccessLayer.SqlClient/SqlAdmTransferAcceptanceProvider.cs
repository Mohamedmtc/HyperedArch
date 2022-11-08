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

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmTransferAcceptance"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmTransferAcceptanceProvider: SqlAdmTransferAcceptanceProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmTransferAcceptanceProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmTransferAcceptanceProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Custom Methods
        public override DataTable GetAppTransAcceptanceList(TransactionManager transactionManager, System.Decimal _AdmAppTransReqId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAppTransAcceptanceList", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmAppTransReqId", DbType.Decimal, _AdmAppTransReqId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_TRANSFER_ACCEPTANCE_ID");
            table.Columns.Add("ACCEPTANCE_FLG");
            table.Columns.Add("ADM_APP_TRANS_REQ_ID");
            table.Columns.Add("ADM_TRANS_ACCEPTANCE_CATEGORY_ID");
            table.Columns.Add("CATEGORY_NAME_AR");
            table.Columns.Add("CATEGORY_NAME_EN");
            table.Columns.Add("ABBREVIATION_AR");
            table.Columns.Add("ABBREVIATION_EN");
            table.Columns.Add("CATEGORY_TYPE");
            table.Columns.Add("CATEGORY_VALUE");
            table.Columns.Add("REG_EXPIRATION");
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
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
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