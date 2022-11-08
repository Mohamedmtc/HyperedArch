#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScScheduleDtlExtStf"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScScheduleDtlExtStfProvider: SqlScScheduleDtlExtStfProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScScheduleDtlExtStfProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScScheduleDtlExtStfProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetStaffMemberFromTimeState(TransactionManager transactionManager, decimal? StfMemberId, decimal? weekDayId, 
            DateTime? FromTime, decimal? SC_SCHEDULE_DTL_EXT_STF_ID, decimal? SC_SCHEDULE_DTL, decimal EdCodeSemesterID,decimal? EdAcadYearID,
            DateTime? FromDate, DateTime? ToDate, DateTime? ToTime)
        {
            //  count = 0;

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStaffMemberFromTimeState", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, (FromTime.HasValue ? (object)FromTime : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfMemberId", DbType.Decimal, StfMemberId);
            database.AddInParameter(commandWrapper, "@WeekDayId", DbType.Decimal, weekDayId);
            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_DTL_EXT_STF_ID", DbType.Decimal, SC_SCHEDULE_DTL_EXT_STF_ID);
            database.AddInParameter(commandWrapper, "@SC_SCHEDULE_DTL", DbType.Decimal, SC_SCHEDULE_DTL);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@EDAcadYearID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@FromDate", DbType.DateTime, (FromDate.HasValue ? (object)FromDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ToDate", DbType.DateTime, (ToDate.HasValue ? (object)ToDate : System.DBNull.Value));
            //eman moustafa date_3_4_2022
            database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, (ToTime.HasValue ? (object)ToTime : System.DBNull.Value));


            IDataReader reader = null;
            DataTable table = new DataTable();


            table.Columns.Add("SA_STF_MEMBER_ID");
            table.Columns.Add("STF_CODE");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("GS_CODE_WEEK_DAY_ID");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),reader[5].ToString() ,
                                             reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),reader[9].ToString()
                                         };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),reader[5].ToString() ,
                                             reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),reader[9].ToString()
                                         };
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
        //Marwa 21/4/2022 18220
        public override DataTable GetStfMemberTimesPeriod(TransactionManager transactionManager, decimal StfMemberId, decimal? weekDayId,
           DateTime? FromTime, decimal EdCodeSemesterID, decimal? EdAcadYearID,DateTime? ToTime)
        {

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStfMemberTimesPeriod", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@StfMemberId", DbType.Decimal, StfMemberId);
            database.AddInParameter(commandWrapper, "@weekDayId", DbType.Decimal, weekDayId);
            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@NewSchdeulFromTime", DbType.DateTime,FromTime);
            database.AddInParameter(commandWrapper, "@NewSchdeulToTime", DbType.DateTime,ToTime);


            IDataReader reader = null;
            DataTable table = new DataTable();


            table.Columns.Add("ConflictFlag");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString()};
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