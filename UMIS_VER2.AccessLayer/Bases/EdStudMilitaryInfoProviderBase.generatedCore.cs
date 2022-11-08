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
	/// This class is the base class for any <see cref="EdStudMilitaryInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudMilitaryInfoProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudMilitaryInfo, UMIS_VER2.BusinessLyer.EdStudMilitaryInfoKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMilitaryInfoKey key)
		{
			return Delete(transactionManager, key.EdStudMilitaryInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudMilitaryInfoId">بيانات التجنيد. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudMilitaryInfoId)
		{
			return Delete(null, _edStudMilitaryInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMilitaryInfoId">بيانات التجنيد. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudMilitaryInfoId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_02af key.
		///		FK_AUTO_02af Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		public TList<EdStudMilitaryInfo> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_02af key.
		///		FK_AUTO_02af Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudMilitaryInfo> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_02af key.
		///		FK_AUTO_02af Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		public TList<EdStudMilitaryInfo> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_02af key.
		///		fkAuto02af Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		public TList<EdStudMilitaryInfo> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_02af key.
		///		fkAuto02af Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		public TList<EdStudMilitaryInfo> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_02af key.
		///		FK_AUTO_02af Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		public abstract TList<EdStudMilitaryInfo> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_INFO_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_MILITARY_INFO_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		public TList<EdStudMilitaryInfo> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_INFO_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_MILITARY_INFO_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudMilitaryInfo> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_INFO_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_MILITARY_INFO_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		public TList<EdStudMilitaryInfo> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_INFO_ADM_APP_REG_HISTORY key.
		///		fkEdStudMilitaryInfoAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		public TList<EdStudMilitaryInfo> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_INFO_ADM_APP_REG_HISTORY key.
		///		fkEdStudMilitaryInfoAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		public TList<EdStudMilitaryInfo> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_INFO_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_MILITARY_INFO_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryInfo objects.</returns>
		public abstract TList<EdStudMilitaryInfo> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudMilitaryInfo Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMilitaryInfoKey key, int start, int pageLength)
		{
			return GetByEdStudMilitaryInfoId(transactionManager, key.EdStudMilitaryInfoId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_ED_STUD_ID_CODE index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudIdAdmAppRegHistoryId(System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByEdStudIdAdmAppRegHistoryId(null,_edStudId, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ED_STUD_ID_CODE index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudIdAdmAppRegHistoryId(System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdAdmAppRegHistoryId(null, _edStudId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ED_STUD_ID_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByEdStudIdAdmAppRegHistoryId(transactionManager, _edStudId, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ED_STUD_ID_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdAdmAppRegHistoryId(transactionManager, _edStudId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ED_STUD_ID_CODE index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudIdAdmAppRegHistoryId(System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdAdmAppRegHistoryId(null, _edStudId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ED_STUD_ID_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId">XXXX???  confirm delete</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_MILITARY_OFFICE_I_1 index.
		/// </summary>
		/// <param name="_gsMilitaryOfficeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public TList<EdStudMilitaryInfo> GetByGsMilitaryOfficeId(System.Decimal? _gsMilitaryOfficeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public TList<EdStudMilitaryInfo> GetByGsMilitaryOfficeId(System.Decimal? _gsMilitaryOfficeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public TList<EdStudMilitaryInfo> GetByGsMilitaryOfficeId(TransactionManager transactionManager, System.Decimal? _gsMilitaryOfficeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public TList<EdStudMilitaryInfo> GetByGsMilitaryOfficeId(TransactionManager transactionManager, System.Decimal? _gsMilitaryOfficeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public TList<EdStudMilitaryInfo> GetByGsMilitaryOfficeId(System.Decimal? _gsMilitaryOfficeId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public abstract TList<EdStudMilitaryInfo> GetByGsMilitaryOfficeId(TransactionManager transactionManager, System.Decimal? _gsMilitaryOfficeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_MILITARY_REGION_I_1 index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public TList<EdStudMilitaryInfo> GetByGsMilitaryRegionId(System.Decimal? _gsMilitaryRegionId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public TList<EdStudMilitaryInfo> GetByGsMilitaryRegionId(System.Decimal? _gsMilitaryRegionId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public TList<EdStudMilitaryInfo> GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal? _gsMilitaryRegionId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public TList<EdStudMilitaryInfo> GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal? _gsMilitaryRegionId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public TList<EdStudMilitaryInfo> GetByGsMilitaryRegionId(System.Decimal? _gsMilitaryRegionId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryInfo&gt;"/> class.</returns>
		public abstract TList<EdStudMilitaryInfo> GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal? _gsMilitaryRegionId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_MILITARY_INFO index.
		/// </summary>
		/// <param name="_edStudMilitaryInfoId">بيانات التجنيد</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudMilitaryInfoId(System.Decimal _edStudMilitaryInfoId)
		{
			int count = -1;
			return GetByEdStudMilitaryInfoId(null,_edStudMilitaryInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MILITARY_INFO index.
		/// </summary>
		/// <param name="_edStudMilitaryInfoId">بيانات التجنيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudMilitaryInfoId(System.Decimal _edStudMilitaryInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudMilitaryInfoId(null, _edStudMilitaryInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MILITARY_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMilitaryInfoId">بيانات التجنيد</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudMilitaryInfoId(TransactionManager transactionManager, System.Decimal _edStudMilitaryInfoId)
		{
			int count = -1;
			return GetByEdStudMilitaryInfoId(transactionManager, _edStudMilitaryInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MILITARY_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMilitaryInfoId">بيانات التجنيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudMilitaryInfoId(TransactionManager transactionManager, System.Decimal _edStudMilitaryInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudMilitaryInfoId(transactionManager, _edStudMilitaryInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MILITARY_INFO index.
		/// </summary>
		/// <param name="_edStudMilitaryInfoId">بيانات التجنيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudMilitaryInfoId(System.Decimal _edStudMilitaryInfoId, int start, int pageLength, out int count)
		{
			return GetByEdStudMilitaryInfoId(null, _edStudMilitaryInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MILITARY_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMilitaryInfoId">بيانات التجنيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudMilitaryInfo GetByEdStudMilitaryInfoId(TransactionManager transactionManager, System.Decimal _edStudMilitaryInfoId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudMilitaryInfo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudMilitaryInfo&gt;"/></returns>
		public static TList<EdStudMilitaryInfo> Fill(IDataReader reader, TList<EdStudMilitaryInfo> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudMilitaryInfo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudMilitaryInfo")
					.Append("|").Append((System.Decimal)reader["ED_STUD_MILITARY_INFO_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudMilitaryInfo>(
					key.ToString(), // EntityTrackingKey
					"EdStudMilitaryInfo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudMilitaryInfo();
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
					c.EdStudMilitaryInfoId = (System.Decimal)reader["ED_STUD_MILITARY_INFO_ID"];
					c.OriginalEdStudMilitaryInfoId = c.EdStudMilitaryInfoId;
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.MilitaryCardNumber = Convert.IsDBNull(reader["MILITARY_CARD_NUMBER"]) ? null : (System.String)reader["MILITARY_CARD_NUMBER"];
					c.GsMilitaryRegionId = Convert.IsDBNull(reader["GS_MILITARY_REGION_ID"]) ? null : (System.Decimal?)reader["GS_MILITARY_REGION_ID"];
					c.GsMilitaryOfficeId = Convert.IsDBNull(reader["GS_MILITARY_OFFICE_ID"]) ? null : (System.Decimal?)reader["GS_MILITARY_OFFICE_ID"];
					c.InfoNotes = Convert.IsDBNull(reader["INFO_NOTES"]) ? null : (System.String)reader["INFO_NOTES"];
					c.RecruitmentDate = Convert.IsDBNull(reader["RECRUITMENT_DATE"]) ? null : (System.DateTime?)reader["RECRUITMENT_DATE"];
					c.UnitCode = Convert.IsDBNull(reader["UNIT_CODE"]) ? null : (System.String)reader["UNIT_CODE"];
					c.ReleaseDate = Convert.IsDBNull(reader["RELEASE_DATE"]) ? null : (System.DateTime?)reader["RELEASE_DATE"];
					c.StatementNumber = Convert.IsDBNull(reader["STATEMENT_NUMBER"]) ? null : (System.String)reader["STATEMENT_NUMBER"];
					c.ReserveEndDate = Convert.IsDBNull(reader["RESERVE_END_DATE"]) ? null : (System.DateTime?)reader["RESERVE_END_DATE"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudMilitaryInfo entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudMilitaryInfoId = (System.Decimal)reader[((int)EdStudMilitaryInfoColumn.EdStudMilitaryInfoId - 1)];
			entity.OriginalEdStudMilitaryInfoId = (System.Decimal)reader["ED_STUD_MILITARY_INFO_ID"];
			entity.EdStudId = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)EdStudMilitaryInfoColumn.EdStudId - 1)];
			entity.MilitaryCardNumber = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.MilitaryCardNumber - 1)))?null:(System.String)reader[((int)EdStudMilitaryInfoColumn.MilitaryCardNumber - 1)];
			entity.GsMilitaryRegionId = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.GsMilitaryRegionId - 1)))?null:(System.Decimal?)reader[((int)EdStudMilitaryInfoColumn.GsMilitaryRegionId - 1)];
			entity.GsMilitaryOfficeId = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.GsMilitaryOfficeId - 1)))?null:(System.Decimal?)reader[((int)EdStudMilitaryInfoColumn.GsMilitaryOfficeId - 1)];
			entity.InfoNotes = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.InfoNotes - 1)))?null:(System.String)reader[((int)EdStudMilitaryInfoColumn.InfoNotes - 1)];
			entity.RecruitmentDate = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.RecruitmentDate - 1)))?null:(System.DateTime?)reader[((int)EdStudMilitaryInfoColumn.RecruitmentDate - 1)];
			entity.UnitCode = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.UnitCode - 1)))?null:(System.String)reader[((int)EdStudMilitaryInfoColumn.UnitCode - 1)];
			entity.ReleaseDate = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.ReleaseDate - 1)))?null:(System.DateTime?)reader[((int)EdStudMilitaryInfoColumn.ReleaseDate - 1)];
			entity.StatementNumber = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.StatementNumber - 1)))?null:(System.String)reader[((int)EdStudMilitaryInfoColumn.StatementNumber - 1)];
			entity.ReserveEndDate = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.ReserveEndDate - 1)))?null:(System.DateTime?)reader[((int)EdStudMilitaryInfoColumn.ReserveEndDate - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)EdStudMilitaryInfoColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)EdStudMilitaryInfoColumn.AdmAppRegHistoryId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudMilitaryInfo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudMilitaryInfoId = (System.Decimal)dataRow["ED_STUD_MILITARY_INFO_ID"];
			entity.OriginalEdStudMilitaryInfoId = (System.Decimal)dataRow["ED_STUD_MILITARY_INFO_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.MilitaryCardNumber = Convert.IsDBNull(dataRow["MILITARY_CARD_NUMBER"]) ? null : (System.String)dataRow["MILITARY_CARD_NUMBER"];
			entity.GsMilitaryRegionId = Convert.IsDBNull(dataRow["GS_MILITARY_REGION_ID"]) ? null : (System.Decimal?)dataRow["GS_MILITARY_REGION_ID"];
			entity.GsMilitaryOfficeId = Convert.IsDBNull(dataRow["GS_MILITARY_OFFICE_ID"]) ? null : (System.Decimal?)dataRow["GS_MILITARY_OFFICE_ID"];
			entity.InfoNotes = Convert.IsDBNull(dataRow["INFO_NOTES"]) ? null : (System.String)dataRow["INFO_NOTES"];
			entity.RecruitmentDate = Convert.IsDBNull(dataRow["RECRUITMENT_DATE"]) ? null : (System.DateTime?)dataRow["RECRUITMENT_DATE"];
			entity.UnitCode = Convert.IsDBNull(dataRow["UNIT_CODE"]) ? null : (System.String)dataRow["UNIT_CODE"];
			entity.ReleaseDate = Convert.IsDBNull(dataRow["RELEASE_DATE"]) ? null : (System.DateTime?)dataRow["RELEASE_DATE"];
			entity.StatementNumber = Convert.IsDBNull(dataRow["STATEMENT_NUMBER"]) ? null : (System.String)dataRow["STATEMENT_NUMBER"];
			entity.ReserveEndDate = Convert.IsDBNull(dataRow["RESERVE_END_DATE"]) ? null : (System.DateTime?)dataRow["RESERVE_END_DATE"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryInfo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudMilitaryInfo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMilitaryInfo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppRegHistoryId ?? 0.0m);
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, (entity.AdmAppRegHistoryId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppRegHistoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppRegHistoryProvider.DeepLoad(transactionManager, entity.AdmAppRegHistoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppRegHistoryIdSource

			#region GsMilitaryOfficeIdSource	
			if (CanDeepLoad(entity, "GsMilitaryOffice|GsMilitaryOfficeIdSource", deepLoadType, innerList) 
				&& entity.GsMilitaryOfficeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsMilitaryOfficeId ?? 0.0m);
				GsMilitaryOffice tmpEntity = EntityManager.LocateEntity<GsMilitaryOffice>(EntityLocator.ConstructKeyFromPkItems(typeof(GsMilitaryOffice), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsMilitaryOfficeIdSource = tmpEntity;
				else
					entity.GsMilitaryOfficeIdSource = DataRepository.GsMilitaryOfficeProvider.GetByGsMilitaryOfficeId(transactionManager, (entity.GsMilitaryOfficeId ?? 0.0m));		
				
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
				pkItems[0] = (entity.GsMilitaryRegionId ?? 0.0m);
				GsMilitaryRegion tmpEntity = EntityManager.LocateEntity<GsMilitaryRegion>(EntityLocator.ConstructKeyFromPkItems(typeof(GsMilitaryRegion), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsMilitaryRegionIdSource = tmpEntity;
				else
					entity.GsMilitaryRegionIdSource = DataRepository.GsMilitaryRegionProvider.GetByGsMilitaryRegionId(transactionManager, (entity.GsMilitaryRegionId ?? 0.0m));		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudMilitaryInfo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudMilitaryInfo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudMilitaryInfo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMilitaryInfo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region AdmAppRegHistoryIdSource
			if (CanDeepSave(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepSaveType, innerList) 
				&& entity.AdmAppRegHistoryIdSource != null)
			{
				DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryIdSource);
				entity.AdmAppRegHistoryId = entity.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
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
	
	#region EdStudMilitaryInfoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudMilitaryInfo</c>
	///</summary>
	public enum EdStudMilitaryInfoChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
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
	
	#endregion EdStudMilitaryInfoChildEntityTypes
	
	#region EdStudMilitaryInfoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudMilitaryInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudMilitaryInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudMilitaryInfoFilterBuilder : SqlFilterBuilder<EdStudMilitaryInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryInfoFilterBuilder class.
		/// </summary>
		public EdStudMilitaryInfoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudMilitaryInfoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudMilitaryInfoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudMilitaryInfoFilterBuilder
	
	#region EdStudMilitaryInfoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudMilitaryInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudMilitaryInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudMilitaryInfoParameterBuilder : ParameterizedSqlFilterBuilder<EdStudMilitaryInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryInfoParameterBuilder class.
		/// </summary>
		public EdStudMilitaryInfoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudMilitaryInfoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudMilitaryInfoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudMilitaryInfoParameterBuilder
	
	#region EdStudMilitaryInfoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudMilitaryInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudMilitaryInfo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudMilitaryInfoSortBuilder : SqlSortBuilder<EdStudMilitaryInfoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryInfoSqlSortBuilder class.
		/// </summary>
		public EdStudMilitaryInfoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudMilitaryInfoSortBuilder
	
} // end namespace
