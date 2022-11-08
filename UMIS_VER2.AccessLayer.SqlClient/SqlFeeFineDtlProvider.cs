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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeFineDtl"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeFineDtlProvider: SqlFeeFineDtlProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeFineDtlProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeFineDtlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetFeeFineDtlByFeeFineID(decimal FeeFineID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SelectAllFeeFineDtlByFeeFineID", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FeeFine_ID", DbType.Decimal, FeeFineID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FeeFineDtlId");
            table.Columns.Add("FeeFineId");
            table.Columns.Add("FeeCodeItemId");
            table.Columns.Add("DelaySeq");
            table.Columns.Add("FINE_PRCNT");
            table.Columns.Add("FINE_VALUE");
            table.Columns.Add("NOTES");
            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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