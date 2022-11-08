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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeStudDisc"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeStudDiscProvider: SqlFeeStudDiscProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeStudDiscProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeStudDiscProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override DataTable GetByStudent(TransactionManager transactionManager, decimal EdStudID, decimal AsFacultyInfoID, decimal EdAcadYearID, decimal EDCodeSemID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_STUD_DISC_GetByStudent", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EDCodeSemID", DbType.Decimal, EDCodeSemID);
            DataTable dt = new DataTable();

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByStudent"));

            if (transactionManager != null)
            {
                dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
            }
            else
            {
                dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetByStudent"));

            return dt;
        }
        public override decimal GetStudentTotalDisc(TransactionManager transactionManager, decimal EdStudID, decimal AsFacultyInfoID, decimal EdAcadYearID)//, decimal EdCodeSemId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentTotalDisc", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, EdStudID);
            if (AsFacultyInfoID != 0)  // In case new applicant without current faculty_id - By Sameh Amein 17-08-2022 <TFS 19033>
                database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyInfoID);  //is nullable parameter in stored procedure
            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            // database.AddInParameter(commandWrapper, "@EdCodeSemId", DbType.Int32, EdCodeSemId);

            decimal dt = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentTotalDisc"));

            if (transactionManager != null)
            {
                dt = (decimal)Utility.ExecuteScalar(transactionManager, commandWrapper);
            }
            else
            {
                dt = (decimal)Utility.ExecuteScalar(database, commandWrapper);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentTotalDisc"));

            return dt;
        }
        public override decimal GetApplicantTotalDisc(TransactionManager transactionManager, decimal _admAppRegHistoryId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetApplicantTotalDisc", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmAppRegHistoryId", DbType.Decimal, _admAppRegHistoryId);

            decimal dt = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetApplicantTotalDisc"));

            if (transactionManager != null)
            {
                dt = (decimal)Utility.ExecuteScalar(transactionManager, commandWrapper);
            }
            else
            {
                dt = (decimal)Utility.ExecuteScalar(database, commandWrapper);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetApplicantTotalDisc"));

            return dt;
        }
        public override bool IsMaxDiscount(TransactionManager transactionManager, decimal feeStudDiscId, decimal EdStudID, decimal EdAcadYearID, decimal AsFacultyInfoID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.IsMaxDiscount", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@feeStudDiscId", DbType.Decimal, feeStudDiscId);
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, EdStudID);            
            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, AsFacultyInfoID);

            int dt = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "IsMaxDiscount"));

            if (transactionManager != null)
            {
                dt = (int)Utility.ExecuteScalar(transactionManager, commandWrapper);
            }
            else
            {
                dt = (int)Utility.ExecuteScalar(database, commandWrapper);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "IsMaxDiscount"));

            return (dt == 1);
        }

        //kamela, 10969
        public override DataTable GetFeeDiscOFStudWithIdAndStatus(TransactionManager transactionManager, decimal StudId, decimal ApproveStatus, decimal AsDegreClass)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFeeDiscOFStudWithIdAndStatus", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@StudId", DbType.Decimal, StudId);
            database.AddInParameter(commandWrapper, "@ApproveStatus", DbType.Decimal, ApproveStatus);
            database.AddInParameter(commandWrapper, "@AsDegreClass", DbType.Decimal, AsDegreClass);

            DataTable dt = new DataTable();

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFeeDiscOFStudWithIdAndStatus"));

            if (transactionManager != null)
            {
                dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
            }
            else
            {
                dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetFeeDiscOFStudWithIdAndStatus"));

            return dt;
        }
        //Manar abdelhafez task 12374 KU
        public override DataTable GETFeeSudDiscUsers( TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GETFeeSudDiscUsers", this.UseStoredProcedure);
            DataTable dt = new DataTable();
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GETFeeSudDiscUsers"));

            if (transactionManager != null)
            {
                dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
            }
            else
            {
                dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GETFeeSudDiscUsers"));

            return dt;
        }
        #endregion
    }
}