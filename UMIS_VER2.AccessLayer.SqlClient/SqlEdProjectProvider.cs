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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdProject"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdProjectProvider: SqlEdProjectProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdProjectProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdProjectProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        /// <summary>
        /// 	Inserts a UMIS_VER2.BusinessLyer.EdProject object into the datasource using a transaction.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="entity">UMIS_VER2.BusinessLyer.EdProject object to insert.</param>
        /// <remarks>
        ///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.EdProject object will be updated
        /// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>	
        /// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdProject entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_PROJECT_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdProjectId", DbType.Decimal, entity.EdProjectId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal,(entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));

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


            entity.OriginalEdProjectId = entity.EdProjectId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        /// <summary>
        /// 	Update an existing row in the datasource.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="entity">UMIS_VER2.BusinessLyer.EdProject object to update.</param>
        /// <remarks>
        ///		After updating the datasource, the UMIS_VER2.BusinessLyer.EdProject object will be updated
        /// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>
        /// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdProject entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_PROJECT_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdProjectId", DbType.Decimal, entity.EdProjectId);
            database.AddInParameter(commandWrapper, "@OriginalEdProjectId", DbType.Decimal, entity.OriginalEdProjectId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));


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

            entity.OriginalEdProjectId = entity.EdProjectId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }


        #region Custom Methods

        public override TList<EdProject> GetStudentProjects(TransactionManager transactionManager, decimal? edAcadYearId, decimal? edCodeSemesterId, decimal? edProjectId,decimal?asFacultyInfo, decimal entityMainId, string studCode, string studName, decimal lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentProjects", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId.HasValue ? (object)edAcadYearId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemsetr", DbType.Decimal, edCodeSemesterId.HasValue ? (object)edCodeSemesterId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfo", DbType.Decimal, asFacultyInfo.HasValue ? (object)asFacultyInfo : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdProjectId", DbType.Decimal, edProjectId.HasValue ? (object)edProjectId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, entityMainId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, studCode);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, studName);
            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, lang);


            IDataReader reader = null;

            //Create Collection
            TList<EdProject> rows = new TList<EdProject>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentProjects", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentProjects", rows));
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