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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeUserFundReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeUserFundReqProvider: SqlFeeUserFundReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeUserFundReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlFeeUserFundReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        //added by manar abdelhafez task 13329 CSS
        public override DataTable GETFeeFundRequest(int AcadYearId, int FeecdeBItem, string granteeName, string AccNo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GETFeeFundRequest", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Int32, AcadYearId);
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
    }
}