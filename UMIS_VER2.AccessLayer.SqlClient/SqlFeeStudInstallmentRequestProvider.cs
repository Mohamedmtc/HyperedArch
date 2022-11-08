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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeStudInstallmentRequest"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeStudInstallmentRequestProvider: SqlFeeStudInstallmentRequestProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeStudInstallmentRequestProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeStudInstallmentRequestProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Custom Method
        public override bool DeleteStudInstallmentRequest(TransactionManager transactionManager, decimal EdAcadYearId, decimal AsFacultyInfoId, decimal EdCodeSemesterId, decimal EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.DeleteStudInstallmentRequest", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, EdStudId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(results);
        }	

        #endregion 
    }
}