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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeTreasury"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeTreasuryProvider: SqlFeeTreasuryProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeTreasuryProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeTreasuryProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region CustomMetods
      
        //Added by nashassan 1/8/2016
        public override DataTable GetFeeTreasuryByTypeAndDate(TransactionManager transactionManager, int Type, DateTime? DateFrom, DateTime? DateTo, decimal EdAcadYearId, decimal EdCodeSemesterId, string TrsNumber, decimal TrsAmount, string TrsName, decimal TrsItem, decimal PageIndex, decimal PageSize, decimal AllowSort, decimal SortColumn, decimal SortDirection)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFeeTreasuryByTypeAndDate", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Type", DbType.Int32, Type);
            database.AddInParameter(commandWrapper, "@DateFrom", DbType.DateTime, DateFrom);
            database.AddInParameter(commandWrapper, "@DateTo", DbType.DateTime, DateTo);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);

            database.AddInParameter(commandWrapper, "@TrsNumber", DbType.String, TrsNumber);
            database.AddInParameter(commandWrapper, "@TrsAmount", DbType.Decimal, TrsAmount);
            database.AddInParameter(commandWrapper, "@TrsName", DbType.String, TrsName);
            database.AddInParameter(commandWrapper, "@TrsItem", DbType.Decimal, TrsItem);

            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            database.AddInParameter(commandWrapper, "@AllowSort", DbType.Decimal, AllowSort);
            database.AddInParameter(commandWrapper, "@SortColumn", DbType.Decimal, SortColumn);
            database.AddInParameter(commandWrapper, "@SortDirection", DbType.Decimal, SortDirection);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("FEE_TREASURY_ID");
            table.Columns.Add("TRS_NUMBER");
            table.Columns.Add("TRS_NAME");
            table.Columns.Add("TRS_DESCR_AR");
            table.Columns.Add("TRS_DESCR_EN");
            table.Columns.Add("OUT_AMOUNT");
            table.Columns.Add("IN_AMOUNT");
            table.Columns.Add("TRANS_DATE");
            table.Columns.Add("TRANS_SE_USER_ID");
            table.Columns.Add("TRANS_USR_NAME");
            table.Columns.Add("FEE_STUD_VOUCHER_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("Year_Code");
            table.Columns.Add("REMAIN_AMOUNT");
            table.Columns.Add("RowsTotCount");
    

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString()
                                         ,reader[14].ToString(), reader[15].ToString(),reader[16].ToString(),reader[17].ToString() };
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