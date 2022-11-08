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
	/// This class is the base class for any <see cref="GsCdeTrainSiteProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeTrainSiteProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeTrainSite, UMIS_VER2.BusinessLyer.GsCdeTrainSiteKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrainSiteKey key)
		{
			return Delete(transactionManager, key.GsCdeTrainSiteId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeTrainSiteId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeTrainSiteId)
		{
			return Delete(null, _gsCdeTrainSiteId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrainSiteId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeTrainSiteId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_ADDRESS_DTL key.
		///		FK_GS_CDE_TRAIN_SITE_GS_ADDRESS_DTL Description: 
		/// </summary>
		/// <param name="_gsAddressDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsAddressDtlId(System.Decimal? _gsAddressDtlId)
		{
			int count = -1;
			return GetByGsAddressDtlId(_gsAddressDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_ADDRESS_DTL key.
		///		FK_GS_CDE_TRAIN_SITE_GS_ADDRESS_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAddressDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeTrainSite> GetByGsAddressDtlId(TransactionManager transactionManager, System.Decimal? _gsAddressDtlId)
		{
			int count = -1;
			return GetByGsAddressDtlId(transactionManager, _gsAddressDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_ADDRESS_DTL key.
		///		FK_GS_CDE_TRAIN_SITE_GS_ADDRESS_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAddressDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsAddressDtlId(TransactionManager transactionManager, System.Decimal? _gsAddressDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsAddressDtlId(transactionManager, _gsAddressDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_ADDRESS_DTL key.
		///		fkGsCdeTrainSiteGsAddressDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsAddressDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsAddressDtlId(System.Decimal? _gsAddressDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsAddressDtlId(null, _gsAddressDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_ADDRESS_DTL key.
		///		fkGsCdeTrainSiteGsAddressDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsAddressDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsAddressDtlId(System.Decimal? _gsAddressDtlId, int start, int pageLength,out int count)
		{
			return GetByGsAddressDtlId(null, _gsAddressDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_ADDRESS_DTL key.
		///		FK_GS_CDE_TRAIN_SITE_GS_ADDRESS_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAddressDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public abstract TList<GsCdeTrainSite> GetByGsAddressDtlId(TransactionManager transactionManager, System.Decimal? _gsAddressDtlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_ACT key.
		///		FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_ACT Description: 
		/// </summary>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsCdeTrnSiteActId(System.Decimal? _gsCdeTrnSiteActId)
		{
			int count = -1;
			return GetByGsCdeTrnSiteActId(_gsCdeTrnSiteActId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_ACT key.
		///		FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_ACT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeTrainSite> GetByGsCdeTrnSiteActId(TransactionManager transactionManager, System.Decimal? _gsCdeTrnSiteActId)
		{
			int count = -1;
			return GetByGsCdeTrnSiteActId(transactionManager, _gsCdeTrnSiteActId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_ACT key.
		///		FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_ACT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsCdeTrnSiteActId(TransactionManager transactionManager, System.Decimal? _gsCdeTrnSiteActId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeTrnSiteActId(transactionManager, _gsCdeTrnSiteActId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_ACT key.
		///		fkGsCdeTrainSiteGsCdeTrnSiteAct Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsCdeTrnSiteActId(System.Decimal? _gsCdeTrnSiteActId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeTrnSiteActId(null, _gsCdeTrnSiteActId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_ACT key.
		///		fkGsCdeTrainSiteGsCdeTrnSiteAct Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsCdeTrnSiteActId(System.Decimal? _gsCdeTrnSiteActId, int start, int pageLength,out int count)
		{
			return GetByGsCdeTrnSiteActId(null, _gsCdeTrnSiteActId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_ACT key.
		///		FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_ACT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public abstract TList<GsCdeTrainSite> GetByGsCdeTrnSiteActId(TransactionManager transactionManager, System.Decimal? _gsCdeTrnSiteActId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_TYPE key.
		///		FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_TYPE Description: 
		/// </summary>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsCdeTrnSiteTypeId(System.Decimal? _gsCdeTrnSiteTypeId)
		{
			int count = -1;
			return GetByGsCdeTrnSiteTypeId(_gsCdeTrnSiteTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_TYPE key.
		///		FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeTrainSite> GetByGsCdeTrnSiteTypeId(TransactionManager transactionManager, System.Decimal? _gsCdeTrnSiteTypeId)
		{
			int count = -1;
			return GetByGsCdeTrnSiteTypeId(transactionManager, _gsCdeTrnSiteTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_TYPE key.
		///		FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsCdeTrnSiteTypeId(TransactionManager transactionManager, System.Decimal? _gsCdeTrnSiteTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeTrnSiteTypeId(transactionManager, _gsCdeTrnSiteTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_TYPE key.
		///		fkGsCdeTrainSiteGsCdeTrnSiteType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsCdeTrnSiteTypeId(System.Decimal? _gsCdeTrnSiteTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeTrnSiteTypeId(null, _gsCdeTrnSiteTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_TYPE key.
		///		fkGsCdeTrainSiteGsCdeTrnSiteType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public TList<GsCdeTrainSite> GetByGsCdeTrnSiteTypeId(System.Decimal? _gsCdeTrnSiteTypeId, int start, int pageLength,out int count)
		{
			return GetByGsCdeTrnSiteTypeId(null, _gsCdeTrnSiteTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_TYPE key.
		///		FK_GS_CDE_TRAIN_SITE_GS_CDE_TRN_SITE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeTrainSite objects.</returns>
		public abstract TList<GsCdeTrainSite> GetByGsCdeTrnSiteTypeId(TransactionManager transactionManager, System.Decimal? _gsCdeTrnSiteTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeTrainSite Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrainSiteKey key, int start, int pageLength)
		{
			return GetByGsCdeTrainSiteId(transactionManager, key.GsCdeTrainSiteId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_TRAIN_SITE index.
		/// </summary>
		/// <param name="_gsCdeTrainSiteId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByGsCdeTrainSiteId(System.Decimal _gsCdeTrainSiteId)
		{
			int count = -1;
			return GetByGsCdeTrainSiteId(null,_gsCdeTrainSiteId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRAIN_SITE index.
		/// </summary>
		/// <param name="_gsCdeTrainSiteId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByGsCdeTrainSiteId(System.Decimal _gsCdeTrainSiteId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeTrainSiteId(null, _gsCdeTrainSiteId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRAIN_SITE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrainSiteId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByGsCdeTrainSiteId(TransactionManager transactionManager, System.Decimal _gsCdeTrainSiteId)
		{
			int count = -1;
			return GetByGsCdeTrainSiteId(transactionManager, _gsCdeTrainSiteId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRAIN_SITE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrainSiteId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByGsCdeTrainSiteId(TransactionManager transactionManager, System.Decimal _gsCdeTrainSiteId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeTrainSiteId(transactionManager, _gsCdeTrainSiteId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRAIN_SITE index.
		/// </summary>
		/// <param name="_gsCdeTrainSiteId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByGsCdeTrainSiteId(System.Decimal _gsCdeTrainSiteId, int start, int pageLength, out int count)
		{
			return GetByGsCdeTrainSiteId(null, _gsCdeTrainSiteId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRAIN_SITE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrainSiteId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByGsCdeTrainSiteId(TransactionManager transactionManager, System.Decimal _gsCdeTrainSiteId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_TRAIN_SITE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrAr(System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(null,_descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRAIN_SITE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrAr(System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRAIN_SITE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrAr(TransactionManager transactionManager, System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRAIN_SITE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRAIN_SITE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrAr(System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRAIN_SITE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_TRAIN_SITE_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrEn(System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(null,_descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRAIN_SITE_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrEn(System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRAIN_SITE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrEn(TransactionManager transactionManager, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRAIN_SITE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRAIN_SITE_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrEn(System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRAIN_SITE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeTrainSite GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeTrainSite&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeTrainSite&gt;"/></returns>
		public static TList<GsCdeTrainSite> Fill(IDataReader reader, TList<GsCdeTrainSite> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeTrainSite c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeTrainSite")
					.Append("|").Append((System.Decimal)reader["GS_CDE_TRAIN_SITE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeTrainSite>(
					key.ToString(), // EntityTrackingKey
					"GsCdeTrainSite",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeTrainSite();
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
					c.GsCdeTrainSiteId = (System.Decimal)reader["GS_CDE_TRAIN_SITE_ID"];
					c.OriginalGsCdeTrainSiteId = c.GsCdeTrainSiteId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.GsCdeTrnSiteActId = Convert.IsDBNull(reader["GS_CDE_TRN_SITE_ACT_ID"]) ? null : (System.Decimal?)reader["GS_CDE_TRN_SITE_ACT_ID"];
					c.GsCdeTrnSiteTypeId = Convert.IsDBNull(reader["GS_CDE_TRN_SITE_TYPE_ID"]) ? null : (System.Decimal?)reader["GS_CDE_TRN_SITE_TYPE_ID"];
					c.GsAddressDtlId = Convert.IsDBNull(reader["GS_ADDRESS_DTL_ID"]) ? null : (System.Decimal?)reader["GS_ADDRESS_DTL_ID"];
					c.PhoneNo = Convert.IsDBNull(reader["PHONE_NO"]) ? null : (System.Decimal?)reader["PHONE_NO"];
					c.MobNo = Convert.IsDBNull(reader["MOB_NO"]) ? null : (System.Decimal?)reader["MOB_NO"];
					c.EMail = Convert.IsDBNull(reader["E_MAIL"]) ? null : (System.String)reader["E_MAIL"];
					c.WebSite = Convert.IsDBNull(reader["WEB_SITE"]) ? null : (System.String)reader["WEB_SITE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeTrainSite entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeTrainSiteId = (System.Decimal)reader[((int)GsCdeTrainSiteColumn.GsCdeTrainSiteId - 1)];
			entity.OriginalGsCdeTrainSiteId = (System.Decimal)reader["GS_CDE_TRAIN_SITE_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeTrainSiteColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdeTrainSiteColumn.DescrEn - 1)];
			entity.GsCdeTrnSiteActId = (reader.IsDBNull(((int)GsCdeTrainSiteColumn.GsCdeTrnSiteActId - 1)))?null:(System.Decimal?)reader[((int)GsCdeTrainSiteColumn.GsCdeTrnSiteActId - 1)];
			entity.GsCdeTrnSiteTypeId = (reader.IsDBNull(((int)GsCdeTrainSiteColumn.GsCdeTrnSiteTypeId - 1)))?null:(System.Decimal?)reader[((int)GsCdeTrainSiteColumn.GsCdeTrnSiteTypeId - 1)];
			entity.GsAddressDtlId = (reader.IsDBNull(((int)GsCdeTrainSiteColumn.GsAddressDtlId - 1)))?null:(System.Decimal?)reader[((int)GsCdeTrainSiteColumn.GsAddressDtlId - 1)];
			entity.PhoneNo = (reader.IsDBNull(((int)GsCdeTrainSiteColumn.PhoneNo - 1)))?null:(System.Decimal?)reader[((int)GsCdeTrainSiteColumn.PhoneNo - 1)];
			entity.MobNo = (reader.IsDBNull(((int)GsCdeTrainSiteColumn.MobNo - 1)))?null:(System.Decimal?)reader[((int)GsCdeTrainSiteColumn.MobNo - 1)];
			entity.EMail = (reader.IsDBNull(((int)GsCdeTrainSiteColumn.EMail - 1)))?null:(System.String)reader[((int)GsCdeTrainSiteColumn.EMail - 1)];
			entity.WebSite = (reader.IsDBNull(((int)GsCdeTrainSiteColumn.WebSite - 1)))?null:(System.String)reader[((int)GsCdeTrainSiteColumn.WebSite - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeTrainSite entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeTrainSiteId = (System.Decimal)dataRow["GS_CDE_TRAIN_SITE_ID"];
			entity.OriginalGsCdeTrainSiteId = (System.Decimal)dataRow["GS_CDE_TRAIN_SITE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.GsCdeTrnSiteActId = Convert.IsDBNull(dataRow["GS_CDE_TRN_SITE_ACT_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_TRN_SITE_ACT_ID"];
			entity.GsCdeTrnSiteTypeId = Convert.IsDBNull(dataRow["GS_CDE_TRN_SITE_TYPE_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_TRN_SITE_TYPE_ID"];
			entity.GsAddressDtlId = Convert.IsDBNull(dataRow["GS_ADDRESS_DTL_ID"]) ? null : (System.Decimal?)dataRow["GS_ADDRESS_DTL_ID"];
			entity.PhoneNo = Convert.IsDBNull(dataRow["PHONE_NO"]) ? null : (System.Decimal?)dataRow["PHONE_NO"];
			entity.MobNo = Convert.IsDBNull(dataRow["MOB_NO"]) ? null : (System.Decimal?)dataRow["MOB_NO"];
			entity.EMail = Convert.IsDBNull(dataRow["E_MAIL"]) ? null : (System.String)dataRow["E_MAIL"];
			entity.WebSite = Convert.IsDBNull(dataRow["WEB_SITE"]) ? null : (System.String)dataRow["WEB_SITE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeTrainSite"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeTrainSite Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrainSite entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsAddressDtlIdSource	
			if (CanDeepLoad(entity, "GsAddressDtl|GsAddressDtlIdSource", deepLoadType, innerList) 
				&& entity.GsAddressDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsAddressDtlId ?? 0.0m);
				GsAddressDtl tmpEntity = EntityManager.LocateEntity<GsAddressDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(GsAddressDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsAddressDtlIdSource = tmpEntity;
				else
					entity.GsAddressDtlIdSource = DataRepository.GsAddressDtlProvider.GetByGsAddressDtlId(transactionManager, (entity.GsAddressDtlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAddressDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsAddressDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsAddressDtlProvider.DeepLoad(transactionManager, entity.GsAddressDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsAddressDtlIdSource

			#region GsCdeTrnSiteActIdSource	
			if (CanDeepLoad(entity, "GsCdeTrnSiteAct|GsCdeTrnSiteActIdSource", deepLoadType, innerList) 
				&& entity.GsCdeTrnSiteActIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeTrnSiteActId ?? 0.0m);
				GsCdeTrnSiteAct tmpEntity = EntityManager.LocateEntity<GsCdeTrnSiteAct>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeTrnSiteAct), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeTrnSiteActIdSource = tmpEntity;
				else
					entity.GsCdeTrnSiteActIdSource = DataRepository.GsCdeTrnSiteActProvider.GetByGsCdeTrnSiteActId(transactionManager, (entity.GsCdeTrnSiteActId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeTrnSiteActIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeTrnSiteActIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeTrnSiteActProvider.DeepLoad(transactionManager, entity.GsCdeTrnSiteActIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeTrnSiteActIdSource

			#region GsCdeTrnSiteTypeIdSource	
			if (CanDeepLoad(entity, "GsCdeTrnSiteType|GsCdeTrnSiteTypeIdSource", deepLoadType, innerList) 
				&& entity.GsCdeTrnSiteTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeTrnSiteTypeId ?? 0.0m);
				GsCdeTrnSiteType tmpEntity = EntityManager.LocateEntity<GsCdeTrnSiteType>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeTrnSiteType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeTrnSiteTypeIdSource = tmpEntity;
				else
					entity.GsCdeTrnSiteTypeIdSource = DataRepository.GsCdeTrnSiteTypeProvider.GetByGsCdeTrnSiteTypeId(transactionManager, (entity.GsCdeTrnSiteTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeTrnSiteTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeTrnSiteTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeTrnSiteTypeProvider.DeepLoad(transactionManager, entity.GsCdeTrnSiteTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeTrnSiteTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeTrainSiteId methods when available
			
			#region GsCdeTrainRespCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeTrainResp>|GsCdeTrainRespCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeTrainRespCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeTrainRespCollection = DataRepository.GsCdeTrainRespProvider.GetByGsCdeTrainSiteId(transactionManager, entity.GsCdeTrainSiteId);

				if (deep && entity.GsCdeTrainRespCollection.Count > 0)
				{
					deepHandles.Add("GsCdeTrainRespCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeTrainResp>) DataRepository.GsCdeTrainRespProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeTrainRespCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdTrainingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTraining>|EdTrainingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTrainingCollection = DataRepository.EdTrainingProvider.GetByGsCdeTrainSite(transactionManager, entity.GsCdeTrainSiteId);

				if (deep && entity.EdTrainingCollection.Count > 0)
				{
					deepHandles.Add("EdTrainingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTraining>) DataRepository.EdTrainingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTrainingCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeTrainSite object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeTrainSite instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeTrainSite Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrainSite entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsAddressDtlIdSource
			if (CanDeepSave(entity, "GsAddressDtl|GsAddressDtlIdSource", deepSaveType, innerList) 
				&& entity.GsAddressDtlIdSource != null)
			{
				DataRepository.GsAddressDtlProvider.Save(transactionManager, entity.GsAddressDtlIdSource);
				entity.GsAddressDtlId = entity.GsAddressDtlIdSource.GsAddressDtlId;
			}
			#endregion 
			
			#region GsCdeTrnSiteActIdSource
			if (CanDeepSave(entity, "GsCdeTrnSiteAct|GsCdeTrnSiteActIdSource", deepSaveType, innerList) 
				&& entity.GsCdeTrnSiteActIdSource != null)
			{
				DataRepository.GsCdeTrnSiteActProvider.Save(transactionManager, entity.GsCdeTrnSiteActIdSource);
				entity.GsCdeTrnSiteActId = entity.GsCdeTrnSiteActIdSource.GsCdeTrnSiteActId;
			}
			#endregion 
			
			#region GsCdeTrnSiteTypeIdSource
			if (CanDeepSave(entity, "GsCdeTrnSiteType|GsCdeTrnSiteTypeIdSource", deepSaveType, innerList) 
				&& entity.GsCdeTrnSiteTypeIdSource != null)
			{
				DataRepository.GsCdeTrnSiteTypeProvider.Save(transactionManager, entity.GsCdeTrnSiteTypeIdSource);
				entity.GsCdeTrnSiteTypeId = entity.GsCdeTrnSiteTypeIdSource.GsCdeTrnSiteTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsCdeTrainResp>
				if (CanDeepSave(entity.GsCdeTrainRespCollection, "List<GsCdeTrainResp>|GsCdeTrainRespCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeTrainResp child in entity.GsCdeTrainRespCollection)
					{
						if(child.GsCdeTrainSiteIdSource != null)
						{
							child.GsCdeTrainSiteId = child.GsCdeTrainSiteIdSource.GsCdeTrainSiteId;
						}
						else
						{
							child.GsCdeTrainSiteId = entity.GsCdeTrainSiteId;
						}

					}

					if (entity.GsCdeTrainRespCollection.Count > 0 || entity.GsCdeTrainRespCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeTrainRespProvider.Save(transactionManager, entity.GsCdeTrainRespCollection);
						
						deepHandles.Add("GsCdeTrainRespCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeTrainResp >) DataRepository.GsCdeTrainRespProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeTrainRespCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdTraining>
				if (CanDeepSave(entity.EdTrainingCollection, "List<EdTraining>|EdTrainingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTraining child in entity.EdTrainingCollection)
					{
						if(child.GsCdeTrainSiteSource != null)
						{
							child.GsCdeTrainSite = child.GsCdeTrainSiteSource.GsCdeTrainSiteId;
						}
						else
						{
							child.GsCdeTrainSite = entity.GsCdeTrainSiteId;
						}

					}

					if (entity.EdTrainingCollection.Count > 0 || entity.EdTrainingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTrainingProvider.Save(transactionManager, entity.EdTrainingCollection);
						
						deepHandles.Add("EdTrainingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTraining >) DataRepository.EdTrainingProvider.DeepSave,
							new object[] { transactionManager, entity.EdTrainingCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeTrainSiteChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeTrainSite</c>
	///</summary>
	public enum GsCdeTrainSiteChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsAddressDtl</c> at GsAddressDtlIdSource
		///</summary>
		[ChildEntityType(typeof(GsAddressDtl))]
		GsAddressDtl,
		
		///<summary>
		/// Composite Property for <c>GsCdeTrnSiteAct</c> at GsCdeTrnSiteActIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeTrnSiteAct))]
		GsCdeTrnSiteAct,
		
		///<summary>
		/// Composite Property for <c>GsCdeTrnSiteType</c> at GsCdeTrnSiteTypeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeTrnSiteType))]
		GsCdeTrnSiteType,
		///<summary>
		/// Collection of <c>GsCdeTrainSite</c> as OneToMany for GsCdeTrainRespCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeTrainResp>))]
		GsCdeTrainRespCollection,
		///<summary>
		/// Collection of <c>GsCdeTrainSite</c> as OneToMany for EdTrainingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTraining>))]
		EdTrainingCollection,
	}
	
	#endregion GsCdeTrainSiteChildEntityTypes
	
	#region GsCdeTrainSiteFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeTrainSiteColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeTrainSite"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeTrainSiteFilterBuilder : SqlFilterBuilder<GsCdeTrainSiteColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeTrainSiteFilterBuilder class.
		/// </summary>
		public GsCdeTrainSiteFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrainSiteFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeTrainSiteFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrainSiteFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeTrainSiteFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeTrainSiteFilterBuilder
	
	#region GsCdeTrainSiteParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeTrainSiteColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeTrainSite"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeTrainSiteParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeTrainSiteColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeTrainSiteParameterBuilder class.
		/// </summary>
		public GsCdeTrainSiteParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrainSiteParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeTrainSiteParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrainSiteParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeTrainSiteParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeTrainSiteParameterBuilder
	
	#region GsCdeTrainSiteSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeTrainSiteColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeTrainSite"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeTrainSiteSortBuilder : SqlSortBuilder<GsCdeTrainSiteColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeTrainSiteSqlSortBuilder class.
		/// </summary>
		public GsCdeTrainSiteSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeTrainSiteSortBuilder
	
} // end namespace
