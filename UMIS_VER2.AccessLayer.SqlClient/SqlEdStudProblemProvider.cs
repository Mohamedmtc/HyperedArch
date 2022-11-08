#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudProblem"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudProblemProvider: SqlEdStudProblemProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudProblemProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudProblemProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetByViolatStd(TransactionManager transactionManager, System.Decimal? _AsFacultyInfoId, System.Decimal? _AcadYearId, System.Decimal? _EdCodeSemesterId, string _StudFacultyCode, System.Decimal? _GsCdeViolCatId,
              System.Decimal? _GsCdeViolId, DateTime? _ViolFromDate, DateTime? _ViolToDate, string _StudentName, System.Decimal? _NamePolicy, bool? _IsEnglish, string _STFCode,decimal?AsCodeDegreeClassId=null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ed_stud_problem_Students", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, _AcadYearId.HasValue ? _AcadYearId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId.HasValue ? _EdCodeSemesterId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId.HasValue ? _AsFacultyInfoId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudFacultyCode", DbType.String, string.IsNullOrEmpty(_StudFacultyCode) ? (object)DBNull.Value : _StudFacultyCode);
            database.AddInParameter(commandWrapper, "@GsCdeViolCatId", DbType.Decimal, _GsCdeViolCatId.HasValue ? _GsCdeViolCatId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdeViolId", DbType.Decimal, _GsCdeViolId.HasValue ? _GsCdeViolId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@ViolFromDate", DbType.Date, _ViolFromDate.HasValue ? (object)_ViolFromDate : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@ViolToDate", DbType.Date, _ViolToDate.HasValue ? (object)_ViolToDate : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudentName", DbType.String, string.IsNullOrEmpty(_StudentName) ? (object)DBNull.Value : (object)_StudentName);
            database.AddInParameter(commandWrapper, "@IsEnglish", DbType.Boolean, _IsEnglish.HasValue ? (_IsEnglish.Value ? 1 : 0) : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy.HasValue ? _NamePolicy : (object)DBNull.Value);
            //Menna 12-02-2020 tfs 13068
            database.AddInParameter(commandWrapper, "@STFCode", DbType.String, string.IsNullOrEmpty(_STFCode) ? (object)DBNull.Value : _STFCode);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId.HasValue? AsCodeDegreeClassId : (object)DBNull.Value);//walaa 25/7/2022


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("PROB_DATE");
            table.Columns.Add("GS_CDE_VIOL_ID");
            table.Columns.Add("ERP_ORG_TREE_ID_FRM");
            table.Columns.Add("ERP_ORG_TREE_ID_TO");
            table.Columns.Add("DECISION");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("ed_stud_problem_ID");
            table.Columns.Add("EDSTUDID");
            table.Columns.Add("GS_CDE_VIOL_CAT_ID");
            table.Columns.Add("CDESCRAR");
            table.Columns.Add("CDESCREN");
            table.Columns.Add("FULLNAMEAR");
            table.Columns.Add("FULLNAMEEN");
            table.Columns.Add("SA_STF_MEMBER_ID");
            table.Columns.Add("AcadYearDescAR");
            table.Columns.Add("AcadYearDescEN");
            table.Columns.Add("CodeSemesterDescAR");
            table.Columns.Add("CodeSemesterDescEN");
         

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString() };
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
    }
}
