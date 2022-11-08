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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudGroup"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudGroupProvider: SqlEdStudGroupProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudGroupProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudGroupProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override bool DeleteCourseTeaching(TransactionManager transactionManager, System.Decimal _EdStudCourseRegId, System.Decimal _EdCodeCourseTeachingId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.DeleteCourseTeaching", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudCourseRegId", DbType.Decimal, _EdStudCourseRegId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseTeachingId", DbType.Decimal, _EdCodeCourseTeachingId);
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

    }
}