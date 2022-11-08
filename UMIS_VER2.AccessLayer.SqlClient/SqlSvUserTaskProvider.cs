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
using System.Data.SqlClient;
using System.Configuration;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SvUserTask"/> entity.
	///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlSvUserTaskProvider : SqlSvUserTaskProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlSvUserTaskProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlSvUserTaskProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }


        #region Custom Method
        /*---custom Method --added by maha 21-8-2019   task 10817--*/
        public override DataTable GetUserTasksData( UMIS_VER2.BusinessLyer.SvUserTask obj, string FromDate, string ToDate)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("dbo.Proc_SelectUserTask", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@AcadYear", DbType.Decimal).Value = obj.EdAcadYearId;
            command.Parameters.Add("@CodeSemester", DbType.Decimal).Value = obj.EdCodeSemesterId;
            command.Parameters.Add("@FromDate", DbType.String).Value = FromDate;
            command.Parameters.Add("@ToDate", DbType.String).Value = ToDate;
            command.Parameters.Add("@TaskTitle", DbType.String).Value = obj.TaskTitle;
            command.Parameters.Add("@StatusID", DbType.Int32).Value = obj.SvCdeTaskStatusId;
            command.Parameters.Add("@UserTypeID", DbType.Decimal).Value = obj.SeCodeUserTypeId;
            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            return table;
        }
        public override DataTable GetUserTaskDetails(decimal ID , int Lang )
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("dbo.SelectAuditUserTasks", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@UsrTaskID", DbType.Decimal).Value = ID;
            command.Parameters.Add("@Lang", DbType.Int64).Value = Lang;
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