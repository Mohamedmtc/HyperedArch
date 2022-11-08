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
	/// This class is the base class for any <see cref="EdExamSchdlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdExamSchdlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdExamSchdl, UMIS_VER2.BusinessLyer.EdExamSchdlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamSchdlKey key)
		{
			return Delete(transactionManager, key.EdExamSchdlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edExamSchdlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edExamSchdlId)
		{
			return Delete(null, _edExamSchdlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edExamSchdlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_EXAM_SCHDL_TYPE key.
		///		FK_ED_CDE_EXAM_SCHDL_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamSchdlTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByEdCdeExamSchdlTypeId(System.Decimal? _edCdeExamSchdlTypeId)
		{
			int count = -1;
			return GetByEdCdeExamSchdlTypeId(_edCdeExamSchdlTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_EXAM_SCHDL_TYPE key.
		///		FK_ED_CDE_EXAM_SCHDL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamSchdlTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		/// <remarks></remarks>
		public TList<EdExamSchdl> GetByEdCdeExamSchdlTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamSchdlTypeId)
		{
			int count = -1;
			return GetByEdCdeExamSchdlTypeId(transactionManager, _edCdeExamSchdlTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_EXAM_SCHDL_TYPE key.
		///		FK_ED_CDE_EXAM_SCHDL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamSchdlTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByEdCdeExamSchdlTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamSchdlTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamSchdlTypeId(transactionManager, _edCdeExamSchdlTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_EXAM_SCHDL_TYPE key.
		///		fkEdCdeExamSchdlType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamSchdlTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByEdCdeExamSchdlTypeId(System.Decimal? _edCdeExamSchdlTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamSchdlTypeId(null, _edCdeExamSchdlTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_EXAM_SCHDL_TYPE key.
		///		fkEdCdeExamSchdlType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamSchdlTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByEdCdeExamSchdlTypeId(System.Decimal? _edCdeExamSchdlTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamSchdlTypeId(null, _edCdeExamSchdlTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_EXAM_SCHDL_TYPE key.
		///		FK_ED_CDE_EXAM_SCHDL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamSchdlTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public abstract TList<EdExamSchdl> GetByEdCdeExamSchdlTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamSchdlTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_ED_CDE_EXAM_TYPE key.
		///		FK_ED_EXAM_SCHDL_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(_edCdeExamTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_ED_CDE_EXAM_TYPE key.
		///		FK_ED_EXAM_SCHDL_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		/// <remarks></remarks>
		public TList<EdExamSchdl> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_ED_CDE_EXAM_TYPE key.
		///		FK_ED_EXAM_SCHDL_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_ED_CDE_EXAM_TYPE key.
		///		fkEdExamSchdlEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_ED_CDE_EXAM_TYPE key.
		///		fkEdExamSchdlEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByEdCdeExamTypeId(System.Decimal? _edCdeExamTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_ED_CDE_EXAM_TYPE key.
		///		FK_ED_EXAM_SCHDL_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public abstract TList<EdExamSchdl> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal? _edCdeExamTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_GS_CODE_GENDER key.
		///		FK_ED_EXAM_SCHDL_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_GS_CODE_GENDER key.
		///		FK_ED_EXAM_SCHDL_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		/// <remarks></remarks>
		public TList<EdExamSchdl> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_GS_CODE_GENDER key.
		///		FK_ED_EXAM_SCHDL_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_GS_CODE_GENDER key.
		///		fkEdExamSchdlGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_GS_CODE_GENDER key.
		///		fkEdExamSchdlGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public TList<EdExamSchdl> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_EXAM_SCHDL_GS_CODE_GENDER key.
		///		FK_ED_EXAM_SCHDL_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdExamSchdl objects.</returns>
		public abstract TList<EdExamSchdl> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdExamSchdl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamSchdlKey key, int start, int pageLength)
		{
			return GetByEdExamSchdlId(transactionManager, key.EdExamSchdlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public abstract TList<EdExamSchdl> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public abstract TList<EdExamSchdl> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_COURSE_ASSES_1 index.
		/// </summary>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCodeCourseAssessId(System.Decimal? _edCodeCourseAssessId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public abstract TList<EdExamSchdl> GetByEdCodeCourseAssessId(TransactionManager transactionManager, System.Decimal? _edCodeCourseAssessId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null,_edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public abstract TList<EdExamSchdl> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCourseId(System.Decimal _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public TList<EdExamSchdl> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdExamSchdl&gt;"/> class.</returns>
		public abstract TList<EdExamSchdl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_EXAM index.
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdExamSchdlId(System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdExamSchdlId(null,_edExamSchdlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM index.
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdExamSchdlId(System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamSchdlId(null, _edExamSchdlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdExamSchdlId(transactionManager, _edExamSchdlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamSchdlId(transactionManager, _edExamSchdlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM index.
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdExamSchdlId(System.Decimal _edExamSchdlId, int start, int pageLength, out int count)
		{
			return GetByEdExamSchdlId(null, _edExamSchdlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_EXAM_SCHDL index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_examDate"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _gsCodeGenderId, System.Decimal? _edCdeExamTypeId, System.DateTime? _examDate)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(null,_edAcadYearId, _edCodeSemesterId, _edCourseId, _edCodeCourseAssessId, _gsCodeGenderId, _edCdeExamTypeId, _examDate, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_EXAM_SCHDL index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_examDate"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _gsCodeGenderId, System.Decimal? _edCdeExamTypeId, System.DateTime? _examDate, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(null, _edAcadYearId, _edCodeSemesterId, _edCourseId, _edCodeCourseAssessId, _gsCodeGenderId, _edCdeExamTypeId, _examDate, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_EXAM_SCHDL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_examDate"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _gsCodeGenderId, System.Decimal? _edCdeExamTypeId, System.DateTime? _examDate)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(transactionManager, _edAcadYearId, _edCodeSemesterId, _edCourseId, _edCodeCourseAssessId, _gsCodeGenderId, _edCdeExamTypeId, _examDate, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_EXAM_SCHDL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_examDate"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _gsCodeGenderId, System.Decimal? _edCdeExamTypeId, System.DateTime? _examDate, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(transactionManager, _edAcadYearId, _edCodeSemesterId, _edCourseId, _edCodeCourseAssessId, _gsCodeGenderId, _edCdeExamTypeId, _examDate, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_EXAM_SCHDL index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_examDate"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _gsCodeGenderId, System.Decimal? _edCdeExamTypeId, System.DateTime? _examDate, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(null, _edAcadYearId, _edCodeSemesterId, _edCourseId, _edCodeCourseAssessId, _gsCodeGenderId, _edCdeExamTypeId, _examDate, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_EXAM_SCHDL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseAssessId"></param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="_examDate"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdExamSchdl GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdEdCodeCourseAssessIdGsCodeGenderIdEdCdeExamTypeIdExamDate(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal? _edCodeCourseAssessId, System.Decimal? _gsCodeGenderId, System.Decimal? _edCdeExamTypeId, System.DateTime? _examDate, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdExamSchdl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdExamSchdl&gt;"/></returns>
		public static TList<EdExamSchdl> Fill(IDataReader reader, TList<EdExamSchdl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdExamSchdl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdExamSchdl")
					.Append("|").Append((System.Decimal)reader["ED_EXAM_SCHDL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdExamSchdl>(
					key.ToString(), // EntityTrackingKey
					"EdExamSchdl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdExamSchdl();
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
					c.EdExamSchdlId = (System.Decimal)reader["ED_EXAM_SCHDL_ID"];
					c.OriginalEdExamSchdlId = c.EdExamSchdlId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdCodeCourseAssessId = Convert.IsDBNull(reader["ED_CODE_COURSE_ASSESS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_ASSESS_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.ExamDate = Convert.IsDBNull(reader["EXAM_DATE"]) ? null : (System.DateTime?)reader["EXAM_DATE"];
					c.FromTime = Convert.IsDBNull(reader["FROM_TIME"]) ? null : (System.DateTime?)reader["FROM_TIME"];
					c.ToTime = Convert.IsDBNull(reader["TO_TIME"]) ? null : (System.DateTime?)reader["TO_TIME"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdCdeExamTypeId = Convert.IsDBNull(reader["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_EXAM_TYPE_ID"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.RsultApproveDate = Convert.IsDBNull(reader["RSULT_APPROVE_DATE"]) ? null : (System.DateTime?)reader["RSULT_APPROVE_DATE"];
					c.SeUserRsultApproveId = Convert.IsDBNull(reader["SE_USER_RSULT_APPROVE_ID"]) ? null : (System.Decimal?)reader["SE_USER_RSULT_APPROVE_ID"];
					c.ExmSchdHodApproveDt = Convert.IsDBNull(reader["EXM_SCHD_HOD_APPROVE_DT"]) ? null : (System.DateTime?)reader["EXM_SCHD_HOD_APPROVE_DT"];
					c.ExmSchdHodApprvUsrId = Convert.IsDBNull(reader["EXM_SCHD_HOD_APPRV_USR_ID"]) ? null : (System.Decimal?)reader["EXM_SCHD_HOD_APPRV_USR_ID"];
					c.ExamVersionNo = Convert.IsDBNull(reader["EXAM_VERSION_NO"]) ? null : (System.Int32?)reader["EXAM_VERSION_NO"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EdCdeExamSchdlTypeId = Convert.IsDBNull(reader["ED_CDE_EXAM_SCHDL_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CDE_EXAM_SCHDL_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdExamSchdl entity)
		{
			if (!reader.Read()) return;
			
			entity.EdExamSchdlId = (System.Decimal)reader[((int)EdExamSchdlColumn.EdExamSchdlId - 1)];
			entity.OriginalEdExamSchdlId = (System.Decimal)reader["ED_EXAM_SCHDL_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdExamSchdlColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdExamSchdlColumn.EdCodeSemesterId - 1)];
			entity.EdCodeCourseAssessId = (reader.IsDBNull(((int)EdExamSchdlColumn.EdCodeCourseAssessId - 1)))?null:(System.Decimal?)reader[((int)EdExamSchdlColumn.EdCodeCourseAssessId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EdExamSchdlColumn.EdCourseId - 1)];
			entity.ExamDate = (reader.IsDBNull(((int)EdExamSchdlColumn.ExamDate - 1)))?null:(System.DateTime?)reader[((int)EdExamSchdlColumn.ExamDate - 1)];
			entity.FromTime = (reader.IsDBNull(((int)EdExamSchdlColumn.FromTime - 1)))?null:(System.DateTime?)reader[((int)EdExamSchdlColumn.FromTime - 1)];
			entity.ToTime = (reader.IsDBNull(((int)EdExamSchdlColumn.ToTime - 1)))?null:(System.DateTime?)reader[((int)EdExamSchdlColumn.ToTime - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdExamSchdlColumn.Notes - 1)))?null:(System.String)reader[((int)EdExamSchdlColumn.Notes - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdExamSchdlColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdExamSchdlColumn.AsFacultyInfoId - 1)];
			entity.EdCdeExamTypeId = (reader.IsDBNull(((int)EdExamSchdlColumn.EdCdeExamTypeId - 1)))?null:(System.Decimal?)reader[((int)EdExamSchdlColumn.EdCdeExamTypeId - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)EdExamSchdlColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)EdExamSchdlColumn.GsCodeGenderId - 1)];
			entity.RsultApproveDate = (reader.IsDBNull(((int)EdExamSchdlColumn.RsultApproveDate - 1)))?null:(System.DateTime?)reader[((int)EdExamSchdlColumn.RsultApproveDate - 1)];
			entity.SeUserRsultApproveId = (reader.IsDBNull(((int)EdExamSchdlColumn.SeUserRsultApproveId - 1)))?null:(System.Decimal?)reader[((int)EdExamSchdlColumn.SeUserRsultApproveId - 1)];
			entity.ExmSchdHodApproveDt = (reader.IsDBNull(((int)EdExamSchdlColumn.ExmSchdHodApproveDt - 1)))?null:(System.DateTime?)reader[((int)EdExamSchdlColumn.ExmSchdHodApproveDt - 1)];
			entity.ExmSchdHodApprvUsrId = (reader.IsDBNull(((int)EdExamSchdlColumn.ExmSchdHodApprvUsrId - 1)))?null:(System.Decimal?)reader[((int)EdExamSchdlColumn.ExmSchdHodApprvUsrId - 1)];
			entity.ExamVersionNo = (reader.IsDBNull(((int)EdExamSchdlColumn.ExamVersionNo - 1)))?null:(System.Int32?)reader[((int)EdExamSchdlColumn.ExamVersionNo - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdExamSchdlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdExamSchdlColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdExamSchdlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdExamSchdlColumn.LastDate - 1)];
			entity.EdCdeExamSchdlTypeId = (reader.IsDBNull(((int)EdExamSchdlColumn.EdCdeExamSchdlTypeId - 1)))?null:(System.Decimal?)reader[((int)EdExamSchdlColumn.EdCdeExamSchdlTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdExamSchdl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdExamSchdlId = (System.Decimal)dataRow["ED_EXAM_SCHDL_ID"];
			entity.OriginalEdExamSchdlId = (System.Decimal)dataRow["ED_EXAM_SCHDL_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdCodeCourseAssessId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_ASSESS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_ASSESS_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.ExamDate = Convert.IsDBNull(dataRow["EXAM_DATE"]) ? null : (System.DateTime?)dataRow["EXAM_DATE"];
			entity.FromTime = Convert.IsDBNull(dataRow["FROM_TIME"]) ? null : (System.DateTime?)dataRow["FROM_TIME"];
			entity.ToTime = Convert.IsDBNull(dataRow["TO_TIME"]) ? null : (System.DateTime?)dataRow["TO_TIME"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdCdeExamTypeId = Convert.IsDBNull(dataRow["ED_CDE_EXAM_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_EXAM_TYPE_ID"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.RsultApproveDate = Convert.IsDBNull(dataRow["RSULT_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["RSULT_APPROVE_DATE"];
			entity.SeUserRsultApproveId = Convert.IsDBNull(dataRow["SE_USER_RSULT_APPROVE_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_RSULT_APPROVE_ID"];
			entity.ExmSchdHodApproveDt = Convert.IsDBNull(dataRow["EXM_SCHD_HOD_APPROVE_DT"]) ? null : (System.DateTime?)dataRow["EXM_SCHD_HOD_APPROVE_DT"];
			entity.ExmSchdHodApprvUsrId = Convert.IsDBNull(dataRow["EXM_SCHD_HOD_APPRV_USR_ID"]) ? null : (System.Decimal?)dataRow["EXM_SCHD_HOD_APPRV_USR_ID"];
			entity.ExamVersionNo = Convert.IsDBNull(dataRow["EXAM_VERSION_NO"]) ? null : (System.Int32?)dataRow["EXAM_VERSION_NO"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.EdCdeExamSchdlTypeId = Convert.IsDBNull(dataRow["ED_CDE_EXAM_SCHDL_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_EXAM_SCHDL_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdExamSchdl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdExamSchdl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamSchdl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCdeExamSchdlTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeExamSchdlType|EdCdeExamSchdlTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExamSchdlTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeExamSchdlTypeId ?? 0.0m);
				EdCdeExamSchdlType tmpEntity = EntityManager.LocateEntity<EdCdeExamSchdlType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExamSchdlType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExamSchdlTypeIdSource = tmpEntity;
				else
					entity.EdCdeExamSchdlTypeIdSource = DataRepository.EdCdeExamSchdlTypeProvider.GetByEdCdeExamSchdlTypeId(transactionManager, (entity.EdCdeExamSchdlTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeExamSchdlTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeExamSchdlTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeExamSchdlTypeProvider.DeepLoad(transactionManager, entity.EdCdeExamSchdlTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeExamSchdlTypeIdSource

			#region EdCodeCourseAssessIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseAssess|EdCodeCourseAssessIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseAssessIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseAssessId ?? 0.0m);
				EdCodeCourseAssess tmpEntity = EntityManager.LocateEntity<EdCodeCourseAssess>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseAssess), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseAssessIdSource = tmpEntity;
				else
					entity.EdCodeCourseAssessIdSource = DataRepository.EdCodeCourseAssessProvider.GetByEdCodeCourseAssessId(transactionManager, (entity.EdCodeCourseAssessId ?? 0.0m));		
				
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

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

			#region EdCdeExamTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExamTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeExamTypeId ?? 0.0m);
				EdCdeExamType tmpEntity = EntityManager.LocateEntity<EdCdeExamType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExamType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExamTypeIdSource = tmpEntity;
				else
					entity.EdCdeExamTypeIdSource = DataRepository.EdCdeExamTypeProvider.GetByEdCdeExamTypeId(transactionManager, (entity.EdCdeExamTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeExamTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeExamTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeExamTypeProvider.DeepLoad(transactionManager, entity.EdCdeExamTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeExamTypeIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterIdSource

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeGenderId ?? 0.0m);
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, (entity.GsCodeGenderId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeGenderIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeGenderIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeGenderProvider.DeepLoad(transactionManager, entity.GsCodeGenderIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeGenderIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdExamSchdlId methods when available
			
			#region CoExaminerCorectorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExaminerCorector>|CoExaminerCorectorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExaminerCorectorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExaminerCorectorCollection = DataRepository.CoExaminerCorectorProvider.GetByEdExamSchdlId(transactionManager, entity.EdExamSchdlId);

				if (deep && entity.CoExaminerCorectorCollection.Count > 0)
				{
					deepHandles.Add("CoExaminerCorectorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExaminerCorector>) DataRepository.CoExaminerCorectorProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExaminerCorectorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamStudAbsence>|EdExamStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamStudAbsenceCollection = DataRepository.EdExamStudAbsenceProvider.GetByEdExamSchdlId(transactionManager, entity.EdExamSchdlId);

				if (deep && entity.EdExamStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdExamStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamStudAbsence>) DataRepository.EdExamStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCheatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCheat>|EdStudCheatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCheatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCheatCollection = DataRepository.EdStudCheatProvider.GetByEdExamSchdlId(transactionManager, entity.EdExamSchdlId);

				if (deep && entity.EdStudCheatCollection.Count > 0)
				{
					deepHandles.Add("EdStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCheat>) DataRepository.EdStudCheatProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCheatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExamSchdlPlaceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamSchdlPlace>|CoExamSchdlPlaceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamSchdlPlaceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamSchdlPlaceCollection = DataRepository.CoExamSchdlPlaceProvider.GetByEdExamSchdlId(transactionManager, entity.EdExamSchdlId);

				if (deep && entity.CoExamSchdlPlaceCollection.Count > 0)
				{
					deepHandles.Add("CoExamSchdlPlaceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamSchdlPlace>) DataRepository.CoExamSchdlPlaceProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamSchdlPlaceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdExamSchdl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdExamSchdl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdExamSchdl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdExamSchdl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCdeExamSchdlTypeIdSource
			if (CanDeepSave(entity, "EdCdeExamSchdlType|EdCdeExamSchdlTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExamSchdlTypeIdSource != null)
			{
				DataRepository.EdCdeExamSchdlTypeProvider.Save(transactionManager, entity.EdCdeExamSchdlTypeIdSource);
				entity.EdCdeExamSchdlTypeId = entity.EdCdeExamSchdlTypeIdSource.EdCdeExamSchdlTypeId;
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
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCdeExamTypeIdSource
			if (CanDeepSave(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExamTypeIdSource != null)
			{
				DataRepository.EdCdeExamTypeProvider.Save(transactionManager, entity.EdCdeExamTypeIdSource);
				entity.EdCdeExamTypeId = entity.EdCdeExamTypeIdSource.EdCdeExamTypeId;
			}
			#endregion 
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<CoExaminerCorector>
				if (CanDeepSave(entity.CoExaminerCorectorCollection, "List<CoExaminerCorector>|CoExaminerCorectorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExaminerCorector child in entity.CoExaminerCorectorCollection)
					{
						if(child.EdExamSchdlIdSource != null)
						{
							child.EdExamSchdlId = child.EdExamSchdlIdSource.EdExamSchdlId;
						}
						else
						{
							child.EdExamSchdlId = entity.EdExamSchdlId;
						}

					}

					if (entity.CoExaminerCorectorCollection.Count > 0 || entity.CoExaminerCorectorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExaminerCorectorProvider.Save(transactionManager, entity.CoExaminerCorectorCollection);
						
						deepHandles.Add("CoExaminerCorectorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExaminerCorector >) DataRepository.CoExaminerCorectorProvider.DeepSave,
							new object[] { transactionManager, entity.CoExaminerCorectorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdExamStudAbsence>
				if (CanDeepSave(entity.EdExamStudAbsenceCollection, "List<EdExamStudAbsence>|EdExamStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamStudAbsence child in entity.EdExamStudAbsenceCollection)
					{
						if(child.EdExamSchdlIdSource != null)
						{
							child.EdExamSchdlId = child.EdExamSchdlIdSource.EdExamSchdlId;
						}
						else
						{
							child.EdExamSchdlId = entity.EdExamSchdlId;
						}

					}

					if (entity.EdExamStudAbsenceCollection.Count > 0 || entity.EdExamStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamStudAbsenceProvider.Save(transactionManager, entity.EdExamStudAbsenceCollection);
						
						deepHandles.Add("EdExamStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamStudAbsence >) DataRepository.EdExamStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCheat>
				if (CanDeepSave(entity.EdStudCheatCollection, "List<EdStudCheat>|EdStudCheatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCheat child in entity.EdStudCheatCollection)
					{
						if(child.EdExamSchdlIdSource != null)
						{
							child.EdExamSchdlId = child.EdExamSchdlIdSource.EdExamSchdlId;
						}
						else
						{
							child.EdExamSchdlId = entity.EdExamSchdlId;
						}

					}

					if (entity.EdStudCheatCollection.Count > 0 || entity.EdStudCheatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCheatProvider.Save(transactionManager, entity.EdStudCheatCollection);
						
						deepHandles.Add("EdStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCheat >) DataRepository.EdStudCheatProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCheatCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExamSchdlPlace>
				if (CanDeepSave(entity.CoExamSchdlPlaceCollection, "List<CoExamSchdlPlace>|CoExamSchdlPlaceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamSchdlPlace child in entity.CoExamSchdlPlaceCollection)
					{
						if(child.EdExamSchdlIdSource != null)
						{
							child.EdExamSchdlId = child.EdExamSchdlIdSource.EdExamSchdlId;
						}
						else
						{
							child.EdExamSchdlId = entity.EdExamSchdlId;
						}

					}

					if (entity.CoExamSchdlPlaceCollection.Count > 0 || entity.CoExamSchdlPlaceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamSchdlPlaceProvider.Save(transactionManager, entity.CoExamSchdlPlaceCollection);
						
						deepHandles.Add("CoExamSchdlPlaceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamSchdlPlace >) DataRepository.CoExamSchdlPlaceProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamSchdlPlaceCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdExamSchdlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdExamSchdl</c>
	///</summary>
	public enum EdExamSchdlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdCdeExamSchdlType</c> at EdCdeExamSchdlTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamSchdlType))]
		EdCdeExamSchdlType,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseAssess</c> at EdCodeCourseAssessIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseAssess))]
		EdCodeCourseAssess,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCdeExamType</c> at EdCdeExamTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamType))]
		EdCdeExamType,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		///<summary>
		/// Collection of <c>EdExamSchdl</c> as OneToMany for CoExaminerCorectorCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExaminerCorector>))]
		CoExaminerCorectorCollection,
		///<summary>
		/// Collection of <c>EdExamSchdl</c> as OneToMany for EdExamStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamStudAbsence>))]
		EdExamStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdExamSchdl</c> as OneToMany for EdStudCheatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCheat>))]
		EdStudCheatCollection,
		///<summary>
		/// Collection of <c>EdExamSchdl</c> as OneToMany for CoExamSchdlPlaceCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamSchdlPlace>))]
		CoExamSchdlPlaceCollection,
	}
	
	#endregion EdExamSchdlChildEntityTypes
	
	#region EdExamSchdlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdExamSchdlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamSchdl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdExamSchdlFilterBuilder : SqlFilterBuilder<EdExamSchdlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamSchdlFilterBuilder class.
		/// </summary>
		public EdExamSchdlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdExamSchdlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdExamSchdlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdExamSchdlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdExamSchdlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdExamSchdlFilterBuilder
	
	#region EdExamSchdlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdExamSchdlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamSchdl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdExamSchdlParameterBuilder : ParameterizedSqlFilterBuilder<EdExamSchdlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamSchdlParameterBuilder class.
		/// </summary>
		public EdExamSchdlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdExamSchdlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdExamSchdlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdExamSchdlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdExamSchdlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdExamSchdlParameterBuilder
	
	#region EdExamSchdlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdExamSchdlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdExamSchdl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdExamSchdlSortBuilder : SqlSortBuilder<EdExamSchdlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdExamSchdlSqlSortBuilder class.
		/// </summary>
		public EdExamSchdlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdExamSchdlSortBuilder
	
} // end namespace
