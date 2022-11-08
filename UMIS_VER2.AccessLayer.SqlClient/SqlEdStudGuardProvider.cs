#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudGuard"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudGuardProvider: SqlEdStudGuardProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudGuardProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudGuardProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        /*
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGuard entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GUARD_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudGuardId", DbType.Decimal, 6);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, (entity.EdStudId.HasValue ? (object)entity.EdStudId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeRelationId", DbType.Decimal, entity.GsCodeRelationId);
            database.AddInParameter(commandWrapper, "@FullNameEn", DbType.String, entity.FullNameEn);
            database.AddInParameter(commandWrapper, "@JobTitle", DbType.String, entity.JobTitle);
            database.AddInParameter(commandWrapper, "@PermAddr", DbType.String, entity.PermAddr);
            database.AddInParameter(commandWrapper, "@EMail", DbType.String, entity.EMail);
            database.AddInParameter(commandWrapper, "@PhoneNum", DbType.String, entity.PhoneNum);
            database.AddInParameter(commandWrapper, "@MobileNum", DbType.String, entity.MobileNum);
            database.AddInParameter(commandWrapper, "@MonthIncome", DbType.Decimal, (entity.MonthIncome.HasValue ? (object)entity.MonthIncome : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StaffFlg", DbType.Decimal, entity.StaffFlg);
            database.AddInParameter(commandWrapper, "@DiplomaticFlg", DbType.Decimal, entity.DiplomaticFlg);
            database.AddInParameter(commandWrapper, "@MainFlg", DbType.Decimal, entity.MainFlg);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, (entity.AdmApplicantId.HasValue ? (object)entity.AdmApplicantId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudBroId", DbType.Decimal, (entity.EdStudBroId.HasValue ? (object)entity.EdStudBroId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, (entity.SaStfMemberId.HasValue ? (object)entity.SaStfMemberId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@BirthDate", DbType.DateTime, (entity.BirthDate.HasValue ? (object)entity.BirthDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeMaritalStateId", DbType.Decimal, (entity.GsCodeMaritalStateId.HasValue ? (object)entity.GsCodeMaritalStateId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeEducationLevelId", DbType.Decimal, (entity.GsCodeEducationLevelId.HasValue ? (object)entity.GsCodeEducationLevelId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CompanyName", DbType.String, entity.CompanyName);
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity.GsCountryNodeId.HasValue ? (object)entity.GsCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FullNameAr", DbType.String, entity.FullNameAr);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            entity.EdStudGuardId = decimal.Parse(commandWrapper.Parameters["@EdStudGuardId"].Value.ToString());
            entity.OriginalEdStudGuardId = entity.EdStudGuardId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	
        */
	}
}