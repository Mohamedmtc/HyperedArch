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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="TrnsLine"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlTrnsLineProvider: SqlTrnsLineProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlTrnsLineProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlTrnsLineProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
	     public override DataTable GetBusLineFee(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterd)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetBusLineFee", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            //database.AddInParameter(commandWrapper, "@EdCodeSemesterd", DbType.Decimal, _EdCodeSemesterd);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("TRNS_LINE_ID");
            table.Columns.Add("LINE_NO");
            table.Columns.Add("LINE_DESCR_AR");
            table.Columns.Add("BUS_NO");
            table.Columns.Add("FEE_ITEM_VALUE");

            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return table;
        }
	}
    
    }
