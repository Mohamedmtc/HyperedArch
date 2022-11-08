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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudAcadWarn"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudAcadWarnProvider: SqlEdStudAcadWarnProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudAcadWarnProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudAcadWarnProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Custom Methods
        public override DataTable GetStudsForAcademicWarning(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _lang, System.Decimal _cGPA, System.Decimal _edCodelevelId,System.Decimal _dpEntityMainId, System.Decimal __majEntityMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudsForAcademicWarning", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _lang);
            database.AddInParameter(commandWrapper, "@CGPA", DbType.Decimal, _cGPA);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _edCodelevelId);
            database.AddInParameter(commandWrapper, "@DpEntityMainId", DbType.Decimal, _dpEntityMainId);
            database.AddInParameter(commandWrapper, "@MajEntityMainId", DbType.Decimal, __majEntityMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("StudCode");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("AccumGpa");
            table.Columns.Add("Level");
            table.Columns.Add("MAX_SEQ_NO");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

        public override DataTable GetAllAcademicWarningForView(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _lang, System.String _studCode, System.Decimal _warnNo, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCodeLevelId, System.Decimal _asCodeDegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAllAcademicWarningForView", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _lang);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _studCode);
            database.AddInParameter(commandWrapper, "@WarnNo", DbType.Decimal, _warnNo);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _edCodeLevelId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _asCodeDegreeClassId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudAcadWarnId");
            table.Columns.Add("EdStudId");
            table.Columns.Add("StudCode");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("DecisionDate");
            table.Columns.Add("SeqNo");
            table.Columns.Add("StudCgpa");
            table.Columns.Add("LevelDescrAr");
            table.Columns.Add("LevelDescrEn");
            table.Columns.Add("CnclFlg");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString() };
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

        public override DataTable GetStudentEmails(TransactionManager transactionManager, System.Decimal _edStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentEmails", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _edStudId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("Email");
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
        #endregion
    }
}