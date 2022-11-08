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
	/// This class is the base class for any <see cref="GsMilitaryOfficeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsMilitaryOfficeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsMilitaryOffice, UMIS_VER2.BusinessLyer.GsMilitaryOfficeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsMilitaryOfficeKey key)
		{
			return Delete(transactionManager, key.GsMilitaryOfficeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsMilitaryOfficeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsMilitaryOfficeId)
		{
			return Delete(null, _gsMilitaryOfficeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryOfficeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsMilitaryOfficeId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsMilitaryOffice Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsMilitaryOfficeKey key, int start, int pageLength)
		{
			return GetByGsMilitaryOfficeId(transactionManager, key.GsMilitaryOfficeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public TList<GsMilitaryOffice> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(null,_gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public TList<GsMilitaryOffice> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public TList<GsMilitaryOffice> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public TList<GsMilitaryOffice> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public TList<GsMilitaryOffice> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength, out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public abstract TList<GsMilitaryOffice> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_MILITARY_REGION_I_1 index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public TList<GsMilitaryOffice> GetByGsMilitaryRegionId(System.Decimal _gsMilitaryRegionId)
		{
			int count = -1;
			return GetByGsMilitaryRegionId(null,_gsMilitaryRegionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_MILITARY_REGION_I_1 index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public TList<GsMilitaryOffice> GetByGsMilitaryRegionId(System.Decimal _gsMilitaryRegionId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryRegionId(null, _gsMilitaryRegionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_MILITARY_REGION_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public TList<GsMilitaryOffice> GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId)
		{
			int count = -1;
			return GetByGsMilitaryRegionId(transactionManager, _gsMilitaryRegionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_MILITARY_REGION_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public TList<GsMilitaryOffice> GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryRegionId(transactionManager, _gsMilitaryRegionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_MILITARY_REGION_I_1 index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public TList<GsMilitaryOffice> GetByGsMilitaryRegionId(System.Decimal _gsMilitaryRegionId, int start, int pageLength, out int count)
		{
			return GetByGsMilitaryRegionId(null, _gsMilitaryRegionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_MILITARY_REGION_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsMilitaryOffice&gt;"/> class.</returns>
		public abstract TList<GsMilitaryOffice> GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_MILITARY_OFFICE index.
		/// </summary>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryOfficeId(System.Decimal _gsMilitaryOfficeId)
		{
			int count = -1;
			return GetByGsMilitaryOfficeId(null,_gsMilitaryOfficeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_MILITARY_OFFICE index.
		/// </summary>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryOfficeId(System.Decimal _gsMilitaryOfficeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryOfficeId(null, _gsMilitaryOfficeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_MILITARY_OFFICE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryOfficeId(TransactionManager transactionManager, System.Decimal _gsMilitaryOfficeId)
		{
			int count = -1;
			return GetByGsMilitaryOfficeId(transactionManager, _gsMilitaryOfficeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_MILITARY_OFFICE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryOfficeId(TransactionManager transactionManager, System.Decimal _gsMilitaryOfficeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryOfficeId(transactionManager, _gsMilitaryOfficeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_MILITARY_OFFICE index.
		/// </summary>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryOfficeId(System.Decimal _gsMilitaryOfficeId, int start, int pageLength, out int count)
		{
			return GetByGsMilitaryOfficeId(null, _gsMilitaryOfficeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_MILITARY_OFFICE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryOfficeId(TransactionManager transactionManager, System.Decimal _gsMilitaryOfficeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_MILITARY_OFFICE_AR index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrAr(System.Decimal _gsMilitaryRegionId, System.String _officeDescrAr)
		{
			int count = -1;
			return GetByGsMilitaryRegionIdOfficeDescrAr(null,_gsMilitaryRegionId, _officeDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_OFFICE_AR index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrAr(System.Decimal _gsMilitaryRegionId, System.String _officeDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryRegionIdOfficeDescrAr(null, _gsMilitaryRegionId, _officeDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_OFFICE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrAr(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, System.String _officeDescrAr)
		{
			int count = -1;
			return GetByGsMilitaryRegionIdOfficeDescrAr(transactionManager, _gsMilitaryRegionId, _officeDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_OFFICE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrAr(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, System.String _officeDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryRegionIdOfficeDescrAr(transactionManager, _gsMilitaryRegionId, _officeDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_OFFICE_AR index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrAr(System.Decimal _gsMilitaryRegionId, System.String _officeDescrAr, int start, int pageLength, out int count)
		{
			return GetByGsMilitaryRegionIdOfficeDescrAr(null, _gsMilitaryRegionId, _officeDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_OFFICE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrAr(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, System.String _officeDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_MILITARY_OFFICE_EN index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrEn(System.Decimal _gsMilitaryRegionId, System.String _officeDescrEn)
		{
			int count = -1;
			return GetByGsMilitaryRegionIdOfficeDescrEn(null,_gsMilitaryRegionId, _officeDescrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_OFFICE_EN index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrEn(System.Decimal _gsMilitaryRegionId, System.String _officeDescrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryRegionIdOfficeDescrEn(null, _gsMilitaryRegionId, _officeDescrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_OFFICE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrEn(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, System.String _officeDescrEn)
		{
			int count = -1;
			return GetByGsMilitaryRegionIdOfficeDescrEn(transactionManager, _gsMilitaryRegionId, _officeDescrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_OFFICE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrEn(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, System.String _officeDescrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryRegionIdOfficeDescrEn(transactionManager, _gsMilitaryRegionId, _officeDescrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_OFFICE_EN index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrEn(System.Decimal _gsMilitaryRegionId, System.String _officeDescrEn, int start, int pageLength, out int count)
		{
			return GetByGsMilitaryRegionIdOfficeDescrEn(null, _gsMilitaryRegionId, _officeDescrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_OFFICE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="_officeDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsMilitaryOffice GetByGsMilitaryRegionIdOfficeDescrEn(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, System.String _officeDescrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsMilitaryOffice&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsMilitaryOffice&gt;"/></returns>
		public static TList<GsMilitaryOffice> Fill(IDataReader reader, TList<GsMilitaryOffice> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsMilitaryOffice c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsMilitaryOffice")
					.Append("|").Append((System.Decimal)reader["GS_MILITARY_OFFICE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsMilitaryOffice>(
					key.ToString(), // EntityTrackingKey
					"GsMilitaryOffice",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsMilitaryOffice();
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
					c.GsMilitaryOfficeId = (System.Decimal)reader["GS_MILITARY_OFFICE_ID"];
					c.OriginalGsMilitaryOfficeId = c.GsMilitaryOfficeId;
					c.GsMilitaryRegionId = (System.Decimal)reader["GS_MILITARY_REGION_ID"];
					c.GsCountryNodeId = (System.Decimal)reader["GS_COUNTRY_NODE_ID"];
					c.OfficeDescrAr = (System.String)reader["OFFICE_DESCR_AR"];
					c.OfficeDescrEn = Convert.IsDBNull(reader["OFFICE_DESCR_EN"]) ? null : (System.String)reader["OFFICE_DESCR_EN"];
					c.OfficeCode = Convert.IsDBNull(reader["OFFICE_CODE"]) ? null : (System.String)reader["OFFICE_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsMilitaryOffice entity)
		{
			if (!reader.Read()) return;
			
			entity.GsMilitaryOfficeId = (System.Decimal)reader[((int)GsMilitaryOfficeColumn.GsMilitaryOfficeId - 1)];
			entity.OriginalGsMilitaryOfficeId = (System.Decimal)reader["GS_MILITARY_OFFICE_ID"];
			entity.GsMilitaryRegionId = (System.Decimal)reader[((int)GsMilitaryOfficeColumn.GsMilitaryRegionId - 1)];
			entity.GsCountryNodeId = (System.Decimal)reader[((int)GsMilitaryOfficeColumn.GsCountryNodeId - 1)];
			entity.OfficeDescrAr = (System.String)reader[((int)GsMilitaryOfficeColumn.OfficeDescrAr - 1)];
			entity.OfficeDescrEn = (reader.IsDBNull(((int)GsMilitaryOfficeColumn.OfficeDescrEn - 1)))?null:(System.String)reader[((int)GsMilitaryOfficeColumn.OfficeDescrEn - 1)];
			entity.OfficeCode = (reader.IsDBNull(((int)GsMilitaryOfficeColumn.OfficeCode - 1)))?null:(System.String)reader[((int)GsMilitaryOfficeColumn.OfficeCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsMilitaryOffice entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsMilitaryOfficeId = (System.Decimal)dataRow["GS_MILITARY_OFFICE_ID"];
			entity.OriginalGsMilitaryOfficeId = (System.Decimal)dataRow["GS_MILITARY_OFFICE_ID"];
			entity.GsMilitaryRegionId = (System.Decimal)dataRow["GS_MILITARY_REGION_ID"];
			entity.GsCountryNodeId = (System.Decimal)dataRow["GS_COUNTRY_NODE_ID"];
			entity.OfficeDescrAr = (System.String)dataRow["OFFICE_DESCR_AR"];
			entity.OfficeDescrEn = Convert.IsDBNull(dataRow["OFFICE_DESCR_EN"]) ? null : (System.String)dataRow["OFFICE_DESCR_EN"];
			entity.OfficeCode = Convert.IsDBNull(dataRow["OFFICE_CODE"]) ? null : (System.String)dataRow["OFFICE_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsMilitaryOffice"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsMilitaryOffice Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsMilitaryOffice entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCountryNodeId;
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource

			#region GsMilitaryRegionIdSource	
			if (CanDeepLoad(entity, "GsMilitaryRegion|GsMilitaryRegionIdSource", deepLoadType, innerList) 
				&& entity.GsMilitaryRegionIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsMilitaryRegionId;
				GsMilitaryRegion tmpEntity = EntityManager.LocateEntity<GsMilitaryRegion>(EntityLocator.ConstructKeyFromPkItems(typeof(GsMilitaryRegion), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsMilitaryRegionIdSource = tmpEntity;
				else
					entity.GsMilitaryRegionIdSource = DataRepository.GsMilitaryRegionProvider.GetByGsMilitaryRegionId(transactionManager, entity.GsMilitaryRegionId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsMilitaryRegionIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsMilitaryRegionIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsMilitaryRegionProvider.DeepLoad(transactionManager, entity.GsMilitaryRegionIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsMilitaryRegionIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsMilitaryOfficeId methods when available
			
			#region SaMiltaryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaMiltary>|SaMiltaryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaMiltaryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaMiltaryCollection = DataRepository.SaMiltaryProvider.GetByGsMilitaryOfficeId(transactionManager, entity.GsMilitaryOfficeId);

				if (deep && entity.SaMiltaryCollection.Count > 0)
				{
					deepHandles.Add("SaMiltaryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaMiltary>) DataRepository.SaMiltaryProvider.DeepLoad,
						new object[] { transactionManager, entity.SaMiltaryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudMilitaryInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMilitaryInfo>|EdStudMilitaryInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMilitaryInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMilitaryInfoCollection = DataRepository.EdStudMilitaryInfoProvider.GetByGsMilitaryOfficeId(transactionManager, entity.GsMilitaryOfficeId);

				if (deep && entity.EdStudMilitaryInfoCollection.Count > 0)
				{
					deepHandles.Add("EdStudMilitaryInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMilitaryInfo>) DataRepository.EdStudMilitaryInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMilitaryInfoCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsMilitaryOffice object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsMilitaryOffice instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsMilitaryOffice Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsMilitaryOffice entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			
			#region GsMilitaryRegionIdSource
			if (CanDeepSave(entity, "GsMilitaryRegion|GsMilitaryRegionIdSource", deepSaveType, innerList) 
				&& entity.GsMilitaryRegionIdSource != null)
			{
				DataRepository.GsMilitaryRegionProvider.Save(transactionManager, entity.GsMilitaryRegionIdSource);
				entity.GsMilitaryRegionId = entity.GsMilitaryRegionIdSource.GsMilitaryRegionId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaMiltary>
				if (CanDeepSave(entity.SaMiltaryCollection, "List<SaMiltary>|SaMiltaryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaMiltary child in entity.SaMiltaryCollection)
					{
						if(child.GsMilitaryOfficeIdSource != null)
						{
							child.GsMilitaryOfficeId = child.GsMilitaryOfficeIdSource.GsMilitaryOfficeId;
						}
						else
						{
							child.GsMilitaryOfficeId = entity.GsMilitaryOfficeId;
						}

					}

					if (entity.SaMiltaryCollection.Count > 0 || entity.SaMiltaryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaMiltaryProvider.Save(transactionManager, entity.SaMiltaryCollection);
						
						deepHandles.Add("SaMiltaryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaMiltary >) DataRepository.SaMiltaryProvider.DeepSave,
							new object[] { transactionManager, entity.SaMiltaryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudMilitaryInfo>
				if (CanDeepSave(entity.EdStudMilitaryInfoCollection, "List<EdStudMilitaryInfo>|EdStudMilitaryInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMilitaryInfo child in entity.EdStudMilitaryInfoCollection)
					{
						if(child.GsMilitaryOfficeIdSource != null)
						{
							child.GsMilitaryOfficeId = child.GsMilitaryOfficeIdSource.GsMilitaryOfficeId;
						}
						else
						{
							child.GsMilitaryOfficeId = entity.GsMilitaryOfficeId;
						}

					}

					if (entity.EdStudMilitaryInfoCollection.Count > 0 || entity.EdStudMilitaryInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMilitaryInfoProvider.Save(transactionManager, entity.EdStudMilitaryInfoCollection);
						
						deepHandles.Add("EdStudMilitaryInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMilitaryInfo >) DataRepository.EdStudMilitaryInfoProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMilitaryInfoCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsMilitaryOfficeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsMilitaryOffice</c>
	///</summary>
	public enum GsMilitaryOfficeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>GsMilitaryRegion</c> at GsMilitaryRegionIdSource
		///</summary>
		[ChildEntityType(typeof(GsMilitaryRegion))]
		GsMilitaryRegion,
		///<summary>
		/// Collection of <c>GsMilitaryOffice</c> as OneToMany for SaMiltaryCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaMiltary>))]
		SaMiltaryCollection,
		///<summary>
		/// Collection of <c>GsMilitaryOffice</c> as OneToMany for EdStudMilitaryInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMilitaryInfo>))]
		EdStudMilitaryInfoCollection,
	}
	
	#endregion GsMilitaryOfficeChildEntityTypes
	
	#region GsMilitaryOfficeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsMilitaryOfficeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsMilitaryOffice"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsMilitaryOfficeFilterBuilder : SqlFilterBuilder<GsMilitaryOfficeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsMilitaryOfficeFilterBuilder class.
		/// </summary>
		public GsMilitaryOfficeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsMilitaryOfficeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsMilitaryOfficeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsMilitaryOfficeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsMilitaryOfficeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsMilitaryOfficeFilterBuilder
	
	#region GsMilitaryOfficeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsMilitaryOfficeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsMilitaryOffice"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsMilitaryOfficeParameterBuilder : ParameterizedSqlFilterBuilder<GsMilitaryOfficeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsMilitaryOfficeParameterBuilder class.
		/// </summary>
		public GsMilitaryOfficeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsMilitaryOfficeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsMilitaryOfficeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsMilitaryOfficeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsMilitaryOfficeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsMilitaryOfficeParameterBuilder
	
	#region GsMilitaryOfficeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsMilitaryOfficeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsMilitaryOffice"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsMilitaryOfficeSortBuilder : SqlSortBuilder<GsMilitaryOfficeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsMilitaryOfficeSqlSortBuilder class.
		/// </summary>
		public GsMilitaryOfficeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsMilitaryOfficeSortBuilder
	
} // end namespace
