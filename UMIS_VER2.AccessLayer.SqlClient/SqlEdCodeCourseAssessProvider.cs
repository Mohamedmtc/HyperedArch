#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using System.Collections;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCodeCourseAssess"/> entity.
	///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlEdCodeCourseAssessProvider : SqlEdCodeCourseAssessProviderBase
    {
        public override DataTable Get_couse_code(TransactionManager transactionManager, Hashtable htParameters)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_ENT_POLICY_ASSESS_COURSE_SRCH", this.UseStoredProcedure);

            //database.AddInParameter(commandWrapper, "@CourseCode", DbType.Decimal, htParameters["courseCode"]);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, htParameters["courseCode"] == string.Empty ? DBNull.Value : htParameters["courseCode"]);
            database.AddInParameter(commandWrapper, "@fac", DbType.Decimal, htParameters["faculty"]);
            database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, htParameters["EdBylawId"]);




            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ED_BYLAW_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("policy_en");
            table.Columns.Add("policy_ar");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("CREDIT_HOURS");


            // table.Columns.Add("ED_COURSE_id");
            table.Columns.Add("ENT_POLICY_ASSESS_HDR_ID");

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
                                     , reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString(),
                                     reader[8].ToString()
                                   };
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

        /// Creates a new <see cref="SqlEdCodeCourseAssessProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlEdCodeCourseAssessProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Custom Methods
        public override TList<EdCodeCourseAssess> GetByUniversity(TransactionManager transactionManager, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_CODE_COURSE_ASSESS_GetByUniversity", this.UseStoredProcedure);

            IDataReader reader = null;
            TList<EdCodeCourseAssess> rows = new TList<EdCodeCourseAssess>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByUniversity", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByUniversity", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override TList<EdCodeCourseAssess> GetByCourse(TransactionManager transactionManager, decimal asFacultyInfoID, decimal edCourseID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_CODE_COURSE_ASSESS_GetByCourse", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, edCourseID);
            IDataReader reader = null;
            TList<EdCodeCourseAssess> rows = new TList<EdCodeCourseAssess>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_CODE_COURSE_ASSESS_GetByCourse", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                int start = 0;
                int pageLength = int.MaxValue;
                int count;
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "ED_CODE_COURSE_ASSESS_GetByCourse", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            //if (rows.Count == 0)
            //    rows.Add(new EdCodeCourseAssess());
            return rows;
        }

        public override TList<EdCodeCourseAssess> GetByCourse(TransactionManager transactionManager, decimal asFacultyInfoID, decimal edCourseID, int EntPolicyAssessId, int EdAcadYearID, int EdCodeSemeterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            //DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_CODE_COURSE_ASSESS_GetByCourse", this.UseStoredProcedure);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseSemAssess", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, edCourseID);
            database.AddInParameter(commandWrapper, "@EntPolicyAssessId", DbType.Int32, EntPolicyAssessId);
            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Int32, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCodeSemeterId", DbType.Int32, EdCodeSemeterId);


            IDataReader reader = null;
            TList<EdCodeCourseAssess> rows = new TList<EdCodeCourseAssess>();
            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_CODE_COURSE_ASSESS_GetByCourse", rows));
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetCourseSemAssess", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                int start = 0;
                int pageLength = int.MaxValue;
                int count;
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "ED_CODE_COURSE_ASSESS_GetByCourse", rows));
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCourseSemAssess", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            //if (rows.Count == 0)
            //    rows.Add(new EdCodeCourseAssess());
            return rows;
        }

        public override TList<EdCodeCourseAssess> GetByMakeUpCourse(TransactionManager transactionManager, decimal asFacultyInfoID, decimal edCourseID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GETMakeUpCourseAsses", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, edCourseID);
            IDataReader reader = null;
            TList<EdCodeCourseAssess> rows = new TList<EdCodeCourseAssess>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GETMakeUpCourseAsses", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                int start = 0;
                int pageLength = int.MaxValue;
                int count;
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GETMakeUpCourseAsses", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return rows;
        }
        #endregion



        public override TList<EdCodeCourseAssess> GetCourseAssess(TransactionManager transactionManager, decimal asFacultyInfoID, string edCourseCode)
        {
             SqlDatabase database = new SqlDatabase(this.ConnectionString);
             DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetCourseAssess", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoID);
            database.AddInParameter(commandWrapper, "@edCourseCode", DbType.String, edCourseCode);
            IDataReader reader = null;
            TList<EdCodeCourseAssess> rows = new TList<EdCodeCourseAssess>();
         
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetCourseAssess", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                int start = 0;
                int pageLength = int.MaxValue;
                int count;
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCourseAssess", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return rows;
        }
    }
}