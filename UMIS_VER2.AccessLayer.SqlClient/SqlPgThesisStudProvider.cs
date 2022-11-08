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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="PgThesisStud"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlPgThesisStudProvider: SqlPgThesisStudProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlPgThesisStudProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlPgThesisStudProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region "Custom methods"
        public override DataTable GetThesis_List(TransactionManager transactionManager, System.Decimal? _EntMainId, System.Decimal? _asCodeDegree,
          System.Decimal _EdAcadYearId, System.Decimal AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.String _EdStudName, System.String studCode, System.Decimal admYear,
           System.Decimal grant_Flg, System.String thesisSubj)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchStudThesis", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AS_CODE_DEGREE_ID", DbType.Decimal, _asCodeDegree);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ENT_MAIN_ID", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@STUD_NAME", DbType.String, _EdStudName);

            database.AddInParameter(commandWrapper, "@STUD_Code", DbType.String, studCode);
            database.AddInParameter(commandWrapper, "@AdmEdAcadYearId", DbType.Decimal, admYear);
            database.AddInParameter(commandWrapper, "@GrantFlg", DbType.Decimal, grant_Flg);
            database.AddInParameter(commandWrapper, "@ThesisTitle", DbType.String, thesisSubj);

            IDataReader reader = null;
            DataTable table = new DataTable();
            
           // table.Columns.Add("ED_CODE_COURSE_ID");
            table.Columns.Add("AS_CODE_DEGREE_ID");
            table.Columns.Add("PG_THESIS_STUD_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("TITLE_AR");
            table.Columns.Add("TITLE_EN");
            table.Columns.Add("REG_DATE");
            table.Columns.Add("GRANT_DATE");
            table.Columns.Add("TOPIC_EN");
            table.Columns.Add("TOPIC_AR");
            table.Columns.Add("MajDescrAr");
            table.Columns.Add("MajDescrEn");
            table.Columns.Add("DegreeDescrAr");
            table.Columns.Add("DegreeDescrEn");
            table.Columns.Add("LevelDescrAr");
            table.Columns.Add("LevelDescrEn"); 

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
                                     , reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString()
                                     , reader[8].ToString() , reader[9].ToString() , reader[10].ToString(), reader[11].ToString()
                                      , reader[12].ToString() , reader[13].ToString() , reader[14].ToString(), reader[15].ToString()
                                     , reader[16].ToString() , reader[17].ToString()};
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
        //eman moustafa ,Date:6-7-2020  Task:13850
    
        public override DataTable GetStudWithAcceptResearch(TransactionManager transactionManager, System.Decimal? EntMainMajorId,System.Decimal? EntMainMinorId, 
         System.Decimal _EdAcadYearId, System.Decimal AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.String _EdStudName, System.String studCode,
          System.String _SuprviserName, System.String _DiscusserName, System.Decimal? _asCodeDegree, System.String _ReaserchTitle)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudWithAcceptResearch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsCodeDegreeID", DbType.Decimal, _asCodeDegree);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainMajorId", DbType.Decimal, EntMainMajorId);
            database.AddInParameter(commandWrapper, "@EntMainMinorId", DbType.Decimal, EntMainMinorId);
            database.AddInParameter(commandWrapper, "@studName", DbType.String, _EdStudName);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, studCode);
            database.AddInParameter(commandWrapper, "@SuprviserName", DbType.String, _SuprviserName);
            database.AddInParameter(commandWrapper, "@DiscusserName", DbType.String, _DiscusserName);
            database.AddInParameter(commandWrapper, "@ReaserchTitle", DbType.String, _ReaserchTitle);

            IDataReader reader = null;
            DataTable table = new DataTable();

            // table.Columns.Add("ED_CODE_COURSE_ID");
           
            table.Columns.Add("PG_THESIS_STUD_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("Major_Ar");
            table.Columns.Add("Major_EN");
            //table.Columns.Add("Minor_Ar");
            //table.Columns.Add("Minor_En");
            table.Columns.Add("TITLE_AR");
            table.Columns.Add("RSRCH_STATUS_AR");
            table.Columns.Add("RSRCH_STATUS_EN");
            table.Columns.Add("SupervisorAR");
            table.Columns.Add("Supervisoren");
            table.Columns.Add("DiscusserAr");
            table.Columns.Add("DiscusserEN");
            table.Columns.Add("RSRCH_STUD_REGISTER_DTL_ID");
            

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
                                     , reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString()
                                     , reader[8].ToString() , reader[9].ToString() , reader[10].ToString(), reader[11].ToString()
                                      , reader[12].ToString() , reader[13].ToString() ,reader[14].ToString() 
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

        //Kamela, 13866,
        public override DataTable GetResearchStudsForGrading(TransactionManager transactionManager, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId,
             System.Decimal AsFacultyInfoId, System.Decimal? EntMainMajorId, System.Decimal? EntMainMinorId, System.String ReaserchTitle, System.String studCode,
         System.String EdStudName, System.Decimal? EdCourseId, System.Decimal? AssessHDRId, System.Decimal? Approve_Flg, System.Decimal? SatffMEmebr_Id)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetResearchStudsForGrading", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AcadYear_Id", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@Codesemester_Id", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFaculty_Id", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@Major_Id", DbType.Decimal, EntMainMajorId);
            database.AddInParameter(commandWrapper, "@Minor_Id", DbType.Decimal, EntMainMinorId);
            database.AddInParameter(commandWrapper, "@ReSearchttile", DbType.String, ReaserchTitle);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, studCode);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, EdStudName);
            database.AddInParameter(commandWrapper, "@Course_Id", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@Assess_HDR_Id", DbType.Decimal, AssessHDRId);
            database.AddInParameter(commandWrapper, "@ApproveResult_Flg", DbType.Decimal, Approve_Flg);
            database.AddInParameter(commandWrapper, "@Staff_Id", DbType.Decimal, SatffMEmebr_Id);

            IDataReader reader = null;
            DataTable table = new DataTable();
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    table.Load(reader);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    table.Load(reader);

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

        //end
        #endregion

    }
}