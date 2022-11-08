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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CtrMenuAct"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlCtrMenuActProvider: SqlCtrMenuActProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlCtrMenuActProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlCtrMenuActProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable Search(TransactionManager transactionManager, System.DateTime? _CatDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CTR_MENU_ACT_SRCH", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CatDate", DbType.DateTime, _CatDate.HasValue ? (object)_CatDate.Value : DBNull.Value);

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("CTR_MENU_ACT_ID");
            tbl.Columns.Add("PLAN_DT");
            tbl.Columns.Add("CTR_CDE_MEAL_ID");
            tbl.Columns.Add("CTR_MENU_ID");
            tbl.Columns.Add("MEAL_AR");
            tbl.Columns.Add("MEAL_EN");
            tbl.Columns.Add("MENU_AR");
            tbl.Columns.Add("MENU_EN");
            tbl.Columns.Add("NET_MEAL_COUNT");
            tbl.Columns.Add("MAX_CAL");

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

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
                    tbl.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return tbl;
        }	
	}
}