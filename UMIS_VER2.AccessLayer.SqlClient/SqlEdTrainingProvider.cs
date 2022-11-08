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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdTraining"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdTrainingProvider: SqlEdTrainingProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdTrainingProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdTrainingProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Custom Methods

        public override DataTable GetEdTrainingDetails(TransactionManager transactionManager, System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _GsDeTrainSiteID, System.Decimal? _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetEdTrainingDetails", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId.HasValue ? (object)_EdAcadYearId.Value : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId.HasValue ? (object)_EdCodeSemesterId.Value : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsDeTrainSiteID", DbType.Decimal, _GsDeTrainSiteID.HasValue ? (object)_GsDeTrainSiteID.Value : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId.HasValue ? (object)_EdStudId.Value : (object)DBNull.Value);

            DataSet ds;

            try
            {
                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        #endregion

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="_edTrainingId">. Primary Key.</param>	
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override bool Delete(TransactionManager transactionManager, System.Decimal _edTrainingId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_TRAINING_Delete", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdTrainingId", DbType.Decimal, _edTrainingId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete"));

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //Stop Tracking Now that it has been updated and persisted.
            if (DataRepository.Provider.EnableEntityTracking)
            {
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EdTraining)
                    , _edTrainingId);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Delete"));

            commandWrapper = null;

            return Convert.ToBoolean(results);
        }//end Delete

        /// <summary>
        /// 	Inserts a UMIS_VER2.BusinessLyer.EdTraining object into the datasource using a transaction.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="entity">UMIS_VER2.BusinessLyer.EdTraining object to insert.</param>
        /// <remarks>
        ///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.EdTraining object will be updated
        /// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>	
        /// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTraining entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_TRAINING_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdTrainingId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@GsCdeTrainSite", DbType.Decimal, entity.GsCdeTrainSite);
            database.AddInParameter(commandWrapper, "@MaxStudNo", DbType.Decimal, (entity.MaxStudNo.HasValue ? (object)entity.MaxStudNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StartDate", DbType.Date, (entity.StartDate.HasValue ? (object)entity.StartDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PeriodMonth", DbType.Decimal, (entity.PeriodMonth.HasValue ? (object)entity.PeriodMonth : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PeriodDay", DbType.Decimal, (entity.PeriodDay.HasValue ? (object)entity.PeriodDay : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EndDate", DbType.Date, (entity.EndDate.HasValue ? (object)entity.EndDate : System.DBNull.Value));

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

            entity.EdTrainingId = decimal.Parse(commandWrapper.Parameters["@EdTrainingId"].Value.ToString());
            entity.OriginalEdTrainingId = entity.EdTrainingId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	
	}
}