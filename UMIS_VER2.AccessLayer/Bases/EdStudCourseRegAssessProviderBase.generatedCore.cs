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
	/// This class is the base class for any <see cref="EdStudCourseRegAssessProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseRegAssessProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCourseRegAssess, UMIS_VER2.BusinessLyer.EdStudCourseRegAssessKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAssessKey key)
		{
			return Delete(transactionManager, key.EdStudCourseRegAssessId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCourseRegAssessId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCourseRegAssessId)
		{
			return Delete(null, _edStudCourseRegAssessId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegAssessId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCourseRegAssessId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_FORM key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SE_FORM Description: 
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		public TList<EdStudCourseRegAssess> GetBySeFormId(System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(_seFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_FORM key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegAssess> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_FORM key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		public TList<EdStudCourseRegAssess> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_FORM key.
		///		fkEdStudCourseRegAssessSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		public TList<EdStudCourseRegAssess> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormId(null, _seFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_FORM key.
		///		fkEdStudCourseRegAssessSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		public TList<EdStudCourseRegAssess> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength,out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_FORM key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		public abstract TList<EdStudCourseRegAssess> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_USER key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		public TList<EdStudCourseRegAssess> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_USER key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegAssess> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_USER key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		public TList<EdStudCourseRegAssess> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_USER key.
		///		fkEdStudCourseRegAssessSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		public TList<EdStudCourseRegAssess> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_USER key.
		///		fkEdStudCourseRegAssessSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		public TList<EdStudCourseRegAssess> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ASSESS_SE_USER key.
		///		FK_ED_STUD_COURSE_REG_ASSESS_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAssess objects.</returns>
		public abstract TList<EdStudCourseRegAssess> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCourseRegAssess Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAssessKey key, int start, int pageLength)
		{
			return GetByEdStudCourseRegAssessId(transactionManager, key.EdStudCourseRegAssessId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public abstract TList<EdStudCourseRegAssess> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_COURSE_ASSES_1 index.
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(null,_edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_ASSES_1 index.
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_ASSES_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_ASSES_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseAssessId(transactionManager, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_ASSES_1 index.
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdCodeCourseAssessId(System.Decimal _edCodeCourseAssessId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseAssessId(null, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_ASSES_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public abstract TList<EdStudCourseRegAssess> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edCodeCourseAssessId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(null,_edCodeCourseStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(null, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(transactionManager, _edCodeCourseStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(transactionManager, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdCodeCourseStatusId(System.Decimal? _edCodeCourseStatusId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseStatusId(null, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_STATU_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public abstract TList<EdStudCourseRegAssess> GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_COURSE_REG_I_1 index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(null,_edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_REG_I_1 index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_REG_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_REG_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_REG_I_1 index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_REG_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public abstract TList<EdStudCourseRegAssess> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(null,_entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAssessHdrId(transactionManager, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public TList<EdStudCourseRegAssess> GetByEntPolicyAssessHdrId(System.Decimal? _entPolicyAssessHdrId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyAssessHdrId(null, _entPolicyAssessHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_ASSESS_HD_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseRegAssess&gt;"/> class.</returns>
		public abstract TList<EdStudCourseRegAssess> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyAssessHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_STATE_COURSE_ASSESS index.
		/// </summary>
		/// <param name="_edStudCourseRegAssessId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegAssessId(System.Decimal _edStudCourseRegAssessId)
		{
			int count = -1;
			return GetByEdStudCourseRegAssessId(null,_edStudCourseRegAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_STATE_COURSE_ASSESS index.
		/// </summary>
		/// <param name="_edStudCourseRegAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegAssessId(System.Decimal _edStudCourseRegAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegAssessId(null, _edStudCourseRegAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_STATE_COURSE_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegAssessId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegAssessId(TransactionManager transactionManager, System.Decimal _edStudCourseRegAssessId)
		{
			int count = -1;
			return GetByEdStudCourseRegAssessId(transactionManager, _edStudCourseRegAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_STATE_COURSE_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegAssessId(TransactionManager transactionManager, System.Decimal _edStudCourseRegAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegAssessId(transactionManager, _edStudCourseRegAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_STATE_COURSE_ASSESS index.
		/// </summary>
		/// <param name="_edStudCourseRegAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegAssessId(System.Decimal _edStudCourseRegAssessId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegAssessId(null, _edStudCourseRegAssessId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_STATE_COURSE_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegAssessId(TransactionManager transactionManager, System.Decimal _edStudCourseRegAssessId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_COURSE_REG_ASSESS index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegIdEdCodeCourseAssessId(System.Decimal _edStudCourseRegId, System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCodeCourseAssessId(null,_edStudCourseRegId, _edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_REG_ASSESS index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegIdEdCodeCourseAssessId(System.Decimal _edStudCourseRegId, System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCodeCourseAssessId(null, _edStudCourseRegId, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_REG_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegIdEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, System.Decimal _edCodeCourseAssessId)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCodeCourseAssessId(transactionManager, _edStudCourseRegId, _edCodeCourseAssessId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_REG_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegIdEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, System.Decimal _edCodeCourseAssessId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCodeCourseAssessId(transactionManager, _edStudCourseRegId, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_REG_ASSESS index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegIdEdCodeCourseAssessId(System.Decimal _edStudCourseRegId, System.Decimal _edCodeCourseAssessId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegIdEdCodeCourseAssessId(null, _edStudCourseRegId, _edCodeCourseAssessId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_REG_ASSESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseRegAssess GetByEdStudCourseRegIdEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, System.Decimal _edCodeCourseAssessId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCourseRegAssess&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCourseRegAssess&gt;"/></returns>
		public static TList<EdStudCourseRegAssess> Fill(IDataReader reader, TList<EdStudCourseRegAssess> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCourseRegAssess c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCourseRegAssess")
					.Append("|").Append((System.Decimal)reader["ED_STUD_COURSE_REG_ASSESS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCourseRegAssess>(
					key.ToString(), // EntityTrackingKey
					"EdStudCourseRegAssess",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCourseRegAssess();
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
					c.EdStudCourseRegAssessId = (System.Decimal)reader["ED_STUD_COURSE_REG_ASSESS_ID"];
					c.OriginalEdStudCourseRegAssessId = c.EdStudCourseRegAssessId;
					c.EdStudCourseRegId = (System.Decimal)reader["ED_STUD_COURSE_REG_ID"];
					c.EdCodeCourseAssessId = (System.Decimal)reader["ED_CODE_COURSE_ASSESS_ID"];
					c.AssessDeg = Convert.IsDBNull(reader["ASSESS_DEG"]) ? null : (System.Decimal?)reader["ASSESS_DEG"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdCodeCourseStatusId = Convert.IsDBNull(reader["ED_CODE_COURSE_STATUS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_STATUS_ID"];
					c.EntPolicyAssessHdrId = Convert.IsDBNull(reader["ENT_POLICY_ASSESS_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_ASSESS_HDR_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.AssessRaiseMark = Convert.IsDBNull(reader["ASSESS_RAISE_MARK"]) ? null : (System.Decimal?)reader["ASSESS_RAISE_MARK"];
					c.ApproveFlg = Convert.IsDBNull(reader["Approve_Flg"]) ? null : (System.Boolean?)reader["Approve_Flg"];
					c.ApproveDate = Convert.IsDBNull(reader["Approve_Date"]) ? null : (System.DateTime?)reader["Approve_Date"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCourseRegAssess entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCourseRegAssessId = (System.Decimal)reader[((int)EdStudCourseRegAssessColumn.EdStudCourseRegAssessId - 1)];
			entity.OriginalEdStudCourseRegAssessId = (System.Decimal)reader["ED_STUD_COURSE_REG_ASSESS_ID"];
			entity.EdStudCourseRegId = (System.Decimal)reader[((int)EdStudCourseRegAssessColumn.EdStudCourseRegId - 1)];
			entity.EdCodeCourseAssessId = (System.Decimal)reader[((int)EdStudCourseRegAssessColumn.EdCodeCourseAssessId - 1)];
			entity.AssessDeg = (reader.IsDBNull(((int)EdStudCourseRegAssessColumn.AssessDeg - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessColumn.AssessDeg - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudCourseRegAssessColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessColumn.AsFacultyInfoId - 1)];
			entity.EdCodeCourseStatusId = (reader.IsDBNull(((int)EdStudCourseRegAssessColumn.EdCodeCourseStatusId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessColumn.EdCodeCourseStatusId - 1)];
			entity.EntPolicyAssessHdrId = (reader.IsDBNull(((int)EdStudCourseRegAssessColumn.EntPolicyAssessHdrId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessColumn.EntPolicyAssessHdrId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudCourseRegAssessColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseRegAssessColumn.LastDate - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStudCourseRegAssessColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessColumn.SeFormId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudCourseRegAssessColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessColumn.SeUserId - 1)];
			entity.AssessRaiseMark = (reader.IsDBNull(((int)EdStudCourseRegAssessColumn.AssessRaiseMark - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAssessColumn.AssessRaiseMark - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EdStudCourseRegAssessColumn.ApproveFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudCourseRegAssessColumn.ApproveFlg - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)EdStudCourseRegAssessColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseRegAssessColumn.ApproveDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCourseRegAssess entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCourseRegAssessId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ASSESS_ID"];
			entity.OriginalEdStudCourseRegAssessId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ASSESS_ID"];
			entity.EdStudCourseRegId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.EdCodeCourseAssessId = (System.Decimal)dataRow["ED_CODE_COURSE_ASSESS_ID"];
			entity.AssessDeg = Convert.IsDBNull(dataRow["ASSESS_DEG"]) ? null : (System.Decimal?)dataRow["ASSESS_DEG"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCodeCourseStatusId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_STATUS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_STATUS_ID"];
			entity.EntPolicyAssessHdrId = Convert.IsDBNull(dataRow["ENT_POLICY_ASSESS_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_ASSESS_HDR_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.AssessRaiseMark = Convert.IsDBNull(dataRow["ASSESS_RAISE_MARK"]) ? null : (System.Decimal?)dataRow["ASSESS_RAISE_MARK"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["Approve_Flg"]) ? null : (System.Boolean?)dataRow["Approve_Flg"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["Approve_Date"]) ? null : (System.DateTime?)dataRow["Approve_Date"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAssess"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRegAssess Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAssess entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeCourseStatusIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseStatus|EdCodeCourseStatusIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseStatusId ?? 0.0m);
				EdCodeCourseStatus tmpEntity = EntityManager.LocateEntity<EdCodeCourseStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseStatusIdSource = tmpEntity;
				else
					entity.EdCodeCourseStatusIdSource = DataRepository.EdCodeCourseStatusProvider.GetByEdCodeCourseStatusId(transactionManager, (entity.EdCodeCourseStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseStatusProvider.DeepLoad(transactionManager, entity.EdCodeCourseStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseStatusIdSource

			#region EntPolicyAssessHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntPolicyAssessHdrId ?? 0.0m);
				EntPolicyAssessHdr tmpEntity = EntityManager.LocateEntity<EntPolicyAssessHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyAssessHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyAssessHdrIdSource = tmpEntity;
				else
					entity.EntPolicyAssessHdrIdSource = DataRepository.EntPolicyAssessHdrProvider.GetByEntPolicyAssessHdrId(transactionManager, (entity.EntPolicyAssessHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyAssessHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyAssessHdrProvider.DeepLoad(transactionManager, entity.EntPolicyAssessHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyAssessHdrIdSource

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

			#region EdCodeCourseAssessIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseAssessIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeCourseAssessId;
				EdCodeCourseAssess tmpEntity = EntityManager.LocateEntity<EdCodeCourseAssess>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseAssess), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseAssessIdSource = tmpEntity;
				else
					entity.EdCodeCourseAssessIdSource = DataRepository.EdCodeCourseAssessProvider.GetByEdCodeCourseAssessId(transactionManager, entity.EdCodeCourseAssessId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseAssessIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseAssessIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseAssessProvider.DeepLoad(transactionManager, entity.EdCodeCourseAssessIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseAssessIdSource

			#region EdStudCourseRegIdSource	
			if (CanDeepLoad(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseRegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudCourseRegId;
				EdStudCourseReg tmpEntity = EntityManager.LocateEntity<EdStudCourseReg>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseReg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseRegIdSource = tmpEntity;
				else
					entity.EdStudCourseRegIdSource = DataRepository.EdStudCourseRegProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseRegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseRegProvider.DeepLoad(transactionManager, entity.EdStudCourseRegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseRegIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCourseRegAssess object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCourseRegAssess instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRegAssess Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAssess entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeCourseStatusIdSource
			if (CanDeepSave(entity, "EdCodeCourseStatus|EdCodeCourseStatusIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseStatusIdSource != null)
			{
				DataRepository.EdCodeCourseStatusProvider.Save(transactionManager, entity.EdCodeCourseStatusIdSource);
				entity.EdCodeCourseStatusId = entity.EdCodeCourseStatusIdSource.EdCodeCourseStatusId;
			}
			#endregion 
			
			#region EntPolicyAssessHdrIdSource
			if (CanDeepSave(entity, "EntPolicyAssessHdr|EntPolicyAssessHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyAssessHdrIdSource != null)
			{
				DataRepository.EntPolicyAssessHdrProvider.Save(transactionManager, entity.EntPolicyAssessHdrIdSource);
				entity.EntPolicyAssessHdrId = entity.EntPolicyAssessHdrIdSource.EntPolicyAssessHdrId;
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
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region EdCodeCourseAssessIdSource
			if (CanDeepSave(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseAssessIdSource != null)
			{
				DataRepository.EdCodeCourseAssessProvider.Save(transactionManager, entity.EdCodeCourseAssessIdSource);
				entity.EdCodeCourseAssessId = entity.EdCodeCourseAssessIdSource.EdCodeCourseAssessId;
			}
			#endregion 
			
			#region EdStudCourseRegIdSource
			if (CanDeepSave(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseRegIdSource != null)
			{
				DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegIdSource);
				entity.EdStudCourseRegId = entity.EdStudCourseRegIdSource.EdStudCourseRegId;
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
	
	#region EdStudCourseRegAssessChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCourseRegAssess</c>
	///</summary>
	public enum EdStudCourseRegAssessChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseStatus</c> at EdCodeCourseStatusIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseStatus))]
		EdCodeCourseStatus,
		
		///<summary>
		/// Composite Property for <c>EntPolicyAssessHdr</c> at EntPolicyAssessHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyAssessHdr))]
		EntPolicyAssessHdr,
		
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
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseAssess</c> at EdCodeCourseAssessIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseAssess))]
		EdCodeCourseAssess,
		
		///<summary>
		/// Composite Property for <c>EdStudCourseReg</c> at EdStudCourseRegIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseReg))]
		EdStudCourseReg,
	}
	
	#endregion EdStudCourseRegAssessChildEntityTypes
	
	#region EdStudCourseRegAssessFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCourseRegAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegAssess"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegAssessFilterBuilder : SqlFilterBuilder<EdStudCourseRegAssessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessFilterBuilder class.
		/// </summary>
		public EdStudCourseRegAssessFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegAssessFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegAssessFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegAssessFilterBuilder
	
	#region EdStudCourseRegAssessParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCourseRegAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegAssess"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegAssessParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCourseRegAssessColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessParameterBuilder class.
		/// </summary>
		public EdStudCourseRegAssessParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegAssessParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegAssessParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegAssessParameterBuilder
	
	#region EdStudCourseRegAssessSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCourseRegAssessColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegAssess"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCourseRegAssessSortBuilder : SqlSortBuilder<EdStudCourseRegAssessColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAssessSqlSortBuilder class.
		/// </summary>
		public EdStudCourseRegAssessSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCourseRegAssessSortBuilder
	
} // end namespace
