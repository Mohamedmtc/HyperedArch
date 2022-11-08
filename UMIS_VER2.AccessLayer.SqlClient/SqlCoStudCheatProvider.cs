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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CoStudCheat"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlCoStudCheatProvider: SqlCoStudCheatProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlCoStudCheatProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlCoStudCheatProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods

        public override DataTable GetCheatIncedints(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CO_STUD_CHEAT_GetCheatIncedints", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CoControlId", DbType.Decimal, _coControlId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("CO_STUD_CHEAT_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("CHEAT_DATE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("CHEAT_DTL");

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

                //Create Collection
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() };
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

        public override DataTable GetControlExams(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CO_STUD_CHEAT_GetControlExams", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CoControlId", DbType.Decimal, _coControlId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ED_EXAM_SCHDL_ID");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_CODE");

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

                //Create Collection
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

        public override DataTable GetControlExamCommittees(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _edExamSchdlId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CO_STUD_CHEAT_GetControlExamCommittees", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CoControlId", DbType.Decimal, _coControlId);
            database.AddInParameter(commandWrapper, "@EdExamSchdlId", DbType.Decimal, _edExamSchdlId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("CO_EXAM_COMMITTEE_ID");
            table.Columns.Add("COMM_NAME_EN");

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

                //Create Collection
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

        public override DataTable GetControlExamCommitteeMembers(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _edExamSchdlId, System.Decimal _coExamCommitteeId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CO_STUD_CHEAT_GetControlExamCommitteeMembers", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CoControlId", DbType.Decimal, _coControlId);
            database.AddInParameter(commandWrapper, "@EdExamSchdlId", DbType.Decimal, _edExamSchdlId);
            database.AddInParameter(commandWrapper, "@CoExamCommitteeId", DbType.Decimal, _coExamCommitteeId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("HEAD_FLAG");
            table.Columns.Add("CO_CONTROL_MEMBERS_ID");
            table.Columns.Add("SC_DEG_DESCR_AR");
            table.Columns.Add("SC_DEG_DESCR_EN");
            table.Columns.Add("MEMBER_NAME_AR");
            table.Columns.Add("MEMBER_NAME_EN");

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

                //Create Collection
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
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

        public override DataTable GetControlExamCommitteeStudents(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _edExamSchdlId, System.Decimal _coExamCommitteeId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CO_STUD_CHEAT_GetControlExamCommitteeStudents", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CoControlId", DbType.Decimal, _coControlId);
            database.AddInParameter(commandWrapper, "@EdExamSchdlId", DbType.Decimal, _edExamSchdlId);
            database.AddInParameter(commandWrapper, "@CoExamCommitteeId", DbType.Decimal, _coExamCommitteeId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");

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

                //Create Collection
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

        public override DataTable GetControlExamDetails(TransactionManager transactionManager, System.Decimal _edExamSchdlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CO_STUD_CHEAT_GetControlExamDetails", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdExamSchdlId", DbType.Decimal, _edExamSchdlId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("EXAM_DATE");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");

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

                //Create Collection
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

        #endregion
	}
}