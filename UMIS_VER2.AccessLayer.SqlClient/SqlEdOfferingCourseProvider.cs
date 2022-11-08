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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdOfferingCourse"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdOfferingCourseProvider: SqlEdOfferingCourseProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdOfferingCourseProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdOfferingCourseProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        //Esraa Ali         2-4-2019            8385
        public override void RemoveOldAllHoursNoExceptApprovedValues()
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.RemoveOldAllHoursNoExceptApprovedValues", UseStoredProcedure);

            Utility.ExecuteNonQuery(database, commandWrapper);

        }

        #region GetAllForView Methods

        /// <summary>
        /// 	Gets All rows from the DataSource.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">out. The number of rows that match this query.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override DataTable GetAllForView(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo)
        {
          
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_OFFERING_COURSE_Get_ForView", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfo", DbType.Decimal, AsFacultyInfo);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_OFFERING_COURSE_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
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
        }//end GetAllForView

        public override DataTable GetAllForOfferingCourseView(TransactionManager transactionManager, decimal AsFacultyInfo, decimal EdAcadYear, decimal EdCodeSem, decimal EntMainId, decimal EdStudId, decimal? asCodeDegreeClassId, string EdCourseCode, decimal? AcademicPlanFlg, decimal? CourseLvl, string CourseCodeTitleAr = null, string CourseCodeTitleEn = null, string AcadPlanId = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_OFFERING_COURSE_VIEW", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
           // database.AddInParameter(commandWrapper, "@Flg", DbType.Decimal, Flg);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId.HasValue ? (object)asCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, EdCourseCode);
            database.AddInParameter(commandWrapper, "@AcademicPlanFlg", DbType.Decimal, AcademicPlanFlg.HasValue ? (object)AcademicPlanFlg.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@CourseLvl", DbType.Decimal, CourseLvl.HasValue ? (object)CourseLvl.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, CourseLvl.HasValue ? (object)CourseLvl.Value : DBNull.Value);
            // Added by Menna 26-08-2019 task 10827
            database.AddInParameter(commandWrapper, "@CourseCodeTitleAr", DbType.String, CourseCodeTitleAr);
            database.AddInParameter(commandWrapper, "@CourseCodeTitleEn", DbType.String, CourseCodeTitleEn);

            database.AddInParameter(commandWrapper, "@AcadPlanId", DbType.String, AcadPlanId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("EdOfferingCourseId");
            table.Columns.Add("EdOfferingId");
            table.Columns.Add("EdCourseId");
            table.Columns.Add("CourseCode");
            table.Columns.Add("CourseCode_AR");
            table.Columns.Add("CourseDescrAr");
            table.Columns.Add("CourseDescrEn");
            table.Columns.Add("MaxStudCount");
            table.Columns.Add("MinAttendNo");
            table.Columns.Add("OnlineFlg");
            table.Columns.Add("SaStfMemberId");
            table.Columns.Add("EntMainId");
            table.Columns.Add("CreditHours");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString() };
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
        }//end GetAllForView
        //iNSERT oFFERING sEARCH
        public override DataTable GetAllForOfferingCourseViewInsert(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSem, decimal EntMainId, decimal? EdAcadYearPlanId, decimal? asCodeDegreeClassId, string EdCourseCode, decimal? AcademicPlanFlg, decimal? CourseLvl, decimal? EntMainMajorId, string EdCourseName)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_OFFERING_COURSE_GetForOffering", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@EntMainMajorId", DbType.Decimal, EntMainMajorId.HasValue ? (object)EntMainMajorId.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearPlanId", DbType.Decimal, EdAcadYearPlanId.HasValue ? (object)EdAcadYearPlanId.Value : DBNull.Value);
            // database.AddInParameter(commandWrapper, "@Flg", DbType.Decimal, Flg);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId.HasValue ? (object)asCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, EdCourseCode);
            database.AddInParameter(commandWrapper, "@EdCourseName", DbType.String, EdCourseName);
            database.AddInParameter(commandWrapper, "@AcademicPlanFlg", DbType.Decimal, AcademicPlanFlg.HasValue ? (object)AcademicPlanFlg.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@CourseLvl", DbType.Decimal, CourseLvl.HasValue ? (object)CourseLvl.Value : DBNull.Value);
         
            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            //table.Columns.Add("EdOfferingCourseId");
            //table.Columns.Add("EdOfferingId");
            table.Columns.Add("EdCourseId");
            table.Columns.Add("CourseCode");
            table.Columns.Add("CourseDescrAr");
            table.Columns.Add("CourseDescrEn");
            //table.Columns.Add("MaxStudCount");
            //table.Columns.Add("MinAttendNo");
            table.Columns.Add("OnlineFlg");
            //table.Columns.Add("SaStfMemberId");
            //table.Columns.Add("EntMainId");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
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
        }//end GetAllForView

        // Get Course Offered for entity main
        public override DataTable GetAllForView(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal? AsFacultyInfo, decimal? EntMainId,
            decimal? onlineFlg, decimal? edCodeCourseId,decimal SaStfMemberId , decimal? AsCodeDegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_OFFERING_COURSE_Get_ForView2", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfo", DbType.Decimal, AsFacultyInfo.HasValue ? (object)AsFacultyInfo.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId.HasValue ? (object)EntMainId.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@OnLineFlg", DbType.Decimal, onlineFlg.HasValue ? (object)onlineFlg.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, edCodeCourseId.HasValue ? (object)edCodeCourseId.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@SA_STF_MAMBER_ID", DbType.Decimal, SaStfMemberId );
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId.HasValue ? (object)AsCodeDegreeClassId.Value : DBNull.Value);


            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_OFFERING_COURSE_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
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
        }//end GetAllForView

        // get count of offered courses on the faculty
        public override int GetNotApprovedResultCoursesCount(TransactionManager transactionManager, decimal _EdAcadYear, decimal _EdCodeSem, decimal _AsFacultyInfo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetNotApprovedResultCoursesCount", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, _EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, _EdCodeSem);

            IDataReader reader = null;

            int count = 1;

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
                    count = int.Parse(reader[0].ToString());
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return count;
        }

        public override int GetCourseAllSessionNo(TransactionManager transactionManager, decimal edOfferingCourseId, decimal? edCodeCourseTeachingId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);

            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_course_All_Session_No", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdOfferingCourseId", DbType.Decimal, edOfferingCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseTeachingId", DbType.Decimal, edCodeCourseTeachingId.HasValue ? (object)edCodeCourseTeachingId.Value : DBNull.Value);

            object scalarValue = null;
            try
            {
                if (transactionManager != null)
                {
                    scalarValue = Utility.ExecuteScalar(transactionManager, commandWrapper);
                }
                else
                {
                    scalarValue = Utility.ExecuteScalar(database, commandWrapper);
                }
            }
            finally
            {
                commandWrapper = null;
            }

            return scalarValue == null ? 0 : int.Parse(scalarValue.ToString());
        }

        public override TList<EdOfferingCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _EdCourseId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_OFFERING_COURSE_GetByEdCourseId", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            TList<EdOfferingCourse> rows = new TList<EdOfferingCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEdCourseId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdCourseId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EdOfferingCourse> GetByEdCourseId_Custom(TransactionManager transactionManager, System.Decimal _EdCourseId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_OFFERING_COURSE_GetByEdCourseId", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            TList<EdOfferingCourse> rows = new TList<EdOfferingCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEdCourseId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdCourseId", rows));
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

        /// <summary>
        /// Use Original Update without checks
        /// </summary>
        public override bool Update_Original(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOfferingCourse entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.O_ED_OFFERING_COURSE_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdOfferingCourseId", DbType.Decimal, entity.EdOfferingCourseId);
            database.AddInParameter(commandWrapper, "@OriginalEdOfferingCourseId", DbType.Decimal, entity.OriginalEdOfferingCourseId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, (entity.EdCourseId.HasValue ? (object)entity.EdCourseId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdOfferingId", DbType.Decimal, (entity.EdOfferingId.HasValue ? (object)entity.EdOfferingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AuditFlg", DbType.Decimal, (entity.AuditFlg.HasValue ? (object)entity.AuditFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@OnlineFlg", DbType.Decimal, (entity.OnlineFlg.HasValue ? (object)entity.OnlineFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@MinAttendNo", DbType.Decimal, (entity.MinAttendNo.HasValue ? (object)entity.MinAttendNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AllSessionNo", DbType.Decimal, (entity.AllSessionNo.HasValue ? (object)entity.AllSessionNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AllHoursNo", DbType.Decimal, (entity.AllHoursNo.HasValue ? (object)entity.AllHoursNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ApproveNoFlg", DbType.Boolean, (entity.ApproveNoFlg.HasValue ? (object)entity.ApproveNoFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@MaxStudCount", DbType.Decimal, (entity.MaxStudCount.HasValue ? (object)entity.MaxStudCount : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, (entity.SaStfMemberId.HasValue ? (object)entity.SaStfMemberId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeFormId", DbType.Decimal, (entity.SeFormId.HasValue ? (object)entity.SeFormId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));
			
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

            entity.OriginalEdOfferingCourseId = entity.EdOfferingCourseId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }

        public override DataTable GetCourseCoordinator(TransactionManager transactionManager, Decimal EdAcadYearId, Decimal EdCodeSemesterId, Decimal EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.VW_RPT_GetCourseCoordinator", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("CourseCoordinator");
            
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString()};
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

        public override DataTable GetCourseCampus(TransactionManager transactionManager, Decimal EdAcadYearId, Decimal EdCodeSemesterId, Decimal EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.VW_RPT_GetCourseCampus", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("CourseCampus");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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

        #endregion
	}
}