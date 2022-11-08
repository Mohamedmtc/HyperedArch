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
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="GsCodeWeekDay"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlGsCodeWeekDayProvider: SqlGsCodeWeekDayProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlGsCodeWeekDayProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlGsCodeWeekDayProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetStaffDays(TransactionManager transactionManager,System.Decimal SaStfMemId,System.Decimal EdAcadYearId,System.Decimal EdCodeSemId,System.Decimal GsCodeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStaffTeachingDays", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@SastfMemberId", DbType.Decimal, SaStfMemId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemId", DbType.Decimal, EdCodeSemId);
            database.AddInParameter(commandWrapper, "@gsCodeId", DbType.Decimal, GsCodeId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
         
            table.Columns.Add("GS_CODE_WEEK_DAY_ID");

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

        public override decimal CheckStaffDaysTime(TransactionManager transactionManager, System.Decimal SaStfMemId, System.Decimal EdAcadYearId, System.Decimal EdCodeSemId, System.String DatesXml)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CHK_ADD_STF_DATETIME", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, EdCodeSemId);
            database.AddInParameter(commandWrapper, "@SA_STF_MEMBER_ID", DbType.Decimal, SaStfMemId);
            database.AddInParameter(commandWrapper, "@DATES_TIMES", DbType.Xml, DatesXml);
            



            int results = 0;

            //Provider Data Requesting Command Event
         //   OnDataRequesting(new CommandEventArgs(commandWrapper, "CheckStaffDaysTime", entity));

            if (transactionManager != null)
            {
                if (Utility.ExecuteScalar(database, commandWrapper) != null)
                    results = (int)Utility.ExecuteScalar(transactionManager, commandWrapper);
                else
                    results = 0;
            }
            else
            {
                if (Utility.ExecuteScalar(database, commandWrapper) != null)
                results =(int) Utility.ExecuteScalar(database, commandWrapper);
                else
                    results = 0;
            }

            return results;
           // entity.OriginalEdStudId = entity.EdStudId;

          //  entity.AcceptChanges();

            //Provider Data Requested Command Event
            //OnDataRequested(new CommandEventArgs(commandWrapper, "ED_STUD_InsertWithIdOut", entity));
            //return Convert.ToDecimal(commandWrapper.Parameters["@EdStudId"].Value);
        }
    }
}