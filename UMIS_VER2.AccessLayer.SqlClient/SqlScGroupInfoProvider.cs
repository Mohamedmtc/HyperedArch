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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScGroupInfo"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScGroupInfoProvider: SqlScGroupInfoProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScGroupInfoProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScGroupInfoProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Custom Methods

        public override DataTable SearchGroups(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asFacultyInfoId, System.Decimal _edCodeLevelId, System.Decimal _scCdeGrpTypeId, System.Decimal _scGroupInfoPrntId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_GROUP_INFO_SRCH", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _edCodeLevelId);
            database.AddInParameter(commandWrapper, "@ScCdeGrpTypeId", DbType.Decimal, _scCdeGrpTypeId);
            database.AddInParameter(commandWrapper, "@ScGroupInfoPrntId", DbType.Decimal, _scGroupInfoPrntId);

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("SC_GROUP_INFO_ID");
            tbl.Columns.Add("LEVEL_DESCR_AR");
            tbl.Columns.Add("LEVEL_DESCR_EN");
            tbl.Columns.Add("GRP_CODE");
            tbl.Columns.Add("GRP_AR");
            tbl.Columns.Add("GRP_EN");
            tbl.Columns.Add("GRP_TYPE_AR");
            tbl.Columns.Add("GRP_TYPE_EN");
            tbl.Columns.Add("STUD_COUNT");
            tbl.Columns.Add("PRNT_GRP_CODE");
            tbl.Columns.Add("PRNT_GRP_AR");
            tbl.Columns.Add("PRNT_GRP_EN");
            //Edit by nashassan 25/7/2016: Add Faculity name as a column in the table 
            tbl.Columns.Add("FACULTY_DESCR_AR");
            tbl.Columns.Add("FACULTY_DESCR_EN");
            //Edit by nashassan 7/8/2016
            tbl.Columns.Add("TeachMethAr");
            tbl.Columns.Add("TeachMethEn");
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

                //Edit by nashassan 25/7/2016: Add Faculity name as a column in the table 
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() , reader[5].ToString()
                                     , reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString()};
                    tbl.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return tbl;
        }
        //Marwa 9/3/2022 17995
        public override DataTable CheckGroupCapacity(TransactionManager transactionManager, System.Decimal SC_GROUP_INFO_ID, System.Decimal txtSectionCapacity, System.Decimal EdCourseId, System.Decimal? SectionID)
        {

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CheckGroupCapacity", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SC_GROUP_INFO_ID", DbType.Decimal, SC_GROUP_INFO_ID);
            database.AddInParameter(commandWrapper, "@txtSectionCapacity", DbType.Decimal, txtSectionCapacity);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@SectionID", DbType.Decimal, SectionID);

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Flag");
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
                    object[] items = { reader[0].ToString() };
                    tbl.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return tbl;
        }

        //Marwa 9/3/2022 17995
        public override DataTable CheckCapacityForAddingStudentInSection(TransactionManager transactionManager, System.Decimal SC_GROUP_INFO_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CheckCapacityForAddingStudentInSection", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SC_GROUP_INFO_ID", DbType.Decimal, SC_GROUP_INFO_ID);

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Flag");
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
                    object[] items = { reader[0].ToString() };
                    tbl.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return tbl;
        }
        //Marwa 21/3/2022 17980
        public override DataTable GroupValidation(TransactionManager transactionManager, decimal EdStudID, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyID, decimal Sc_Group_InfoID, decimal SC_Group_TypeID, decimal EdCorseID, decimal? CheckFlag=0)
        {

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GroupValidation", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, EdStudID);
            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@AsFacultyID", DbType.Decimal, AsFacultyID);
            database.AddInParameter(commandWrapper, "@Sc_Group_InfoID", DbType.Decimal, Sc_Group_InfoID);
            database.AddInParameter(commandWrapper, "@SC_Group_TypeID", DbType.Decimal, SC_Group_TypeID);
            database.AddInParameter(commandWrapper, "@EdCorseID", DbType.Decimal, EdCorseID);
            database.AddInParameter(commandWrapper, "@CheckFlag", DbType.Decimal, CheckFlag);

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("StudGroupID");
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
                    object[] items = { reader[0].ToString() };
                    tbl.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return tbl;
        }

        public override DataTable ScheduleSearch(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edCodeLevelId, System.Decimal _scCdeGrpTypeId, System.Decimal _scGroupInfoId, System.Decimal _ScBuildingId, System.Decimal _ScHallId, System.Decimal _SaStfMemberId, System.Decimal _ScTchngDayId, System.Decimal _EdCourseId,System.Boolean _PeriodId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_GROUP_INFO_ScheduleSearch", UseStoredProcedure);
             
            database.AddInParameter(commandWrapper, "@edAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@edCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@asFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@edCodeLevelId", DbType.Decimal, _edCodeLevelId);
            database.AddInParameter(commandWrapper, "@scCdeGrpTypeId", DbType.Decimal, _scCdeGrpTypeId);
            database.AddInParameter(commandWrapper, "@scGroupInfoId", DbType.Decimal, _scGroupInfoId);
            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, _ScBuildingId);
            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, _ScHallId);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@ScTchngDayId", DbType.Decimal, _ScTchngDayId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@PeriodId", DbType.Boolean, _PeriodId);
            
            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("SC_GROUP_DAY_ID");
            tbl.Columns.Add("GRP_CODE");
            tbl.Columns.Add("GRP_AR");
            tbl.Columns.Add("GRP_EN");
            tbl.Columns.Add("COURSE_CODE");
            tbl.Columns.Add("COURSE_DESCR_AR");
            tbl.Columns.Add("COURSE_DESCR_EN");
            tbl.Columns.Add("TCHNG_MTHD_DESCR_AR");
            tbl.Columns.Add("TCHNG_MTHD_DESCR_EN");
            tbl.Columns.Add("TCHNG_DAY_AR");
            tbl.Columns.Add("TCHNG_DAY_EN");
            tbl.Columns.Add("BUILD_CODE");
            tbl.Columns.Add("BUILD_DESCR_AR");
            tbl.Columns.Add("BUILD_DESCR_EN");
            tbl.Columns.Add("HALL_CODE");
            tbl.Columns.Add("HALL_DESCR_AR");
            tbl.Columns.Add("HALL_DESCR_EN");
            tbl.Columns.Add("SLOT_AR");
            tbl.Columns.Add("SLOT_EN");
            tbl.Columns.Add("SC_TCHNG_DAY_ID");
            tbl.Columns.Add("ED_CDE_TCHNG_MTHD_ID");
            tbl.Columns.Add("SC_TCHNG_SLOT_FRM_ID");
            tbl.Columns.Add("SC_TCHNG_SLOT_TO_ID");
            tbl.Columns.Add("ED_CODE_LEVEL_ID");
            tbl.Columns.Add("STF_FULL_NAME_EN");
            tbl.Columns.Add("STF_FULL_NAME_AR");
            tbl.Columns.Add("COURSE_TOPIC");
            tbl.Columns.Add("PERIOD_AR");
            tbl.Columns.Add("PERIOD_EN");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() , reader[5].ToString()
                                     , reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString()
                                     , reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString()
                                     , reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString()
                                     , reader[24].ToString(), reader[25].ToString(), reader[26].ToString(), reader[28].ToString(), reader[29].ToString()};
                    tbl.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return tbl;
        }

        public override DataTable ScheduleSearchStud(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edCodeLevelId, System.Decimal _scCdeGrpTypeId, System.Decimal _scGroupInfoId, System.Decimal _ScBuildingId, System.Decimal _ScHallId, System.Decimal _SaStfMemberId, System.Decimal _ScTchngDayId, System.Decimal _EdCourseId, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_SC_GROUP_INFO_ScheduleSearch_STUD", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@edAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@edCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@asFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@edCodeLevelId", DbType.Decimal, _edCodeLevelId);
            database.AddInParameter(commandWrapper, "@scCdeGrpTypeId", DbType.Decimal, _scCdeGrpTypeId);
            database.AddInParameter(commandWrapper, "@scGroupInfoId", DbType.Decimal, _scGroupInfoId);
            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, _ScBuildingId);
            database.AddInParameter(commandWrapper, "@ScHallId", DbType.Decimal, _ScHallId);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@ScTchngDayId", DbType.Decimal, _ScTchngDayId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("SC_GROUP_DAY_ID");
            tbl.Columns.Add("GRP_CODE");
            tbl.Columns.Add("GRP_AR");
            tbl.Columns.Add("GRP_EN");
            tbl.Columns.Add("COURSE_CODE");
            tbl.Columns.Add("COURSE_DESCR_AR");
            tbl.Columns.Add("COURSE_DESCR_EN");
            tbl.Columns.Add("TCHNG_MTHD_DESCR_AR");
            tbl.Columns.Add("TCHNG_MTHD_DESCR_EN");
            tbl.Columns.Add("TCHNG_DAY_AR");
            tbl.Columns.Add("TCHNG_DAY_EN");
            tbl.Columns.Add("BUILD_CODE");
            tbl.Columns.Add("BUILD_DESCR_AR");
            tbl.Columns.Add("BUILD_DESCR_EN");
            tbl.Columns.Add("HALL_CODE");
            tbl.Columns.Add("HALL_DESCR_AR");
            tbl.Columns.Add("HALL_DESCR_EN");
            tbl.Columns.Add("SLOT_AR");
            tbl.Columns.Add("SLOT_EN");
            tbl.Columns.Add("SC_TCHNG_DAY_ID");
            tbl.Columns.Add("ED_CDE_TCHNG_MTHD_ID");
            tbl.Columns.Add("SC_TCHNG_SLOT_FRM_ID");
            tbl.Columns.Add("SC_TCHNG_SLOT_TO_ID");
            tbl.Columns.Add("ED_CODE_LEVEL_ID");
            tbl.Columns.Add("ED_STUD_ID");
            tbl.Columns.Add("FROM_TIME");
            tbl.Columns.Add("TO_TIME");
            tbl.Columns.Add("GS_CODE_WEEK_DAY_ID");
            tbl.Columns.Add("STF_FULL_NAME_AR");
            tbl.Columns.Add("STF_FULL_NAME_EN");
            tbl.Columns.Add("TECH_METHOD_DESCREN");
            tbl.Columns.Add("TECH_METHOD_DESCRAR");
            


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() , reader[5].ToString()
                                     , reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString()
                                     , reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString()
                                     , reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString()
                                     , reader[24].ToString(), reader[25].ToString(), reader[26].ToString(), reader[27].ToString(), reader[28].ToString(), reader[29].ToString()
                                     , reader[30].ToString(), reader[31].ToString()};
                    tbl.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return tbl;
        }

        public override bool CopyGroupInfo(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EntMainId, decimal EdCodeLevelId, decimal EdAcadYearNewId, decimal EdCodeSemesterNewId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CopyGroupInfo", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EdAcadYearNewId", DbType.Decimal, EdAcadYearNewId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterNewId", DbType.Decimal, EdCodeSemesterNewId);

            int results = 0;

            try
            {
                if (transactionManager != null)
                {
                    results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    results = Utility.ExecuteNonQuery(database, commandWrapper);
                }
            }
            catch (Exception)
            {

            }

            return Convert.ToBoolean(results);


        }

        public override DataTable GetTeachingMethodByCourseID(TransactionManager transactionManager, System.Decimal _edCourseID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCrsTchngMthd", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _edCourseID);

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ED_CDE_TCHNG_MTHD_ID");
            tbl.Columns.Add("DESCR_EN");
            tbl.Columns.Add("DESCR_AR");


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString()};
                    tbl.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return tbl;
        }

        //Added by nashassan 9/8/2016
        public override DataTable GetGroupsInfoByTchngMthd(TransactionManager transactionManager, System.Decimal _ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetGroupsInfoByTchngMthd", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _ScScheduleDtlId);
        

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("SC_SCHEDULE_DTL_ID");
            tbl.Columns.Add("ED_CDE_TCHNG_MTHD_ID");
            tbl.Columns.Add("SC_GROUP_INFO_ID");
            tbl.Columns.Add("GRP_CODE");
            tbl.Columns.Add("GRP_AR");
            tbl.Columns.Add("GRP_EN");
            tbl.Columns.Add("SC_GROUP_INFO_PRNT_ID");
            tbl.Columns.Add("AS_FACULTY_INFO_ID");
            tbl.Columns.Add("FACULTY_DESCR_AR");
            tbl.Columns.Add("FACULTY_DESCR_EN");
           
        
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() , reader[5].ToString()
                                     , reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()};
                    tbl.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return tbl;
        }

        #endregion
    }
}