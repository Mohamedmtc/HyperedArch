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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudClrncReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudClrncReqProvider: SqlEdStudClrncReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudClrncReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudClrncReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods


        public override decimal InsertWithIdOut(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudClrncReq entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_CLRNC_REQ_InsertWithId", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudClrncReqId", DbType.Decimal, 7);
            database.AddInParameter(commandWrapper, "@ReqDate", DbType.DateTime, (entity.ReqDate.HasValue ? (object)entity.ReqDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ReqStatusDate", DbType.DateTime, (entity.ReqStatusDate.HasValue ? (object)entity.ReqStatusDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, (entity.EdStudSemesterId.HasValue ? (object)entity.EdStudSemesterId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCdeClrncReasonId", DbType.Decimal, entity.GsCdeClrncReasonId);
            database.AddInParameter(commandWrapper, "@GsCodeReqStatusId", DbType.Decimal, entity.GsCodeReqStatusId);
            database.AddInParameter(commandWrapper, "@WithdrawDate", DbType.DateTime, (entity.WithdrawDate.HasValue ? (object)entity.WithdrawDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@WithdrawName", DbType.String, entity.WithdrawName);
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertWithIdOut", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            entity.OriginalEdStudClrncReqId = entity.EdStudClrncReqId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "InsertWithIdOut", entity));

            return Convert.ToDecimal(commandWrapper.Parameters["@EdStudClrncReqId"].Value);
        }


        public override DataTable SearchStudClearReq(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal _AsFacultyId, System.DateTime? _ReqFromDate, System.DateTime? _ReqToDate, System.Decimal? _GsCodeClearReasonId
            , System.Decimal? _GsCodeReqStatusId,System.String StudCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchStudClearReq", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ReqFromDate", DbType.DateTime, _ReqFromDate);
            database.AddInParameter(commandWrapper, "@ReqToDate", DbType.DateTime, _ReqToDate);

            database.AddInParameter(commandWrapper, "@EdAcadyearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            database.AddInParameter(commandWrapper, "@AsFacultyId", DbType.Decimal, _AsFacultyId);
            database.AddInParameter(commandWrapper, "@GsCodeClrnReasonId", DbType.Decimal, _GsCodeClearReasonId);

            database.AddInParameter(commandWrapper, "@GsCodeReqStatusId", DbType.Decimal, _GsCodeReqStatusId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudCode");
            table.Columns.Add("StudNameAr");
            table.Columns.Add("StudNameEn");
            table.Columns.Add("LevelDescAr");
            table.Columns.Add("LevelDescEn");

            table.Columns.Add("DeptDescrAr");
            table.Columns.Add("DeptDescrEn");

            table.Columns.Add("ReqStatusAr");
            table.Columns.Add("ReqStatusEn");
            table.Columns.Add("WithdrawDate");
            table.Columns.Add("EdStudClrncReqId");
            table.Columns.Add("GsCodeReqStatusId");
            try
            {
                //Provider Data Requesting Command Event
                // OnDataRequesting(new CommandEventArgs(commandWrapper, "SearchStudClearReq", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                                         reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                                         reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString()};
                        table.Rows.Add(items);
                    }
                }

                ////Create Collection
                //Fill(reader, rows, start, pageLength);
                //count = -1;
                //if (reader.NextResult())
                //{
                //    if (reader.Read())
                //    {
                //        count = reader.GetInt32(0);
                //    }
                //}

                ////Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "SearchStudClearReq", rows));
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