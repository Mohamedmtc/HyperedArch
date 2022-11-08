#region Using directives

using System;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer.Bases;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmAppMessage"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmAppMessageProvider: SqlAdmAppMessageProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmAppMessageProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmAppMessageProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppMessage entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_MESSAGE_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@AdmAppMessageId", DbType.Decimal,18 );
            database.AddInParameter(commandWrapper, "@MsgSubj", DbType.String, entity.MsgSubj);
            database.AddInParameter(commandWrapper, "@MsgBody", DbType.String, entity.MsgBody);
            database.AddInParameter(commandWrapper, "@MsgDate", DbType.DateTime, entity.MsgDate);
            database.AddInParameter(commandWrapper, "@FailFlg", DbType.Decimal, entity.FailFlg);

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

            entity.AdmAppMessageId = decimal.Parse(commandWrapper.Parameters["@AdmAppMessageId"].Value.ToString());
            entity.OriginalAdmAppMessageId = entity.AdmAppMessageId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	
	}
}