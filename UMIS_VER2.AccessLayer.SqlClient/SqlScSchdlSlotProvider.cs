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

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScSchdlSlot"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScSchdlSlotProvider: SqlScSchdlSlotProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScSchdlSlotProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScSchdlSlotProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        /* -- copy from nub  task 15565 --- maha */
        public override TList<ScSchdlSlot> GetSchdlSlot(TransactionManager transactionManager, System.DateTime _DayDate, System.Decimal _ScTchngSlotId, System.Decimal _GsCodeWeekDayId, System.Decimal _ScGroupInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSchdlSlot", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@DayDate", SqlDbType.Date, _DayDate);
            database.AddInParameter(commandWrapper, "@ScTchngSlotId", SqlDbType.Decimal, _ScTchngSlotId);
            database.AddInParameter(commandWrapper, "@GsCodeWeekDayId", SqlDbType.Decimal, _GsCodeWeekDayId);
            database.AddInParameter(commandWrapper, "@ScGroupInfoId", SqlDbType.Decimal, _ScGroupInfoId);
            IDataReader reader = null;

            //Create Collection
            TList<ScSchdlSlot> rows = new TList<ScSchdlSlot>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetSchdlSlot", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, 0, 10);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetApplicantsForDistribution", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }//end getall

        /*---- added by maha 5-4-2021 --show also teaching method ----*/
        public override DataTable GetSlotContent_Schdule(TransactionManager transactionManager, decimal _objSchdlSlotID)
        {

            SqlConnection conn = new SqlConnection(this.ConnectionString);
            SqlCommand command = new SqlCommand("dbo.GetSlot_Schdule_Content", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SchdlSlotID", DbType.Decimal).Value = _objSchdlSlotID;

            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            return table;
        }
    }
}