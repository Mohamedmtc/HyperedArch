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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SvStudLockerReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSvStudLockerReqProvider: SqlSvStudLockerReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSvStudLockerReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSvStudLockerReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }
        #region
        public override DataTable SearchSvStudLockRequest(TransactionManager transactionManager, System.Decimal _FacId,
             System.Decimal _BuildId, string _LocKCode, string _STUDCODE, string _KeyNo, decimal _RecieptNo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchSvStudLockRequest", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FacId", DbType.Decimal, _FacId);
            database.AddInParameter(commandWrapper, "@BuilId", DbType.Decimal, _BuildId);
            database.AddInParameter(commandWrapper, "@LocKCode", DbType.String, _LocKCode);
            database.AddInParameter(commandWrapper, "@STUDCODE", DbType.String, _STUDCODE);
            database.AddInParameter(commandWrapper, "@KeyNo", DbType.String, _KeyNo);
            database.AddInParameter(commandWrapper, "@RecieptNo", DbType.String, _RecieptNo);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_STUD_LOCKER_REQ_ID");
            table.Columns.Add("KEY_NO");
            table.Columns.Add("REQ_DATE");
            table.Columns.Add("RETURN_DATE");
            table.Columns.Add("LOCKER_CODE");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("FULL_NAME_AR");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                          reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                          reader[8].ToString(), reader[9].ToString(), reader[10].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                          reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                          reader[8].ToString(), reader[9].ToString(), reader[10].ToString()};
                        table.Rows.Add(items);
                    }
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