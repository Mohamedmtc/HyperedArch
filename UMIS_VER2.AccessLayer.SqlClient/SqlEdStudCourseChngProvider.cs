#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudCourseChng"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudCourseChngProvider: SqlEdStudCourseChngProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudCourseChngProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudCourseChngProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseChng entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_STUD_COURSE_CHNG_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudCourseChngId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, entity.EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCourseSubId", DbType.Decimal, (entity.EdCourseSubId.HasValue ? (object)entity.EdCourseSubId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeCourseChngId", DbType.Decimal, entity.EdCodeCourseChngId);
            database.AddInParameter(commandWrapper, "@EdCdeCourseChngRsnId", DbType.Decimal, entity.EdCdeCourseChngRsnId);
            database.AddInParameter(commandWrapper, "@ReqDate", DbType.DateTime, entity.ReqDate);
            database.AddInParameter(commandWrapper, "@ReqStatusDate", DbType.DateTime, (entity.ReqStatusDate.HasValue ? (object)entity.ReqStatusDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeReqStatusId", DbType.Decimal, (entity.GsCodeReqStatusId.HasValue ? (object)entity.GsCodeReqStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, (entity.ApproveFlg.HasValue ? (object)entity.ApproveFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeFormId", DbType.Decimal, (entity.SeFormId.HasValue ? (object)entity.SeFormId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserInsrtId", DbType.Decimal, (entity.SeUserInsrtId.HasValue ? (object)entity.SeUserInsrtId : System.DBNull.Value));
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

            object _edStudCourseChngId = database.GetParameterValue(commandWrapper, "@EdStudCourseChngId");
            entity.EdStudCourseChngId = (System.Decimal)_edStudCourseChngId;

            entity.OriginalEdStudCourseChngId = entity.EdStudCourseChngId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        public override DataTable GetCourseWithdrawReq(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EntMainId,
                                        System.String CourseCode, System.String StudCode, System.Decimal ApproveFlg, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CourseWithdrawReq", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@Course_Code", DbType.String, CourseCode);
            database.AddInParameter(commandWrapper, "@stud_Code", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, ApproveFlg);

            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetCourseWithdrawReq"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCourseWithdrawReq"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }


        public override DataTable GetAllForStudent(TransactionManager transactionManager, decimal _EdStudID, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId, string _Lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_CHNG_Get_ForStudent", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.String, _Lang);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("EdStudCourseChngId");
            table.Columns.Add("CourseDescr");
            table.Columns.Add("CourseChngDescr");
            table.Columns.Add("ReqDate");
            table.Columns.Add("ApproveFlg");
            table.Columns.Add("EdCourseId");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                        table.Rows.Add(items);
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        public override DataTable GetAllCoursesForCourseChng(TransactionManager transactionManager, decimal _EdStudID, decimal _CourseChngFlag, decimal _EntCoursePkgHdrId, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_CHNG_Get_ForCourseChng", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@CourseChngFlag", DbType.Decimal, _CourseChngFlag);
            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, _EntCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }
        public override DataTable GetAllCoursesForCourseChngByEntityMain(TransactionManager transactionManager, decimal _EdStudID, decimal _CourseChngFlag, decimal _EntMainId, decimal _EdAcadYearId, decimal _AsFacultyInfoId, decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_CHNG_Get_ForCourseChngByEntMainId", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@CourseChngFlag", DbType.Decimal, _CourseChngFlag);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_CODE");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        public override DataTable GetStudentState(TransactionManager transactionManager, decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_CHNG_Get_StudentState", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        public override DataTable GetAllForApprove(TransactionManager transactionManager, decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _Lang, decimal _EdCodeCourseChngId, decimal _EdCourseId, string _StudName, decimal _ApproveFlg, string _CourseCode, DateTime _FromDate, DateTime _ToDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_CHNG_GetAllForApprove", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@EdCodeCourseChngId", DbType.Decimal, _EdCodeCourseChngId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, _StudName);
            database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, _ApproveFlg);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, _CourseCode);
            database.AddInParameter(commandWrapper, "@FromDate", DbType.DateTime, _FromDate);
            database.AddInParameter(commandWrapper, "@ToDate", DbType.DateTime, _ToDate);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_COURSE_CHNG_ID");
            table.Columns.Add("ED_CODE_COURSE_CHNG_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("REQ_DATE");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("CHNG_DESCR_AR");
            table.Columns.Add("CHNG_DESCR_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("ED_STUD_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
                        table.Rows.Add(items);
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        /// <summary>
        /// Search students that have requests for "Add/Drop/Withdrow" courses.
        /// Added by HSabry 11-11-2012
        /// </summary>
        public override DataTable SearchStuds(TransactionManager transactionManager, decimal _AsFacultyInfoId, decimal _EdAcadYearId, decimal _EdCodeSemesterId, string _StudCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_CHNG_SearchStuds", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("StudFacultyCode");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("LevelDescrAr");
            table.Columns.Add("LevelDescrEn");
            table.Columns.Add("StudStatesAr");
            table.Columns.Add("StudStatesEn");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        #endregion
	}
}