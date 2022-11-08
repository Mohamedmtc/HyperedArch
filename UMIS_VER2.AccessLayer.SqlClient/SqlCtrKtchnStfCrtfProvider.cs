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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CtrKtchnStfCrtf"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlCtrKtchnStfCrtfProvider: SqlCtrKtchnStfCrtfProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlCtrKtchnStfCrtfProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlCtrKtchnStfCrtfProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable SearchKetchenEmps(TransactionManager transactionManager, System.Decimal _ErpEmpId, string _FromDt, string _ToDt)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_CTR_KTCHN_STF_CRTF_SRCH", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ErpEmpID", DbType.Decimal, _ErpEmpId);
            database.AddInParameter(commandWrapper, "@FromDt", DbType.DateTime, !string.IsNullOrEmpty(_FromDt) ? (object)_FromDt : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ToDt", DbType.DateTime, !string.IsNullOrEmpty(_ToDt) ? (object)_ToDt : DBNull.Value);

            IDataReader reader = null;
            DataTable tmp = new DataTable();


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
                tmp.Load(reader);

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;

            //return rows;
        }
	}
}