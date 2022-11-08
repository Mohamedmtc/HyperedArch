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
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeStudVoucher"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlFeeStudVoucherProvider : SqlFeeStudVoucherProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlFeeStudVoucherProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlFeeStudVoucherProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Custom Methods
        public override DataTable GetDetailedItems(TransactionManager transactionManager, decimal feeStudVoucherID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_STUD_VOUCHER_GetDetailedItems", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FeeStudVoucherID", DbType.Decimal, feeStudVoucherID);

            DataTable dt = new DataTable();

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetDetailedItems"));

            if (transactionManager != null)
            {
                dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
            }
            else
            {
                dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetDetailedItems"));

            return dt;
        }
        public override decimal GetTotalPayment(TransactionManager transactionManager, decimal edStudID, decimal asFacultyID, decimal edAcadYearID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_STUD_VOUCHER_GetTotalPayment", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, edStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyID", DbType.Decimal, asFacultyID);
            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, edAcadYearID);

            decimal val = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetTotalPayment"));

            if (transactionManager != null)
            {
                val = Convert.ToDecimal(Utility.ExecuteScalar(transactionManager, commandWrapper));
            }
            else
            {
                val = Convert.ToDecimal(Utility.ExecuteScalar(database, commandWrapper));
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetTotalPayment"));

            return val;
        }
        public override void DeleteByVoucherID(decimal VoucherID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.DeleteByVoucherID", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@VoucherID", DbType.Decimal, VoucherID);
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "DeleteByVoucherID"));
            Utility.ExecuteNonQuery(database, commandWrapper);
            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "DeleteByVoucherID"));

        }
        public override void DeleteByVoucherForApplicantID(decimal VoucherID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.DeleteByVoucherForApplicantID", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@VoucherID", DbType.Decimal, VoucherID);
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "DeleteByVoucherID"));
            Utility.ExecuteNonQuery(database, commandWrapper);
            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "DeleteByVoucherID"));

        }
        public override DataTable GetVoucherPayOnlineNotPayed(decimal? edStudID, decimal? AppID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);

            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetVoucherPayOnlineNotPayed", this.UseStoredProcedure);
            if (edStudID != null)
                database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, edStudID);

            if (AppID != null)
                database.AddInParameter(commandWrapper, "@AppID", DbType.Decimal, AppID);
            //decimal val = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetVoucherPayOnlineNotPayed"));


            // val = Convert.ToDecimal(Utility.ExecuteScalar(database, commandWrapper));
            DataTable dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetVoucherPayOnlineNotPayed"));

            return dt;// val;
        }

        public override TList<FeeStudVoucher> SearchStudVoucher(TransactionManager transactionManager, DateTime? _VoucherDateFrom, DateTime? _VoucherDateTo
            , decimal? _FeeCodeTypeId, decimal? _GsCodeCurrencyId, decimal _EdStudId, decimal _AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SearchStudVoucher", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@VoucherDateFrom", DbType.DateTime, _VoucherDateFrom);
            database.AddInParameter(commandWrapper, "@VoucherDateTo", DbType.DateTime, _VoucherDateTo);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeId", DbType.Decimal, _FeeCodeTypeId);
            database.AddInParameter(commandWrapper, "@GsCodeCurrencyId", DbType.Decimal, _GsCodeCurrencyId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            IDataReader reader = null;

            //Create Collection
            TList<FeeStudVoucher> rows = new TList<FeeStudVoucher>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SearchStudVoucher", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "SearchStudVoucher", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }//end getall

        public override DataTable SearchStudVoucher_Custum(TransactionManager transactionManager, DateTime? _VoucherDateFrom, DateTime? _VoucherDateTo
          , decimal? _FeeCodeTypeId, decimal? _GsCodeCurrencyId, decimal? _EdStudId, decimal? _AsFacultyInfoId, decimal? BankId, string FromReciptNum
          , string ToReciptNum, decimal? PaymentMehodId, decimal? _AcadYearId, decimal? _CodeSemesterId, decimal? _SeUserId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SearchStudVoucher_Custum", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@VoucherDateFrom", DbType.DateTime, _VoucherDateFrom);
            database.AddInParameter(commandWrapper, "@VoucherDateTo", DbType.DateTime, _VoucherDateTo);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeId", DbType.Decimal, _FeeCodeTypeId);
            database.AddInParameter(commandWrapper, "@GsCodeCurrencyId", DbType.Decimal, _GsCodeCurrencyId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            database.AddInParameter(commandWrapper, "@BankId", DbType.Decimal, BankId);
            database.AddInParameter(commandWrapper, "@FromReciptNum", DbType.String, FromReciptNum);
            database.AddInParameter(commandWrapper, "@ToReciptNum", DbType.String, ToReciptNum);
            //Task 3732
            database.AddInParameter(commandWrapper, "@PaymentMehodId", DbType.Decimal, PaymentMehodId);
            //Menna
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, _AcadYearId);
            database.AddInParameter(commandWrapper, "@CodeSemesterId", DbType.Decimal, _CodeSemesterId);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, _SeUserId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FeeStudVoucherId");
            table.Columns.Add("VoucherSerial");
            table.Columns.Add("VoucherDate");
            table.Columns.Add("TotalAmount");
            table.Columns.Add("ReceiptNum");
            table.Columns.Add("ReceiptDate");
            table.Columns.Add("GsCodeCurrencyId");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("CURRENCY_DESCR_AR");
            table.Columns.Add("CURRENCY_DESCR_EN");

            table.Columns.Add("METHOD_DESCR_AR");
            table.Columns.Add("METHOD_DESCR_EN");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");




            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString() };
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
        }//end getall

        public override DataTable SearchStudVoucher_Delete(TransactionManager transactionManager, DateTime? _VoucherDateFrom, DateTime? _VoucherDateTo
          , decimal? _FeeCodeTypeId, decimal? _GsCodeCurrencyId, decimal? _EdStudId,
            decimal? _AsFacultyInfoId, decimal? BankId, string FromReciptNum, string ToReciptNum, decimal? PaymentMehodId, int TypeId, int CancelVoucherDurationDays, decimal? _AcadYearId, decimal? _CodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SearchStudVoucher_Delete", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@VoucherDateFrom", DbType.DateTime, _VoucherDateFrom);
            database.AddInParameter(commandWrapper, "@VoucherDateTo", DbType.DateTime, _VoucherDateTo);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeId", DbType.Decimal, _FeeCodeTypeId);
            database.AddInParameter(commandWrapper, "@GsCodeCurrencyId", DbType.Decimal, _GsCodeCurrencyId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            database.AddInParameter(commandWrapper, "@TypeId", DbType.Decimal, TypeId);
            database.AddInParameter(commandWrapper, "@BankId", DbType.Decimal, BankId);
            database.AddInParameter(commandWrapper, "@FromReciptNum", DbType.String, FromReciptNum);
            database.AddInParameter(commandWrapper, "@ToReciptNum", DbType.String, ToReciptNum);
            //Task 3732
            database.AddInParameter(commandWrapper, "@PaymentMehodId", DbType.Decimal, PaymentMehodId);
            database.AddInParameter(commandWrapper, "@CancelVoucherDurationDays", DbType.Decimal, CancelVoucherDurationDays);
            // Add ACadYear AND SEMESTER 
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, _AcadYearId);
            database.AddInParameter(commandWrapper, "@CodeSemesterId", DbType.Decimal, _CodeSemesterId);
            DataTable dt = new DataTable();

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetDetailedItems"));

            if (transactionManager != null)
            {
                dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
            }
            else
            {
                dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetDetailedItems"));

            return dt;
        }//end getall


        public override decimal GetSerialVoucher( decimal VoucherSerial, TransactionManager transactionManager=null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetSerialVoucher", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@VoucherSerial", DbType.Decimal, VoucherSerial);
            //decimal res = 0;
            //res = decimal.Parse(Utility.ExecuteScalar(database, commandWrapper).ToString());
            //return res;
            //walaa 9/8/2022
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetSerialVoucher"));
            decimal res = 0;
            if (transactionManager != null)
            {
                res = decimal.Parse(Utility.ExecuteScalar(transactionManager, commandWrapper).ToString());
            }
            else
            {
                res = decimal.Parse(Utility.ExecuteScalar(database, commandWrapper).ToString());
            }
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetSerialVoucher"));
            return res;
        }



        #endregion
    }
}