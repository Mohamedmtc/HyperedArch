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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SeUserAccnt"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSeUserAccntProvider: SqlSeUserAccntProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSeUserAccntProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSeUserAccntProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }
       
        
        #region Custom Methods
        public override decimal insertDateTimeforUserAccunt(TransactionManager transactionManager,UMIS_VER2.BusinessLyer.SeUserAccnt objSeUserAccnt )
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SP_UpdateUserAccountDate", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FROM_DATE", DbType.DateTime, objSeUserAccnt.AvailPeriodFromDate);
            database.AddInParameter(commandWrapper, "@TO_DATE", DbType.DateTime, objSeUserAccnt.AvailPeriodToDate);
            database.AddInParameter(commandWrapper, "@SE_USER_ACCNT_ID", DbType.Decimal,objSeUserAccnt.SeUserAccntId);
           
            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", objSeUserAccnt));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            objSeUserAccnt.OriginalSeUserAccntId = objSeUserAccnt.SeUserAccntId;

            objSeUserAccnt.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", objSeUserAccnt));

            return Convert.ToDecimal(commandWrapper.Parameters["@SE_USER_ACCNT_ID"].Value);
        }

        public override TList<SeUserAccnt> GetSeUserAccountIdByUserTypeAndUserTableId(TransactionManager transactionManager, System.Decimal _UserType, System.Decimal _SeUserId, System.Decimal _UserTableId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_SeUserAccountIdByUserTypeAndUserTableId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@UserType", DbType.Decimal, _UserType);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, _SeUserId);
            database.AddInParameter(commandWrapper, "@UserTableId", DbType.Decimal, _UserTableId);
            IDataReader reader = null;
            TList<SeUserAccnt> rows = new TList<SeUserAccnt>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "Get_SeUserAccountIdByUserTypeAndUserTableId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                //Fill(reader, rows, start, pageLength);
                //count = -1;
                //if (reader.NextResult())
                //{
                    if (reader.Read())
                    {
                        SeUserAccnt seUserAccount = new SeUserAccnt();
                        seUserAccount.SeUserAccntId = decimal.Parse(reader["SE_USER_ACCNT_ID"].ToString());
                        rows.Add(seUserAccount);
                    }
                //}

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "Get_SeUserAccountIdByUserTypeAndUserTableId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        #endregion
    }
}