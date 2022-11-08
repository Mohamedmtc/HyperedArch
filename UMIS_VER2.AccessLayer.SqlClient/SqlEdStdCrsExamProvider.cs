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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStdCrsExam"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStdCrsExamProvider: SqlEdStdCrsExamProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStdCrsExamProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStdCrsExamProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable Search(TransactionManager transactionManager, decimal CoControlRoomId, string StudCode, string CourseCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ApplyControlCelemRules_Search", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CoControlRoomId", DbType.Decimal, CoControlRoomId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, CourseCode);

            DataTable tbl = null;
            
            try
            {
                if (transactionManager != null)
                    tbl = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                else
                    tbl = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }
            finally
            {
                commandWrapper = null;
            }

            return tbl;
        }

        public override DataTable ViewAccumStudMark(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCdeExamType, decimal EdCodeLevelId, decimal EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ViewAccumStudMark", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCdeExamType", DbType.Decimal, EdCdeExamType);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, EdStudId);
            DataTable tbl = null;

            try
            {
                if (transactionManager != null)
                    tbl = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                else
                    tbl = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }
            finally
            {
                commandWrapper = null;
            }

            return tbl;
        }
        public override int InsrtStdCrsExamTypeForGrading(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdSemester, decimal ExamType, decimal EdCodeLevelId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.InsrtStdCrsExamTypeForGrading", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdSemester", DbType.Decimal, EdSemester);
            database.AddInParameter(commandWrapper, "@ExamType", DbType.Decimal, ExamType);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId);

            try
            {
                if (transactionManager != null)
                    return Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                else
                    return Utility.ExecuteNonQuery(database, commandWrapper);
            }
            finally
            {
                commandWrapper = null;
            }
            
        
        }

        public override int AccumStudMark(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal? EdCdeExamType, decimal EdCodeLevelId, decimal EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.AccumStudMark", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCdeExamType", DbType.Decimal, EdCdeExamType);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, EdStudId);

            try
            {
                if (transactionManager != null)
                    return Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                else
                    return Utility.ExecuteNonQuery(database, commandWrapper);
            }
            finally
            {
                commandWrapper = null;
            }
        }

        public override DataTable GetCrsExamResult(TransactionManager transactionManager, System.Decimal AcadYear, System.Decimal SemesterId,
              System.Decimal FacId, System.Decimal MajorId, System.Decimal LevelId,
              System.Decimal ExamTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetCrsExamResult", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, FacId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, MajorId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, LevelId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, AcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, SemesterId);
            database.AddInParameter(commandWrapper, "@EdCdeExamType", DbType.Decimal, ExamTypeId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("StudCount");
            table.Columns.Add("AprvdStudCount");


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
                                     , reader[4].ToString() , reader[5].ToString()};
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

        public override DataTable GetCrsExamStudResult(TransactionManager transactionManager, System.Decimal AcadYear, System.Decimal SemesterId,
          System.Decimal FacId, System.Decimal MajorId, System.Decimal LevelId,
          System.Decimal ExamTypeId, System.Decimal EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetCrsExamStudResult", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, FacId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, MajorId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, LevelId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, AcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, SemesterId);
            database.AddInParameter(commandWrapper, "@EdCdeExamType", DbType.Decimal, ExamTypeId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("COURSE_DEGREE");
            table.Columns.Add("ED_CODE_GRADING_ID");
            table.Columns.Add("SYMBOL_AR");
            table.Columns.Add("SYMBOL_EN");
            table.Columns.Add("GS_CODE_PASS_FAIL_ID");
            table.Columns.Add("PF_AR");
            table.Columns.Add("PF_EN");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
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
                                     , reader[4].ToString() , reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString()};
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

        public override bool ApproveCrsExmRslt(TransactionManager transactionManager, System.Decimal AcadYear, System.Decimal SemesterId,
       System.Decimal FacId, System.Decimal MajorId, System.Decimal LevelId,
       System.Decimal ExamTypeId, System.Decimal EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "ApproveCrsExmRslt", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, FacId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, MajorId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, LevelId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, AcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, SemesterId);
            database.AddInParameter(commandWrapper, "@EdCdeExamType", DbType.Decimal, ExamTypeId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(results);

        }

        public override bool CancelApproveCrsExmRslt(TransactionManager transactionManager, System.Decimal AcadYear, System.Decimal SemesterId,
       System.Decimal FacId, System.Decimal MajorId, System.Decimal LevelId,
       System.Decimal ExamTypeId, System.Decimal EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "CnclApproveCrsExmRslt", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, FacId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, MajorId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, LevelId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, AcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, SemesterId);
            database.AddInParameter(commandWrapper, "@EdCdeExamType", DbType.Decimal, ExamTypeId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(results);

        }

    }
}