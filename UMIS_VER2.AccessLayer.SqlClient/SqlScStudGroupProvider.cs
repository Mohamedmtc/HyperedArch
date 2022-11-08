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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScStudGroup"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScStudGroupProvider: SqlScStudGroupProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScStudGroupProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScStudGroupProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetStudsInGroup(TransactionManager transactionManager, System.Decimal _scGroupInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_STUD_GROUP_StudsInGroup", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@scGroupInfoId", DbType.Decimal, _scGroupInfoId);

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("SC_STUD_GROUP_ID");
            tbl.Columns.Add("ED_STUD_ID");
            tbl.Columns.Add("STUD_FACULTY_CODE");
            tbl.Columns.Add("FULL_NAME_AR");
            tbl.Columns.Add("FULL_NAME_EN");
            tbl.Columns.Add("LEVEL_DESCR_AR");
            tbl.Columns.Add("LEVEL_DESCR_EN");
            tbl.Columns.Add("SENIORITY_LVL");
            tbl.Columns.Add("DGR_AR");
            tbl.Columns.Add("DGR_EN");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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

        public override DataTable StudentsSearchForAdd(TransactionManager transactionManager, System.Decimal _scGroupInfoId,decimal _edCodeLevelId, string _studCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_STUD_GROUP_StudentsSearchForAdd", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@scGroupInfoId", DbType.Decimal, _scGroupInfoId);
            database.AddInParameter(commandWrapper, "@edCodeLevelId", DbType.Decimal, _edCodeLevelId);
            database.AddInParameter(commandWrapper, "@studCode", DbType.String, _studCode);

            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ED_STUD_ID");
            tbl.Columns.Add("STUD_FACULTY_CODE");
            tbl.Columns.Add("FULL_NAME_AR");
            tbl.Columns.Add("FULL_NAME_EN");
            tbl.Columns.Add("LEVEL_DESCR_AR");
            tbl.Columns.Add("LEVEL_DESCR_EN");
            tbl.Columns.Add("AS_FACULTY_INFO_ID");
            tbl.Columns.Add("ED_ACAD_YEAR_ID");
            tbl.Columns.Add("ED_CODE_SEMESTER_ID");
            tbl.Columns.Add("SENIORITY_LVL");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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

        public override DataTable SC_Get_Count_Of_Students(TransactionManager transactionManager, System.Decimal asFacultyInfoId, System.Decimal EDCODESEMESTERID, System.Decimal EDACADYEARID, System.Decimal EDCODELEVELID, System.Decimal ENTMAINID, System.Decimal SCGROUPINFOPRNTID, System.Decimal EDCOURSEID, decimal GrpTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SC_Get_Count_Of_Students", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EDCODESEMESTERID", DbType.Decimal, EDCODESEMESTERID);
            database.AddInParameter(commandWrapper, "@asFacultyInfoId", DbType.Decimal, asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EDACADYEARID", DbType.Decimal, EDACADYEARID);
            database.AddInParameter(commandWrapper, "@EDCODELEVELID", DbType.Decimal, EDCODELEVELID);
            database.AddInParameter(commandWrapper, "@ENTMAINID", DbType.Decimal, ENTMAINID);
            database.AddInParameter(commandWrapper, "@SCGROUPINFOPRNTID", DbType.Decimal, SCGROUPINFOPRNTID);
            database.AddInParameter(commandWrapper, "@EDCOURSEID", DbType.Decimal, EDCOURSEID);
            database.AddInParameter(commandWrapper, "@GrpTypeId", DbType.Decimal, GrpTypeId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("totalstudent");
            table.Columns.Add("Student_group");
            table.Columns.Add("Student_Section");
            table.Columns.Add("NO_Groups");
            table.Columns.Add("NO_Sec");
            table.Columns.Add("NO_STUD_grp");

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

        public override void AutoGenerateSubGroupInfo(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EntMainId, decimal EdCodeLevelId, decimal EdCourseId, decimal ScGroupInfoPrntId, decimal GrpTypeId, decimal TotStudCount, decimal GroupCount, decimal GroupStudCount, decimal OrderTypeId, string grpPrfx)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.AutoGenerateSubGroupInfo", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EdCourseId ", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@ScGroupInfoPrntId ", DbType.Decimal, ScGroupInfoPrntId);
            database.AddInParameter(commandWrapper, "@GrpTypeId", DbType.Decimal, GrpTypeId);
            database.AddInParameter(commandWrapper, "@TotStudCount", DbType.Decimal, TotStudCount);
            database.AddInParameter(commandWrapper, "@GroupCount", DbType.Decimal, GroupCount);
            database.AddInParameter(commandWrapper, "@GroupStudCount", DbType.Decimal, GroupStudCount);
            database.AddInParameter(commandWrapper, "@OrderTypeId", DbType.Decimal, OrderTypeId);
            database.AddInParameter(commandWrapper, "@GrpPrfx", DbType.String, grpPrfx);

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

        //Angham 25/11/2020
        public override Boolean ValidateIFStudentsInGroupSection(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdcodeSemesterId,
                    System.Decimal AcadYearID, System.Decimal EdCodeLevelID, System.Decimal MajorID, decimal GrpTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "CheckStudentsInGroupSection", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CodeSemsterID", DbType.Decimal, EdcodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@AcadYearID", DbType.Decimal, AcadYearID);
            database.AddInParameter(commandWrapper, "@LevelID", DbType.Decimal, EdCodeLevelID);
            database.AddInParameter(commandWrapper, "@MajorID", DbType.Decimal, MajorID);
            database.AddInParameter(commandWrapper, "@GroupInfoType", DbType.Decimal, GrpTypeId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ALLDataDone");


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
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][0].ToString() == "1")
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        //End Angham 25/11/2020
	}
}