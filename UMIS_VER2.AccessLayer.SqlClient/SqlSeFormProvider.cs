#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SeForm"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSeFormProvider: SqlSeFormProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSeFormProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSeFormProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override bool Delete(TransactionManager transactionManager, System.Decimal _seFormId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_SE_FORM_Delete", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SeFormId", DbType.Decimal, _seFormId);

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
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(SeForm)
                    , _seFormId);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Delete"));

            commandWrapper = null;

            return Convert.ToBoolean(results);
        }//end Delete

        #endregion

        #region Custom Procedures

        public override TList<SeForm> GetBySeModuleId_AllForms(TransactionManager transactionManager, System.Decimal _seModuleId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_FORM_GetBySeModuleId_AllForms", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SeModuleId", DbType.Decimal, _seModuleId);

            IDataReader reader = null;
            TList<SeForm> tmp = new TList<SeForm>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetBySeModuleId_AllForms", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, 0, int.MaxValue);
                
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetBySeModuleId_AllForms", tmp));
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
        public override TList<SeForm> GetSeform_ForUser(TransactionManager transactionManager, System.Decimal _seModuleId, System.Decimal _SeAccnt)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSeform_ForUser", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SeModuleId", DbType.Decimal, _seModuleId);
            database.AddInParameter(commandWrapper, "@SeAccntId", DbType.Decimal, _SeAccnt);

            IDataReader reader = null;
            TList<SeForm> tmp = new TList<SeForm>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetSeform_ForUser", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, 0, int.MaxValue);
                
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetSeform_ForUser", tmp));
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
		
        
        #endregion
    }
}