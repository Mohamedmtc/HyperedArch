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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CtrMenuItem"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlCtrMenuItemProvider: SqlCtrMenuItemProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlCtrMenuItemProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlCtrMenuItemProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetMealItemDetails(TransactionManager transactionManager, System.Decimal _CTR_CDE_MEAL_ITEM_ID, System.Decimal _CTR_CDE_MEAL_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetMealItemDetails", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CTR_CDE_MEAL_ITEM_ID", DbType.Decimal, _CTR_CDE_MEAL_ITEM_ID);
            database.AddInParameter(commandWrapper, "@CTR_CDE_MEAL_ID", DbType.Decimal, _CTR_CDE_MEAL_ID);

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("CTR_CDE_MEAL_ID");
            tbl.Columns.Add("CTR_CDE_MEAL_ITEM_ID");
            tbl.Columns.Add("UNIT_COUNT");
            tbl.Columns.Add("ITEM_CAL");
            tbl.Columns.Add("MEAL_ITEM_AR");
            tbl.Columns.Add("MEAL_ITEM_EN");
            tbl.Columns.Add("ITEM_TYPE_AR");
            tbl.Columns.Add("ITEM_TYPE_EN");
            tbl.Columns.Add("TOTAL_CAL");

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

                if (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() };
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