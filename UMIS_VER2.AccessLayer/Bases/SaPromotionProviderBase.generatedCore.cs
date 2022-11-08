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
	/// This class is the base class for any <see cref="SaPromotionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaPromotionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaPromotion, UMIS_VER2.BusinessLyer.SaPromotionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionKey key)
		{
			return Delete(transactionManager, key.SaPromotionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saPromotionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saPromotionId)
		{
			return Delete(null, _saPromotionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saPromotionId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0021 key.
		///		FK_AUTO_0021 Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0021 key.
		///		FK_AUTO_0021 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotion> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0021 key.
		///		FK_AUTO_0021 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0021 key.
		///		fkAuto0021 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0021 key.
		///		fkAuto0021 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0021 key.
		///		FK_AUTO_0021 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public abstract TList<SaPromotion> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0022 key.
		///		FK_AUTO_0022 Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0022 key.
		///		FK_AUTO_0022 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotion> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0022 key.
		///		FK_AUTO_0022 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0022 key.
		///		fkAuto0022 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0022 key.
		///		fkAuto0022 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0022 key.
		///		FK_AUTO_0022 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public abstract TList<SaPromotion> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_GS_APPROVAL_H key.
		///		FK_SA_PROMOTION_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetByGsApprovalHId(System.Decimal? _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(_gsApprovalHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_GS_APPROVAL_H key.
		///		FK_SA_PROMOTION_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotion> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_GS_APPROVAL_H key.
		///		FK_SA_PROMOTION_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_GS_APPROVAL_H key.
		///		fkSaPromotionGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetByGsApprovalHId(System.Decimal? _gsApprovalHId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_GS_APPROVAL_H key.
		///		fkSaPromotionGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetByGsApprovalHId(System.Decimal? _gsApprovalHId, int start, int pageLength,out int count)
		{
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_GS_APPROVAL_H key.
		///		FK_SA_PROMOTION_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public abstract TList<SaPromotion> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_CODE_SC_DEG key.
		///		FK_SA_PROMOTION_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaCodeScDegId(System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_CODE_SC_DEG key.
		///		FK_SA_PROMOTION_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotion> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_CODE_SC_DEG key.
		///		FK_SA_PROMOTION_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_CODE_SC_DEG key.
		///		fkSaPromotionSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_CODE_SC_DEG key.
		///		fkSaPromotionSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_CODE_SC_DEG key.
		///		FK_SA_PROMOTION_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public abstract TList<SaPromotion> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_SC_COMM_DECISION key.
		///		FK_SA_PROMOTION_SA_SC_COMM_DECISION Description: 
		/// </summary>
		/// <param name="_saScCommDecisionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaScCommDecisionId(System.Decimal? _saScCommDecisionId)
		{
			int count = -1;
			return GetBySaScCommDecisionId(_saScCommDecisionId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_SC_COMM_DECISION key.
		///		FK_SA_PROMOTION_SA_SC_COMM_DECISION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommDecisionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotion> GetBySaScCommDecisionId(TransactionManager transactionManager, System.Decimal? _saScCommDecisionId)
		{
			int count = -1;
			return GetBySaScCommDecisionId(transactionManager, _saScCommDecisionId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_SC_COMM_DECISION key.
		///		FK_SA_PROMOTION_SA_SC_COMM_DECISION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommDecisionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaScCommDecisionId(TransactionManager transactionManager, System.Decimal? _saScCommDecisionId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScCommDecisionId(transactionManager, _saScCommDecisionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_SC_COMM_DECISION key.
		///		fkSaPromotionSaScCommDecision Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScCommDecisionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaScCommDecisionId(System.Decimal? _saScCommDecisionId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaScCommDecisionId(null, _saScCommDecisionId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_SC_COMM_DECISION key.
		///		fkSaPromotionSaScCommDecision Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScCommDecisionId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public TList<SaPromotion> GetBySaScCommDecisionId(System.Decimal? _saScCommDecisionId, int start, int pageLength,out int count)
		{
			return GetBySaScCommDecisionId(null, _saScCommDecisionId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_SA_SC_COMM_DECISION key.
		///		FK_SA_PROMOTION_SA_SC_COMM_DECISION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommDecisionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotion objects.</returns>
		public abstract TList<SaPromotion> GetBySaScCommDecisionId(TransactionManager transactionManager, System.Decimal? _saScCommDecisionId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaPromotion Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionKey key, int start, int pageLength)
		{
			return GetBySaPromotionId(transactionManager, key.SaPromotionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_PROMOTION index.
		/// </summary>
		/// <param name="_saPromotionId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotion GetBySaPromotionId(System.Decimal _saPromotionId)
		{
			int count = -1;
			return GetBySaPromotionId(null,_saPromotionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION index.
		/// </summary>
		/// <param name="_saPromotionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotion GetBySaPromotionId(System.Decimal _saPromotionId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionId(null, _saPromotionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotion GetBySaPromotionId(TransactionManager transactionManager, System.Decimal _saPromotionId)
		{
			int count = -1;
			return GetBySaPromotionId(transactionManager, _saPromotionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotion GetBySaPromotionId(TransactionManager transactionManager, System.Decimal _saPromotionId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionId(transactionManager, _saPromotionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION index.
		/// </summary>
		/// <param name="_saPromotionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotion GetBySaPromotionId(System.Decimal _saPromotionId, int start, int pageLength, out int count)
		{
			return GetBySaPromotionId(null, _saPromotionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaPromotion GetBySaPromotionId(TransactionManager transactionManager, System.Decimal _saPromotionId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaPromotion&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaPromotion&gt;"/></returns>
		public static TList<SaPromotion> Fill(IDataReader reader, TList<SaPromotion> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaPromotion c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaPromotion")
					.Append("|").Append((System.Decimal)reader["SA_PROMOTION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaPromotion>(
					key.ToString(), // EntityTrackingKey
					"SaPromotion",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaPromotion();
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
					c.SaPromotionId = (System.Decimal)reader["SA_PROMOTION_ID"];
					c.OriginalSaPromotionId = c.SaPromotionId;
					c.DecisionNum = (System.String)reader["DECISION_NUM"];
					c.DecisionDate = (System.DateTime)reader["DECISION_DATE"];
					c.StrtWorkFrom = Convert.IsDBNull(reader["STRT_WORK_FROM"]) ? null : (System.DateTime?)reader["STRT_WORK_FROM"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.HistoryDataFlag = (System.Decimal)reader["HISTORY_DATA_FLAG"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaCodeScDegId = (System.Decimal)reader["SA_CODE_SC_DEG_ID"];
					c.GsApprovalHId = Convert.IsDBNull(reader["GS_APPROVAL_H_ID"]) ? null : (System.Decimal?)reader["GS_APPROVAL_H_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.SaScCommDecisionId = Convert.IsDBNull(reader["SA_SC_COMM_DECISION_ID"]) ? null : (System.Decimal?)reader["SA_SC_COMM_DECISION_ID"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.AsNodeId = Convert.IsDBNull(reader["AS_NODE_ID"]) ? null : (System.Decimal?)reader["AS_NODE_ID"];
					c.Salary = Convert.IsDBNull(reader["Salary"]) ? null : (System.Decimal?)reader["Salary"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaPromotion entity)
		{
			if (!reader.Read()) return;
			
			entity.SaPromotionId = (System.Decimal)reader[((int)SaPromotionColumn.SaPromotionId - 1)];
			entity.OriginalSaPromotionId = (System.Decimal)reader["SA_PROMOTION_ID"];
			entity.DecisionNum = (System.String)reader[((int)SaPromotionColumn.DecisionNum - 1)];
			entity.DecisionDate = (System.DateTime)reader[((int)SaPromotionColumn.DecisionDate - 1)];
			entity.StrtWorkFrom = (reader.IsDBNull(((int)SaPromotionColumn.StrtWorkFrom - 1)))?null:(System.DateTime?)reader[((int)SaPromotionColumn.StrtWorkFrom - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaPromotionColumn.Comments - 1)))?null:(System.String)reader[((int)SaPromotionColumn.Comments - 1)];
			entity.HistoryDataFlag = (System.Decimal)reader[((int)SaPromotionColumn.HistoryDataFlag - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaPromotionColumn.SaStfMemberId - 1)];
			entity.SaCodeScDegId = (System.Decimal)reader[((int)SaPromotionColumn.SaCodeScDegId - 1)];
			entity.GsApprovalHId = (reader.IsDBNull(((int)SaPromotionColumn.GsApprovalHId - 1)))?null:(System.Decimal?)reader[((int)SaPromotionColumn.GsApprovalHId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaPromotionColumn.AsFacultyInfoId - 1)];
			entity.SaScCommDecisionId = (reader.IsDBNull(((int)SaPromotionColumn.SaScCommDecisionId - 1)))?null:(System.Decimal?)reader[((int)SaPromotionColumn.SaScCommDecisionId - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)SaPromotionColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)SaPromotionColumn.GsCountryNodeId - 1)];
			entity.AsNodeId = (reader.IsDBNull(((int)SaPromotionColumn.AsNodeId - 1)))?null:(System.Decimal?)reader[((int)SaPromotionColumn.AsNodeId - 1)];
			entity.Salary = (reader.IsDBNull(((int)SaPromotionColumn.Salary - 1)))?null:(System.Decimal?)reader[((int)SaPromotionColumn.Salary - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaPromotion entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaPromotionId = (System.Decimal)dataRow["SA_PROMOTION_ID"];
			entity.OriginalSaPromotionId = (System.Decimal)dataRow["SA_PROMOTION_ID"];
			entity.DecisionNum = (System.String)dataRow["DECISION_NUM"];
			entity.DecisionDate = (System.DateTime)dataRow["DECISION_DATE"];
			entity.StrtWorkFrom = Convert.IsDBNull(dataRow["STRT_WORK_FROM"]) ? null : (System.DateTime?)dataRow["STRT_WORK_FROM"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.HistoryDataFlag = (System.Decimal)dataRow["HISTORY_DATA_FLAG"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeScDegId = (System.Decimal)dataRow["SA_CODE_SC_DEG_ID"];
			entity.GsApprovalHId = Convert.IsDBNull(dataRow["GS_APPROVAL_H_ID"]) ? null : (System.Decimal?)dataRow["GS_APPROVAL_H_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.SaScCommDecisionId = Convert.IsDBNull(dataRow["SA_SC_COMM_DECISION_ID"]) ? null : (System.Decimal?)dataRow["SA_SC_COMM_DECISION_ID"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.AsNodeId = Convert.IsDBNull(dataRow["AS_NODE_ID"]) ? null : (System.Decimal?)dataRow["AS_NODE_ID"];
			entity.Salary = Convert.IsDBNull(dataRow["Salary"]) ? null : (System.Decimal?)dataRow["Salary"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotion"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPromotion Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotion entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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

			#region GsApprovalHIdSource	
			if (CanDeepLoad(entity, "GsApprovalH|GsApprovalHIdSource", deepLoadType, innerList) 
				&& entity.GsApprovalHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsApprovalHId ?? 0.0m);
				GsApprovalH tmpEntity = EntityManager.LocateEntity<GsApprovalH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsApprovalH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsApprovalHIdSource = tmpEntity;
				else
					entity.GsApprovalHIdSource = DataRepository.GsApprovalHProvider.GetByGsApprovalHId(transactionManager, (entity.GsApprovalHId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsApprovalHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsApprovalHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsApprovalHProvider.DeepLoad(transactionManager, entity.GsApprovalHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsApprovalHIdSource

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeScDegId;
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);		
				
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

			#region SaScCommDecisionIdSource	
			if (CanDeepLoad(entity, "SaScCommDecision|SaScCommDecisionIdSource", deepLoadType, innerList) 
				&& entity.SaScCommDecisionIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaScCommDecisionId ?? 0.0m);
				SaScCommDecision tmpEntity = EntityManager.LocateEntity<SaScCommDecision>(EntityLocator.ConstructKeyFromPkItems(typeof(SaScCommDecision), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaScCommDecisionIdSource = tmpEntity;
				else
					entity.SaScCommDecisionIdSource = DataRepository.SaScCommDecisionProvider.GetBySaScCommDecisionId(transactionManager, (entity.SaScCommDecisionId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScCommDecisionIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaScCommDecisionIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaScCommDecisionProvider.DeepLoad(transactionManager, entity.SaScCommDecisionIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaScCommDecisionIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaPromotion object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaPromotion instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPromotion Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotion entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
			
			#region GsApprovalHIdSource
			if (CanDeepSave(entity, "GsApprovalH|GsApprovalHIdSource", deepSaveType, innerList) 
				&& entity.GsApprovalHIdSource != null)
			{
				DataRepository.GsApprovalHProvider.Save(transactionManager, entity.GsApprovalHIdSource);
				entity.GsApprovalHId = entity.GsApprovalHIdSource.GsApprovalHId;
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
			
			#region SaScCommDecisionIdSource
			if (CanDeepSave(entity, "SaScCommDecision|SaScCommDecisionIdSource", deepSaveType, innerList) 
				&& entity.SaScCommDecisionIdSource != null)
			{
				DataRepository.SaScCommDecisionProvider.Save(transactionManager, entity.SaScCommDecisionIdSource);
				entity.SaScCommDecisionId = entity.SaScCommDecisionIdSource.SaScCommDecisionId;
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
	
	#region SaPromotionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaPromotion</c>
	///</summary>
	public enum SaPromotionChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>GsApprovalH</c> at GsApprovalHIdSource
		///</summary>
		[ChildEntityType(typeof(GsApprovalH))]
		GsApprovalH,
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
		///<summary>
		/// Composite Property for <c>SaScCommDecision</c> at SaScCommDecisionIdSource
		///</summary>
		[ChildEntityType(typeof(SaScCommDecision))]
		SaScCommDecision,
	}
	
	#endregion SaPromotionChildEntityTypes
	
	#region SaPromotionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaPromotionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotion"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPromotionFilterBuilder : SqlFilterBuilder<SaPromotionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionFilterBuilder class.
		/// </summary>
		public SaPromotionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPromotionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPromotionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPromotionFilterBuilder
	
	#region SaPromotionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaPromotionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotion"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPromotionParameterBuilder : ParameterizedSqlFilterBuilder<SaPromotionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionParameterBuilder class.
		/// </summary>
		public SaPromotionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPromotionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPromotionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPromotionParameterBuilder
	
	#region SaPromotionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaPromotionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotion"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaPromotionSortBuilder : SqlSortBuilder<SaPromotionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionSqlSortBuilder class.
		/// </summary>
		public SaPromotionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaPromotionSortBuilder
	
} // end namespace
