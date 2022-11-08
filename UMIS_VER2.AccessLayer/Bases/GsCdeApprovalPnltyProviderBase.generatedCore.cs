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
	/// This class is the base class for any <see cref="GsCdeApprovalPnltyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeApprovalPnltyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty, UMIS_VER2.BusinessLyer.GsCdeApprovalPnltyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeApprovalPnltyKey key)
		{
			return Delete(transactionManager, key.GsCdeApprovalPnltyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeApprovalPnltyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeApprovalPnltyId)
		{
			return Delete(null, _gsCdeApprovalPnltyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeApprovalPnltyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeApprovalPnltyId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CDE_PENALTY key.
		///		FK_GS_CDE_APPROVAL_PNLTY_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="_gsCdePenaltyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		public TList<GsCdeApprovalPnlty> GetByGsCdePenaltyId(System.Decimal _gsCdePenaltyId)
		{
			int count = -1;
			return GetByGsCdePenaltyId(_gsCdePenaltyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CDE_PENALTY key.
		///		FK_GS_CDE_APPROVAL_PNLTY_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeApprovalPnlty> GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyId)
		{
			int count = -1;
			return GetByGsCdePenaltyId(transactionManager, _gsCdePenaltyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CDE_PENALTY key.
		///		FK_GS_CDE_APPROVAL_PNLTY_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		public TList<GsCdeApprovalPnlty> GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdePenaltyId(transactionManager, _gsCdePenaltyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CDE_PENALTY key.
		///		fkGsCdeApprovalPnltyGsCdePenalty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		public TList<GsCdeApprovalPnlty> GetByGsCdePenaltyId(System.Decimal _gsCdePenaltyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdePenaltyId(null, _gsCdePenaltyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CDE_PENALTY key.
		///		fkGsCdeApprovalPnltyGsCdePenalty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		public TList<GsCdeApprovalPnlty> GetByGsCdePenaltyId(System.Decimal _gsCdePenaltyId, int start, int pageLength,out int count)
		{
			return GetByGsCdePenaltyId(null, _gsCdePenaltyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CDE_PENALTY key.
		///		FK_GS_CDE_APPROVAL_PNLTY_GS_CDE_PENALTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		public abstract TList<GsCdeApprovalPnlty> GetByGsCdePenaltyId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CODE_APPROVAL key.
		///		FK_GS_CDE_APPROVAL_PNLTY_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		public TList<GsCdeApprovalPnlty> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(_gsCodeApprovalId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CODE_APPROVAL key.
		///		FK_GS_CDE_APPROVAL_PNLTY_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeApprovalPnlty> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CODE_APPROVAL key.
		///		FK_GS_CDE_APPROVAL_PNLTY_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		public TList<GsCdeApprovalPnlty> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CODE_APPROVAL key.
		///		fkGsCdeApprovalPnltyGsCodeApproval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		public TList<GsCdeApprovalPnlty> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CODE_APPROVAL key.
		///		fkGsCdeApprovalPnltyGsCodeApproval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		public TList<GsCdeApprovalPnlty> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength,out int count)
		{
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_APPROVAL_PNLTY_GS_CODE_APPROVAL key.
		///		FK_GS_CDE_APPROVAL_PNLTY_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty objects.</returns>
		public abstract TList<GsCdeApprovalPnlty> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeApprovalPnltyKey key, int start, int pageLength)
		{
			return GetByGsCdeApprovalPnltyId(transactionManager, key.GsCdeApprovalPnltyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="_gsCdeApprovalPnltyId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdeApprovalPnltyId(System.Decimal _gsCdeApprovalPnltyId)
		{
			int count = -1;
			return GetByGsCdeApprovalPnltyId(null,_gsCdeApprovalPnltyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="_gsCdeApprovalPnltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdeApprovalPnltyId(System.Decimal _gsCdeApprovalPnltyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeApprovalPnltyId(null, _gsCdeApprovalPnltyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeApprovalPnltyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdeApprovalPnltyId(TransactionManager transactionManager, System.Decimal _gsCdeApprovalPnltyId)
		{
			int count = -1;
			return GetByGsCdeApprovalPnltyId(transactionManager, _gsCdeApprovalPnltyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeApprovalPnltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdeApprovalPnltyId(TransactionManager transactionManager, System.Decimal _gsCdeApprovalPnltyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeApprovalPnltyId(transactionManager, _gsCdeApprovalPnltyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="_gsCdeApprovalPnltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdeApprovalPnltyId(System.Decimal _gsCdeApprovalPnltyId, int start, int pageLength, out int count)
		{
			return GetByGsCdeApprovalPnltyId(null, _gsCdeApprovalPnltyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeApprovalPnltyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdeApprovalPnltyId(TransactionManager transactionManager, System.Decimal _gsCdeApprovalPnltyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdePenaltyIdGsCodeApprovalId(System.Decimal _gsCdePenaltyId, System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCdePenaltyIdGsCodeApprovalId(null,_gsCdePenaltyId, _gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdePenaltyIdGsCodeApprovalId(System.Decimal _gsCdePenaltyId, System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdePenaltyIdGsCodeApprovalId(null, _gsCdePenaltyId, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdePenaltyIdGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyId, System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCdePenaltyIdGsCodeApprovalId(transactionManager, _gsCdePenaltyId, _gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdePenaltyIdGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyId, System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdePenaltyIdGsCodeApprovalId(transactionManager, _gsCdePenaltyId, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdePenaltyIdGsCodeApprovalId(System.Decimal _gsCdePenaltyId, System.Decimal _gsCodeApprovalId, int start, int pageLength, out int count)
		{
			return GetByGsCdePenaltyIdGsCodeApprovalId(null, _gsCdePenaltyId, _gsCodeApprovalId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_APPROVAL_PNLTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdePenaltyId"></param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty GetByGsCdePenaltyIdGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCdePenaltyId, System.Decimal _gsCodeApprovalId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeApprovalPnlty&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeApprovalPnlty&gt;"/></returns>
		public static TList<GsCdeApprovalPnlty> Fill(IDataReader reader, TList<GsCdeApprovalPnlty> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeApprovalPnlty")
					.Append("|").Append((System.Decimal)reader["GS_CDE_APPROVAL_PNLTY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeApprovalPnlty>(
					key.ToString(), // EntityTrackingKey
					"GsCdeApprovalPnlty",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty();
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
					c.GsCdeApprovalPnltyId = (System.Decimal)reader["GS_CDE_APPROVAL_PNLTY_ID"];
					c.OriginalGsCdeApprovalPnltyId = c.GsCdeApprovalPnltyId;
					c.GsCodeApprovalId = (System.Decimal)reader["GS_CODE_APPROVAL_ID"];
					c.GsCdePenaltyId = (System.Decimal)reader["GS_CDE_PENALTY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeApprovalPnltyId = (System.Decimal)reader[((int)GsCdeApprovalPnltyColumn.GsCdeApprovalPnltyId - 1)];
			entity.OriginalGsCdeApprovalPnltyId = (System.Decimal)reader["GS_CDE_APPROVAL_PNLTY_ID"];
			entity.GsCodeApprovalId = (System.Decimal)reader[((int)GsCdeApprovalPnltyColumn.GsCodeApprovalId - 1)];
			entity.GsCdePenaltyId = (System.Decimal)reader[((int)GsCdeApprovalPnltyColumn.GsCdePenaltyId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeApprovalPnltyId = (System.Decimal)dataRow["GS_CDE_APPROVAL_PNLTY_ID"];
			entity.OriginalGsCdeApprovalPnltyId = (System.Decimal)dataRow["GS_CDE_APPROVAL_PNLTY_ID"];
			entity.GsCodeApprovalId = (System.Decimal)dataRow["GS_CODE_APPROVAL_ID"];
			entity.GsCdePenaltyId = (System.Decimal)dataRow["GS_CDE_PENALTY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCdePenaltyIdSource	
			if (CanDeepLoad(entity, "GsCdePenalty|GsCdePenaltyIdSource", deepLoadType, innerList) 
				&& entity.GsCdePenaltyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdePenaltyId;
				GsCdePenalty tmpEntity = EntityManager.LocateEntity<GsCdePenalty>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdePenalty), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdePenaltyIdSource = tmpEntity;
				else
					entity.GsCdePenaltyIdSource = DataRepository.GsCdePenaltyProvider.GetByGsCdePenaltyId(transactionManager, entity.GsCdePenaltyId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdePenaltyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdePenaltyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdePenaltyProvider.DeepLoad(transactionManager, entity.GsCdePenaltyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdePenaltyIdSource

			#region GsCodeApprovalIdSource	
			if (CanDeepLoad(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeApprovalId;
				GsCodeApproval tmpEntity = EntityManager.LocateEntity<GsCodeApproval>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApproval), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalIdSource = tmpEntity;
				else
					entity.GsCodeApprovalIdSource = DataRepository.GsCodeApprovalProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalProvider.DeepLoad(transactionManager, entity.GsCodeApprovalIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCdePenaltyIdSource
			if (CanDeepSave(entity, "GsCdePenalty|GsCdePenaltyIdSource", deepSaveType, innerList) 
				&& entity.GsCdePenaltyIdSource != null)
			{
				DataRepository.GsCdePenaltyProvider.Save(transactionManager, entity.GsCdePenaltyIdSource);
				entity.GsCdePenaltyId = entity.GsCdePenaltyIdSource.GsCdePenaltyId;
			}
			#endregion 
			
			#region GsCodeApprovalIdSource
			if (CanDeepSave(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalIdSource != null)
			{
				DataRepository.GsCodeApprovalProvider.Save(transactionManager, entity.GsCodeApprovalIdSource);
				entity.GsCodeApprovalId = entity.GsCodeApprovalIdSource.GsCodeApprovalId;
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
	
	#region GsCdeApprovalPnltyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeApprovalPnlty</c>
	///</summary>
	public enum GsCdeApprovalPnltyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCdePenalty</c> at GsCdePenaltyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdePenalty))]
		GsCdePenalty,
		
		///<summary>
		/// Composite Property for <c>GsCodeApproval</c> at GsCodeApprovalIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApproval))]
		GsCodeApproval,
	}
	
	#endregion GsCdeApprovalPnltyChildEntityTypes
	
	#region GsCdeApprovalPnltyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeApprovalPnltyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeApprovalPnlty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeApprovalPnltyFilterBuilder : SqlFilterBuilder<GsCdeApprovalPnltyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeApprovalPnltyFilterBuilder class.
		/// </summary>
		public GsCdeApprovalPnltyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeApprovalPnltyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeApprovalPnltyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeApprovalPnltyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeApprovalPnltyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeApprovalPnltyFilterBuilder
	
	#region GsCdeApprovalPnltyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeApprovalPnltyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeApprovalPnlty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeApprovalPnltyParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeApprovalPnltyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeApprovalPnltyParameterBuilder class.
		/// </summary>
		public GsCdeApprovalPnltyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeApprovalPnltyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeApprovalPnltyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeApprovalPnltyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeApprovalPnltyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeApprovalPnltyParameterBuilder
	
	#region GsCdeApprovalPnltySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeApprovalPnltyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeApprovalPnlty"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeApprovalPnltySortBuilder : SqlSortBuilder<GsCdeApprovalPnltyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeApprovalPnltySqlSortBuilder class.
		/// </summary>
		public GsCdeApprovalPnltySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeApprovalPnltySortBuilder
	
} // end namespace
