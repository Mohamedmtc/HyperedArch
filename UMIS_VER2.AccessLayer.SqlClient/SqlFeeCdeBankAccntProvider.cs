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
using System.Web.UI.WebControls;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeCdeBankAccnt"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeCdeBankAccntProvider: SqlFeeCdeBankAccntProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeCdeBankAccntProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeCdeBankAccntProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region custom methods
        public override bool FeeCdeBankAccntUpdate(TransactionManager transactionManager,System.Decimal FeeCdeBankAccntId,System.Boolean DFULT_FLG)//added by hoda at 26/6/2022 merit task 18797 
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "C_FEE_CDE_BANK_ACCNT_Update", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FeeCdeBankAccntId", DbType.Decimal, FeeCdeBankAccntId);
            database.AddInParameter(commandWrapper, "@DFULT_FLG", DbType.Boolean, DFULT_FLG);

            int results = 0;
           
            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }
                        
            return Convert.ToBoolean(results);
        }
        #endregion
    }
}