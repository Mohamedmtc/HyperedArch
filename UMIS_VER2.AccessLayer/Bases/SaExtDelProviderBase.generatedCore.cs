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
	/// This class is the base class for any <see cref="SaExtDelProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaExtDelProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaExtDel, UMIS_VER2.BusinessLyer.SaExtDelKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaExtDelKey key)
		{
			return Delete(transactionManager, key.SaExtDelId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saExtDelId">او المنتدب اليها الجهة المعار منها. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saExtDelId)
		{
			return Delete(null, _saExtDelId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saExtDelId">او المنتدب اليها الجهة المعار منها. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saExtDelId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaExtDel Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaExtDelKey key, int start, int pageLength)
		{
			return GetBySaExtDelId(transactionManager, key.SaExtDelId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public abstract TList<SaExtDel> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetByAsNodeId(System.Decimal? _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(null,_asNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetByAsNodeId(System.Decimal? _asNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeId(null, _asNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetByAsNodeId(System.Decimal? _asNodeId, int start, int pageLength, out int count)
		{
			return GetByAsNodeId(null, _asNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public abstract TList<SaExtDel> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeOrgId">الجهة المعار منها او المنتدب  اليها</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId)
		{
			int count = -1;
			return GetBySaCodeOrgId(null,_saCodeOrgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeOrgId">الجهة المعار منها او المنتدب  اليها</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeOrgId(null, _saCodeOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId">الجهة المعار منها او المنتدب  اليها</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId)
		{
			int count = -1;
			return GetBySaCodeOrgId(transactionManager, _saCodeOrgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId">الجهة المعار منها او المنتدب  اليها</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeOrgId(transactionManager, _saCodeOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeOrgId">الجهة المعار منها او المنتدب  اليها</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId, int start, int pageLength, out int count)
		{
			return GetBySaCodeOrgId(null, _saCodeOrgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_ORG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId">الجهة المعار منها او المنتدب  اليها</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public abstract TList<SaExtDel> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId">مسلسل عضو هيئة التدريس</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(null,_saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId">مسلسل عضو هيئة التدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">مسلسل عضو هيئة التدريس</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">مسلسل عضو هيئة التدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId">مسلسل عضو هيئة التدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public TList<SaExtDel> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">مسلسل عضو هيئة التدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaExtDel&gt;"/> class.</returns>
		public abstract TList<SaExtDel> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_EXT_DEL index.
		/// </summary>
		/// <param name="_saExtDelId">او المنتدب اليها الجهة المعار منها</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaExtDel GetBySaExtDelId(System.Decimal _saExtDelId)
		{
			int count = -1;
			return GetBySaExtDelId(null,_saExtDelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EXT_DEL index.
		/// </summary>
		/// <param name="_saExtDelId">او المنتدب اليها الجهة المعار منها</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaExtDel GetBySaExtDelId(System.Decimal _saExtDelId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaExtDelId(null, _saExtDelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EXT_DEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saExtDelId">او المنتدب اليها الجهة المعار منها</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaExtDel GetBySaExtDelId(TransactionManager transactionManager, System.Decimal _saExtDelId)
		{
			int count = -1;
			return GetBySaExtDelId(transactionManager, _saExtDelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EXT_DEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saExtDelId">او المنتدب اليها الجهة المعار منها</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaExtDel GetBySaExtDelId(TransactionManager transactionManager, System.Decimal _saExtDelId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaExtDelId(transactionManager, _saExtDelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EXT_DEL index.
		/// </summary>
		/// <param name="_saExtDelId">او المنتدب اليها الجهة المعار منها</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaExtDel GetBySaExtDelId(System.Decimal _saExtDelId, int start, int pageLength, out int count)
		{
			return GetBySaExtDelId(null, _saExtDelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_EXT_DEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saExtDelId">او المنتدب اليها الجهة المعار منها</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaExtDel GetBySaExtDelId(TransactionManager transactionManager, System.Decimal _saExtDelId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaExtDel&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaExtDel&gt;"/></returns>
		public static TList<SaExtDel> Fill(IDataReader reader, TList<SaExtDel> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaExtDel c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaExtDel")
					.Append("|").Append((System.Decimal)reader["SA_EXT_DEL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaExtDel>(
					key.ToString(), // EntityTrackingKey
					"SaExtDel",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaExtDel();
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
					c.SaExtDelId = (System.Decimal)reader["SA_EXT_DEL_ID"];
					c.OriginalSaExtDelId = c.SaExtDelId;
					c.DelFlg = (System.Decimal)reader["DEL_FLG"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.StartDate = (System.DateTime)reader["START_DATE"];
					c.EndDate = Convert.IsDBNull(reader["END_DATE"]) ? null : (System.DateTime?)reader["END_DATE"];
					c.SaCodeOrgId = Convert.IsDBNull(reader["SA_CODE_ORG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_ORG_ID"];
					c.OrgNameAr = Convert.IsDBNull(reader["ORG_NAME_AR"]) ? null : (System.String)reader["ORG_NAME_AR"];
					c.OrgNameEn = Convert.IsDBNull(reader["ORG_NAME_EN"]) ? null : (System.String)reader["ORG_NAME_EN"];
					c.IsOrgUni = (System.Decimal)reader["IS_ORG_UNI"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AsNodeId = Convert.IsDBNull(reader["AS_NODE_ID"]) ? null : (System.Decimal?)reader["AS_NODE_ID"];
					c.IsDelTermin = (System.Decimal)reader["IS_DEL_TERMIN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaExtDel entity)
		{
			if (!reader.Read()) return;
			
			entity.SaExtDelId = (System.Decimal)reader[((int)SaExtDelColumn.SaExtDelId - 1)];
			entity.OriginalSaExtDelId = (System.Decimal)reader["SA_EXT_DEL_ID"];
			entity.DelFlg = (System.Decimal)reader[((int)SaExtDelColumn.DelFlg - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaExtDelColumn.SaStfMemberId - 1)];
			entity.StartDate = (System.DateTime)reader[((int)SaExtDelColumn.StartDate - 1)];
			entity.EndDate = (reader.IsDBNull(((int)SaExtDelColumn.EndDate - 1)))?null:(System.DateTime?)reader[((int)SaExtDelColumn.EndDate - 1)];
			entity.SaCodeOrgId = (reader.IsDBNull(((int)SaExtDelColumn.SaCodeOrgId - 1)))?null:(System.Decimal?)reader[((int)SaExtDelColumn.SaCodeOrgId - 1)];
			entity.OrgNameAr = (reader.IsDBNull(((int)SaExtDelColumn.OrgNameAr - 1)))?null:(System.String)reader[((int)SaExtDelColumn.OrgNameAr - 1)];
			entity.OrgNameEn = (reader.IsDBNull(((int)SaExtDelColumn.OrgNameEn - 1)))?null:(System.String)reader[((int)SaExtDelColumn.OrgNameEn - 1)];
			entity.IsOrgUni = (System.Decimal)reader[((int)SaExtDelColumn.IsOrgUni - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SaExtDelColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SaExtDelColumn.AsFacultyInfoId - 1)];
			entity.AsNodeId = (reader.IsDBNull(((int)SaExtDelColumn.AsNodeId - 1)))?null:(System.Decimal?)reader[((int)SaExtDelColumn.AsNodeId - 1)];
			entity.IsDelTermin = (System.Decimal)reader[((int)SaExtDelColumn.IsDelTermin - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaExtDel entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaExtDelId = (System.Decimal)dataRow["SA_EXT_DEL_ID"];
			entity.OriginalSaExtDelId = (System.Decimal)dataRow["SA_EXT_DEL_ID"];
			entity.DelFlg = (System.Decimal)dataRow["DEL_FLG"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.StartDate = (System.DateTime)dataRow["START_DATE"];
			entity.EndDate = Convert.IsDBNull(dataRow["END_DATE"]) ? null : (System.DateTime?)dataRow["END_DATE"];
			entity.SaCodeOrgId = Convert.IsDBNull(dataRow["SA_CODE_ORG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_ORG_ID"];
			entity.OrgNameAr = Convert.IsDBNull(dataRow["ORG_NAME_AR"]) ? null : (System.String)dataRow["ORG_NAME_AR"];
			entity.OrgNameEn = Convert.IsDBNull(dataRow["ORG_NAME_EN"]) ? null : (System.String)dataRow["ORG_NAME_EN"];
			entity.IsOrgUni = (System.Decimal)dataRow["IS_ORG_UNI"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AsNodeId = Convert.IsDBNull(dataRow["AS_NODE_ID"]) ? null : (System.Decimal?)dataRow["AS_NODE_ID"];
			entity.IsDelTermin = (System.Decimal)dataRow["IS_DEL_TERMIN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaExtDel"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaExtDel Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaExtDel entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeOrgIdSource	
			if (CanDeepLoad(entity, "SaCodeOrg|SaCodeOrgIdSource", deepLoadType, innerList) 
				&& entity.SaCodeOrgIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeOrgId ?? 0.0m);
				SaCodeOrg tmpEntity = EntityManager.LocateEntity<SaCodeOrg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeOrg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeOrgIdSource = tmpEntity;
				else
					entity.SaCodeOrgIdSource = DataRepository.SaCodeOrgProvider.GetBySaCodeOrgId(transactionManager, (entity.SaCodeOrgId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeOrgIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeOrgIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeOrgProvider.DeepLoad(transactionManager, entity.SaCodeOrgIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeOrgIdSource

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region AsNodeIdSource	
			if (CanDeepLoad(entity, "EntityMain|AsNodeIdSource", deepLoadType, innerList) 
				&& entity.AsNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsNodeId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsNodeIdSource = tmpEntity;
				else
					entity.AsNodeIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.AsNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.AsNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsNodeIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaExtDel object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaExtDel instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaExtDel Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaExtDel entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeOrgIdSource
			if (CanDeepSave(entity, "SaCodeOrg|SaCodeOrgIdSource", deepSaveType, innerList) 
				&& entity.SaCodeOrgIdSource != null)
			{
				DataRepository.SaCodeOrgProvider.Save(transactionManager, entity.SaCodeOrgIdSource);
				entity.SaCodeOrgId = entity.SaCodeOrgIdSource.SaCodeOrgId;
			}
			#endregion 
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region AsNodeIdSource
			if (CanDeepSave(entity, "EntityMain|AsNodeIdSource", deepSaveType, innerList) 
				&& entity.AsNodeIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.AsNodeIdSource);
				entity.AsNodeId = entity.AsNodeIdSource.EntMainId;
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
	
	#region SaExtDelChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaExtDel</c>
	///</summary>
	public enum SaExtDelChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeOrg</c> at SaCodeOrgIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeOrg))]
		SaCodeOrg,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at AsNodeIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion SaExtDelChildEntityTypes
	
	#region SaExtDelFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaExtDelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaExtDel"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaExtDelFilterBuilder : SqlFilterBuilder<SaExtDelColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaExtDelFilterBuilder class.
		/// </summary>
		public SaExtDelFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaExtDelFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaExtDelFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaExtDelFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaExtDelFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaExtDelFilterBuilder
	
	#region SaExtDelParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaExtDelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaExtDel"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaExtDelParameterBuilder : ParameterizedSqlFilterBuilder<SaExtDelColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaExtDelParameterBuilder class.
		/// </summary>
		public SaExtDelParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaExtDelParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaExtDelParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaExtDelParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaExtDelParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaExtDelParameterBuilder
	
	#region SaExtDelSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaExtDelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaExtDel"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaExtDelSortBuilder : SqlSortBuilder<SaExtDelColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaExtDelSqlSortBuilder class.
		/// </summary>
		public SaExtDelSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaExtDelSortBuilder
	
} // end namespace
