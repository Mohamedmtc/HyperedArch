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

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeRefundCodeDtl"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeRefundCodeDtlProvider: SqlFeeRefundCodeDtlProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeRefundCodeDtlProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeRefundCodeDtlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        //added by mmq at 2-05-2017
        public override DataTable GetFeeRefundCodeDtlByFeeRefundCodeId_custum(TransactionManager transactionManager, decimal FeeRefundCodeId, string FeeType, decimal lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFeeRefundCodeDtlByFeeRefundCodeId_custum", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FeeRefundCodeId", DbType.Decimal, FeeRefundCodeId);
            database.AddInParameter(commandWrapper, "@FeeType", DbType.String, FeeType);
            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, lang);

            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("FEE_REFUND_CODE_DTL_ID");
            dt.Columns.Add("FEE_REFUND_CODE_ID");
            dt.Columns.Add("FEE_CODE_ITEM_ID");
            dt.Columns.Add("DUE_DATE");
            dt.Columns.Add("RFND_PRCNT");
            dt.Columns.Add("FEE_CODE_ITEM_RLT_ID");
            dt.Columns.Add("FEE_CODE_ITEM_PNFT_ID");
            dt.Columns.Add("ADM_CDE_FEE_ID");
            dt.Columns.Add("FeeDescr");
            dt.Columns.Add("RtlFeeDescr");
            dt.Columns.Add("PenfFeeDescr");

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFeeRefundCodeDtlByFeeRefundCodeId_custum"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetFeeRefundCodeDtlByFeeRefundCodeId_custum"));

            return dt;
        }
        public override DataTable DeployRefundRule(TransactionManager transactionManager, decimal EdStudId, decimal facultyID,decimal edAcadYearId, decimal EdCodeSemesterId, decimal CurrentYear , decimal CurrentSemester, DateTime? ReqDate ,decimal Lang, decimal FeeRefundReqId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Sp_Deploy_Refund_Rule_new", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, EdStudId);
            database.AddInParameter(commandWrapper, "@facultyID", DbType.Decimal, facultyID);
            database.AddInParameter(commandWrapper, "@currentYearID", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@currentSemID", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@currentOpenAcadYear", DbType.Decimal, CurrentYear);
            database.AddInParameter(commandWrapper, "@currentOpenSemester", DbType.Decimal, CurrentSemester);
            database.AddInParameter(commandWrapper, "@ReqDate", DbType.DateTime, ReqDate);
            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, Lang);
            database.AddInParameter(commandWrapper, "@FeeRefundReqId", DbType.Decimal, FeeRefundReqId);
           
            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("FEE_CODE_ITEM_ID");
            dt.Columns.Add("FEE_ITEM_VALUE");
            dt.Columns.Add("FEE_STUD_FEE_ITEM_ID");
            dt.Columns.Add("FeeCodeItemPnft");
            dt.Columns.Add("FeeCodeItemRelated");
            dt.Columns.Add("ItemDescr");
            dt.Columns.Add("PayedAmount");
            dt.Columns.Add("RFNDVALUE");
            dt.Columns.Add("Notes");
            dt.Columns.Add("FEE_REFUND_CODE_Id");
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFeeRefundCodeDtlByFeeRefundCodeId_custum"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()  };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetFeeRefundCodeDtlByFeeRefundCodeId_custum"));

            return dt;
        }

    }
}