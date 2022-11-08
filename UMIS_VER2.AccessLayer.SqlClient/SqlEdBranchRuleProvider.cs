#region Using directives

using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using UMIS_VER2.BusinessLyer;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdBranchRule"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdBranchRuleProvider: SqlEdBranchRuleProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdBranchRuleProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdBranchRuleProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable CheckBranchRuleRelatedWithData(decimal edBranchRuleId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CheckBranchRuleRelatedWithData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdBranchRuleId", DbType.Decimal, edBranchRuleId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("@Flg");
           
            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString() };
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
    }
}