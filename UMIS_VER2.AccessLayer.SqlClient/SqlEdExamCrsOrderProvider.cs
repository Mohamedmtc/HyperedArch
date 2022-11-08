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
using UMIS_VER2.AccessLayer.Bases;
using System.Data.SqlClient;
using System.Configuration;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdExamCrsOrder"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdExamCrsOrderProvider: SqlEdExamCrsOrderProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdExamCrsOrderProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdExamCrsOrderProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetByEdAcadPlanDtlCoursesId(TransactionManager transactionManager, System.Decimal? _edAcadPlanHdrId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.EXAM_CRS_ORDER_GetByEdAcadPlanDtlId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadPlanHdrId", DbType.Decimal, _edAcadPlanHdrId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_ACAD_PLAN_DTL_ID");
            table.Columns.Add("ED_ACAD_PLAN_HDR_ID");
            table.Columns.Add("ENT_COURSE_PKG_HDR_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_EXAM_CRS_ORDER_ID");
            table.Columns.Add("DAY_ORDER");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("SE_USER_ID");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         , reader[5].ToString(), reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         , reader[5].ToString(), reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString()};
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