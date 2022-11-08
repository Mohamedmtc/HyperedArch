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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdTopicTchng"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdTopicTchngProvider: SqlEdTopicTchngProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdTopicTchngProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdTopicTchngProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}


        public override DataTable GetTopicHrs_CrsHRs(TransactionManager transactionManager, decimal CourseID)
        {

            SqlConnection conn = new SqlConnection(this.ConnectionString);
            SqlCommand command = new SqlCommand("SelectTopicHrs_CrsHRs", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("CrsID", SqlDbType.Decimal).Value = CourseID;
            conn.Open();
            //
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            //
            return table;
        }

	}
}