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
	/// This class is the base class for any <see cref="AdmAppTransToCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppTransToCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppTransToCourse, UMIS_VER2.BusinessLyer.AdmAppTransToCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransToCourseKey key)
		{
			return Delete(transactionManager, key.AdmAppTransToCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppTransToCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppTransToCourseId)
		{
			return Delete(null, _admAppTransToCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransToCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppTransToCourseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_ENT_POLICY_GRADING_HDR key.
		///		FK_ADM_APP_TRANS_TO_COURSE_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		public TList<AdmAppTransToCourse> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(_entPolicyGradingHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_ENT_POLICY_GRADING_HDR key.
		///		FK_ADM_APP_TRANS_TO_COURSE_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppTransToCourse> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_ENT_POLICY_GRADING_HDR key.
		///		FK_ADM_APP_TRANS_TO_COURSE_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		public TList<AdmAppTransToCourse> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_ENT_POLICY_GRADING_HDR key.
		///		fkAdmAppTransToCourseEntPolicyGradingHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		public TList<AdmAppTransToCourse> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_ENT_POLICY_GRADING_HDR key.
		///		fkAdmAppTransToCourseEntPolicyGradingHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		public TList<AdmAppTransToCourse> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId, int start, int pageLength,out int count)
		{
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_ENT_POLICY_GRADING_HDR key.
		///		FK_ADM_APP_TRANS_TO_COURSE_ENT_POLICY_GRADING_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		public abstract TList<AdmAppTransToCourse> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_GS_CODE_PASS_FAIL key.
		///		FK_ADM_APP_TRANS_TO_COURSE_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		public TList<AdmAppTransToCourse> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(_gsCodePassFailId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_GS_CODE_PASS_FAIL key.
		///		FK_ADM_APP_TRANS_TO_COURSE_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppTransToCourse> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_GS_CODE_PASS_FAIL key.
		///		FK_ADM_APP_TRANS_TO_COURSE_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		public TList<AdmAppTransToCourse> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_GS_CODE_PASS_FAIL key.
		///		fkAdmAppTransToCourseGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		public TList<AdmAppTransToCourse> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_GS_CODE_PASS_FAIL key.
		///		fkAdmAppTransToCourseGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		public TList<AdmAppTransToCourse> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength,out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_TO_COURSE_GS_CODE_PASS_FAIL key.
		///		FK_ADM_APP_TRANS_TO_COURSE_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransToCourse objects.</returns>
		public abstract TList<AdmAppTransToCourse> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppTransToCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransToCourseKey key, int start, int pageLength)
		{
			return GetByAdmAppTransToCourseId(transactionManager, key.AdmAppTransToCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId)
		{
			int count = -1;
			return GetByAdmAppTransReqId(null,_admAppTransReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqId(null, _admAppTransReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId)
		{
			int count = -1;
			return GetByAdmAppTransReqId(transactionManager, _admAppTransReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqId(transactionManager, _admAppTransReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTransReqId(null, _admAppTransReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public abstract TList<AdmAppTransToCourse> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public abstract TList<AdmAppTransToCourse> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_TRANS_COURSE_1 index.
		/// </summary>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCodeTransCourseTypeId(System.Decimal _edCodeTransCourseTypeId)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(null,_edCodeTransCourseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_TRANS_COURSE_1 index.
		/// </summary>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCodeTransCourseTypeId(System.Decimal _edCodeTransCourseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(null, _edCodeTransCourseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_TRANS_COURSE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCodeTransCourseTypeId(TransactionManager transactionManager, System.Decimal _edCodeTransCourseTypeId)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(transactionManager, _edCodeTransCourseTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_TRANS_COURSE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCodeTransCourseTypeId(TransactionManager transactionManager, System.Decimal _edCodeTransCourseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeTransCourseTypeId(transactionManager, _edCodeTransCourseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_TRANS_COURSE_1 index.
		/// </summary>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCodeTransCourseTypeId(System.Decimal _edCodeTransCourseTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeTransCourseTypeId(null, _edCodeTransCourseTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_TRANS_COURSE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeTransCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public abstract TList<AdmAppTransToCourse> GetByEdCodeTransCourseTypeId(TransactionManager transactionManager, System.Decimal _edCodeTransCourseTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(null,_edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public abstract TList<AdmAppTransToCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(null,_entCoursePkgHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public TList<AdmAppTransToCourse> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId, int start, int pageLength, out int count)
		{
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransToCourse&gt;"/> class.</returns>
		public abstract TList<AdmAppTransToCourse> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_TRANS_BALANCE index.
		/// </summary>
		/// <param name="_admAppTransToCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransToCourseId(System.Decimal _admAppTransToCourseId)
		{
			int count = -1;
			return GetByAdmAppTransToCourseId(null,_admAppTransToCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_BALANCE index.
		/// </summary>
		/// <param name="_admAppTransToCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransToCourseId(System.Decimal _admAppTransToCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransToCourseId(null, _admAppTransToCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_BALANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransToCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransToCourseId(TransactionManager transactionManager, System.Decimal _admAppTransToCourseId)
		{
			int count = -1;
			return GetByAdmAppTransToCourseId(transactionManager, _admAppTransToCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_BALANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransToCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransToCourseId(TransactionManager transactionManager, System.Decimal _admAppTransToCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransToCourseId(transactionManager, _admAppTransToCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_BALANCE index.
		/// </summary>
		/// <param name="_admAppTransToCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransToCourseId(System.Decimal _admAppTransToCourseId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTransToCourseId(null, _admAppTransToCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_BALANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransToCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransToCourseId(TransactionManager transactionManager, System.Decimal _admAppTransToCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_APP_TRANS_TO_COURSE index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransReqIdEdCourseId(System.Decimal _admAppTransReqId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByAdmAppTransReqIdEdCourseId(null,_admAppTransReqId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_TRANS_TO_COURSE index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransReqIdEdCourseId(System.Decimal _admAppTransReqId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqIdEdCourseId(null, _admAppTransReqId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_TRANS_TO_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransReqIdEdCourseId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByAdmAppTransReqIdEdCourseId(transactionManager, _admAppTransReqId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_TRANS_TO_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransReqIdEdCourseId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqIdEdCourseId(transactionManager, _admAppTransReqId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_TRANS_TO_COURSE index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransReqIdEdCourseId(System.Decimal _admAppTransReqId, System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTransReqIdEdCourseId(null, _admAppTransReqId, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_TRANS_TO_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppTransToCourse GetByAdmAppTransReqIdEdCourseId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppTransToCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppTransToCourse&gt;"/></returns>
		public static TList<AdmAppTransToCourse> Fill(IDataReader reader, TList<AdmAppTransToCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppTransToCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppTransToCourse")
					.Append("|").Append((System.Decimal)reader["ADM_APP_TRANS_TO_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppTransToCourse>(
					key.ToString(), // EntityTrackingKey
					"AdmAppTransToCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppTransToCourse();
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
					c.AdmAppTransToCourseId = (System.Decimal)reader["ADM_APP_TRANS_TO_COURSE_ID"];
					c.OriginalAdmAppTransToCourseId = c.AdmAppTransToCourseId;
					c.AdmAppTransReqId = (System.Decimal)reader["ADM_APP_TRANS_REQ_ID"];
					c.EntCoursePkgHdrId = Convert.IsDBNull(reader["ENT_COURSE_PKG_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_COURSE_PKG_HDR_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EdCodeTransCourseTypeId = (System.Decimal)reader["ED_CODE_TRANS_COURSE_TYPE_ID"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.CoursePoint = Convert.IsDBNull(reader["COURSE_POINT"]) ? null : (System.Decimal?)reader["COURSE_POINT"];
					c.AddGpaFlg = (System.Decimal)reader["ADD_GPA_FLG"];
					c.AddMjrgpaFlg = (System.Decimal)reader["ADD_MJRGPA_FLG"];
					c.GsCodePassFailId = Convert.IsDBNull(reader["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PASS_FAIL_ID"];
					c.EntPolicyGradingHdrId = Convert.IsDBNull(reader["ENT_POLICY_GRADING_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_GRADING_HDR_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppTransToCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppTransToCourseId = (System.Decimal)reader[((int)AdmAppTransToCourseColumn.AdmAppTransToCourseId - 1)];
			entity.OriginalAdmAppTransToCourseId = (System.Decimal)reader["ADM_APP_TRANS_TO_COURSE_ID"];
			entity.AdmAppTransReqId = (System.Decimal)reader[((int)AdmAppTransToCourseColumn.AdmAppTransReqId - 1)];
			entity.EntCoursePkgHdrId = (reader.IsDBNull(((int)AdmAppTransToCourseColumn.EntCoursePkgHdrId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransToCourseColumn.EntCoursePkgHdrId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)AdmAppTransToCourseColumn.EdCourseId - 1)];
			entity.EdCodeTransCourseTypeId = (System.Decimal)reader[((int)AdmAppTransToCourseColumn.EdCodeTransCourseTypeId - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)AdmAppTransToCourseColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransToCourseColumn.EdCodeGradingId - 1)];
			entity.CoursePoint = (reader.IsDBNull(((int)AdmAppTransToCourseColumn.CoursePoint - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransToCourseColumn.CoursePoint - 1)];
			entity.AddGpaFlg = (System.Decimal)reader[((int)AdmAppTransToCourseColumn.AddGpaFlg - 1)];
			entity.AddMjrgpaFlg = (System.Decimal)reader[((int)AdmAppTransToCourseColumn.AddMjrgpaFlg - 1)];
			entity.GsCodePassFailId = (reader.IsDBNull(((int)AdmAppTransToCourseColumn.GsCodePassFailId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransToCourseColumn.GsCodePassFailId - 1)];
			entity.EntPolicyGradingHdrId = (reader.IsDBNull(((int)AdmAppTransToCourseColumn.EntPolicyGradingHdrId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransToCourseColumn.EntPolicyGradingHdrId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppTransToCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppTransToCourseId = (System.Decimal)dataRow["ADM_APP_TRANS_TO_COURSE_ID"];
			entity.OriginalAdmAppTransToCourseId = (System.Decimal)dataRow["ADM_APP_TRANS_TO_COURSE_ID"];
			entity.AdmAppTransReqId = (System.Decimal)dataRow["ADM_APP_TRANS_REQ_ID"];
			entity.EntCoursePkgHdrId = Convert.IsDBNull(dataRow["ENT_COURSE_PKG_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_COURSE_PKG_HDR_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EdCodeTransCourseTypeId = (System.Decimal)dataRow["ED_CODE_TRANS_COURSE_TYPE_ID"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.CoursePoint = Convert.IsDBNull(dataRow["COURSE_POINT"]) ? null : (System.Decimal?)dataRow["COURSE_POINT"];
			entity.AddGpaFlg = (System.Decimal)dataRow["ADD_GPA_FLG"];
			entity.AddMjrgpaFlg = (System.Decimal)dataRow["ADD_MJRGPA_FLG"];
			entity.GsCodePassFailId = Convert.IsDBNull(dataRow["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PASS_FAIL_ID"];
			entity.EntPolicyGradingHdrId = Convert.IsDBNull(dataRow["ENT_POLICY_GRADING_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_GRADING_HDR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransToCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppTransToCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransToCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppTransReqIdSource	
			if (CanDeepLoad(entity, "AdmAppTransReq|AdmAppTransReqIdSource", deepLoadType, innerList) 
				&& entity.AdmAppTransReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppTransReqId;
				AdmAppTransReq tmpEntity = EntityManager.LocateEntity<AdmAppTransReq>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppTransReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppTransReqIdSource = tmpEntity;
				else
					entity.AdmAppTransReqIdSource = DataRepository.AdmAppTransReqProvider.GetByAdmAppTransReqId(transactionManager, entity.AdmAppTransReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppTransReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppTransReqProvider.DeepLoad(transactionManager, entity.AdmAppTransReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppTransReqIdSource

			#region EdCodeGradingIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeGradingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeGradingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeGradingId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeGradingIdSource = tmpEntity;
				else
					entity.EdCodeGradingIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.EdCodeGradingId ?? 0.0m));		
				
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

			#region EdCodeTransCourseTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeTransCourseType|EdCodeTransCourseTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeTransCourseTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeTransCourseTypeId;
				EdCodeTransCourseType tmpEntity = EntityManager.LocateEntity<EdCodeTransCourseType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeTransCourseType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeTransCourseTypeIdSource = tmpEntity;
				else
					entity.EdCodeTransCourseTypeIdSource = DataRepository.EdCodeTransCourseTypeProvider.GetByEdCodeTransCourseTypeId(transactionManager, entity.EdCodeTransCourseTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeTransCourseTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeTransCourseTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeTransCourseTypeProvider.DeepLoad(transactionManager, entity.EdCodeTransCourseTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeTransCourseTypeIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

			#region EntCoursePkgHdrIdSource	
			if (CanDeepLoad(entity, "EntCoursePkgHdr|EntCoursePkgHdrIdSource", deepLoadType, innerList) 
				&& entity.EntCoursePkgHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCoursePkgHdrId ?? 0.0m);
				EntCoursePkgHdr tmpEntity = EntityManager.LocateEntity<EntCoursePkgHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCoursePkgHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCoursePkgHdrIdSource = tmpEntity;
				else
					entity.EntCoursePkgHdrIdSource = DataRepository.EntCoursePkgHdrProvider.GetByEntCoursePkgHdrId(transactionManager, (entity.EntCoursePkgHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCoursePkgHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCoursePkgHdrProvider.DeepLoad(transactionManager, entity.EntCoursePkgHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCoursePkgHdrIdSource

			#region EntPolicyGradingHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyGradingHdr|EntPolicyGradingHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyGradingHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntPolicyGradingHdrId ?? 0.0m);
				EntPolicyGradingHdr tmpEntity = EntityManager.LocateEntity<EntPolicyGradingHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyGradingHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyGradingHdrIdSource = tmpEntity;
				else
					entity.EntPolicyGradingHdrIdSource = DataRepository.EntPolicyGradingHdrProvider.GetByEntPolicyGradingHdrId(transactionManager, (entity.EntPolicyGradingHdrId ?? 0.0m));		
				
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
				pkItems[0] = (entity.GsCodePassFailId ?? 0.0m);
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePassFailIdSource = tmpEntity;
				else
					entity.GsCodePassFailIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, (entity.GsCodePassFailId ?? 0.0m));		
				
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
			// Deep load child collections  - Call GetByAdmAppTransToCourseId methods when available
			
			#region AdmAppTransBalanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransBalance>|AdmAppTransBalanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransBalanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransBalanceCollection = DataRepository.AdmAppTransBalanceProvider.GetByAdmAppTransToCourseId(transactionManager, entity.AdmAppTransToCourseId);

				if (deep && entity.AdmAppTransBalanceCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransBalance>) DataRepository.AdmAppTransBalanceProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransBalanceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppTransToCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppTransToCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppTransToCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransToCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppTransReqIdSource
			if (CanDeepSave(entity, "AdmAppTransReq|AdmAppTransReqIdSource", deepSaveType, innerList) 
				&& entity.AdmAppTransReqIdSource != null)
			{
				DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqIdSource);
				entity.AdmAppTransReqId = entity.AdmAppTransReqIdSource.AdmAppTransReqId;
			}
			#endregion 
			
			#region EdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingIdSource);
				entity.EdCodeGradingId = entity.EdCodeGradingIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EdCodeTransCourseTypeIdSource
			if (CanDeepSave(entity, "EdCodeTransCourseType|EdCodeTransCourseTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeTransCourseTypeIdSource != null)
			{
				DataRepository.EdCodeTransCourseTypeProvider.Save(transactionManager, entity.EdCodeTransCourseTypeIdSource);
				entity.EdCodeTransCourseTypeId = entity.EdCodeTransCourseTypeIdSource.EdCodeTransCourseTypeId;
			}
			#endregion 
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EntCoursePkgHdrIdSource
			if (CanDeepSave(entity, "EntCoursePkgHdr|EntCoursePkgHdrIdSource", deepSaveType, innerList) 
				&& entity.EntCoursePkgHdrIdSource != null)
			{
				DataRepository.EntCoursePkgHdrProvider.Save(transactionManager, entity.EntCoursePkgHdrIdSource);
				entity.EntCoursePkgHdrId = entity.EntCoursePkgHdrIdSource.EntCoursePkgHdrId;
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
	
			#region List<AdmAppTransBalance>
				if (CanDeepSave(entity.AdmAppTransBalanceCollection, "List<AdmAppTransBalance>|AdmAppTransBalanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransBalance child in entity.AdmAppTransBalanceCollection)
					{
						if(child.AdmAppTransToCourseIdSource != null)
						{
							child.AdmAppTransToCourseId = child.AdmAppTransToCourseIdSource.AdmAppTransToCourseId;
						}
						else
						{
							child.AdmAppTransToCourseId = entity.AdmAppTransToCourseId;
						}

					}

					if (entity.AdmAppTransBalanceCollection.Count > 0 || entity.AdmAppTransBalanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransBalanceProvider.Save(transactionManager, entity.AdmAppTransBalanceCollection);
						
						deepHandles.Add("AdmAppTransBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransBalance >) DataRepository.AdmAppTransBalanceProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransBalanceCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmAppTransToCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppTransToCourse</c>
	///</summary>
	public enum AdmAppTransToCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppTransReq</c> at AdmAppTransReqIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppTransReq))]
		AdmAppTransReq,
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdCodeTransCourseType</c> at EdCodeTransCourseTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeTransCourseType))]
		EdCodeTransCourseType,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EntCoursePkgHdr</c> at EntCoursePkgHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntCoursePkgHdr))]
		EntCoursePkgHdr,
		
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
		///<summary>
		/// Collection of <c>AdmAppTransToCourse</c> as OneToMany for AdmAppTransBalanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransBalance>))]
		AdmAppTransBalanceCollection,
	}
	
	#endregion AdmAppTransToCourseChildEntityTypes
	
	#region AdmAppTransToCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppTransToCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransToCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppTransToCourseFilterBuilder : SqlFilterBuilder<AdmAppTransToCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransToCourseFilterBuilder class.
		/// </summary>
		public AdmAppTransToCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransToCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppTransToCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransToCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppTransToCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppTransToCourseFilterBuilder
	
	#region AdmAppTransToCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppTransToCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransToCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppTransToCourseParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppTransToCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransToCourseParameterBuilder class.
		/// </summary>
		public AdmAppTransToCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransToCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppTransToCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransToCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppTransToCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppTransToCourseParameterBuilder
	
	#region AdmAppTransToCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppTransToCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransToCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppTransToCourseSortBuilder : SqlSortBuilder<AdmAppTransToCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransToCourseSqlSortBuilder class.
		/// </summary>
		public AdmAppTransToCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppTransToCourseSortBuilder
	
} // end namespace
