#region Using directives

using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudAcadmicAdv"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudAcadmicAdvProvider: SqlEdStudAcadmicAdvProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudAcadmicAdvProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlEdStudAcadmicAdvProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
	//added by mmq at 08-02-2017
        public override decimal CopyStudentsAcadmicAdv(TransactionManager transactionManager, string edAcadYear, string edCodeSemster )
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "BATCH_COPY_ACADMIC_ADV", this.UseStoredProcedure);
            
            database.AddOutParameter(commandWrapper, "@Retrun", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@p_EdAcadYearID", DbType.Decimal, edAcadYear);
            database.AddInParameter(commandWrapper, "@p_EdCodeSemesterID", DbType.Decimal, edCodeSemster);
           

            int results = 0;

            //Provider Data Requesting Command Event
         

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            return Convert.ToDecimal(commandWrapper.Parameters["@Retrun"].Value);
        }

    }
}