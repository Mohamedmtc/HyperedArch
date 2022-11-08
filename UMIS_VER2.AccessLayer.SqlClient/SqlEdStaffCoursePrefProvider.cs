#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStaffCoursePref"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStaffCoursePrefProvider: SqlEdStaffCoursePrefProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStaffCoursePrefProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStaffCoursePrefProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetStffCoursePref(TransactionManager transactionManager, System.Decimal _ACAD_YEAR_ID, System.Decimal _CODE_SEMESTER_ID, System.Decimal _STF_MEMBER_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SP_GetStffCoursePref", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "ACAD_YEAR_ID", DbType.Decimal, _ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "CODE_SEMESTER_ID", DbType.Decimal, _CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "STF_MEMBER_ID", DbType.Decimal, _STF_MEMBER_ID);
            IDataReader reader = null;
            DataTable tmp = new DataTable();
            tmp.Columns.Add("ED_STAFF_COURSE_PREF_ID");
            tmp.Columns.Add("SA_STF_MEMBER_ID");
            tmp.Columns.Add("ED_ACAD_YEAR_ID");
            tmp.Columns.Add("ED_CODE_SEMESTER_ID");
            tmp.Columns.Add("ED_COURSE_ID");
            tmp.Columns.Add("COURSE_CODE");
            tmp.Columns.Add("COURSE_DESCR_AR");
            tmp.Columns.Add("COURSE_DESCR_EN");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()};
                    tmp.Rows.Add(items);
                }

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;

            //return rows;
        }
		
    }
}