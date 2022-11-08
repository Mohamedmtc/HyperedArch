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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScScheduleDtlDate"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScScheduleDtlDateProvider: SqlScScheduleDtlDateProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScScheduleDtlDateProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScScheduleDtlDateProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        public override bool DeleteSchduleDatesBySectionID(decimal scScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "DeleteSchduleDatesBySectionID", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlID", DbType.Decimal, scScheduleDtlId);

            OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete"));

            int results = 0;
            results = Utility.ExecuteNonQuery(database, commandWrapper);
            OnDataRequested(new CommandEventArgs(commandWrapper, "Delete"));
            commandWrapper = null;

            return Convert.ToBoolean(results);
        }

	}
}