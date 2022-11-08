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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SeAccnt"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSeAccntProvider: SqlSeAccntProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSeAccntProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSeAccntProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}


        public override DataTable GetAdminOfficerApplicants(TransactionManager transactionManager, decimal SeUserId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetAdminOfficerApplicants", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, SeUserId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();

            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("SE_USER_ID");



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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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

        public override DataTable GetAudtSeAcct(TransactionManager transactionManager, decimal SeCodeUserTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAudtSeAcct", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SeCodeUserTypeId", DbType.Decimal, SeCodeUserTypeId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();

            table.Columns.Add("SeAccntId");
            table.Columns.Add("DescAr");
            table.Columns.Add("DescEn");
          
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };              
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