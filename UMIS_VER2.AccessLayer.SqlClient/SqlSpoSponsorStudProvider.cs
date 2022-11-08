#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SpoSponsorStud"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSpoSponsorStudProvider: SqlSpoSponsorStudProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSpoSponsorStudProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSpoSponsorStudProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Updated Methods

        //public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorStud entity)
        //{
        //    SqlDatabase database = new SqlDatabase(this.ConnectionString);
        //    DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SPO_SPONSOR_STUD_Insert", UseStoredProcedure);

        //    database.AddInParameter(commandWrapper, "@SpoSponsorStudId", DbType.Decimal, entity.SpoSponsorStudId);
        //    database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, (entity.EdStudId.HasValue ? (object)entity.EdStudId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@SpoSponsorId", DbType.Decimal, entity.SpoSponsorOfferId);
        //    database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
        //    database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
        //    database.AddInParameter(commandWrapper, "@Percentage", DbType.Byte, entity.Percentage);
        //    database.AddInParameter(commandWrapper, "@Amount", DbType.Decimal, entity.Amount);
        //    database.AddInParameter(commandWrapper, "@IsApproved", DbType.Decimalentity.IsApproved);

        //    int results = 0;

        //    //Provider Data Requesting Command Event
        //    OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));

        //    if (transactionManager != null)
        //    {
        //        results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
        //    }
        //    else
        //    {
        //        results = Utility.ExecuteNonQuery(database, commandWrapper);
        //    }

        //    entity.SpoSponsorStudId = decimal.Parse(commandWrapper.Parameters["@SpoSponsorStudId"].Value.ToString());
        //    entity.OriginalSpoSponsorStudId = entity.SpoSponsorStudId;

        //    entity.AcceptChanges();

        //    //Provider Data Requested Command Event
        //    OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

        //    return Convert.ToBoolean(results);
        //}

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="_spoSponsorStudId">. Primary Key.</param>	
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override bool Delete(TransactionManager transactionManager, System.Decimal _spoSponsorStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SPO_SPONSOR_STUD_Delete", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SpoSponsorStudId", DbType.Decimal, _spoSponsorStudId);

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
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorStud)
                    , _spoSponsorStudId);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Delete"));

            commandWrapper = null;

            return Convert.ToBoolean(results);
        }//end Delete

        #endregion

        #region Custom Methods

        public override DataTable GetSponsorStudents(TransactionManager transactionManager, decimal spoSponsorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSponsorStudents", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SpoSponsorId", DbType.Decimal, spoSponsorId);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("SPO_SPONSOR_ID");
            table.Columns.Add("SPO_SPONSOR_STUD_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("PERCENTAGE");
            table.Columns.Add("IS_APPROVED");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("AMOUNT");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");

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
                    object[] items = { 
                                         reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                                         reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                         reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),
                                         reader[9].ToString(), reader[10].ToString()
                                     };
                    table.Rows.Add(items);
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

        public override TList<SpoSponsorStud> GetStudentSponsered(TransactionManager transactionManager,  decimal? edAcadYearId, decimal? edCodeSemesterId, decimal? spoSponsorId,  decimal? GsCountryNodeId, decimal? AsFacultyInfoId, decimal? EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentSponsered", this.UseStoredProcedure);



            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId.HasValue ? (object)edAcadYearId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemester", DbType.Decimal, edCodeSemesterId.HasValue ? (object)edCodeSemesterId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId.HasValue ? (object)EntMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@gsCountryNodeId", DbType.Decimal, GsCountryNodeId.HasValue ? (object)GsCountryNodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@spoSponsorId", DbType.Decimal, spoSponsorId.HasValue ? (object)spoSponsorId : DBNull.Value);


            IDataReader reader = null;
            TList<SpoSponsorStud> rows = new TList<SpoSponsorStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentSponsered", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                int count = -1;
                int start = 0;
                int pageLength = int.MaxValue;
                Fill(reader, rows, start, pageLength);
              
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentSponsered", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        #endregion
	}
}