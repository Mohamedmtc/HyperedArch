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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCourseEquiv"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdCourseEquivProvider: SqlEdCourseEquivProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdCourseEquivProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdCourseEquivProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        public override DataTable GetCourseEquivalents(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edSemesterId, System.Decimal courseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GET_COURSE_EQUIVALENTS", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, edSemesterId);
            database.AddInParameter(commandWrapper, "@COURSE_ID", DbType.Decimal, courseId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ENT_MAIN_ID");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString()};
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

        #region Updated Procedures

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseEquiv entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_EQUIV_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseEquivId", DbType.Decimal, entity.EdCourseEquivId);
            database.AddInParameter(commandWrapper, "@EdEquivCourseId", DbType.Decimal, entity.EdEquivCourseId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);

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


            entity.OriginalEdCourseEquivId = entity.EdCourseEquivId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        #endregion
    }
}