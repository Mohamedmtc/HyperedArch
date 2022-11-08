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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppTransToCourse"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAppTransToCourseProvider: SqlAdmAppTransToCourseProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAppTransToCourseProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmAppTransToCourseProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods

        /// <summary>
        /// 	Inserts a UMIS_VER2.BusinessLyer.AdmAppTransToCourse object into the datasource using a transaction.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppTransToCourse object to insert.</param>
        /// <remarks>
        ///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.AdmAppTransToCourse object will be updated
        /// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>	
        /// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override decimal InsertWithOutputID(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransToCourse entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_TRANS_TO_COURSE_Insert", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@AdmAppTransToCourseId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@AdmAppTransReqId", DbType.Decimal, entity.AdmAppTransReqId);
            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, (entity.EntCoursePkgHdrId.HasValue ? (object)entity.EntCoursePkgHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeTransCourseTypeId", DbType.Decimal, entity.EdCodeTransCourseTypeId);
            database.AddInParameter(commandWrapper, "@EdCodeGradingId", DbType.Decimal, (entity.EdCodeGradingId.HasValue ? (object)entity.EdCodeGradingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CoursePoint", DbType.Decimal, (entity.CoursePoint.HasValue ? (object)entity.CoursePoint : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AddGpaFlg", DbType.Decimal, entity.AddGpaFlg);
            database.AddInParameter(commandWrapper, "@AddMjrgpaFlg", DbType.Decimal, entity.AddMjrgpaFlg);
            database.AddInParameter(commandWrapper, "@GsCodePassFailId", DbType.Decimal, (entity.GsCodePassFailId.HasValue ? (object)entity.GsCodePassFailId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntPolicyGradingHdrId", DbType.Decimal, (entity.EntPolicyGradingHdrId.HasValue ? (object)entity.EntPolicyGradingHdrId : System.DBNull.Value));
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


            entity.OriginalAdmAppTransToCourseId = entity.AdmAppTransToCourseId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToDecimal(commandWrapper.Parameters["@AdmAppTransToCourseId"].Value);
        }	

        #endregion

	}
}