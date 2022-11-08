#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScSchdlPeriod"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScSchdlPeriodProvider: SqlScSchdlPeriodProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScSchdlPeriodProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScSchdlPeriodProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        
        //Added by nashassan 16/10/2016: override the original insert function to retreive ScSchdlPeriodId after insert
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlPeriod entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_SCHDL_PERIOD_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper,"@ScSchdlPeriodId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, entity.AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@SchdlPeriodAr", DbType.String, entity.SchdlPeriodAr);
            database.AddInParameter(commandWrapper, "@SchdlPeriodEn", DbType.String, entity.SchdlPeriodEn);
            database.AddInParameter(commandWrapper, "@PeriodFrom", DbType.DateTime, (entity.PeriodFrom.HasValue ? (object)entity.PeriodFrom : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PeriodTo", DbType.DateTime, (entity.PeriodTo.HasValue ? (object)entity.PeriodTo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntMainMjrId", DbType.Decimal, (entity.EntMainMjrId.HasValue ? (object)entity.EntMainMjrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));

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

            entity.ScSchdlPeriodId = decimal.Parse(commandWrapper.Parameters["@ScSchdlPeriodId"].Value.ToString());
            entity.OriginalScSchdlPeriodId = entity.ScSchdlPeriodId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }


        /*----task 11634  -- copy from nub  task 15565*/
        public override DataTable GetScSchdlPeriodByCodeSem_Acadyear(TransactionManager transactionManager, decimal CodeSemstID, decimal AcadyearID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("GetScSchdlPeriodBySem_Acadyear", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("EdAcadYearId", SqlDbType.Decimal).Value = AcadyearID;
            command.Parameters.Add("EdCodeSemesterId", SqlDbType.Decimal).Value = CodeSemstID;
            //command.Parameters.Add("EntMainId", SqlDbType.Decimal).Value = EntMainId;
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();

            return table;
        }
        /*-- copy from nub  task 15565 -- maha ----*/
        public override DataTable SelectAllDaysbySchedlePeriod(TransactionManager transactionManager, decimal SechdulePeriodID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("SelectAllDaysbySchedlePeriod", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("SchdulePerdID", SqlDbType.Decimal).Value = SechdulePeriodID;

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();

            return table;
        }
	}
}