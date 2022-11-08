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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="MdiStudVacc"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlMdiStudVaccProvider: SqlMdiStudVaccProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlMdiStudVaccProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlMdiStudVaccProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable SearchStudVacc(TransactionManager transactionManager, System.Decimal _AsFacultyInfoID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudCode, System.Decimal _MdiCdeVacc, System.Decimal _MdiVaccSrl, string _FromDt, string _ToDt)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_MDI_STUD_VACC_FIND", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, _AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@MdiCdeVacc", DbType.Decimal, _MdiCdeVacc);
            database.AddInParameter(commandWrapper, "@MdiVaccSrl", DbType.Decimal, _MdiVaccSrl);
            database.AddInParameter(commandWrapper, "@FromDt", DbType.DateTime, !string.IsNullOrEmpty(_FromDt) ? (object)_FromDt : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ToDt", DbType.DateTime, !string.IsNullOrEmpty(_ToDt) ? (object)_ToDt : DBNull.Value);

            DataTable tmp = new DataTable();
            try
            {
                if (transactionManager != null)
                    tmp.Load(Utility.ExecuteReader(transactionManager, commandWrapper));
                else
                    tmp.Load(Utility.ExecuteReader(database, commandWrapper));

            }
            finally
            {
                commandWrapper = null;
            }

            return tmp;
        }

        public override int GetStudVaccSerial(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _MdiCdeVaccID,System.Decimal _RptSerial)
        {
            int count = 0;
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStudVaccSerial", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@MdiCdeVaccId", DbType.Decimal, _MdiCdeVaccID);
            database.AddInParameter(commandWrapper, "@RptSerial", DbType.Decimal, _RptSerial);

            try
            {
                if (transactionManager != null)
                    count = Convert.ToInt32(Utility.ExecuteScalar(transactionManager, commandWrapper));
                else
                    count = Convert.ToInt32(Utility.ExecuteScalar(database, commandWrapper));

            }
            finally
            {
                commandWrapper = null;
            }

            return count;
        }

        public override int Delete_Custom(TransactionManager transactionManager, System.Decimal _MdiStudVaccId)
        {
            int count = 0;
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_MDI_STUD_VACC_Delete", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@MdiStudVaccId", DbType.Decimal, _MdiStudVaccId);

            try
            {
                if (transactionManager != null)
                    count = Convert.ToInt32(Utility.ExecuteScalar(transactionManager, commandWrapper));
                else
                    count = Convert.ToInt32(Utility.ExecuteScalar(database, commandWrapper));

            }
            finally
            {
                commandWrapper = null;
            }

            return count;
        }
	}
}