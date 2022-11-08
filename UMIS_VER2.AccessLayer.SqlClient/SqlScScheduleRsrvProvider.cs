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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScScheduleRsrv"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScScheduleRsrvProvider: SqlScScheduleRsrvProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScScheduleRsrvProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScScheduleRsrvProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
	//added by mmq at 26-07-2016
        //edit byn nashassan 9/8/2016 add _SC_SCHEDULE_DTL_ID parameter 
        public override void InsertAndUpdateGroup_SCHEDULE_RSRV(TransactionManager transactionManager, System.String _SC_GROUP_INFO_IDs, System.Decimal _AS_FACULTY_INFO_ID, System.Decimal _ed_code_semester_id, System.Decimal _d_acad_year_id, System.Decimal _ed_code_teaching, System.Decimal _ed_course_id, System.Decimal _SC_SCHEDULE_DTL_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_Insert_And_Update_Group_SCHEDULE_RSRV", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SC_GROUP_INFO_IDs", DbType.String, _SC_GROUP_INFO_IDs);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, _AS_FACULTY_INFO_ID);
            database.AddInParameter(commandWrapper, "@ed_code_semester_id", DbType.Decimal, _ed_code_semester_id);
            database.AddInParameter(commandWrapper, "@d_acad_year_id", DbType.Decimal, _d_acad_year_id);
            database.AddInParameter(commandWrapper, "@ed_code_teaching", DbType.Decimal, _ed_code_teaching);
            database.AddInParameter(commandWrapper, "@ed_course_id", DbType.Decimal, _ed_course_id);
            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_DTL_ID", DbType.Decimal, _SC_SCHEDULE_DTL_ID);
        //    database.AddInParameter(commandWrapper, "@_AS_FACULTY_INFO_ID", DbType.Decimal, _AS_FACULTY_INFO_ID);
          
            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            
        }

        //added by mmq at 28-07-2016 
        //edit byn nashassan 9/8/2016 add _SC_SCHEDULE_DTL_ID parameter 
        public override DataTable GetSCGroupInfoInScSchReserv(TransactionManager transactionManager, System.Decimal _ED_COURSE_ID, System.Decimal _ED_CODE_SEMESTER_ID, System.Decimal _ED_ACAD_YEAR_ID, System.Decimal _ED_CODE_COURSE_TEACHING_ID, System.Decimal _AS_FACULTY_INFO_ID, System.Decimal _SC_SCHEDULE_DTL_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSCGroupInfoInScSchReserv", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, _ED_COURSE_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, _ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, _ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_COURSE_TEACHING_ID", DbType.Decimal, _ED_CODE_COURSE_TEACHING_ID);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, _AS_FACULTY_INFO_ID);
            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_DTL_ID", DbType.Decimal, _SC_SCHEDULE_DTL_ID);
         
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_GROUP_INFO_ID");
          
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
                    object[] items = { reader[0].ToString()};
                    table.Rows.Add(items);
                }
            }
            finally
            {
                commandWrapper = null;
            }

            return table;
        }






    
    }
}