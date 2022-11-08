#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CoControlRoom"/> entity.
	///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlCoControlRoomProvider : SqlCoControlRoomProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlCoControlRoomProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlCoControlRoomProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Custom Methods

        public override bool InsertNewControlRoomWithHeadMember(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.String _UserName, System.String _Password, System.String _SecretQuestion, System.String _SecretAnswer, System.Decimal _CreatorSeUserId, System.Decimal _ControlRoomHeadAccount)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.InsertNewControlRoomWithHeadMember", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@CoControlId", DbType.Decimal, _CoControlId);
            database.AddInParameter(commandWrapper, "@UserName", DbType.String, _UserName);
            database.AddInParameter(commandWrapper, "@Password", DbType.String, _Password);
            database.AddInParameter(commandWrapper, "@SecretQuestion", DbType.String, _SecretQuestion);
            database.AddInParameter(commandWrapper, "@SecretAnswer", DbType.String, _SecretAnswer);
            database.AddInParameter(commandWrapper, "@CreatorSeUserId", DbType.Decimal, _CreatorSeUserId);
            database.AddInParameter(commandWrapper, "@ControlRoomHeadAccount", DbType.Decimal, _ControlRoomHeadAccount);

            int result = 0;

            if (transactionManager != null)
            {
                result = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                result = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(result);
        }

        public override bool InsertNewControlRoomWithHeadMember(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId,System.Decimal _ControlRoomHeadAccount)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.InsertNewControlRoomWithHeadMemberUserExist", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@CoControlId", DbType.Decimal, _CoControlId);
            database.AddInParameter(commandWrapper, "@ControlRoomHeadAccount", DbType.Decimal, _ControlRoomHeadAccount);

            int result = 0;

            if (transactionManager != null)
            {
                result = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                result = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(result);
        }

        public override bool UpdateControlRoom(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.String _UserName, System.String _Password, System.String _SecretQuestion, System.String _SecretAnswer, System.Decimal _CreatorSeUserId, System.Decimal _ControlRoomHeadAccount, System.Decimal _ControlRoomId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UpdateControlRoom", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@CoControlId", DbType.Decimal, _CoControlId);
            database.AddInParameter(commandWrapper, "@UserName", DbType.String, _UserName);
            database.AddInParameter(commandWrapper, "@Password", DbType.String, _Password);
            database.AddInParameter(commandWrapper, "@SecretQuestion", DbType.String, _SecretQuestion);
            database.AddInParameter(commandWrapper, "@SecretAnswer", DbType.String, _SecretAnswer);
            database.AddInParameter(commandWrapper, "@CreatorSeUserId", DbType.Decimal, _CreatorSeUserId);
            database.AddInParameter(commandWrapper, "@ControlRoomHeadAccount", DbType.Decimal, _ControlRoomHeadAccount);
            database.AddInParameter(commandWrapper, "@ControlRoomId", DbType.Decimal, _ControlRoomId);

            int result = 0;

            if (transactionManager != null)
            {
                result = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                result = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(result);
        }

        public override bool UpdateControlRoom(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.Decimal _ControlRoomHeadAccount, System.Decimal _ControlRoomId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UpdateControlRoomUserExist", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@CoControlId", DbType.Decimal, _CoControlId);
            database.AddInParameter(commandWrapper, "@ControlRoomHeadAccount", DbType.Decimal, _ControlRoomHeadAccount);
            database.AddInParameter(commandWrapper, "@ControlRoomId", DbType.Decimal, _ControlRoomId);

            int result = 0;

            if (transactionManager != null)
            {
                result = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                result = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(result);
        }

        public override bool DeleteControlRoomWithAllItsData(TransactionManager transactionManager, System.Decimal _ControlRoomId, System.Decimal _ControlRoomHeadAccount, System.Decimal _ControlRoomMemberAccount)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.DeleteControlRoomWithAllItsData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ControlRoomId", DbType.Decimal, _ControlRoomId);
            database.AddInParameter(commandWrapper, "@ControlRoomHeadAccount", DbType.Decimal, _ControlRoomHeadAccount);
            database.AddInParameter(commandWrapper, "@ControlRoomMemberAccount", DbType.Decimal, _ControlRoomMemberAccount);

            int result = 0;

            if (transactionManager != null)
            {
                result = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                result = Utility.ExecuteNonQuery(database, commandWrapper);
            }
            
            return Convert.ToBoolean(result);
        }

        public override bool InsertNewRoomMember(TransactionManager transactionManager, System.Decimal _CoControlRoomId, System.Decimal _SaStfMemberId, System.String _UserName, System.String _Password, System.String _SecretQuestion, System.String _SecretAnswer, System.Decimal _CreatorSeUserId, System.Decimal _ControlRoomMemberAccount, System.String _Notes)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.InsertNewRoomMember", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CoControlRoomId", DbType.Decimal, _CoControlRoomId);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@UserName", DbType.String, _UserName);
            database.AddInParameter(commandWrapper, "@Password", DbType.String, _Password);
            database.AddInParameter(commandWrapper, "@SecretQuestion", DbType.String, _SecretQuestion);
            database.AddInParameter(commandWrapper, "@SecretAnswer", DbType.String, _SecretAnswer);
            database.AddInParameter(commandWrapper, "@CreatorSeUserId", DbType.Decimal, _CreatorSeUserId);
            database.AddInParameter(commandWrapper, "@ControlRoomMemberAccount", DbType.Decimal, _ControlRoomMemberAccount);
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, _Notes);

            int result = 0;

            if (transactionManager != null)
            {
                result = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                result = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(result);
        }

        public override bool InsertNewRoomMember(TransactionManager transactionManager, System.Decimal _CoControlRoomId, System.Decimal _SaStfMemberId, System.Decimal _ControlRoomMemberAccount, System.String _Notes)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.InsertNewRoomMemberUserExist", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CoControlRoomId", DbType.Decimal, _CoControlRoomId);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@ControlRoomMemberAccount", DbType.Decimal, _ControlRoomMemberAccount);
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, _Notes);

            int result = 0;

            if (transactionManager != null)
            {
                result = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                result = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(result);
        }
        
        #endregion
    }
}