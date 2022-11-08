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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CtrStudExp"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlCtrStudExpProvider: SqlCtrStudExpProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlCtrStudExpProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlCtrStudExpProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable SearchStudExps(TransactionManager transactionManager, System.Decimal _AcadYearId, System.Decimal _SemesterId, System.Decimal _StudId, System.Decimal _ReasonID, string _FromDt, string _ToDt)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CTR_STUD_EXP_SRCH", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _AcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _SemesterId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _StudId);
            database.AddInParameter(commandWrapper, "@ReasonID", DbType.Decimal, _ReasonID);
            database.AddInParameter(commandWrapper, "@FromDt", DbType.DateTime, !string.IsNullOrEmpty(_FromDt) ? (object)_FromDt : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ToDt", DbType.DateTime, !string.IsNullOrEmpty(_ToDt) ? (object)_ToDt : DBNull.Value);

            IDataReader reader = null;
            DataTable tmp = new DataTable();


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
                tmp.Load(reader);

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;

            //return rows;
        }
	}
}