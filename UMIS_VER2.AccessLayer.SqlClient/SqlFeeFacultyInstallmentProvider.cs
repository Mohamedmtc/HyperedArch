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
using UMIS_VER2.AccessLayer.Bases;
using System.Configuration;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeFacultyInstallment"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeFacultyInstallmentProvider: SqlFeeFacultyInstallmentProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeFacultyInstallmentProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeFacultyInstallmentProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override DataTable GetStudsArrears(TransactionManager transactionManager, decimal EdAcadYearId, decimal AsFacultyInfoId, decimal? DepartmentId, decimal? EdCodeLevelId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_FACULTY_INSTALLMENT_GetStudsArrears", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@DepartmentId", DbType.Decimal, DepartmentId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId);

            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudsArrears", tmp));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Create collection and fill
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudsArrears", tmp));
            }
            finally
            {
                commandWrapper = null;
            }

            return dt;
        }

        public override bool LoadInstallments(TransactionManager transactionManager, decimal EdAcadYearId, decimal AsFacultyInfoId, decimal EntMainId, decimal EdCodeSemesterId, decimal AsCodeDegreeId, decimal Load, decimal Lang, string _SessionID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_FACULTY_INSTALLMENT_LoadInstallments", UseStoredProcedure);

            string sUrl = ConfigurationManager.AppSettings["WebServicePath"];
            string sKey = ConfigurationManager.AppSettings["WebServiceKey"];

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, AsCodeDegreeId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Load", DbType.Decimal, Load);
            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, Lang);
            database.AddInParameter(commandWrapper, "@SessionID", DbType.String, _SessionID);
            database.AddInParameter(commandWrapper, "@sUrl", DbType.String, sUrl);
            database.AddInParameter(commandWrapper, "@sKey", DbType.String, sKey);

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