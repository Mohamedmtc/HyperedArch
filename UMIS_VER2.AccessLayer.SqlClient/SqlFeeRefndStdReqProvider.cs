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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeRefndStdReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeRefndStdReqProvider: SqlFeeRefndStdReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeRefndStdReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeRefndStdReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        //public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefndStdReq entity)
        //{
        //    SqlDatabase database = new SqlDatabase(this.ConnectionString);
        //    DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_REFND_STD_REQ_Insert", UseStoredProcedure);
        //    database.AddOutParameter(commandWrapper, "@FeeRefndStdReqId", DbType.Decimal, 5);
        //    database.AddInParameter(commandWrapper, "@RfndDate", DbType.Date, entity.RfndDate);
        //    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, entity.AsFacultyInfoId);
        //    database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
        //    database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
        //    database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
        //    database.AddInParameter(commandWrapper, "@TotRfndValue", DbType.Decimal, (entity.TotRfndValue.HasValue ? (object)entity.TotRfndValue : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@TotRfndPrcnt", DbType.Decimal, (entity.TotRfndPrcnt.HasValue ? (object)entity.TotRfndPrcnt : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@RfndReason", DbType.AnsiString, entity.RfndReason);
        //    database.AddInParameter(commandWrapper, "@CurrencyId", DbType.Decimal, entity.CurrencyId);
        //    database.AddInParameter(commandWrapper, "@GsCodeReqStatusId", DbType.Decimal, (entity.GsCodeReqStatusId.HasValue ? (object)entity.GsCodeReqStatusId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);
        //    database.AddInParameter(commandWrapper, "@RfndNumber", DbType.String, entity.RfndNumber);
        //    database.AddInParameter(commandWrapper, "@CalcRfndValue", DbType.Decimal, (entity.CalcRfndValue.HasValue ? (object)entity.CalcRfndValue : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@CalcRfndPrcnt", DbType.Decimal, (entity.CalcRfndPrcnt.HasValue ? (object)entity.CalcRfndPrcnt : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@UserName", DbType.String, entity.UserName);
        //    database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@StudFeeBalance", DbType.Decimal, (entity.StudFeeBalance.HasValue ? (object)entity.StudFeeBalance : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@RefndTypeId", DbType.Int32, (entity.RefndTypeId.HasValue ? (object)entity.RefndTypeId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, (entity.AdmApplicantId.HasValue ? (object)entity.AdmApplicantId : System.DBNull.Value));
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

        //    entity.FeeRefndStdReqId = decimal.Parse(commandWrapper.Parameters["@FeeRefndStdReqId"].Value.ToString());
        //    entity.OriginalFeeRefndStdReqId = entity.FeeRefndStdReqId;

        //    entity.AcceptChanges();

        //    //Provider Data Requested Command Event
        //    OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

        //    return Convert.ToBoolean(results);
        //}

        public override DataTable GetStudentRefendReq(decimal? SemesterID, decimal? AsFacultyInfoID, decimal? EdAcadYearID, int? GsCodeReqStatusID, DateTime? FromDate, DateTime? ToDate, bool? Canceled, string StudentCode,string ApplicantCode,int IsApplicant,int? ApplicantID,int?UserId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentRefendReq", this.UseStoredProcedure);
            if(SemesterID!=null)
           database.AddInParameter(commandWrapper, "@SemesterID", DbType.Decimal, SemesterID);
            if (AsFacultyInfoID != null)
                database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyInfoID);
            if (EdAcadYearID != null)
                database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            if (GsCodeReqStatusID != null)
                database.AddInParameter(commandWrapper, "@GsCodeReqStatusID", DbType.Decimal, GsCodeReqStatusID);
            if (FromDate != null)
                database.AddInParameter(commandWrapper, "@FromDate", DbType.Date, FromDate);
            if (ToDate != null)
                database.AddInParameter(commandWrapper, "@ToDate", DbType.Date, ToDate);
     
            if (Canceled != null)
                database.AddInParameter(commandWrapper, "@Canceled", DbType.Boolean, Canceled.Value);
            if(StudentCode!="")
                database.AddInParameter(commandWrapper, "@StudentCode", DbType.String, StudentCode);
            if (ApplicantCode != "")
                database.AddInParameter(commandWrapper, "@ApplicantCode", DbType.String, ApplicantCode);
          

            database.AddInParameter(commandWrapper, "@IsApplicant", DbType.Int32, IsApplicant);

            if (UserId != null) 
                database.AddInParameter(commandWrapper, "@UserId", DbType.Decimal, UserId);
            DataTable dt = new DataTable();
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByStudent"));
                dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetByStudent"));

            return dt;
        }


        public override DataTable GetAdmAppFeesForCurrentSemsterRef(decimal AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentRefendReq", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ApplicantID", DbType.Decimal, AdmApplicantId);
            DataTable dt = new DataTable();
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByStudent"));
            dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
  

            return dt;
        }


    }
}