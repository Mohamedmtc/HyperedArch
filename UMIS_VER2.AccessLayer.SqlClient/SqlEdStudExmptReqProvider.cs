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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudExmptReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudExmptReqProvider: SqlEdStudExmptReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudExmptReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudExmptReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        // MElshazly 7/7/2019 [10193]
        public override DataTable GetStudExemption(TransactionManager transactionManager, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId, System.DateTime? ReqDateFrom, System.DateTime? ReqDateTo, System.Decimal AsFacultyInfoId, System.Int32 ApproveFlg, System.Decimal EdStudId, System.Decimal ED_CDE_EXMPT_Id)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetStudExemption", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCodeSemsterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ReqDateFrom", DbType.DateTime, ReqDateFrom);
            database.AddInParameter(commandWrapper, "@ReqDateTo", DbType.DateTime, ReqDateTo);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Int32, ApproveFlg);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, EdStudId);
            database.AddInParameter(commandWrapper, "@ED_CDE_EXMPT_Id", DbType.Decimal, ED_CDE_EXMPT_Id);

            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudExemption"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudExemption"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        // MElshazly 7/7/2019 [10193]
        public override DataTable GetExemptStudents(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? AsCodeDegreeclassId,
            string StudCode, decimal? FlagExempt, decimal? AdmissionYear, decimal? LoadType, decimal? GsCodeMilitaryStateId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetExemptStudents", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, lang.HasValue ? (object)lang : DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, !string.IsNullOrEmpty(StudCode) ? (object)StudCode : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId.HasValue ? (object)EdAcadYearId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemId.HasValue ? (object)EdCodeSemId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId.HasValue ? (object)EntMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@FlagExempt", DbType.Decimal, FlagExempt.HasValue ? (object)FlagExempt : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeclassId.HasValue ? (object)AsCodeDegreeclassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAdmAcadYearId", DbType.Decimal, AdmissionYear.HasValue ? (object)AdmissionYear : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeLoadTypeId", DbType.Decimal, LoadType.HasValue ? (object)LoadType : DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCodeMilitaryStateId", DbType.Decimal, GsCodeMilitaryStateId.HasValue ? (object)GsCodeMilitaryStateId : DBNull.Value);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudCode");
            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("EdStudId");
            table.Columns.Add("ED_STUD_EXMPT_REQ_ID");
            table.Columns.Add("MAJOR_EN");
            table.Columns.Add("MAJOR_AR");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("NOtes");
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
                    object[] items = {
                                         reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                         reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString(),
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
    }
}