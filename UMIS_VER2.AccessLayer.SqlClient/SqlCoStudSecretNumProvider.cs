#region Using directives

using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using UMIS_VER2.BusinessLyer;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
    ///<summary>
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CoStudSecretNum"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlCoStudSecretNumProvider : SqlCoStudSecretNumProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlCoStudSecretNumProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlCoStudSecretNumProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Custom Methods

        public override DataTable GetStudSecretNum(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal? ENT_MAIN_ID, System.Decimal ED_CODE_LEVEL_ID,System.Decimal ED_EXAM_TYPE_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStudSecretNum", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, AS_FACULTY_INFO_ID);
            database.AddInParameter(commandWrapper, "@ENT_MAIN_ID", DbType.Decimal, ENT_MAIN_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_LEVEL_ID", DbType.Decimal, ED_CODE_LEVEL_ID);
            database.AddInParameter(commandWrapper, "@ED_EXAM_TYPE_ID", DbType.Decimal, ED_EXAM_TYPE_ID);

            IDataReader reader = null;
            DataTable table = new DataTable();

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

                table.Load(reader);

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        public override DataTable DeleteStudSecretNum(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ENT_MAIN_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_DeleteStudSecretNum", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, AS_FACULTY_INFO_ID);
            database.AddInParameter(commandWrapper, "@ENT_MAIN_ID", DbType.Decimal, ENT_MAIN_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_LEVEL_ID", DbType.Decimal, ED_CODE_LEVEL_ID);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, ED_COURSE_ID);

            IDataReader reader = null;
            DataTable table = new DataTable();

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

                table.Load(reader);

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        public override DataTable GetStudSerialNumStatastics(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStudSecretNumSts", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, AS_FACULTY_INFO_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_LEVEL_ID", DbType.Decimal, ED_CODE_LEVEL_ID);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, ED_COURSE_ID);

            IDataReader reader = null;
            DataTable table = new DataTable();

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

                table.Load(reader);

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        public override DataTable GetStudToCreateSerialNum(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID, System.Decimal DepId, System.Decimal MajorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStudToCreateSerialNum", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, AS_FACULTY_INFO_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_LEVEL_ID", DbType.Decimal, ED_CODE_LEVEL_ID);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, ED_COURSE_ID);
            database.AddInParameter(commandWrapper, "@DepId", DbType.Decimal, DepId);
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, MajorId);

            IDataReader reader = null;
            DataTable table = new DataTable();

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

                table.Load(reader);

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        public override DataTable GetStudSerialNum(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID, System.Decimal ExamTypeId, System.Decimal DepId, System.Decimal MajorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStudSecretNumDtl", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, AS_FACULTY_INFO_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_LEVEL_ID", DbType.Decimal, ED_CODE_LEVEL_ID);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, ED_COURSE_ID);
            database.AddInParameter(commandWrapper, "@EdCdeExamTypeId", DbType.Decimal, ExamTypeId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, DepId);
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, MajorId);
            
            IDataReader reader = null;
            DataTable table = new DataTable();

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

                table.Load(reader);

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        public override DataTable GetSECRET_NUM(TransactionManager transactionManager, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal ED_ACAD_YEAR_ID, System.String SECRET_NUM)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetSECRET_NUM", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@SecretNum", DbType.String, SECRET_NUM);

            IDataReader reader = null;
            DataTable table = new DataTable();

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

                table.Load(reader);

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