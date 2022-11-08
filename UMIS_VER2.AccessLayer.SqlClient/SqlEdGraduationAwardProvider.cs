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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdGraduationAward"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdGraduationAwardProvider: SqlEdGraduationAwardProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdGraduationAwardProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdGraduationAwardProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetGraduateSpecilaization(TransactionManager transactionManager, decimal? EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetGraduateSpecilaization", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, (EdStudId.HasValue ? (object)EdStudId : System.DBNull.Value));
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetGraduateSpecilaization"));

                if (transactionManager != null)
                    return Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                else
                    return Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }

            finally
            {
                commandWrapper = null;
            }
            return null;
        }

        public override DataTable GetGraduatesCertificates(TransactionManager transactionManager, decimal? EdStudId, decimal? EdAcadYearId, string GRADUATION_AWARD_NUMBER, DateTime? GRADUATION_AWARD_DATE, DateTime? PRESIDENT_APPROVAL_DATE, decimal? AsFacultyInfoId, string FAC_GRADUATION_AWARD_NUMBER, DateTime? FAC_GRADUATION_AWARD_DATE, decimal pageIndex, decimal pageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetGraduatesCertificates", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, (EdStudId.HasValue ? (object)EdStudId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, (EdAcadYearId.HasValue ? (object)EdAcadYearId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GRADUATION_AWARD_NUMBER", DbType.String, GRADUATION_AWARD_NUMBER);
            database.AddInParameter(commandWrapper, "@GRADUATION_AWARD_DATE", DbType.DateTime, (GRADUATION_AWARD_DATE.HasValue ? (object)GRADUATION_AWARD_DATE : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PRESIDENT_APPROVAL_DATE", DbType.DateTime, (PRESIDENT_APPROVAL_DATE.HasValue ? (object)PRESIDENT_APPROVAL_DATE : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FAC_GRADUATION_AWARD_NUMBER", DbType.String, FAC_GRADUATION_AWARD_NUMBER);
            database.AddInParameter(commandWrapper, "@FAC_GRADUATION_AWARD_DATE", DbType.DateTime, (FAC_GRADUATION_AWARD_DATE.HasValue ? (object)FAC_GRADUATION_AWARD_DATE : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("ED_GRADUATION_AWARD_ID");
            table.Columns.Add("ED_STUD_GRADUATION_AWARD_ID");

            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("NATIONAL_NUMBER");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("GRADUATION_AWARD_NUMBER");
            table.Columns.Add("GRADUATION_AWARD_DATE");
            table.Columns.Add("PRESIDENT_APPROVAL_DATE");

            table.Columns.Add("DELIVERY_DATE");
             table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("IS_APPLIED");
            table.Columns.Add("CERT_STATUS_FLG");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(), reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString()};
                    table.Rows.Add(items);
                }
            }

            finally
            {
                commandWrapper = null;
            }

            return table;
        }

        public override bool UpdateAllGraduatesCertificates(TransactionManager transactionManager, decimal? EdStudId, decimal? EdAcadYearId, string GRADUATION_AWARD_NUMBER, DateTime? GRADUATION_AWARD_DATE, DateTime? PRESIDENT_APPROVAL_DATE, decimal? AsFacultyInfoId, string FAC_GRADUATION_AWARD_NUMBER, DateTime? FAC_GRADUATION_AWARD_DATE, DateTime? DELIVARY_DATE)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UpdateAllGraduatesCertificates", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, (EdStudId.HasValue ? (object)EdStudId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, (EdAcadYearId.HasValue ? (object)EdAcadYearId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GRADUATION_AWARD_NUMBER", DbType.String, GRADUATION_AWARD_NUMBER);
            database.AddInParameter(commandWrapper, "@GRADUATION_AWARD_DATE", DbType.DateTime, (GRADUATION_AWARD_DATE.HasValue ? (object)GRADUATION_AWARD_DATE : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PRESIDENT_APPROVAL_DATE", DbType.DateTime, (PRESIDENT_APPROVAL_DATE.HasValue ? (object)PRESIDENT_APPROVAL_DATE : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FAC_GRADUATION_AWARD_NUMBER", DbType.String, FAC_GRADUATION_AWARD_NUMBER);
            database.AddInParameter(commandWrapper, "@FAC_GRADUATION_AWARD_DATE", DbType.DateTime, (FAC_GRADUATION_AWARD_DATE.HasValue ? (object)FAC_GRADUATION_AWARD_DATE : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@updateDate", DbType.DateTime, (DELIVARY_DATE.HasValue ? (object)DELIVARY_DATE : System.DBNull.Value));

            int reader = 0;
            bool done = true;
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteNonQuery(database, commandWrapper);
                }
                done = true;
            }
            catch (Exception ex)
            {
                done = false;
            }
            finally
            {
                commandWrapper = null;
            }

            return done;
        }

        public override DataTable GetAllGraduationAwards(TransactionManager transactionManager, decimal? EdAcadYearId, decimal? SemsesterId, string GraduationAwardNumber, DateTime? GraduationAwardDate, DateTime? PresidentApprovalDate, decimal? AsFacultyInfoId, string FacGraduationAwardNumber, DateTime? FacGraduationAwardDate, decimal pageIndex, decimal pageSize, decimal? CodeDegree, decimal? CodeDegreeClass)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAllGraduationAwards", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, (EdAcadYearId.HasValue ? (object)EdAcadYearId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, (SemsesterId.HasValue ? (object)SemsesterId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GraduationAwardNumber", DbType.String, GraduationAwardNumber);
            database.AddInParameter(commandWrapper, "@GraduationAwardDate", DbType.DateTime, (GraduationAwardDate.HasValue ? (object)GraduationAwardDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PresidentApprovalDate", DbType.DateTime, (PresidentApprovalDate.HasValue ? (object)PresidentApprovalDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FacGraduationAwardNumber", DbType.String, FacGraduationAwardNumber);
            database.AddInParameter(commandWrapper, "@FacGraduationAwardDate", DbType.DateTime, (FacGraduationAwardDate.HasValue ? (object)FacGraduationAwardDate : System.DBNull.Value));
             database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
             database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);

             database.AddInParameter(commandWrapper, "@ASCODEDEGREEID", DbType.Decimal, CodeDegree);
             database.AddInParameter(commandWrapper, "@ASCODEDEGREECLASSID", DbType.Decimal, CodeDegreeClass);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("ED_GRADUATION_AWARD_ID");
            table.Columns.Add("GRADUATION_AWARD_DATE");     
            table.Columns.Add("GRADUATION_AWARD_NUMBER");            
            table.Columns.Add("PRESIDENT_APPROVAL_DATE");
            table.Columns.Add("NOTES");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("IS_APPLIED");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("FACULTY_GRADUATION_AWARD_NUMBER");
            table.Columns.Add("FACULTY_GRADUATION_AWARD_DATE");
            table.Columns.Add("StudentsCount");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(), reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString()
                                     ,reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString()};
                    table.Rows.Add(items);
                }
            }

            finally
            {
                commandWrapper = null;
            }

            return table;


            //try
            //{
            //    //Provider Data Requesting Command Event
            //    OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAllGraduationAwards"));

            //    if (transactionManager != null)
            //        return Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
            //    else
            //        return Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            //}
            //finally
            //{
            //    commandWrapper = null;
            //}

            //return null;
        }

        public override DataTable GetStudentsHoldForGrad(TransactionManager transactionManager, decimal? EdAcadYearId, decimal? EdCodeSemesterId, decimal? AsCodeDegreeClassId, decimal? AsCodeDegreeId, decimal? AsFacultyInfoId, decimal? EntDeptId, decimal? EntMajId, string StudCode, decimal pageIndex, decimal pageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentsHoldForGrad", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, (EdAcadYearId.HasValue ? (object)EdAcadYearId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, (EdCodeSemesterId.HasValue ? (object)EdCodeSemesterId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, (AsCodeDegreeClassId.HasValue ? (object)AsCodeDegreeClassId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, (AsCodeDegreeId.HasValue ? (object)AsCodeDegreeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntDeptId", DbType.Decimal, (EntDeptId.HasValue ? (object)EntDeptId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntMajId", DbType.Decimal, (EntMajId.HasValue ? (object)EntMajId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("Error"); //adde by mmq at 24-01-2016
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(),reader[5].ToString(),reader[6].ToString(),reader[7].ToString(), reader[8].ToString(), reader[9].ToString()};
                    table.Rows.Add(items);
                }
            }

            finally
            {
                commandWrapper = null;
            }

            return table;
        }

        public override DataTable GetStudentsGrad(TransactionManager transactionManager, decimal EdGraduationAwardId, decimal pageIndex, decimal pageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentsGrad", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdGraduationAwardId", DbType.Decimal, EdGraduationAwardId);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("ED_STUD_GRADUATION_AWARD_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("Major_AR");
            table.Columns.Add("Major_EN");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                       reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString()};
                    table.Rows.Add(items);
                }
            }

            finally
            {
                commandWrapper = null;
            }

            return table;
        }
	}
}