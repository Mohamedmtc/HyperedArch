#region Using directives

using System;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using UMIS_VER2.AccessLayer.Bases;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudCourseRegPre"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudCourseRegPreProvider: SqlEdStudCourseRegPreProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudCourseRegPreProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudCourseRegPreProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetStudEarlyReg(TransactionManager transactionManager, System.Decimal EdAcadYearID,System.Decimal EdCodeSemesterId,
                                                System.Decimal AsFacultyInfoId, System.Decimal EntMainId,
                                                System.String CourseCode, System.String StudCode )
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudEarlyReg", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@Course_Code", DbType.String, CourseCode);
            database.AddInParameter(commandWrapper, "@stud_Code", DbType.String, StudCode);

            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudEarlyReg"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudEarlyReg"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

	}
}