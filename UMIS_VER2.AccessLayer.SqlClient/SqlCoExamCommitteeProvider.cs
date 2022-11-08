#region Using directives

using System;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CoExamCommittee"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlCoExamCommitteeProvider: SqlCoExamCommitteeProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlCoExamCommitteeProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlCoExamCommitteeProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Method
        /*---custom Method --added by maha 01-6-2021   task 16756--*/
        public override DataTable ValidateExamCommitteChaneCapacity(decimal CoExamCommitteID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("dbo.Validate_ExamCommitteChaneCapacity", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Co_ExamCommitteID", DbType.Decimal).Value = CoExamCommitteID;

            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            return table;
        }

        public override DataTable UpdateNextSeatFromTo(decimal CoExamCommitteID, decimal DifferanceCapacityVal)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("dbo.UpdateNextSeatFromTo_NextCommitteData", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Co_ExamCommitteID", DbType.Decimal).Value = CoExamCommitteID;
            command.Parameters.Add("@DifferaceCapacityVal", DbType.Decimal).Value = DifferanceCapacityVal;
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