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
	/// This class is the base class for any <see cref="CoControlMemberProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoControlMemberProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoControlMember, UMIS_VER2.BusinessLyer.CoControlMemberKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControlMemberKey key)
		{
			return Delete(transactionManager, key.CoControlMembersId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coControlMembersId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coControlMembersId)
		{
			return Delete(null, _coControlMembersId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembersId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coControlMembersId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.CoControlMember Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControlMemberKey key, int start, int pageLength)
		{
			return GetByCoControlMembersId(transactionManager, key.CoControlMembersId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetByCoControlId(System.Decimal? _coControlId)
		{
			int count = -1;
			return GetByCoControlId(null,_coControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetByCoControlId(System.Decimal? _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetByCoControlId(TransactionManager transactionManager, System.Decimal? _coControlId)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetByCoControlId(TransactionManager transactionManager, System.Decimal? _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetByCoControlId(System.Decimal? _coControlId, int start, int pageLength, out int count)
		{
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public abstract TList<CoControlMember> GetByCoControlId(TransactionManager transactionManager, System.Decimal? _coControlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(null,_saCodeScDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength, out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public abstract TList<CoControlMember> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(null,_saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public TList<CoControlMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoControlMember&gt;"/> class.</returns>
		public abstract TList<CoControlMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_CONTROL_MEMBERS index.
		/// </summary>
		/// <param name="_coControlMembersId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlMembersId(System.Decimal _coControlMembersId)
		{
			int count = -1;
			return GetByCoControlMembersId(null,_coControlMembersId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL_MEMBERS index.
		/// </summary>
		/// <param name="_coControlMembersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlMembersId(System.Decimal _coControlMembersId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlMembersId(null, _coControlMembersId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL_MEMBERS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembersId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlMembersId(TransactionManager transactionManager, System.Decimal _coControlMembersId)
		{
			int count = -1;
			return GetByCoControlMembersId(transactionManager, _coControlMembersId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL_MEMBERS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlMembersId(TransactionManager transactionManager, System.Decimal _coControlMembersId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlMembersId(transactionManager, _coControlMembersId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL_MEMBERS index.
		/// </summary>
		/// <param name="_coControlMembersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlMembersId(System.Decimal _coControlMembersId, int start, int pageLength, out int count)
		{
			return GetByCoControlMembersId(null, _coControlMembersId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CONTROL_MEMBERS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembersId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlMembersId(TransactionManager transactionManager, System.Decimal _coControlMembersId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CO_CONTROL_MEMBER index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="_memberNameAr"></param>
		/// <param name="_memberNameEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(System.Decimal? _coControlId, System.Decimal? _saStfMemberId, System.String _memberNameAr, System.String _memberNameEn)
		{
			int count = -1;
			return GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(null,_coControlId, _saStfMemberId, _memberNameAr, _memberNameEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL_MEMBER index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="_memberNameAr"></param>
		/// <param name="_memberNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(System.Decimal? _coControlId, System.Decimal? _saStfMemberId, System.String _memberNameAr, System.String _memberNameEn, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(null, _coControlId, _saStfMemberId, _memberNameAr, _memberNameEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="_memberNameAr"></param>
		/// <param name="_memberNameEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(TransactionManager transactionManager, System.Decimal? _coControlId, System.Decimal? _saStfMemberId, System.String _memberNameAr, System.String _memberNameEn)
		{
			int count = -1;
			return GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(transactionManager, _coControlId, _saStfMemberId, _memberNameAr, _memberNameEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="_memberNameAr"></param>
		/// <param name="_memberNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(TransactionManager transactionManager, System.Decimal? _coControlId, System.Decimal? _saStfMemberId, System.String _memberNameAr, System.String _memberNameEn, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(transactionManager, _coControlId, _saStfMemberId, _memberNameAr, _memberNameEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL_MEMBER index.
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="_memberNameAr"></param>
		/// <param name="_memberNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(System.Decimal? _coControlId, System.Decimal? _saStfMemberId, System.String _memberNameAr, System.String _memberNameEn, int start, int pageLength, out int count)
		{
			return GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(null, _coControlId, _saStfMemberId, _memberNameAr, _memberNameEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CO_CONTROL_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="_memberNameAr"></param>
		/// <param name="_memberNameEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoControlMember GetByCoControlIdSaStfMemberIdMemberNameArMemberNameEn(TransactionManager transactionManager, System.Decimal? _coControlId, System.Decimal? _saStfMemberId, System.String _memberNameAr, System.String _memberNameEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoControlMember&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoControlMember&gt;"/></returns>
		public static TList<CoControlMember> Fill(IDataReader reader, TList<CoControlMember> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoControlMember c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoControlMember")
					.Append("|").Append((System.Decimal)reader["CO_CONTROL_MEMBERS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoControlMember>(
					key.ToString(), // EntityTrackingKey
					"CoControlMember",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoControlMember();
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
					c.CoControlMembersId = (System.Decimal)reader["CO_CONTROL_MEMBERS_ID"];
					c.OriginalCoControlMembersId = c.CoControlMembersId;
					c.CoControlId = Convert.IsDBNull(reader["CO_CONTROL_ID"]) ? null : (System.Decimal?)reader["CO_CONTROL_ID"];
					c.MemberFlg = (System.Decimal)reader["MEMBER_FLG"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.SaCodeScDegId = Convert.IsDBNull(reader["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_SC_DEG_ID"];
					c.MemberNameAr = Convert.IsDBNull(reader["MEMBER_NAME_AR"]) ? null : (System.String)reader["MEMBER_NAME_AR"];
					c.MemberNameEn = Convert.IsDBNull(reader["MEMBER_NAME_EN"]) ? null : (System.String)reader["MEMBER_NAME_EN"];
					c.MobNo = Convert.IsDBNull(reader["MOB_NO"]) ? null : (System.String)reader["MOB_NO"];
					c.JobTitle = Convert.IsDBNull(reader["JOB_TITLE"]) ? null : (System.String)reader["JOB_TITLE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.SupervisorFlg = (System.Decimal)reader["SUPERVISOR_FLG"];
					c.HeadFlg = (System.Decimal)reader["HEAD_FLG"];
					c.MemberTypeFlg = (System.Decimal)reader["MEMBER_TYPE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoControlMember entity)
		{
			if (!reader.Read()) return;
			
			entity.CoControlMembersId = (System.Decimal)reader[((int)CoControlMemberColumn.CoControlMembersId - 1)];
			entity.OriginalCoControlMembersId = (System.Decimal)reader["CO_CONTROL_MEMBERS_ID"];
			entity.CoControlId = (reader.IsDBNull(((int)CoControlMemberColumn.CoControlId - 1)))?null:(System.Decimal?)reader[((int)CoControlMemberColumn.CoControlId - 1)];
			entity.MemberFlg = (System.Decimal)reader[((int)CoControlMemberColumn.MemberFlg - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)CoControlMemberColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)CoControlMemberColumn.SaStfMemberId - 1)];
			entity.SaCodeScDegId = (reader.IsDBNull(((int)CoControlMemberColumn.SaCodeScDegId - 1)))?null:(System.Decimal?)reader[((int)CoControlMemberColumn.SaCodeScDegId - 1)];
			entity.MemberNameAr = (reader.IsDBNull(((int)CoControlMemberColumn.MemberNameAr - 1)))?null:(System.String)reader[((int)CoControlMemberColumn.MemberNameAr - 1)];
			entity.MemberNameEn = (reader.IsDBNull(((int)CoControlMemberColumn.MemberNameEn - 1)))?null:(System.String)reader[((int)CoControlMemberColumn.MemberNameEn - 1)];
			entity.MobNo = (reader.IsDBNull(((int)CoControlMemberColumn.MobNo - 1)))?null:(System.String)reader[((int)CoControlMemberColumn.MobNo - 1)];
			entity.JobTitle = (reader.IsDBNull(((int)CoControlMemberColumn.JobTitle - 1)))?null:(System.String)reader[((int)CoControlMemberColumn.JobTitle - 1)];
			entity.Notes = (reader.IsDBNull(((int)CoControlMemberColumn.Notes - 1)))?null:(System.String)reader[((int)CoControlMemberColumn.Notes - 1)];
			entity.IsActive = (System.Decimal)reader[((int)CoControlMemberColumn.IsActive - 1)];
			entity.SupervisorFlg = (System.Decimal)reader[((int)CoControlMemberColumn.SupervisorFlg - 1)];
			entity.HeadFlg = (System.Decimal)reader[((int)CoControlMemberColumn.HeadFlg - 1)];
			entity.MemberTypeFlg = (System.Decimal)reader[((int)CoControlMemberColumn.MemberTypeFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoControlMember entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoControlMembersId = (System.Decimal)dataRow["CO_CONTROL_MEMBERS_ID"];
			entity.OriginalCoControlMembersId = (System.Decimal)dataRow["CO_CONTROL_MEMBERS_ID"];
			entity.CoControlId = Convert.IsDBNull(dataRow["CO_CONTROL_ID"]) ? null : (System.Decimal?)dataRow["CO_CONTROL_ID"];
			entity.MemberFlg = (System.Decimal)dataRow["MEMBER_FLG"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeScDegId = Convert.IsDBNull(dataRow["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_SC_DEG_ID"];
			entity.MemberNameAr = Convert.IsDBNull(dataRow["MEMBER_NAME_AR"]) ? null : (System.String)dataRow["MEMBER_NAME_AR"];
			entity.MemberNameEn = Convert.IsDBNull(dataRow["MEMBER_NAME_EN"]) ? null : (System.String)dataRow["MEMBER_NAME_EN"];
			entity.MobNo = Convert.IsDBNull(dataRow["MOB_NO"]) ? null : (System.String)dataRow["MOB_NO"];
			entity.JobTitle = Convert.IsDBNull(dataRow["JOB_TITLE"]) ? null : (System.String)dataRow["JOB_TITLE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
			entity.SupervisorFlg = (System.Decimal)dataRow["SUPERVISOR_FLG"];
			entity.HeadFlg = (System.Decimal)dataRow["HEAD_FLG"];
			entity.MemberTypeFlg = (System.Decimal)dataRow["MEMBER_TYPE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoControlMember"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoControlMember Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControlMember entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region CoControlIdSource	
			if (CanDeepLoad(entity, "CoControl|CoControlIdSource", deepLoadType, innerList) 
				&& entity.CoControlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.CoControlId ?? 0.0m);
				CoControl tmpEntity = EntityManager.LocateEntity<CoControl>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlIdSource = tmpEntity;
				else
					entity.CoControlIdSource = DataRepository.CoControlProvider.GetByCoControlId(transactionManager, (entity.CoControlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoControlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoControlProvider.DeepLoad(transactionManager, entity.CoControlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoControlIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCoControlMembersId methods when available
			
			#region CoExamCommSupervisorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamCommSupervisor>|CoExamCommSupervisorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamCommSupervisorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamCommSupervisorCollection = DataRepository.CoExamCommSupervisorProvider.GetByCoControlMembersId(transactionManager, entity.CoControlMembersId);

				if (deep && entity.CoExamCommSupervisorCollection.Count > 0)
				{
					deepHandles.Add("CoExamCommSupervisorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamCommSupervisor>) DataRepository.CoExamCommSupervisorProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamCommSupervisorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoStudCheatCollectionGetByCoControlMembHdId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoStudCheat>|CoStudCheatCollectionGetByCoControlMembHdId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoStudCheatCollectionGetByCoControlMembHdId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoStudCheatCollectionGetByCoControlMembHdId = DataRepository.CoStudCheatProvider.GetByCoControlMembHdId(transactionManager, entity.CoControlMembersId);

				if (deep && entity.CoStudCheatCollectionGetByCoControlMembHdId.Count > 0)
				{
					deepHandles.Add("CoStudCheatCollectionGetByCoControlMembHdId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoStudCheat>) DataRepository.CoStudCheatProvider.DeepLoad,
						new object[] { transactionManager, entity.CoStudCheatCollectionGetByCoControlMembHdId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoStudCheatCollectionGetByCoControlMembId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoStudCheat>|CoStudCheatCollectionGetByCoControlMembId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoStudCheatCollectionGetByCoControlMembId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoStudCheatCollectionGetByCoControlMembId = DataRepository.CoStudCheatProvider.GetByCoControlMembId(transactionManager, entity.CoControlMembersId);

				if (deep && entity.CoStudCheatCollectionGetByCoControlMembId.Count > 0)
				{
					deepHandles.Add("CoStudCheatCollectionGetByCoControlMembId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoStudCheat>) DataRepository.CoStudCheatProvider.DeepLoad,
						new object[] { transactionManager, entity.CoStudCheatCollectionGetByCoControlMembId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExamCommSupervisorAltCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamCommSupervisorAlt>|CoExamCommSupervisorAltCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamCommSupervisorAltCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamCommSupervisorAltCollection = DataRepository.CoExamCommSupervisorAltProvider.GetByCoControlMembersId(transactionManager, entity.CoControlMembersId);

				if (deep && entity.CoExamCommSupervisorAltCollection.Count > 0)
				{
					deepHandles.Add("CoExamCommSupervisorAltCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamCommSupervisorAlt>) DataRepository.CoExamCommSupervisorAltProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamCommSupervisorAltCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoControlMember object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoControlMember instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoControlMember Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoControlMember entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
			}
			#endregion 
			
			#region CoControlIdSource
			if (CanDeepSave(entity, "CoControl|CoControlIdSource", deepSaveType, innerList) 
				&& entity.CoControlIdSource != null)
			{
				DataRepository.CoControlProvider.Save(transactionManager, entity.CoControlIdSource);
				entity.CoControlId = entity.CoControlIdSource.CoControlId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<CoExamCommSupervisor>
				if (CanDeepSave(entity.CoExamCommSupervisorCollection, "List<CoExamCommSupervisor>|CoExamCommSupervisorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamCommSupervisor child in entity.CoExamCommSupervisorCollection)
					{
						if(child.CoControlMembersIdSource != null)
						{
							child.CoControlMembersId = child.CoControlMembersIdSource.CoControlMembersId;
						}
						else
						{
							child.CoControlMembersId = entity.CoControlMembersId;
						}

					}

					if (entity.CoExamCommSupervisorCollection.Count > 0 || entity.CoExamCommSupervisorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamCommSupervisorProvider.Save(transactionManager, entity.CoExamCommSupervisorCollection);
						
						deepHandles.Add("CoExamCommSupervisorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamCommSupervisor >) DataRepository.CoExamCommSupervisorProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamCommSupervisorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoStudCheat>
				if (CanDeepSave(entity.CoStudCheatCollectionGetByCoControlMembHdId, "List<CoStudCheat>|CoStudCheatCollectionGetByCoControlMembHdId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoStudCheat child in entity.CoStudCheatCollectionGetByCoControlMembHdId)
					{
						if(child.CoControlMembHdIdSource != null)
						{
							child.CoControlMembHdId = child.CoControlMembHdIdSource.CoControlMembersId;
						}
						else
						{
							child.CoControlMembHdId = entity.CoControlMembersId;
						}

					}

					if (entity.CoStudCheatCollectionGetByCoControlMembHdId.Count > 0 || entity.CoStudCheatCollectionGetByCoControlMembHdId.DeletedItems.Count > 0)
					{
						//DataRepository.CoStudCheatProvider.Save(transactionManager, entity.CoStudCheatCollectionGetByCoControlMembHdId);
						
						deepHandles.Add("CoStudCheatCollectionGetByCoControlMembHdId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoStudCheat >) DataRepository.CoStudCheatProvider.DeepSave,
							new object[] { transactionManager, entity.CoStudCheatCollectionGetByCoControlMembHdId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoStudCheat>
				if (CanDeepSave(entity.CoStudCheatCollectionGetByCoControlMembId, "List<CoStudCheat>|CoStudCheatCollectionGetByCoControlMembId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoStudCheat child in entity.CoStudCheatCollectionGetByCoControlMembId)
					{
						if(child.CoControlMembIdSource != null)
						{
							child.CoControlMembId = child.CoControlMembIdSource.CoControlMembersId;
						}
						else
						{
							child.CoControlMembId = entity.CoControlMembersId;
						}

					}

					if (entity.CoStudCheatCollectionGetByCoControlMembId.Count > 0 || entity.CoStudCheatCollectionGetByCoControlMembId.DeletedItems.Count > 0)
					{
						//DataRepository.CoStudCheatProvider.Save(transactionManager, entity.CoStudCheatCollectionGetByCoControlMembId);
						
						deepHandles.Add("CoStudCheatCollectionGetByCoControlMembId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoStudCheat >) DataRepository.CoStudCheatProvider.DeepSave,
							new object[] { transactionManager, entity.CoStudCheatCollectionGetByCoControlMembId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExamCommSupervisorAlt>
				if (CanDeepSave(entity.CoExamCommSupervisorAltCollection, "List<CoExamCommSupervisorAlt>|CoExamCommSupervisorAltCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamCommSupervisorAlt child in entity.CoExamCommSupervisorAltCollection)
					{
						if(child.CoControlMembersIdSource != null)
						{
							child.CoControlMembersId = child.CoControlMembersIdSource.CoControlMembersId;
						}
						else
						{
							child.CoControlMembersId = entity.CoControlMembersId;
						}

					}

					if (entity.CoExamCommSupervisorAltCollection.Count > 0 || entity.CoExamCommSupervisorAltCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamCommSupervisorAltProvider.Save(transactionManager, entity.CoExamCommSupervisorAltCollection);
						
						deepHandles.Add("CoExamCommSupervisorAltCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamCommSupervisorAlt >) DataRepository.CoExamCommSupervisorAltProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamCommSupervisorAltCollection, deepSaveType, childTypes, innerList }
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
	
	#region CoControlMemberChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoControlMember</c>
	///</summary>
	public enum CoControlMemberChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
		///<summary>
		/// Composite Property for <c>CoControl</c> at CoControlIdSource
		///</summary>
		[ChildEntityType(typeof(CoControl))]
		CoControl,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		///<summary>
		/// Collection of <c>CoControlMember</c> as OneToMany for CoExamCommSupervisorCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamCommSupervisor>))]
		CoExamCommSupervisorCollection,
		///<summary>
		/// Collection of <c>CoControlMember</c> as OneToMany for CoStudCheatCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoStudCheat>))]
		CoStudCheatCollectionGetByCoControlMembHdId,
		///<summary>
		/// Collection of <c>CoControlMember</c> as OneToMany for CoStudCheatCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoStudCheat>))]
		CoStudCheatCollectionGetByCoControlMembId,
		///<summary>
		/// Collection of <c>CoControlMember</c> as OneToMany for CoExamCommSupervisorAltCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamCommSupervisorAlt>))]
		CoExamCommSupervisorAltCollection,
	}
	
	#endregion CoControlMemberChildEntityTypes
	
	#region CoControlMemberFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoControlMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoControlMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoControlMemberFilterBuilder : SqlFilterBuilder<CoControlMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoControlMemberFilterBuilder class.
		/// </summary>
		public CoControlMemberFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoControlMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoControlMemberFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoControlMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoControlMemberFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoControlMemberFilterBuilder
	
	#region CoControlMemberParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoControlMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoControlMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoControlMemberParameterBuilder : ParameterizedSqlFilterBuilder<CoControlMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoControlMemberParameterBuilder class.
		/// </summary>
		public CoControlMemberParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoControlMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoControlMemberParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoControlMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoControlMemberParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoControlMemberParameterBuilder
	
	#region CoControlMemberSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoControlMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoControlMember"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoControlMemberSortBuilder : SqlSortBuilder<CoControlMemberColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoControlMemberSqlSortBuilder class.
		/// </summary>
		public CoControlMemberSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoControlMemberSortBuilder
	
} // end namespace
