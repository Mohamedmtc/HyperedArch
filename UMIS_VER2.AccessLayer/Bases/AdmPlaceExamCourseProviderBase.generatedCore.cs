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
	/// This class is the base class for any <see cref="AdmPlaceExamCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmPlaceExamCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmPlaceExamCourse, UMIS_VER2.BusinessLyer.AdmPlaceExamCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamCourseKey key)
		{
			return Delete(transactionManager, key.AdmPlaceExamCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admPlaceExamCourseId">المقررات المرتبطة- المقررات المعفية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admPlaceExamCourseId)
		{
			return Delete(null, _admPlaceExamCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamCourseId">المقررات المرتبطة- المقررات المعفية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admPlaceExamCourseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_PLACE_EXAM_COURSE_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="_admCdeExamGrdngId">in case of exam with grade</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		public TList<AdmPlaceExamCourse> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(_admCdeExamGrdngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_PLACE_EXAM_COURSE_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">in case of exam with grade</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamCourse> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_PLACE_EXAM_COURSE_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">in case of exam with grade</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		public TList<AdmPlaceExamCourse> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_ADM_CDE_EXAM_GRDNG key.
		///		fkAdmPlaceExamCourseAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId">in case of exam with grade</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		public TList<AdmPlaceExamCourse> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_ADM_CDE_EXAM_GRDNG key.
		///		fkAdmPlaceExamCourseAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId">in case of exam with grade</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		public TList<AdmPlaceExamCourse> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_PLACE_EXAM_COURSE_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">in case of exam with grade</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		public abstract TList<AdmPlaceExamCourse> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_GS_CODE_PASS_FAIL key.
		///		FK_ADM_PLACE_EXAM_COURSE_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		public TList<AdmPlaceExamCourse> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(_gsCodePassFailId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_GS_CODE_PASS_FAIL key.
		///		FK_ADM_PLACE_EXAM_COURSE_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamCourse> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_GS_CODE_PASS_FAIL key.
		///		FK_ADM_PLACE_EXAM_COURSE_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		public TList<AdmPlaceExamCourse> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_GS_CODE_PASS_FAIL key.
		///		fkAdmPlaceExamCourseGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		public TList<AdmPlaceExamCourse> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_GS_CODE_PASS_FAIL key.
		///		fkAdmPlaceExamCourseGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		public TList<AdmPlaceExamCourse> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength,out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_COURSE_GS_CODE_PASS_FAIL key.
		///		FK_ADM_PLACE_EXAM_COURSE_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamCourse objects.</returns>
		public abstract TList<AdmPlaceExamCourse> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmPlaceExamCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamCourseKey key, int start, int pageLength)
		{
			return GetByAdmPlaceExamCourseId(transactionManager, key.AdmPlaceExamCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_CDE_PLACEMENT_EX_1 index.
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public TList<AdmPlaceExamCourse> GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(null,_admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_PLACEMENT_EX_1 index.
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public TList<AdmPlaceExamCourse> GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_PLACEMENT_EX_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public TList<AdmPlaceExamCourse> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_PLACEMENT_EX_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public TList<AdmPlaceExamCourse> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_PLACEMENT_EX_1 index.
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public TList<AdmPlaceExamCourse> GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId, int start, int pageLength, out int count)
		{
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_PLACEMENT_EX_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public abstract TList<AdmPlaceExamCourse> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public TList<AdmPlaceExamCourse> GetByEdCourseId(System.Decimal? _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public TList<AdmPlaceExamCourse> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public TList<AdmPlaceExamCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public TList<AdmPlaceExamCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public TList<AdmPlaceExamCourse> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmPlaceExamCourse&gt;"/> class.</returns>
		public abstract TList<AdmPlaceExamCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="_admPlaceExamCourseId">المقررات المرتبطة- المقررات المعفية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmPlaceExamCourseId(System.Decimal _admPlaceExamCourseId)
		{
			int count = -1;
			return GetByAdmPlaceExamCourseId(null,_admPlaceExamCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="_admPlaceExamCourseId">المقررات المرتبطة- المقررات المعفية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmPlaceExamCourseId(System.Decimal _admPlaceExamCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamCourseId(null, _admPlaceExamCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamCourseId">المقررات المرتبطة- المقررات المعفية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmPlaceExamCourseId(TransactionManager transactionManager, System.Decimal _admPlaceExamCourseId)
		{
			int count = -1;
			return GetByAdmPlaceExamCourseId(transactionManager, _admPlaceExamCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamCourseId">المقررات المرتبطة- المقررات المعفية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmPlaceExamCourseId(TransactionManager transactionManager, System.Decimal _admPlaceExamCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamCourseId(transactionManager, _admPlaceExamCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="_admPlaceExamCourseId">المقررات المرتبطة- المقررات المعفية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmPlaceExamCourseId(System.Decimal _admPlaceExamCourseId, int start, int pageLength, out int count)
		{
			return GetByAdmPlaceExamCourseId(null, _admPlaceExamCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamCourseId">المقررات المرتبطة- المقررات المعفية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmPlaceExamCourseId(TransactionManager transactionManager, System.Decimal _admPlaceExamCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_exemptFlg">0  - مقرر تحميل 
		/// 		/// مقرر معفى  - 1   KU</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(System.Decimal _admCdePlacementExamId, System.Decimal? _edCourseId, System.Boolean _exemptFlg)
		{
			int count = -1;
			return GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(null,_admCdePlacementExamId, _edCourseId, _exemptFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_exemptFlg">0  - مقرر تحميل 
		/// 		/// مقرر معفى  - 1   KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(System.Decimal _admCdePlacementExamId, System.Decimal? _edCourseId, System.Boolean _exemptFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(null, _admCdePlacementExamId, _edCourseId, _exemptFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_exemptFlg">0  - مقرر تحميل 
		/// 		/// مقرر معفى  - 1   KU</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, System.Decimal? _edCourseId, System.Boolean _exemptFlg)
		{
			int count = -1;
			return GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(transactionManager, _admCdePlacementExamId, _edCourseId, _exemptFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_exemptFlg">0  - مقرر تحميل 
		/// 		/// مقرر معفى  - 1   KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, System.Decimal? _edCourseId, System.Boolean _exemptFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(transactionManager, _admCdePlacementExamId, _edCourseId, _exemptFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_exemptFlg">0  - مقرر تحميل 
		/// 		/// مقرر معفى  - 1   KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(System.Decimal _admCdePlacementExamId, System.Decimal? _edCourseId, System.Boolean _exemptFlg, int start, int pageLength, out int count)
		{
			return GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(null, _admCdePlacementExamId, _edCourseId, _exemptFlg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PLACE_EXAM_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_exemptFlg">0  - مقرر تحميل 
		/// 		/// مقرر معفى  - 1   KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmPlaceExamCourse GetByAdmCdePlacementExamIdEdCourseIdExemptFlg(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, System.Decimal? _edCourseId, System.Boolean _exemptFlg, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmPlaceExamCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmPlaceExamCourse&gt;"/></returns>
		public static TList<AdmPlaceExamCourse> Fill(IDataReader reader, TList<AdmPlaceExamCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmPlaceExamCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmPlaceExamCourse")
					.Append("|").Append((System.Decimal)reader["ADM_PLACE_EXAM_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmPlaceExamCourse>(
					key.ToString(), // EntityTrackingKey
					"AdmPlaceExamCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmPlaceExamCourse();
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
					c.AdmPlaceExamCourseId = (System.Decimal)reader["ADM_PLACE_EXAM_COURSE_ID"];
					c.OriginalAdmPlaceExamCourseId = c.AdmPlaceExamCourseId;
					c.AdmCdePlacementExamId = (System.Decimal)reader["ADM_CDE_PLACEMENT_EXAM_ID"];
					c.MarkFrom = Convert.IsDBNull(reader["MARK_FROM"]) ? null : (System.Decimal?)reader["MARK_FROM"];
					c.MarkTo = Convert.IsDBNull(reader["MARK_TO"]) ? null : (System.Decimal?)reader["MARK_TO"];
					c.GsCodePassFailId = Convert.IsDBNull(reader["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PASS_FAIL_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.AdmCdeExamGrdngId = Convert.IsDBNull(reader["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_EXAM_GRDNG_ID"];
					c.ExemptFlg = (System.Boolean)reader["EXEMPT_FLG"];
					c.OrientFlg = Convert.IsDBNull(reader["ORIENT_FLG"]) ? null : (System.Boolean?)reader["ORIENT_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmPlaceExamCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmPlaceExamCourseId = (System.Decimal)reader[((int)AdmPlaceExamCourseColumn.AdmPlaceExamCourseId - 1)];
			entity.OriginalAdmPlaceExamCourseId = (System.Decimal)reader["ADM_PLACE_EXAM_COURSE_ID"];
			entity.AdmCdePlacementExamId = (System.Decimal)reader[((int)AdmPlaceExamCourseColumn.AdmCdePlacementExamId - 1)];
			entity.MarkFrom = (reader.IsDBNull(((int)AdmPlaceExamCourseColumn.MarkFrom - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamCourseColumn.MarkFrom - 1)];
			entity.MarkTo = (reader.IsDBNull(((int)AdmPlaceExamCourseColumn.MarkTo - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamCourseColumn.MarkTo - 1)];
			entity.GsCodePassFailId = (reader.IsDBNull(((int)AdmPlaceExamCourseColumn.GsCodePassFailId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamCourseColumn.GsCodePassFailId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)AdmPlaceExamCourseColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamCourseColumn.EdCourseId - 1)];
			entity.AdmCdeExamGrdngId = (reader.IsDBNull(((int)AdmPlaceExamCourseColumn.AdmCdeExamGrdngId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamCourseColumn.AdmCdeExamGrdngId - 1)];
			entity.ExemptFlg = (System.Boolean)reader[((int)AdmPlaceExamCourseColumn.ExemptFlg - 1)];
			entity.OrientFlg = (reader.IsDBNull(((int)AdmPlaceExamCourseColumn.OrientFlg - 1)))?null:(System.Boolean?)reader[((int)AdmPlaceExamCourseColumn.OrientFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmPlaceExamCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmPlaceExamCourseId = (System.Decimal)dataRow["ADM_PLACE_EXAM_COURSE_ID"];
			entity.OriginalAdmPlaceExamCourseId = (System.Decimal)dataRow["ADM_PLACE_EXAM_COURSE_ID"];
			entity.AdmCdePlacementExamId = (System.Decimal)dataRow["ADM_CDE_PLACEMENT_EXAM_ID"];
			entity.MarkFrom = Convert.IsDBNull(dataRow["MARK_FROM"]) ? null : (System.Decimal?)dataRow["MARK_FROM"];
			entity.MarkTo = Convert.IsDBNull(dataRow["MARK_TO"]) ? null : (System.Decimal?)dataRow["MARK_TO"];
			entity.GsCodePassFailId = Convert.IsDBNull(dataRow["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PASS_FAIL_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.AdmCdeExamGrdngId = Convert.IsDBNull(dataRow["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_EXAM_GRDNG_ID"];
			entity.ExemptFlg = (System.Boolean)dataRow["EXEMPT_FLG"];
			entity.OrientFlg = Convert.IsDBNull(dataRow["ORIENT_FLG"]) ? null : (System.Boolean?)dataRow["ORIENT_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmPlaceExamCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeExamGrdngIdSource	
			if (CanDeepLoad(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeExamGrdngId ?? 0.0m);
				AdmCdeExamGrdng tmpEntity = EntityManager.LocateEntity<AdmCdeExamGrdng>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeExamGrdng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeExamGrdngIdSource = tmpEntity;
				else
					entity.AdmCdeExamGrdngIdSource = DataRepository.AdmCdeExamGrdngProvider.GetByAdmCdeExamGrdngId(transactionManager, (entity.AdmCdeExamGrdngId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeExamGrdngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeExamGrdngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeExamGrdngProvider.DeepLoad(transactionManager, entity.AdmCdeExamGrdngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeExamGrdngIdSource

			#region AdmCdePlacementExamIdSource	
			if (CanDeepLoad(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepLoadType, innerList) 
				&& entity.AdmCdePlacementExamIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdePlacementExamId;
				AdmCdePlacementExam tmpEntity = EntityManager.LocateEntity<AdmCdePlacementExam>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdePlacementExam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdePlacementExamIdSource = tmpEntity;
				else
					entity.AdmCdePlacementExamIdSource = DataRepository.AdmCdePlacementExamProvider.GetByAdmCdePlacementExamId(transactionManager, entity.AdmCdePlacementExamId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacementExamIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdePlacementExamIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdePlacementExamProvider.DeepLoad(transactionManager, entity.AdmCdePlacementExamIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdePlacementExamIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmPlaceExamCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmPlaceExamCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmPlaceExamCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeExamGrdngIdSource
			if (CanDeepSave(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource != null)
			{
				DataRepository.AdmCdeExamGrdngProvider.Save(transactionManager, entity.AdmCdeExamGrdngIdSource);
				entity.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
			}
			#endregion 
			
			#region AdmCdePlacementExamIdSource
			if (CanDeepSave(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepSaveType, innerList) 
				&& entity.AdmCdePlacementExamIdSource != null)
			{
				DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamIdSource);
				entity.AdmCdePlacementExamId = entity.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
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
	
	#region AdmPlaceExamCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmPlaceExamCourse</c>
	///</summary>
	public enum AdmPlaceExamCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeExamGrdng</c> at AdmCdeExamGrdngIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeExamGrdng))]
		AdmCdeExamGrdng,
		
		///<summary>
		/// Composite Property for <c>AdmCdePlacementExam</c> at AdmCdePlacementExamIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdePlacementExam))]
		AdmCdePlacementExam,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>GsCodePassFail</c> at GsCodePassFailIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePassFail))]
		GsCodePassFail,
	}
	
	#endregion AdmPlaceExamCourseChildEntityTypes
	
	#region AdmPlaceExamCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmPlaceExamCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmPlaceExamCourseFilterBuilder : SqlFilterBuilder<AdmPlaceExamCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamCourseFilterBuilder class.
		/// </summary>
		public AdmPlaceExamCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmPlaceExamCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmPlaceExamCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmPlaceExamCourseFilterBuilder
	
	#region AdmPlaceExamCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmPlaceExamCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmPlaceExamCourseParameterBuilder : ParameterizedSqlFilterBuilder<AdmPlaceExamCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamCourseParameterBuilder class.
		/// </summary>
		public AdmPlaceExamCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmPlaceExamCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmPlaceExamCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmPlaceExamCourseParameterBuilder
	
	#region AdmPlaceExamCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmPlaceExamCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmPlaceExamCourseSortBuilder : SqlSortBuilder<AdmPlaceExamCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamCourseSqlSortBuilder class.
		/// </summary>
		public AdmPlaceExamCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmPlaceExamCourseSortBuilder
	
} // end namespace
