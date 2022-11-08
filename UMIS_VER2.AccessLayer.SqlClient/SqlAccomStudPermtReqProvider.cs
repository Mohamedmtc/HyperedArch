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

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AccomStudPermtReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAccomStudPermtReqProvider: SqlAccomStudPermtReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAccomStudPermtReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAccomStudPermtReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }
        #region CustomMethods
        public override DataTable GetAccomStudPermtRequests(decimal AcadYearID, decimal SemesterID, decimal AsFacultyinfoId, decimal DegreeId, decimal MajorId, decimal MinorId, decimal levelId, string StudName,decimal LangNum, decimal NamePolicy,string StudCode, int CodeReqState, int RequestType)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("GetAccomStudPermtRequests", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("AcadYearID", SqlDbType.Decimal).Value = AcadYearID;
            command.Parameters.Add("SemesterID", SqlDbType.Decimal).Value = SemesterID;
            command.Parameters.Add("AsFacultyinfoId", SqlDbType.Decimal).Value = AsFacultyinfoId;
            command.Parameters.Add("DegreeId", SqlDbType.Decimal).Value = DegreeId;
            command.Parameters.Add("MajorId", SqlDbType.Decimal).Value = MajorId;
            command.Parameters.Add("MinorID", SqlDbType.Decimal).Value = MinorId;
            command.Parameters.Add("levelId", SqlDbType.Decimal).Value = levelId;
            command.Parameters.Add("StudName", SqlDbType.NVarChar).Value = StudName;
            command.Parameters.Add("LangNum", SqlDbType.Decimal).Value = LangNum;
            command.Parameters.Add("NamePolicy", SqlDbType.Decimal).Value = NamePolicy;
            command.Parameters.Add("StudCode", SqlDbType.NVarChar).Value = StudCode;
            command.Parameters.Add("CodeReqState", SqlDbType.Int).Value = CodeReqState;
            command.Parameters.Add("RequestType", SqlDbType.Int).Value = RequestType;

            conn.Open();

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();

            return table;

        }
        #endregion

    }
}