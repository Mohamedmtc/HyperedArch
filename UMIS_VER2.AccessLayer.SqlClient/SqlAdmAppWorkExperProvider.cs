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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppWorkExper"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAppWorkExperProvider: SqlAdmAppWorkExperProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAppWorkExperProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmAppWorkExperProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Update Methods

        /// <summary>
        /// 	Inserts a UMIS_VER2.BusinessLyer.AdmAppWorkExper object into the datasource using a transaction.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppWorkExper object to insert.</param>
        /// <remarks>
        ///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.AdmAppWorkExper object will be updated
        /// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>	
        /// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
       /*
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppWorkExper entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_WORK_EXPER_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@AdmAppWorkExperId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@OrganizationName", DbType.String, entity.OrganizationName);
            database.AddInParameter(commandWrapper, "@OrganizationAddress", DbType.String, entity.OrganizationAddress);
            database.AddInParameter(commandWrapper, "@JobTitle", DbType.String, entity.JobTitle);
            database.AddInParameter(commandWrapper, "@PeriodFrom", DbType.Date, entity.PeriodFrom);
            database.AddInParameter(commandWrapper, "@PeriodTo", DbType.Date, entity.PeriodTo);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, (entity.AdmApplicantId.HasValue ? (object)entity.AdmApplicantId : System.DBNull.Value));

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

            entity.AdmAppWorkExperId = decimal.Parse(commandWrapper.Parameters["@AdmAppWorkExperId"].Value.ToString());
            entity.OriginalAdmAppWorkExperId = entity.AdmAppWorkExperId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }
        */
        #endregion
	}
}