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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudInttransTemp"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudInttransTempProvider: SqlEdStudInttransTempProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudInttransTempProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudInttransTempProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetAllForView(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _type)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_INTTRANS_TEMP_GetAllForView", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Type", DbType.Decimal, _type);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdInttransRuleId");
            table.Columns.Add("EntMainId");
            table.Columns.Add("EntDescrAr");
            table.Columns.Add("EntDescrEn");
            table.Columns.Add("MinCgpa");
            table.Columns.Add("MaxStudNum");
            table.Columns.Add("StudCount");

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

        public override bool CancelAutomaticInttrans(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _type)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_INTTRANS_TEMP_CancelAutomaticInttrans", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Type", DbType.Decimal, _type);

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

        public override DataTable GetStuds(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _entMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_INTTRANS_TEMP_GetStuds", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("AccumGpa");

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
	}
}