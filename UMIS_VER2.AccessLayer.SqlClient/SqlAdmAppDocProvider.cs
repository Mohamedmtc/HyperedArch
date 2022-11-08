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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppDoc"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAppDocProvider: SqlAdmAppDocProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAppDocProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmAppDocProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppDoc entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ADM_APP_DOC_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@AdmAppDocId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, entity.AdmApplicantId);
            database.AddInParameter(commandWrapper, "@AdmReqDocId", DbType.Decimal, entity.AdmReqDocId);
            database.AddInParameter(commandWrapper, "@SubmitDate", DbType.DateTime, (entity.SubmitDate.HasValue ? (object)entity.SubmitDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AppDocPath", DbType.String, entity.AppDocPath);
            database.AddInParameter(commandWrapper, "@ED_STUD_ID", DbType.Decimal, (entity.EdStudId.HasValue ? (object)entity.EdStudId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ADM_APP_REG_HISTORY_ID", DbType.Decimal, (entity.AdmAppRegHistoryId.HasValue ? (object)entity.AdmAppRegHistoryId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@RCVD_FLG", DbType.Decimal, (entity.RcvdFlg.HasValue ? (object)entity.RcvdFlg : System.DBNull.Value));

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

            entity.AdmAppDocId = commandWrapper.Parameters["@AdmAppDocId"].Value.ToString()!=""? decimal.Parse(commandWrapper.Parameters["@AdmAppDocId"].Value.ToString()):0;
            entity.OriginalAdmAppDocId = entity.AdmAppDocId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        public override TList<AdmAppDoc> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ADM_APP_DOC_GetByAdmApplicantId", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _admApplicantId);

            IDataReader reader = null;
            TList<AdmAppDoc> tmp = new TList<AdmAppDoc>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByAdmApplicantId", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByAdmApplicantId", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;

            //return rows;
        }

        #endregion
        
        #region CustomProcedures
        public override int LoadReqDocApplicant(TransactionManager transactionManager, decimal admCdeDocId, decimal admOpenAcadSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadReqDocOnApplicants", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmReqDocId", DbType.Decimal, admCdeDocId);
            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemesterId", DbType.Decimal, admOpenAcadSemesterId);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "LoadReqDocApplicant"));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "LoadReqDocApplicant"));

            return results;
        }
        #endregion
    }
}