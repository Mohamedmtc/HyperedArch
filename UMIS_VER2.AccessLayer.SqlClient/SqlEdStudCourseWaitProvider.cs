#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudCourseWait"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudCourseWaitProvider: SqlEdStudCourseWaitProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudCourseWaitProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudCourseWaitProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Custom Methods
        public override DataSet GetStudentCourseWaitList(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _EdCourseID, System.Decimal? _ScScheduleDtlID, System.Decimal? _EntityMainId, System.Decimal _Asc, System.Decimal _OrderColumn)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SP_Get_Ed_Stud_Course_Wait", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, _EdCourseID);
            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_DTL_ID", DbType.Decimal, _ScScheduleDtlID);
            database.AddInParameter(commandWrapper, "@ENT_MAIN_ID", DbType.Decimal, _EntityMainId);
            database.AddInParameter(commandWrapper, "@Asc", DbType.Decimal, _Asc);
            database.AddInParameter(commandWrapper, "@OrderColumn", DbType.Decimal, _OrderColumn);

            DataSet ds = null;

            try
            {
                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return ds;
        }

        public override bool DeleteStudentCourseWaitList(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal? _EdCourseID, System.Decimal? _ScScheduleDtlID, System.Decimal? _EntityMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SP_Delete_Ed_Stud_Course_Wait", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ED_COURSE_ID", DbType.Decimal, _EdCourseID);
            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_DTL_ID", DbType.Decimal, _ScScheduleDtlID);
            database.AddInParameter(commandWrapper, "@ENT_MAIN_ID", DbType.Decimal, _EntityMainId);

            int result = 0;
            try
            {
                if (transactionManager != null)
                {
                    result = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    result = Utility.ExecuteNonQuery(database, commandWrapper);
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return result > 0;
        }
        #endregion
    }
}