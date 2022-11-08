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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCourseOutcomesDtl"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
    public partial class SqlEdCourseOutcomesDtlProvider: SqlEdCourseOutcomesDtlProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdCourseOutcomesDtlProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdCourseOutcomesDtlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        public override DataTable GetCourseOutcomesTopicsDetails(decimal EdAcadYearId, decimal AsFacultyInfoId, decimal EdCodeSemesterId, decimal EdCourseId,decimal EdOutcomesTopicsId)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("GetCourseOutcomesTopicsDetails", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("EdAcadYearId", SqlDbType.Decimal).Value = EdAcadYearId;
            command.Parameters.Add("EdCodeSemesterId", SqlDbType.Decimal).Value = EdCodeSemesterId;
            command.Parameters.Add("AsFacultyInfoId", SqlDbType.Decimal).Value = AsFacultyInfoId;
            command.Parameters.Add("EdCourseId", SqlDbType.Decimal).Value = EdCourseId;
            command.Parameters.Add("EdOutcomesTopicsId", SqlDbType.Decimal).Value = EdOutcomesTopicsId;
            conn.Open();
            

            //Create Collection
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
                
           
            return table;
        }//end 
    }
}