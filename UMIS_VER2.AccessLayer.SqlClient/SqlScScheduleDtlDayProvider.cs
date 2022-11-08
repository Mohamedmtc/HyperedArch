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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScScheduleDtlDay"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScScheduleDtlDayProvider: SqlScScheduleDtlDayProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScScheduleDtlDayProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScScheduleDtlDayProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        #region CourseScheduleSearch
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
        ///		FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_scTchngSlotId">مسلسل الفترة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        //updated by dalia at 17-10-2012 add new parameter @PkgID and its value =0 then overload the method 
        //to use it in the screen studcourseregister_section
        //and added new column appear to make it key column in grid
        public override DataTable CourseScheduleSearch(TransactionManager transactionManager,
              System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.String _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String _courseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal _CourseLvl, System.Decimal _AcademicPlanFlg,System.Decimal AsCodeDegreeClassId, int start, int pageLength, out int count)
        {
            count = 0;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CourseScheduleSearch", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainID", DbType.Decimal, _EntMainID);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@scStaffId", DbType.Decimal, _scStaffId);
            database.AddInParameter(commandWrapper, "@scScheduleDtlId", DbType.Decimal, _scScheduleDtlId);
            database.AddInParameter(commandWrapper, "@scDayId", DbType.String, _scDayId);
            database.AddInParameter(commandWrapper, "@scTchngSlotId", DbType.Decimal, _scTchngSlotId);
            database.AddInParameter(commandWrapper, "@scBuildingId", DbType.Decimal, _scBuildingId);
            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, _ScHallId);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, _courseCode);
            database.AddInParameter(commandWrapper, "@OrderById", DbType.Decimal, _OrderById);
            database.AddInParameter(commandWrapper, "@LanguageId", DbType.Decimal, _LanguageId);
            database.AddInParameter(commandWrapper, "@PkgID", DbType.Decimal, 0);
            database.AddInParameter(commandWrapper, "@CourseLvl", DbType.Decimal, _CourseLvl);
            database.AddInParameter(commandWrapper, "@AcademicPlanFlg", DbType.Decimal, _AcademicPlanFlg);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);
            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ScSchedualDtlId");
            table.Columns.Add("CourseDescr");
            table.Columns.Add("CourseCode");
            table.Columns.Add("EdCourseId"); 
            table.Columns.Add("StaffDescr");
            table.Columns.Add("GroupDescr");
            table.Columns.Add("DayDescr");
            table.Columns.Add("SlotDescr");
            table.Columns.Add("BuildingDescr");
            table.Columns.Add("HallDescr");
            table.Columns.Add("EntityMainDescr");
            table.Columns.Add("TeachMethodDescr");
            table.Columns.Add("NoAvailableSeats");
            table.Columns.Add("FromTime");
            table.Columns.Add("ToTime");
            table.Columns.Add("CampusDescr");
            //table.Columns.Add("ExamDate");
            //table.Columns.Add("ExamFromTime");
            //table.Columns.Add("ExamToTime");
            table.Columns.Add("Notes");
            table.Columns.Add("EdExamSchdlId");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                                           reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), 
                                           reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(),
                                           reader[15].ToString(), reader[16].ToString(), reader[17].ToString()};
                                           //, reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString() 
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                                           reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), 
                                           reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), 
                                           reader[15].ToString(), reader[16].ToString(), reader[17].ToString()};
                                           //, reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString() };
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

        #region Overloaded CourseScheduleSearch
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
        ///		FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_scTchngSlotId">مسلسل الفترة</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        //added by dalia at 17-10-2012 add new parameter @PkgID and its value =course pkg then overload the method 
        //to use it in the screen studcourseregister_section
        public override DataTable CourseScheduleSearchWithOutCourseReg(TransactionManager transactionManager,
              System.Decimal? _EdAcadYearId, System.Decimal? _EdCodeSemesterId, System.Decimal? _EntMainID, System.Decimal? _EdCourseId, System.Decimal? _scStaffId,
            System.Decimal? _scScheduleDtlId, System.Decimal? _scDayId, System.Decimal? _scTchngSlotId,
            System.Decimal? _scBuildingId, System.Decimal? _ScHallId, System.String _courseCode, System.Decimal? _OrderById,
            System.Decimal? _LanguageId, System.Decimal? _PkgID, System.Decimal? _StudSemesterID)
        {
          int  count = 0;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CourseScheduleSearchWithOutCourseReg", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainID", DbType.Decimal, _EntMainID);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@scStaffId", DbType.Decimal, _scStaffId);
            database.AddInParameter(commandWrapper, "@scScheduleDtlId", DbType.Decimal, _scScheduleDtlId);
            database.AddInParameter(commandWrapper, "@scDayId", DbType.Decimal, _scDayId);
            database.AddInParameter(commandWrapper, "@scTchngSlotId", DbType.Decimal, _scTchngSlotId);
            database.AddInParameter(commandWrapper, "@scBuildingId", DbType.Decimal, _scBuildingId);
            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, _ScHallId);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, _courseCode);
            database.AddInParameter(commandWrapper, "@OrderById", DbType.Decimal, _OrderById);
            database.AddInParameter(commandWrapper, "@LanguageId", DbType.Decimal, _LanguageId);
            database.AddInParameter(commandWrapper, "@PkgID", DbType.Decimal, _PkgID);
            database.AddInParameter(commandWrapper, "@StudSemesterID", DbType.Decimal, _StudSemesterID);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ScSchedualDtlId");
            table.Columns.Add("CourseDescr");
            table.Columns.Add("CourseCode");
            table.Columns.Add("EdCourseId"); 
            table.Columns.Add("StaffDescr");
            table.Columns.Add("GroupDescr");
            table.Columns.Add("DayDescr");
            table.Columns.Add("SlotDescr");
            table.Columns.Add("BuildingDescr");
            table.Columns.Add("HallDescr");
            table.Columns.Add("EntityMainDescr");
            table.Columns.Add("TeachMethodDescr");
            table.Columns.Add("NoAvailableSeats");
            table.Columns.Add("FromTime");
            table.Columns.Add("ToTime");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString() };
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
        public override DataTable GetScScheduleDtlDay(TransactionManager transactionManager, decimal? schedualdtlID, decimal? ScHallId, DateTime? FromTime, DateTime? ToTime, decimal? ScBuildingId, decimal? edCdeCourseTeachingId, string gsCodeWeekDayId)
        {
          //  count = 0;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetListScScheduleDtlDay", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, schedualdtlID);
            database.AddInParameter(commandWrapper, "@gsCodeWeekDayId", DbType.String, gsCodeWeekDayId);
            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, ScHallId);
            database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, (FromTime.HasValue ? (object)FromTime: System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, (ToTime.HasValue ? (object)ToTime : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, ScBuildingId);
            database.AddInParameter(commandWrapper, "@edCdeCourseTeachingId", DbType.Decimal, edCdeCourseTeachingId);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("SC_SCHEDULE_DTL_DAY_ID");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GS_CODE_WEEK_DAY_ID");
            table.Columns.Add("SC_TCHNG_SLOT_ID");
            table.Columns.Add("SC_BUILDING_ID");
            table.Columns.Add("SC_HALL_ID");
            table.Columns.Add("NOTES");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_ID");
          
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                                           reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()
 };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                                           reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()};
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


      

        public override string GetScheduleDtlDayes(TransactionManager transactionManager, Decimal ScScheduleDtlId, Decimal SC_TCHNG_SLOT_ID, Decimal SC_BUILDING_ID, Decimal SC_HALL_ID)
        {
           
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SP_GetScheduleDtlDayes", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@SC_TCHNG_SLOT_ID", DbType.Decimal, SC_TCHNG_SLOT_ID);
            database.AddInParameter(commandWrapper, "@SC_BUILDING_ID", DbType.Decimal, SC_BUILDING_ID);
            database.AddInParameter(commandWrapper, "@SC_HALL_ID", DbType.Decimal, SC_HALL_ID);
           
            string  strDays = "";

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {

                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetScheduleDtlDayes", rows));

                if (transactionManager != null)
                {
                    strDays = Utility.ExecuteScalar(transactionManager, commandWrapper) as string;
                }
                else
                {
                    strDays = Utility.ExecuteScalar(database, commandWrapper) as string;
                }


                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetScheduleDtlDayes", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return strDays;
        }
        #endregion
    }
}