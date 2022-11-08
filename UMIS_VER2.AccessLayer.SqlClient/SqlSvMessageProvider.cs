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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SvMessage"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSvMessageProvider: SqlSvMessageProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSvMessageProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSvMessageProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override decimal GetLastID(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_MESSAGE_GetLast", this.UseStoredProcedure);

            IDataReader reader = null;
            decimal ID = 0;

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        if (reader[0].ToString() != "")
                            ID = decimal.Parse(reader[0].ToString());
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        if (reader[0].ToString() != "")
                            ID = decimal.Parse(reader[0].ToString());
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return ID;

        }
        #endregion

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMessage entity)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_SV_MESSAGE_Insert",UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@SvMessageId", DbType.Decimal, 6);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@MsgContent", DbType.String, entity.MsgContent);
            database.AddInParameter(commandWrapper, "@MsgDate", DbType.DateTime, entity.MsgDate);
            database.AddInParameter(commandWrapper, "@MsgSubject", DbType.String, entity.MsgSubject);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, (entity.AdmApplicantId.HasValue ? (object)entity.AdmApplicantId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DeleteFlg", DbType.Decimal, (entity.DeleteFlg.HasValue ? (object)entity.DeleteFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserAccntId", DbType.Decimal, (entity.SeUserAccntId.HasValue ? (object)entity.SeUserAccntId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@NotifyFlg", DbType.Boolean, (entity.NotifyFlg.HasValue ? (object)entity.NotifyFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@InboxFlg", DbType.Boolean, (entity.InboxFlg.HasValue ? (object)entity.InboxFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AutoFlg", DbType.Boolean, (entity.AutoFlg.HasValue ? (object)entity.AutoFlg : System.DBNull.Value));

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

            entity.SvMessageId = decimal.Parse(commandWrapper.Parameters["@SvMessageId"].Value.ToString());
            entity.OriginalSvMessageId = entity.SvMessageId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        
    }
}