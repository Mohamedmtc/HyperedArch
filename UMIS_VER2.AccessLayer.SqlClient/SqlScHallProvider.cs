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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScHall"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScHallProvider: SqlScHallProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScHallProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScHallProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures
        /*
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHall entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_SC_HALL_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, entity.ScHallId);
            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, entity.ScBuildingId);
            database.AddInParameter(commandWrapper, "@HallCode", DbType.String, entity.HallCode);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@Capacity", DbType.Decimal, entity.Capacity);
            database.AddInParameter(commandWrapper, "@IsShared", DbType.Decimal, entity.IsShared);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@ExmCapcity", DbType.Decimal, (entity.ExmCapcity.HasValue ? (object)entity.ExmCapcity : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ScCdeHallTypeId", DbType.Decimal, (entity.ScCdeHallTypeId.HasValue ? (object)entity.ScCdeHallTypeId : System.DBNull.Value));

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


            entity.OriginalScHallId = entity.ScHallId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }
        */
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHall entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_SC_HALL_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, entity.ScHallId);
            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, entity.ScBuildingId);
            database.AddInParameter(commandWrapper, "@HallCode", DbType.String, entity.HallCode);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@Capacity", DbType.Decimal, entity.Capacity);
            database.AddInParameter(commandWrapper, "@IsShared", DbType.Decimal, entity.IsShared);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@ExmCapcity", DbType.Decimal, (entity.ExmCapcity.HasValue ? (object)entity.ExmCapcity : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Floor", DbType.String, entity.Floor);
            database.AddInParameter(commandWrapper, "@CAPACITYMAX", DbType.Decimal, (entity.CapacityMax.HasValue ? (object)entity.CapacityMax : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SCCDEHALLTYPEID", DbType.Decimal, (entity.ScCdeHallTypeId.HasValue ? (object)entity.ScCdeHallTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CRSSHAREDFLG", DbType.Boolean, (entity.CrsSharedFlg.HasValue ? (object)entity.CrsSharedFlg : false));

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


            entity.OriginalScHallId = entity.ScHallId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	
        /*
        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHall entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_SC_HALL_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, entity.ScHallId);
            database.AddInParameter(commandWrapper, "@OriginalScHallId", DbType.Decimal, entity.OriginalScHallId);
            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, entity.ScBuildingId);
            database.AddInParameter(commandWrapper, "@HallCode", DbType.String, entity.HallCode);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@Capacity", DbType.Decimal, entity.Capacity);
            database.AddInParameter(commandWrapper, "@IsShared", DbType.Decimal, entity.IsShared);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@ExmCapcity", DbType.Decimal, (entity.ExmCapcity.HasValue ? (object)entity.ExmCapcity : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ScCdeHallTypeId", DbType.Decimal, (entity.ScCdeHallTypeId.HasValue ? (object)entity.ScCdeHallTypeId : System.DBNull.Value));

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

            entity.OriginalScHallId = entity.ScHallId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }
        */
        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHall entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_SC_HALL_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, entity.ScHallId);
            database.AddInParameter(commandWrapper, "@OriginalScHallId", DbType.Decimal, entity.OriginalScHallId);
            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, entity.ScBuildingId);
            database.AddInParameter(commandWrapper, "@HallCode", DbType.String, entity.HallCode);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@Capacity", DbType.Decimal, entity.Capacity);
            database.AddInParameter(commandWrapper, "@IsShared", DbType.Decimal, entity.IsShared);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@ExmCapcity", DbType.Decimal, (entity.ExmCapcity.HasValue ? (object)entity.ExmCapcity : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Floor", DbType.String, entity.Floor);
            database.AddInParameter(commandWrapper, "@CAPACITYMAX", DbType.Decimal, (entity.CapacityMax.HasValue ? (object)entity.CapacityMax : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SCCDEHALLTYPEID", DbType.Decimal, (entity.ScCdeHallTypeId.HasValue ? (object)entity.ScCdeHallTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CRSSHAREDFLG", DbType.Boolean, (entity.CrsSharedFlg.HasValue ? (object)entity.CrsSharedFlg : false));
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

            entity.OriginalScHallId = entity.ScHallId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }

        #endregion

        #region Custom Methods
        public override TList<ScHall> GetHalls(TransactionManager transactionManager, System.Decimal ScBuildingId, decimal? AsFacultyInfoId, int start, int pageLength)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetHalls", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsfacultyIfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@SCbuildingId", DbType.Decimal, ScBuildingId);
            //database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, EntPolcyAssessHdrId);
            IDataReader reader = null;
            TList<ScHall> rows = new TList<ScHall>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetHalls", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);



                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetHalls", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;

        }
        
        #endregion
    }
}