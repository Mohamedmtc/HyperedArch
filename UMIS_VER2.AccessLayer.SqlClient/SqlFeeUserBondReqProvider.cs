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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeUserBondReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeUserBondReqProvider: SqlFeeUserBondReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeUserBondReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeUserBondReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods
        //added by manar abdelhafez task 13031 CSS
        public override DataTable GetFeesBondRequest(DateTime? dateFrom, DateTime? dateTo, int FeecdeBItem, string granteeName, string AccNo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFeesBondRequest", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@dateFrom", DbType.DateTime, dateFrom.HasValue ? dateFrom : null);
            database.AddInParameter(commandWrapper, "@dateTo", DbType.DateTime, dateTo.HasValue ? dateTo : null);
            database.AddInParameter(commandWrapper, "@FeecdeBItem", DbType.Int32, FeecdeBItem);
            database.AddInParameter(commandWrapper, "@granteeName", DbType.String, granteeName);
            database.AddInParameter(commandWrapper, "@AccNo", DbType.String, AccNo);
            IDataReader reader = null;
            DataTable LstFee = new DataTable();
            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                LstFee.Load(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWrapper = null;
            }

            return LstFee;
        }
        //end 
        #endregion	
    }
}