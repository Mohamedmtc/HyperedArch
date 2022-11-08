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
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SeBlockTrans"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlSeBlockTransProvider : SqlSeBlockTransProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlSeBlockTransProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlSeBlockTransProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }
        #region Custom Methods

        public override DataTable GetStudentsToBlosk(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? AsCodeDegreeclassId
            , string StudCode, string StudCodeFrom, string StudCodeTo, decimal? FlagFreez, decimal? AdmissionYear, decimal? OrientationFlag, decimal? EnrollStatus, decimal? LoadType, decimal? paymentflg, decimal? miltirystatus, decimal? GsCodeMilitaryStateId, decimal? BlockReasonID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetBlockStudents", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, lang.HasValue ? (object)lang : DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, !string.IsNullOrEmpty(StudCode) ? (object)StudCode : DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudCodeFrom", DbType.String, !string.IsNullOrEmpty(StudCodeFrom) ? (object)StudCodeFrom : DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudCodeTo", DbType.String, !string.IsNullOrEmpty(StudCodeTo) ? (object)StudCodeTo : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId.HasValue ? (object)EdAcadYearId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemId.HasValue ? (object)EdCodeSemId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId.HasValue ? (object)EntMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@FlagFreez", DbType.Decimal, FlagFreez.HasValue ? (object)FlagFreez : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeclassId.HasValue ? (object)AsCodeDegreeclassId : DBNull.Value);

            database.AddInParameter(commandWrapper, "@EdAdmAcadYearId", DbType.Decimal, AdmissionYear.HasValue ? (object)AdmissionYear : DBNull.Value);
            database.AddInParameter(commandWrapper, "@OrientationFlag", DbType.Decimal, OrientationFlag.HasValue ? (object)OrientationFlag : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollTypeId", DbType.Decimal, EnrollStatus.HasValue ? (object)EnrollStatus : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeLoadTypeId", DbType.Decimal, LoadType.HasValue ? (object)LoadType : DBNull.Value);
            database.AddInParameter(commandWrapper, "@paymentflg", DbType.Decimal, paymentflg.HasValue ? (object)paymentflg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@miltirystatus", DbType.Decimal, miltirystatus.HasValue ? (object)miltirystatus : DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCodeMilitaryStateId", DbType.Decimal, GsCodeMilitaryStateId.HasValue ? (object)GsCodeMilitaryStateId : DBNull.Value);
            #region MyRegion
            database.AddInParameter(commandWrapper, "@BlockReasonID", DbType.Decimal, BlockReasonID.HasValue ? (object)BlockReasonID : DBNull.Value);
            #endregion
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudCode");
            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("EdStudId");
            table.Columns.Add("CGPA");
            table.Columns.Add("ACCUM_CREDIT");
            table.Columns.Add("FREEZE_FLG");
            table.Columns.Add("SE_BLOCK_TRANS_ID");
            table.Columns.Add("MAJOR_EN");
            table.Columns.Add("MAJOR_AR");
            //
            table.Columns.Add("BLOCK_TYPE_DESCR_AR");
            table.Columns.Add("BLOCK_TYPE_DESCR_EN");
            table.Columns.Add("SE_CDE_BLOCK_TYPE_ID");
            table.Columns.Add("NOtes");

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
                    object[] items = { 
                                         reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                         reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString(),
                                         reader[8].ToString(), reader[9].ToString()
                                         //
                                         ,reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString()
                                       
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
        //copied from GetStudentsToBlosk and change sp  by mmq at 30-01-2017 // Task 5056
        public override DataTable GetStudentsToBlosk_HU(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? AsCodeDegreeclassId
       , string StudCode, string StudCodeFrom, string StudCodeTo, decimal? FlagFreez, decimal? AdmissionYear, decimal? OrientationFlag, decimal? EnrollStatus, decimal? LoadType, decimal? paymentflg, decimal? miltirystatus, decimal? GsCodeMilitaryStateId, decimal? BlockReasonID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetBlockStudents_HU", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, lang.HasValue ? (object)lang : DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, !string.IsNullOrEmpty(StudCode) ? (object)StudCode : DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudCodeFrom", DbType.String, !string.IsNullOrEmpty(StudCodeFrom) ? (object)StudCodeFrom : DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudCodeTo", DbType.String, !string.IsNullOrEmpty(StudCodeTo) ? (object)StudCodeTo : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId.HasValue ? (object)EdAcadYearId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemId.HasValue ? (object)EdCodeSemId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId.HasValue ? (object)EntMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@FlagFreez", DbType.Decimal, FlagFreez.HasValue ? (object)FlagFreez : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeclassId.HasValue ? (object)AsCodeDegreeclassId : DBNull.Value);

            database.AddInParameter(commandWrapper, "@EdAdmAcadYearId", DbType.Decimal, AdmissionYear.HasValue ? (object)AdmissionYear : DBNull.Value);
            database.AddInParameter(commandWrapper, "@OrientationFlag", DbType.Decimal, OrientationFlag.HasValue ? (object)OrientationFlag : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollTypeId", DbType.Decimal, EnrollStatus.HasValue ? (object)EnrollStatus : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeLoadTypeId", DbType.Decimal, LoadType.HasValue ? (object)LoadType : DBNull.Value);
            database.AddInParameter(commandWrapper, "@paymentflg", DbType.Decimal, paymentflg.HasValue ? (object)paymentflg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@miltirystatus", DbType.Decimal, miltirystatus.HasValue ? (object)miltirystatus : DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCodeMilitaryStateId", DbType.Decimal, GsCodeMilitaryStateId.HasValue ? (object)GsCodeMilitaryStateId : DBNull.Value);

            #region MyRegion
            database.AddInParameter(commandWrapper, "@BlockReasonID", DbType.Decimal, BlockReasonID.HasValue ? (object)BlockReasonID : DBNull.Value);
            #endregion

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudCode");
            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("EdStudId");
            table.Columns.Add("CGPA");
            table.Columns.Add("ACCUM_CREDIT");
            table.Columns.Add("FREEZE_FLG");
            table.Columns.Add("SE_BLOCK_TRANS_ID");
            table.Columns.Add("MAJOR_EN");
            table.Columns.Add("MAJOR_AR");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            //
            table.Columns.Add("BLOCK_TYPE_DESCR_AR");
            table.Columns.Add("BLOCK_TYPE_DESCR_EN");
            table.Columns.Add("SE_CDE_BLOCK_TYPE_ID");
            table.Columns.Add("NOtes");
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
                    object[] items = { 
                                         reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                         reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString(),
                                         reader[8].ToString(), reader[9].ToString(), reader[10].ToString()
                                         //
                                         ,reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString()
                                       
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
        public override DataTable GetCourseSectionToBlosk(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? SectionId, string courseCode, decimal? FlagFreez, decimal? BlockType, decimal? AsCodeDegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetBlockCourseSection", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, lang.HasValue ? (object)lang : DBNull.Value);
            database.AddInParameter(commandWrapper, "@courseCode", DbType.String, !string.IsNullOrEmpty(courseCode) ? (object)courseCode : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId.HasValue ? (object)EdAcadYearId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemId.HasValue ? (object)EdCodeSemId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId.HasValue ? (object)EntMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@FlagFreez", DbType.Decimal, FlagFreez.HasValue ? (object)FlagFreez : DBNull.Value);
            database.AddInParameter(commandWrapper, "@SectionId", DbType.Decimal, SectionId.HasValue ? (object)SectionId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@BlockType", DbType.Decimal, BlockType.HasValue ? (object)BlockType : DBNull.Value);
            // database.AddInParameter(commandWrapper, "@SelectioType", DbType.Decimal, SelectioType.HasValue ? (object)SelectioType : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId.HasValue ? (object)AsCodeDegreeClassId : DBNull.Value);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("GROUP_ORDER");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("NO_STUDENTS");
            table.Columns.Add("NO_STUD_MAX");
            table.Columns.Add("NO_STUD_WAIT");
            table.Columns.Add("ONLINE_FLG");
            table.Columns.Add("WAITLIST_FLG");
            table.Columns.Add("BlockScheduleid");
            table.Columns.Add("BlockCourseId");
            table.Columns.Add("SE_BLOCK_TRANS_ID");
            table.Columns.Add("EMP_STUD_FLG");
            table.Columns.Add("ActiveStudCount");
            table.Columns.Add("WaitStudCount");
            
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
                    object[] items = { 
                                       reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString(),
                                       reader[8].ToString() , reader[9].ToString() , reader[10].ToString(), reader[11].ToString(),
                                       reader[12].ToString() , reader[13].ToString() , reader[14].ToString(), reader[15].ToString(),
                                       reader[16].ToString() , reader[17].ToString() ,reader[18].ToString() 

                                       
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
        public override void DeleteBlockStudent(TransactionManager transactionManager, System.Decimal _SeBlockTransId, System.Decimal EdCodeSemId, System.Decimal EdAcadYearId, System.Decimal SeCdeBlockTypeId, System.Decimal ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.deleteBlockStudent", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SeBlockTransId", DbType.Decimal, _SeBlockTransId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemId);
            database.AddInParameter(commandWrapper, "@SeCdeBlockTypeId", DbType.Decimal, SeCdeBlockTypeId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "DeleteBlockStudent"));

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "DeleteBlockStudent"));

            commandWrapper = null;
        }//end Delete
        public override decimal InsertBlockStudent(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeBlockTrans entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.InsertBlockStudent", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SeBlockTransId", DbType.Decimal, entity.SeBlockTransId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, entity.SeUserId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, (entity.EdCourseId.HasValue ? (object)entity.EdCourseId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, (entity.EdStudId.HasValue ? (object)entity.EdStudId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, (entity.ScScheduleDtlId.HasValue ? (object)entity.ScScheduleDtlId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@TransDate", DbType.DateTime, entity.TransDate);
            database.AddInParameter(commandWrapper, "@SeCdeBlockTypeId", DbType.Decimal, entity.SeCdeBlockTypeId);
            //  database.AddInParameter(commandWrapper, "@SelectionType", DbType.Decimal, SelectionType);


            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertBlockStudent", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            entity.OriginalSeBlockTransId = entity.SeBlockTransId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "InsertBlockStudent", entity));
            return Convert.ToDecimal(commandWrapper.Parameters["@SeBlockTransId"].Value);
        }

        public override bool InsertBulkBlockStudent(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? SectionId, string courseCode, decimal? FlagFreez, decimal? BlockType, decimal? AsCodeDegreeClassId, decimal UserId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetBulkBlockCourseSection", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, lang.HasValue ? (object)lang : DBNull.Value);
            database.AddInParameter(commandWrapper, "@courseCode", DbType.String, !string.IsNullOrEmpty(courseCode) ? (object)courseCode : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId.HasValue ? (object)EdAcadYearId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemId.HasValue ? (object)EdCodeSemId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId.HasValue ? (object)EntMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@FlagFreez", DbType.Decimal, FlagFreez.HasValue ? (object)FlagFreez : DBNull.Value);
            database.AddInParameter(commandWrapper, "@SectionId", DbType.Decimal, SectionId.HasValue ? (object)SectionId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@BlockType", DbType.Decimal, BlockType.HasValue ? (object)BlockType : DBNull.Value);
            // database.AddInParameter(commandWrapper, "@SelectioType", DbType.Decimal, SelectioType.HasValue ? (object)SelectioType : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId.HasValue ? (object)AsCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, UserId);


            int results = 0;

            //Provider Data Requesting Command Event
            // OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertBulkBlockStudent", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            //object _seBlockTransId = database.GetParameterValue(commandWrapper, "@SeBlockTransId");
            //entity.SeBlockTransId = (System.Decimal)_seBlockTransId;

            //entity.OriginalSeBlockTransId = entity.SeBlockTransId;

            //entity.AcceptChanges();

            ////Provider Data Requested Command Event
            //OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        public override bool BulkBlockTrans(TransactionManager transactionManager, System.String SlctdScSchedulDtlID, decimal EmpStudFlg, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, string courseCode, decimal? FlagFreez, decimal? BlockType, decimal? AsCodeDegreeClassId, decimal UserId, decimal BulkFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_BulkBlockTrans", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@courseCode", DbType.String, !string.IsNullOrEmpty(courseCode) ? (object)courseCode : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId.HasValue ? (object)EdAcadYearId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemId.HasValue ? (object)EdCodeSemId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId.HasValue ? (object)EntMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@FlagFreez", DbType.Decimal, FlagFreez.HasValue ? (object)FlagFreez : DBNull.Value);
            database.AddInParameter(commandWrapper, "@BlockType", DbType.Decimal, BlockType.HasValue ? (object)BlockType : DBNull.Value);
            database.AddInParameter(commandWrapper, "@BulkFlg", DbType.Decimal, BulkFlg);
            database.AddInParameter(commandWrapper, "@EmpStudFlg", DbType.Decimal, EmpStudFlg);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId.HasValue ? (object)AsCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, UserId);
            database.AddInParameter(commandWrapper, "@SlctdScSchedulDtlID", DbType.Xml, SlctdScSchedulDtlID.Length > 10 ? (object)SlctdScSchedulDtlID : DBNull.Value);

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
        /*-----task 11283  ---KU ----2-12-2019 ---*/
        public override void UnBlockStudent_Fees(TransactionManager transactionManager,decimal StudentID, decimal EdAcadYearID, decimal EdCodeSemsterID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UnBlockStudHasRemain", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AcadYearID" ,DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@CodeSemsterID", DbType.Decimal, EdCodeSemsterID);
            database.AddInParameter(commandWrapper, "@StudID", DbType.Decimal, StudentID);

            int results = 0;
            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

        }


        #endregion
    }
}