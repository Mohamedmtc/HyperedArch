#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeTreasuryReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeTreasuryReqProvider: SqlFeeTreasuryReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeTreasuryReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeTreasuryReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}


        #region Custom Methods

        public override DataTable FeeTreasurysSearch(TransactionManager transactionManager, System.Decimal _EdAcadYearId, DateTime? FromDate, DateTime? ToDate)
        {
                     
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWarpper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_FEE_TREASURY_REQ", this.UseStoredProcedure);
            database.AddInParameter(commandWarpper, "@EdAcadYearID", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWarpper, "@FromDate", DbType.DateTime,FromDate );
            database.AddInParameter(commandWarpper, "@ToDate", DbType.DateTime, ToDate);
            
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FEE_TREASURY_REQ_ID");
            //table.Columns.Add("FEE_CDE_BOND_ITEM_ID");
            table.Columns.Add("REQ_AMOUNT");
            table.Columns.Add("ToDate");
            table.Columns.Add("FromDate");
            table.Columns.Add("AcadYearCode");
            table.Columns.Add("AcadYearEN");
            table.Columns.Add("APPROVE_FLG");
           
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWarpper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWarpper);
                }
                while (reader.Read())
                {
                    object[] items ={reader[0].ToString(),reader[1].ToString(),reader[2].ToString(),reader[3].ToString(),reader[4].ToString(),
                                   reader[5].ToString(),reader[6].ToString()};
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWarpper = null;

            }
            return table;


        }
        public override DataTable FeeTreasurysSearchDTL(TransactionManager transactionManager, System.Decimal _EdFeeTresuryReqID)
        {

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWarpper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_FEE_CDE_BOND_ITEM_DTL", this.UseStoredProcedure);
            database.AddInParameter(commandWarpper, "@FeeTresuryReqID", DbType.Decimal, _EdFeeTresuryReqID);
            
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("BOND_ITEM_AR");
            table.Columns.Add("BOND_ITEM_EN");
            table.Columns.Add("ACCOUNT_NO");
            table.Columns.Add("FEE_CDE_BOND_ITEM_ID");
            table.Columns.Add("REQ_AMOUNT");
            table.Columns.Add("BOND_ITEM_AMOUNT");
            

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWarpper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWarpper);
                }
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWarpper = null;

            }
            return table;

        }
        #endregion Custom Methods
    }
}