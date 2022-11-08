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
	/// This class is the base class for any <see cref="EdStudMilitaryStateProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudMilitaryStateProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudMilitaryState, UMIS_VER2.BusinessLyer.EdStudMilitaryStateKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMilitaryStateKey key)
		{
			return Delete(transactionManager, key.EdStudMilitaryStateId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudMilitaryStateId">بيانات دورة التربية العسكرية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudMilitaryStateId)
		{
			return Delete(null, _edStudMilitaryStateId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMilitaryStateId">بيانات دورة التربية العسكرية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudMilitaryStateId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_STATE_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_MILITARY_STATE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryState objects.</returns>
		public TList<EdStudMilitaryState> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_STATE_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_MILITARY_STATE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryState objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudMilitaryState> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_STATE_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_MILITARY_STATE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryState objects.</returns>
		public TList<EdStudMilitaryState> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_STATE_ADM_APP_REG_HISTORY key.
		///		fkEdStudMilitaryStateAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryState objects.</returns>
		public TList<EdStudMilitaryState> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_STATE_ADM_APP_REG_HISTORY key.
		///		fkEdStudMilitaryStateAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryState objects.</returns>
		public TList<EdStudMilitaryState> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_MILITARY_STATE_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_MILITARY_STATE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudMilitaryState objects.</returns>
		public abstract TList<EdStudMilitaryState> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudMilitaryState Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMilitaryStateKey key, int start, int pageLength)
		{
			return GetByEdStudMilitaryStateId(transactionManager, key.EdStudMilitaryStateId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_ED_STUD_MILITARY_STATE_1 index.
		/// </summary>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(System.Decimal? _edStudId, System.Decimal _gsCodeMilitaryStateId, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(null,_edStudId, _gsCodeMilitaryStateId, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ED_STUD_MILITARY_STATE_1 index.
		/// </summary>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(System.Decimal? _edStudId, System.Decimal _gsCodeMilitaryStateId, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(null, _edStudId, _gsCodeMilitaryStateId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ED_STUD_MILITARY_STATE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal _gsCodeMilitaryStateId, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(transactionManager, _edStudId, _gsCodeMilitaryStateId, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ED_STUD_MILITARY_STATE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal _gsCodeMilitaryStateId, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(transactionManager, _edStudId, _gsCodeMilitaryStateId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ED_STUD_MILITARY_STATE_1 index.
		/// </summary>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(System.Decimal? _edStudId, System.Decimal _gsCodeMilitaryStateId, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(null, _edStudId, _gsCodeMilitaryStateId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ED_STUD_MILITARY_STATE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudIdGsCodeMilitaryStateIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal _gsCodeMilitaryStateId, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public TList<EdStudMilitaryState> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public TList<EdStudMilitaryState> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public TList<EdStudMilitaryState> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public TList<EdStudMilitaryState> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public TList<EdStudMilitaryState> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public abstract TList<EdStudMilitaryState> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public TList<EdStudMilitaryState> GetByGsCodeMilitaryStateId(System.Decimal _gsCodeMilitaryStateId)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(null,_gsCodeMilitaryStateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public TList<EdStudMilitaryState> GetByGsCodeMilitaryStateId(System.Decimal _gsCodeMilitaryStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(null, _gsCodeMilitaryStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public TList<EdStudMilitaryState> GetByGsCodeMilitaryStateId(TransactionManager transactionManager, System.Decimal _gsCodeMilitaryStateId)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(transactionManager, _gsCodeMilitaryStateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public TList<EdStudMilitaryState> GetByGsCodeMilitaryStateId(TransactionManager transactionManager, System.Decimal _gsCodeMilitaryStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(transactionManager, _gsCodeMilitaryStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public TList<EdStudMilitaryState> GetByGsCodeMilitaryStateId(System.Decimal _gsCodeMilitaryStateId, int start, int pageLength, out int count)
		{
			return GetByGsCodeMilitaryStateId(null, _gsCodeMilitaryStateId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilitaryStateId">موقف الطالب من التجنيد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudMilitaryState&gt;"/> class.</returns>
		public abstract TList<EdStudMilitaryState> GetByGsCodeMilitaryStateId(TransactionManager transactionManager, System.Decimal _gsCodeMilitaryStateId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_MILITARY_STATE index.
		/// </summary>
		/// <param name="_edStudMilitaryStateId">بيانات دورة التربية العسكرية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudMilitaryStateId(System.Decimal _edStudMilitaryStateId)
		{
			int count = -1;
			return GetByEdStudMilitaryStateId(null,_edStudMilitaryStateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MILITARY_STATE index.
		/// </summary>
		/// <param name="_edStudMilitaryStateId">بيانات دورة التربية العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudMilitaryStateId(System.Decimal _edStudMilitaryStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudMilitaryStateId(null, _edStudMilitaryStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MILITARY_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMilitaryStateId">بيانات دورة التربية العسكرية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudMilitaryStateId(TransactionManager transactionManager, System.Decimal _edStudMilitaryStateId)
		{
			int count = -1;
			return GetByEdStudMilitaryStateId(transactionManager, _edStudMilitaryStateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MILITARY_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMilitaryStateId">بيانات دورة التربية العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudMilitaryStateId(TransactionManager transactionManager, System.Decimal _edStudMilitaryStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudMilitaryStateId(transactionManager, _edStudMilitaryStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MILITARY_STATE index.
		/// </summary>
		/// <param name="_edStudMilitaryStateId">بيانات دورة التربية العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudMilitaryStateId(System.Decimal _edStudMilitaryStateId, int start, int pageLength, out int count)
		{
			return GetByEdStudMilitaryStateId(null, _edStudMilitaryStateId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_MILITARY_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudMilitaryStateId">بيانات دورة التربية العسكرية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudMilitaryState GetByEdStudMilitaryStateId(TransactionManager transactionManager, System.Decimal _edStudMilitaryStateId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudMilitaryState&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudMilitaryState&gt;"/></returns>
		public static TList<EdStudMilitaryState> Fill(IDataReader reader, TList<EdStudMilitaryState> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudMilitaryState c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudMilitaryState")
					.Append("|").Append((System.Decimal)reader["ED_STUD_MILITARY_STATE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudMilitaryState>(
					key.ToString(), // EntityTrackingKey
					"EdStudMilitaryState",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudMilitaryState();
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
					c.EdStudMilitaryStateId = (System.Decimal)reader["ED_STUD_MILITARY_STATE_ID"];
					c.OriginalEdStudMilitaryStateId = c.EdStudMilitaryStateId;
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.StateNotes = Convert.IsDBNull(reader["STATE_NOTES"]) ? null : (System.String)reader["STATE_NOTES"];
					c.GsCodeMilitaryStateId = (System.Decimal)reader["GS_CODE_MILITARY_STATE_ID"];
					c.StateDate = Convert.IsDBNull(reader["STATE_DATE"]) ? null : (System.DateTime?)reader["STATE_DATE"];
					c.ExpireDate = Convert.IsDBNull(reader["EXPIRE_DATE"]) ? null : (System.DateTime?)reader["EXPIRE_DATE"];
					c.ResolutionNumber = Convert.IsDBNull(reader["RESOLUTION_NUMBER"]) ? null : (System.String)reader["RESOLUTION_NUMBER"];
					c.IsCurState = (System.Decimal)reader["IS_CUR_STATE"];
					c.ResolutionStatement = Convert.IsDBNull(reader["RESOLUTION_STATEMENT"]) ? null : (System.String)reader["RESOLUTION_STATEMENT"];
					c.ResolutionDate = Convert.IsDBNull(reader["RESOLUTION_DATE"]) ? null : (System.DateTime?)reader["RESOLUTION_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudMilitaryState entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudMilitaryStateId = (System.Decimal)reader[((int)EdStudMilitaryStateColumn.EdStudMilitaryStateId - 1)];
			entity.OriginalEdStudMilitaryStateId = (System.Decimal)reader["ED_STUD_MILITARY_STATE_ID"];
			entity.EdStudId = (reader.IsDBNull(((int)EdStudMilitaryStateColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)EdStudMilitaryStateColumn.EdStudId - 1)];
			entity.StateNotes = (reader.IsDBNull(((int)EdStudMilitaryStateColumn.StateNotes - 1)))?null:(System.String)reader[((int)EdStudMilitaryStateColumn.StateNotes - 1)];
			entity.GsCodeMilitaryStateId = (System.Decimal)reader[((int)EdStudMilitaryStateColumn.GsCodeMilitaryStateId - 1)];
			entity.StateDate = (reader.IsDBNull(((int)EdStudMilitaryStateColumn.StateDate - 1)))?null:(System.DateTime?)reader[((int)EdStudMilitaryStateColumn.StateDate - 1)];
			entity.ExpireDate = (reader.IsDBNull(((int)EdStudMilitaryStateColumn.ExpireDate - 1)))?null:(System.DateTime?)reader[((int)EdStudMilitaryStateColumn.ExpireDate - 1)];
			entity.ResolutionNumber = (reader.IsDBNull(((int)EdStudMilitaryStateColumn.ResolutionNumber - 1)))?null:(System.String)reader[((int)EdStudMilitaryStateColumn.ResolutionNumber - 1)];
			entity.IsCurState = (System.Decimal)reader[((int)EdStudMilitaryStateColumn.IsCurState - 1)];
			entity.ResolutionStatement = (reader.IsDBNull(((int)EdStudMilitaryStateColumn.ResolutionStatement - 1)))?null:(System.String)reader[((int)EdStudMilitaryStateColumn.ResolutionStatement - 1)];
			entity.ResolutionDate = (reader.IsDBNull(((int)EdStudMilitaryStateColumn.ResolutionDate - 1)))?null:(System.DateTime?)reader[((int)EdStudMilitaryStateColumn.ResolutionDate - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)EdStudMilitaryStateColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)EdStudMilitaryStateColumn.AdmAppRegHistoryId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudMilitaryState entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudMilitaryStateId = (System.Decimal)dataRow["ED_STUD_MILITARY_STATE_ID"];
			entity.OriginalEdStudMilitaryStateId = (System.Decimal)dataRow["ED_STUD_MILITARY_STATE_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.StateNotes = Convert.IsDBNull(dataRow["STATE_NOTES"]) ? null : (System.String)dataRow["STATE_NOTES"];
			entity.GsCodeMilitaryStateId = (System.Decimal)dataRow["GS_CODE_MILITARY_STATE_ID"];
			entity.StateDate = Convert.IsDBNull(dataRow["STATE_DATE"]) ? null : (System.DateTime?)dataRow["STATE_DATE"];
			entity.ExpireDate = Convert.IsDBNull(dataRow["EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["EXPIRE_DATE"];
			entity.ResolutionNumber = Convert.IsDBNull(dataRow["RESOLUTION_NUMBER"]) ? null : (System.String)dataRow["RESOLUTION_NUMBER"];
			entity.IsCurState = (System.Decimal)dataRow["IS_CUR_STATE"];
			entity.ResolutionStatement = Convert.IsDBNull(dataRow["RESOLUTION_STATEMENT"]) ? null : (System.String)dataRow["RESOLUTION_STATEMENT"];
			entity.ResolutionDate = Convert.IsDBNull(dataRow["RESOLUTION_DATE"]) ? null : (System.DateTime?)dataRow["RESOLUTION_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudMilitaryState"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudMilitaryState Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMilitaryState entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCodeMilitaryStateIdSource	
			if (CanDeepLoad(entity, "GsCodeMilitaryState|GsCodeMilitaryStateIdSource", deepLoadType, innerList) 
				&& entity.GsCodeMilitaryStateIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeMilitaryStateId;
				GsCodeMilitaryState tmpEntity = EntityManager.LocateEntity<GsCodeMilitaryState>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeMilitaryState), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeMilitaryStateIdSource = tmpEntity;
				else
					entity.GsCodeMilitaryStateIdSource = DataRepository.GsCodeMilitaryStateProvider.GetByGsCodeMilitaryStateId(transactionManager, entity.GsCodeMilitaryStateId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeMilitaryStateIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeMilitaryStateIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeMilitaryStateProvider.DeepLoad(transactionManager, entity.GsCodeMilitaryStateIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeMilitaryStateIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudMilitaryState object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudMilitaryState instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudMilitaryState Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudMilitaryState entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsCodeMilitaryStateIdSource
			if (CanDeepSave(entity, "GsCodeMilitaryState|GsCodeMilitaryStateIdSource", deepSaveType, innerList) 
				&& entity.GsCodeMilitaryStateIdSource != null)
			{
				DataRepository.GsCodeMilitaryStateProvider.Save(transactionManager, entity.GsCodeMilitaryStateIdSource);
				entity.GsCodeMilitaryStateId = entity.GsCodeMilitaryStateIdSource.GsCodeMilitaryStateId;
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
	
	#region EdStudMilitaryStateChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudMilitaryState</c>
	///</summary>
	public enum EdStudMilitaryStateChildEntityTypes
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
		/// Composite Property for <c>GsCodeMilitaryState</c> at GsCodeMilitaryStateIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeMilitaryState))]
		GsCodeMilitaryState,
	}
	
	#endregion EdStudMilitaryStateChildEntityTypes
	
	#region EdStudMilitaryStateFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudMilitaryStateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudMilitaryState"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudMilitaryStateFilterBuilder : SqlFilterBuilder<EdStudMilitaryStateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryStateFilterBuilder class.
		/// </summary>
		public EdStudMilitaryStateFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryStateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudMilitaryStateFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryStateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudMilitaryStateFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudMilitaryStateFilterBuilder
	
	#region EdStudMilitaryStateParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudMilitaryStateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudMilitaryState"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudMilitaryStateParameterBuilder : ParameterizedSqlFilterBuilder<EdStudMilitaryStateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryStateParameterBuilder class.
		/// </summary>
		public EdStudMilitaryStateParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryStateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudMilitaryStateParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryStateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudMilitaryStateParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudMilitaryStateParameterBuilder
	
	#region EdStudMilitaryStateSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudMilitaryStateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudMilitaryState"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudMilitaryStateSortBuilder : SqlSortBuilder<EdStudMilitaryStateColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudMilitaryStateSqlSortBuilder class.
		/// </summary>
		public EdStudMilitaryStateSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudMilitaryStateSortBuilder
	
} // end namespace
