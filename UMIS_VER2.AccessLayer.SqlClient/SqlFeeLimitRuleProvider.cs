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

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeLimitRule"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeLimitRuleProvider: SqlFeeLimitRuleProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeLimitRuleProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeLimitRuleProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetMinStuBalance(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asCodeDegreeClassId, System.Decimal _asCodeDegreeId, System.Decimal _AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetMinStuBalance", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@asCodeDegreeClassId", DbType.Decimal, _asCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@asCodeDegreeId", DbType.Int32, _asCodeDegreeId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Int32, _AsFacultyInfoId);



            DataTable dt = new DataTable();

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetMinStuBalance"));

            if (transactionManager != null)
            {
                dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
            }
            else
            {
                dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetByStudent"));

            return dt;
        }

        public override bool CheckFeeLimitRuleExists(TransactionManager transactionManager, System.Int32? _feeLimitRuleId, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _AsCodeDegreeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_LIMIT_RULE_CHECK_REPEATED_DATA", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FeeLimitRuleId", DbType.Int32, _feeLimitRuleId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, _AsCodeDegreeId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "FEE_LIMIT_RULE_CHECK_REPEATED_DATA"));
            
            
            if (transactionManager != null)
            {
                Utility.ExecuteDataSet(transactionManager, commandWrapper);
            }
            else
            {
                Utility.ExecuteDataSet(database, commandWrapper);
            }

            return true;
        }
	}
}