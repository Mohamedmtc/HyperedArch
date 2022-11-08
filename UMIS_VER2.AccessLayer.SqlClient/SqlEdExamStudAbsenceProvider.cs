#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using UMIS_VER2.BusinessLyer;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdExamStudAbsence"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdExamStudAbsenceProvider: SqlEdExamStudAbsenceProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdExamStudAbsenceProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdExamStudAbsenceProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Method
        public override DataTable GetExamStudentAbsenceData(TransactionManager transactionManager, decimal _EdAcadYearId, decimal _EdCodeSemesterId,
                            decimal StudID, decimal ExamTypeID, decimal CourseID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetExamStudAbsenceData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CrsID", DbType.Decimal, CourseID);
            database.AddInParameter(commandWrapper, "@StudID", DbType.Decimal, StudID);
            database.AddInParameter(commandWrapper, "@AcadYearID", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@CodeSemsID", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ExamTypeID", DbType.Decimal, ExamTypeID);

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
        #endregion
    }
}