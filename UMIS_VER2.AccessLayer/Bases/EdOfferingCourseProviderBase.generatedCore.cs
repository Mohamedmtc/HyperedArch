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
	/// This class is the base class for any <see cref="EdOfferingCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdOfferingCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdOfferingCourse, UMIS_VER2.BusinessLyer.EdOfferingCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOfferingCourseKey key)
		{
			return Delete(transactionManager, key.EdOfferingCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edOfferingCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edOfferingCourseId)
		{
			return Delete(null, _edOfferingCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edOfferingCourseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SA_STF_MEMBER key.
		///		FK_ED_OFFERING_COURSE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SA_STF_MEMBER key.
		///		FK_ED_OFFERING_COURSE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdOfferingCourse> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SA_STF_MEMBER key.
		///		FK_ED_OFFERING_COURSE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SA_STF_MEMBER key.
		///		fkEdOfferingCourseSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SA_STF_MEMBER key.
		///		fkEdOfferingCourseSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SA_STF_MEMBER key.
		///		FK_ED_OFFERING_COURSE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public abstract TList<EdOfferingCourse> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_FORM key.
		///		FK_ED_OFFERING_COURSE_SE_FORM Description: 
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySeFormId(System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(_seFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_FORM key.
		///		FK_ED_OFFERING_COURSE_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdOfferingCourse> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_FORM key.
		///		FK_ED_OFFERING_COURSE_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_FORM key.
		///		fkEdOfferingCourseSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormId(null, _seFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_FORM key.
		///		fkEdOfferingCourseSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength,out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_FORM key.
		///		FK_ED_OFFERING_COURSE_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public abstract TList<EdOfferingCourse> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_USER key.
		///		FK_ED_OFFERING_COURSE_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_USER key.
		///		FK_ED_OFFERING_COURSE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdOfferingCourse> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_USER key.
		///		FK_ED_OFFERING_COURSE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_USER key.
		///		fkEdOfferingCourseSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_USER key.
		///		fkEdOfferingCourseSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public TList<EdOfferingCourse> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_OFFERING_COURSE_SE_USER key.
		///		FK_ED_OFFERING_COURSE_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdOfferingCourse objects.</returns>
		public abstract TList<EdOfferingCourse> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdOfferingCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOfferingCourseKey key, int start, int pageLength)
		{
			return GetByEdOfferingCourseId(transactionManager, key.EdOfferingCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public abstract TList<EdOfferingCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByEdCourseId(System.Decimal? _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public abstract TList<EdOfferingCourse> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_OFFERING_ID_1 index.
		/// </summary>
		/// <param name="_edOfferingId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByEdOfferingId(System.Decimal? _edOfferingId)
		{
			int count = -1;
			return GetByEdOfferingId(null,_edOfferingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_OFFERING_ID_1 index.
		/// </summary>
		/// <param name="_edOfferingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByEdOfferingId(System.Decimal? _edOfferingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingId(null, _edOfferingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_OFFERING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByEdOfferingId(TransactionManager transactionManager, System.Decimal? _edOfferingId)
		{
			int count = -1;
			return GetByEdOfferingId(transactionManager, _edOfferingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_OFFERING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByEdOfferingId(TransactionManager transactionManager, System.Decimal? _edOfferingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingId(transactionManager, _edOfferingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_OFFERING_ID_1 index.
		/// </summary>
		/// <param name="_edOfferingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public TList<EdOfferingCourse> GetByEdOfferingId(System.Decimal? _edOfferingId, int start, int pageLength, out int count)
		{
			return GetByEdOfferingId(null, _edOfferingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_OFFERING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdOfferingCourse&gt;"/> class.</returns>
		public abstract TList<EdOfferingCourse> GetByEdOfferingId(TransactionManager transactionManager, System.Decimal? _edOfferingId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE_INSTANCE index.
		/// </summary>
		/// <param name="_edOfferingCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingCourseId(System.Decimal _edOfferingCourseId)
		{
			int count = -1;
			return GetByEdOfferingCourseId(null,_edOfferingCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_INSTANCE index.
		/// </summary>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingCourseId(System.Decimal _edOfferingCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingCourseId(null, _edOfferingCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_INSTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingCourseId(TransactionManager transactionManager, System.Decimal _edOfferingCourseId)
		{
			int count = -1;
			return GetByEdOfferingCourseId(transactionManager, _edOfferingCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_INSTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingCourseId(TransactionManager transactionManager, System.Decimal _edOfferingCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingCourseId(transactionManager, _edOfferingCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_INSTANCE index.
		/// </summary>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingCourseId(System.Decimal _edOfferingCourseId, int start, int pageLength, out int count)
		{
			return GetByEdOfferingCourseId(null, _edOfferingCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_INSTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingCourseId(TransactionManager transactionManager, System.Decimal _edOfferingCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_OFFERING_COURSE index.
		/// </summary>
		/// <param name="_edOfferingId"></param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingIdEdCourseId(System.Decimal? _edOfferingId, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdOfferingIdEdCourseId(null,_edOfferingId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_OFFERING_COURSE index.
		/// </summary>
		/// <param name="_edOfferingId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingIdEdCourseId(System.Decimal? _edOfferingId, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingIdEdCourseId(null, _edOfferingId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_OFFERING_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingId"></param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingIdEdCourseId(TransactionManager transactionManager, System.Decimal? _edOfferingId, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdOfferingIdEdCourseId(transactionManager, _edOfferingId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_OFFERING_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingIdEdCourseId(TransactionManager transactionManager, System.Decimal? _edOfferingId, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingIdEdCourseId(transactionManager, _edOfferingId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_OFFERING_COURSE index.
		/// </summary>
		/// <param name="_edOfferingId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingIdEdCourseId(System.Decimal? _edOfferingId, System.Decimal? _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdOfferingIdEdCourseId(null, _edOfferingId, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_OFFERING_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdOfferingCourse GetByEdOfferingIdEdCourseId(TransactionManager transactionManager, System.Decimal? _edOfferingId, System.Decimal? _edCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdOfferingCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdOfferingCourse&gt;"/></returns>
		public static TList<EdOfferingCourse> Fill(IDataReader reader, TList<EdOfferingCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdOfferingCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdOfferingCourse")
					.Append("|").Append((System.Decimal)reader["ED_OFFERING_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdOfferingCourse>(
					key.ToString(), // EntityTrackingKey
					"EdOfferingCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdOfferingCourse();
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
					c.EdOfferingCourseId = (System.Decimal)reader["ED_OFFERING_COURSE_ID"];
					c.OriginalEdOfferingCourseId = c.EdOfferingCourseId;
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.EdOfferingId = Convert.IsDBNull(reader["ED_OFFERING_ID"]) ? null : (System.Decimal?)reader["ED_OFFERING_ID"];
					c.AuditFlg = Convert.IsDBNull(reader["AUDIT_FLG"]) ? null : (System.Decimal?)reader["AUDIT_FLG"];
					c.OnlineFlg = Convert.IsDBNull(reader["ONLINE_FLG"]) ? null : (System.Decimal?)reader["ONLINE_FLG"];
					c.MinAttendNo = Convert.IsDBNull(reader["MIN_ATTEND_NO"]) ? null : (System.Decimal?)reader["MIN_ATTEND_NO"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AllSessionNo = Convert.IsDBNull(reader["ALL_SESSION_NO"]) ? null : (System.Decimal?)reader["ALL_SESSION_NO"];
					c.AllHoursNo = Convert.IsDBNull(reader["ALL_HOURS_NO"]) ? null : (System.Decimal?)reader["ALL_HOURS_NO"];
					c.ApproveNoFlg = Convert.IsDBNull(reader["APPROVE_NO_FLG"]) ? null : (System.Boolean?)reader["APPROVE_NO_FLG"];
					c.MaxStudCount = Convert.IsDBNull(reader["MAX_STUD_COUNT"]) ? null : (System.Decimal?)reader["MAX_STUD_COUNT"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdOfferingCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.EdOfferingCourseId = (System.Decimal)reader[((int)EdOfferingCourseColumn.EdOfferingCourseId - 1)];
			entity.OriginalEdOfferingCourseId = (System.Decimal)reader["ED_OFFERING_COURSE_ID"];
			entity.EdCourseId = (reader.IsDBNull(((int)EdOfferingCourseColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.EdCourseId - 1)];
			entity.EdOfferingId = (reader.IsDBNull(((int)EdOfferingCourseColumn.EdOfferingId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.EdOfferingId - 1)];
			entity.AuditFlg = (reader.IsDBNull(((int)EdOfferingCourseColumn.AuditFlg - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.AuditFlg - 1)];
			entity.OnlineFlg = (reader.IsDBNull(((int)EdOfferingCourseColumn.OnlineFlg - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.OnlineFlg - 1)];
			entity.MinAttendNo = (reader.IsDBNull(((int)EdOfferingCourseColumn.MinAttendNo - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.MinAttendNo - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdOfferingCourseColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.AsFacultyInfoId - 1)];
			entity.AllSessionNo = (reader.IsDBNull(((int)EdOfferingCourseColumn.AllSessionNo - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.AllSessionNo - 1)];
			entity.AllHoursNo = (reader.IsDBNull(((int)EdOfferingCourseColumn.AllHoursNo - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.AllHoursNo - 1)];
			entity.ApproveNoFlg = (reader.IsDBNull(((int)EdOfferingCourseColumn.ApproveNoFlg - 1)))?null:(System.Boolean?)reader[((int)EdOfferingCourseColumn.ApproveNoFlg - 1)];
			entity.MaxStudCount = (reader.IsDBNull(((int)EdOfferingCourseColumn.MaxStudCount - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.MaxStudCount - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)EdOfferingCourseColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.SaStfMemberId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdOfferingCourseColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdOfferingCourseColumn.LastDate - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdOfferingCourseColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.SeFormId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdOfferingCourseColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdOfferingCourseColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdOfferingCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdOfferingCourseId = (System.Decimal)dataRow["ED_OFFERING_COURSE_ID"];
			entity.OriginalEdOfferingCourseId = (System.Decimal)dataRow["ED_OFFERING_COURSE_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.EdOfferingId = Convert.IsDBNull(dataRow["ED_OFFERING_ID"]) ? null : (System.Decimal?)dataRow["ED_OFFERING_ID"];
			entity.AuditFlg = Convert.IsDBNull(dataRow["AUDIT_FLG"]) ? null : (System.Decimal?)dataRow["AUDIT_FLG"];
			entity.OnlineFlg = Convert.IsDBNull(dataRow["ONLINE_FLG"]) ? null : (System.Decimal?)dataRow["ONLINE_FLG"];
			entity.MinAttendNo = Convert.IsDBNull(dataRow["MIN_ATTEND_NO"]) ? null : (System.Decimal?)dataRow["MIN_ATTEND_NO"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AllSessionNo = Convert.IsDBNull(dataRow["ALL_SESSION_NO"]) ? null : (System.Decimal?)dataRow["ALL_SESSION_NO"];
			entity.AllHoursNo = Convert.IsDBNull(dataRow["ALL_HOURS_NO"]) ? null : (System.Decimal?)dataRow["ALL_HOURS_NO"];
			entity.ApproveNoFlg = Convert.IsDBNull(dataRow["APPROVE_NO_FLG"]) ? null : (System.Boolean?)dataRow["APPROVE_NO_FLG"];
			entity.MaxStudCount = Convert.IsDBNull(dataRow["MAX_STUD_COUNT"]) ? null : (System.Decimal?)dataRow["MAX_STUD_COUNT"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdOfferingCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdOfferingCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOfferingCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
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

			#region EdOfferingIdSource	
			if (CanDeepLoad(entity, "EdOffering|EdOfferingIdSource", deepLoadType, innerList) 
				&& entity.EdOfferingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdOfferingId ?? 0.0m);
				EdOffering tmpEntity = EntityManager.LocateEntity<EdOffering>(EntityLocator.ConstructKeyFromPkItems(typeof(EdOffering), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdOfferingIdSource = tmpEntity;
				else
					entity.EdOfferingIdSource = DataRepository.EdOfferingProvider.GetByEdOfferingId(transactionManager, (entity.EdOfferingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdOfferingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdOfferingProvider.DeepLoad(transactionManager, entity.EdOfferingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdOfferingIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
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

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeFormId ?? 0.0m);
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, (entity.SeFormId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdOfferingCourseId methods when available
			
			#region EdCourseInstanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseInstance>|EdCourseInstanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseInstanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseInstanceCollection = DataRepository.EdCourseInstanceProvider.GetByEdOfferingCourseId(transactionManager, entity.EdOfferingCourseId);

				if (deep && entity.EdCourseInstanceCollection.Count > 0)
				{
					deepHandles.Add("EdCourseInstanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseInstance>) DataRepository.EdCourseInstanceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseInstanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleHdr>|ScScheduleHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleHdrCollection = DataRepository.ScScheduleHdrProvider.GetByEdOfferingCourseId(transactionManager, entity.EdOfferingCourseId);

				if (deep && entity.ScScheduleHdrCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleHdr>) DataRepository.ScScheduleHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleHdrCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdOfferingCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdOfferingCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdOfferingCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdOfferingCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdOfferingIdSource
			if (CanDeepSave(entity, "EdOffering|EdOfferingIdSource", deepSaveType, innerList) 
				&& entity.EdOfferingIdSource != null)
			{
				DataRepository.EdOfferingProvider.Save(transactionManager, entity.EdOfferingIdSource);
				entity.EdOfferingId = entity.EdOfferingIdSource.EdOfferingId;
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
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
			}
			#endregion 
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdCourseInstance>
				if (CanDeepSave(entity.EdCourseInstanceCollection, "List<EdCourseInstance>|EdCourseInstanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseInstance child in entity.EdCourseInstanceCollection)
					{
						if(child.EdOfferingCourseIdSource != null)
						{
							child.EdOfferingCourseId = child.EdOfferingCourseIdSource.EdOfferingCourseId;
						}
						else
						{
							child.EdOfferingCourseId = entity.EdOfferingCourseId;
						}

					}

					if (entity.EdCourseInstanceCollection.Count > 0 || entity.EdCourseInstanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseInstanceProvider.Save(transactionManager, entity.EdCourseInstanceCollection);
						
						deepHandles.Add("EdCourseInstanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseInstance >) DataRepository.EdCourseInstanceProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseInstanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleHdr>
				if (CanDeepSave(entity.ScScheduleHdrCollection, "List<ScScheduleHdr>|ScScheduleHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleHdr child in entity.ScScheduleHdrCollection)
					{
						if(child.EdOfferingCourseIdSource != null)
						{
							child.EdOfferingCourseId = child.EdOfferingCourseIdSource.EdOfferingCourseId;
						}
						else
						{
							child.EdOfferingCourseId = entity.EdOfferingCourseId;
						}

					}

					if (entity.ScScheduleHdrCollection.Count > 0 || entity.ScScheduleHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleHdrProvider.Save(transactionManager, entity.ScScheduleHdrCollection);
						
						deepHandles.Add("ScScheduleHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleHdr >) DataRepository.ScScheduleHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleHdrCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdOfferingCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdOfferingCourse</c>
	///</summary>
	public enum EdOfferingCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdOffering</c> at EdOfferingIdSource
		///</summary>
		[ChildEntityType(typeof(EdOffering))]
		EdOffering,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>EdOfferingCourse</c> as OneToMany for EdCourseInstanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseInstance>))]
		EdCourseInstanceCollection,
		///<summary>
		/// Collection of <c>EdOfferingCourse</c> as OneToMany for ScScheduleHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleHdr>))]
		ScScheduleHdrCollection,
	}
	
	#endregion EdOfferingCourseChildEntityTypes
	
	#region EdOfferingCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdOfferingCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOfferingCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdOfferingCourseFilterBuilder : SqlFilterBuilder<EdOfferingCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOfferingCourseFilterBuilder class.
		/// </summary>
		public EdOfferingCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdOfferingCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdOfferingCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdOfferingCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdOfferingCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdOfferingCourseFilterBuilder
	
	#region EdOfferingCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdOfferingCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOfferingCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdOfferingCourseParameterBuilder : ParameterizedSqlFilterBuilder<EdOfferingCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOfferingCourseParameterBuilder class.
		/// </summary>
		public EdOfferingCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdOfferingCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdOfferingCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdOfferingCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdOfferingCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdOfferingCourseParameterBuilder
	
	#region EdOfferingCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdOfferingCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdOfferingCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdOfferingCourseSortBuilder : SqlSortBuilder<EdOfferingCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdOfferingCourseSqlSortBuilder class.
		/// </summary>
		public EdOfferingCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdOfferingCourseSortBuilder
	
} // end namespace
