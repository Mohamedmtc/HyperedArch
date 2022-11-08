#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppLtrRecom"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAppLtrRecomProvider: SqlAdmAppLtrRecomProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAppLtrRecomProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmAppLtrRecomProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Updated Methods

        /// <summary>
        /// 	Inserts a UMIS_VER2.BusinessLyer.AdmAppLtrRecom object into the datasource using a transaction.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppLtrRecom object to insert.</param>
        /// <remarks>
        ///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.AdmAppLtrRecom object will be updated
        /// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>	
        /// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppLtrRecom entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_LTR_RECOM_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@AdmAppLtrRecomId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, entity.AdmApplicantId);
            database.AddInParameter(commandWrapper, "@Name", DbType.String, entity.Name);
            database.AddInParameter(commandWrapper, "@JobTitle", DbType.String, entity.JobTitle);
            database.AddInParameter(commandWrapper, "@MobNum", DbType.String, entity.MobNum);
            database.AddInParameter(commandWrapper, "@PhoneNum", DbType.String, entity.PhoneNum);
            database.AddInParameter(commandWrapper, "@EMail", DbType.String, entity.EMail);
            database.AddInParameter(commandWrapper, "@LetterPath", DbType.String, entity.LetterPath);
            database.AddInParameter(commandWrapper, "@AdmAppRegHistoryId", DbType.Decimal, entity.AdmAppRegHistoryId);

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

            entity.AdmAppLtrRecomId = decimal.Parse(commandWrapper.Parameters["@AdmAppLtrRecomId"].Value.ToString());
            entity.OriginalAdmAppLtrRecomId = entity.AdmAppLtrRecomId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        #endregion
	}
}