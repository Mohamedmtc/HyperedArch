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
using System.Data.SqlClient;
using System.Configuration;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudSemester"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudSemesterProvider: SqlEdStudSemesterProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudSemesterProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudSemesterProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods


        #region Update Methods

        /// <summary>
        /// 	Update an existing row in the datasource.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="entity">UMIS_VER2.BusinessLyer.EdStudSemester object to update.</param>
        /// <remarks>
        ///		After updating the datasource, the UMIS_VER2.BusinessLyer.EdStudSemester object will be updated
        /// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>
        /// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override bool Update_Original(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemester entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_SEMESTER_Update_Original", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, entity.EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@OriginalEdStudSemesterId", DbType.Decimal, entity.OriginalEdStudSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, (entity.EdCodeLevelId.HasValue ? (object)entity.EdCodeLevelId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsLast", DbType.Decimal, entity.IsLast);
            database.AddInParameter(commandWrapper, "@EdCodeLoadTypeId", DbType.Decimal, (entity.EdCodeLoadTypeId.HasValue ? (object)entity.EdCodeLoadTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeEnrollTypeId", DbType.Decimal, (entity.EdCodeEnrollTypeId.HasValue ? (object)entity.EdCodeEnrollTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AccumCh", DbType.Decimal, (entity.AccumCh.HasValue ? (object)entity.AccumCh : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AccumGpa", DbType.Decimal, (entity.AccumGpa.HasValue ? (object)entity.AccumGpa : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsCourseApproved", DbType.Decimal, entity.IsCourseApproved);
            database.AddInParameter(commandWrapper, "@CourseApproveDate", DbType.DateTime, (entity.CourseApproveDate.HasValue ? (object)entity.CourseApproveDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AccumPoint", DbType.Decimal, (entity.AccumPoint.HasValue ? (object)entity.AccumPoint : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SemCh", DbType.Decimal, (entity.SemCh.HasValue ? (object)entity.SemCh : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SemGpa", DbType.Decimal, (entity.SemGpa.HasValue ? (object)entity.SemGpa : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SemPoint", DbType.Decimal, (entity.SemPoint.HasValue ? (object)entity.SemPoint : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsClosed", DbType.Decimal, entity.IsClosed);
            database.AddInParameter(commandWrapper, "@MajorCgpa", DbType.Decimal, (entity.MajorCgpa.HasValue ? (object)entity.MajorCgpa : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@MajorGpa", DbType.Decimal, (entity.MajorGpa.HasValue ? (object)entity.MajorGpa : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AcdPlnLoadFlg", DbType.Decimal, (entity.AcdPlnLoadFlg.HasValue ? (object)entity.AcdPlnLoadFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@OnlineFlg", DbType.Decimal, (entity.OnlineFlg.HasValue ? (object)entity.OnlineFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ExpForGrad", DbType.Decimal, (entity.ExpForGrad.HasValue ? (object)entity.ExpForGrad : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@HoldForGrad", DbType.Decimal, (entity.HoldForGrad.HasValue ? (object)entity.HoldForGrad : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@OrientFlg", DbType.Decimal, (entity.OrientFlg.HasValue ? (object)entity.OrientFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NationalitySimilarityFlg", DbType.Decimal, (entity.NationalitySimilarityFlg.HasValue ? (object)entity.NationalitySimilarityFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FeeFacultyRuleId", DbType.Decimal, (entity.FeeFacultyRuleId.HasValue ? (object)entity.FeeFacultyRuleId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StudCardStkrFlg", DbType.Decimal, (entity.StudCardStkrFlg.HasValue ? (object)entity.StudCardStkrFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StudCardStkrDate", DbType.DateTime, (entity.StudCardStkrDate.HasValue ? (object)entity.StudCardStkrDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FeeTotAmnt", DbType.Decimal, (entity.FeeTotAmnt.HasValue ? (object)entity.FeeTotAmnt : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FeePayAmnt", DbType.Decimal, (entity.FeePayAmnt.HasValue ? (object)entity.FeePayAmnt : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FeeRefundAmnt", DbType.Decimal, (entity.FeeRefundAmnt.HasValue ? (object)entity.FeeRefundAmnt : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, entity.PayFlg);
            database.AddInParameter(commandWrapper, "@FreezeFlg", DbType.Decimal, entity.FreezeFlg);

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

            entity.OriginalEdStudSemesterId = entity.EdStudSemesterId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }
        //added by mmq at 22/06/2016
        //public override DataTable Update_Result_Is_Approved(TransactionManager transactionManager, System.String EdAcadYearId, System.String EdCodeSemesterId, System.String AsFacultyInfoId, System.String DeptEntMainId, System.String MjrEntMainId, System.String AppFlg, System.String UpdFlg, System.String UserId)
        //{
        //    SqlDatabase database = new SqlDatabase(this.ConnectionString);
        //    DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ApproveSemesterResult", UseStoredProcedure);

        //    database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
        //    database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
        //    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
        //    database.AddInParameter(commandWrapper, "@DeptEntMainId", DbType.Decimal, DeptEntMainId);
        //    database.AddInParameter(commandWrapper, "@MjrEntMainId", DbType.Decimal, MjrEntMainId);
        //    database.AddInParameter(commandWrapper, "@AppFlg", DbType.Decimal, AppFlg);            
        //    database.AddInParameter(commandWrapper, "@UpdFlg", DbType.Decimal, UpdFlg);
        //    database.AddInParameter(commandWrapper, "@UserID", DbType.Decimal, UserId);

        //    int results = 0;
        //    IDataReader reader = null;
        //    DataTable table = new DataTable();
        //    table.Columns.Add("FACULTY_DESCR_AR");
        //    table.Columns.Add("FACULTY_DESCR_EN");
        //    table.Columns.Add("LVL_AR");
        //    table.Columns.Add("LVL_EN");
        //    table.Columns.Add("MAJOR_AR");
        //    table.Columns.Add("MAJOR_EN");
        //    table.Columns.Add("STUD_COUNT");
        //    table.Columns.Add("STUD_SHOW_RESULT");
        //    table.Columns.Add("STUD_BLOCKED");

        //    if (transactionManager != null)
        //    {
        //        reader = Utility.ExecuteReader(transactionManager, commandWrapper);
        //        while (reader.Read())
        //        {
        //            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
        //                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString()};

        //            table.Rows.Add(items);

        //        }
        //    }
        //    else
        //    {
        //        reader = Utility.ExecuteReader(database, commandWrapper);
        //        while (reader.Read())
        //        {
        //            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
        //                              reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString()};

        //            table.Rows.Add(items);
        //        }




        //    }
        //    return table;
        //}
        // Changed by MElshazly 3/12/2020 [15606][Copied the code below from NUB/Modular source code.]
       public override DataTable Update_Result_Is_Approved(TransactionManager transactionManager, System.String EdAcadYearId, System.String EdCodeSemesterId, System.String AsFacultyInfoId, System.String DeptEntMainId, System.String MjrEntMainId, System.String AppFlg, System.String UpdFlg, System.String UserId,
                                                            decimal? LevelID, decimal? ExamTypeID , decimal? _AsCodeDegreeClassID, decimal? EdAcadPlnYear=null)
        {
            DbCommand commandWrapper;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            if (ExamTypeID == null)
            {
                commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ApproveSemesterResult", UseStoredProcedure);
                if (EdAcadPlnYear != null)
                    database.AddInParameter(commandWrapper, "@EdAcadPlanYearId", DbType.Decimal, EdAcadPlnYear);//walaa 14/9/2022 task 19295
            }
            else
            {
                commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ApproveSemesterResult_MOD", UseStoredProcedure);
                database.AddInParameter(commandWrapper, "@ExamTypeID", DbType.Decimal, ExamTypeID);
            }

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@DeptEntMainId", DbType.Decimal, DeptEntMainId);
            database.AddInParameter(commandWrapper, "@MjrEntMainId", DbType.Decimal, MjrEntMainId);
            database.AddInParameter(commandWrapper, "@AppFlg", DbType.Decimal, AppFlg);
            database.AddInParameter(commandWrapper, "@UpdFlg", DbType.Decimal, UpdFlg);
            database.AddInParameter(commandWrapper, "@UserID", DbType.Decimal, UserId);
            if (LevelID != null)
                database.AddInParameter(commandWrapper, "@LevelID", DbType.Decimal, LevelID);
            if (_AsCodeDegreeClassID != null)
                database.AddInParameter(commandWrapper, "@AsCodeDegreeClassID", DbType.Decimal, _AsCodeDegreeClassID);
            
            int results = 0;
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("LVL_AR");
            table.Columns.Add("LVL_EN");
            table.Columns.Add("ED_CODE_LEVEL_ID");//esraa yousef 13-3-2022
            table.Columns.Add("MAJOR_AR");
            table.Columns.Add("MAJOR_EN");
            table.Columns.Add("STUD_COUNT");
            table.Columns.Add("STUD_SHOW_RESULT");
            table.Columns.Add("STUD_BLOCKED");
            if (ExamTypeID != null)
                table.Columns.Add("CoureNotApprove");   //esraa yousef 8-9-2020 

          /*-- bug 18093 modfiedby maha ---*/
            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                if (ExamTypeID != null)
                {
                    #region Modular with exam type id not null
                    //Edit by Mohamed Saleh 24-06-2021 bug 16940 
                    if (reader.FieldCount > 1)
                        while (reader.Read())
                        {
                            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                     reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
                            table.Rows.Add(items);
                        }
                    //Add by Mohamed Saleh 24-06-2021 bug 16940 
                    else
                    {
                        table.Columns.Clear();
                        table.Columns.Add("Error");
                        while (reader.Read())
                        {
                            object[] items = { reader[0].ToString() };

                            table.Rows.Add(items);

                        }
                    } 
                    #endregion
                }
                else
                {
                    #region Credit Hours With ExamTypeID is null
                    //Edit by Mohamed Saleh 24-06-2021 bug 16940 
                    if (reader.FieldCount > 1)
                        while (reader.Read())
                        {
                            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                     reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() ,reader[9].ToString()};
                            table.Rows.Add(items);
                        }
                    //Add by Mohamed Saleh 24-06-2021 bug 16940 
                    else
                    {
                        table.Columns.Clear();
                        table.Columns.Add("Error");
                        while (reader.Read())
                        {
                            object[] items = { reader[0].ToString() };

                            table.Rows.Add(items);

                        }
                    } 
                    #endregion
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                if (ExamTypeID != null)
                {
                    #region Modular with exam type id not null
                    //Edit by Mohamed Saleh 24-06-2021 bug 16940 
                    if (reader.FieldCount > 1)
                        while (reader.Read())
                        {
                            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                     reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
                            table.Rows.Add(items);
                        }
                    //Add by Mohamed Saleh 24-06-2021 bug 16940 
                    else
                    {
                        table.Columns.Clear();
                        table.Columns.Add("Error");
                        while (reader.Read())
                        {
                            object[] items = { reader[0].ToString() };

                            table.Rows.Add(items);

                        }
                    } 
                    #endregion
                }
                else
                {
                    #region Credit Hours With ExamTypeID is null
                    //Edit by Mohamed Saleh 24-06-2021 bug 16940 
                    if (reader.FieldCount > 1)
                        while (reader.Read())
                        {
                            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                     reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),reader[9].ToString()};
                            table.Rows.Add(items);
                        }
                    //Add by Mohamed Saleh 24-06-2021 bug 16940 
                    else
                    {
                        table.Columns.Clear();
                        table.Columns.Add("Error");
                        while (reader.Read())
                        {
                            object[] items = { reader[0].ToString() };

                            table.Rows.Add(items);

                        }
                    } 
                    #endregion
                }
            }
            return table;
        }
        //Marwa 27/3/2022 18018
        public override DataTable Search_Result_Is_Approved_ForAsessSemWorkOnly(TransactionManager transactionManager, System.String EdAcadYearId,
            System.String EdCodeSemesterId, System.String AsFacultyInfoId, System.String DeptEntMainId, System.String MjrEntMainId,
                                                          decimal LevelID,decimal CourseID, decimal AssessHDRID, decimal CourseAssessID)
        {
            DbCommand commandWrapper;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);

            commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchApproveSemesterResult_ForSemWorkOnly", UseStoredProcedure);
            

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@DeptEntMainId", DbType.Decimal, DeptEntMainId);
            database.AddInParameter(commandWrapper, "@MjrEntMainId", DbType.Decimal, MjrEntMainId);
            database.AddInParameter(commandWrapper, "@LevelID", DbType.Decimal, LevelID);
            database.AddInParameter(commandWrapper, "@CourseID", DbType.Decimal, CourseID);
            database.AddInParameter(commandWrapper, "@AssessHDRID", DbType.Decimal, AssessHDRID);
            database.AddInParameter(commandWrapper, "@CourseAssessID", DbType.Decimal, CourseAssessID);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("LVL_AR");
            table.Columns.Add("LVL_EN");
            table.Columns.Add("ED_CODE_LEVEL_ID");//esraa yousef 13-3-2022
            table.Columns.Add("MAJOR_AR");
            table.Columns.Add("MAJOR_EN");
            table.Columns.Add("STUD_COUNT");
            table.Columns.Add("STUD_SHOW_RESULT");
            table.Columns.Add("STUD_BLOCKED");

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

                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), 
                                                    reader[5].ToString() , reader[6].ToString(), reader[7].ToString(), reader[8].ToString()};
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
        //Marwa 27/3/2022 18018
        public override bool Update_Result_Is_Approved_ForAsessSemWorkOnly(TransactionManager transactionManager, System.String EdAcadYearId, 
            System.String EdCodeSemesterId, System.String AsFacultyInfoId, System.String DeptEntMainId, System.String MjrEntMainId,
                                                          decimal LevelID, decimal CourseID, decimal AssessHDRID, decimal CourseAssessID)
        {
            DbCommand commandWrapper;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);

            commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UpdateApproveSemesterResult_ForSemWorkOnly", UseStoredProcedure);


            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@DeptEntMainId", DbType.Decimal, DeptEntMainId);
            database.AddInParameter(commandWrapper, "@MjrEntMainId", DbType.Decimal, MjrEntMainId);
            database.AddInParameter(commandWrapper, "@LevelID", DbType.Decimal, LevelID);
            database.AddInParameter(commandWrapper, "@CourseID", DbType.Decimal, CourseID);
            database.AddInParameter(commandWrapper, "@AssessHDRID", DbType.Decimal, AssessHDRID);
            database.AddInParameter(commandWrapper, "@CourseAssessID", DbType.Decimal, CourseAssessID);

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(results);
        }
        
        #endregion

        //Marwa 24/3/2022 18018
        public override DataTable GetStudRegisteredCoursess_AsesssData(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsFacultyInfoId, decimal LevelId, decimal SerachFlag,decimal? CourseID,decimal? EntPolicyasessHdrID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudRegisteredCoursess_AsesssData", this.UseStoredProcedure);


            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@LevelID", DbType.Decimal, LevelId);
            database.AddInParameter(commandWrapper, "@CourseID", DbType.Decimal, CourseID);
            database.AddInParameter(commandWrapper, "@EntPolicyasessHdrID", DbType.Decimal, EntPolicyasessHdrID);
            database.AddInParameter(commandWrapper, "@SerachFlag", DbType.Decimal, SerachFlag);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");

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

                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString()};
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

        #region Gathering GPA
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_ED_STUD key.
        ///		FK_ED_STUD_SEMESTER_ED_STUD Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edStudId">مسلسل الطالب</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemester objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override bool Gathering_GPA(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _AcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Gathering_GPA", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, _AcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Selected_EdStudId", DbType.Decimal, _EdStudId);


            int results = 0;

            //Provider Data Requesting Command Event
            //OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            //entity.OriginalEdStudSemesterId = entity.EdStudSemesterId;

            //entity.AcceptChanges();

            ////Provider Data Requested Command Event
            //OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        public override DataTable GetCGPA(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _AcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCGPA", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, _AcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Selected_EdStudId", DbType.Decimal, _EdStudId);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("CCH");
            table.Columns.Add("CGPA");
            table.Columns.Add("CPrecent");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
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

        public override DataTable GetCGPAGrade(TransactionManager transactionManager, System.Decimal _EntMainId, System.Decimal _EdStudSemesterId, System.Decimal _CGPA)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GET_CGPA_GRADE", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, _EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@CGPA", DbType.Decimal, _CGPA);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_POLICY_GRADING_DTL_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("ED_CODE_GRADING_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
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

        #endregion

        public override DataTable GetLastStudSemester(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_SEMESTER_GetLastStudSemester", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_ENROLL_TYPE_ID");
            table.Columns.Add("Enroll_Desc_En");
            table.Columns.Add("Enroll_Desc_Ar");
            table.Columns.Add("LOAD_DESCR_AR");
            table.Columns.Add("LOAD_DESCR_EN");
            table.Columns.Add("MAJOR_CGPA");
            table.Columns.Add("ACCUM_CH");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         , reader[5].ToString(), reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         , reader[5].ToString(), reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
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
        public override DataTable GetSTudCoursesInLastSem(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _AcadYearId,
            System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId, decimal _ExamTypeID, decimal _checkResultApproveFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_StudentCourses", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _AcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@ExamTypeID", DbType.Decimal, _ExamTypeID);
            database.AddInParameter(commandWrapper, "@CheckSemesterApproval", DbType.Decimal, _ExamTypeID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");

            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("ED_CODE_COURSE_STATUS_ID");

            table.Columns.Add("CREDIT_HOURS");
            table.Columns.Add("ED_STUD_COURSE_REG_ID");
            table.Columns.Add("COURSE_STATUS_AR");
            table.Columns.Add("COURSE_STATUS_EN");
            table.Columns.Add("PAY_FLG");
            table.Columns.Add("IS_RESULT_APPROVED");
            table.Columns.Add("GRADING_DESCR_AR");
            table.Columns.Add("GRADING_DESCR_EN");
            table.Columns.Add("COURSE_POINT");

            table.Columns.Add("COURSE_DEGREE");
            table.Columns.Add("COURSE_DEGREE_let"); //added by esraa yousef eue 17798 26-1-2022
            table.Columns.Add("GS_CODE_PASS_FAIL_ID");
            table.Columns.Add("stud_status_ar");

            table.Columns.Add("stud_status_en");
            table.Columns.Add("pass_fail_descr_ar");
            table.Columns.Add("pass_fail_descr_en");
            table.Columns.Add("Graded_Degree");


            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(),
                                             reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(),reader[19].ToString(),reader[20].ToString() , reader[21].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), 
                                             reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(),reader[19].ToString(),reader[20].ToString() , reader[21].ToString() };

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

        public override DataTable GetStudAcadWarn(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCdeAcadWarnTypeId, System.String _StudCode, System.Decimal _EdCodeLevelId, System.Decimal _AsCodeDegreeClassId, System.Decimal _Lang, System.Decimal? _MajorId = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudAcadWarn", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCdeAcadWarnTypeId", DbType.Decimal, _EdCdeAcadWarnTypeId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);

            if (_MajorId.HasValue)
                database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, _MajorId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("ED_CDE_ACAD_WARN_TYPE_ID");
            table.Columns.Add("ACAD_WARN_TYPE_DESCR_AR");
            table.Columns.Add("ACAD_WARN_TYPE_DESCR_EN");
            table.Columns.Add("ACAD_WARN_CODE");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("LEVEL_DESCR_AR");
            table.Columns.Add("LEVEL_DESCR_EN");
            table.Columns.Add("MAJOR_AR");
            table.Columns.Add("MAJOR_EN");
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

                //read data
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         , reader[5].ToString(), reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()
                                         ,reader[11].ToString(),reader[12].ToString(),reader[13].ToString()};
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

        public override DataTable GetStudsForCalculateCGPA(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _DeptEntMainId, System.Decimal _MajorEntMainId, System.Decimal _AsCodeDegreeClassId, System.Decimal _EdCodeEnrollTypeId, System.Decimal _IsClosed, /*System.String _StudCode, */System.Decimal _NotCalculated, System.Decimal _EdCodeLevelId, System.String _StudCodeFrom, System.String _StudCodeTo, System.Decimal _AdmissionYear, System.Decimal? MinorId = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudsForCalculateCGPA", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@DeptEntMainId", DbType.Decimal, _DeptEntMainId);
            database.AddInParameter(commandWrapper, "@MajorEntMainId", DbType.Decimal, _MajorEntMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollTypeId", DbType.Decimal, _EdCodeEnrollTypeId);
            database.AddInParameter(commandWrapper, "@IsClosed", DbType.Decimal, _IsClosed);
            // database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode); // Commented by MElshazly 19/12/2020
            database.AddInParameter(commandWrapper, "@NotCalculated", DbType.Decimal, _NotCalculated);
            database.AddInParameter(commandWrapper, "@StudCodeFrom", DbType.String, _StudCodeFrom); // Added by MElshazly 19/12/2020
            database.AddInParameter(commandWrapper, "@StudCodeTo", DbType.String, _StudCodeTo); // Added by MElshazly 19/12/2020
            database.AddInParameter(commandWrapper, "@AdmissionYear", DbType.Decimal, _AdmissionYear); // Added by MElshazly 19/12/2020
            if (MinorId.HasValue)
                database.AddInParameter(commandWrapper, "@MinorId", DbType.Decimal, MinorId); // Added by Kamela 14-2-2021

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("MAJOR_DESCR_AR");
            table.Columns.Add("MAJOR_DESCR_EN");
            table.Columns.Add("SEM_CH");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("SEM_GPA");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("MAJOR_GPA");
            table.Columns.Add("MAJOR_CGPA");
            table.Columns.Add("IS_CLOSED");
            table.Columns.Add("HOLD_FOR_GRAD");
            table.Columns.Add("OLD_ACCUM_CH");
            table.Columns.Add("OLD_ACCUM_GPA");
            table.Columns.Add("OLD_MAJOR_CGPA");
            table.Columns.Add("ENROLL_CODE");
            table.Columns.Add("OLD_ENROLL_CODE");
            //Kamela, 14363, dispaly Name of  Enrollment case not Enrol code because if student is enroll it doesn't dispaly any thaning ( Enroll code = "" in database )
            table.Columns.Add("New_Enrol_code_AR");
            table.Columns.Add("New_Enrol_code_EN");
            table.Columns.Add("Old_Enrol_code_AR");
            table.Columns.Add("Old_Enrol_code_EN");
            //end
            table.Columns.Add("ACAD_WARN_CODE");
            table.Columns.Add("ACAD_WARN_CODE_AR");
            table.Columns.Add("ACAD_WARN_CODE_EN");
            table.Columns.Add("OLD_ACAD_WARN_CODE");
            table.Columns.Add("OLD_ACAD_WARN_CODE_AR");
            table.Columns.Add("OLD_ACAD_WARN_CODE_EN");
            table.Columns.Add("ORIENT_FLG");
            table.Columns.Add("UGPA");
            table.Columns.Add("UCGPA");
            table.Columns.Add("OLD_ACCUM_UGPA");
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

                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         , reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()
                                         , reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(),
                                         reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(),
                                        reader[23].ToString(), reader[24].ToString(), reader[25].ToString(), reader[26].ToString()
                                     ,reader[27].ToString(),reader[28].ToString(),reader[29].ToString(),reader[30].ToString(),reader[31].ToString(),
                                     reader[32].ToString(),reader[33].ToString()};
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

        public override bool CalculateCGPAandMajorCGPA(TransactionManager transactionManager, System.String _SelectedStudSemester, System.Decimal _GPAFlg, System.Decimal _CGPAFlg, System.Decimal _MajorCGPAFlg, System.Decimal _CloseFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CalculateCGPAandMajorCGPA", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Selected_StudSemester", DbType.Xml, _SelectedStudSemester);
            database.AddInParameter(commandWrapper, "@GPA_Flg", DbType.Decimal, _GPAFlg);
            database.AddInParameter(commandWrapper, "@CGPA_Flg", DbType.Decimal, _CGPAFlg);
            database.AddInParameter(commandWrapper, "@MajorCGPA_Flg", DbType.Decimal, _MajorCGPAFlg);
            database.AddInParameter(commandWrapper, "@Close_Flg", DbType.Decimal, _CloseFlg);
            
            int results = 0;
            
            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }
            
            return Convert.ToBoolean(results);
        }

        public override int CalcAcadWarn(TransactionManager transactionManager, System.Decimal _EdStudSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CalcAcadWarn", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, _EdStudSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SEQ_NO");

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

            int SeqNo = 0;
            if (table.Rows.Count > 0)
                SeqNo = int.Parse(table.Rows[0][0].ToString());

            return SeqNo;
        }

        /// <summary>
        /// Get Students for graduate
        /// <Studs xmlns="http://www.w3.org/2005/Atom"><Stud> <EdStudId>1692</EdStudId> <EdStudSemesterId>2048</EdStudSemesterId> </Stud><Stud> <EdStudId>2637</EdStudId> <EdStudSemesterId>2856</EdStudSemesterId> </Stud> </Studs>
        /// </summary>
        public override bool ChangeStateToH(TransactionManager transactionManager, System.String _SelectedStudSemester)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ChangeStateToH", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Selected_StudSemester", DbType.Xml, _SelectedStudSemester);

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(results);
        }

        public override DataTable AutoUpdateStudEnroll(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.AutoUpdateStudEnroll", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
          
            ////Provider Data Requesting Command Event
            //OnDataRequesting(new CommandEventArgs(commandWrapper, "DeleteStudentsWaitingList"));

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SE_USER_ACCNT_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_CONTACT_METHOD");

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

                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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
        /// <summary>
        /// get numbers of student in each major
        /// </summary>
        /// <param name="transactionManager"></param>
        /// <param name="_ClassDeg"></param>
        /// <param name="_CodeSemstr"></param>
        /// <param name="_AcadYear"></param>
        /// <param name="_FacultyInfo"></param>
        /// <returns></returns>
        public override DataTable GetRegistedStud(TransactionManager transactionManager,System.Decimal?_ClassDeg,System.Decimal? _CodeSemstr,System.Decimal? _AcadYear,System.Decimal?_FacultyInfo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWarrper = StoredProcedureProvider.GetCommandWrapper(database, "STS_Registerd_Count", this.UseStoredProcedure);
            
            database.AddInParameter(commandWarrper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, _CodeSemstr);
            database.AddInParameter(commandWarrper, "@ED_ACAD_YEAR_ID", DbType.Decimal, _AcadYear);
            database.AddInParameter(commandWarrper, "@AS_FACULTY_INFO_ID", DbType.Decimal, _FacultyInfo);
            database.AddInParameter(commandWarrper, "@CLASS_DEGREE_ID", DbType.Decimal, _ClassDeg);
            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("NUM");
            dt.Columns.Add("STUDENTS_NUM_AR");
            dt.Columns.Add("STUDENTS_NUM_EN");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWarrper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWarrper);
                }
                while(reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(),reader[2].ToString() };
                    dt.Rows.Add(items);
                }


            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWarrper = null;

            }
            return  dt;


        }

        //--- task 17063 -- maha --27-7-2021----//
        public override DataTable CalculateSemesterPoint_Mod(TransactionManager transactionManager, System.String EdAcadYearId,
            System.String EdCodeSemesterId, System.String AsFacultyInfoId, System.String DeptEntMainId,
            System.String MjrEntMainId,  System.String UserId, decimal? LevelID, decimal? ExamTypeID)
        {
            DbCommand commandWrapper;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.MOD_CalculateTotals", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ExamTypeID", DbType.Decimal, ExamTypeID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@DeptEntMainId", DbType.Decimal, DeptEntMainId);
            database.AddInParameter(commandWrapper, "@MjrEntMainId", DbType.Decimal, MjrEntMainId);           
            database.AddInParameter(commandWrapper, "@UserID", DbType.Decimal, UserId);
            if (LevelID != null)
                database.AddInParameter(commandWrapper, "@LevelID", DbType.Decimal, LevelID);

            int results = 0;
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("MesgError");


            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                if (reader.FieldCount > 0)
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                if (reader.FieldCount > 0)
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
            }
            return table;
        }

        //---- added by maha 2-8-2021 ----//
        public override bool DeleteEdStudSemesterExtbyStudSemesterID(TransactionManager transactionManager, decimal StudSemesterID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.DeleteStudSemesterExtbyStudSemID", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, StudSemesterID);
            
            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "DeleteEdStudSemesterExtbyStudSemesterID"));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(results);
        }

        //--- task 17064 -- maha --26-8-2021----//
        public override DataTable CHK_SEMETER_SUMMER_MERIT_Conditions(TransactionManager transactionManager, decimal AsFacultyID, decimal EdStudID)
        {
            DbCommand commandWrapper;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHK_SEMETER_SUMMER_MERIT", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyID);
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, EdStudID);
            
            int results = 0;
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");


            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                if (reader.FieldCount > 0)
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                if (reader.FieldCount > 0)
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
            }
            return table;
        }
        
        //Menna
        public override DataSet GetResultSheetForLevelData_View3_Credit(decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCodeLevelId,
            decimal EntMainId, decimal Sort,decimal lang, decimal IsSuperUser,string CodeFrom,string CodeTo,decimal EdCodeStatusId, decimal ApproveFlg,decimal AdmissionYear,
            decimal FailedStud,  decimal AsCodeDegreeClassId,  decimal GenderId,decimal AccumPassCH_From, decimal AccumPassCH_To, decimal EnrollId)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("Rpt_ResultSheetForLevelData_View3_Credit", conn);
            command.CommandType = CommandType.StoredProcedure;
            //command.CommandTimeout = 500000;
            command.Parameters.Add("AsFacultyInfoId", SqlDbType.Decimal).Value = AsFacultyInfoId;
            command.Parameters.Add("EdAcadYearId", SqlDbType.Decimal).Value = EdAcadYearId;
            command.Parameters.Add("EdCodeSemesterId", SqlDbType.Decimal).Value = EdCodeSemesterId;
            command.Parameters.Add("EdCodeLevelId", SqlDbType.Decimal).Value = EdCodeLevelId;
            command.Parameters.Add("EntMainId", SqlDbType.Decimal).Value = EntMainId;
            command.Parameters.Add("Sort", SqlDbType.Decimal).Value = Sort;
            command.Parameters.Add("lang", SqlDbType.Decimal).Value = lang;
            command.Parameters.Add("IsSuperUser", SqlDbType.Decimal).Value = IsSuperUser;
           
            command.Parameters.Add("CodeFrom", DbType.String).Value =  CodeFrom; 
            command.Parameters.Add("CodeTo", DbType.String).Value =  CodeTo; 
            command.Parameters.Add("EdCodeStatusId", SqlDbType.Decimal).Value = EdCodeStatusId;
            command.Parameters.Add("ApproveFlg", SqlDbType.Decimal).Value = ApproveFlg;
            command.Parameters.Add("AdmissionYear", SqlDbType.Decimal).Value = AdmissionYear;
            command.Parameters.Add("FailedStud", SqlDbType.Decimal).Value = FailedStud;
            command.Parameters.Add("AsCodeDegreeClassId", SqlDbType.Decimal).Value = AsCodeDegreeClassId;
            command.Parameters.Add("GenderId", SqlDbType.Decimal).Value = GenderId;
            if (AccumPassCH_From!=0)
            command.Parameters.Add("AccumPassCH_From", SqlDbType.Decimal).Value =AccumPassCH_From;
            if (AccumPassCH_To!=0)
            command.Parameters.Add("AccumPassCH_To", SqlDbType.Decimal).Value =AccumPassCH_To;
            command.Parameters.Add("EnrollId", SqlDbType.Decimal).Value =EnrollId;
            conn.Open();


            //Create Collection
            DataSet table = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();


            return table;
        }
        
        //--- maha -- eue -- c------2-10-2022 ---//
        public override bool CalculateSemesterPassedCH_EUE(TransactionManager transactionManager, decimal _SelectedStudSemesterID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CalcSemesterPassedCH_EUE", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Selected_StudSemester", DbType.Xml, _SelectedStudSemesterID);
            
            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(results);
        }

        #endregion
	}
}