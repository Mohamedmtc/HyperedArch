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
	/// This class is the base class for any <see cref="SaTransferProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaTransferProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaTransfer, UMIS_VER2.BusinessLyer.SaTransferKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaTransferKey key)
		{
			return Delete(transactionManager, key.SaTransferId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saTransferId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saTransferId)
		{
			return Delete(null, _saTransferId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTransferId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saTransferId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002d key.
		///		FK_AUTO_002d Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002d key.
		///		FK_AUTO_002d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		/// <remarks></remarks>
		public TList<SaTransfer> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002d key.
		///		FK_AUTO_002d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002d key.
		///		fkAuto002d Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002d key.
		///		fkAuto002d Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002d key.
		///		FK_AUTO_002d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public abstract TList<SaTransfer> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0520 key.
		///		FK_AUTO_0520 Description: 
		/// </summary>
		/// <param name="_saCodeOrgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId)
		{
			int count = -1;
			return GetBySaCodeOrgId(_saCodeOrgId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0520 key.
		///		FK_AUTO_0520 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		/// <remarks></remarks>
		public TList<SaTransfer> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId)
		{
			int count = -1;
			return GetBySaCodeOrgId(transactionManager, _saCodeOrgId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0520 key.
		///		FK_AUTO_0520 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeOrgId(transactionManager, _saCodeOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0520 key.
		///		fkAuto0520 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeOrgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeOrgId(null, _saCodeOrgId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0520 key.
		///		fkAuto0520 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetBySaCodeOrgId(System.Decimal? _saCodeOrgId, int start, int pageLength,out int count)
		{
			return GetBySaCodeOrgId(null, _saCodeOrgId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0520 key.
		///		FK_AUTO_0520 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public abstract TList<SaTransfer> GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal? _saCodeOrgId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_GS_APPROVAL_H key.
		///		FK_SA_TRANSFER_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetByGsApprovalHId(System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(_gsApprovalHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_GS_APPROVAL_H key.
		///		FK_SA_TRANSFER_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		/// <remarks></remarks>
		public TList<SaTransfer> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_GS_APPROVAL_H key.
		///		FK_SA_TRANSFER_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_GS_APPROVAL_H key.
		///		fkSaTransferGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_GS_APPROVAL_H key.
		///		fkSaTransferGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength,out int count)
		{
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_GS_APPROVAL_H key.
		///		FK_SA_TRANSFER_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public abstract TList<SaTransfer> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_SA_STF_MEMBER key.
		///		FK_SA_TRANSFER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_SA_STF_MEMBER key.
		///		FK_SA_TRANSFER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		/// <remarks></remarks>
		public TList<SaTransfer> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_SA_STF_MEMBER key.
		///		FK_SA_TRANSFER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_SA_STF_MEMBER key.
		///		fkSaTransferSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_SA_STF_MEMBER key.
		///		fkSaTransferSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public TList<SaTransfer> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_TRANSFER_SA_STF_MEMBER key.
		///		FK_SA_TRANSFER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaTransfer objects.</returns>
		public abstract TList<SaTransfer> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaTransfer Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaTransferKey key, int start, int pageLength)
		{
			return GetBySaTransferId(transactionManager, key.SaTransferId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_TRANSFER index.
		/// </summary>
		/// <param name="_saTransferId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaTransfer GetBySaTransferId(System.Decimal _saTransferId)
		{
			int count = -1;
			return GetBySaTransferId(null,_saTransferId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_TRANSFER index.
		/// </summary>
		/// <param name="_saTransferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaTransfer GetBySaTransferId(System.Decimal _saTransferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaTransferId(null, _saTransferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_TRANSFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTransferId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaTransfer GetBySaTransferId(TransactionManager transactionManager, System.Decimal _saTransferId)
		{
			int count = -1;
			return GetBySaTransferId(transactionManager, _saTransferId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_TRANSFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTransferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaTransfer GetBySaTransferId(TransactionManager transactionManager, System.Decimal _saTransferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaTransferId(transactionManager, _saTransferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_TRANSFER index.
		/// </summary>
		/// <param name="_saTransferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaTransfer GetBySaTransferId(System.Decimal _saTransferId, int start, int pageLength, out int count)
		{
			return GetBySaTransferId(null, _saTransferId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_TRANSFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTransferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaTransfer GetBySaTransferId(TransactionManager transactionManager, System.Decimal _saTransferId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaTransfer&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaTransfer&gt;"/></returns>
		public static TList<SaTransfer> Fill(IDataReader reader, TList<SaTransfer> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaTransfer c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaTransfer")
					.Append("|").Append((System.Decimal)reader["SA_TRANSFER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaTransfer>(
					key.ToString(), // EntityTrackingKey
					"SaTransfer",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaTransfer();
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
					c.SaTransferId = (System.Decimal)reader["SA_TRANSFER_ID"];
					c.OriginalSaTransferId = c.SaTransferId;
					c.DecisionNum = (System.String)reader["DECISION_NUM"];
					c.DecisionDate = (System.DateTime)reader["DECISION_DATE"];
					c.DecisionSumm = Convert.IsDBNull(reader["DECISION_SUMM"]) ? null : (System.String)reader["DECISION_SUMM"];
					c.TransferStartDate = (System.DateTime)reader["TRANSFER_START_DATE"];
					c.TansferType = (System.Decimal)reader["TANSFER_TYPE"];
					c.IsUniOrg = (System.Decimal)reader["IS_UNI_ORG"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.AsNodeId = Convert.IsDBNull(reader["AS_NODE_ID"]) ? null : (System.Decimal?)reader["AS_NODE_ID"];
					c.SaCodeOrgId = Convert.IsDBNull(reader["SA_CODE_ORG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_ORG_ID"];
					c.GsApprovalHId = (System.Decimal)reader["GS_APPROVAL_H_ID"];
					c.DoseAffectStaffStat = (System.Decimal)reader["DOSE_AFFECT_STAFF_STAT"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.AsNodeIdOld = (System.Decimal)reader["AS_NODE_ID_OLD"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaTransfer entity)
		{
			if (!reader.Read()) return;
			
			entity.SaTransferId = (System.Decimal)reader[((int)SaTransferColumn.SaTransferId - 1)];
			entity.OriginalSaTransferId = (System.Decimal)reader["SA_TRANSFER_ID"];
			entity.DecisionNum = (System.String)reader[((int)SaTransferColumn.DecisionNum - 1)];
			entity.DecisionDate = (System.DateTime)reader[((int)SaTransferColumn.DecisionDate - 1)];
			entity.DecisionSumm = (reader.IsDBNull(((int)SaTransferColumn.DecisionSumm - 1)))?null:(System.String)reader[((int)SaTransferColumn.DecisionSumm - 1)];
			entity.TransferStartDate = (System.DateTime)reader[((int)SaTransferColumn.TransferStartDate - 1)];
			entity.TansferType = (System.Decimal)reader[((int)SaTransferColumn.TansferType - 1)];
			entity.IsUniOrg = (System.Decimal)reader[((int)SaTransferColumn.IsUniOrg - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaTransferColumn.Comments - 1)))?null:(System.String)reader[((int)SaTransferColumn.Comments - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaTransferColumn.SaStfMemberId - 1)];
			entity.AsNodeId = (reader.IsDBNull(((int)SaTransferColumn.AsNodeId - 1)))?null:(System.Decimal?)reader[((int)SaTransferColumn.AsNodeId - 1)];
			entity.SaCodeOrgId = (reader.IsDBNull(((int)SaTransferColumn.SaCodeOrgId - 1)))?null:(System.Decimal?)reader[((int)SaTransferColumn.SaCodeOrgId - 1)];
			entity.GsApprovalHId = (System.Decimal)reader[((int)SaTransferColumn.GsApprovalHId - 1)];
			entity.DoseAffectStaffStat = (System.Decimal)reader[((int)SaTransferColumn.DoseAffectStaffStat - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaTransferColumn.AsFacultyInfoId - 1)];
			entity.AsNodeIdOld = (System.Decimal)reader[((int)SaTransferColumn.AsNodeIdOld - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaTransfer entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaTransferId = (System.Decimal)dataRow["SA_TRANSFER_ID"];
			entity.OriginalSaTransferId = (System.Decimal)dataRow["SA_TRANSFER_ID"];
			entity.DecisionNum = (System.String)dataRow["DECISION_NUM"];
			entity.DecisionDate = (System.DateTime)dataRow["DECISION_DATE"];
			entity.DecisionSumm = Convert.IsDBNull(dataRow["DECISION_SUMM"]) ? null : (System.String)dataRow["DECISION_SUMM"];
			entity.TransferStartDate = (System.DateTime)dataRow["TRANSFER_START_DATE"];
			entity.TansferType = (System.Decimal)dataRow["TANSFER_TYPE"];
			entity.IsUniOrg = (System.Decimal)dataRow["IS_UNI_ORG"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.AsNodeId = Convert.IsDBNull(dataRow["AS_NODE_ID"]) ? null : (System.Decimal?)dataRow["AS_NODE_ID"];
			entity.SaCodeOrgId = Convert.IsDBNull(dataRow["SA_CODE_ORG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_ORG_ID"];
			entity.GsApprovalHId = (System.Decimal)dataRow["GS_APPROVAL_H_ID"];
			entity.DoseAffectStaffStat = (System.Decimal)dataRow["DOSE_AFFECT_STAFF_STAT"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.AsNodeIdOld = (System.Decimal)dataRow["AS_NODE_ID_OLD"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaTransfer"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaTransfer Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaTransfer entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsApprovalHIdSource	
			if (CanDeepLoad(entity, "GsApprovalH|GsApprovalHIdSource", deepLoadType, innerList) 
				&& entity.GsApprovalHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsApprovalHId;
				GsApprovalH tmpEntity = EntityManager.LocateEntity<GsApprovalH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsApprovalH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsApprovalHIdSource = tmpEntity;
				else
					entity.GsApprovalHIdSource = DataRepository.GsApprovalHProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);		
				
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
			// Deep load child collections  - Call GetBySaTransferId methods when available
			
			#region SaServTerminCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaServTermin>|SaServTerminCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaServTerminCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaServTerminCollection = DataRepository.SaServTerminProvider.GetBySaTransferId(transactionManager, entity.SaTransferId);

				if (deep && entity.SaServTerminCollection.Count > 0)
				{
					deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaServTermin>) DataRepository.SaServTerminProvider.DeepLoad,
						new object[] { transactionManager, entity.SaServTerminCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaTransfer object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaTransfer instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaTransfer Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaTransfer entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SaCodeOrgIdSource
			if (CanDeepSave(entity, "SaCodeOrg|SaCodeOrgIdSource", deepSaveType, innerList) 
				&& entity.SaCodeOrgIdSource != null)
			{
				DataRepository.SaCodeOrgProvider.Save(transactionManager, entity.SaCodeOrgIdSource);
				entity.SaCodeOrgId = entity.SaCodeOrgIdSource.SaCodeOrgId;
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
	
			#region List<SaServTermin>
				if (CanDeepSave(entity.SaServTerminCollection, "List<SaServTermin>|SaServTerminCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaServTermin child in entity.SaServTerminCollection)
					{
						if(child.SaTransferIdSource != null)
						{
							child.SaTransferId = child.SaTransferIdSource.SaTransferId;
						}
						else
						{
							child.SaTransferId = entity.SaTransferId;
						}

					}

					if (entity.SaServTerminCollection.Count > 0 || entity.SaServTerminCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaServTerminProvider.Save(transactionManager, entity.SaServTerminCollection);
						
						deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaServTermin >) DataRepository.SaServTerminProvider.DeepSave,
							new object[] { transactionManager, entity.SaServTerminCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaTransferChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaTransfer</c>
	///</summary>
	public enum SaTransferChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaCodeOrg</c> at SaCodeOrgIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeOrg))]
		SaCodeOrg,
		
		///<summary>
		/// Composite Property for <c>GsApprovalH</c> at GsApprovalHIdSource
		///</summary>
		[ChildEntityType(typeof(GsApprovalH))]
		GsApprovalH,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		///<summary>
		/// Collection of <c>SaTransfer</c> as OneToMany for SaServTerminCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaServTermin>))]
		SaServTerminCollection,
	}
	
	#endregion SaTransferChildEntityTypes
	
	#region SaTransferFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaTransferColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaTransfer"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaTransferFilterBuilder : SqlFilterBuilder<SaTransferColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaTransferFilterBuilder class.
		/// </summary>
		public SaTransferFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaTransferFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaTransferFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaTransferFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaTransferFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaTransferFilterBuilder
	
	#region SaTransferParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaTransferColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaTransfer"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaTransferParameterBuilder : ParameterizedSqlFilterBuilder<SaTransferColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaTransferParameterBuilder class.
		/// </summary>
		public SaTransferParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaTransferParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaTransferParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaTransferParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaTransferParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaTransferParameterBuilder
	
	#region SaTransferSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaTransferColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaTransfer"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaTransferSortBuilder : SqlSortBuilder<SaTransferColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaTransferSqlSortBuilder class.
		/// </summary>
		public SaTransferSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaTransferSortBuilder
	
} // end namespace
