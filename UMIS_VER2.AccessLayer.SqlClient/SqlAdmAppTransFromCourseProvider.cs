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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppTransFromCourse"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAppTransFromCourseProvider: SqlAdmAppTransFromCourseProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAppTransFromCourseProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmAppTransFromCourseProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods
           /// <summary>
        /// 	Inserts a UMIS_VER2.BusinessLyer.AdmAppTransFromCourse object into the datasource using a transaction.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppTransFromCourse object to insert.</param>
        /// <remarks>
        ///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.AdmAppTransFromCourse object will be updated
        /// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>	
        /// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override decimal InsertWithOutputID(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransFromCourse entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_TRANS_FROM_COURSE_Insert", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@AdmAppTransFromCourseId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@AdmAppTransReqId", DbType.Decimal, entity.AdmAppTransReqId);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, entity.CourseCode);
            database.AddInParameter(commandWrapper, "@CourseCh", DbType.String, entity.CourseCh);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@CourseGrade", DbType.String, entity.CourseGrade);
            database.AddInParameter(commandWrapper, "@CoursePoint", DbType.Decimal, (entity.CoursePoint.HasValue ? (object)entity.CoursePoint : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodePassFailId", DbType.Decimal, (entity.GsCodePassFailId.HasValue ? (object)entity.GsCodePassFailId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CourseBrief", DbType.String, entity.CourseBrief);
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);

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


            entity.OriginalAdmAppTransFromCourseId = entity.AdmAppTransFromCourseId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToDecimal(commandWrapper.Parameters["@AdmAppTransFromCourseId"].Value);
        }	
        #endregion

	}
}