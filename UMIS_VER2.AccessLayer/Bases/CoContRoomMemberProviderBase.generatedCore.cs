#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="CoContRoomMemberProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoContRoomMemberProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoContRoomMember, UMIS_VER2.BusinessLyer.CoContRoomMemberKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoContRoomMemberKey key)
		{
			return Delete(transactionManager, key.CoContRoomMemberId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coContRoomMemberId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coContRoomMemberId)
		{
			return Delete(null, _coContRoomMemberId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRoomMemberId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coContRoomMemberId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_CODE_SC_DEG key.
		///		FK_CO_CONT_ROOM_MEMBER_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		public TList<CoContRoomMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_CODE_SC_DEG key.
		///		FK_CO_CONT_ROOM_MEMBER_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		/// <remarks></remarks>
		public TList<CoContRoomMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_CODE_SC_DEG key.
		///		FK_CO_CONT_ROOM_MEMBER_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		public TList<CoContRoomMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_CODE_SC_DEG key.
		///		fkCoContRoomMemberSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		public TList<CoContRoomMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_CODE_SC_DEG key.
		///		fkCoContRoomMemberSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		public TList<CoContRoomMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_CODE_SC_DEG key.
		///		FK_CO_CONT_ROOM_MEMBER_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		public abstract TList<CoContRoomMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_STF_MEMBER key.
		///		FK_CO_CONT_ROOM_MEMBER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		public TList<CoContRoomMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_STF_MEMBER key.
		///		FK_CO_CONT_ROOM_MEMBER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		/// <remarks></remarks>
		public TList<CoContRoomMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_STF_MEMBER key.
		///		FK_CO_CONT_ROOM_MEMBER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		public TList<CoContRoomMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_STF_MEMBER key.
		///		fkCoContRoomMemberSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		public TList<CoContRoomMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_STF_MEMBER key.
		///		fkCoContRoomMemberSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		public TList<CoContRoomMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_CONT_ROOM_MEMBER_SA_STF_MEMBER key.
		///		FK_CO_CONT_ROOM_MEMBER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoContRoomMember objects.</returns>
		public abstract TList<CoContRoomMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override UMIS_VER2.BusinessLyer.CoContRoomMember Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoContRoomMemberKey key, int start, int pageLength)
		{
			return GetByCoContRoomMemberId(transactionManager, key.CoContRoomMemberId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public TList<CoContRoomMember> GetByCoControlRoomId(System.Decimal _coControlRoomId)
		{
			int count = -1;
			return GetByCoControlRoomId(null,_coControlRoomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public TList<CoContRoomMember> GetByCoControlRoomId(System.Decimal _coControlRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlRoomId(null, _coControlRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public TList<CoContRoomMember> GetByCoControlRoomId(TransactionManager transactionManager, System.Decimal _coControlRoomId)
		{
			int count = -1;
			return GetByCoControlRoomId(transactionManager, _coControlRoomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public TList<CoContRoomMember> GetByCoControlRoomId(TransactionManager transactionManager, System.Decimal _coControlRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlRoomId(transactionManager, _coControlRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public TList<CoContRoomMember> GetByCoControlRoomId(System.Decimal _coControlRoomId, int start, int pageLength, out int count)
		{
			return GetByCoControlRoomId(null, _coControlRoomId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public abstract TList<CoContRoomMember> GetByCoControlRoomId(TransactionManager transactionManager, System.Decimal _coControlRoomId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public TList<CoContRoomMember> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(null,_seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public TList<CoContRoomMember> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public TList<CoContRoomMember> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public TList<CoContRoomMember> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public TList<CoContRoomMember> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength, out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoContRoomMember&gt;"/> class.</returns>
		public abstract TList<CoContRoomMember> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_CONT_PHASE_MEMBER index.
		/// </summary>
		/// <param name="_coContRoomMemberId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoContRoomMemberId(System.Decimal _coContRoomMemberId)
		{
			int count = -1;
			return GetByCoContRoomMemberId(null,_coContRoomMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONT_PHASE_MEMBER index.
		/// </summary>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoContRoomMemberId(System.Decimal _coContRoomMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoContRoomMemberId(null, _coContRoomMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONT_PHASE_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRoomMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoContRoomMemberId(TransactionManager transactionManager, System.Decimal _coContRoomMemberId)
		{
			int count = -1;
			return GetByCoContRoomMemberId(transactionManager, _coContRoomMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONT_PHASE_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoContRoomMemberId(TransactionManager transactionManager, System.Decimal _coContRoomMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoContRoomMemberId(transactionManager, _coContRoomMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONT_PHASE_MEMBER index.
		/// </summary>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoContRoomMemberId(System.Decimal _coContRoomMemberId, int start, int pageLength, out int count)
		{
			return GetByCoContRoomMemberId(null, _coContRoomMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONT_PHASE_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coContRoomMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoContRoomMemberId(TransactionManager transactionManager, System.Decimal _coContRoomMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CO_CONT_ROOM_MEMBER index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoControlRoomIdSaStfMemberId(System.Decimal _coControlRoomId, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetByCoControlRoomIdSaStfMemberId(null,_coControlRoomId, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONT_ROOM_MEMBER index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoControlRoomIdSaStfMemberId(System.Decimal _coControlRoomId, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlRoomIdSaStfMemberId(null, _coControlRoomId, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONT_ROOM_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoControlRoomIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _coControlRoomId, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetByCoControlRoomIdSaStfMemberId(transactionManager, _coControlRoomId, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONT_ROOM_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoControlRoomIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _coControlRoomId, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlRoomIdSaStfMemberId(transactionManager, _coControlRoomId, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONT_ROOM_MEMBER index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoControlRoomIdSaStfMemberId(System.Decimal _coControlRoomId, System.Decimal? _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetByCoControlRoomIdSaStfMemberId(null, _coControlRoomId, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONT_ROOM_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoContRoomMember GetByCoControlRoomIdSaStfMemberId(TransactionManager transactionManager, System.Decimal _coControlRoomId, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoContRoomMember&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoContRoomMember&gt;"/></returns>
		public static TList<CoContRoomMember> Fill(IDataReader reader, TList<CoContRoomMember> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				UMIS_VER2.BusinessLyer.CoContRoomMember c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoContRoomMember")
					.Append("|").Append((System.Decimal)reader["CO_CONT_ROOM_MEMBER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoContRoomMember>(
					key.ToString(), // EntityTrackingKey
					"CoContRoomMember",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoContRoomMember();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.CoContRoomMemberId = (System.Decimal)reader["CO_CONT_ROOM_MEMBER_ID"];
					c.OriginalCoContRoomMemberId = c.CoContRoomMemberId;
					c.CoControlRoomId = (System.Decimal)reader["CO_CONTROL_ROOM_ID"];
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.SaCodeScDegId = Convert.IsDBNull(reader["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_SC_DEG_ID"];
					c.HeadFlg = (System.Decimal)reader["HEAD_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoContRoomMember entity)
		{
			if (!reader.Read()) return;
			
			entity.CoContRoomMemberId = (System.Decimal)reader[((int)CoContRoomMemberColumn.CoContRoomMemberId - 1)];
			entity.OriginalCoContRoomMemberId = (System.Decimal)reader["CO_CONT_ROOM_MEMBER_ID"];
			entity.CoControlRoomId = (System.Decimal)reader[((int)CoContRoomMemberColumn.CoControlRoomId - 1)];
			entity.SeUserId = (System.Decimal)reader[((int)CoContRoomMemberColumn.SeUserId - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)CoContRoomMemberColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)CoContRoomMemberColumn.SaStfMemberId - 1)];
			entity.SaCodeScDegId = (reader.IsDBNull(((int)CoContRoomMemberColumn.SaCodeScDegId - 1)))?null:(System.Decimal?)reader[((int)CoContRoomMemberColumn.SaCodeScDegId - 1)];
			entity.HeadFlg = (System.Decimal)reader[((int)CoContRoomMemberColumn.HeadFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)CoContRoomMemberColumn.Notes - 1)))?null:(System.String)reader[((int)CoContRoomMemberColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoContRoomMember entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoContRoomMemberId = (System.Decimal)dataRow["CO_CONT_ROOM_MEMBER_ID"];
			entity.OriginalCoContRoomMemberId = (System.Decimal)dataRow["CO_CONT_ROOM_MEMBER_ID"];
			entity.CoControlRoomId = (System.Decimal)dataRow["CO_CONTROL_ROOM_ID"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeScDegId = Convert.IsDBNull(dataRow["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_SC_DEG_ID"];
			entity.HeadFlg = (System.Decimal)dataRow["HEAD_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoContRoomMember"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoContRoomMember Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoContRoomMember entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CoControlRoomIdSource	
			if (CanDeepLoad(entity, "CoControlRoom|CoControlRoomIdSource", deepLoadType, innerList) 
				&& entity.CoControlRoomIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoControlRoomId;
				CoControlRoom tmpEntity = EntityManager.LocateEntity<CoControlRoom>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControlRoom), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlRoomIdSource = tmpEntity;
				else
					entity.CoControlRoomIdSource = DataRepository.CoControlRoomProvider.GetByCoControlRoomId(transactionManager, entity.CoControlRoomId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlRoomIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoControlRoomIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoControlRoomProvider.DeepLoad(transactionManager, entity.CoControlRoomIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoControlRoomIdSource

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeScDegId ?? 0.0m);
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, (entity.SaCodeScDegId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeScDegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeScDegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeScDegProvider.DeepLoad(transactionManager, entity.SaCodeScDegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeScDegIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeUserId;
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, entity.SeUserId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCoContRoomMemberId methods when available
			
			#region CoContRmMemCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoContRmMemCourse>|CoContRmMemCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoContRmMemCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoContRmMemCourseCollection = DataRepository.CoContRmMemCourseProvider.GetByCoContRoomMemberId(transactionManager, entity.CoContRoomMemberId);

				if (deep && entity.CoContRmMemCourseCollection.Count > 0)
				{
					deepHandles.Add("CoContRmMemCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoContRmMemCourse>) DataRepository.CoContRmMemCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.CoContRmMemCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoContRoomMember object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoContRoomMember instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoContRoomMember Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoContRoomMember entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CoControlRoomIdSource
			if (CanDeepSave(entity, "CoControlRoom|CoControlRoomIdSource", deepSaveType, innerList) 
				&& entity.CoControlRoomIdSource != null)
			{
				DataRepository.CoControlRoomProvider.Save(transactionManager, entity.CoControlRoomIdSource);
				entity.CoControlRoomId = entity.CoControlRoomIdSource.CoControlRoomId;
			}
			#endregion 
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<CoContRmMemCourse>
				if (CanDeepSave(entity.CoContRmMemCourseCollection, "List<CoContRmMemCourse>|CoContRmMemCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoContRmMemCourse child in entity.CoContRmMemCourseCollection)
					{
						if(child.CoContRoomMemberIdSource != null)
						{
							child.CoContRoomMemberId = child.CoContRoomMemberIdSource.CoContRoomMemberId;
						}
						else
						{
							child.CoContRoomMemberId = entity.CoContRoomMemberId;
						}

					}

					if (entity.CoContRmMemCourseCollection.Count > 0 || entity.CoContRmMemCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoContRmMemCourseProvider.Save(transactionManager, entity.CoContRmMemCourseCollection);
						
						deepHandles.Add("CoContRmMemCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoContRmMemCourse >) DataRepository.CoContRmMemCourseProvider.DeepSave,
							new object[] { transactionManager, entity.CoContRmMemCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region CoContRoomMemberChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoContRoomMember</c>
	///</summary>
	public enum CoContRoomMemberChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoControlRoom</c> at CoControlRoomIdSource
		///</summary>
		[ChildEntityType(typeof(CoControlRoom))]
		CoControlRoom,
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>CoContRoomMember</c> as OneToMany for CoContRmMemCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoContRmMemCourse>))]
		CoContRmMemCourseCollection,
	}
	
	#endregion CoContRoomMemberChildEntityTypes
	
	#region CoContRoomMemberFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoContRoomMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoContRoomMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoContRoomMemberFilterBuilder : SqlFilterBuilder<CoContRoomMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoContRoomMemberFilterBuilder class.
		/// </summary>
		public CoContRoomMemberFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoContRoomMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoContRoomMemberFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoContRoomMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoContRoomMemberFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoContRoomMemberFilterBuilder
	
	#region CoContRoomMemberParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoContRoomMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoContRoomMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoContRoomMemberParameterBuilder : ParameterizedSqlFilterBuilder<CoContRoomMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoContRoomMemberParameterBuilder class.
		/// </summary>
		public CoContRoomMemberParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoContRoomMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoContRoomMemberParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoContRoomMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoContRoomMemberParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoContRoomMemberParameterBuilder
	
	#region CoContRoomMemberSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoContRoomMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoContRoomMember"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoContRoomMemberSortBuilder : SqlSortBuilder<CoContRoomMemberColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoContRoomMemberSqlSortBuilder class.
		/// </summary>
		public CoContRoomMemberSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoContRoomMemberSortBuilder
	
} // end namespace
