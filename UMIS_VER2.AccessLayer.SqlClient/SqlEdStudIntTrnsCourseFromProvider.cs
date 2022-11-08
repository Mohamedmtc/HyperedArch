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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudIntTrnsCourseFrom"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudIntTrnsCourseFromProvider: SqlEdStudIntTrnsCourseFromProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudIntTrnsCourseFromProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudIntTrnsCourseFromProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region custom Methods
        public override DataTable GetStudentFromCourses(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "ED_STUD_INT_TRNS_COURSE_FROM_GetByEdStudIntTrnsId", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudIntTrnsId", DbType.Decimal, _edStudIntTrnsId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EDSTUDINTTRNSCOURSEFROMID");
            table.Columns.Add("EDCOURSEID");
            table.Columns.Add("AUDITFLG");
            table.Columns.Add("REPEATFLG");
            table.Columns.Add("ISLAST");
            table.Columns.Add("ASFACULTYINFOID");
            table.Columns.Add("EDCODECOURSESTATUSID");
            table.Columns.Add("EDCODEGRADINGID");
            table.Columns.Add("COURSEDEGREE");
            table.Columns.Add("COURSEPOINT");
            table.Columns.Add("ENTPOLICYGRADINGHDRID");
            table.Columns.Add("GSCODEPASSFAILID");
            table.Columns.Add("ADDGPAFLG");
            table.Columns.Add("ENTPOLICYASSESSHDRID");
            table.Columns.Add("INCOMPFLG");
            table.Columns.Add("EDACADYEARID");
            table.Columns.Add("EDCODESEMESTERID");
            table.Columns.Add("EDSTUDID");
            table.Columns.Add("EDSTUDINTTRNSID");
            table.Columns.Add("ADDMJRGPAFLG");
            table.Columns.Add("ENTCOURSEPKGDTLID");
            table.Columns.Add("EquivalentCourse");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString()
                                     , reader[7].ToString() , reader[8].ToString(),  reader[9].ToString()
                                     , reader[10].ToString() , reader[11].ToString(),  reader[12].ToString()
                                     , reader[13].ToString() , reader[14].ToString(),  reader[15].ToString()
                                     , reader[16].ToString() , reader[17].ToString(),  reader[18].ToString(),
                                     reader[19].ToString(),reader[20].ToString(),reader[21].ToString()};
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
        public override DataTable GetStudentFromCoursesAll(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetStudentFromCoursesAll", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudIntTrnsId", DbType.Decimal, _edStudIntTrnsId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_INT_TRNS_COURSE_FROM_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("AUDIT_FLG");
            table.Columns.Add("REPEAT_FLG");
            table.Columns.Add("IS_LAST");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("ED_CODE_COURSE_STATUS_ID");
            table.Columns.Add("ED_CODE_GRADING_ID");
            table.Columns.Add("COURSE_DEGREE");
            table.Columns.Add("COURSE_POINT");
            table.Columns.Add("ENT_POLICY_GRADING_HDR_ID");
            table.Columns.Add("GS_CODE_PASS_FAIL_ID");
            table.Columns.Add("ADD_GPA_FLG");
            table.Columns.Add("ADD_MJRGPA_FLG");
            table.Columns.Add("ENT_POLICY_ASSESS_HDR_ID");
            table.Columns.Add("INCOMP_FLG");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_STUD_INT_TRNS_ID");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString()
                                     , reader[7].ToString() , reader[8].ToString(),  reader[9].ToString()
                                     , reader[10].ToString() , reader[11].ToString(),  reader[12].ToString()
                                     , reader[13].ToString() , reader[14].ToString(),  reader[15].ToString()
                                     , reader[16].ToString() , reader[17].ToString(),  reader[18].ToString(),
                                     reader[19].ToString()};
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