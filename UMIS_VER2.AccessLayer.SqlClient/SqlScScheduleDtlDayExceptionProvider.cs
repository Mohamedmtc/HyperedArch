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

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScScheduleDtlDayException"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScScheduleDtlDayExceptionProvider: SqlScScheduleDtlDayExceptionProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScScheduleDtlDayExceptionProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScScheduleDtlDayExceptionProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetScheduleDtlDay_Search(TransactionManager transactionManager, decimal ED_ACAD_YEAR_ID,
               decimal ED_CODE_SEMESTER_ID, decimal As_Faculty_Info_Id, decimal Ed_Course_Id,
                 decimal TeachingMethodId, decimal Lang, decimal ScScheduleDtlDayID, decimal WeekDayID)
        {
             SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetScheduleDtl_Day", this.UseStoredProcedure);
          
            database.AddInParameter(commandWrapper,"ED_ACAD_YEAR_ID", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper,"ED_CODE_SEMESTER_ID", DbType.Decimal, ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper,"As_Faculty_Info_Id", DbType.Decimal,As_Faculty_Info_Id);
            database.AddInParameter(commandWrapper,"ED_COURSE_ID", DbType.Decimal, Ed_Course_Id);
            database.AddInParameter(commandWrapper,"TeachingMethodId", DbType.Decimal,TeachingMethodId);
            database.AddInParameter(commandWrapper,"Lang", DbType.Decimal, Lang);
           database.AddInParameter(commandWrapper,"ScScheduleDtlDayID", DbType.Decimal, ScScheduleDtlDayID);
            database.AddInParameter(commandWrapper,"WeekDayID", DbType.Decimal, WeekDayID);
             IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("SC_SCHEDULE_DTL_DAY_ID");
             table.Columns.Add("ED_CODE_COURSE_TEACHING_ID");
             table.Columns.Add("SC_SCHEDULE_HDR_ID");
             table.Columns.Add("SC_SCHEDULE_DTL_ID");
             table.Columns.Add("GROUP_DESCR_AR");
             table.Columns.Add("GROUP_DESCR_EN");
             table.Columns.Add("ED_CDE_TCHNG_MTHD_ID");
             table.Columns.Add("TEACHING_DESCR_AR");
             table.Columns.Add("TEACHING_DESCR_EN");
             table.Columns.Add("ED_COURSE_ID");
             table.Columns.Add("COURSE_CODE");
             table.Columns.Add("CourseCode_AR");
             table.Columns.Add("COURSE_DESCR_AR");
             table.Columns.Add("COURSE_DESCR_EN");
             table.Columns.Add("Dayes");
             table.Columns.Add("TimeSlotes");
             table.Columns.Add("Halls");
             table.Columns.Add("OnlyHalls");
             table.Columns.Add("MAIN_LEC_STAFF_AR");
             table.Columns.Add("MAIN_LEC_STAFF_EN");
             table.Columns.Add("NO_STUDENTS");

             table.Columns.Add("GS_CODE_WEEK_DAY_ID");
             table.Columns.Add("DESCR_EN");
             table.Columns.Add("DESCR_AR");

             table.Columns.Add("SC_BUILDING_ID");
             table.Columns.Add("SC_HALL_ID");
             try
             {
                 if (transactionManager != null)
                 {
                     reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                     //read data
                     while (reader.Read())
                     {
                         object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                             reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString() ,reader[20].ToString()
                                          ,reader[21].ToString(),reader[22].ToString() ,reader[23].ToString(),reader[24].ToString() ,reader[25].ToString()};
                         table.Rows.Add(items);
                     }
                 }
                 else
                 {
                     reader = Utility.ExecuteReader(database, commandWrapper);
                     //read data
                     while (reader.Read())
                     {
                         object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                             reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString() ,reader[20].ToString() 
                                            ,reader[21].ToString(),reader[22].ToString() ,reader[23].ToString(),reader[23].ToString() ,reader[24].ToString()};

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

        
        
        
        
        public override DataTable ChekRepeatSectionEX(TransactionManager transactionManager, decimal? ScScheduleDtlDayId, decimal? ScBuildingId, decimal? ScHallId, DateTime? FromTime, DateTime? ToTime,DateTime ExceptionDate)
        {
            //  count = 0;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ChekRepeatSectionException", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlDayId", DbType.Decimal, ScScheduleDtlDayId);
            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, ScBuildingId);
            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, ScHallId);
            database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, (FromTime.HasValue ? (object)FromTime : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, (ToTime.HasValue ? (object)ToTime : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ExceptionDate", DbType.DateTime,ExceptionDate );
            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("SC_SCHEDULE_DTL_DAY_Exception_ID");
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

        public override DataTable GetScScheduleDtlDayEx(TransactionManager transactionManager, decimal? ScScheduleDtlDayId)
        {
            //  count = 0;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_ScheduleDtlDay_Exception", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlDayId", DbType.Decimal, ScScheduleDtlDayId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_SCHEDULE_DTL_DAY_Exception_Id");
            table.Columns.Add("SC_SCHEDULE_DTL_DAY_ID");
            table.Columns.Add("buildingAr");
            table.Columns.Add("buildingEn");
            table.Columns.Add("hallEn");
            table.Columns.Add("hallar");
            table.Columns.Add("SC_HALL_ID");
            table.Columns.Add("SC_BUILDING_ID");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("Exception_Date");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                         reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items =  { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                         reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
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

        public override DataTable getDaysCommonSLotsForEx(TransactionManager transactionManager, DateTime DateDay,decimal EdAcadYearID,decimal EdCodeSemesterId)
        {

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.getDaysCommonSLotsForExcept", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@Day", DbType.DateTime, DateDay);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, EdCodeSemesterId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_TCHNG_SLOT_ID");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
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

        public override DataTable GetFreeHallsForSectionException(TransactionManager transactionManager, decimal YearId, decimal SemesterId,
            decimal GsCodeWeekDayId, DateTime FromTime, DateTime ToTime, decimal BuildingId, decimal ScScheduleDtlDayId, DateTime NewExceptionDate)//Marwa 12/4/2022 18240
        {
            //  count = 0;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAllHallAvail", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, YearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, SemesterId);
            database.AddInParameter(commandWrapper, "@GsCodeWeekDayId", DbType.Decimal, GsCodeWeekDayId);
            database.AddInParameter(commandWrapper, "@Building_ID", DbType.Decimal, BuildingId);
            database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, FromTime);
            database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, ToTime);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlDayId", DbType.Decimal, ScScheduleDtlDayId);//Marwa 12/4/2022 18240
            database.AddInParameter(commandWrapper, "@NewExceptionDate", DbType.DateTime,NewExceptionDate);// maha 17-4-2022 ----//

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_BUILDING_ID");
            table.Columns.Add("BUILD_CODE");
            table.Columns.Add("BuildingAr");
            table.Columns.Add("BuildingEn");
            table.Columns.Add("SC_HALL_ID");
            table.Columns.Add("HALL_CODE");
            table.Columns.Add("HallAr");
            table.Columns.Add("CAPACITY");
            table.Columns.Add("IS_SHARED");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("HallEn");
            table.Columns.Add("EXM_CAPCITY");
            table.Columns.Add("CAPACITY_MAX");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                             reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                             reader[12].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                             reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                             reader[12].ToString() };

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
	}
}