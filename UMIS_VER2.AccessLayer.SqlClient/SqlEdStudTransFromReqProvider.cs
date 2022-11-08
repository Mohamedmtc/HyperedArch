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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudTransFromReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudTransFromReqProvider: SqlEdStudTransFromReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudTransFromReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudTransFromReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override DataTable GetTransferFromFacultyRequests(TransactionManager transactionManager, decimal asFacultyInfoId, decimal edAcadYearId, decimal edCodeSemesterId, decimal gsCodeReqStatusId,
           DateTime? reqFromDate, DateTime? reqToDate, decimal asCodeDegreeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SP_Get_TransFromReq", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@GsCodeReqStatusId", DbType.Decimal, gsCodeReqStatusId);
            database.AddInParameter(commandWrapper, "@ReqFromDate", DbType.DateTime, reqFromDate != DateTime.MinValue ? (object)reqFromDate : System.DBNull.Value);
            database.AddInParameter(commandWrapper, "@ReqToDate", DbType.DateTime, reqToDate != DateTime.MinValue ? (object)reqToDate : System.DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId);
            IDataReader reader = null;
            DataTable table = new DataTable();


            table.Columns.Add("EdStudTransFromReqId");
            table.Columns.Add("EdStudId");
            table.Columns.Add("AsFacultyInfoId");
            table.Columns.Add("TransferReason");
            table.Columns.Add("EdAcadYearId");
            table.Columns.Add("EdCodeSemesterId");
            table.Columns.Add("ReqDate");
            table.Columns.Add("GsCodeReqStatusId");
            table.Columns.Add("IsApplied");
            table.Columns.Add("UnivName");
            table.Columns.Add("FacName");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");

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
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString(),  
                                     reader[8].ToString(),  reader[9].ToString(),  reader[10].ToString(),  reader[12].ToString(),  reader[13].ToString()};
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