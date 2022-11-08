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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudIntTrns"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudIntTrnsProvider: SqlEdStudIntTrnsProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudIntTrnsProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudIntTrnsProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        public override DataTable Search(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.String _studCode, System.Decimal _TypeId, System.Decimal _reqStatus, System.Decimal _isApplied)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_INT_TRNS_Search", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _edAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _studCode);
            database.AddInParameter(commandWrapper, "@TypeId", DbType.Decimal, _TypeId);
            database.AddInParameter(commandWrapper, "@ReqStatus", DbType.Decimal, _reqStatus);
            database.AddInParameter(commandWrapper, "@IsApplied", DbType.Decimal, _isApplied);

            IDataReader reader = null;
            DataTable tmp = new DataTable();
            tmp.Columns.Add("EdStudIntTrnsId");
            tmp.Columns.Add("EdStudId");
            tmp.Columns.Add("FullNameAr");
            tmp.Columns.Add("FullNameEn");
            tmp.Columns.Add("StudCode");
            tmp.Columns.Add("FromEntDescrAr");
            tmp.Columns.Add("FromEntDescrEn");
            tmp.Columns.Add("ToEntDescrAr");
            tmp.Columns.Add("ToEntDescrEn");
            tmp.Columns.Add("ReqDate");
            tmp.Columns.Add("ReqStatusDescrAr");
            tmp.Columns.Add("ReqStatusDescrEn");
            tmp.Columns.Add("IsApplied");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString() };
                    tmp.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;
        }

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrns entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_INT_TRNS_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudIntTrnsId", DbType.Decimal,9);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ReqDate", DbType.DateTime, (entity.ReqDate.HasValue ? (object)entity.ReqDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeReqStatusId", DbType.Decimal, entity.GsCodeReqStatusId);
            database.AddInParameter(commandWrapper, "@ReqStatusDate", DbType.DateTime, (entity.ReqStatusDate.HasValue ? (object)entity.ReqStatusDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);
            database.AddInParameter(commandWrapper, "@IsApplied", DbType.Decimal, entity.IsApplied);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, entity.AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@AdmCodeTransferTypeId", DbType.Decimal, entity.AdmCodeTransferTypeId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterReqId", DbType.Decimal, entity.EdCodeSemesterReqId);
            database.AddInParameter(commandWrapper, "@EdAcadYearReqId", DbType.Decimal, entity.EdAcadYearReqId);
            
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

            if (database.GetParameterValue(commandWrapper, "@EdStudIntTrnsId") != DBNull.Value)
            {
                entity.EdStudIntTrnsId = (decimal)database.GetParameterValue(commandWrapper, "@EdStudIntTrnsId");
                entity.OriginalEdStudIntTrnsId = entity.EdStudIntTrnsId;

                entity.AcceptChanges();
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return results > 0;
        }	
    }
}