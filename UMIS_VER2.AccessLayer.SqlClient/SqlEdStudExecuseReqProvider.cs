#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudExecuseReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudExecuseReqProvider: SqlEdStudExecuseReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudExecuseReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudExecuseReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        /*---custom Method --added by maha 3-9-2019   task 10883--*/
        public override DataTable GetAbsExecuseReqData(decimal facultyID, decimal AcadYearID, decimal CodeSemesterID, decimal DegreeTypeID, decimal DegreeID, decimal MajorID, decimal ReqStatus, string StudCode)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("dbo.SelectExecuseReqs", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@AcadYear", DbType.Decimal).Value = AcadYearID;
            command.Parameters.Add("@CodeSemester", DbType.Decimal).Value = CodeSemesterID;
            command.Parameters.Add("@FacultyID", DbType.String).Value = facultyID;
            command.Parameters.Add("@MajorID", DbType.String).Value = MajorID;
            command.Parameters.Add("@DegreeType", DbType.String).Value = DegreeTypeID;
            command.Parameters.Add("@Degree", DbType.Int32).Value = DegreeID;
            command.Parameters.Add("@StudCode", DbType.String).Value = StudCode;
            command.Parameters.Add("@StatusID", DbType.Decimal).Value = ReqStatus;
            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            return table;
        }
        public override DataTable SearchStudClearReq(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
         , System.Decimal _AsFacultyId, System.DateTime? _ReqFromDate, System.DateTime? _ReqToDate, System.Decimal? _GsCodeExecuseReasonId
         , System.Decimal? _GsCodeReqStatusId, System.String StudCode)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("dbo.SelectExecuseReqs", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ReqFromDate", DbType.DateTime).Value = _ReqFromDate;
            command.Parameters.Add("@ReqToDate", DbType.DateTime).Value = _ReqToDate;
            command.Parameters.Add("@EdAcadyearId", DbType.Decimal).Value = _EdAcadYearId;
            command.Parameters.Add("@EdCodeSemesterId", DbType.Decimal).Value = _EdCodeSemesterId;
            command.Parameters.Add("@GsCodeExecuseReasonId", DbType.Decimal).Value = _GsCodeExecuseReasonId;
            command.Parameters.Add("@AsFacultyId", DbType.Decimal).Value = _AsFacultyId;
            command.Parameters.Add("@StudCode", DbType.String).Value = StudCode;
            command.Parameters.Add("@GsCodeReqStatusId", DbType.Decimal).Value = _GsCodeReqStatusId;
            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            return table;            
        }

	}
}