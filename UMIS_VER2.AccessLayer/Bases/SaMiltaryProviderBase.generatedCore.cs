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
	/// This class is the base class for any <see cref="SaMiltaryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaMiltaryProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaMiltary, UMIS_VER2.BusinessLyer.SaMiltaryKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaMiltaryKey key)
		{
			return Delete(transactionManager, key.SaMiltaryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saMiltaryId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saMiltaryId)
		{
			return Delete(null, _saMiltaryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saMiltaryId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saMiltaryId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001d key.
		///		FK_AUTO_001d Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		public TList<SaMiltary> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001d key.
		///		FK_AUTO_001d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		/// <remarks></remarks>
		public TList<SaMiltary> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001d key.
		///		FK_AUTO_001d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		public TList<SaMiltary> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001d key.
		///		fkAuto001d Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		public TList<SaMiltary> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001d key.
		///		fkAuto001d Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		public TList<SaMiltary> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001d key.
		///		FK_AUTO_001d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		public abstract TList<SaMiltary> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001e key.
		///		FK_AUTO_001e Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		public TList<SaMiltary> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001e key.
		///		FK_AUTO_001e Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		/// <remarks></remarks>
		public TList<SaMiltary> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001e key.
		///		FK_AUTO_001e Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		public TList<SaMiltary> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001e key.
		///		fkAuto001e Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		public TList<SaMiltary> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001e key.
		///		fkAuto001e Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		public TList<SaMiltary> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001e key.
		///		FK_AUTO_001e Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMiltary objects.</returns>
		public abstract TList<SaMiltary> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaMiltary Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaMiltaryKey key, int start, int pageLength)
		{
			return GetBySaMiltaryId(transactionManager, key.SaMiltaryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public abstract TList<SaMiltary> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_MILITARY_OFFICE_I_1 index.
		/// </summary>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsMilitaryOfficeId(System.Decimal _gsMilitaryOfficeId)
		{
			int count = -1;
			return GetByGsMilitaryOfficeId(null,_gsMilitaryOfficeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_MILITARY_OFFICE_I_1 index.
		/// </summary>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsMilitaryOfficeId(System.Decimal _gsMilitaryOfficeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryOfficeId(null, _gsMilitaryOfficeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_MILITARY_OFFICE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsMilitaryOfficeId(TransactionManager transactionManager, System.Decimal _gsMilitaryOfficeId)
		{
			int count = -1;
			return GetByGsMilitaryOfficeId(transactionManager, _gsMilitaryOfficeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_MILITARY_OFFICE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsMilitaryOfficeId(TransactionManager transactionManager, System.Decimal _gsMilitaryOfficeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryOfficeId(transactionManager, _gsMilitaryOfficeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_MILITARY_OFFICE_I_1 index.
		/// </summary>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsMilitaryOfficeId(System.Decimal _gsMilitaryOfficeId, int start, int pageLength, out int count)
		{
			return GetByGsMilitaryOfficeId(null, _gsMilitaryOfficeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_MILITARY_OFFICE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public abstract TList<SaMiltary> GetByGsMilitaryOfficeId(TransactionManager transactionManager, System.Decimal _gsMilitaryOfficeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_MILITARY_REGION_I_1 index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsMilitaryRegionId(System.Decimal _gsMilitaryRegionId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsMilitaryRegionId(System.Decimal _gsMilitaryRegionId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public TList<SaMiltary> GetByGsMilitaryRegionId(System.Decimal _gsMilitaryRegionId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMiltary&gt;"/> class.</returns>
		public abstract TList<SaMiltary> GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_MILTARY index.
		/// </summary>
		/// <param name="_saMiltaryId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaMiltary GetBySaMiltaryId(System.Decimal _saMiltaryId)
		{
			int count = -1;
			return GetBySaMiltaryId(null,_saMiltaryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_MILTARY index.
		/// </summary>
		/// <param name="_saMiltaryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaMiltary GetBySaMiltaryId(System.Decimal _saMiltaryId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaMiltaryId(null, _saMiltaryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_MILTARY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saMiltaryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaMiltary GetBySaMiltaryId(TransactionManager transactionManager, System.Decimal _saMiltaryId)
		{
			int count = -1;
			return GetBySaMiltaryId(transactionManager, _saMiltaryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_MILTARY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saMiltaryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaMiltary GetBySaMiltaryId(TransactionManager transactionManager, System.Decimal _saMiltaryId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaMiltaryId(transactionManager, _saMiltaryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_MILTARY index.
		/// </summary>
		/// <param name="_saMiltaryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaMiltary GetBySaMiltaryId(System.Decimal _saMiltaryId, int start, int pageLength, out int count)
		{
			return GetBySaMiltaryId(null, _saMiltaryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_MILTARY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saMiltaryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaMiltary GetBySaMiltaryId(TransactionManager transactionManager, System.Decimal _saMiltaryId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaMiltary&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaMiltary&gt;"/></returns>
		public static TList<SaMiltary> Fill(IDataReader reader, TList<SaMiltary> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaMiltary c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaMiltary")
					.Append("|").Append((System.Decimal)reader["SA_MILTARY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaMiltary>(
					key.ToString(), // EntityTrackingKey
					"SaMiltary",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaMiltary();
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
					c.SaMiltaryId = (System.Decimal)reader["SA_MILTARY_ID"];
					c.OriginalSaMiltaryId = c.SaMiltaryId;
					c.MilCardNum = (System.String)reader["MIL_CARD_NUM"];
					c.MilCardDate = (System.DateTime)reader["MIL_CARD_DATE"];
					c.MilCertNum = Convert.IsDBNull(reader["MIL_CERT_NUM"]) ? null : (System.String)reader["MIL_CERT_NUM"];
					c.MilCertDate = Convert.IsDBNull(reader["MIL_CERT_DATE"]) ? null : (System.DateTime?)reader["MIL_CERT_DATE"];
					c.MilCertIssOrg = Convert.IsDBNull(reader["MIL_CERT_ISS_ORG"]) ? null : (System.String)reader["MIL_CERT_ISS_ORG"];
					c.MilStartDate = Convert.IsDBNull(reader["MIL_START_DATE"]) ? null : (System.DateTime?)reader["MIL_START_DATE"];
					c.MilReleaseDate = Convert.IsDBNull(reader["MIL_RELEASE_DATE"]) ? null : (System.DateTime?)reader["MIL_RELEASE_DATE"];
					c.UnitNum = Convert.IsDBNull(reader["UNIT_NUM"]) ? null : (System.String)reader["UNIT_NUM"];
					c.MilServEval = Convert.IsDBNull(reader["MIL_SERV_EVAL"]) ? null : (System.String)reader["MIL_SERV_EVAL"];
					c.MilIsSoldier = (System.Decimal)reader["MIL_IS_SOLDIER"];
					c.MilJobPreserveDecNum = Convert.IsDBNull(reader["MIL_JOB_PRESERVE_DEC_NUM"]) ? null : (System.String)reader["MIL_JOB_PRESERVE_DEC_NUM"];
					c.MilJobPreserveDecDate = Convert.IsDBNull(reader["MIL_JOB_PRESERVE_DEC_DATE"]) ? null : (System.DateTime?)reader["MIL_JOB_PRESERVE_DEC_DATE"];
					c.MilComments = Convert.IsDBNull(reader["MIL_COMMENTS"]) ? null : (System.String)reader["MIL_COMMENTS"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.GsMilitaryRegionId = (System.Decimal)reader["GS_MILITARY_REGION_ID"];
					c.GsMilitaryOfficeId = (System.Decimal)reader["GS_MILITARY_OFFICE_ID"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaMiltary entity)
		{
			if (!reader.Read()) return;
			
			entity.SaMiltaryId = (System.Decimal)reader[((int)SaMiltaryColumn.SaMiltaryId - 1)];
			entity.OriginalSaMiltaryId = (System.Decimal)reader["SA_MILTARY_ID"];
			entity.MilCardNum = (System.String)reader[((int)SaMiltaryColumn.MilCardNum - 1)];
			entity.MilCardDate = (System.DateTime)reader[((int)SaMiltaryColumn.MilCardDate - 1)];
			entity.MilCertNum = (reader.IsDBNull(((int)SaMiltaryColumn.MilCertNum - 1)))?null:(System.String)reader[((int)SaMiltaryColumn.MilCertNum - 1)];
			entity.MilCertDate = (reader.IsDBNull(((int)SaMiltaryColumn.MilCertDate - 1)))?null:(System.DateTime?)reader[((int)SaMiltaryColumn.MilCertDate - 1)];
			entity.MilCertIssOrg = (reader.IsDBNull(((int)SaMiltaryColumn.MilCertIssOrg - 1)))?null:(System.String)reader[((int)SaMiltaryColumn.MilCertIssOrg - 1)];
			entity.MilStartDate = (reader.IsDBNull(((int)SaMiltaryColumn.MilStartDate - 1)))?null:(System.DateTime?)reader[((int)SaMiltaryColumn.MilStartDate - 1)];
			entity.MilReleaseDate = (reader.IsDBNull(((int)SaMiltaryColumn.MilReleaseDate - 1)))?null:(System.DateTime?)reader[((int)SaMiltaryColumn.MilReleaseDate - 1)];
			entity.UnitNum = (reader.IsDBNull(((int)SaMiltaryColumn.UnitNum - 1)))?null:(System.String)reader[((int)SaMiltaryColumn.UnitNum - 1)];
			entity.MilServEval = (reader.IsDBNull(((int)SaMiltaryColumn.MilServEval - 1)))?null:(System.String)reader[((int)SaMiltaryColumn.MilServEval - 1)];
			entity.MilIsSoldier = (System.Decimal)reader[((int)SaMiltaryColumn.MilIsSoldier - 1)];
			entity.MilJobPreserveDecNum = (reader.IsDBNull(((int)SaMiltaryColumn.MilJobPreserveDecNum - 1)))?null:(System.String)reader[((int)SaMiltaryColumn.MilJobPreserveDecNum - 1)];
			entity.MilJobPreserveDecDate = (reader.IsDBNull(((int)SaMiltaryColumn.MilJobPreserveDecDate - 1)))?null:(System.DateTime?)reader[((int)SaMiltaryColumn.MilJobPreserveDecDate - 1)];
			entity.MilComments = (reader.IsDBNull(((int)SaMiltaryColumn.MilComments - 1)))?null:(System.String)reader[((int)SaMiltaryColumn.MilComments - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaMiltaryColumn.SaStfMemberId - 1)];
			entity.GsMilitaryRegionId = (System.Decimal)reader[((int)SaMiltaryColumn.GsMilitaryRegionId - 1)];
			entity.GsMilitaryOfficeId = (System.Decimal)reader[((int)SaMiltaryColumn.GsMilitaryOfficeId - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)SaMiltaryColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)SaMiltaryColumn.GsCountryNodeId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaMiltaryColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaMiltary entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaMiltaryId = (System.Decimal)dataRow["SA_MILTARY_ID"];
			entity.OriginalSaMiltaryId = (System.Decimal)dataRow["SA_MILTARY_ID"];
			entity.MilCardNum = (System.String)dataRow["MIL_CARD_NUM"];
			entity.MilCardDate = (System.DateTime)dataRow["MIL_CARD_DATE"];
			entity.MilCertNum = Convert.IsDBNull(dataRow["MIL_CERT_NUM"]) ? null : (System.String)dataRow["MIL_CERT_NUM"];
			entity.MilCertDate = Convert.IsDBNull(dataRow["MIL_CERT_DATE"]) ? null : (System.DateTime?)dataRow["MIL_CERT_DATE"];
			entity.MilCertIssOrg = Convert.IsDBNull(dataRow["MIL_CERT_ISS_ORG"]) ? null : (System.String)dataRow["MIL_CERT_ISS_ORG"];
			entity.MilStartDate = Convert.IsDBNull(dataRow["MIL_START_DATE"]) ? null : (System.DateTime?)dataRow["MIL_START_DATE"];
			entity.MilReleaseDate = Convert.IsDBNull(dataRow["MIL_RELEASE_DATE"]) ? null : (System.DateTime?)dataRow["MIL_RELEASE_DATE"];
			entity.UnitNum = Convert.IsDBNull(dataRow["UNIT_NUM"]) ? null : (System.String)dataRow["UNIT_NUM"];
			entity.MilServEval = Convert.IsDBNull(dataRow["MIL_SERV_EVAL"]) ? null : (System.String)dataRow["MIL_SERV_EVAL"];
			entity.MilIsSoldier = (System.Decimal)dataRow["MIL_IS_SOLDIER"];
			entity.MilJobPreserveDecNum = Convert.IsDBNull(dataRow["MIL_JOB_PRESERVE_DEC_NUM"]) ? null : (System.String)dataRow["MIL_JOB_PRESERVE_DEC_NUM"];
			entity.MilJobPreserveDecDate = Convert.IsDBNull(dataRow["MIL_JOB_PRESERVE_DEC_DATE"]) ? null : (System.DateTime?)dataRow["MIL_JOB_PRESERVE_DEC_DATE"];
			entity.MilComments = Convert.IsDBNull(dataRow["MIL_COMMENTS"]) ? null : (System.String)dataRow["MIL_COMMENTS"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.GsMilitaryRegionId = (System.Decimal)dataRow["GS_MILITARY_REGION_ID"];
			entity.GsMilitaryOfficeId = (System.Decimal)dataRow["GS_MILITARY_OFFICE_ID"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaMiltary"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaMiltary Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaMiltary entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsMilitaryOfficeIdSource	
			if (CanDeepLoad(entity, "GsMilitaryOffice|GsMilitaryOfficeIdSource", deepLoadType, innerList) 
				&& entity.GsMilitaryOfficeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsMilitaryOfficeId;
				GsMilitaryOffice tmpEntity = EntityManager.LocateEntity<GsMilitaryOffice>(EntityLocator.ConstructKeyFromPkItems(typeof(GsMilitaryOffice), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsMilitaryOfficeIdSource = tmpEntity;
				else
					entity.GsMilitaryOfficeIdSource = DataRepository.GsMilitaryOfficeProvider.GetByGsMilitaryOfficeId(transactionManager, entity.GsMilitaryOfficeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsMilitaryOfficeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsMilitaryOfficeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsMilitaryOfficeProvider.DeepLoad(transactionManager, entity.GsMilitaryOfficeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsMilitaryOfficeIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaMiltary object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaMiltary instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaMiltary Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaMiltary entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsMilitaryOfficeIdSource
			if (CanDeepSave(entity, "GsMilitaryOffice|GsMilitaryOfficeIdSource", deepSaveType, innerList) 
				&& entity.GsMilitaryOfficeIdSource != null)
			{
				DataRepository.GsMilitaryOfficeProvider.Save(transactionManager, entity.GsMilitaryOfficeIdSource);
				entity.GsMilitaryOfficeId = entity.GsMilitaryOfficeIdSource.GsMilitaryOfficeId;
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
	
	#region SaMiltaryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaMiltary</c>
	///</summary>
	public enum SaMiltaryChildEntityTypes
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
		/// Composite Property for <c>GsMilitaryOffice</c> at GsMilitaryOfficeIdSource
		///</summary>
		[ChildEntityType(typeof(GsMilitaryOffice))]
		GsMilitaryOffice,
		
		///<summary>
		/// Composite Property for <c>GsMilitaryRegion</c> at GsMilitaryRegionIdSource
		///</summary>
		[ChildEntityType(typeof(GsMilitaryRegion))]
		GsMilitaryRegion,
	}
	
	#endregion SaMiltaryChildEntityTypes
	
	#region SaMiltaryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaMiltaryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaMiltary"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaMiltaryFilterBuilder : SqlFilterBuilder<SaMiltaryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaMiltaryFilterBuilder class.
		/// </summary>
		public SaMiltaryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaMiltaryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaMiltaryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaMiltaryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaMiltaryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaMiltaryFilterBuilder
	
	#region SaMiltaryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaMiltaryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaMiltary"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaMiltaryParameterBuilder : ParameterizedSqlFilterBuilder<SaMiltaryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaMiltaryParameterBuilder class.
		/// </summary>
		public SaMiltaryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaMiltaryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaMiltaryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaMiltaryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaMiltaryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaMiltaryParameterBuilder
	
	#region SaMiltarySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaMiltaryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaMiltary"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaMiltarySortBuilder : SqlSortBuilder<SaMiltaryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaMiltarySqlSortBuilder class.
		/// </summary>
		public SaMiltarySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaMiltarySortBuilder
	
} // end namespace
