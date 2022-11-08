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
using System.Configuration;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
    ///<summary>
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStud"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlEdStudProvider : SqlEdStudProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlEdStudProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlEdStudProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Custom Methods

        public override DataTable GetStudAcadData(System.Decimal? _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentAcadData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            //table.Columns.Add("LOAD_DESCR_AR");
            table.Columns.Add("MAJOR_AR");
            table.Columns.Add("MAJOR_EN");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("ACCUM_CH");
            //table.Columns.Add("LOAD_DESCR_AR");
            //table.Columns.Add("LOAD_DESCR_EN");
            //  table.Columns.Add("HAVE_REMISSION");
            // table.Columns.Add("SPONSOR_NAME_AR");
            //table.Columns.Add("SPONSOR_NAME_EN");
            // table.Columns.Add("DESCR_EN");
            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString()
                                     , reader[7].ToString(),  reader[8].ToString(),  reader[9].ToString() ,  reader[10].ToString() };
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

        public override DataTable FeeStudentsSearch(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudName, System.String _StudCode, System.String _StudCPR, System.String _SearchType)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_FeeStudentsSearch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, _StudName);
            database.AddInParameter(commandWrapper, "@CPR", DbType.String, _StudCPR);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@SearchType", DbType.String, _SearchType);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("ED_STUD_ID");

            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("NATIONAL_NUMBER");
            table.Columns.Add("STUD_FACULTY_CODE");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString()};
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

        public override DataTable GeStudSemWork(TransactionManager transactionManager, System.Decimal? _EdStudSemester)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GeStudSemWork", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_STUD_SEMESTER_ID", DbType.Decimal, _EdStudSemester);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ASSESS_DESCR_AR");
            table.Columns.Add("ASSESS_DESCR_EN");
            table.Columns.Add("ASSESS_DEG");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString()};
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


        public override DataTable GetStudentsToBeSponsored(TransactionManager transactionManager, decimal? lang, string edStudName,
            decimal? namePolicy, string studFacultyCode, decimal? _CGPAFrom, decimal? _CGPATo, decimal? earnedCrFrom,
            decimal? earnedCrTo, string edCodeEnrollTypeIds, decimal? edAcadYearId, decimal? edCodeSemesterId,
            decimal? spoSponsorId, decimal? lastSemesterFlg, decimal? GsCountryNodeId, decimal? AsFacultyInfoId,
            decimal? EntMainId, string cpr, decimal pageIndex, decimal pageSize, decimal allowSort, decimal sortColumn, decimal sortDirection)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentsToBeSponsored", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, lang.HasValue ? (object)lang : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdStudName", DbType.String, !string.IsNullOrEmpty(edStudName) ? (object)edStudName : DBNull.Value);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, namePolicy.HasValue ? (object)namePolicy : DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudFacultyCode", DbType.String, !string.IsNullOrEmpty(studFacultyCode) ? (object)studFacultyCode : DBNull.Value);
            database.AddInParameter(commandWrapper, "@CGPAFrom", DbType.Decimal, _CGPAFrom.HasValue ? (object)_CGPAFrom : DBNull.Value);
            database.AddInParameter(commandWrapper, "@CGPATo", DbType.Decimal, _CGPATo.HasValue ? (object)_CGPATo : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EarnedCrFrom", DbType.Decimal, earnedCrFrom.HasValue ? (object)earnedCrFrom : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EarnedCrTo", DbType.Decimal, earnedCrTo.HasValue ? (object)earnedCrTo : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollTypeIds", DbType.String, !string.IsNullOrEmpty(edCodeEnrollTypeIds) ? (object)edCodeEnrollTypeIds : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId.HasValue ? (object)edAcadYearId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemester", DbType.Decimal, edCodeSemesterId.HasValue ? (object)edCodeSemesterId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@spoSponsorId", DbType.Decimal, spoSponsorId.HasValue ? (object)spoSponsorId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@LastSemesterFlg", DbType.Decimal, lastSemesterFlg.HasValue ? (object)lastSemesterFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId.HasValue ? (object)EntMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@NationalNumber", DbType.String, !string.IsNullOrEmpty(cpr) ? (object)cpr : DBNull.Value);

            database.AddInParameter(commandWrapper, "@gsCountryNodeId", DbType.Decimal, GsCountryNodeId.HasValue ? (object)GsCountryNodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);
            database.AddInParameter(commandWrapper, "@AllowSort", DbType.Decimal, allowSort);
            database.AddInParameter(commandWrapper, "@SortColumn", DbType.Decimal, sortColumn);
            database.AddInParameter(commandWrapper, "@SortDirection", DbType.Decimal, sortDirection);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("HAVE_SPONSOR");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ENT_CODE_ENTITY_TYPE_ID");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("ED_CODE_ENROLL_TYPE_ID");
            table.Columns.Add("ActiveAcadYearId");
            table.Columns.Add("ActiveEdCodeSemester");
            table.Columns.Add("RowsTotCount");
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
                                         reader[12].ToString(), reader[13].ToString() , reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString()
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

        public override DataTable GetThesis_Course_Stud(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId,
            System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetThesis_Course_Stud", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ED_STUD_ID", DbType.Decimal, _EdStudId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("YEAR_ORDER");
            table.Columns.Add("SEMESTER_ORDER");
            table.Columns.Add("ACAD_YEAR_DESCR_AR");
            table.Columns.Add("ACAD_YEAR_DESCR_EN");
            table.Columns.Add("SEMESTER_DESCR_AR");
            table.Columns.Add("SEMESTER_DESCR_EN");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString(), reader[8].ToString()
                                     , reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString()};
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

        public override DataTable FilterStudDataForMails(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
      , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
      string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStudDataForMails", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("NATIONAL_NUMBER");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("CL_FULL_NAME_AR");
            table.Columns.Add("STUD_NAME_AR");
            table.Columns.Add("CL_STUD_NAME_AR");
            table.Columns.Add("FATHER_NAME_AR");
            table.Columns.Add("CL_FATHER_NAME_AR");
            table.Columns.Add("GRANDFATHER_NAME_AR");
            table.Columns.Add("CL_GRANDFATHER_NAME_AR");
            table.Columns.Add("FAMILY_NAME_AR");
            table.Columns.Add("CL_FAMILY_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_NAME_EN");
            table.Columns.Add("FATHER_NAME_EN");
            table.Columns.Add("GRANDFATHER_NAME_EN");
            table.Columns.Add("FAMILY_NAME_EN");
            table.Columns.Add("FATHER_PROFESSION");
            table.Columns.Add("FATHER_NATIONAL_NUMBER");
            table.Columns.Add("MOTHER_NATIONAL_NUMBER");
            table.Columns.Add("MOTHER_NAME_AR");
            table.Columns.Add("CL_MOTHER_NAME_AR");
            table.Columns.Add("MOTHER_NAME_EN");
            table.Columns.Add("GS_CODE_GENDER_ID");
            table.Columns.Add("GS_CODE_RELIGION_ID");
            table.Columns.Add("BIRTH_REG_NUMBER");
            table.Columns.Add("BIRTH_DATE");
            table.Columns.Add("GS_BIRTH_COUNTRY_NODE_ID");
            table.Columns.Add("GS_COUNTRY_INFO_ID_1");
            table.Columns.Add("GS_COUNTRY_INFO_ID_2");
            table.Columns.Add("STUD_PHOTO");
            table.Columns.Add("GS_CODE_IDENT_TYPE_ID");
            table.Columns.Add("IS_PRNT_STAFF");
            table.Columns.Add("SA_STF_MEMBER_PRNT_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("GENDER_DESCR_Ar");
            table.Columns.Add("RELIGION_DESCR_AR");
            table.Columns.Add("DESCR_Ar");
            table.Columns.Add("Temp1");
            table.Columns.Add("Temp2");
            table.Columns.Add("GetStudStatesAr");
            table.Columns.Add("GetStudStatesEn");
            table.Columns.Add("CurrLevelDescr");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(),
                                     reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),reader[22].ToString(),reader[23].ToString(),reader[24].ToString()
                                     ,reader[25].ToString(),reader[26].ToString(),reader[27].ToString(),reader[28].ToString(),reader[29].ToString(),reader[30].ToString()
                                     ,reader[31].ToString(),reader[32].ToString(),reader[33].ToString(),reader[34].ToString(),reader[35].ToString(),reader[36].ToString()
                                     ,reader[37].ToString(),reader[38].ToString(),reader[39].ToString(),reader[40].ToString(),reader[41].ToString(),reader[42].ToString()
                                    ,reader[43].ToString() };
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

        public override DataTable FilterStudDataForSections(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId,

            string StudName, string StudCode, System.Decimal _LangNum, System.Decimal scSheduleDtlId, System.Decimal EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStudSectionsData", this.UseStoredProcedure);


            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@scSheduleDtlId", DbType.Decimal, scSheduleDtlId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("AccumCh");
            table.Columns.Add("AccumGpa");
            table.Columns.Add("ScScheduleDtlId");


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
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


        public override DataTable GetFilteredStudentsList(TransactionManager transactionManager, Hashtable studSearchParams)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_StudFilter", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, studSearchParams["_asFacultyInfoId"]);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, studSearchParams["_EdAcadYearId"]);
            database.AddInParameter(commandWrapper, "@EdAdmAcadYearId", DbType.Decimal, studSearchParams["EdAdmAcadYearId"]);
            database.AddInParameter(commandWrapper, "@EdAdmAcadSemesterID", DbType.Decimal, studSearchParams["EdAdmAcadSemesterID"]);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, studSearchParams["_EdCodeSemesterId"]);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, studSearchParams["_EntityMainId"]);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, studSearchParams["_GsCodeGenderId"]);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, studSearchParams["_GsCountryInfoId"]);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, studSearchParams["StudName"]);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, studSearchParams["StudCode"]);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, studSearchParams["NationalNum"]);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, studSearchParams["_LangNum"]);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, studSearchParams["_NamePolicy"]);

            database.AddInParameter(commandWrapper, "@DegreeClassId", DbType.Decimal, studSearchParams["_DegreeClass"]);
            database.AddInParameter(commandWrapper, "@CodeDegreeId", DbType.Decimal, studSearchParams["_CodeDegree"]);
            database.AddInParameter(commandWrapper, "@GPAFrom", DbType.Decimal, studSearchParams["_GPAFrom"]);
            database.AddInParameter(commandWrapper, "@GPATo", DbType.Decimal, studSearchParams["_GPATo"]);
            database.AddInParameter(commandWrapper, "@CHFrom", DbType.Decimal, studSearchParams["_CHFrom"]);
            database.AddInParameter(commandWrapper, "@CHTo", DbType.Decimal, studSearchParams["_CHTo"]);
            database.AddInParameter(commandWrapper, "@EdcdeAcadWarnId", DbType.Decimal, studSearchParams["EdcdeAcadWarnId"]);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, studSearchParams["EdCodeLevelId"]);
            database.AddInParameter(commandWrapper, "@GovernorateId", DbType.Decimal, studSearchParams["GovernorateId"]);
            // database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, studSearchParams["EdCodeCourseId"]);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, studSearchParams["EdCourseId"]);
            database.AddInParameter(commandWrapper, "@SectionId", DbType.Decimal, studSearchParams["SectionId"]);
            database.AddInParameter(commandWrapper, "@AcadAdvisorId", DbType.Decimal, studSearchParams["AcadAdvisorId"]);
            database.AddInParameter(commandWrapper, "@EdCodeLoadTypeId", DbType.Decimal, studSearchParams["EdCodeLoadTypeId"]);
            database.AddInParameter(commandWrapper, "@OrientationFlag", DbType.Decimal, studSearchParams["OrientationFlag"]);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollTypeId", DbType.Decimal, studSearchParams["EdCodeEnrollTypeId"]);
            database.AddInParameter(commandWrapper, "@SpoSponsorId", DbType.Decimal, studSearchParams["SpoSponsorId"]);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, studSearchParams["SaStfMemberId"]);
            database.AddInParameter(commandWrapper, "@EntMainMinorId", DbType.Decimal, studSearchParams["EntMainMinorId"]);
            database.AddInParameter(commandWrapper, "@GraduatesFlag", DbType.Decimal, studSearchParams["GraduatesFlag"]);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, decimal.Parse(studSearchParams["PageIndex"].ToString()));
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, decimal.Parse(studSearchParams["PageSize"].ToString()));
            database.AddInParameter(commandWrapper, "@AllowSort", DbType.Decimal, decimal.Parse(studSearchParams["AllowSort"].ToString()));
            database.AddInParameter(commandWrapper, "@SortColumn", DbType.Decimal, decimal.Parse(studSearchParams["SortColumn"].ToString()));
            database.AddInParameter(commandWrapper, "@SortDirection", DbType.Decimal, decimal.Parse(studSearchParams["SortDirection"].ToString()));
            database.AddInParameter(commandWrapper, "@PassportNum", DbType.String, studSearchParams["PassportNum"]);

            database.AddInParameter(commandWrapper, "@MotherID", DbType.String, studSearchParams["MotherID"]);//added by walaa 3/1/2022

            
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("AsFacultyInfoId");
            table.Columns.Add("StudFacultyCode");
            table.Columns.Add("EdStudId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("GsCodeGenderId");
            table.Columns.Add("AccumCh");
            table.Columns.Add("AccumGpa");
            table.Columns.Add("DescrAr");
            table.Columns.Add("DescrEn");
            table.Columns.Add("NationDescrAr");
            table.Columns.Add("NationDescrEn");
            table.Columns.Add("OrientFlag");
            table.Columns.Add("GsCountryInfoId1");
            table.Columns.Add("MajorAr");
            table.Columns.Add("MajorEn");
            table.Columns.Add("MainorAr");
            table.Columns.Add("MainorEn");
            table.Columns.Add("FREEZE_FLG");
            table.Columns.Add("RemainCh");
            table.Columns.Add("SemCh");
            table.Columns.Add("PassedChNotAddGPA");
            table.Columns.Add("Mother_ID"); //added by walaa task 17617
       
            table.Columns.Add("RowsTotCount");
           
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(),
                                     reader[21].ToString(), reader[22].ToString(),  reader[23].ToString(),reader[24].ToString()};
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


        public override TList<EdStud> GetFilteredStudentsList_New(TransactionManager transactionManager, Hashtable studSearchParams)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_StudFilter_New", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, studSearchParams["_asFacultyInfoId"]);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, studSearchParams["_EdAcadYearId"]);
            database.AddInParameter(commandWrapper, "@EdAdmAcadYearId", DbType.Decimal, studSearchParams["EdAdmAcadYearId"]);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, studSearchParams["_EdCodeSemesterId"]);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, studSearchParams["_EntityMainId"]);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, studSearchParams["_GsCodeGenderId"]);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, studSearchParams["_GsCountryInfoId"]);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, studSearchParams["StudName"]);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, studSearchParams["StudCode"]);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, studSearchParams["NationalNum"]);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, studSearchParams["_LangNum"]);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, studSearchParams["_NamePolicy"]);

            database.AddInParameter(commandWrapper, "@DegreeClassId", DbType.Decimal, studSearchParams["_DegreeClass"]);
            database.AddInParameter(commandWrapper, "@CodeDegreeId", DbType.Decimal, studSearchParams["_CodeDegree"]);
            database.AddInParameter(commandWrapper, "@GPAFrom", DbType.Decimal, studSearchParams["_GPAFrom"]);
            database.AddInParameter(commandWrapper, "@GPATo", DbType.Decimal, studSearchParams["_GPATo"]);
            database.AddInParameter(commandWrapper, "@CHFrom", DbType.Decimal, studSearchParams["_CHFrom"]);
            database.AddInParameter(commandWrapper, "@CHTo", DbType.Decimal, studSearchParams["_CHTo"]);
            database.AddInParameter(commandWrapper, "@EdcdeAcadWarnId", DbType.Decimal, studSearchParams["EdcdeAcadWarnId"]);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, studSearchParams["EdCodeLevelId"]);
            database.AddInParameter(commandWrapper, "@GovernorateId", DbType.Decimal, studSearchParams["GovernorateId"]);
            // database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, studSearchParams["EdCodeCourseId"]);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, studSearchParams["EdCourseId"]);
            database.AddInParameter(commandWrapper, "@SectionId", DbType.Decimal, studSearchParams["SectionId"]);
            database.AddInParameter(commandWrapper, "@AcadAdvisorId", DbType.Decimal, studSearchParams["AcadAdvisorId"]);
            database.AddInParameter(commandWrapper, "@EdCodeLoadTypeId", DbType.Decimal, studSearchParams["EdCodeLoadTypeId"]);
            database.AddInParameter(commandWrapper, "@OrientationFlag", DbType.Decimal, studSearchParams["OrientationFlag"]);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollTypeId", DbType.Decimal, studSearchParams["EdCodeEnrollTypeId"]);
            database.AddInParameter(commandWrapper, "@SpoSponsorId", DbType.Decimal, studSearchParams["SpoSponsorId"]);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, studSearchParams["SaStfMemberId"]);
            database.AddInParameter(commandWrapper, "@EntMainMinorId", DbType.Decimal, studSearchParams["EntMainMinorId"]);
            database.AddInParameter(commandWrapper, "@GraduatesFlag", DbType.Decimal, studSearchParams["GraduatesFlag"]);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, decimal.Parse(studSearchParams["PageIndex"].ToString()));
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, decimal.Parse(studSearchParams["PageSize"].ToString()));
            database.AddInParameter(commandWrapper, "@AllowSort", DbType.Decimal, decimal.Parse(studSearchParams["AllowSort"].ToString()));
            database.AddInParameter(commandWrapper, "@SortColumn", DbType.Decimal, decimal.Parse(studSearchParams["SortColumn"].ToString()));
            database.AddInParameter(commandWrapper, "@SortDirection", DbType.Decimal, decimal.Parse(studSearchParams["SortDirection"].ToString()));

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFilter", rows));

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
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }


        public override TList<EdStud> StudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
         , System.Decimal? _EdCodeLevelId, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeCourseId,
            decimal asCodeDegreeId, decimal forgeinFlg, decimal? haveSponsor, decimal? nationalitySimilarityFlg,
          int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStudData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, _EdCodeCourseId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId);
            database.AddInParameter(commandWrapper, "@ForgeinFlag", DbType.Decimal, forgeinFlg);
            database.AddInParameter(commandWrapper, "@HaveSponsor", DbType.Decimal, haveSponsor.HasValue ? (object)haveSponsor.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@NATIONALITY_SIMILARITY_FLG", DbType.Decimal, nationalitySimilarityFlg.HasValue ? (object)nationalitySimilarityFlg.Value : DBNull.Value);


            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFilter", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override TList<EdStud> StudFilter2(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
      , System.Decimal? _EdCodeLevelId, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
         string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeCourseId,
         decimal asCodeDegreeId, decimal? nationalitySimilarityFlg, decimal? _AdmissionYearId
      , int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStudData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, _EdCodeCourseId);
            database.AddInParameter(commandWrapper, "@AdmissionYearId", DbType.Decimal, _AdmissionYearId);

            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId);

            database.AddInParameter(commandWrapper, "@NATIONALITY_SIMILARITY_FLG", DbType.Decimal, nationalitySimilarityFlg.HasValue ? (object)nationalitySimilarityFlg.Value : DBNull.Value);


            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFilter", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EdStud> StudFilter3(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _EntityMainId, System.Decimal? _EdCodeLevelId,
              string StudName, string StudCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStud3", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "FilterStud3", rows));

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
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "FilterStud3", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override TList<EdStud> StudFilterLast(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
         , System.Decimal? _EdCodeLevelId, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
            string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeCourseId,
            decimal asCodeDegreeId, decimal forgeinFlg, decimal? haveSponsor, decimal? nationalitySimilarityFlg, System.String _Codefrom, System.String _Codeto, decimal _EnrollType
         , int start, int pageLength, out int count, int? StudentType = null, string FEE_STUD_FEE_ITEMIDS = "", decimal? IS_NODE_LOCAL = null, decimal? AdmYearId = null, decimal? AdmSemesterId=null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_FilterStudDataLast", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@Codefrom", DbType.String, _Codefrom);
            database.AddInParameter(commandWrapper, "@Codeto", DbType.String, _Codeto);


            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, _EdCodeCourseId);

            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId);
            database.AddInParameter(commandWrapper, "@ForgeinFlag", DbType.Decimal, forgeinFlg);
            database.AddInParameter(commandWrapper, "@HaveSponsor", DbType.Decimal, haveSponsor.HasValue ? (object)haveSponsor.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@NATIONALITY_SIMILARITY_FLG", DbType.Decimal, nationalitySimilarityFlg.HasValue ? (object)nationalitySimilarityFlg.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EnrollType", DbType.Decimal, _EnrollType);
            if (StudentType != null)
                database.AddInParameter(commandWrapper, "@StudentType", DbType.Int32, StudentType);
            if (FEE_STUD_FEE_ITEMIDS != "")
                database.AddInParameter(commandWrapper, "@FEE_STUD_FEE_ITEMIDS", DbType.String, FEE_STUD_FEE_ITEMIDS);
            if (IS_NODE_LOCAL != null)
                database.AddInParameter(commandWrapper, "@IS_NODE_LOCAL", DbType.String, IS_NODE_LOCAL);
            if (AdmYearId != null)
                database.AddInParameter(commandWrapper, "@AdmYearId", DbType.String, AdmYearId);
            if (AdmSemesterId != null)
                database.AddInParameter(commandWrapper, "@AdmSemesterId", DbType.String, AdmSemesterId);
            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFilter", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EdStud> StudFilter_Prefrence(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
      , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
      string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStudData_Prefrence", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFilter", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EdStud> StudFilter_Qual(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
    , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
    string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.Decimal _EdCodeQualId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStudData_Qual", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            database.AddInParameter(commandWrapper, "@EdCodeQualId", DbType.Decimal, _EdCodeQualId);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFilter", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EdStud> StudFilter_Pagging(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
       , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
       string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStudDataPagging", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, start);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageLength);

            DataSet reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFilter", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteDataSet(database, commandWrapper);
                }

                //Create Collection
                Fill_ByDataSet(reader, rows);

                count = int.Parse(reader.Tables[1].Rows[0][0].ToString());
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilter", rows));
            }
            finally
            {
                commandWrapper = null;
            }
            return rows;
        }

        public static TList<EdStud> Fill_ByDataSet(DataSet reader, TList<EdStud> rows)
        {
            NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
            Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;

            //// advance to the starting row
            //for (int i = 0; i < start; i++)
            //{
            //    if (!reader.Read())
            //        return rows; // not enough rows, just return
            //}
            for (int i = 0; i < reader.Tables[0].Rows.Count; i++)
            {
                //if (!reader.Read())
                //    break; // we are done

                string key = null;

                UMIS_VER2.BusinessLyer.EdStud c = null;
                if (useEntityFactory)
                {
                    key = new System.Text.StringBuilder("EdStud")
                    .Append("|").Append((System.Decimal)reader.Tables[0].Rows[i]["ED_STUD_ID"]).ToString();
                    c = EntityManager.LocateOrCreate<EdStud>(
                    key.ToString(), // EntityTrackingKey
                    "EdStud",  //Creational Type
                    entityCreationFactoryType,  //Factory used to create entity
                    enableEntityTracking); // Track this entity?
                }
                else
                {
                    c = new UMIS_VER2.BusinessLyer.EdStud();
                }

                if (!enableEntityTracking ||
                    c.EntityState == EntityState.Added ||
                    (enableEntityTracking &&

                        (
                            (currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
                            (currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
                        )
                    ))
                {
                    c.SuppressEntityEvents = true;
                    c.EdStudId = (System.Decimal)reader.Tables[0].Rows[i]["ED_STUD_ID"];
                    c.OriginalEdStudId = c.EdStudId;
                    c.NationalNumber = Convert.IsDBNull(reader.Tables[0].Rows[i]["NATIONAL_NUMBER"]) ? null : (System.String)reader.Tables[0].Rows[i]["NATIONAL_NUMBER"];
                    c.FullNameAr = (System.String)reader.Tables[0].Rows[i]["FULL_NAME_AR"];
                    c.ClFullNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["CL_FULL_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["CL_FULL_NAME_AR"];
                    c.StudNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["STUD_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["STUD_NAME_AR"];
                    c.ClStudNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["CL_STUD_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["CL_STUD_NAME_AR"];
                    c.FatherNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["FATHER_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["FATHER_NAME_AR"];
                    c.ClFatherNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["CL_FATHER_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["CL_FATHER_NAME_AR"];
                    c.GrandfatherNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["GRANDFATHER_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["GRANDFATHER_NAME_AR"];
                    c.ClGrandfatherNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["CL_GRANDFATHER_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["CL_GRANDFATHER_NAME_AR"];
                    c.FamilyNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["FAMILY_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["FAMILY_NAME_AR"];
                    c.ClFamilyNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["CL_FAMILY_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["CL_FAMILY_NAME_AR"];
                    c.FullNameEn = (System.String)reader.Tables[0].Rows[i]["FULL_NAME_EN"];
                    c.StudNameEn = Convert.IsDBNull(reader.Tables[0].Rows[i]["STUD_NAME_EN"]) ? null : (System.String)reader.Tables[0].Rows[i]["STUD_NAME_EN"];
                    c.FatherNameEn = Convert.IsDBNull(reader.Tables[0].Rows[i]["FATHER_NAME_EN"]) ? null : (System.String)reader.Tables[0].Rows[i]["FATHER_NAME_EN"];
                    c.GrandfatherNameEn = Convert.IsDBNull(reader.Tables[0].Rows[i]["GRANDFATHER_NAME_EN"]) ? null : (System.String)reader.Tables[0].Rows[i]["GRANDFATHER_NAME_EN"];
                    c.FamilyNameEn = Convert.IsDBNull(reader.Tables[0].Rows[i]["FAMILY_NAME_EN"]) ? null : (System.String)reader.Tables[0].Rows[i]["FAMILY_NAME_EN"];
                    c.FatherProfession = Convert.IsDBNull(reader.Tables[0].Rows[i]["FATHER_PROFESSION"]) ? null : (System.String)reader.Tables[0].Rows[i]["FATHER_PROFESSION"];
                    c.FatherNationalNumber = Convert.IsDBNull(reader.Tables[0].Rows[i]["FATHER_NATIONAL_NUMBER"]) ? null : (System.String)reader.Tables[0].Rows[i]["FATHER_NATIONAL_NUMBER"];
                    c.MotherNationalNumber = Convert.IsDBNull(reader.Tables[0].Rows[i]["MOTHER_NATIONAL_NUMBER"]) ? null : (System.String)reader.Tables[0].Rows[i]["MOTHER_NATIONAL_NUMBER"];
                    c.MotherNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["MOTHER_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["MOTHER_NAME_AR"];
                    c.ClMotherNameAr = Convert.IsDBNull(reader.Tables[0].Rows[i]["CL_MOTHER_NAME_AR"]) ? null : (System.String)reader.Tables[0].Rows[i]["CL_MOTHER_NAME_AR"];
                    c.MotherNameEn = Convert.IsDBNull(reader.Tables[0].Rows[i]["MOTHER_NAME_EN"]) ? null : (System.String)reader.Tables[0].Rows[i]["MOTHER_NAME_EN"];
                    c.GsCodeGenderId = Convert.IsDBNull(reader.Tables[0].Rows[i]["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader.Tables[0].Rows[i]["GS_CODE_GENDER_ID"];
                    c.GsCodeReligionId = Convert.IsDBNull(reader.Tables[0].Rows[i]["GS_CODE_RELIGION_ID"]) ? null : (System.Decimal?)reader.Tables[0].Rows[i]["GS_CODE_RELIGION_ID"];
                    c.BirthRegNumber = Convert.IsDBNull(reader.Tables[0].Rows[i]["BIRTH_REG_NUMBER"]) ? null : (System.String)reader.Tables[0].Rows[i]["BIRTH_REG_NUMBER"];
                    c.BirthDate = Convert.IsDBNull(reader.Tables[0].Rows[i]["BIRTH_DATE"]) ? null : (System.DateTime?)reader.Tables[0].Rows[i]["BIRTH_DATE"];
                    c.GsBirthCountryNodeId = Convert.IsDBNull(reader.Tables[0].Rows[i]["GS_BIRTH_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader.Tables[0].Rows[i]["GS_BIRTH_COUNTRY_NODE_ID"];
                    c.GsCountryInfoId1 = Convert.IsDBNull(reader.Tables[0].Rows[i]["GS_COUNTRY_INFO_ID_1"]) ? null : (System.Decimal?)reader.Tables[0].Rows[i]["GS_COUNTRY_INFO_ID_1"];
                    c.GsCountryInfoId2 = Convert.IsDBNull(reader.Tables[0].Rows[i]["GS_COUNTRY_INFO_ID_2"]) ? null : (System.Decimal?)reader.Tables[0].Rows[i]["GS_COUNTRY_INFO_ID_2"];
                    c.StudPhoto = Convert.IsDBNull(reader.Tables[0].Rows[i]["STUD_PHOTO"]) ? null : (System.String)reader.Tables[0].Rows[i]["STUD_PHOTO"];
                    c.GsCodeIdentTypeId = Convert.IsDBNull(reader.Tables[0].Rows[i]["GS_CODE_IDENT_TYPE_ID"]) ? null : (System.Decimal?)reader.Tables[0].Rows[i]["GS_CODE_IDENT_TYPE_ID"];
                    c.IsPrntStaff = Convert.IsDBNull(reader.Tables[0].Rows[i]["IS_PRNT_STAFF"]) ? null : (System.Decimal?)reader.Tables[0].Rows[i]["IS_PRNT_STAFF"];
                    c.SaStfMemberPrntId = Convert.IsDBNull(reader.Tables[0].Rows[i]["SA_STF_MEMBER_PRNT_ID"]) ? null : (System.Decimal?)reader.Tables[0].Rows[i]["SA_STF_MEMBER_PRNT_ID"];
                    c.EntityTrackingKey = key;
                    c.AcceptChanges();
                    c.SuppressEntityEvents = false;
                }
                rows.Add(c);
            }
            return rows;
        }

        // Graduated Student
        public override TList<EdStud> GraduatedStudFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId, string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterGraduatedStudData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GraduatedStudFilter", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GraduatedStudFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        //


        public override TList<EdStud> StudFeeDiscountFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
    , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
    string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy, System.DateTime? _ReqStartDate, System.DateTime? _ReqEndDate, System.Decimal? _FeeDiscEdAcadYearId, System.Decimal? _GsCodeReqStatusId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudFeeDiscountFilter", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);


            database.AddInParameter(commandWrapper, "@StartDate", DbType.DateTime, _ReqStartDate);
            database.AddInParameter(commandWrapper, "@EndDate", DbType.String, _ReqEndDate);
            database.AddInParameter(commandWrapper, "@FeeDiscEdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@GsCodeReqStatusId", DbType.Decimal, _GsCodeReqStatusId);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFeeDiscountFilter", rows));

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
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFeeDiscountFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }


        public override DataTable StudFeeDiscountFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId, string StudName, string StudCode, string NationalNum
            , System.Decimal _LangNum, System.Decimal _NamePolicy, System.DateTime? _ReqStartDate, System.DateTime? _ReqEndDate, System.Decimal? _FeeDiscEdAcadYearId, System.Decimal? _GsCodeReqStatusId,
            System.Decimal? _FeeCdeDiscTypeId, Decimal? _CodeDegreeTypeID, Decimal? _SeUserID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudFeeDiscountFilter2", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);


            database.AddInParameter(commandWrapper, "@StartDate", DbType.DateTime, _ReqStartDate);
            database.AddInParameter(commandWrapper, "@EndDate", DbType.DateTime, _ReqEndDate);
            database.AddInParameter(commandWrapper, "@FeeDiscEdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@GsCodeReqStatusId", DbType.Decimal, _GsCodeReqStatusId);
            database.AddInParameter(commandWrapper, "@FeeCdeDiscTypeId", DbType.Decimal, _FeeCdeDiscTypeId);
            database.AddInParameter(commandWrapper, "@CodeDegreeTypeID", DbType.Decimal, _CodeDegreeTypeID);
            database.AddInParameter(commandWrapper, "@SeUserID", DbType.Decimal, _SeUserID);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FEE_STUD_DISC_ID");
            table.Columns.Add("DISC_REQ_DATE");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("DISC_PERCENT");
            table.Columns.Add("STOP_FLG");
            table.Columns.Add("UPDATED_PERCENT");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("DISC_TYPE_DESCR_AR");
            table.Columns.Add("DISC_TYPE_DESCR_EN");
            table.Columns.Add("REQ_STATUS_DESCR_AR");
            table.Columns.Add("REQ_STATUS_DESCR_EN");
            table.Columns.Add("ACAD_YEAR_DESCR_AR");
            table.Columns.Add("ACAD_YEAR_DESCR_EN");
            table.Columns.Add("DISC_AMNT");
            //added by manar abdelhafez Task No 12129
            table.Columns.Add("LAST_UPDATED");
            table.Columns.Add("USER_NAME_EN");
            table.Columns.Add("USER_NAME_AR");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString() };
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


        public override EdStud GetByEdStudIdOnly(TransactionManager transactionManager, System.Decimal _edStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GetByEdStudIdOnly", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _edStudId);

            IDataReader reader = null;
            TList<EdStud> tmp = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEdStudIdOnly", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdStudIdOnly", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (tmp.Count == 1)
            {
                return tmp[0];
            }
            else if (tmp.Count == 0)
            {
                return null;
            }
            else
            {
                throw new DataException("Cannot find the unique instance of the class.");
            }

            //return rows;
        }


        public override void DeleteAllStudRelatedRecords(TransactionManager transactionManager, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.DeleteAllStudRelatedRecords", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "DeleteAllStudRelatedRecords"));

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
            OnDataRequested(new CommandEventArgs(commandWrapper, "DeleteAllStudRelatedRecords"));

            commandWrapper = null;
        }//end Delete

        public override DataTable HaveOtherFeeToStud(string _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, string FEE_CODE_ITEM_IDs)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.HaveOtherFeeToStud", this.UseStoredProcedure);


            database.AddInParameter(commandWrapper, "@EdStudId", DbType.String, _EdStudId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@FEE_CODE_ITEM_IDs", DbType.String, FEE_CODE_ITEM_IDs);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "HaveOtherFeeToStud"));
            DataTable dt = new DataTable();

            dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];

            commandWrapper = null;

            return dt;




        }
        public override void LoadOtherFeeToStud(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _FeeFacultyItemId, System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsCodeCurrency, System.Decimal _FeeITemValue, Decimal userId, decimal FormID, string notes = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadOtherFeeToStud", this.UseStoredProcedure);


            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@FeeFacultyItemId", DbType.Decimal, _FeeFacultyItemId);
            database.AddInParameter(commandWrapper, "@GsCodeCurrency", DbType.Decimal, _GsCodeCurrency);
            database.AddInParameter(commandWrapper, "@FeeITemValue", DbType.Decimal, _FeeITemValue);

            database.AddInParameter(commandWrapper, "@userid", DbType.Decimal, userId);//added by mmq at 31-10-2016

            database.AddInParameter(commandWrapper, "@FormID", DbType.Decimal, FormID);//added by khaled 17-12-2018
            if (notes != null)
                database.AddInParameter(commandWrapper, "@Notes", DbType.String, notes);
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "LoadOtherFeeToStud"));

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
            OnDataRequested(new CommandEventArgs(commandWrapper, "LoadOtherFeeToStud"));

            commandWrapper = null;
        }//end Delete


        public override void UnLoadOtherFeeToStud(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _FeeFacultyItemId, System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsCodeCurrency, System.Decimal _UserId, decimal FormID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UnLoadOtherFeeToStud", this.UseStoredProcedure);


            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@FeeFacultyItemId", DbType.Decimal, _FeeFacultyItemId);
            database.AddInParameter(commandWrapper, "@GsCodeCurrency", DbType.Decimal, _GsCodeCurrency);
            database.AddInParameter(commandWrapper, "@userid", DbType.Decimal, _UserId);//added by mmq at 23-11-2016
            database.AddInParameter(commandWrapper, "@FormID", DbType.Decimal, FormID);//added by khaled 17-12-2018

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "UnLoadOtherFeeToStud"));

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
            OnDataRequested(new CommandEventArgs(commandWrapper, "UnLoadOtherFeeToStud"));

            commandWrapper = null;
        }//end Delete

        public override TList<EdStud> GetStudHaveCourses(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, int? CourseID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudHaveCourses", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "Stf_MemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "Ed_Acad_YearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "Ed_SemesterId", DbType.Decimal, _EdCodeSemesterId);
            if (CourseID != null)
                database.AddInParameter(commandWrapper, "CourseID", DbType.Decimal, CourseID);
            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudHaveCourses", rows));

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
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudHaveCourses", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EdStud> StaffSearchStuds(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _LangId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudFullName, System.Decimal? _MaxGPA, System.Decimal? _MinGPA, System.Decimal? _EntMainId
            , System.Decimal? _EdRegisterCourseId, System.String _RegCourseCode, System.Decimal? _AbsCourseId, System.Decimal? _CourseTeachId, System.DateTime? _AbsDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StaffSearchStuds", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _LangId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, (_StudFullName == "" ? null : _StudFullName));
            database.AddInParameter(commandWrapper, "@MinGPA", DbType.Decimal, _MinGPA);
            database.AddInParameter(commandWrapper, "@MaxGPA", DbType.Decimal, _MaxGPA);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);

            database.AddInParameter(commandWrapper, "@EdRegisterCourseId", DbType.Decimal, _EdRegisterCourseId);
            database.AddInParameter(commandWrapper, "@RegCourseCode", DbType.String, (_RegCourseCode == "" ? null : _RegCourseCode));
            if (_AbsCourseId == 0)
                database.AddInParameter(commandWrapper, "@EdAbsCourseId", DbType.Decimal, System.DBNull.Value);
            else
                database.AddInParameter(commandWrapper, "@EdAbsCourseId", DbType.Decimal, _AbsCourseId);
            if (_CourseTeachId == 0)
                database.AddInParameter(commandWrapper, "@CourseTeachId", DbType.Decimal, System.DBNull.Value);
            else
                database.AddInParameter(commandWrapper, "@CourseTeachId", DbType.Decimal, _CourseTeachId);
            if (_AbsDate == DateTime.Parse("1/1/1700"))
                database.AddInParameter(commandWrapper, "@AbsenceDate", DbType.DateTime, System.DBNull.Value);
            else
                database.AddInParameter(commandWrapper, "@AbsenceDate", DbType.DateTime, _AbsDate);

            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StaffSearchStuds", rows));

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
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "StaffSearchStuds", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }


        public override TList<EdStud> SearchAllStuds(TransactionManager transactionManager, System.Decimal _LangId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudFullName, System.Decimal? _MaxGPA, System.Decimal? _MinGPA, System.Decimal? _EntMainId
    , System.Decimal? _EdRegisterCourseId, System.String _RegCourseCode, System.Decimal? _AbsCourseId, System.Decimal? _CourseTeachId, System.DateTime? _AbsDate
            , System.Decimal AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchAllStuds", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _LangId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, (_StudFullName == "" ? null : _StudFullName));
            database.AddInParameter(commandWrapper, "@MinGPA", DbType.Decimal, _MinGPA);
            database.AddInParameter(commandWrapper, "@MaxGPA", DbType.Decimal, _MaxGPA);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);

            database.AddInParameter(commandWrapper, "@EdRegisterCourseId", DbType.Decimal, _EdRegisterCourseId);
            database.AddInParameter(commandWrapper, "@RegCourseCode", DbType.String, (_RegCourseCode == "" ? null : _RegCourseCode));
            if (_AbsCourseId == 0)
                database.AddInParameter(commandWrapper, "@EdAbsCourseId", DbType.Decimal, System.DBNull.Value);
            else
                database.AddInParameter(commandWrapper, "@EdAbsCourseId", DbType.Decimal, _AbsCourseId);
            if (_CourseTeachId == 0)
                database.AddInParameter(commandWrapper, "@CourseTeachId", DbType.Decimal, System.DBNull.Value);
            else
                database.AddInParameter(commandWrapper, "@CourseTeachId", DbType.Decimal, _CourseTeachId);
            if (_AbsDate == DateTime.Parse("1/1/1700"))
                database.AddInParameter(commandWrapper, "@AbsenceDate", DbType.DateTime, System.DBNull.Value);
            else
                database.AddInParameter(commandWrapper, "@AbsenceDate", DbType.DateTime, _AbsDate);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SearchAllStuds", rows));

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
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "SearchAllStuds", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }


        public override DataTable GetGeneralAbsentStudents(TransactionManager transactionManager, System.Decimal _ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetGeneralAbsentStuds", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _ScScheduleDtlId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudCode");
            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("EdStudId");
            table.Columns.Add("EdStudAbsenceId");
            table.Columns.Add("AbsenceFlag");
            table.Columns.Add("ExcuseFlag");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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



        public override DataTable GetStudentPaymentStatusPerSemester(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadId, System.Decimal _edSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentPaymentStatus", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _edStudId);
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, _edAcadId);
            database.AddInParameter(commandWrapper, "@SemesterId", DbType.Decimal, _edSemesterId);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("paymentStatus");

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



        public override DataTable GetGeneralAbsentStudents(TransactionManager transactionManager, System.Decimal _ScScheduleDtlId, System.Decimal _ScTchngSlotId, System.Decimal _EdCourseId, System.DateTime _AbsDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetDetailedAbsentStuds", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlDayId", DbType.Decimal, _ScTchngSlotId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            if (_AbsDate != null)
                database.AddInParameter(commandWrapper, "@AbsDate", DbType.DateTime, _AbsDate);
            else
                database.AddInParameter(commandWrapper, "@AbsDate", DbType.DateTime, System.DBNull.Value);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudCode");
            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("EdStudId");
            table.Columns.Add("EdStudAbsenceId");
            table.Columns.Add("AbsenceFlag");
            table.Columns.Add("ExcuseFlag");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

        public override DataTable GetGeneralAbsentStudents(TransactionManager transactionManager, System.Decimal _ScScheduleDtlId, System.DateTime _FromTime, System.DateTime _ToTime, System.Decimal _EdCourseId, System.DateTime _AbsDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetDetailedAbsentStuds_FromToTime", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, _FromTime);
            database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, _ToTime);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            if (_AbsDate != null)
                database.AddInParameter(commandWrapper, "@AbsDate", DbType.DateTime, _AbsDate);
            else
                database.AddInParameter(commandWrapper, "@AbsDate", DbType.DateTime, System.DBNull.Value);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudCode");
            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("EdStudId");
            table.Columns.Add("EdStudAbsenceId");
            table.Columns.Add("AbsenceFlag");
            table.Columns.Add("ExcuseFlag");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

        public override DataTable GetGeneralExamAbsentStudents(TransactionManager transactionManager, System.Decimal _CourseId,
            System.Decimal courseAssessId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId,
            System.Decimal EdExamScheduleId, System.Decimal lang, System.Decimal AsFacultyInfoId,
            System.Decimal AbscentOnly, System.String StudCode,
            System.Decimal AsCodeDegreeClassId, string SortDirection, string ExamDate, Decimal? HallId = null , decimal ExamTypeID  = 1)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetExamAbsentStuds", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _CourseId);
            database.AddInParameter(commandWrapper, "@CourseAssessId", DbType.Decimal, courseAssessId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdExamScheduleId", DbType.Decimal, EdExamScheduleId);
            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, lang);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ABS_FLG", DbType.Decimal, AbscentOnly);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.String, AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@SortDirection", DbType.String, SortDirection);
            database.AddInParameter(commandWrapper, "@HallId", DbType.Decimal, HallId);
            database.AddInParameter(commandWrapper, "@ExamDate", DbType.String, ExamDate); //Angham 07042020  13312
            database.AddInParameter(commandWrapper, "@ExamTypeId", DbType.String, ExamTypeID); //maha 21-12-2020  task 15566

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("StudCode");

            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("EdStudId");
            table.Columns.Add("EdExamStudAbsenceId");
            table.Columns.Add("AbsenceFlag");

            table.Columns.Add("ExcuseFlag");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("Major_Ar");
            table.Columns.Add("Major_EN");

            table.Columns.Add("ED_STUD_COURSE_REG_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("ED_CODE_COURSE_ASSESS_ID");
            table.Columns.Add("ED_CDE_EXECUSE_RSN_ID");

            table.Columns.Add("NOTES");
            table.Columns.Add("IS_RESULT_APPROVED");
            table.Columns.Add("EXAM_APPROVE_FLG");
            table.Columns.Add("ASSESS_DEG");
            table.Columns.Add("SEM_WORK_FLG");

            table.Columns.Add("ED_CDE_EXAM_TYPE_ID");
            table.Columns.Add("SECRET_NUM");

            table.Columns.Add("Phone");  //Angham 06/04/2020 13312 
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                             reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), 
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(), 
                                             reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),
                                             reader[20].ToString(), reader[21].ToString(),reader[22].ToString(),reader[23].ToString(),reader[24].ToString(),reader[25].ToString()
                                         ,reader[26].ToString(),reader[27].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                             reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), 
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString() ,reader[15].ToString(),
                                             reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),
                                             reader[20].ToString(), reader[21].ToString(),reader[22].ToString(),reader[23].ToString(),reader[24].ToString(),reader[25].ToString()
                                         ,reader[26].ToString(),reader[27].ToString()};
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

        public override DataTable GetGeneralExamSheetingStudents(TransactionManager transactionManager, System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetExamCheateStuds", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoIdId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@EdStudCode", DbType.String, StudCode);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_STUD_CHEAT_id");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("Major_Ar");
            table.Columns.Add("Major_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                             reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                             reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString()  };
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


        public override DataTable GetGeneralExamSheetingStudentsMU(TransactionManager transactionManager, System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode,int ExameType)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetExamCheateStudsMU", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoIdId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@EdStudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@ExameType", DbType.Int32, ExameType);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_STUD_CHEAT_id");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("Major_Ar");
            table.Columns.Add("Major_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                             reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                             reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString()  };
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

        public override DataTable GetExamCheatReslut(TransactionManager transactionManager, System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetExamCheatReslut", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoIdId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@EdStudCode", DbType.String, StudCode);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("ED_STUD_CHEAT_EXEC_ID");
            table.Columns.Add("ED_CODE_CHEAT_RSLT_ID");
            table.Columns.Add("ResultID");
            table.Columns.Add("APPROVE_FLG");
            table.Columns.Add("CHEAT_RSLT_AR");
            table.Columns.Add("CHEAT_RSLT_EN");
            table.Columns.Add("NOTES");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_STUD_CHEAT_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ED_EXAM_SCHDL_ID");
            table.Columns.Add("ED_STUD_SEMESTER_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                             reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString(), reader[17].ToString(), reader[18].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                             reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString(),reader[17].ToString(), reader[18].ToString()  };
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
        //Added by manar abdelhafez 5587
        public override DataTable GetExamCheatReslutMU(TransactionManager transactionManager, System.Decimal _AsFacultyInfoIdId, System.Decimal _EntMainId, System.Decimal _ScScheduleDtlId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal AsCodeDegreeClassId, string StudCode,int ExameType)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetExamCheatReslutMU", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoIdId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@EdStudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@ExameType", DbType.Int32, ExameType);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("ED_STUD_CHEAT_EXEC_ID");
            table.Columns.Add("ED_CODE_CHEAT_RSLT_ID");
            table.Columns.Add("ResultID");
            table.Columns.Add("APPROVE_FLG");
            table.Columns.Add("CHEAT_RSLT_AR");
            table.Columns.Add("CHEAT_RSLT_EN");
            table.Columns.Add("NOTES");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_STUD_CHEAT_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ED_EXAM_SCHDL_ID");
            table.Columns.Add("ED_STUD_SEMESTER_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                             reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString(), reader[17].ToString(), reader[18].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                             reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString(),reader[17].ToString(), reader[18].ToString()  };
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


        public override DataTable GetGeneralExamAbsentStudents(TransactionManager transactionManager, System.Decimal _EdCourseId, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _CoExamSchdlPlaceId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetExamAbsentStudsByPlace", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@CoExamSchdlPlaceId", DbType.Decimal, _CoExamSchdlPlaceId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudCode");
            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("EdStudId");
            table.Columns.Add("EdExamStudAbsenceId");
            table.Columns.Add("AbsenceFlag");
            table.Columns.Add("ExcuseFlag");


            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

        public override DataTable LoadFeesToStudent(TransactionManager transactionManager, System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsCodeDegreeId, System.Decimal _EdCodeLevelId, System.Decimal _ForgeinFlag)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadStudFees", this.UseStoredProcedure);

            string sUrl = ConfigurationManager.AppSettings["WebServicePath"];
            string sKey = ConfigurationManager.AppSettings["WebServiceKey"];

            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, _AsCodeDegreeId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@ForgeinFlag", DbType.Decimal, _ForgeinFlag);
            //database.AddInParameter(commandWrapper, "@SessionID", DbType.String, _SessionID);
            //database.AddInParameter(commandWrapper, "@sUrl", DbType.String, sUrl);
            //database.AddInParameter(commandWrapper, "@sKey", DbType.String, sKey);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("InValidReason");
            table.Columns.Add("SucessInserted");
            table.Columns.Add("FaildInserted");
            table.Columns.Add("TotalStudNo");
            table.Columns.Add("StudCode");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

        public override DataTable UnLoadFeesToStudent(TransactionManager transactionManager, System.Decimal _EntityMainId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsCodeDegreeId, System.Decimal _EdCodeLevelId, System.Decimal _ForgeinFlag)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UnLoadStudFees", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, _AsCodeDegreeId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@ForgeinFlag", DbType.Decimal, _ForgeinFlag);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("InValidReason");
            table.Columns.Add("SucessInserted");
            table.Columns.Add("FaildInserted");
            table.Columns.Add("TotalStudNo");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
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

        public override decimal InsertWithOutEdStudId(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStud entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_InsertWithIdOut", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudId", DbType.Decimal, 5);
            //database.AddInParameter(commandWrapper, "@StudCode", DbType.String, entity.StudCode);
            database.AddInParameter(commandWrapper, "@NationalNumber", DbType.String, entity.NationalNumber);
            database.AddInParameter(commandWrapper, "@FullNameAr", DbType.String, entity.FullNameAr);
            database.AddInParameter(commandWrapper, "@ClFullNameAr", DbType.String, entity.ClFullNameAr);
            database.AddInParameter(commandWrapper, "@StudNameAr", DbType.String, entity.StudNameAr);
            database.AddInParameter(commandWrapper, "@ClStudNameAr", DbType.String, entity.ClStudNameAr);
            database.AddInParameter(commandWrapper, "@FatherNameAr", DbType.String, entity.FatherNameAr);
            database.AddInParameter(commandWrapper, "@ClFatherNameAr", DbType.String, entity.ClFatherNameAr);
            database.AddInParameter(commandWrapper, "@GrandfatherNameAr", DbType.String, entity.GrandfatherNameAr);
            database.AddInParameter(commandWrapper, "@ClGrandfatherNameAr", DbType.String, entity.ClGrandfatherNameAr);
            database.AddInParameter(commandWrapper, "@FamilyNameAr", DbType.String, entity.FamilyNameAr);
            database.AddInParameter(commandWrapper, "@ClFamilyNameAr", DbType.String, entity.ClFamilyNameAr);
            database.AddInParameter(commandWrapper, "@FullNameEn", DbType.String, entity.FullNameEn);
            database.AddInParameter(commandWrapper, "@StudNameEn", DbType.String, entity.StudNameEn);
            database.AddInParameter(commandWrapper, "@FatherNameEn", DbType.String, entity.FatherNameEn);
            database.AddInParameter(commandWrapper, "@GrandfatherNameEn", DbType.String, entity.GrandfatherNameEn);
            database.AddInParameter(commandWrapper, "@FamilyNameEn", DbType.String, entity.FamilyNameEn);
            database.AddInParameter(commandWrapper, "@FatherProfession", DbType.String, entity.FatherProfession);
            database.AddInParameter(commandWrapper, "@FatherNationalNumber", DbType.String, entity.FatherNationalNumber);
            database.AddInParameter(commandWrapper, "@MotherNationalNumber", DbType.String, entity.MotherNationalNumber);
            database.AddInParameter(commandWrapper, "@MotherNameAr", DbType.String, entity.MotherNameAr);
            database.AddInParameter(commandWrapper, "@ClMotherNameAr", DbType.String, entity.ClMotherNameAr);
            database.AddInParameter(commandWrapper, "@MotherNameEn", DbType.String, entity.MotherNameEn);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object)entity.GsCodeGenderId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeReligionId", DbType.Decimal, (entity.GsCodeReligionId.HasValue ? (object)entity.GsCodeReligionId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@BirthRegNumber", DbType.String, entity.BirthRegNumber);
            database.AddInParameter(commandWrapper, "@BirthDate", DbType.DateTime, (entity.BirthDate.HasValue ? (object)entity.BirthDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsBirthCountryNodeId", DbType.Decimal, (entity.GsBirthCountryNodeId.HasValue ? (object)entity.GsBirthCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId1", DbType.Decimal, (entity.GsCountryInfoId1.HasValue ? (object)entity.GsCountryInfoId1 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId2", DbType.Decimal, (entity.GsCountryInfoId2.HasValue ? (object)entity.GsCountryInfoId2 : System.DBNull.Value));
            //database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, entity.AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@StudPhoto", DbType.String, entity.StudPhoto);
            database.AddInParameter(commandWrapper, "@IsPrntStaff", DbType.Decimal, (entity.IsPrntStaff.HasValue ? (object)entity.IsPrntStaff : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaStfMemberPrntId", DbType.Decimal, (entity.SaStfMemberPrntId.HasValue ? (object)entity.SaStfMemberPrntId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@STUD_WGHT", DbType.Decimal, (entity.StudWght.HasValue ? (object)entity.StudWght : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@STUD_LNHT", DbType.Decimal, (entity.StudLnht.HasValue ? (object)entity.StudLnht : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCdeBloodId", DbType.Decimal, (entity.GsCdeBloodId.HasValue ? (object)entity.GsCdeBloodId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IdentIssuePlc", DbType.String, entity.IdentIssuePlc);
            database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, (entity.GsCodeLanguageId.HasValue ? (object)entity.GsCodeLanguageId : System.DBNull.Value));

            //kamela, 12134
            database.AddInParameter(commandWrapper, "@IdentIssueDate", DbType.Date, (entity.IdentIssueDate.HasValue ? (object)entity.IdentIssueDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PassporIssueDate", DbType.Date, (entity.PassporIssueDate.HasValue ? (object)entity.PassporIssueDate : System.DBNull.Value));

            database.AddInParameter(commandWrapper, "@PassporNo", DbType.String, entity.PassporNo);
            database.AddInParameter(commandWrapper, "@PassporExpireDate", DbType.Date, (entity.PassporExpireDate.HasValue ? (object)entity.PassporExpireDate : System.DBNull.Value));

            //end
            //esraa yousef 16796 15-6-2021 
            database.AddInParameter(commandWrapper, "@GsCdeMaritalStatusId", DbType.Decimal, (entity.GsCdeMaritalStatusId.HasValue ? (object)entity.GsCdeMaritalStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@MarriageDate", DbType.Date, (entity.MarriageDate.HasValue ? (object)entity.MarriageDate : System.DBNull.Value));

            database.AddInParameter(commandWrapper, "@NoChild", DbType.Decimal, (entity.NoChild.HasValue ? (object)entity.NoChild : System.DBNull.Value));

//end 

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_STUD_InsertWithIdOut", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            entity.OriginalEdStudId = entity.EdStudId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "ED_STUD_InsertWithIdOut", entity));
            return Convert.ToDecimal(commandWrapper.Parameters["@EdStudId"].Value);
        }


        public override string GenerateStudCodewithoutUpdate(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _AsFacultyInfoId)
        {
            string Code = "";
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GenerateStudCodewithoutUpdate", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GenerateStudCodewithoutUpdate", rows));

                if (transactionManager != null)
                {
                    Code = Utility.ExecuteScalar(transactionManager, commandWrapper) as string;
                }
                else
                {
                    Code = Utility.ExecuteScalar(database, commandWrapper) as string;
                }


                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GenerateStudCodewithoutUpdate", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return Code;
        }



        public override string GenerateStudCode(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _AsFacultyInfoId)
        {
            string Code = "";
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GenerateStudCode", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GenerateStudCode", rows));

                if (transactionManager != null)
                {
                    Code = Utility.ExecuteScalar(transactionManager, commandWrapper) as string;
                }
                else
                {
                    Code = Utility.ExecuteScalar(database, commandWrapper) as string;
                }


                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GenerateStudCode", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return Code;
        }

        //public override TList<EdStud> AcademicAdvStudSearch(TransactionManager transactionManager, System.Decimal _LangId, System.String _StudFullName, System.Decimal? _EdCodeLevelId, System.Decimal? _EntityMain,
        //    System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _ScScheduleDtlId, System.Decimal _NamePolicy, string _studCode, System.Decimal EdCourseId, System.Decimal _EdAcadYearJoinId, int start, int pageLength, out int count)
        public override DataTable AcademicAdvStudSearch(TransactionManager transactionManager, System.Decimal _LangId, System.String _StudFullName, System.Decimal? _EdCodeLevelId, System.Decimal? _EntityMain,
          System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _ScScheduleDtlId, System.Decimal _NamePolicy, string _studCode, System.Decimal EdCourseId, System.Decimal _EdAcadYearJoinId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.AcademicAdvStudSearch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, string.IsNullOrEmpty(_StudFullName) ? "" : _StudFullName);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMain);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, _ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            database.AddInParameter(commandWrapper, "@studCode", DbType.String, _studCode);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EdAcadYearJoinId", DbType.Decimal, _EdAcadYearJoinId);

            IDataReader reader = null;

            DataTable table = new DataTable();
            table.Columns.Add("Ed_Stud_Id");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("Major_Ar");
            table.Columns.Add("Major_En");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            // TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                // OnDataRequesting(new CommandEventArgs(commandWrapper, "AcademicAdvStudSearch", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                //Fill(reader, rows, start, pageLength);
                //count = -1;
                //if (reader.NextResult())
                //{
                //    if (reader.Read())
                //    {
                //        count = reader.GetInt32(0);
                //    }
                //}
                ////Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "AcademicAdvStudSearch", rows));

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            count = table.Rows.Count;
            return table;
        }

        public override TList<EdStud> CourseChngStudSearch(TransactionManager transactionManager, System.Decimal _LangId, System.String _StudFullName, System.Decimal? _EdCodeLevelId, System.Decimal _EdCourseId, System.Decimal _CourseChngFlag, System.Decimal? _EntityMain,
            System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CourseChngStudSearch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, _StudFullName);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMain);
            database.AddInParameter(commandWrapper, "@CourseChngFlag", DbType.Decimal, _CourseChngFlag);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "CourseChngStudSearch", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "CourseChngStudSearch", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override DataTable GetForStaffEvaluationForStudent(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, int all)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetForStaffEvaluationForStudent", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@all", DbType.Decimal, all);
            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("SA_STF_MEMBER_ID");
            table.Columns.Add("STF_CODE");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("SV_STAFF_EVL_ID");
            table.Columns.Add("EVAL_TITLE");
            table.Columns.Add("WAIT_FLG");
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
        public override DataTable GetForStaffEvaluation(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_GET_STUD_STAFF_EVAL", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("SA_STF_MEMBER_ID");
            table.Columns.Add("STF_CODE");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("SV_STAFF_EVL_ID");
            table.Columns.Add("EVAL_TITLE");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

        public override DataTable GetRemainingEvaluations(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_RemainingEvaluations", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EVAL_TYPE");
            table.Columns.Add("SV_EVAL_ID");
            table.Columns.Add("EVAL_TYPE_ID");
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

        }

        public override DataTable StudentCoursesTimeTable(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudentCoursesTimeTable", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("GS_CODE_WEEK_DAY_ID");
            table.Columns.Add("SC_TCHNG_SLOT_ID");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_AR");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("SC_BUILDING_DESCR_AR");
            table.Columns.Add("SC_BUILDING_DESCR_EN");
            table.Columns.Add("SC_HALL_DESCR_AR");
            table.Columns.Add("SC_HALL_DESCR_EN");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString() };
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
        public override DataTable StudentEarlyCoursesTimeTable2(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudentEarlyCoursesTimeTable2", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GS_CODE_WEEK_DAY_ID");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("SC_BUILDING_DESCR_AR");
            table.Columns.Add("SC_BUILDING_DESCR_EN");
            table.Columns.Add("SC_HALL_DESCR_AR");
            table.Columns.Add("SC_HALL_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_AR");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("DAY_ORDER");
            table.Columns.Add("SYMBOL");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString() };
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
        public override DataTable StudentCoursesTimeTable2(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudentCoursesTimeTable2", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GS_CODE_WEEK_DAY_ID");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("SC_BUILDING_DESCR_AR");
            table.Columns.Add("SC_BUILDING_DESCR_EN");
            table.Columns.Add("SC_HALL_DESCR_AR");
            table.Columns.Add("SC_HALL_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_AR");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("DAY_ORDER");
            table.Columns.Add("SYMBOL");
            table.Columns.Add("FROM_DATE");
            table.Columns.Add("TO_DATE");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                             reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),
                                             reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(),
                                             reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(),
                                          reader[19].ToString(), reader[20].ToString()};
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
                                             reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(),
                                             reader[18].ToString(), reader[19].ToString(), reader[20].ToString() };
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
        public override DataTable StufCoursesTimeTable2(TransactionManager transactionManager, System.Decimal? _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStufMemberID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StufCoursesTimeTable2", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStufMemberID", DbType.Decimal, _SaStufMemberID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId.HasValue ? _AsFacultyInfoId : (Object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GS_CODE_WEEK_DAY_ID");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("SC_BUILDING_DESCR_AR");
            table.Columns.Add("SC_BUILDING_DESCR_EN");
            table.Columns.Add("SC_HALL_DESCR_AR");
            table.Columns.Add("SC_HALL_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_AR");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("DAY_ORDER");
            table.Columns.Add("SYMBOL");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString() };
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

        //added by mmq at 18-10-2016
        public override DataTable StudentCoursesSchedule(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseSchedule", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            DataTable table = new DataTable();

            try
            {
                table = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }
            finally
            {

                commandWrapper = null;
            }
            return table;

        }


        public override DataTable StudentCourses(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, System.Decimal _CheckSemesterApproval)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudentCourses", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@CheckSemesterApproval", DbType.Decimal, _CheckSemesterApproval); // Added by MElshazly 29/4/2021 [16625][Differentiates between pages that should check the value of ED_STUD_SEMESTER.RESULT_APPROVE_FLG and the pages that shouldn't.]

            //IDataReader reader = null;
            // DataTable table = new DataTable();
            //table.Columns.Add("ED_COURSE_ID");
            //table.Columns.Add("COURSE_DESCR_AR");
            //table.Columns.Add("COURSE_DESCR_EN");
            //table.Columns.Add("COURSE_CODE");
            //table.Columns.Add("ED_CODE_COURSE_STATUS_ID");
            //table.Columns.Add("CREDIT_HOURS");
            //table.Columns.Add("ED_STUD_COURSE_REG_ID");
            //table.Columns.Add("COURSE_STATUS_AR");
            //table.Columns.Add("COURSE_STATUS_EN");
            //table.Columns.Add("PAY_FLG");
            //table.Columns.Add("GRADING_DESCR_AR");
            //table.Columns.Add("GRADING_DESCR_EN");
            //table.Columns.Add("COURSE_POINT");
            //table.Columns.Add("GS_CODE_PASS_FAIL_ID");
            //table.Columns.Add("GROUP_DESCR_AR");
            //table.Columns.Add("GROUP_DESCR_EN");
            //table.Columns.Add("EVAL_DATE");

            DataTable table = new DataTable();

            try
            {
                table = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }
            finally
            {

                commandWrapper = null;
            }
            return table;
            //try
            //{
            //    if (transactionManager != null)
            //    {
            //        reader = Utility.ExecuteReader(transactionManager, commandWrapper);
            //        //read data
            //        while (reader.Read())
            //        {
            //            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString() };
            //            table.Rows.Add(items);
            //        }
            //    }
            //    else
            //    {
            //        reader = Utility.ExecuteReader(database, commandWrapper);
            //        //read data
            //        while (reader.Read())
            //        {
            //            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString() };
            //            table.Rows.Add(items);
            //        }
            //    }
            //}
            //finally
            //{
            //    if (reader != null)
            //        reader.Close();

            //    commandWrapper = null;
            //}
            //return table;

        }
        public override DataTable FeesStudentCourses(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Fees_StudentCourses", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);



            DataTable table = new DataTable();

            try
            {
                table = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }
            finally
            {

                commandWrapper = null;
            }
            return table;


        }
        public override DataTable StdCrsExmType(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, System.Decimal? ExamTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_StdCrsExmType", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCdeExamTypeId", DbType.Decimal, ExamTypeId);

            DataTable table = new DataTable();

            try
            {
                table = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }
            finally
            {

                commandWrapper = null;
            }
            return table;
        }

        public override DataTable GroupAllocation_StudentSearch(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelID, System.Decimal _EntMainID, System.Decimal _EdCourseID, System.Decimal _Lang, System.Decimal _NamePolicy, System.String _StudName, System.Decimal _EdCodeCourseTeachingId, decimal? MinorId, decimal? GenderId, decimal? ScheduleDtlId,
            string MotherID =null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GroupAllocation_StudentSearch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, _StudName);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelID);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainID);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseID);
            database.AddInParameter(commandWrapper, "@EdCodeCourseTeachingId", DbType.Decimal, _EdCodeCourseTeachingId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);

            database.AddInParameter(commandWrapper, "@MinorId", DbType.Decimal, @MinorId.HasValue ? MinorId : null);
            database.AddInParameter(commandWrapper, "@GenderId", DbType.Decimal, @GenderId.HasValue ? GenderId : null);
            database.AddInParameter(commandWrapper, "@ScheduleDtlId", DbType.Decimal, ScheduleDtlId.HasValue ? ScheduleDtlId : null);
         database.AddInParameter(commandWrapper, "@MotherID", DbType.String,MotherID); //added by esraa yousef 18786 22-6-2022 eue 

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("StudCode");
            table.Columns.Add("LevelDescrAr");
            table.Columns.Add("LevelDescrEn");
            table.Columns.Add("IsCourseApproved");
            table.Columns.Add("Mother_ID");//added by esraa yousef 18786 22-6-2022 eue 


            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),reader[7].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),reader[7].ToString() };
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
        /* --- modified by maha 21-12-2020 --- tas 15566 - add exam type id --*/
        public override DataTable ExamPlaceAllocation_StudentSearch(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId,
            System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelID, System.Decimal _EntMainID, System.Decimal _EdCourseID, System.Decimal _Lang,
            System.Decimal _NamePolicy, System.String _StudName, System.Decimal _CoExamSchdlPlaceId, System.String _StudCode, System.Decimal _SC_SCHEDULE_DTL_ID, 
            decimal? GenderId , System.Decimal _EdExamTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ExamPlaceAllocation_StudentSearch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, _StudName);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelID);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainID);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseID);
            database.AddInParameter(commandWrapper, "@CoExamSchdlPlaceId", DbType.Decimal, _CoExamSchdlPlaceId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@studCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_DTL_ID", DbType.Decimal, _SC_SCHEDULE_DTL_ID);

            //kamela, 12071, add gender to search in case sysparam 67 = 1 To get only studs 
            if (GenderId.HasValue)
                database.AddInParameter(commandWrapper, "@GenderId", DbType.Decimal, GenderId);
            //end
            database.AddInParameter(commandWrapper, "@EDEXAMTYPEID", DbType.Decimal, _EdExamTypeId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("StudCode");
            table.Columns.Add("LevelDescrAr");
            table.Columns.Add("LevelDescrEn");
            table.Columns.Add("IsCourseApproved");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

        public override DataTable StudentAvailableCoursesForEvaluation(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_AvailableCoursesForEvaluation", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");

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

        public override DataTable StudentCourseEvaluation(TransactionManager transactionManager, System.Decimal _EdCourseId, System.Decimal _EdStudID, decimal SvCourseEvalId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_CourseEvaluated", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@SvCourseEvalId", DbType.Decimal, SvCourseEvalId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_CODE_EVAL_ITEM_ID");
            table.Columns.Add("SV_CODE_RATING_SCHM_DTL_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
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

        public override DataTable StudentSummeryGradReq(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_SummeryGradReq", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("ENT_COURSE_PKG_HDR_TOT_CH");
            table.Columns.Add("FullFilledCreditHours");
            table.Columns.Add("CurrentRegisterdCreditHours");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
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

        public override DataTable StudentSummeryGradAudit(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal AsFacultyInfoID, System.Decimal AsCodeDegreeID, System.Decimal EntMainId, System.Decimal EdAcadYearId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_SummeryGradAudit", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeID", DbType.Decimal, AsCodeDegreeID);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EntMainID");
            table.Columns.Add("EntDescrAr");
            table.Columns.Add("EntDescrEn");
            table.Columns.Add("PkgDescrAr");
            table.Columns.Add("PkgHdrId");
            table.Columns.Add("PkgDescrEn");
            table.Columns.Add("PkgTotCh");
            table.Columns.Add("ChFulfilled");
            table.Columns.Add("PKG_TYPE_DESCRAR");
            table.Columns.Add("PKG_TYPE_DESCREn");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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

        public override DataTable StudentTranscript(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdStudID, System.Decimal AsCodeDegreeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_Transcript", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, AsCodeDegreeId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdAcadYearDescrAr");
            table.Columns.Add("EdAcadYearDescrEn");
            table.Columns.Add("EdCodeSemesterDescrAr");
            table.Columns.Add("EdCodeSemesterDescrEn");
            table.Columns.Add("EdCourseCode");
            table.Columns.Add("EdCourseDescrAr");
            table.Columns.Add("EdCourseDescrEn");
            table.Columns.Add("EdCourseCreditHours");
            table.Columns.Add("EdStudCourseRegDegree");
            table.Columns.Add("EdStudCourseRegPoint");
            table.Columns.Add("EdCodeGradingDescrAr");
            table.Columns.Add("EdCodeGradingDescrEn");
            table.Columns.Add("EdCodeCourseStatusId");
            table.Columns.Add("Symbol");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("SEM_GPA");
            table.Columns.Add("SEM_CH");
            table.Columns.Add("MAJOR_CGPA");
            table.Columns.Add("REPEAT_NO");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("LOAD_DESCR_AR");
            table.Columns.Add("LOAD_DESCR_EN");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString() };
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

        public override DataTable StudentCourseChangeTime(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _EdCodeSemActivityId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_CourseChangeTime", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@EdCodeSemActivityId", DbType.Decimal, _EdCodeSemActivityId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FROM_DATE");
            table.Columns.Add("TO_DATE");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
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

        public override DataTable GetNewSemesterStudentsData(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _ED_CODE_SEMESTER_ID, System.Decimal _ED_ACAD_YEAR_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GetNewSemesterStudentsData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, _ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, _ED_ACAD_YEAR_ID);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("ED_CODE_LEVEL_ID");
            table.Columns.Add("IS_LAST");
            table.Columns.Add("ED_CODE_LOAD_TYPE_ID");
            table.Columns.Add("ED_CODE_ENROLL_TYPE_ID");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("ACCUM_POINT");
            table.Columns.Add("IS_COURSE_APPROVED");
            table.Columns.Add("SEM_CH");
            table.Columns.Add("SEM_GPA");
            table.Columns.Add("SEM_POINT");
            table.Columns.Add("ED_SEMESTER_OPEN_ID");
            table.Columns.Add("ED_STUD_SEMESTER_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString() };
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

        public override DataTable GetNewLoadTypeID(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GetNewLoadTypeID", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ED_STUD_ID", DbType.Decimal, _EdStudId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_CODE_LOAD_TYPE_ID");

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

        public override DataTable GetStudDetails(TransactionManager transactionManager, System.Decimal _EdStudSemId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudDetails", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemId", DbType.Decimal, _EdStudSemId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("LevelDescrAr");
            table.Columns.Add("LevelDescrEn");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("StatesAr");
            table.Columns.Add("StatesEn");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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


        public override string ConvertChars(TransactionManager transactionManager, System.String _OriginalString)
        {
            string ReturnVal = "";
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CONVERT_CHARACTERS", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@OriginalString", DbType.String, _OriginalString);
            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "CONVERT_CHARACTERS", rows));

                if (transactionManager != null)
                {
                    ReturnVal = (string)Utility.ExecuteScalar(transactionManager, commandWrapper);
                }
                else
                {
                    ReturnVal = (string)Utility.ExecuteScalar(database, commandWrapper);
                }

                OnDataRequested(new CommandEventArgs(commandWrapper, "CONVERT_CHARACTERS", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return ReturnVal;
        }

        public override DataTable Notifications(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_Notifications", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("Kind");
            table.Columns.Add("EdStudId");
            table.Columns.Add("Value");
            table.Columns.Add("URL");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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

        public override TList<EdStud> StudFeeDiscFilter(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _EdStudId, System.Decimal? _FeeCodeDiscType,
            System.Decimal _GPALessThan, System.Decimal _LangNum)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStudFeeDisc", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@FeeCodeDiscType", DbType.Decimal, _FeeCodeDiscType);
            database.AddInParameter(commandWrapper, "@GPALessThan", DbType.String, _GPALessThan);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.String, _LangNum);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFeeDiscFilter", rows));

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
                int pageLength = int.MaxValue;
                int count;
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFeeDiscFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            if (rows.Count == 0)
                rows.Add(new EdStud());
            return rows;
        }

        public override DataTable StudFeeDiscFilter_New(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _EdStudId, System.Decimal? _FeeCodeDiscType,
            System.Decimal _GPALessThan, System.Decimal _LangNum, System.String _studName, System.String _studCode, System.Int32 _filter)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStudFeeDisc", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@FeeCodeDiscType", DbType.Decimal, _FeeCodeDiscType);
            database.AddInParameter(commandWrapper, "@GPALessThan", DbType.String, _GPALessThan);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.String, _LangNum);
            database.AddInParameter(commandWrapper, "@studName", DbType.String, _studName);
            database.AddInParameter(commandWrapper, "@studCode", DbType.String, _studCode);
            database.AddInParameter(commandWrapper, "@filter", DbType.Int32, _filter);
            IDataReader reader = null;

            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("StudCode");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("GsCountryInfoId1");
            table.Columns.Add("GsCountryInfoId2");
            table.Columns.Add("AsFacultyInfoId");
            table.Columns.Add("genderDescr");
            table.Columns.Add("DiscPrecent");
            table.Columns.Add("UpdatedPrecent");

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

                //Create Collection

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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


        public override TList<EdStud> StudFilterWithStudentType(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
          , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
          string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
            System.Decimal _StudentType, System.Decimal _CourseID, System.Decimal _CourseSubID, System.Decimal _RegisterInCourse, System.Decimal _IsCoursApproved, System.String _Codefrom, System.String _Codeto, System.Decimal _EdAcadYearJoinId
            //kamela,12917
            , System.Decimal? _MajorId
            , System.Decimal? _MinorId
            //end
            , decimal? _AsCodeDegreeClassID = 0 
            )
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudFilterWithStudentType", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdAcadYearJoinId", DbType.Decimal, _EdAcadYearJoinId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            database.AddInParameter(commandWrapper, "@StudentType", DbType.Decimal, _StudentType);
            database.AddInParameter(commandWrapper, "@CourseID", DbType.Decimal, _CourseID);
            database.AddInParameter(commandWrapper, "@CourseSubID", DbType.Decimal, _CourseSubID);
            database.AddInParameter(commandWrapper, "@RegisterInCourse", DbType.Decimal, _RegisterInCourse);
            database.AddInParameter(commandWrapper, "@IsCoursApproved", DbType.Decimal, _IsCoursApproved);
            database.AddInParameter(commandWrapper, "@Codefrom", DbType.String, _Codefrom);
            database.AddInParameter(commandWrapper, "@Codeto", DbType.String, _Codeto);

            //kamela,12917
            database.AddInParameter(commandWrapper, "@majorId", DbType.Decimal, _MajorId);
            database.AddInParameter(commandWrapper, "@minorId", DbType.Decimal, _MinorId);
            //end
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassID", DbType.Decimal, _AsCodeDegreeClassID);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFilterWithStudentType", rows));

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
                int pageLength = int.MaxValue;
                int count;
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilterWithStudentType", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            if (rows.Count == 0)
                rows.Add(new EdStud());
            return rows;
        }

        public override DataTable StudFilterWithStudentType2(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
  , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
  string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
    System.Decimal _StudentType, System.Decimal _CourseID, System.Decimal _CourseSubID, System.Decimal _RegisterInCourse, System.Decimal _IsCoursApproved)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudFilterWithStudentType", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            database.AddInParameter(commandWrapper, "@StudentType", DbType.Decimal, _StudentType);
            database.AddInParameter(commandWrapper, "@CourseID", DbType.Decimal, _CourseID);
            database.AddInParameter(commandWrapper, "@CourseSubID", DbType.Decimal, _CourseSubID);
            database.AddInParameter(commandWrapper, "@RegisterInCourse", DbType.Decimal, _RegisterInCourse);
            database.AddInParameter(commandWrapper, "@IsCoursApproved", DbType.Decimal, _IsCoursApproved);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudId");
            table.Columns.Add("StudCode");
            table.Columns.Add("NationalNumber");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("ClFullNameAr");
            table.Columns.Add("StudNameAr");
            table.Columns.Add("ClStudNameAr");
            table.Columns.Add("FatherNameAr");
            table.Columns.Add("ClFatherNameAr");
            table.Columns.Add("GrandfatherNameAr");
            table.Columns.Add("ClGrandfatherNameAr");
            table.Columns.Add("FamilyNameAr");
            table.Columns.Add("ClFamilyNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("StudNameEn");
            table.Columns.Add("FatherNameEn");
            table.Columns.Add("GrandfatherNameEn");
            table.Columns.Add("FamilyNameEn");
            table.Columns.Add("FatherProfrssion");
            table.Columns.Add("FatherNationalNumber");
            table.Columns.Add("MotherNationalNumber");
            table.Columns.Add("MotherNameAr");
            table.Columns.Add("ClMotherNameAr");
            table.Columns.Add("MotherNameEn");
            table.Columns.Add("GsCodeGenderId");
            table.Columns.Add("GsCodeReligionId");
            table.Columns.Add("BirthRegNumber");
            table.Columns.Add("BirthDate");
            table.Columns.Add("GsBirthCountryNodeId");
            table.Columns.Add("GsCountryInfoId1");
            table.Columns.Add("GsCountryInfoId2");
            table.Columns.Add("Temp");
            table.Columns.Add("StudPhoto");
            table.Columns.Add("GenderDescrAr");
            table.Columns.Add("ReligionDescrAr");
            table.Columns.Add("DescrAr");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString(), reader[24].ToString(), reader[25].ToString(), reader[26].ToString(), reader[27].ToString(), reader[28].ToString(), reader[29].ToString(), reader[30].ToString(), reader[31].ToString(), reader[32].ToString(), reader[33].ToString(), reader[34].ToString(), reader[35].ToString() };
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

        //added by dalia

        public override TList<EdStud> StudFilterforMailStud(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
      , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
      string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FilterStudDataForMails", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);
            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFilterforMailStud", rows));

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
                int pageLength = int.MaxValue;
                int count;
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilterforMailStud", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            if (rows.Count == 0)
                rows.Add(new EdStud());
            return rows;
        }




        public override TList<EdStud> StudFilterInAllEntityPath(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
       , System.Decimal? _CodeLevel, System.Decimal? _EntityMainId, System.Decimal _LangNum, System.Decimal _EdStudId, System.Decimal _ApproveRegister, System.String _StudCode, System.Decimal? _SaStfMemberId,
            decimal asCodeDegreeClassId, decimal? accumChFrom, decimal? accumChTo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudFilterInAllEntityPath", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _CodeLevel);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@ApproveRegister", DbType.Decimal, _ApproveRegister);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@AccumChFrom", DbType.Decimal, accumChFrom.HasValue ? (object)accumChFrom.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AccumChTo", DbType.Decimal, accumChTo.HasValue ? (object)accumChTo.Value : DBNull.Value);
            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudFilterInAllEntityPath", rows));

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
                int pageLength = int.MaxValue;
                int count;
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilterInAllEntityPath", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            if (rows.Count == 0)
                rows.Add(new EdStud());
            return rows;
        }

        public override DataTable StudFilterByAdvising(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _SaStfMemberId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudFilterByAdvising", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudAcadmicAdvId");
            table.Columns.Add("AsFacultyInfoId");
            table.Columns.Add("EdAcadYearId");
            table.Columns.Add("EdCodeSemesterId");
            table.Columns.Add("SaStfMemberId");
            table.Columns.Add("EdStudId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
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

                //Create Collection
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

        public override DataTable GetStudMinTimeSemesterAndLevel(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud_MinTimeSemesterAndLevel", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("MinTimeSemester");
            table.Columns.Add("MinTimeLevels");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
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
        public override DataTable GetStudNoOfMajorAndMinorDeclared(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud_NoOfMajorAndMinorDeclared", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("NoOfMajorDeclared");
            table.Columns.Add("NoOfMinorDeclared");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
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
        public override DataTable GetStudReqCourses(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud_ReqCourses", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");

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
        public override DataTable GetStudPassCourses(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud_PassCourses", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");

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
        public override DataTable GetStudEntityMains(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud_EntityMains", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");

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

        public override DataTable GetStudNullDegreeCourses(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, System.Decimal _EdStudStateID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud_NullDegreeCourses", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdStudStateId", DbType.Decimal, _EdStudStateID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");

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

        public override DataTable GetStudStatusIds(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud_StatusIds", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_STATE_ID");

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

        public override DataTable GetStudPassCourses(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud_PassCourses2", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");

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

        public override DataTable GetStudStateCourses(TransactionManager transactionManager, System.Decimal _EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud_StateCourses", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");

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

        public override DataTable GetStudStateTotCh(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud_StateTotCh", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_COURSE_PKG_HDR_ID");
            table.Columns.Add("MIN_TOT_CH");
            table.Columns.Add("STUD_TOT_CH");

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

        public override DataTable GetStud_CH_CGPA_ForEntity(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_CHandCGPAforEntityMain", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("CH");
            table.Columns.Add("CGPA");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
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

        public override DataTable GetUserDataForStudentView(TransactionManager transactionManager, System.Decimal _SeUserId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GetForStudentView", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, _SeUserId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SE_USER_ID");
            table.Columns.Add("Inbox");
            table.Columns.Add("Polls");

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

        public override DataTable GetResultSheetAssess(TransactionManager transactionManager, decimal edAcadYearID, decimal asFacultyInfoID, decimal edOpenSemesterID, decimal edCodeLevelID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GetResultSheetAssess", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, edAcadYearID);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, asFacultyInfoID);
            database.AddInParameter(commandWrapper, "@ED_SEMESTER_OPEN_ID", DbType.Decimal, edOpenSemesterID);
            database.AddInParameter(commandWrapper, "@ED_CODE_LEVEL_ID", DbType.Decimal, edCodeLevelID);

            DataTable table = new DataTable();
            try
            {
                if (transactionManager != null)
                {
                    table = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    table = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return table;
        }
        public override DataTable GetStudents(TransactionManager transactionManager, decimal edAcadYearID, decimal asFacultyInfoID, decimal edCodeSemesterId, decimal edCodeLevelID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GetStudents", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, edAcadYearID);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, asFacultyInfoID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ED_CODE_LEVEL_ID", DbType.Decimal, edCodeLevelID);

            DataTable table = new DataTable();
            try
            {
                if (transactionManager != null)
                {
                    table = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables.Count > 0 ? Utility.ExecuteDataSet(database, commandWrapper).Tables[0] : table;
                }
                else
                {
                    table = Utility.ExecuteDataSet(database, commandWrapper).Tables.Count > 0 ? Utility.ExecuteDataSet(database, commandWrapper).Tables[0] : table;
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return table;
        }
        public override DataTable GetStudents(TransactionManager transactionManager, decimal edAcadYearID, decimal asFacultyInfoID, decimal edCodeSemesterId, decimal edCodeLevelID, decimal EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_ED_STUD_GetStudents_Residency", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, edAcadYearID);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, asFacultyInfoID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ED_CODE_LEVEL_ID", DbType.Decimal, edCodeLevelID);
            database.AddInParameter(commandWrapper, "@EntaMainId", DbType.Decimal, EntMainId);
            DataTable table = new DataTable();
            try
            {
                if (transactionManager != null)
                {
                    table = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    table = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return table;
        }
        public override DataTable GetStudentCourseDegree(TransactionManager transactionManager, decimal edStudID, decimal edCourseID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GetStudentCourseDegree", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@P_ED_STUD_ID", DbType.Decimal, edStudID);
            database.AddInParameter(commandWrapper, "@P_ED_COURSE_ID", DbType.Decimal, edCourseID);

            DataTable table = new DataTable();
            try
            {
                if (transactionManager != null)
                {
                    table = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    table = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return table;
        }
        public override DataTable GetStudentAssessDegree(TransactionManager transactionManager, decimal edStudCourseRegID, decimal edCodeCourseAssessID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GetStudentAssessDegree", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@P_ED_STUD_COURSE_REG_ID", DbType.Decimal, edStudCourseRegID);
            database.AddInParameter(commandWrapper, "@P_ED_CODE_COURSE_ASSESS_ID", DbType.Decimal, edCodeCourseAssessID);

            DataTable table = new DataTable();
            try
            {
                if (transactionManager != null)
                {
                    table = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    table = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return table;
        }

        public override void LoadAgendaFeesOnStudent(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _ActivityId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadAgendaFeesOnStudent", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ActivityId", DbType.Decimal, _ActivityId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "LoadAgendaFeesOnStudent"));

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
            OnDataRequested(new CommandEventArgs(commandWrapper, "LoadAgendaFeesOnStudent"));

            commandWrapper = null;
        }//end Delete

        public override void Ed_Stud_Destroy(TransactionManager transactionManager, System.String _Students)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_Destroy", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Var_Students", DbType.String, _Students);


            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Ed_Stud_Destroy"));

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
            OnDataRequested(new CommandEventArgs(commandWrapper, "Ed_Stud_Destroy"));

            commandWrapper = null;
        }//end Delete

        public override DataTable GetAttendanceFWforStudent(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAttendanceFWforStudent", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ABS_COUNT");
            table.Columns.Add("IS_RESULT_APPROVED");
            table.Columns.Add("SEQ_NO");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

        public override bool InsertImportEdStud(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStud entity, UMIS_VER2.BusinessLyer.EdStudContactMethod entity2, UMIS_VER2.BusinessLyer.EdStudQual entity3)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_InsertImport", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
            database.AddInParameter(commandWrapper, "@NationalNumber", DbType.String, entity.NationalNumber);
            database.AddInParameter(commandWrapper, "@FullNameAr", DbType.String, entity.FullNameAr);
            database.AddInParameter(commandWrapper, "@ClFullNameAr", DbType.String, entity.ClFullNameAr);
            database.AddInParameter(commandWrapper, "@StudNameAr", DbType.String, entity.StudNameAr);
            database.AddInParameter(commandWrapper, "@ClStudNameAr", DbType.String, entity.ClStudNameAr);
            database.AddInParameter(commandWrapper, "@FatherNameAr", DbType.String, entity.FatherNameAr);
            database.AddInParameter(commandWrapper, "@ClFatherNameAr", DbType.String, entity.ClFatherNameAr);
            database.AddInParameter(commandWrapper, "@GrandfatherNameAr", DbType.String, entity.GrandfatherNameAr);
            database.AddInParameter(commandWrapper, "@ClGrandfatherNameAr", DbType.String, entity.ClGrandfatherNameAr);
            database.AddInParameter(commandWrapper, "@FamilyNameAr", DbType.String, entity.FamilyNameAr);
            database.AddInParameter(commandWrapper, "@ClFamilyNameAr", DbType.String, entity.ClFamilyNameAr);
            database.AddInParameter(commandWrapper, "@FullNameEn", DbType.String, entity.FullNameEn);
            database.AddInParameter(commandWrapper, "@StudNameEn", DbType.String, entity.StudNameEn);
            database.AddInParameter(commandWrapper, "@FatherNameEn", DbType.String, entity.FatherNameEn);
            database.AddInParameter(commandWrapper, "@GrandfatherNameEn", DbType.String, entity.GrandfatherNameEn);
            database.AddInParameter(commandWrapper, "@FamilyNameEn", DbType.String, entity.FamilyNameEn);
            database.AddInParameter(commandWrapper, "@FatherProfession", DbType.String, entity.FatherProfession);
            database.AddInParameter(commandWrapper, "@FatherNationalNumber", DbType.String, entity.FatherNationalNumber);
            database.AddInParameter(commandWrapper, "@MotherNationalNumber", DbType.String, entity.MotherNationalNumber);
            database.AddInParameter(commandWrapper, "@MotherNameAr", DbType.String, entity.MotherNameAr);
            database.AddInParameter(commandWrapper, "@ClMotherNameAr", DbType.String, entity.ClMotherNameAr);
            database.AddInParameter(commandWrapper, "@MotherNameEn", DbType.String, entity.MotherNameEn);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object)entity.GsCodeGenderId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeReligionId", DbType.Decimal, (entity.GsCodeReligionId.HasValue ? (object)entity.GsCodeReligionId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@BirthRegNumber", DbType.String, entity.BirthRegNumber);
            database.AddInParameter(commandWrapper, "@BirthDate", DbType.Date, (entity.BirthDate.HasValue ? (object)entity.BirthDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsBirthCountryNodeId", DbType.Decimal, (entity.GsBirthCountryNodeId.HasValue ? (object)entity.GsBirthCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId1", DbType.Decimal, (entity.GsCountryInfoId1.HasValue ? (object)entity.GsCountryInfoId1 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId2", DbType.Decimal, (entity.GsCountryInfoId2.HasValue ? (object)entity.GsCountryInfoId2 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StudPhoto", DbType.String, entity.StudPhoto);
            database.AddInParameter(commandWrapper, "@GsCodeIdentTypeId", DbType.Decimal, (entity.GsCodeIdentTypeId.HasValue ? (object)entity.GsCodeIdentTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsPrntStaff", DbType.Decimal, (entity.IsPrntStaff.HasValue ? (object)entity.IsPrntStaff : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaStfMemberPrntId", DbType.Decimal, (entity.SaStfMemberPrntId.HasValue ? (object)entity.SaStfMemberPrntId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudContactMethodId", DbType.Decimal, entity2.EdStudContactMethodId);

            database.AddInParameter(commandWrapper, "@GsCodeContactMethodId", DbType.Decimal, entity2.GsCodeContactMethodId);
            database.AddInParameter(commandWrapper, "@MethodDescr", DbType.String, entity2.MethodDescr);
            database.AddInParameter(commandWrapper, "@MethodNotes", DbType.String, entity2.MethodNotes);
            database.AddInParameter(commandWrapper, "@EdStudQualId", DbType.Decimal, entity3.EdStudQualId);

            database.AddInParameter(commandWrapper, "@EdCodeQualId", DbType.Decimal, entity3.EdCodeQualId);
            database.AddInParameter(commandWrapper, "@SchoolName", DbType.String, entity3.SchoolName);
            database.AddInParameter(commandWrapper, "@QualDate", DbType.DateTime, (entity3.QualDate.HasValue ? (object)entity3.QualDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@TotalDegree", DbType.Decimal, entity3.TotalDegree);
            database.AddInParameter(commandWrapper, "@TotalPercent", DbType.Decimal, entity3.TotalPercent);
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity3.GsCountryNodeId.HasValue ? (object)entity3.GsCountryNodeId : System.DBNull.Value));
            //database.AddInParameter(commandWrapper, "@IsAcceptanceQual", DbType.Decimal, entity3.IsAcceptanceQual);
            //database.AddInParameter(commandWrapper, "@IsStudAssorted", DbType.Decimal, (entity3.IsStudAssorted.HasValue ? (object)entity3.IsStudAssorted : System.DBNull.Value));
            //database.AddInParameter(commandWrapper, "@StudAssortment", DbType.Decimal, (entity3.StudAssortment.HasValue ? (object)entity3.StudAssortment : System.DBNull.Value));
            //database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity3.AsFacultyInfoId.HasValue ? (object)entity3.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StudSeatNum", DbType.Decimal, (entity3.StudSeatNum.HasValue ? (object)entity3.StudSeatNum : System.DBNull.Value));
            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertImportEdStud", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            entity.OriginalEdStudId = entity.EdStudId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "InsertImportEdStud", entity));

            return Convert.ToBoolean(results);
        }

        public override DataTable GeStudAluminiData(TransactionManager transactionManager, System.Decimal _FacultyID, System.Decimal _DepartmentId,
            System.Decimal _MajorId, System.Decimal _levelId, System.Decimal _AdmissionYearId, System.Decimal _GraduationYearId,
            //Add Additional parameters for search 
            System.Decimal _GraduationYearId2, System.Decimal _SemesterFromId, System.Decimal _SemesterToId,
            //Added by Eman Abdelgawad -Task 5537
            System.String _Code,
            System.Decimal _DegreeId, System.Decimal _ClassDegreeId, System.Decimal _StudTypeFlag, System.Decimal _enrollId, System.Decimal _blockflg, System.Decimal PageIndex, System.Decimal PageSize,
            System.Decimal? _Active,

             //kamela, add new params (studname , lang) to search with it in Ku case 
            System.String lang,
            System.String studName,
            //end
            //Kamela, 13536
            System.String National_Number,
            System.Decimal? National_Id,
            System.Decimal? ApplicNT_Type,
            //end
            decimal EdByLawId
              , decimal? PlanYearId = null
            , decimal? ParttimeStud = null
            , decimal? GenderId = null,
            decimal? AdmissionSemId =null,
            decimal? StudyMethodId=null
            )
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentAndAluminiHistory", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, _FacultyID);
            database.AddInParameter(commandWrapper, "@AdmissionYearId", DbType.Decimal, _AdmissionYearId);
            database.AddInParameter(commandWrapper, "@GraduationYearId", DbType.Decimal, _GraduationYearId);
            database.AddInParameter(commandWrapper, "@GraduationYearId2", DbType.Decimal, _GraduationYearId2);
            database.AddInParameter(commandWrapper, "@SemesterFromId", DbType.Decimal, _SemesterFromId);
            database.AddInParameter(commandWrapper, "@SemesterToId", DbType.Decimal, _SemesterToId);
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, _MajorId);
            database.AddInParameter(commandWrapper, "@LevelId", DbType.Decimal, _levelId);
            database.AddInParameter(commandWrapper, "@Code", DbType.String, _Code);
            database.AddInParameter(commandWrapper, "@DepartmentId", DbType.Decimal, _DepartmentId);
            database.AddInParameter(commandWrapper, "@DegreeId", DbType.Decimal, _DegreeId);
            database.AddInParameter(commandWrapper, "@DegreeClassID", DbType.Decimal, _ClassDegreeId);
            database.AddInParameter(commandWrapper, "@StudTypeFlag", DbType.Decimal, _StudTypeFlag);
            database.AddInParameter(commandWrapper, "@EnrollId", DbType.Decimal, _enrollId);
            database.AddInParameter(commandWrapper, "@blockflg", DbType.Decimal, _blockflg);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            database.AddInParameter(commandWrapper, "@Active", DbType.Decimal, _Active);
            //database.AddInParameter(commandWrapper, "@AllowSort", DbType.Decimal, AllowSort);
            //database.AddInParameter(commandWrapper, "@SortColumn", DbType.Decimal, SortColumn);
            //database.AddInParameter(commandWrapper, "@SortDirection", DbType.Decimal, SortDirection);


            //kamela, add new params (studname , lang) to search with it in Ku case 
            database.AddInParameter(commandWrapper, "@lang", DbType.String, lang);
            database.AddInParameter(commandWrapper, "@studName", DbType.String, studName);
            //end

            //Kamela, 13536
            database.AddInParameter(commandWrapper, "@National_Number", DbType.String, National_Number);
            if(National_Id.HasValue)
                 database.AddInParameter(commandWrapper, "@Nationality_Id", DbType.Decimal, National_Id);
            if (ApplicNT_Type.HasValue)
                database.AddInParameter(commandWrapper, "@ApplicantTpe_Id", DbType.Decimal, ApplicNT_Type);
            //end 

            #region //Task_4253  - Mostafa Hussien - 27/2/2018
            database.AddInParameter(commandWrapper, "@EdByLawId", DbType.Decimal, EdByLawId);
            #endregion

            if (PlanYearId.HasValue)
                database.AddInParameter(commandWrapper, "@PlanYearId", DbType.Decimal, PlanYearId);
            if(ParttimeStud.HasValue)
                database.AddInParameter(commandWrapper, "@PartTimeFlg", DbType.Decimal, ParttimeStud);//walaa 25052022

            if(GenderId.HasValue)
                database.AddInParameter(commandWrapper, "@GenderId", DbType.Decimal, GenderId);

            if (AdmissionSemId.HasValue)
                database.AddInParameter(commandWrapper, "@EdAdmAcadSemesterID", DbType.Decimal, AdmissionSemId); //esraa yousef eue 19068 21-8-2022  pass admmission sem 
            if (StudyMethodId.HasValue)
                database.AddInParameter(commandWrapper, "@StudyMethodId", DbType.Decimal, StudyMethodId);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_MAIN_FAC_ID");
            table.Columns.Add("MajorAr");
            table.Columns.Add("MajorEn");
            table.Columns.Add("MinorAr"); // MElshazly 30/5/2020
            table.Columns.Add("MinorEn"); // MElshazly 30/5/2020
            table.Columns.Add("AdmissionYear");
            table.Columns.Add("GraduationYear");
            table.Columns.Add("EnrollDescrAr");
            table.Columns.Add("EnrollDescrEn");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("OLD_ALUMNI_FLG");
            table.Columns.Add("AS_CODE_DEGREE_ID");
            //Kamela, 13536
            table.Columns.Add("Nationality_EN");
            table.Columns.Add("Nationality_AR");
            table.Columns.Add("ACCUM_GPA");

            //end
            table.Columns.Add("RowsTotCount");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString()
                                     ,  reader[8].ToString()
                                     ,  reader[9].ToString(),  reader[10].ToString(), reader[11].ToString(),  reader[12].ToString(), 
                                     reader[13].ToString(),  reader[14].ToString(),  reader[15].ToString(),  reader[16].ToString(), 
                                     reader[17].ToString(),  reader[18].ToString(),
                                     reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),reader[22].ToString(),reader[23].ToString()};
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

        //---------------------------------------- 

        public override DataTable GeStudAcadWarn(TransactionManager transactionManager, System.Decimal currentAcadYearId, System.Decimal currentSemsterId, System.Decimal _FacultyID, System.Decimal _DepartmentId,
           System.Decimal _MajorId, System.Decimal _levelId, System.Decimal _AdmissionYearId, System.Decimal _GraduationYearId, System.String _Code,
           System.Decimal _DegreeId, System.Decimal _ClassDegreeId, System.Decimal _StudTypeFlag, System.Decimal AcadWarnId, System.Decimal PageIndex, System.Decimal PageSize, decimal EdByLawId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_AllowRegForAcademicWarningsStud", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CurrentAcadYearId", DbType.Decimal, currentAcadYearId);
            database.AddInParameter(commandWrapper, "@CurrentSemsterId", DbType.Decimal, currentSemsterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, _FacultyID);
            database.AddInParameter(commandWrapper, "@AdmissionYearId", DbType.Decimal, _AdmissionYearId);
            database.AddInParameter(commandWrapper, "@GraduationYearId", DbType.Decimal, _GraduationYearId);
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, _MajorId);
            database.AddInParameter(commandWrapper, "@LevelId", DbType.Decimal, _levelId);
            database.AddInParameter(commandWrapper, "@Code", DbType.String, _Code);
            database.AddInParameter(commandWrapper, "@DepartmentId", DbType.Decimal, _DepartmentId);
            database.AddInParameter(commandWrapper, "@DegreeId", DbType.Decimal, _DegreeId);
            database.AddInParameter(commandWrapper, "@DegreeClassID", DbType.Decimal, _ClassDegreeId);
            database.AddInParameter(commandWrapper, "@StudTypeFlag", DbType.Decimal, _StudTypeFlag);
            database.AddInParameter(commandWrapper, "@AcadWarnId", DbType.Decimal, AcadWarnId); ;
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            database.AddInParameter(commandWrapper, "@EdByLawId", DbType.Decimal, EdByLawId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("currentAcadYearId");
            table.Columns.Add("currentSemsterId");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_MAIN_FAC_ID");
            table.Columns.Add("MajorAr");
            table.Columns.Add("MajorEn");
            table.Columns.Add("AdmissionYear");
            table.Columns.Add("GraduationYear");
            table.Columns.Add("AcadWarnDescrAr");
            table.Columns.Add("AcadWarnDescrEn");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("OLD_ALUMNI_FLG");
            table.Columns.Add("AS_CODE_DEGREE_ID");
            table.Columns.Add("RowsTotCount");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString(),  reader[6].ToString(),  reader[7].ToString()
                                     ,  reader[8].ToString()
                                     ,  reader[9].ToString(),  reader[10].ToString(), reader[11].ToString(),  reader[12].ToString(),  reader[13].ToString(),  reader[14].ToString(),  reader[15].ToString(),  reader[16].ToString(),  reader[17].ToString(),  reader[18].ToString(), reader[19].ToString(),  reader[20].ToString()};
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
        //----------------------------------------add by sara hassan in 24/7/2018 ******************



        public override bool UpdateImportEdStud(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStud entity, UMIS_VER2.BusinessLyer.EdStudContactMethod entity2, UMIS_VER2.BusinessLyer.EdStudQual entity3)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_UpdateImport", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
            database.AddInParameter(commandWrapper, "@OriginalEdStudId", DbType.Decimal, entity.OriginalEdStudId);
            database.AddInParameter(commandWrapper, "@NationalNumber", DbType.String, entity.NationalNumber);
            database.AddInParameter(commandWrapper, "@FullNameAr", DbType.String, entity.FullNameAr);
            database.AddInParameter(commandWrapper, "@ClFullNameAr", DbType.String, entity.ClFullNameAr);
            database.AddInParameter(commandWrapper, "@StudNameAr", DbType.String, entity.StudNameAr);
            database.AddInParameter(commandWrapper, "@ClStudNameAr", DbType.String, entity.ClStudNameAr);
            database.AddInParameter(commandWrapper, "@FatherNameAr", DbType.String, entity.FatherNameAr);
            database.AddInParameter(commandWrapper, "@ClFatherNameAr", DbType.String, entity.ClFatherNameAr);
            database.AddInParameter(commandWrapper, "@GrandfatherNameAr", DbType.String, entity.GrandfatherNameAr);
            database.AddInParameter(commandWrapper, "@ClGrandfatherNameAr", DbType.String, entity.ClGrandfatherNameAr);
            database.AddInParameter(commandWrapper, "@FamilyNameAr", DbType.String, entity.FamilyNameAr);
            database.AddInParameter(commandWrapper, "@ClFamilyNameAr", DbType.String, entity.ClFamilyNameAr);
            database.AddInParameter(commandWrapper, "@FullNameEn", DbType.String, entity.FullNameEn);
            database.AddInParameter(commandWrapper, "@StudNameEn", DbType.String, entity.StudNameEn);
            database.AddInParameter(commandWrapper, "@FatherNameEn", DbType.String, entity.FatherNameEn);
            database.AddInParameter(commandWrapper, "@GrandfatherNameEn", DbType.String, entity.GrandfatherNameEn);
            database.AddInParameter(commandWrapper, "@FamilyNameEn", DbType.String, entity.FamilyNameEn);
            database.AddInParameter(commandWrapper, "@FatherProfession", DbType.String, entity.FatherProfession);
            database.AddInParameter(commandWrapper, "@FatherNationalNumber", DbType.String, entity.FatherNationalNumber);
            database.AddInParameter(commandWrapper, "@MotherNationalNumber", DbType.String, entity.MotherNationalNumber);
            database.AddInParameter(commandWrapper, "@MotherNameAr", DbType.String, entity.MotherNameAr);
            database.AddInParameter(commandWrapper, "@ClMotherNameAr", DbType.String, entity.ClMotherNameAr);
            database.AddInParameter(commandWrapper, "@MotherNameEn", DbType.String, entity.MotherNameEn);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object)entity.GsCodeGenderId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeReligionId", DbType.Decimal, (entity.GsCodeReligionId.HasValue ? (object)entity.GsCodeReligionId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@BirthRegNumber", DbType.String, entity.BirthRegNumber);
            database.AddInParameter(commandWrapper, "@BirthDate", DbType.Date, (entity.BirthDate.HasValue ? (object)entity.BirthDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsBirthCountryNodeId", DbType.Decimal, (entity.GsBirthCountryNodeId.HasValue ? (object)entity.GsBirthCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId1", DbType.Decimal, (entity.GsCountryInfoId1.HasValue ? (object)entity.GsCountryInfoId1 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId2", DbType.Decimal, (entity.GsCountryInfoId2.HasValue ? (object)entity.GsCountryInfoId2 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StudPhoto", DbType.String, entity.StudPhoto);
            database.AddInParameter(commandWrapper, "@GsCodeIdentTypeId", DbType.Decimal, (entity.GsCodeIdentTypeId.HasValue ? (object)entity.GsCodeIdentTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsPrntStaff", DbType.Decimal, (entity.IsPrntStaff.HasValue ? (object)entity.IsPrntStaff : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaStfMemberPrntId", DbType.Decimal, (entity.SaStfMemberPrntId.HasValue ? (object)entity.SaStfMemberPrntId : System.DBNull.Value));

            database.AddInParameter(commandWrapper, "@EdStudContactMethodId", DbType.Decimal, entity2.EdStudContactMethodId);
            database.AddInParameter(commandWrapper, "@OriginalEdStudContactMethodId", DbType.Decimal, entity2.OriginalEdStudContactMethodId);

            database.AddInParameter(commandWrapper, "@GsCodeContactMethodId", DbType.Decimal, entity2.GsCodeContactMethodId);
            database.AddInParameter(commandWrapper, "@MethodDescr", DbType.String, entity2.MethodDescr);
            database.AddInParameter(commandWrapper, "@MethodNotes", DbType.String, entity2.MethodNotes);

            database.AddInParameter(commandWrapper, "@EdStudQualId", DbType.Decimal, entity3.EdStudQualId);
            database.AddInParameter(commandWrapper, "@OriginalEdStudQualId", DbType.Decimal, entity3.OriginalEdStudQualId);

            database.AddInParameter(commandWrapper, "@EdCodeQualId", DbType.Decimal, entity3.EdCodeQualId);
            database.AddInParameter(commandWrapper, "@SchoolName", DbType.String, entity3.SchoolName);
            database.AddInParameter(commandWrapper, "@QualDate", DbType.DateTime, (entity3.QualDate.HasValue ? (object)entity3.QualDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@TotalDegree", DbType.Decimal, entity3.TotalDegree);
            database.AddInParameter(commandWrapper, "@TotalPercent", DbType.Decimal, entity3.TotalPercent);
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity3.GsCountryNodeId.HasValue ? (object)entity3.GsCountryNodeId : System.DBNull.Value));
            //database.AddInParameter(commandWrapper, "@IsAcceptanceQual", DbType.Decimal, entity3.IsAcceptanceQual);
            //database.AddInParameter(commandWrapper, "@IsStudAssorted", DbType.Decimal, (entity3.IsStudAssorted.HasValue ? (object)entity3.IsStudAssorted : System.DBNull.Value));
            //database.AddInParameter(commandWrapper, "@StudAssortment", DbType.Decimal, (entity3.StudAssortment.HasValue ? (object)entity3.StudAssortment : System.DBNull.Value));
            //database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity3.AsFacultyInfoId.HasValue ? (object)entity3.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StudSeatNum", DbType.Decimal, (entity3.StudSeatNum.HasValue ? (object)entity3.StudSeatNum : System.DBNull.Value));
            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "UpdateImportEdStud", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            entity.OriginalEdStudId = entity.EdStudId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "UpdateImportEdStud", entity));

            return Convert.ToBoolean(results);
        }

        //Added by nashassan 24/8/2016
        public override DataTable GetStud4Notify(TransactionManager transactionManager, Hashtable studSearchParams)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStud4Notify", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, studSearchParams["_lang"]);
            //database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, studSearchParams["_asFacultyInfoId"]);
            //database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, studSearchParams["_EdAcadYearId"]);
            //database.AddInParameter(commandWrapper, "@EdAdmAcadYearId", DbType.Decimal, studSearchParams["EdAdmAcadYearId"]);
            //database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, studSearchParams["_EdCodeSemesterId"]);
            //database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, studSearchParams["_EntityMainId"]);
            //database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, studSearchParams["_GsCodeGenderId"]);

            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, decimal.Parse(studSearchParams["_PageIndex"].ToString()));
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, decimal.Parse(studSearchParams["_PageSize"].ToString()));
            database.AddInParameter(commandWrapper, "@AllowSort", DbType.Decimal, decimal.Parse(studSearchParams["_AllowSort"].ToString()));
            database.AddInParameter(commandWrapper, "@SortColumn", DbType.Decimal, decimal.Parse(studSearchParams["_SortColumn"].ToString()));
            database.AddInParameter(commandWrapper, "@SortDirection", DbType.Decimal, decimal.Parse(studSearchParams["_SortDirection"].ToString()));

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("StudFacultyCode");
            table.Columns.Add("EdStudId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("Email");
            table.Columns.Add("Mobile");
            table.Columns.Add("Phone");
            table.Columns.Add("NationDescrAr");
            table.Columns.Add("NationDescrEn");
            table.Columns.Add("GsCountryInfoId1");
            table.Columns.Add("AsFacultyInfoId");
            table.Columns.Add("GsCodeGenderId");
            table.Columns.Add("Total");
            table.Columns.Add("RowsTotCount");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString() };
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

        public override DataTable GetStudentPhoto(TransactionManager transactionManager, decimal _FacultyID, string StudCode, decimal _DepartmentId, decimal _MajorId, decimal _levelId, decimal _DegreeId, decimal _ClassDegreeId, decimal photoFlag, decimal PageIndex, decimal PageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStudentPhoto", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, _FacultyID);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode == "" ? "0" : StudCode);
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, _MajorId);
            database.AddInParameter(commandWrapper, "@LevelId", DbType.Decimal, _levelId);
            database.AddInParameter(commandWrapper, "@DepartmentId", DbType.Decimal, _DepartmentId);
            database.AddInParameter(commandWrapper, "@DegreeId", DbType.Decimal, _DegreeId);
            database.AddInParameter(commandWrapper, "@DegreeClassID", DbType.Decimal, _ClassDegreeId);
            database.AddInParameter(commandWrapper, "@PhotoFlag", DbType.Decimal, photoFlag);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);

            IDataReader reader = null;
            DataTable table = new DataTable();
            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                table.Load(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWrapper = null;
            }
            return table;
        }


        public override DataTable StudSerchDateCtrl(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
     , System.Decimal? _EdCodeLevelId, System.Decimal? _EntityMainId, System.Decimal? _GsCodeGenderId, System.Decimal? _GsCountryInfoId,
        string StudName, string StudCode, string NationalNum, System.Decimal _LangNum, System.Decimal _NamePolicy,
        decimal asCodeDegreeId, System.Decimal? _AsCodeDegreeClassId,decimal?AdmYearId =null,decimal?AdmSemesterId=null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudSerchDateCtrl", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, _GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, _GsCountryInfoId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@NationalNum", DbType.String, NationalNum);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, _LangNum);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy);

            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            if (AdmYearId != null)
                database.AddInParameter(commandWrapper, "@AdmYearId", DbType.Decimal, AdmYearId);
            if (AdmSemesterId != null)
                database.AddInParameter(commandWrapper,"@AdmSemesterId",DbType.Decimal,AdmSemesterId);
            DataSet ds = null;

            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }

                //Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }
        public override DataTable GetStudAdvRmk(TransactionManager transactionManager, System.Decimal? _EdStudID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudAdvRmk", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_ACDADV_RMK_ID");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("RMK_DATE");
            table.Columns.Add("RMK_TITLE");
            table.Columns.Add("RMK_DTL");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
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
        /// GET STUDENT DATA ADDITIONAL TO BANK NAME AND BANCE ACCOUNT TASK 8572
        /// </summary>
        /// <param name="transactionManager"></param>
        /// <param name="_EdStudID"></param>
        /// <returns></returns>

        public override DataTable GetStudBank(TransactionManager transactionManager, System.Decimal? _EdStudID, System.Decimal? _StudDept, System.Decimal? _StudFaculty, System.Decimal? _StudDegree)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWarpper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.STUD_BANK_ACCOUNT", this.UseStoredProcedure);
            database.AddInParameter(commandWarpper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWarpper, "@deptid", DbType.Decimal, _StudDept);
            database.AddInParameter(commandWarpper, "@facltyinfoid", DbType.Decimal, _StudFaculty);
            database.AddInParameter(commandWarpper, "@degreeid", DbType.Decimal, _StudDegree);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_STUD_Code");
            table.Columns.Add("STUD_Bank_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("DEPARTMENT_AR");
            table.Columns.Add("DEPARTMENT_EN");
            table.Columns.Add("STUD_BANK_NAME_AR");
            table.Columns.Add("STUD_BANK_NAME_EN");
            table.Columns.Add("STUD_BANK_ACC");
            table.Columns.Add("PAYROLL_CARD_FLG");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWarpper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWarpper);
                }
                while (reader.Read())
                {
                    object[] items ={reader[0].ToString(),reader[1].ToString(),reader[2].ToString(),reader[3].ToString(),reader[4].ToString(),
                                   reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWarpper = null;

            }
            return table;

        }
        //eman moustafa Task:13027 Date:1/6/2020
        public override DataTable GetStudBank_Css(TransactionManager transactionManager, System.Decimal? _EdAcadYearID, System.Decimal? _EDLevelID, System.Decimal? _MajorID, System.Decimal? _MinorID,
            System.Decimal? _EdStudID, string _EdStudName, System.Decimal? _GenderID, System.Decimal? _CdeStudTypeID, System.Decimal? _Nationality, System.Decimal? _RegFlg, System.Decimal? _Lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWarpper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.STUD_BANK_ACCOUNT_Css", this.UseStoredProcedure);
            database.AddInParameter(commandWarpper, "@EdAcadYearID", DbType.Decimal, _EdAcadYearID);
            database.AddInParameter(commandWarpper, "@EDLevelID", DbType.Decimal, _EDLevelID);
            database.AddInParameter(commandWarpper, "@MajorID", DbType.Decimal, _MajorID);
            database.AddInParameter(commandWarpper, "@MinorID", DbType.Decimal, _MinorID);
            database.AddInParameter(commandWarpper, "@EdStudID", DbType.Decimal, _EdStudID);
            //database.AddInParameter(commandWarpper, "@EdStudCode", DbType.String, _EdStudCode);
            database.AddInParameter(commandWarpper, "@EdStudName", DbType.String, _EdStudName);
            database.AddInParameter(commandWarpper, "@GenderID", DbType.Decimal, _GenderID);
            database.AddInParameter(commandWarpper, "@CdeStudTypeID", DbType.Decimal, _CdeStudTypeID);
            database.AddInParameter(commandWarpper, "@Nationality", DbType.Decimal, _Nationality);
            database.AddInParameter(commandWarpper, "@RegFlg", DbType.Decimal, _RegFlg);
            database.AddInParameter(commandWarpper, "@Lang", DbType.Decimal, _Lang);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_STUD_Code");
            table.Columns.Add("STUD_Bank_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("Major_AR");
            table.Columns.Add("Major_EN");
            //table.Columns.Add("STUD_BANK_NAME_AR");
            //table.Columns.Add("STUD_BANK_NAME_EN");
            table.Columns.Add("STUD_BANK_ACC");
            table.Columns.Add("PAYROLL_CARD_FLG");
            table.Columns.Add("Student_Type_AR");
            table.Columns.Add("Student_Type_EN");
            table.Columns.Add("Minor_AR");
            table.Columns.Add("Minor_EN");
            table.Columns.Add("LEVEL_DESCR_AR");
            table.Columns.Add("LEVEL_DESCR_EN");
            table.Columns.Add("NATION_DESCR_AR");
            table.Columns.Add("NATION_DESCR_EN");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWarpper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWarpper);
                }
                while (reader.Read())
                {
                    object[] items ={reader[0].ToString(),reader[1].ToString(),reader[2].ToString(),reader[3].ToString(),reader[4].ToString(),
                                   reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()
                                    ,reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString()};
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWarpper = null;

            }
            return table;

        }
        //Esraa Ali     27-5-2020     13648
        //Start
        public override DataTable INTEG_GetStudents(System.Decimal _FacID, System.Decimal _YearID, System.Decimal _SemID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.INTEG_GetStudents", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FacID", DbType.Decimal, _FacID);
            database.AddInParameter(commandWrapper, "@YearID", DbType.Decimal, _YearID);
            database.AddInParameter(commandWrapper, "@SemID", DbType.Decimal, _SemID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SIS ID");
            table.Columns.Add("School SIS ID");
            table.Columns.Add("Username");

            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                while (reader.Read())
                {
                    object[] items ={reader[0].ToString(),reader[1].ToString(),reader[2].ToString()};
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

        public override DataTable INTEG_GetStudentEnrollment(System.Decimal _FacID,System.Decimal _YearID,System.Decimal _SemID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.INTEG_GetStudentEnrollment", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FacID", DbType.Decimal, _FacID);
            database.AddInParameter(commandWrapper, "@YearID", DbType.Decimal, _YearID);
            database.AddInParameter(commandWrapper, "@SemID", DbType.Decimal, _SemID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("Section SIS ID");
            table.Columns.Add("SIS ID");

            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString()};
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
        //End

        #endregion
        public override DataTable GetAbsenceStudToApprove(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearId, System.Decimal _CourseId, System.Decimal EdExamScheduleId, System.Decimal ApproveFlag, System.String StudCode, System.Decimal courseAssessId, System.Decimal? AsCodeDegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.AbsenceStudToApprove", this.UseStoredProcedure);


            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _CourseId);
            database.AddInParameter(commandWrapper, "@CourseAssessId", DbType.Decimal, courseAssessId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdExamScheduleId", DbType.Decimal, EdExamScheduleId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@Approve_FLG", DbType.Decimal, ApproveFlag);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.String, AsCodeDegreeClassId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("StudCode");

            table.Columns.Add("StudFullNameAr");
            table.Columns.Add("StudFullNameEn");
            table.Columns.Add("EdStudId");
            table.Columns.Add("EdExamStudAbsenceId");
            table.Columns.Add("AbsenceFlag");

            table.Columns.Add("ExcuseFlag");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("Major_Ar");
            table.Columns.Add("Major_EN");

            table.Columns.Add("ED_STUD_COURSE_REG_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("ED_CODE_COURSE_ASSESS_ID");
            table.Columns.Add("ED_CDE_EXECUSE_RSN_ID");

            table.Columns.Add("NOTES");
            table.Columns.Add("IS_RESULT_APPROVED");
            table.Columns.Add("EXAM_APPROVE_FLG");
            table.Columns.Add("ASSESS_DEG");
            table.Columns.Add("SEM_WORK_FLG");

            table.Columns.Add("ED_CDE_EXAM_TYPE_ID");
            table.Columns.Add("SECRET_NUM");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                             reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), 
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(), 
                                             reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),
                                             reader[20].ToString(), reader[21].ToString(),reader[22].ToString(),reader[23].ToString(),
                                             reader[24].ToString(),reader[25].ToString(),reader[26].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), 
                                             reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), 
                                             reader[12].ToString(),reader[13].ToString(),reader[14].ToString() ,reader[15].ToString(),
                                             reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),
                                             reader[20].ToString(), reader[21].ToString(),reader[22].ToString(),reader[23].ToString(),
                                             reader[24].ToString(),reader[25].ToString(),reader[26].ToString()};
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
        public override UMIS_VER2.BusinessLyer.EdStud GetByEdStudIdModular(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_GetByEdStudId_Modular", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _edStudId);

            IDataReader reader = null;
            TList<EdStud> tmp = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEdStudIdModular", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdStudIdModular", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (tmp.Count == 1)
            {
                return tmp[0];
            }
            else if (tmp.Count == 0)
            {
                return null;
            }
            else
            {
                throw new DataException("Cannot find the unique instance of the class.");
            }

            //return rows;
        }
        // task 16153 added by maha 
        public override DataTable GetCurrentStudyMethodForStudent(TransactionManager transactionManager, string StudentCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Getstudent_StudyMethod", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudCode", DbType.String, StudentCode);
          
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUDY_METHOD_ID");

            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString()};
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
        //------------
        //added by esraa yousef 18762 eue 12-6-2022
        public override DataTable GetCurrentAccumTypeGradingForStudent(TransactionManager transactionManager, string StudentCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCurrentAccumTypeGradingForStudent", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudCode", DbType.String, StudentCode);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ACCUM_GRDNG_TYPE_FLG");

            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString() };
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
        //------------
        public override DataTable GetABSofStudInCourse(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID, Decimal _CourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAllABSOfStud", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _CourseId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_ID");
            table.Columns.Add("AbsDate");
            table.Columns.Add("DescrAr");
            table.Columns.Add("DescrEn");
            table.Columns.Add("SC_GROUP_DAY_ID");
            table.Columns.Add("ExecuseFlg");


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

    }
}