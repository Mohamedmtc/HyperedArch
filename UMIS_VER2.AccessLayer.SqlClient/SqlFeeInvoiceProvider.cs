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

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeInvoice"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeInvoiceProvider: SqlFeeInvoiceProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeInvoiceProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeInvoiceProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        public override DataTable GetInvoiceItems(TransactionManager transactionManager, System.Decimal _InvoiveId, System.String _InvoiceStudId, System.Decimal _VoucherId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetInvoiceItems", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@InvoiveId", DbType.Decimal, _InvoiveId);
            database.AddInParameter(commandWrapper, "@InvoiceStudId", DbType.String, _InvoiceStudId);
            database.AddInParameter(commandWrapper, "@VoucherId", DbType.Decimal, _VoucherId);
            IDataReader reader = null;
            DataTable table = new DataTable();
       

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

                table.Load(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;

        }
        public override DataTable GetSponsoreInvoices(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdStudId, System.Decimal _CPR, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _SpoSponsorId, System.String _InvoiceNum, System.Decimal _InvoiceType, System.String _InvoiceId, System.String _SpoCode, System.Decimal _InvoiceCdeStaus, System.Decimal _PageIndex, System.Decimal _PageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSponsoreInvoices", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@CPR", DbType.Decimal, _CPR);
            database.AddInParameter(commandWrapper, "@DateFrom", DbType.DateTime, _DateFrom);
            database.AddInParameter(commandWrapper, "@DateTo", DbType.DateTime, _DateTo);
            database.AddInParameter(commandWrapper, "@SpoSponsorId", DbType.Decimal, _SpoSponsorId);
            database.AddInParameter(commandWrapper, "@InvoiceNum", DbType.String, _InvoiceNum);
            database.AddInParameter(commandWrapper, "@InvoiceType", DbType.Decimal, _InvoiceType);
            database.AddInParameter(commandWrapper, "@InvoiceId", DbType.String, _InvoiceId);
            database.AddInParameter(commandWrapper, "@SpoCode", DbType.String, _SpoCode);
            database.AddInParameter(commandWrapper, "@InvoiceCdeStaus", DbType.Decimal, _InvoiceCdeStaus);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, _PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, _PageSize);
            IDataReader reader = null;
            DataTable table = new DataTable();

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

                table.Load(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;

        }
        public override DataTable GetSponsoreInvoicesToPay(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _EdStudId, System.Decimal _CPR, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _SpoSponsorId, System.String _InvoiceNum, System.Decimal _InvoiceType, System.String _InvoiceId, System.String _SpoCode, System.Decimal _InvoiceCdeStaus, System.Decimal VoucherId,  System.Decimal _PageIndex, System.Decimal _PageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSponsoreInvoicesToPay", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);

            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@CPR", DbType.Decimal, _CPR);
            database.AddInParameter(commandWrapper, "@DateFrom", DbType.DateTime, _DateFrom);
            database.AddInParameter(commandWrapper, "@DateTo", DbType.DateTime, _DateTo);
            database.AddInParameter(commandWrapper, "@SpoSponsorId", DbType.Decimal, _SpoSponsorId);
            database.AddInParameter(commandWrapper, "@InvoiceNum", DbType.String, _InvoiceNum);
            database.AddInParameter(commandWrapper, "@InvoiceType", DbType.Decimal, _InvoiceType);
            database.AddInParameter(commandWrapper, "@InvoiceId", DbType.String, _InvoiceId);
            database.AddInParameter(commandWrapper, "@SpoCode", DbType.String, _SpoCode);
            database.AddInParameter(commandWrapper, "@InvoiceCdeStaus", DbType.Decimal, _InvoiceCdeStaus);
            database.AddInParameter(commandWrapper, "@VoucherId", DbType.Decimal, VoucherId);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, _PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, _PageSize);
            IDataReader reader = null;
            DataTable table = new DataTable();
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

                table.Load(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;

        }

        public override DataTable GetStudFeeForSposor(TransactionManager transactionManager, System.Decimal _FeeInvoice, System.Decimal _SponsorId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsCodeCurrency, System.Decimal _PageIndex, System.Decimal _PageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudFeeForSposor", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@FeeInvoice", DbType.Decimal, _FeeInvoice);
            database.AddInParameter(commandWrapper, "@SponsorId", DbType.Decimal, _SponsorId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@GsCodeCurrency", DbType.Decimal, _GsCodeCurrency);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, _PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, _PageSize);
            IDataReader reader = null;
            DataTable table = new DataTable();
          
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

                table.Load(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;

        }

        public override DataTable GetSpoStudFeeItem(TransactionManager transactionManager, System.Decimal _FeeInvoice, System.Decimal _SpoSponsorStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSpoStudFeeItem", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@FeeInvoice", DbType.Decimal, _FeeInvoice);
            database.AddInParameter(commandWrapper, "@SpoSponsorStudId", DbType.Decimal, _SpoSponsorStudId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            IDataReader reader = null;
            DataTable table = new DataTable();
    
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

                table.Load(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;

        }

        public override DataTable GetSpoStudFeeItemForPayment(TransactionManager transactionManager, System.Decimal _FeeInvoice, System.Decimal _SpoSponsorStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _VoucherId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSpoStudFeeItemForPayment", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@FeeInvoice", DbType.Decimal, _FeeInvoice);
            database.AddInParameter(commandWrapper, "@SpoSponsorStudId", DbType.Decimal, _SpoSponsorStudId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@VoucherId", DbType.Decimal, _VoucherId);

            IDataReader reader = null;
            DataTable table = new DataTable();

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

                table.Load(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;

        }
    }
}