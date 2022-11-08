#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="CoControlRoomProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoControlRoomProviderBase : CoControlRoomProviderBaseCore
	{
        #region Custom Methods

        public abstract bool InsertNewControlRoomWithHeadMember(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.String _UserName, System.String _Password, System.String _SecretQuestion, System.String _SecretAnswer, System.Decimal _CreatorSeUserId, System.Decimal _ControlRoomHeadAccount);

        public abstract bool InsertNewControlRoomWithHeadMember(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.Decimal _ControlRoomHeadAccount);

        public abstract bool UpdateControlRoom(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.String _UserName, System.String _Password, System.String _SecretQuestion, System.String _SecretAnswer, System.Decimal _CreatorSeUserId, System.Decimal _ControlRoomHeadAccount, System.Decimal _ControlRoomId);

        public abstract bool UpdateControlRoom(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.Decimal _ControlRoomHeadAccount, System.Decimal _ControlRoomId);

        public abstract bool DeleteControlRoomWithAllItsData(TransactionManager transactionManager, System.Decimal _ControlRoomId, System.Decimal _ControlRoomHeadAccount, System.Decimal _ControlRoomMemberAccount);

        public abstract bool InsertNewRoomMember(TransactionManager transactionManager, System.Decimal _CoControlRoomId, System.Decimal _SaStfMemberId, System.String _UserName, System.String _Password, System.String _SecretQuestion, System.String _SecretAnswer, System.Decimal _CreatorSeUserId, System.Decimal _ControlRoomMemberAccount, System.String _Notes);

        public abstract bool InsertNewRoomMember(TransactionManager transactionManager, System.Decimal _CoControlRoomId, System.Decimal _SaStfMemberId, System.Decimal _ControlRoomMemberAccount, System.String _Notes);

        #endregion
	} // end class
} // end namespace
