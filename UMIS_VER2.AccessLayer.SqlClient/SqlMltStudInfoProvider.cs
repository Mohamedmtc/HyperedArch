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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="MltStudInfo"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlMltStudInfoProvider: SqlMltStudInfoProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlMltStudInfoProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlMltStudInfoProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable StudentsSearch(TransactionManager transactionManager, System.Decimal _AsFacultyInfoID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelId, System.Decimal _MltOrgTreeId, System.String _StudCode, System.Decimal _VaccSerial, System.Decimal _MdiCdeVaccId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.MDI_STUD_VACC_BULK_SRCH", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, _AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@MltOrgTreeId", DbType.Decimal, _MltOrgTreeId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@VaccSerial", DbType.Decimal, _VaccSerial);
            database.AddInParameter(commandWrapper, "@MdiCdeVaccId", DbType.Decimal, _MdiCdeVaccId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("MLT_STUD_INFO_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("DGR_AR");
            table.Columns.Add("DGR_EN");
            table.Columns.Add("SENIORITY_LVL");
            table.Columns.Add("STUD_ORG_PATH_AR");
            table.Columns.Add("STUD_ORG_PATH_EN");
            table.Columns.Add("VACC_DATE");
            table.Columns.Add("VACC_SERIAL");

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
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString(),  reader[8].ToString()
                                     , reader[9].ToString() , reader[10].ToString(),  reader[11].ToString()};
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
        public override DataTable StudentsSearch(TransactionManager transactionManager, System.Decimal _AsFacultyInfoID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelId, System.Decimal _MltOrgTreeId, System.String _StudCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.MLT_STUD_INFO_SRCH", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, _AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@MltOrgTreeId", DbType.Decimal, _MltOrgTreeId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("MLT_STUD_INFO_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("DGR_AR");
            table.Columns.Add("DGR_EN");
            table.Columns.Add("SENIORITY_LVL");
            table.Columns.Add("STUD_ORG_PATH_AR");
            table.Columns.Add("STUD_ORG_PATH_EN");
            table.Columns.Add("ED_STUD_ID");

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
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString(),  reader[8].ToString()};
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

        public override DataTable StudentsSearchForAdd(TransactionManager transactionManager, System.Decimal _AsFacultyInfoID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelId, System.Decimal _MltOrgTreeId, System.String _StudCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.MLT_STUD_INFO_GetForAdd", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, _AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@MltOrgTreeId", DbType.Decimal, _MltOrgTreeId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("MLT_STUD_INFO_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("DGR_AR");
            table.Columns.Add("DGR_EN");
            table.Columns.Add("SENIORITY_LVL");

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
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString()};
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