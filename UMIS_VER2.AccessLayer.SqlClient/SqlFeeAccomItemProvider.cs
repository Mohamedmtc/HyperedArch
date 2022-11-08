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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeAccomItem"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeAccomItemProvider: SqlFeeAccomItemProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeAccomItemProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        
        public SqlFeeAccomItemProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}


        #region Custom Methods
        public override DataTable GetFeeAccomItem_HousingData(TransactionManager transactionManager, decimal AcadYearID, Boolean InoutFlg, Boolean airCondFlg,
            Boolean MaritalFlg, decimal?CurrencyID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFeeAccomItem_HousingData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AcadYearID", DbType.Decimal, AcadYearID);
            database.AddInParameter(commandWrapper, "@InOutFlg", DbType.Boolean, InoutFlg);
            database.AddInParameter(commandWrapper, "@AirCondFlg", DbType.Boolean, airCondFlg);
            database.AddInParameter(commandWrapper, "@MaritalFlg", DbType.Boolean, MaritalFlg);
            database.AddInParameter(commandWrapper, "@CurrencyID", DbType.Decimal, CurrencyID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FeeAccomItemId");
            table.Columns.Add("EdAcadYearId");
            table.Columns.Add("FeeItemValue");
            table.Columns.Add("HousingTypeAr");
            table.Columns.Add("HousingTypeEn");
            table.Columns.Add("FeeCodeItemId");
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
                    object[] items = { reader["FeeAccomItemId"].ToString(), reader["ED_ACAD_YEAR_ID"].ToString(), reader["FEE_ITEM_VALUE"].ToString(),
                                         reader["HousingTypeAr"].ToString(), reader["HousingTypeEn"].ToString(),reader["FEE_CODE_ITEM_ID"].ToString()};
                    table.Rows.Add(items);
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