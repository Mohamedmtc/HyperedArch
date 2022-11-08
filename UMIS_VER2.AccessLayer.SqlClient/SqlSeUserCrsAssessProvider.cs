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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SeUserCrsAssess"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSeUserCrsAssessProvider: SqlSeUserCrsAssessProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSeUserCrsAssessProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSeUserCrsAssessProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        public override DataTable GETSemesterCourses(decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCodeCourseAssessId)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("GETSemesterCourses", conn);
            command.CommandType = CommandType.StoredProcedure;

            if (!(AsFacultyInfoId == 0)) command.Parameters.Add("AsFacultyInfoId", SqlDbType.Decimal).Value = AsFacultyInfoId;
            command.Parameters.Add("EdAcadYearId", SqlDbType.Decimal).Value = EdAcadYearId;
            command.Parameters.Add("EdCodeSemesterId", SqlDbType.Decimal).Value = EdCodeSemesterId;
            if (!(EdCodeCourseAssessId == 0)) command.Parameters.Add("EdCodeCourseAssessId", SqlDbType.Decimal).Value = EdCodeCourseAssessId;
            //command.Parameters.Add("EdCodeCourseAssessId", SqlDbType.Decimal).Value = EdCodeCourseAssessId == 0 ? null : EdCodeCourseAssessId;

            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();

            return table;
        }
        public override int DeleteUserCoursesAssess(decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCodeCourseAssessId)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("DeleteUserCourseAssess", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (!(AsFacultyInfoId == 0)) cmd.Parameters.Add("AsFacultyInfoId", SqlDbType.Decimal).Value = AsFacultyInfoId;
            cmd.Parameters.Add("EdAcadYearId", SqlDbType.Decimal).Value = EdAcadYearId;
            cmd.Parameters.Add("EdCodeSemesterId", SqlDbType.Decimal).Value = EdCodeSemesterId;
            if (!(EdCodeCourseAssessId == 0)) cmd.Parameters.Add("EdCodeCourseAssessId", SqlDbType.Decimal).Value = EdCodeCourseAssessId;
            conn.Open();
            try
            {
                int x = cmd.ExecuteNonQuery();
                conn.Close();
                return x;
            }
            catch (Exception ex)
            {
                conn.Close();
                return -1;
            }
        }
    }
}