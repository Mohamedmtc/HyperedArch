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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScScheduleCrossList"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScScheduleCrossListProvider: SqlScScheduleCrossListProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScScheduleCrossListProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScScheduleCrossListProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region "GetScheduleDetails"
        public override DataTable GetScheduleDetails(TransactionManager transactionManager, System.Decimal ED_COURSE_ID,
            System.Decimal? ED_CODE_COURSE_TEACHING_ID, System.Decimal ED_ACAD_YEAR_ID, System.Decimal SemesterId)         
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetScheduleDetails", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CourseId", DbType.Decimal, ED_COURSE_ID);
            database.AddInParameter(commandWrapper, "@TeachingId", DbType.Decimal, ED_CODE_COURSE_TEACHING_ID);
            database.AddInParameter(commandWrapper, "@AcdYear", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@SemesterId", DbType.Decimal, SemesterId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
                     
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
        #endregion

        #region "GetComboBData"
        public override DataTable GetComboBData(TransactionManager transactionManager, System.Decimal ED_COURSE_ID,
            System.Decimal ED_CODE_COURSE_TEACHING_ID, System.Decimal ED_ACAD_YEAR_ID, System.Decimal SemesterId, System.Decimal? SA_STF_MAMBER_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetComboBData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CourseId", DbType.Decimal, ED_COURSE_ID);
            database.AddInParameter(commandWrapper, "@TeachingId", DbType.Decimal, ED_CODE_COURSE_TEACHING_ID);
            database.AddInParameter(commandWrapper, "@AcdYear", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@SemesterId", DbType.Decimal, SemesterId);
            database.AddInParameter(commandWrapper, "@StfMemberId", DbType.Decimal, SA_STF_MAMBER_ID);
            
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
             
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString()};
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
        #endregion
	}
}