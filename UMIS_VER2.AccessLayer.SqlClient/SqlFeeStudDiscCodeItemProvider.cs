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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeStudDiscCodeItem"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeStudDiscCodeItemProvider: SqlFeeStudDiscCodeItemProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeStudDiscCodeItemProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeStudDiscCodeItemProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        public override void DelFeeStudDiscCodeItem(decimal FeeStudDiscId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.DelFeeStudDiscCodeItem", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@FeeStudDiscId", DbType.Decimal, FeeStudDiscId);
            Utility.ExecuteNonQuery(database, commandWrapper);
        }
        public override string CheckForItemPercentage(decimal FeeStudDiscId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CheckForItemPercentage", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@FeeStudDiscId", DbType.String, FeeStudDiscId);
     
            string res = Utility.ExecuteScalar(database, commandWrapper).ToString();
            return res;
        } 

      
	}
   
}