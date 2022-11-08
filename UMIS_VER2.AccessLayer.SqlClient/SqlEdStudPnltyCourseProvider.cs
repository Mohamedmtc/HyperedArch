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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudPnltyCourse"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudPnltyCourseProvider: SqlEdStudPnltyCourseProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudPnltyCourseProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudPnltyCourseProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}


        public override DataTable GetStudPenltiesByViolAndSemesterIds(TransactionManager transactionManager, System.Decimal? _EdStudSemesterId, System.Decimal? _EdStudViolId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudPenltiesByViolAndSemesterIds", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, _EdStudSemesterId.HasValue ? _EdStudSemesterId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdStudViolId", DbType.Decimal, _EdStudViolId.HasValue ? _EdStudViolId : (object)DBNull.Value);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("CREDIT_HOURS");
            table.Columns.Add("FAIL_FLAG");
            table.Columns.Add("CANCEL_REGISTERATION_FLAG");

            table.Columns.Add("ED_STUD_VIOL_ID");
            table.Columns.Add("ED_STUD_PNLTY_COURSE_ID");
            table.Columns.Add("ED_STUD_COURSE_REG_ID");
            table.Columns.Add("ED_COURSE_ID");


            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()
                                         , reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()
                                         , reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()};
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
	}
}