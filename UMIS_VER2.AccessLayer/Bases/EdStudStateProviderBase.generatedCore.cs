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
	/// This class is the base class for any <see cref="EdStudStateProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudStateProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudState, UMIS_VER2.BusinessLyer.EdStudStateKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudStateKey key)
		{
			return Delete(transactionManager, key.EdStudStateId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudStateId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudStateId)
		{
			return Delete(null, _edStudStateId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudStateId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudStateId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ED_ACAD_YEAR key.
		///		FK_ED_STUD_STATE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		public TList<EdStudState> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ED_ACAD_YEAR key.
		///		FK_ED_STUD_STATE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudState> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ED_ACAD_YEAR key.
		///		FK_ED_STUD_STATE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		public TList<EdStudState> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ED_ACAD_YEAR key.
		///		fkEdStudStateEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		public TList<EdStudState> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ED_ACAD_YEAR key.
		///		fkEdStudStateEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		public TList<EdStudState> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ED_ACAD_YEAR key.
		///		FK_ED_STUD_STATE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام  الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		public abstract TList<EdStudState> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ENT_CODE_ENTITY_TYPE key.
		///		FK_ED_STUD_STATE_ENT_CODE_ENTITY_TYPE Description: 
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		public TList<EdStudState> GetByEntCodeEntityTypeId(System.Decimal? _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(_entCodeEntityTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ENT_CODE_ENTITY_TYPE key.
		///		FK_ED_STUD_STATE_ENT_CODE_ENTITY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudState> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal? _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ENT_CODE_ENTITY_TYPE key.
		///		FK_ED_STUD_STATE_ENT_CODE_ENTITY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		public TList<EdStudState> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal? _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ENT_CODE_ENTITY_TYPE key.
		///		fkEdStudStateEntCodeEntityType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		public TList<EdStudState> GetByEntCodeEntityTypeId(System.Decimal? _entCodeEntityTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ENT_CODE_ENTITY_TYPE key.
		///		fkEdStudStateEntCodeEntityType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		public TList<EdStudState> GetByEntCodeEntityTypeId(System.Decimal? _entCodeEntityTypeId, int start, int pageLength,out int count)
		{
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_STATE_ENT_CODE_ENTITY_TYPE key.
		///		FK_ED_STUD_STATE_ENT_CODE_ENTITY_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudState objects.</returns>
		public abstract TList<EdStudState> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal? _entCodeEntityTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudState Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudStateKey key, int start, int pageLength)
		{
			return GetByEdStudStateId(transactionManager, key.EdStudStateId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public abstract TList<EdStudState> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_STATE_STATUS_1 index.
		/// </summary>
		/// <param name="_edCodeStateStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEdCodeStateStatusId(System.Decimal? _edCodeStateStatusId)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(null,_edCodeStateStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_STATE_STATUS_1 index.
		/// </summary>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEdCodeStateStatusId(System.Decimal? _edCodeStateStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(null, _edCodeStateStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_STATE_STATUS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal? _edCodeStateStatusId)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(transactionManager, _edCodeStateStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_STATE_STATUS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal? _edCodeStateStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(transactionManager, _edCodeStateStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_STATE_STATUS_1 index.
		/// </summary>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEdCodeStateStatusId(System.Decimal? _edCodeStateStatusId, int start, int pageLength, out int count)
		{
			return GetByEdCodeStateStatusId(null, _edCodeStateStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_STATE_STATUS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public abstract TList<EdStudState> GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal? _edCodeStateStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(null,_edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public abstract TList<EdStudState> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(null,_entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public TList<EdStudState> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudState&gt;"/> class.</returns>
		public abstract TList<EdStudState> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_STUD_STATE index.
		/// </summary>
		/// <param name="_edStudStateId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudState GetByEdStudStateId(System.Decimal _edStudStateId)
		{
			int count = -1;
			return GetByEdStudStateId(null,_edStudStateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE index.
		/// </summary>
		/// <param name="_edStudStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudState GetByEdStudStateId(System.Decimal _edStudStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudStateId(null, _edStudStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudStateId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudState GetByEdStudStateId(TransactionManager transactionManager, System.Decimal _edStudStateId)
		{
			int count = -1;
			return GetByEdStudStateId(transactionManager, _edStudStateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudState GetByEdStudStateId(TransactionManager transactionManager, System.Decimal _edStudStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudStateId(transactionManager, _edStudStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE index.
		/// </summary>
		/// <param name="_edStudStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudState GetByEdStudStateId(System.Decimal _edStudStateId, int start, int pageLength, out int count)
		{
			return GetByEdStudStateId(null, _edStudStateId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudState GetByEdStudStateId(TransactionManager transactionManager, System.Decimal _edStudStateId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_STATE index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudState GetByEdStudSemesterIdEntMainId(System.Decimal _edStudSemesterId, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEntMainId(null,_edStudSemesterId, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_STATE index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudState GetByEdStudSemesterIdEntMainId(System.Decimal _edStudSemesterId, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEntMainId(null, _edStudSemesterId, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudState GetByEdStudSemesterIdEntMainId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEntMainId(transactionManager, _edStudSemesterId, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudState GetByEdStudSemesterIdEntMainId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEntMainId(transactionManager, _edStudSemesterId, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_STATE index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudState GetByEdStudSemesterIdEntMainId(System.Decimal _edStudSemesterId, System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterIdEntMainId(null, _edStudSemesterId, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_entMainId">الخطة الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudState GetByEdStudSemesterIdEntMainId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudState&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudState&gt;"/></returns>
		public static TList<EdStudState> Fill(IDataReader reader, TList<EdStudState> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudState c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudState")
					.Append("|").Append((System.Decimal)reader["ED_STUD_STATE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudState>(
					key.ToString(), // EntityTrackingKey
					"EdStudState",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudState();
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
					c.EdStudStateId = (System.Decimal)reader["ED_STUD_STATE_ID"];
					c.OriginalEdStudStateId = c.EdStudStateId;
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.TotCh = Convert.IsDBNull(reader["TOT_CH"]) ? null : (System.Decimal?)reader["TOT_CH"];
					c.FullfilledCh = Convert.IsDBNull(reader["FULLFILLED_CH"]) ? null : (System.Decimal?)reader["FULLFILLED_CH"];
					c.EdCodeStateStatusId = Convert.IsDBNull(reader["ED_CODE_STATE_STATUS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_STATE_STATUS_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.IsDeclared = (System.Decimal)reader["IS_DECLARED"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EntCodeEntityTypeId = Convert.IsDBNull(reader["ENT_CODE_ENTITY_TYPE_ID"]) ? null : (System.Decimal?)reader["ENT_CODE_ENTITY_TYPE_ID"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudState entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudStateId = (System.Decimal)reader[((int)EdStudStateColumn.EdStudStateId - 1)];
			entity.OriginalEdStudStateId = (System.Decimal)reader["ED_STUD_STATE_ID"];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudStateColumn.EdStudSemesterId - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)EdStudStateColumn.EntMainId - 1)];
			entity.TotCh = (reader.IsDBNull(((int)EdStudStateColumn.TotCh - 1)))?null:(System.Decimal?)reader[((int)EdStudStateColumn.TotCh - 1)];
			entity.FullfilledCh = (reader.IsDBNull(((int)EdStudStateColumn.FullfilledCh - 1)))?null:(System.Decimal?)reader[((int)EdStudStateColumn.FullfilledCh - 1)];
			entity.EdCodeStateStatusId = (reader.IsDBNull(((int)EdStudStateColumn.EdCodeStateStatusId - 1)))?null:(System.Decimal?)reader[((int)EdStudStateColumn.EdCodeStateStatusId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudStateColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudStateColumn.AsFacultyInfoId - 1)];
			entity.IsDeclared = (System.Decimal)reader[((int)EdStudStateColumn.IsDeclared - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EdStudStateColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EdStudStateColumn.EdAcadYearId - 1)];
			entity.EntCodeEntityTypeId = (reader.IsDBNull(((int)EdStudStateColumn.EntCodeEntityTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudStateColumn.EntCodeEntityTypeId - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStudStateColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStudStateColumn.SeFormId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudStateColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudStateColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudStateColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudStateColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudState entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudStateId = (System.Decimal)dataRow["ED_STUD_STATE_ID"];
			entity.OriginalEdStudStateId = (System.Decimal)dataRow["ED_STUD_STATE_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.TotCh = Convert.IsDBNull(dataRow["TOT_CH"]) ? null : (System.Decimal?)dataRow["TOT_CH"];
			entity.FullfilledCh = Convert.IsDBNull(dataRow["FULLFILLED_CH"]) ? null : (System.Decimal?)dataRow["FULLFILLED_CH"];
			entity.EdCodeStateStatusId = Convert.IsDBNull(dataRow["ED_CODE_STATE_STATUS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_STATE_STATUS_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.IsDeclared = (System.Decimal)dataRow["IS_DECLARED"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EntCodeEntityTypeId = Convert.IsDBNull(dataRow["ENT_CODE_ENTITY_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudState"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudState Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudState entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
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

			#region EdCodeStateStatusIdSource	
			if (CanDeepLoad(entity, "EdCodeStateStatus|EdCodeStateStatusIdSource", deepLoadType, innerList) 
				&& entity.EdCodeStateStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeStateStatusId ?? 0.0m);
				EdCodeStateStatus tmpEntity = EntityManager.LocateEntity<EdCodeStateStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeStateStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeStateStatusIdSource = tmpEntity;
				else
					entity.EdCodeStateStatusIdSource = DataRepository.EdCodeStateStatusProvider.GetByEdCodeStateStatusId(transactionManager, (entity.EdCodeStateStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeStateStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeStateStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeStateStatusProvider.DeepLoad(transactionManager, entity.EdCodeStateStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeStateStatusIdSource

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudSemesterId;
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource

			#region EntCodeEntityTypeIdSource	
			if (CanDeepLoad(entity, "EntCodeEntityType|EntCodeEntityTypeIdSource", deepLoadType, innerList) 
				&& entity.EntCodeEntityTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCodeEntityTypeId ?? 0.0m);
				EntCodeEntityType tmpEntity = EntityManager.LocateEntity<EntCodeEntityType>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeEntityType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeEntityTypeIdSource = tmpEntity;
				else
					entity.EntCodeEntityTypeIdSource = DataRepository.EntCodeEntityTypeProvider.GetByEntCodeEntityTypeId(transactionManager, (entity.EntCodeEntityTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeEntityTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeEntityTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeEntityTypeProvider.DeepLoad(transactionManager, entity.EntCodeEntityTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeEntityTypeIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudState object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudState instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudState Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudState entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCodeStateStatusIdSource
			if (CanDeepSave(entity, "EdCodeStateStatus|EdCodeStateStatusIdSource", deepSaveType, innerList) 
				&& entity.EdCodeStateStatusIdSource != null)
			{
				DataRepository.EdCodeStateStatusProvider.Save(transactionManager, entity.EdCodeStateStatusIdSource);
				entity.EdCodeStateStatusId = entity.EdCodeStateStatusIdSource.EdCodeStateStatusId;
			}
			#endregion 
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region EntCodeEntityTypeIdSource
			if (CanDeepSave(entity, "EntCodeEntityType|EntCodeEntityTypeIdSource", deepSaveType, innerList) 
				&& entity.EntCodeEntityTypeIdSource != null)
			{
				DataRepository.EntCodeEntityTypeProvider.Save(transactionManager, entity.EntCodeEntityTypeIdSource);
				entity.EntCodeEntityTypeId = entity.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
			}
			#endregion 
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
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
	
	#region EdStudStateChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudState</c>
	///</summary>
	public enum EdStudStateChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeStateStatus</c> at EdCodeStateStatusIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeStateStatus))]
		EdCodeStateStatus,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>EntCodeEntityType</c> at EntCodeEntityTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeEntityType))]
		EntCodeEntityType,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion EdStudStateChildEntityTypes
	
	#region EdStudStateFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudStateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudState"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudStateFilterBuilder : SqlFilterBuilder<EdStudStateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudStateFilterBuilder class.
		/// </summary>
		public EdStudStateFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudStateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudStateFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudStateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudStateFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudStateFilterBuilder
	
	#region EdStudStateParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudStateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudState"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudStateParameterBuilder : ParameterizedSqlFilterBuilder<EdStudStateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudStateParameterBuilder class.
		/// </summary>
		public EdStudStateParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudStateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudStateParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudStateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudStateParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudStateParameterBuilder
	
	#region EdStudStateSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudStateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudState"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudStateSortBuilder : SqlSortBuilder<EdStudStateColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudStateSqlSortBuilder class.
		/// </summary>
		public EdStudStateSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudStateSortBuilder
	
} // end namespace
