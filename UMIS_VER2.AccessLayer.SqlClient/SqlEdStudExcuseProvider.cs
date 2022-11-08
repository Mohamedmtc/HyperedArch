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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudExcuse"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudExcuseProvider: SqlEdStudExcuseProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudExcuseProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudExcuseProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        //ED_STUD_EXCUSE_Latest_ID
        public override decimal GetLatestID(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_EXCUSE_Latest_ID", this.UseStoredProcedure);

            IDataReader reader = null;

            decimal maxID = 0;
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        maxID = decimal.Parse(reader[0].ToString());

                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        maxID = decimal.Parse(reader[0].ToString());
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return maxID;

        }

        public override DataTable GetAllForApprove(TransactionManager transactionManager, decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _AsFacultyInfoId, decimal _Lang, decimal _GsCodeReqStateId, decimal _EdCodeExcuseTypeId, string _StudName, string _StudFacultyCode, DateTime _FromDate, DateTime _ToDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_EXCUSE_GetForApprove", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@EdCodeExcuseTypeId", DbType.Decimal, _EdCodeExcuseTypeId);
            database.AddInParameter(commandWrapper, "@GsCodeReqStateId", DbType.Decimal, _GsCodeReqStateId);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, _StudName);
            database.AddInParameter(commandWrapper, "@STUD_FACULTY_CODE", DbType.String, string.IsNullOrEmpty(_StudFacultyCode) ? (object)DBNull.Value : _StudFacultyCode);
            database.AddInParameter(commandWrapper, "@FromDate", DbType.DateTime, _FromDate);
            database.AddInParameter(commandWrapper, "@ToDate", DbType.DateTime, _ToDate);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("EdStudExcuseId");
            table.Columns.Add("EdCodeExcuseTypeId");
            table.Columns.Add("GsCodeReqStatusId");
            table.Columns.Add("ReqDate");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("EdStudId");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override DataTable GetStudExcuses(TransactionManager transactionManager, decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _AsFacultyInfoId, decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_EXCUSE_GetStudExcuses", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("EdStudExcuseId");
            table.Columns.Add("EdStudSemesterId");
            table.Columns.Add("EdCodeExcuseTypeId");
            table.Columns.Add("ExcuseNum");
            table.Columns.Add("ExcuseNote");
            table.Columns.Add("ReqDate");
            table.Columns.Add("GsCodeReqStatusId");
            table.Columns.Add("ReqStatusDate");
            table.Columns.Add("AsFacultyInfoId");
            table.Columns.Add("EdStudId");
            table.Columns.Add("EdAcadYearId");
            table.Columns.Add("EdCodeSemesterId");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
                        table.Rows.Add(items);
                    }
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