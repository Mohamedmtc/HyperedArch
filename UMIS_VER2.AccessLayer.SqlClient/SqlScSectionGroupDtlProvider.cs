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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScSectionGroupDtl"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScSectionGroupDtlProvider: SqlScSectionGroupDtlProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScSectionGroupDtlProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScSectionGroupDtlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetSectionDtlForShow(TransactionManager transactionManager, System.Decimal ScSectionGroupHdrId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SECTION_GROUP_DTL_GetForShow", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScSectionGroupHdrId", DbType.Decimal, ScSectionGroupHdrId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_SECTION_GROUP_DTL_ID");
            table.Columns.Add("SC_SECTION_GROUP_HDR_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("GROUP_ORDER");
            table.Columns.Add("NO_STUDENTS");
            table.Columns.Add("NO_STUD_MAX");

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

        public override int GetOrientStudCount(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SECTION_GROUP_DTL_GetOrientStudCount", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("OrientStudCount");
            int count = 0;
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

            if (table.Rows.Count > 0)
                count = int.Parse(table.Rows[0][0].ToString());

            return count;
        }

        public override bool LoadOrientaionCourses(TransactionManager transactionManager, System.Decimal _ScSectionGroupHdrId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudSemesters)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadOrientaionCourses", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ScSectionGroupHdrId", DbType.Decimal, _ScSectionGroupHdrId);
            database.AddInParameter(commandWrapper, "@StudSemesters", DbType.String, _StudSemesters);

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

        public override bool LoadSectionGroupDtl(TransactionManager transactionManager, System.Decimal _ScSectionGroupHdrId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudSemesters)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SECTION_GROUP_DTL_LOAD", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ScSectionGroupHdrId", DbType.Decimal, _ScSectionGroupHdrId);
            database.AddInParameter(commandWrapper, "@StudSemesters", DbType.String, _StudSemesters);

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

        public override DataTable GetAcadPlanEntities(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EntMainId, System.Decimal AsCodeDegreeClassId, System.Decimal EntCodeEntityTypeId, System.Decimal CurrentFlg, System.Decimal MajorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAcadPlanMajors", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, EntCodeEntityTypeId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@currentFlg", DbType.Decimal, CurrentFlg);
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, MajorId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ED_ACAD_PLAN_ID");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("YEAR_DESCR_AR");
            table.Columns.Add("YEAR_DESCR_EN");
            table.Columns.Add("YEAR_ORDER");
            table.Columns.Add("ParentDeptId");

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

        public override DataTable GetStudentsOnAcadPlan(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadPlanId, System.Decimal EdCodeLevelId, System.Decimal GsCodeGenderId, System.Decimal OrientFlg, System.Decimal SortBy, System.Decimal Lang, decimal? GroupHdrId = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentsOnAcadPlan", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadPlanId", DbType.Decimal, EdAcadPlanId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@OrientFlg", DbType.Decimal, OrientFlg);
            database.AddInParameter(commandWrapper, "@SortBy", DbType.Decimal, SortBy);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, Lang);
            if (GroupHdrId.HasValue)
                database.AddInParameter(commandWrapper, "@GroupHdrId", DbType.Decimal, GroupHdrId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("Sn");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("IS_COURSE_APPROVED");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
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
        //added by manar to  Delete Courses and unload Group From Students tfs :18477
        public override bool UNLoadSectionGroupDtl(TransactionManager transactionManager, System.Decimal _ScSectionGroupHdrId, System.String _StudSemesters)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SECTION_GROUP_DTL_UNLOAD", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ScSectionGroupHdrId", DbType.Decimal, _ScSectionGroupHdrId);
            database.AddInParameter(commandWrapper, "@StudSemesters", DbType.String, _StudSemesters);
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
        public override DataTable GetStudentsRegisteredOnGroup(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal EdAcadPlanId, System.Decimal EdCodeLevelId, System.Decimal GsCodeGenderId, System.Decimal OrientFlg, System.Decimal SortBy, System.Decimal Lang, decimal? GroupHdrId = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentsRegisteredOnGroup", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadPlanId", DbType.Decimal, EdAcadPlanId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, GsCodeGenderId);
            database.AddInParameter(commandWrapper, "@OrientFlg", DbType.Decimal, OrientFlg);
            database.AddInParameter(commandWrapper, "@SortBy", DbType.Decimal, SortBy);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, Lang);
            if (GroupHdrId.HasValue)
                database.AddInParameter(commandWrapper, "@GroupHdrId", DbType.Decimal, GroupHdrId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("Sn");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("IS_COURSE_APPROVED");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
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