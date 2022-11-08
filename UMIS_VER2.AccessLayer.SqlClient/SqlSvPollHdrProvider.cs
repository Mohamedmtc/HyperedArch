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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SvPollHdr"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSvPollHdrProvider: SqlSvPollHdrProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSvPollHdrProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSvPollHdrProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override bool DeleteAllRelatedData(TransactionManager transactionManager, System.Decimal _svPollHdrId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_POLL_HDR_DeleteAllRelatedData", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SvPollHdrId", DbType.Decimal, _svPollHdrId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete"));

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //Stop Tracking Now that it has been updated and persisted.
            if (DataRepository.Provider.EnableEntityTracking)
            {
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(SvPollHdr)
                    , _svPollHdrId);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Delete"));

            commandWrapper = null;

            return Convert.ToBoolean(results);
        }
        public override decimal GetLastOne(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_POLL_HDR_GetLastOne", this.UseStoredProcedure);

            decimal id = 0;
            IDataReader reader = null;

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        id = decimal.Parse(reader[0].ToString());
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        id = decimal.Parse(reader[0].ToString());
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return id;

        }
        public override DataTable GetForView(TransactionManager transactionManager, System.Decimal _SeUserId, decimal studStaffFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_POLL_HDR_GetForView", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, _SeUserId);
            database.AddInParameter(commandWrapper, "@StudStaffFlg", DbType.Decimal, studStaffFlg);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SvPollHdrId");
            table.Columns.Add("PollText");
            table.Columns.Add("PollDate");
            table.Columns.Add("StudCount");
            table.Columns.Add("StaffCount");
            table.Columns.Add("PubFlg");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
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
        public override DataTable GetForStudView(TransactionManager transactionManager,System.Decimal EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_POLL_HDR_GetForStudView", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, EdStudId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_POLL_HDR_ID");
            table.Columns.Add("POLL_TEXT");
            table.Columns.Add("POLL_DATE");
            table.Columns.Add("DUE_DATE");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("NODE_PATH");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("SC_DEG_DESCR_AR");
            table.Columns.Add("SC_DEG_DESCR_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
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

        public override DataTable GetForStaffView(TransactionManager transactionManager, System.Decimal StaffId, System.Decimal AcadYearId, System.Decimal SemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_SV_POLL_HDR_GetForStaffView", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SaStfMemberID", DbType.Decimal, StaffId);
            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, AcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, SemesterId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_POLL_HDR_ID");
            table.Columns.Add("POLL_TEXT");
            table.Columns.Add("POLL_DATE");
            table.Columns.Add("DUE_DATE");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("SC_DEG_DESCR_AR");
            table.Columns.Add("SC_DEG_DESCR_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString()};
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
        public override DataTable GetStudOptionForPoll(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _SvPollHdrId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_POLL_DTL_GetStudOptionForPoll", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@SvPollHdrId", DbType.Decimal, _SvPollHdrId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_POLL_DTL_ID");

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
            return table;

        }

        public override DataTable GetStaffOptionForPoll(TransactionManager transactionManager, System.Decimal StfMemberId, System.Decimal _SvPollHdrId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_POLL_DTL_GetStaffOptionForPoll", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStaffMember", DbType.Decimal, StfMemberId);
            database.AddInParameter(commandWrapper, "@SvPollHdrId", DbType.Decimal, _SvPollHdrId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_POLL_DTL_ID");

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
            return table;

        }
        public override DataTable GetUserPoll(TransactionManager transactionManager, System.Decimal _SeUserId, System.Decimal _SvPollHdrId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_STUD_POLL_GetBySvPollHdrIdAndSeUserId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, _SeUserId);
            database.AddInParameter(commandWrapper, "@SvPollHdrId", DbType.Decimal, _SvPollHdrId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_STUD_POLL_ID");

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
            return table;

        }
        #endregion
    }
}