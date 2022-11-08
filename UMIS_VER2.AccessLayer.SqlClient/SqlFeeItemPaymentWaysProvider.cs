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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeItemPaymentWays"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeItemPaymentWaysProvider: SqlFeeItemPaymentWaysProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeItemPaymentWaysProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeItemPaymentWaysProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }
        #region customMethods
        public override DataTable GetFeeItemPaymentWays(System.Decimal feeFacultyItemID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFeeItemPaymentWays", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@FeeFacultyItemId", DbType.Decimal, feeFacultyItemID);
            IDataReader reader = null;
            DataTable table = new DataTable();


            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                table.Load(reader);
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