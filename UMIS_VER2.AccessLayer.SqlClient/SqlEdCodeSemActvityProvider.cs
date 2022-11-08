#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using UMIS_VER2.BusinessLyer;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCodeSemActvity"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdCodeSemActvityProvider: SqlEdCodeSemActvityProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdCodeSemActvityProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdCodeSemActvityProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetCustomEdCodeSemActvityPaged(TransactionManager transactionManager, string whereClause, string orderBy, decimal pageIndex, decimal pageSize)
        {     
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            System.Data.Common.DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_ED_CODE_SEM_ACTVITY_GetPaged", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@WhereClause", DbType.String, whereClause);
            database.AddInParameter(commandWrapper, "@OrderBy", DbType.String, orderBy);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdCodeSemActvityId");
            table.Columns.Add("DescrAr");
            table.Columns.Add("DescrEn");
            table.Columns.Add("ActvOrder");
            table.Columns.Add("HideFlg");
            table.Columns.Add("ConstFlg");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                    table.Rows.Add(items);
                }
            } 
            catch (Exception ex)
            { }
            finally
            {
                commandWrapper = null;
            }

            return table;
        }

        public override DataTable GetCustomEdCodeSemActvityPaged(TransactionManager transactionManager, string DescrEn, string DescrAr, int PolicyNameEn, int PolicyNameAr, decimal pageIndex, decimal pageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            System.Data.Common.DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_ED_CODE_SEM_ACTVITY_GetPaged_new", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, DescrEn);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, DescrAr);
            database.AddInParameter(commandWrapper, "@PolicyNameEn", DbType.Decimal, PolicyNameEn);
            database.AddInParameter(commandWrapper, "@PolicyNameAr", DbType.Decimal, PolicyNameAr);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("EdCodeSemActvityId");
            table.Columns.Add("DescrAr");
            table.Columns.Add("DescrEn");
            table.Columns.Add("ActvOrder");
            table.Columns.Add("HideFlg");
            table.Columns.Add("ConstFlg");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                    table.Rows.Add(items);
                }
            }
            catch (Exception ex)
            { }
            finally
            {
                commandWrapper = null;
            }

            return table;
        }

	}
}