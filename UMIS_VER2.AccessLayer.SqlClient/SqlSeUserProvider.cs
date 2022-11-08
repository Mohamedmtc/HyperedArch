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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SeUser"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSeUserProvider: SqlSeUserProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSeUserProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSeUserProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        //public override decimal InsertGetID(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUser entity)
        //{
        //    SqlDatabase database = new SqlDatabase(this.ConnectionString);
        //    DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_USER_Insert", UseStoredProcedure);

        //    database.AddOutParameter(commandWrapper, "@SeUserId", DbType.Decimal,10);
        //    database.AddInParameter(commandWrapper, "@SeCodeUserJobId", DbType.Decimal, (entity.SeCodeUserJobId.HasValue ? (object)entity.SeCodeUserJobId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@SeCodeUserPlaceId", DbType.Decimal, (entity.SeCodeUserPlaceId.HasValue ? (object)entity.SeCodeUserPlaceId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@UserNameEn", DbType.String, entity.UserNameEn);
        //    database.AddInParameter(commandWrapper, "@UserNameAr", DbType.String, entity.UserNameAr);
        //    database.AddInParameter(commandWrapper, "@PwdExpireDate", DbType.DateTime, (entity.PwdExpireDate.HasValue ? (object)entity.PwdExpireDate : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@SecurityQuestion", DbType.String, entity.SecurityQuestion);
        //    database.AddInParameter(commandWrapper, "@SequrityAns", DbType.String, entity.SequrityAns);
        //    database.AddInParameter(commandWrapper, "@CreatorUserId", DbType.Decimal, (entity.CreatorUserId.HasValue ? (object)entity.CreatorUserId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@CreationDate", DbType.DateTime, entity.CreationDate);
        //    database.AddInParameter(commandWrapper, "@LastLoginDate", DbType.DateTime, (entity.LastLoginDate.HasValue ? (object)entity.LastLoginDate : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@Status", DbType.Decimal, entity.Status);
        //    database.AddInParameter(commandWrapper, "@FailedAttemptsNum", DbType.Decimal, entity.FailedAttemptsNum);
        //    database.AddInParameter(commandWrapper, "@ValidateMachine", DbType.Decimal, (entity.ValidateMachine.HasValue ? (object)entity.ValidateMachine : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@Ip", DbType.String, entity.Ip);
        //    database.AddInParameter(commandWrapper, "@Mac", DbType.String, entity.Mac);
        //    database.AddInParameter(commandWrapper, "@IsLogin", DbType.Decimal, (entity.IsLogin.HasValue ? (object)entity.IsLogin : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@Email", DbType.String, entity.Email);
        //    database.AddInParameter(commandWrapper, "@AdUserName", DbType.String, entity.AdUserName);
        //    database.AddInParameter(commandWrapper, "@AdUserGuid", DbType.String, entity.AdUserGuid);
        //    database.AddInParameter(commandWrapper, "@SeCodeUserTypeId", DbType.Decimal, (entity.SeCodeUserTypeId.HasValue ? (object)entity.SeCodeUserTypeId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@UserTableId", DbType.Decimal, (entity.UserTableId.HasValue ? (object)entity.UserTableId : System.DBNull.Value));

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

        //    object _seUserId = database.GetParameterValue(commandWrapper, "@SeUserId");
        //    entity.SeUserId = (System.Decimal)_seUserId;

        //    entity.OriginalSeUserId = entity.SeUserId;

        //    entity.AcceptChanges();

        //    //Provider Data Requested Command Event
        //    OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

        //    return decimal.Parse(_seUserId.ToString());
        //}	

        public override DataTable GetUserAccounts(TransactionManager transactionManager,System.Decimal _SeUserId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_Get_User_Accounts", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, _SeUserId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SE_USER_ID");
            table.Columns.Add("SE_CODE_USER_TYPE_ID");
            table.Columns.Add("USER_NAME_EN");
            table.Columns.Add("USER_NAME_AR");
            table.Columns.Add("AD_USER_NAME");
            table.Columns.Add("DESC_AR");
            table.Columns.Add("DESC_EN");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("SE_USER_ACCNT_ID");
            table.Columns.Add("HAS_AVAIL_PERIOD");
            table.Columns.Add("AVAIL_PERIOD_FROM_DATE");
            table.Columns.Add("AVAIL_PERIOD_FROM_TIME");
            table.Columns.Add("AVAIL_PERIOD_TO_DATE");
            table.Columns.Add("AVAIL_PERIOD_TO_TIME");
            table.Columns.Add("IS_ACTIVE");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(),
                                             reader[1].ToString(),
                                             reader[2].ToString(),
                                             reader[3].ToString(),
                                             reader[4].ToString(),
                                             reader[5].ToString(),
                                             reader[6].ToString(),
                                             reader[7].ToString(),
                                             reader[8].ToString(),
                                             reader[9].ToString(),
                                             reader[10].ToString(),
                                             reader[11].ToString(),
                                             reader[12].ToString(),
                                             reader[13].ToString(),
                                             reader[14].ToString(),
                                             reader[15].ToString()
                                         };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(),
                                             reader[1].ToString(),
                                             reader[2].ToString(),
                                             reader[3].ToString(),
                                             reader[4].ToString(),
                                             reader[5].ToString(),
                                             reader[6].ToString(),
                                             reader[7].ToString(),
                                             reader[8].ToString(),
                                             reader[9].ToString(),
                                             reader[10].ToString(),
                                             reader[11].ToString(),
                                             reader[12].ToString(),
                                             reader[13].ToString(),
                                             reader[14].ToString(),
                                             reader[15].ToString()
                                         };
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

        }

        public override DataTable GetUserPages(TransactionManager transactionManager, System.Decimal _SeUserID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudentCoursesTimeTable", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, _SeUserID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FORM_CODE_NAME");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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

        }

        public override DataTable GetSystemUsers(TransactionManager transactionManager, System.String UserNameEn, string UserNameAr, string AdUserName, decimal SeCodeUserTypeId, decimal SeCodeUserPlaceId, decimal SeCodeUserJobId, decimal PageIndex, decimal PageSize, decimal? ASFACULTYINFOID, decimal? SystemUserStatus)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSystemUsers", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@UserNameEn", DbType.String,UserNameEn);
            database.AddInParameter(commandWrapper, "@UserNameAr", DbType.String, UserNameAr) ;
            database.AddInParameter(commandWrapper, "@AdUserName", DbType.String, AdUserName);
            database.AddInParameter(commandWrapper, "@SeCodeUserTypeId", DbType.Decimal, SeCodeUserTypeId);

            database.AddInParameter(commandWrapper, "@SeCodeUserPlaceId", DbType.Decimal, SeCodeUserPlaceId);
            database.AddInParameter(commandWrapper, "@SeCodeUserJobId", DbType.Decimal, SeCodeUserJobId);
            database.AddInParameter(commandWrapper, "@ASFACULTYINFOID", DbType.Decimal, ASFACULTYINFOID);
            
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            if (SystemUserStatus != -1)
            {
                database.AddInParameter(commandWrapper, "@Status", DbType.Decimal, SystemUserStatus);
            }
            IDataReader reader = null;
            DataTable table = new DataTable();
            
            table.Columns.Add("sn");
            table.Columns.Add("SeUserId");
            table.Columns.Add("SeCodeUserTypeId");
            table.Columns.Add("UserNameEn");
            table.Columns.Add("UserNameAr");
            table.Columns.Add("ADUserName");
            table.Columns.Add("UserTypeDescrEn");
            table.Columns.Add("UserTypeDescrAr");
            table.Columns.Add("Status");
            table.Columns.Add("RowsTotCount");
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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() , reader[9].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;

        }




        public override DataTable GetByUNandPWD(TransactionManager transactionManager, System.String _UserName,System.String _Password)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_User_UNandPWD", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@UserName", DbType.String, _UserName);
            database.AddInParameter(commandWrapper, "@Password", DbType.String, _Password);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SE_USER_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionManager"></param>
        /// <param name="IsActive"></param>
        /// <returns></returns>
        public override DataTable GetUsersByStatus(TransactionManager transactionManager, System.Decimal IsActive)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetUsersByStatus", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, IsActive);
             

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SE_USER_ID");
            table.Columns.Add("USER_NAME_AR");
            table.Columns.Add("USER_NAME_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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
        }
        public override DataTable GetAccountsByUserID(TransactionManager transactionManager, System.Decimal UserID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAccountsByUserID", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@UserID", DbType.Decimal, UserID);
             

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SE_ACCOUNT_ID");
            table.Columns.Add("DESC_AR");
            table.Columns.Add("DESC_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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
        }

        

        #endregion
    }
}