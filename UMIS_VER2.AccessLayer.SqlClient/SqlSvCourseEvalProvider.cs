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

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SvCourseEval"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSvCourseEvalProvider: SqlSvCourseEvalProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSvCourseEvalProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSvCourseEvalProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override DataTable GetCourses_ForView(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId, string CourseCode, string CourseDesc, decimal PubFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_COURSE_EVAL_GetCourses_ForView", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfo", DbType.Decimal, AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, CourseCode);
            database.AddInParameter(commandWrapper, "@courseDesc", DbType.String, CourseDesc);
            database.AddInParameter(commandWrapper, "@pubFlg", DbType.Decimal, PubFlg);
            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("NoOfVotes");
            table.Columns.Add("SV_COURSE_EVAL_ID");
            table.Columns.Add("PUB_FLG");
            table.Columns.Add("REG_FLG");
            table.Columns.Add("RSLT_FLG");
            table.Columns.Add("SEMESTER_EN");
            table.Columns.Add("SEMESTER_AR");
            table.Columns.Add("ACAD_YEAR_EN");
            table.Columns.Add("ACAD_YEAR_AR");
            table.Columns.Add("FACULTY_EN");
            table.Columns.Add("FACULTY_AR");
            table.Columns.Add("Title");
            table.Columns.Add("StartDate");
            table.Columns.Add("EndDate");
            table.Columns.Add("Percentage");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString() };
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


        public override DataTable GetCoursesNeedStuff(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal SaStfMamberId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStaff_Courses", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@SaStfMamberId", DbType.Decimal, SaStfMamberId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("SA_STF_MAMBER_ID");
            


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()};
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

        /*--task 15565 -- maha 24-12-2020---*/
        public override DataTable GetCoursesNeedStuff_Mod(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal SaStfMamberId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStaff_Courses_Mod", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@SaStfMamberId", DbType.Decimal, SaStfMamberId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("SA_STF_MAMBER_ID");



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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
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
        public override DataTable GetStuffCoursesSections(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal EdCourseId, decimal SaStfMamberId,decimal GroupCodeId=0)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStaff_CourseSection", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@SaStfMamberId", DbType.Decimal, SaStfMamberId);
            database.AddInParameter(commandWrapper, "@GroupCodeId", DbType.Decimal, GroupCodeId);
            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GROUP_ORDER");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_Ar");
            table.Columns.Add("SA_STF_MAMBER_ID");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_AR");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_EN");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_ID");



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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                         reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()
                                       ,reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
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

        public override DataTable GetStuffMemberRatings(TransactionManager transactionManager, decimal SaStfMamberId, decimal SectionId, decimal evalItemId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStuffMemberRatings", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SaStfMamberId", DbType.Decimal, SaStfMamberId);
            database.AddInParameter(commandWrapper, "@SectionId", DbType.Decimal, SectionId);
            database.AddInParameter(commandWrapper, "@evalItemId", DbType.Decimal, evalItemId);
            database.AddInParameter(commandWrapper, "@edAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@edCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@edCourseId", DbType.Decimal, EdCourseId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();

            table.Columns.Add("DESCR_Ar");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("RateCount");



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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString()};
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


        public override DataTable GetStudEvalForStaff(TransactionManager transactionManager, decimal SaStfMamberId, decimal SectionId, decimal evalItemId, decimal courseEvalId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStudEvalForStafF", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SaStfMamberId", DbType.Decimal, SaStfMamberId);
            database.AddInParameter(commandWrapper, "@SectionId", DbType.Decimal, SectionId);
            database.AddInParameter(commandWrapper, "@evalItemId", DbType.Decimal, evalItemId);
            database.AddInParameter(commandWrapper, "@courseEvalID", DbType.Decimal, courseEvalId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();

            table.Columns.Add("DESCR_Ar");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("RateCount");



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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable GetCourseEvalDetails(TransactionManager transactionManager, decimal SvCourseEvalId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetCourse_EvalDtls", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SvCourseEvalId", DbType.Decimal, SvCourseEvalId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("DESCR_Ar");



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
                    object[] items = { reader[0].ToString(), reader[1].ToString()};
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
        
        


        public override DataTable GetCourses_ForSet(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_COURSE_EVAL_GetCourses_ForSet", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfo", DbType.Decimal, AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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
        public override TList<SvCourseEval> GetByEdAcadYearIdEdCodeSemesterIdEdCourseId(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_COURSE_EVAL_GetByEdAcadYearIdEdCodeSemesterIdEdCourseId", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);

            IDataReader reader = null;

          //Create Collection
            TList<SvCourseEval> rows = new TList<SvCourseEval>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SV_COURSE_EVAL_GetByEdAcadYearIdEdCodeSemesterIdEdCourseId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "SV_COURSE_EVAL_GetByEdAcadYearIdEdCodeSemesterIdEdCourseId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
            
        }
        //Marwa 22/12/2021 17608
        public override TList<SvCourseEval> GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdSvCourseEvalID(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId, decimal SvCoursEvalID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_COURSE_EVAL_GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdSvCourseEvalID", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@SVCourseEvalID", DbType.Decimal, SvCoursEvalID);

            IDataReader reader = null;

            //Create Collection
            TList<SvCourseEval> rows = new TList<SvCourseEval>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SV_COURSE_EVAL_GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdSvCourseEvalID", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "SV_COURSE_EVAL_GetByEdAcadYearIdEdCodeSemesterIdEdCourseId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;

        }
        //Marwa 27/12/2021 17608
        public override string CHECKValidateDateCourseEvaluate(TransactionManager transactionManager, decimal svCourseEvalId, decimal EdAcadYearId, decimal EdCodeSemesterId, DateTime EvalDate, DateTime EvalDueDate, decimal SvCourseEvalId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHECKValidateDateCourseEvaluate", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, svCourseEvalId);
            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EvalDate", DbType.DateTime, EvalDate);
            database.AddInParameter(commandWrapper, "@EvalDueDate", DbType.DateTime, EvalDueDate);
            database.AddInParameter(commandWrapper, "@SvCourseEvalId", DbType.String, SvCourseEvalId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();

            table.Columns.Add("CheckCourseEvalDate");
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
            return table.Rows[0][0].ToString();

        }
        //Marwa 27/12/2021 17608
        public override DataTable GetCourseEvalution(TransactionManager transactionManager, decimal AcadYearId, decimal SemesterId, decimal MainId, string CourseIds)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseEvalution", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, AcadYearId);
            database.AddInParameter(commandWrapper, "@SemesterId", DbType.Decimal, SemesterId);
            database.AddInParameter(commandWrapper, "@MainId", DbType.Decimal, MainId);
            database.AddInParameter(commandWrapper, "@CourseIds", DbType.String, CourseIds);
 

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();

            table.Columns.Add("SV_COURSE_EVAL_ID");
            table.Columns.Add("EVAL_TITLE");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString() };
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
     
        public override bool GetCourses_Delete(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_COURSE_EVAL_GetCourses_Delete", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);

            bool found = false;


            try
            {
                int results = 0;

                if (transactionManager != null)
                {
                    results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    results = Utility.ExecuteNonQuery(database, commandWrapper);
                }

                found = true;
            }
            catch
            {
                found = false;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;
        }
        public override DataTable GetEvaluatedCourses(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetEvaluatedCourses", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfo", DbType.Decimal, AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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
        //Task No:5540, Made By:shaza ,Desc: get course evaluation based on degree class ,Date: 16-4-2019
        public override DataTable GetEvaluatedCoursesByDegreeClass(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId, decimal DegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetEvaluatedCoursesByDegreeClass", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfo", DbType.Decimal, AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@DegreeClassId", DbType.Decimal, DegreeClassId);
            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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
        //End
        public override DataTable GetEvalCourseTemplt(TransactionManager transactionManager, decimal EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_COURSE_EVAL_GetTemplt", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("SV_COURSE_EVAL_ID");
            table.Columns.Add("FACULTY_EN");
            table.Columns.Add("FACULTY_AR");
            table.Columns.Add("Title");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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

        public override bool CourseEvalTemplt_Delete(TransactionManager transactionManager, decimal EdCourseEvalId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_COURSE_EVAL_Templt_Delete", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@COURSEEVALID", DbType.Decimal, EdCourseEvalId);
            
            bool found = false;


            try
            {
                int results = 0;

                if (transactionManager != null)
                {
                    results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    results = Utility.ExecuteNonQuery(database, commandWrapper);
                }

                found = true;
            }
            catch
            {
                found = false;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;
        }

        public override bool CopyTemplateToCourses(TransactionManager transactionManager, decimal? EntityMainID, decimal SeUserID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_COURSE_EVL_COPY_FROM_TEMPLATE", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EntityMainID", DbType.Decimal, EntityMainID);
            database.AddInParameter(commandWrapper, "@SeUserID", DbType.Decimal, SeUserID);

            bool found = false;


            try
            {
                int results = 0;

                if (transactionManager != null)
                {
                    results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    results = Utility.ExecuteNonQuery(database, commandWrapper);
                }

                found = true;
            }
            catch
            {
                found = false;
                throw;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;
        }
        #endregion
    }
}