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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScTchngSlot"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScTchngSlotProvider: SqlScTchngSlotProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScTchngSlotProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScTchngSlotProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override DataTable IfSlotReserved(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemesterId, System.Decimal ScTchngSlotId)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHK_TCHNG_SLOT_USED", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@SC_TCHNG_SLOT_ID", DbType.Decimal, ScTchngSlotId);
            

            IDataReader reader = null;
            DataTable tmp = new DataTable();
            tmp.Columns.Add("Value");

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
                    object[] items = { reader[0].ToString()};
                    tmp.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;
        }
        //Marwa 14/2/2022
        public override DataTable IfSlotReservedForModular(TransactionManager transactionManager, System.Decimal ScTchngSlotId)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHK_TCHNG_SLOT_USED_for_Modular", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SC_TCHNG_SLOT_ID", DbType.Decimal, ScTchngSlotId);


            IDataReader reader = null;
            DataTable tmp = new DataTable();
            tmp.Columns.Add("Value");

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
                    object[] items = { reader[0].ToString() };
                    tmp.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;
        }

        /// <summary>
        /// Get Time Slotes for Day of week in selected Teaching Day
        /// </summary>
        /// <param name="_scTchngDayId">Teaching Day</param>
        /// <param name="_isActive">-1 for All</param>
        /// <param name="_examFlg">-1 for All</param>
        public override DataTable GetSlotes(TransactionManager transactionManager, System.Decimal _scTchngDayId, System.Decimal _isActive, System.Decimal _examFlg)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_TCHNG_SLOT_GetSlotes", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@scTchngDayId", DbType.Decimal, _scTchngDayId);
            database.AddInParameter(commandWrapper, "@isActive", DbType.Decimal, _isActive);
            database.AddInParameter(commandWrapper, "@examFlg", DbType.Decimal, _examFlg);


            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("SC_TCHNG_SLOT_ID");
            tbl.Columns.Add("DESCR_AR");
            tbl.Columns.Add("DESCR_EN");
            tbl.Columns.Add("FROM_TIME");
            tbl.Columns.Add("TO_TIME");
            

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
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
        #endregion

        public override TList<ScTchngSlot> getSlotsInPeriod(TransactionManager transactionManager, System.Decimal rdlTiming, System.Decimal ?AsFacultyInfoId, System.Decimal? EdCodeSemesterId, System.Decimal? EdAcadYearId)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SELECTALLSlotsInPeriod", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@timingflg", DbType.Decimal, rdlTiming);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId.HasValue ? (object)EdCodeSemesterId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId.HasValue ? (object)EdAcadYearId : DBNull.Value);


            IDataReader reader = null;
            TList<ScTchngSlot> rows = new TList<ScTchngSlot>();


            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SELECTALLSlotsInPeriod", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }
                int start = 0;
                int pageLength = int.MaxValue;
                int count = int.MaxValue;
                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                OnDataRequested(new CommandEventArgs(commandWrapper, "SELECTALLSlotsInPeriod", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override DataTable CheckTimeSlotInPeriod(TransactionManager transactionManager, System.Decimal? SC_TCHNG_SLOT_ID, DateTime FROM_TIME, DateTime TO_TIME, System.Decimal? EXAM_FLG, System.Decimal? ScSchdlPeriodId)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHECKTIMESLOTInPeriod", UseStoredProcedure);



            database.AddInParameter(commandWrapper, "EXAM_FLG", DbType.Decimal, EXAM_FLG.HasValue ? (object)EXAM_FLG : DBNull.Value);
            database.AddInParameter(commandWrapper, "SC_TCHNG_SLOT_ID", DbType.Decimal, SC_TCHNG_SLOT_ID.HasValue ? (object)SC_TCHNG_SLOT_ID : DBNull.Value);
            database.AddInParameter(commandWrapper, "FROM_TIME", DbType.DateTime, FROM_TIME);
            database.AddInParameter(commandWrapper, "TO_TIME", DbType.DateTime, TO_TIME);
            database.AddInParameter(commandWrapper, "ScSchdlPeriodId", DbType.Decimal, ScSchdlPeriodId.HasValue ? (object)ScSchdlPeriodId : DBNull.Value);


            IDataReader reader = null;
            DataTable tbl = new DataTable();
            tbl.Columns.Add("SC_TCHNG_SLOT_ID");
            tbl.Columns.Add("DESCR_AR");
            tbl.Columns.Add("DESCR_EN");
            tbl.Columns.Add("FROM_TIME");
            tbl.Columns.Add("TO_TIME");
            tbl.Columns.Add("SC_SCHDL_PERIOD_ID");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
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
       //added  by esraa yousef 17898 21-2-2022 EUE
        public override TList<ScTchngSlot> GetSlotesInDayes_Mod(TransactionManager transactionManager, System.Decimal? ScSchdlPerodId)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSlotesInDayes_Mod", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SC_SCHDL_PERIOD_ID", DbType.Decimal, ScSchdlPerodId);
        

            IDataReader reader = null;
            TList<ScTchngSlot> rows = new TList<ScTchngSlot>();


            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetSlotesInDayes_Mod", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }
                int start = 0;
                int pageLength = int.MaxValue;
                int count = int.MaxValue;
                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetSlotesInDayes_Mod", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        

    }
}