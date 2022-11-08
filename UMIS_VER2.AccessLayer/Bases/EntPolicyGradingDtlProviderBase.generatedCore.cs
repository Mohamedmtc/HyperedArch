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
	/// This class is the base class for any <see cref="EntPolicyGradingDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyGradingDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyGradingDtl, UMIS_VER2.BusinessLyer.EntPolicyGradingDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingDtlKey key)
		{
			return Delete(transactionManager, key.EntPolicyGradingDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyGradingDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyGradingDtlId)
		{
			return Delete(null, _entPolicyGradingDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyGradingDtlId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyGradingDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingDtlKey key, int start, int pageLength)
		{
			return GetByEntPolicyGradingDtlId(transactionManager, key.EntPolicyGradingDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByEdCodeGradingId(System.Decimal _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(null,_edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByEdCodeGradingId(System.Decimal _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByEdCodeGradingId(System.Decimal _edCodeGradingId, int start, int pageLength, out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public abstract TList<EntPolicyGradingDtl> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal _edCodeGradingId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByEntPolicyGradingHdrId(System.Decimal _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(null,_entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByEntPolicyGradingHdrId(System.Decimal _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByEntPolicyGradingHdrId(System.Decimal _entPolicyGradingHdrId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public abstract TList<EntPolicyGradingDtl> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByGsCodePassFailId(System.Decimal _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(null,_gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByGsCodePassFailId(System.Decimal _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public TList<EntPolicyGradingDtl> GetByGsCodePassFailId(System.Decimal _gsCodePassFailId, int start, int pageLength, out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PASS_FAIL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyGradingDtl&gt;"/> class.</returns>
		public abstract TList<EntPolicyGradingDtl> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal _gsCodePassFailId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="_entPolicyGradingDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingDtlId(System.Decimal _entPolicyGradingDtlId)
		{
			int count = -1;
			return GetByEntPolicyGradingDtlId(null,_entPolicyGradingDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="_entPolicyGradingDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingDtlId(System.Decimal _entPolicyGradingDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingDtlId(null, _entPolicyGradingDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingDtlId(TransactionManager transactionManager, System.Decimal _entPolicyGradingDtlId)
		{
			int count = -1;
			return GetByEntPolicyGradingDtlId(transactionManager, _entPolicyGradingDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingDtlId(TransactionManager transactionManager, System.Decimal _entPolicyGradingDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingDtlId(transactionManager, _entPolicyGradingDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="_entPolicyGradingDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingDtlId(System.Decimal _entPolicyGradingDtlId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyGradingDtlId(null, _entPolicyGradingDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingDtlId(TransactionManager transactionManager, System.Decimal _entPolicyGradingDtlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_gradOrder"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdGradOrder(System.Decimal _entPolicyGradingHdrId, System.Decimal _gradOrder)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrIdGradOrder(null,_entPolicyGradingHdrId, _gradOrder, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_gradOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdGradOrder(System.Decimal _entPolicyGradingHdrId, System.Decimal _gradOrder, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrIdGradOrder(null, _entPolicyGradingHdrId, _gradOrder, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_gradOrder"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdGradOrder(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, System.Decimal _gradOrder)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrIdGradOrder(transactionManager, _entPolicyGradingHdrId, _gradOrder, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_gradOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdGradOrder(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, System.Decimal _gradOrder, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrIdGradOrder(transactionManager, _entPolicyGradingHdrId, _gradOrder, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_gradOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdGradOrder(System.Decimal _entPolicyGradingHdrId, System.Decimal _gradOrder, int start, int pageLength, out int count)
		{
			return GetByEntPolicyGradingHdrIdGradOrder(null, _entPolicyGradingHdrId, _gradOrder, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_gradOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdGradOrder(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, System.Decimal _gradOrder, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_GRADING_DTL2 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdEdCodeGradingId(System.Decimal _entPolicyGradingHdrId, System.Decimal _edCodeGradingId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrIdEdCodeGradingId(null,_entPolicyGradingHdrId, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_DTL2 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdEdCodeGradingId(System.Decimal _entPolicyGradingHdrId, System.Decimal _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrIdEdCodeGradingId(null, _entPolicyGradingHdrId, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_DTL2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_edCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdEdCodeGradingId(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, System.Decimal _edCodeGradingId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrIdEdCodeGradingId(transactionManager, _entPolicyGradingHdrId, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_DTL2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdEdCodeGradingId(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, System.Decimal _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrIdEdCodeGradingId(transactionManager, _entPolicyGradingHdrId, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_DTL2 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdEdCodeGradingId(System.Decimal _entPolicyGradingHdrId, System.Decimal _edCodeGradingId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyGradingHdrIdEdCodeGradingId(null, _entPolicyGradingHdrId, _edCodeGradingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_GRADING_DTL2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetByEntPolicyGradingHdrIdEdCodeGradingId(TransactionManager transactionManager, System.Decimal _entPolicyGradingHdrId, System.Decimal _edCodeGradingId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyGradingDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyGradingDtl&gt;"/></returns>
		public static TList<EntPolicyGradingDtl> Fill(IDataReader reader, TList<EntPolicyGradingDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyGradingDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyGradingDtl")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_GRADING_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyGradingDtl>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyGradingDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyGradingDtl();
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
					c.EntPolicyGradingDtlId = (System.Decimal)reader["ENT_POLICY_GRADING_DTL_ID"];
					c.OriginalEntPolicyGradingDtlId = c.EntPolicyGradingDtlId;
					c.EntPolicyGradingHdrId = (System.Decimal)reader["ENT_POLICY_GRADING_HDR_ID"];
					c.EdCodeGradingId = (System.Decimal)reader["ED_CODE_GRADING_ID"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.GradCode = Convert.IsDBNull(reader["GRAD_CODE"]) ? null : (System.String)reader["GRAD_CODE"];
					c.SymbolAr = Convert.IsDBNull(reader["SYMBOL_AR"]) ? null : (System.String)reader["SYMBOL_AR"];
					c.SymbolEn = Convert.IsDBNull(reader["SYMBOL_EN"]) ? null : (System.String)reader["SYMBOL_EN"];
					c.GradOrder = (System.Decimal)reader["GRAD_ORDER"];
					c.MinRate = Convert.IsDBNull(reader["MIN_RATE"]) ? null : (System.Decimal?)reader["MIN_RATE"];
					c.MaxRate = Convert.IsDBNull(reader["MAX_RATE"]) ? null : (System.Decimal?)reader["MAX_RATE"];
					c.GsCodePassFailId = (System.Decimal)reader["GS_CODE_PASS_FAIL_ID"];
					c.Points = Convert.IsDBNull(reader["POINTS"]) ? null : (System.Decimal?)reader["POINTS"];
					c.MinPrcent = Convert.IsDBNull(reader["MIN_PRCENT"]) ? null : (System.Decimal?)reader["MIN_PRCENT"];
					c.MaxPrcent = Convert.IsDBNull(reader["MAX_PRCENT"]) ? null : (System.Decimal?)reader["MAX_PRCENT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyGradingDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyGradingDtlId = (System.Decimal)reader[((int)EntPolicyGradingDtlColumn.EntPolicyGradingDtlId - 1)];
			entity.OriginalEntPolicyGradingDtlId = (System.Decimal)reader["ENT_POLICY_GRADING_DTL_ID"];
			entity.EntPolicyGradingHdrId = (System.Decimal)reader[((int)EntPolicyGradingDtlColumn.EntPolicyGradingHdrId - 1)];
			entity.EdCodeGradingId = (System.Decimal)reader[((int)EntPolicyGradingDtlColumn.EdCodeGradingId - 1)];
			entity.DescrAr = (System.String)reader[((int)EntPolicyGradingDtlColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EntPolicyGradingDtlColumn.DescrEn - 1)))?null:(System.String)reader[((int)EntPolicyGradingDtlColumn.DescrEn - 1)];
			entity.GradCode = (reader.IsDBNull(((int)EntPolicyGradingDtlColumn.GradCode - 1)))?null:(System.String)reader[((int)EntPolicyGradingDtlColumn.GradCode - 1)];
			entity.SymbolAr = (reader.IsDBNull(((int)EntPolicyGradingDtlColumn.SymbolAr - 1)))?null:(System.String)reader[((int)EntPolicyGradingDtlColumn.SymbolAr - 1)];
			entity.SymbolEn = (reader.IsDBNull(((int)EntPolicyGradingDtlColumn.SymbolEn - 1)))?null:(System.String)reader[((int)EntPolicyGradingDtlColumn.SymbolEn - 1)];
			entity.GradOrder = (System.Decimal)reader[((int)EntPolicyGradingDtlColumn.GradOrder - 1)];
			entity.MinRate = (reader.IsDBNull(((int)EntPolicyGradingDtlColumn.MinRate - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingDtlColumn.MinRate - 1)];
			entity.MaxRate = (reader.IsDBNull(((int)EntPolicyGradingDtlColumn.MaxRate - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingDtlColumn.MaxRate - 1)];
			entity.GsCodePassFailId = (System.Decimal)reader[((int)EntPolicyGradingDtlColumn.GsCodePassFailId - 1)];
			entity.Points = (reader.IsDBNull(((int)EntPolicyGradingDtlColumn.Points - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingDtlColumn.Points - 1)];
			entity.MinPrcent = (reader.IsDBNull(((int)EntPolicyGradingDtlColumn.MinPrcent - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingDtlColumn.MinPrcent - 1)];
			entity.MaxPrcent = (reader.IsDBNull(((int)EntPolicyGradingDtlColumn.MaxPrcent - 1)))?null:(System.Decimal?)reader[((int)EntPolicyGradingDtlColumn.MaxPrcent - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyGradingDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyGradingDtlId = (System.Decimal)dataRow["ENT_POLICY_GRADING_DTL_ID"];
			entity.OriginalEntPolicyGradingDtlId = (System.Decimal)dataRow["ENT_POLICY_GRADING_DTL_ID"];
			entity.EntPolicyGradingHdrId = (System.Decimal)dataRow["ENT_POLICY_GRADING_HDR_ID"];
			entity.EdCodeGradingId = (System.Decimal)dataRow["ED_CODE_GRADING_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.GradCode = Convert.IsDBNull(dataRow["GRAD_CODE"]) ? null : (System.String)dataRow["GRAD_CODE"];
			entity.SymbolAr = Convert.IsDBNull(dataRow["SYMBOL_AR"]) ? null : (System.String)dataRow["SYMBOL_AR"];
			entity.SymbolEn = Convert.IsDBNull(dataRow["SYMBOL_EN"]) ? null : (System.String)dataRow["SYMBOL_EN"];
			entity.GradOrder = (System.Decimal)dataRow["GRAD_ORDER"];
			entity.MinRate = Convert.IsDBNull(dataRow["MIN_RATE"]) ? null : (System.Decimal?)dataRow["MIN_RATE"];
			entity.MaxRate = Convert.IsDBNull(dataRow["MAX_RATE"]) ? null : (System.Decimal?)dataRow["MAX_RATE"];
			entity.GsCodePassFailId = (System.Decimal)dataRow["GS_CODE_PASS_FAIL_ID"];
			entity.Points = Convert.IsDBNull(dataRow["POINTS"]) ? null : (System.Decimal?)dataRow["POINTS"];
			entity.MinPrcent = Convert.IsDBNull(dataRow["MIN_PRCENT"]) ? null : (System.Decimal?)dataRow["MIN_PRCENT"];
			entity.MaxPrcent = Convert.IsDBNull(dataRow["MAX_PRCENT"]) ? null : (System.Decimal?)dataRow["MAX_PRCENT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyGradingDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyGradingDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeGradingIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeGradingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeGradingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeGradingId;
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeGradingIdSource = tmpEntity;
				else
					entity.EdCodeGradingIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeGradingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeGradingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.EdCodeGradingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeGradingIdSource

			#region EntPolicyGradingHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyGradingHdr|EntPolicyGradingHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyGradingHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntPolicyGradingHdrId;
				EntPolicyGradingHdr tmpEntity = EntityManager.LocateEntity<EntPolicyGradingHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyGradingHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyGradingHdrIdSource = tmpEntity;
				else
					entity.EntPolicyGradingHdrIdSource = DataRepository.EntPolicyGradingHdrProvider.GetByEntPolicyGradingHdrId(transactionManager, entity.EntPolicyGradingHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyGradingHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyGradingHdrProvider.DeepLoad(transactionManager, entity.EntPolicyGradingHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyGradingHdrIdSource

			#region GsCodePassFailIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|GsCodePassFailIdSource", deepLoadType, innerList) 
				&& entity.GsCodePassFailIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodePassFailId;
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePassFailIdSource = tmpEntity;
				else
					entity.GsCodePassFailIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePassFailIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePassFailIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.GsCodePassFailIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePassFailIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyGradingDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyGradingDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyGradingDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyGradingDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingIdSource);
				entity.EdCodeGradingId = entity.EdCodeGradingIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EntPolicyGradingHdrIdSource
			if (CanDeepSave(entity, "EntPolicyGradingHdr|EntPolicyGradingHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyGradingHdrIdSource != null)
			{
				DataRepository.EntPolicyGradingHdrProvider.Save(transactionManager, entity.EntPolicyGradingHdrIdSource);
				entity.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
			}
			#endregion 
			
			#region GsCodePassFailIdSource
			if (CanDeepSave(entity, "GsCodePassFail|GsCodePassFailIdSource", deepSaveType, innerList) 
				&& entity.GsCodePassFailIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.GsCodePassFailIdSource);
				entity.GsCodePassFailId = entity.GsCodePassFailIdSource.GsCodePassFailId;
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
	
	#region EntPolicyGradingDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyGradingDtl</c>
	///</summary>
	public enum EntPolicyGradingDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EntPolicyGradingHdr</c> at EntPolicyGradingHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyGradingHdr))]
		EntPolicyGradingHdr,
		
		///<summary>
		/// Composite Property for <c>GsCodePassFail</c> at GsCodePassFailIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePassFail))]
		GsCodePassFail,
	}
	
	#endregion EntPolicyGradingDtlChildEntityTypes
	
	#region EntPolicyGradingDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyGradingDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyGradingDtlFilterBuilder : SqlFilterBuilder<EntPolicyGradingDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingDtlFilterBuilder class.
		/// </summary>
		public EntPolicyGradingDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyGradingDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyGradingDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyGradingDtlFilterBuilder
	
	#region EntPolicyGradingDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyGradingDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyGradingDtlParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyGradingDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingDtlParameterBuilder class.
		/// </summary>
		public EntPolicyGradingDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyGradingDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyGradingDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyGradingDtlParameterBuilder
	
	#region EntPolicyGradingDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyGradingDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyGradingDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyGradingDtlSortBuilder : SqlSortBuilder<EntPolicyGradingDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyGradingDtlSqlSortBuilder class.
		/// </summary>
		public EntPolicyGradingDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyGradingDtlSortBuilder
	
} // end namespace
