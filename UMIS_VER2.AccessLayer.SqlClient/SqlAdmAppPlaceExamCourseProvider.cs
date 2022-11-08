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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppPlaceExamCourse"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAppPlaceExamCourseProvider: SqlAdmAppPlaceExamCourseProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAppPlaceExamCourseProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmAppPlaceExamCourseProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE key.
        ///		FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlaceExamCourse objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override TList<AdmAppPlaceExamCourse> GetAdmAppPlaceExamCource_Search(TransactionManager transactionManager, System.Decimal _edCourseId, System.Decimal _AdmEdAcadYearId, System.Decimal _AdmEdCodeSemesterId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAdmAppPlaceExamCource_Search", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);
            database.AddInParameter(commandWrapper, "@AdmEdAcadYearId", DbType.Decimal, _AdmEdAcadYearId);
            database.AddInParameter(commandWrapper, "@AdmEdCodeSemesterId", DbType.Decimal, _AdmEdCodeSemesterId);

            IDataReader reader = null;
            TList<AdmAppPlaceExamCourse> rows = new TList<AdmAppPlaceExamCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAdmAppPlaceExamCource_Search", rows));

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
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAdmAppPlaceExamCource_Search", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        #region LoadCoursesOnApllicants
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE key.
        ///		FK_ADM_APP_PLACE_EXAM_COURSE_ED_COURSE Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCourseId">مسلسل المادة داخل النظام</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppPlaceExamCourse objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override TList<AdmAppPlaceExamCourse> LoadCourseOnApplicants(TransactionManager transactionManager, System.Decimal _edCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadCourseOnApplicants", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);

            IDataReader reader = null;
            TList<AdmAppPlaceExamCourse> rows = new TList<AdmAppPlaceExamCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "LoadCourseOnApplicants", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                int start = 0;
                int pageLength = 0;
                int count = 0;
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "LoadCourseOnApplicants", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<AdmAppPlaceExamCourse> UnLoadCourseOnApplicants(TransactionManager transactionManager, System.Decimal _edCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UnLoadCourseOnApplicants", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);

            IDataReader reader = null;
            TList<AdmAppPlaceExamCourse> rows = new TList<AdmAppPlaceExamCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "UnLoadCourseOnApplicants", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                int start = 0;
                int pageLength = 0;
                int count = 0;
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "UnLoadCourseOnApplicants", rows));
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
        #endregion

	}
}