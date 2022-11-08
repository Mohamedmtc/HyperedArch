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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCourseCoreq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdCourseCoreqProvider: SqlEdCourseCoreqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdCourseCoreqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdCourseCoreqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseCoreq entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_COREQ_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdCourseCoreqId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@EdCourseGroup", DbType.Decimal, entity.EdCourseGroup);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@IsMain", DbType.Decimal, entity.IsMain);

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

            entity.EdCourseCoreqId = decimal.Parse(commandWrapper.Parameters["@EdCourseCoreqId"].Value.ToString());
            entity.OriginalEdCourseCoreqId = entity.EdCourseCoreqId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        public override bool Delete(TransactionManager transactionManager, System.Decimal _edCourseCoreqId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_COREQ_Delete", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdCourseCoreqId", DbType.Decimal, _edCourseCoreqId);

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
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EdCourseCoreq)
                    , _edCourseCoreqId);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Delete"));

            commandWrapper = null;

            return Convert.ToBoolean(results);
        }

        public override TList<EdCourseCoreq> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_COREQ_GetByEdCourseId", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);

            IDataReader reader = null;
            TList<EdCourseCoreq> tmp = new TList<EdCourseCoreq>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEdCourseId", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdCourseId", tmp));
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

        #region Custom Methods
        public override TList<EdCourseCoreq> GetMaxGroup(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.COURSE_COREQ_Get_MaxGroup", this.UseStoredProcedure);

            IDataReader reader = null;

            //Create Collection
            TList<EdCourseCoreq> rows = new TList<EdCourseCoreq>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetMaxGroup", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, 0, 1);
                //count = -1;
                //if (reader.NextResult())
                //{
                //    if (reader.Read())
                //    {
                //        count = reader.GetInt32(0);
                //    }
                //}

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetMaxGroup", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }//end getall


        #endregion
	}
}