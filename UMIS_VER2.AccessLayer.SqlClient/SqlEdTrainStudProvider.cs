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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdTrainStud"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdTrainStudProvider: SqlEdTrainStudProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdTrainStudProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdTrainStudProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        public override DataTable GetEdTrainStudDetails(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsDeTrainSiteID, string _StudCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetEdTrainStudDetails", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@GsDeTrainSiteID", DbType.Decimal, _GsDeTrainSiteID);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
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
        /// 	Inserts a UMIS_VER2.BusinessLyer.EdTrainStud object into the datasource using a transaction.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="entity">UMIS_VER2.BusinessLyer.EdTrainStud object to insert.</param>
        /// <remarks>
        ///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.EdTrainStud object will be updated
        /// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>	
        /// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdTrainStud entity, decimal acadYearId, decimal semesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_TRAIN_STUD_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdTrainStudId", DbType.Decimal, entity.EdTrainStudId);
            database.AddInParameter(commandWrapper, "@EdTrainingId", DbType.Decimal, entity.EdTrainingId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@SupComment", DbType.String, entity.SupComment);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, acadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, semesterId);

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


            entity.OriginalEdTrainStudId = entity.EdTrainStudId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }
	}
}