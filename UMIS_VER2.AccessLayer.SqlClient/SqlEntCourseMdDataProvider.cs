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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntCourseMdData"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEntCourseMdDataProvider: SqlEntCourseMdDataProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEntCourseMdDataProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEntCourseMdDataProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCourseMdData entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENT_COURSE_MD_DATA_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCourseMdDataId", DbType.Decimal, entity.EntCourseMdDataId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeGradingId", DbType.Decimal, (entity.EdCodeGradingId.HasValue ? (object)entity.EdCodeGradingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntCodePrecondMdId", DbType.Decimal, (entity.EntCodePrecondMdId.HasValue ? (object)entity.EntCodePrecondMdId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntCodeFullfillMdId", DbType.Decimal, (entity.EntCodeFullfillMdId.HasValue ? (object)entity.EntCodeFullfillMdId : System.DBNull.Value));

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


            entity.OriginalEntCourseMdDataId = entity.EntCourseMdDataId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCourseMdData entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENT_COURSE_MD_DATA_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCourseMdDataId", DbType.Decimal, entity.EntCourseMdDataId);
            database.AddInParameter(commandWrapper, "@OriginalEntCourseMdDataId", DbType.Decimal, entity.OriginalEntCourseMdDataId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entity.EntMainId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeGradingId", DbType.Decimal, (entity.EdCodeGradingId.HasValue ? (object)entity.EdCodeGradingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntCodePrecondMdId", DbType.Decimal, (entity.EntCodePrecondMdId.HasValue ? (object)entity.EntCodePrecondMdId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntCodeFullfillMdId", DbType.Decimal, (entity.EntCodeFullfillMdId.HasValue ? (object)entity.EntCodeFullfillMdId : System.DBNull.Value));

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

            entity.OriginalEntCourseMdDataId = entity.EntCourseMdDataId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }

        #endregion

    }
}