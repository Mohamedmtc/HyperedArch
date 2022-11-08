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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmRsrvdCode"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmRsrvdCodeProvider: SqlAdmRsrvdCodeProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmRsrvdCodeProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmRsrvdCodeProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Custom Methods  
        /*
        //Dina Added at 28/112012 to insert AdmRsrvdCode without redandancy && Update
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRsrvdCode entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ADM_RSRVD_CODE_Insert", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmRsrvdCodeId", DbType.Decimal, entity.AdmRsrvdCodeId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, entity.AdmAppReservedCode);

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


            entity.OriginalAdmRsrvdCodeId = entity.AdmRsrvdCodeId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRsrvdCode entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ADM_RSRVD_CODE_Update", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmRsrvdCodeId", DbType.Decimal, entity.AdmRsrvdCodeId);
            database.AddInParameter(commandWrapper, "@OriginalAdmRsrvdCodeId", DbType.Decimal, entity.OriginalAdmRsrvdCodeId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, entity.AdmAppReservedCode);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

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
                EntityManager.StopTracking(entity.EntityTrackingKey);

            entity.OriginalAdmRsrvdCodeId = entity.AdmRsrvdCodeId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }
        //Dina End 28/112012
        */
        #endregion
    }
}