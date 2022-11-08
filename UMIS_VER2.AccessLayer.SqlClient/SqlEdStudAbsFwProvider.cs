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
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudAbsFw"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlEdStudAbsFwProvider : SqlEdStudAbsFwProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlEdStudAbsFwProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlEdStudAbsFwProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Custom Method
        public override DataTable GetStudsForAttendanceWarning(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal _fromPercent, System.Decimal _toPercent, System.Decimal _seqNo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudsForAttendanceWarning", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);
            database.AddInParameter(commandWrapper, "@FromPercent", DbType.Decimal, _fromPercent);
            database.AddInParameter(commandWrapper, "@ToPercent", DbType.Decimal, _toPercent);
            database.AddInParameter(commandWrapper, "@SeqNo", DbType.Decimal, _seqNo);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("StudCode");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("LevelDescrAr");
            table.Columns.Add("LevelDescrEn");
            table.Columns.Add("StfFullNameAr");
            table.Columns.Add("StfFullNameEn");
            table.Columns.Add("AllSessionNo");
            table.Columns.Add("StudAbsCount");
            table.Columns.Add("StudAbsPercent");
            table.Columns.Add("SeqNo");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
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

        public override DataTable GetAllAttendanceWarningForView(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.String _StudCode, System.Decimal _AsCodeDegreeClassId, System.Decimal _scScheduleDtlId, System.Decimal _WarningType, System.Decimal _majorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetAllAttendanceWarning", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _scScheduleDtlId);
            database.AddInParameter(commandWrapper, "@WarningType", DbType.Decimal, _WarningType);
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, _majorId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("SEQ_NO");
            table.Columns.Add("IS_RESULT_APPROVED");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("StudAbs");
            table.Columns.Add("StudAbsPrcnt");
            table.Columns.Add("StudAbsExec");
            table.Columns.Add("StudAbsExecPrcnt");
            table.Columns.Add("AbsWarnStatusId");
            table.Columns.Add("ED_CDE_EXAM_TYPE_ID");
            table.Columns.Add("MAJOR_ACCUM_CH");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                       reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), 
                                       reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), 
                                       reader[16].ToString() ,reader[17].ToString() ,reader[18].ToString() ,reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),
                                       reader[22].ToString(),reader[23].ToString(),reader[24].ToString()};
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

        //Esraa Ali         2-4-2019            8493
        public override DataTable GetAllAttendanceWarning_TOT_CRS_CHForView(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.String _StudCode, System.Decimal _AsCodeDegreeClassId, System.Decimal _scScheduleDtlId, System.Decimal _WarningType, System.Decimal _majorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetAllAttendanceWarning_TOT_CRS_CH", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _scScheduleDtlId);
            database.AddInParameter(commandWrapper, "@WarningType", DbType.Decimal, _WarningType);
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, _majorId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("SEQ_NO");
            table.Columns.Add("IS_RESULT_APPROVED");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("StudAbs");
            table.Columns.Add("StudAbsPrcnt");
            table.Columns.Add("StudAbsExec");
            table.Columns.Add("StudAbsExecPrcnt");
            table.Columns.Add("AbsWarnStatusId");
            table.Columns.Add("ED_CDE_EXAM_TYPE_ID");
            table.Columns.Add("MAJOR_ACCUM_CH");

            //kamela, KU Issue
            table.Columns.Add("ABS_RATE_WARNINIG_1");
            table.Columns.Add("ABS_RATE_WARNINIG_2");
            table.Columns.Add("ABS_RATE_COURSE_FAIL");
            //end 

            //Angham 30032020 
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            //End Angham 30032020 
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                       reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), 
                                       reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), 
                                       reader[16].ToString() ,reader[17].ToString() ,reader[18].ToString() ,reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),
                                       reader[22].ToString() , reader[23].ToString() , reader[24].ToString() , reader[25].ToString(),
                                       reader[26].ToString() , reader[27].ToString()
                                     };
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

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudAbsFw entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_ABS_FW_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudAbsFwId", DbType.Decimal, 10);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@DecisionDate", DbType.DateTime, entity.DecisionDate);
            database.AddInParameter(commandWrapper, "@SeqNo", DbType.Decimal, entity.SeqNo);
            database.AddInParameter(commandWrapper, "@FwFlg", DbType.Decimal, entity.FwFlg);
            database.AddInParameter(commandWrapper, "@AbsCount", DbType.Decimal, (entity.AbsCount.HasValue ? (object)entity.AbsCount : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AbsPercent", DbType.Decimal, (entity.AbsPercent.HasValue ? (object)entity.AbsPercent : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CnclFlg", DbType.Decimal, entity.CnclFlg);
            database.AddInParameter(commandWrapper, "@MailFlg", DbType.Decimal, (entity.MailFlg.HasValue ? (object)entity.MailFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeFormId", DbType.Decimal, (entity.SeFormId.HasValue ? (object)entity.SeFormId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));

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

            object _edStudAbsFwId = database.GetParameterValue(commandWrapper, "@EdStudAbsFwId");
            entity.EdStudAbsFwId = (System.Decimal)_edStudAbsFwId;

            entity.OriginalEdStudAbsFwId = entity.EdStudAbsFwId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }
        /*-- 24-12-2020 --- maha task 15565 ---*/
        public override DataTable GetModularAllAttendanceWarningForView(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.String _StudCode, System.Decimal _AsCodeDegreeClassId, System.Decimal _grpId, System.Decimal _WarningType, System.Decimal _majorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Mod_GetAllAttendanceWarning", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@grpId", DbType.Decimal, _grpId);
            database.AddInParameter(commandWrapper, "@WarningType", DbType.Decimal, _WarningType);
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, _majorId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("SEQ_NO");
            table.Columns.Add("IS_RESULT_APPROVED");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("StudAbs");
            table.Columns.Add("StudAbsPrcnt");
            table.Columns.Add("StudAbsExec");
            table.Columns.Add("StudAbsExecPrcnt");
            table.Columns.Add("AbsWarnStatusId");
            table.Columns.Add("ED_CDE_EXAM_TYPE_ID");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                       reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), 
                                       reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), 
                                       reader[16].ToString() ,reader[17].ToString() ,reader[18].ToString() ,reader[19].ToString(),reader[20].ToString(),reader[21].ToString()  };
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