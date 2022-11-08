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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntCoursePkgDtl"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEntCoursePkgDtlProvider: SqlEntCoursePkgDtlProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEntCoursePkgDtlProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEntCoursePkgDtlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgDtl entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENT_COURSE_PKG_DTL_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCoursePkgDtlId", DbType.Decimal, entity.EntCoursePkgDtlId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, (entity.EdCourseId.HasValue ? (object)entity.EdCourseId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, entity.EntCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@AddGpaFlg", DbType.Decimal, entity.AddGpaFlg);
            database.AddInParameter(commandWrapper, "@AddMjrgpaFlg", DbType.Decimal, (entity.AddMjrgpaFlg.HasValue ? (object)entity.AddMjrgpaFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CrsExpFlg", DbType.Decimal, (entity.CrsExpFlg.HasValue ? (object)entity.CrsExpFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CrsExp", DbType.String, entity.CrsExp);
            database.AddInParameter(commandWrapper, "@CrsExpNameAr", DbType.String, entity.CrsExpNameAr);
            database.AddInParameter(commandWrapper, "@CrsExpNameEn", DbType.String, entity.CrsExpNameEn);
            database.AddInParameter(commandWrapper, "@EdCourseExpHdrId", DbType.Decimal, (entity.EdCourseExpHdrId.HasValue ? (object)entity.EdCourseExpHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCourseExpPrereqHdrId", DbType.Decimal, (entity.EdCourseExpPrereqHdrId.HasValue ? (object)entity.EdCourseExpPrereqHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CreditHours", DbType.Decimal, (entity.CreditHours.HasValue ? (object)entity.CreditHours : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LoadWithTrain", DbType.Decimal, (entity.LoadWithTrain.HasValue ? (object)entity.LoadWithTrain : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PrereqCodeExp", DbType.String, entity.PrereqCodeExp);
            database.AddInParameter(commandWrapper, "@PrereqIdExp", DbType.String, entity.PrereqIdExp);

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


            entity.OriginalEntCoursePkgDtlId = entity.EntCoursePkgDtlId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        #endregion

        #region Custom Methods

        #region GetByOfferedEntCoursePkgHdrId
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR key.
        ///		FK_ENT_COURSE_PKG_ENT_COURSE_PKG_HDR Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_entCoursePkgHdrId">مسلسل مجموعة المتطلبات الرئيسي</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override TList<EntCoursePkgDtl> GetByOfferedEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_COURSE_PKG_DTL_OFFERED", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, _entCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);


            IDataReader reader = null;
            TList<EntCoursePkgDtl> rows = new TList<EntCoursePkgDtl>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEntCoursePkgHdrId", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByOfferedEntCoursePkgHdrId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            if (rows.Count == 0)
            {
                EntCoursePkgDtl emtyrow = new EntCoursePkgDtl();
                //emtyrow..CourseDescrAr = "";
                rows.Add(emtyrow);
            }
            return rows;
        }



        #endregion

        public override TList<EntCoursePkgDtl> GetByEdCourseId_StudSemesterId(TransactionManager transactionManager, System.Decimal _edstudsemesterId, System.Decimal _edCourseId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.COURSE_PKG_DTL_by_Course_StudSem", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, _edstudsemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);

            IDataReader reader = null;
            TList<EntCoursePkgDtl> rows = new TList<EntCoursePkgDtl>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEdCourseId_StudSemesterId", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdCourseId_StudSemesterId", rows));
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