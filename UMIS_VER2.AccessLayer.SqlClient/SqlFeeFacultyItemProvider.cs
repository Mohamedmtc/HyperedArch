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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeFacultyItem"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeFacultyItemProvider: SqlFeeFacultyItemProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeFacultyItemProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeFacultyItemProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override DataTable GetFacultyItemByStudID(decimal? _EdStudId, decimal? FEE_CODE_TYPE_ID, decimal? FeeStudDiscId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFacultyItemByStudID", this.UseStoredProcedure);

            if (_EdStudId !=null)
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);

            if (FEE_CODE_TYPE_ID != null)
            database.AddInParameter(commandWrapper, "@FEE_CODE_TYPE_ID", DbType.Decimal, FEE_CODE_TYPE_ID);

            if (FeeStudDiscId!=null)
            database.AddInParameter(commandWrapper, "@FeeStudDiscId", DbType.Decimal, FeeStudDiscId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFacultyItemByStudID"));
            DataTable dt = new DataTable();

            dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];

            commandWrapper = null;

            return dt;




        }
        #endregion
    }
}