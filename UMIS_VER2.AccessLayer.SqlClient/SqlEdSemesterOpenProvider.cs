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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdSemesterOpen"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdSemesterOpenProvider: SqlEdSemesterOpenProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdSemesterOpenProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdSemesterOpenProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        public override bool SP_UpdateSetCurrentSem(TransactionManager transactionManager, System.Decimal _ACD_YEAR, System.Decimal _ED_CODE_SEMESTER_ID, System.Decimal _ent_main_id, decimal? AsCodeDegreeClassId)
        {


            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SP_UpdateSetCurrentSem", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ACD_YEAR", DbType.Decimal, _ACD_YEAR);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, _ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@ent_main_id", DbType.Decimal, _ent_main_id);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "SP_UpdateSetCurrentSem"));

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
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EdSemesterOpen),_ACD_YEAR,_ED_CODE_SEMESTER_ID,_ent_main_id);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "SP_UpdateSetCurrentSem"));

            commandWrapper = null;

            return Convert.ToBoolean(results);
        }//end Delete


        public override bool DeleteAllSemesterAgenda(TransactionManager transactionManager, System.Decimal _edSemesterOpenId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.DeleteAllSemesterAgenda", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdSemesterOpenId", DbType.Decimal, _edSemesterOpenId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "DeleteAllSemesterAgenda"));

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
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EdSemesterOpen)
                    , _edSemesterOpenId);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "DeleteAllSemesterAgenda"));

            commandWrapper = null;

            return Convert.ToBoolean(results);
        }//end Delete

        public override decimal ImportFromPreviousAgenda(TransactionManager transactionManager, System.Decimal _edSemesterOpenId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ImportFromPreviousAgenda", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdSemesterOpenId", DbType.Decimal, _edSemesterOpenId);
            database.AddOutParameter(commandWrapper, "@PrevEdSemesterOpen", DbType.Decimal, 5);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "ImportFromPreviousAgenda"));

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
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EdSemesterOpen)
                    , _edSemesterOpenId);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "ImportFromPreviousAgenda"));

            //commandWrapper = null;

            return Convert.ToDecimal(commandWrapper.Parameters["@PrevEdSemesterOpen"].Value);
        }//end Delete


        public override bool ImportFromPreviousSem(TransactionManager transactionManager, System.Decimal _edSemesterOpenId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Agenda_ImportFromPrevSem", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdSemesterOpenId", DbType.Decimal, _edSemesterOpenId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "ImportFromPreviousSem"));

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
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EdSemesterOpen)
                    , _edSemesterOpenId);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "ImportFromPreviousSem"));

            commandWrapper = null;

            return Convert.ToBoolean(results);
        }//end Delete


        public override DataTable CheckDepartmentsResultApproved(TransactionManager transactionManager, System.Decimal _edSemesterOpenId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CheckDepartmentsResultApproved", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdSemesterOpenId", DbType.Decimal, _edSemesterOpenId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "CheckDepartmentsResultApproved"));

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("ent_main_id");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("GROUP_ORDER");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
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
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         , reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()
                                         , reader[10].ToString(), reader[11].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         , reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()
                                         , reader[10].ToString(), reader[11].ToString()};
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

        public override UMIS_VER2.BusinessLyer.EdSemesterOpen GetForIncompleteScoring(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_SEM_OPEN_ForIncompScoring", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            IDataReader reader = null;
            TList<EdSemesterOpen> tmp = new TList<EdSemesterOpen>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_SEM_OPEN_ForIncompScoring", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                int start = 0;
                int pageLength = 1;
                Fill(reader, tmp, start, pageLength);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "ED_SEM_OPEN_ForIncompScoring", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (tmp.Count == 1)
            {
                return tmp[0];
            }
            else if (tmp.Count == 0)
            {
                return null;
            }
            else
            {
                throw new DataException("Cannot find the unique instance of the class.");
            }

            //return rows;
        }
        #endregion

	}
}