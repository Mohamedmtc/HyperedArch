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
	/// This class is the base class for any <see cref="ScSchdlPeriodProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScSchdlPeriodProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScSchdlPeriod, UMIS_VER2.BusinessLyer.ScSchdlPeriodKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlPeriodKey key)
		{
			return Delete(transactionManager, key.ScSchdlPeriodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scSchdlPeriodId">فترات الجدول. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scSchdlPeriodId)
		{
			return Delete(null, _scSchdlPeriodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scSchdlPeriodId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_AS_FACULTY_INFO key.
		///		FK_SC_SCHDL_PERIOD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId">مسلسل الكلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_AS_FACULTY_INFO key.
		///		FK_SC_SCHDL_PERIOD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">مسلسل الكلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlPeriod> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_AS_FACULTY_INFO key.
		///		FK_SC_SCHDL_PERIOD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">مسلسل الكلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_AS_FACULTY_INFO key.
		///		fkScSchdlPeriodAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">مسلسل الكلية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_AS_FACULTY_INFO key.
		///		fkScSchdlPeriodAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId">مسلسل الكلية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_AS_FACULTY_INFO key.
		///		FK_SC_SCHDL_PERIOD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">مسلسل الكلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public abstract TList<ScSchdlPeriod> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_ACAD_YEAR key.
		///		FK_SC_SCHDL_PERIOD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">مسلسل العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_ACAD_YEAR key.
		///		FK_SC_SCHDL_PERIOD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">مسلسل العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlPeriod> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_ACAD_YEAR key.
		///		FK_SC_SCHDL_PERIOD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">مسلسل العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_ACAD_YEAR key.
		///		fkScSchdlPeriodEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">مسلسل العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_ACAD_YEAR key.
		///		fkScSchdlPeriodEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">مسلسل العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_ACAD_YEAR key.
		///		FK_SC_SCHDL_PERIOD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">مسلسل العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public abstract TList<ScSchdlPeriod> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_CODE_SEMESTER key.
		///		FK_SC_SCHDL_PERIOD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_CODE_SEMESTER key.
		///		FK_SC_SCHDL_PERIOD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlPeriod> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_CODE_SEMESTER key.
		///		FK_SC_SCHDL_PERIOD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_CODE_SEMESTER key.
		///		fkScSchdlPeriodEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_CODE_SEMESTER key.
		///		fkScSchdlPeriodEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ED_CODE_SEMESTER key.
		///		FK_SC_SCHDL_PERIOD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public abstract TList<ScSchdlPeriod> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ENTITY_MAIN key.
		///		FK_SC_SCHDL_PERIOD_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainMjrId">ألماجور</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEntMainMjrId(System.Decimal? _entMainMjrId)
		{
			int count = -1;
			return GetByEntMainMjrId(_entMainMjrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ENTITY_MAIN key.
		///		FK_SC_SCHDL_PERIOD_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMjrId">ألماجور</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlPeriod> GetByEntMainMjrId(TransactionManager transactionManager, System.Decimal? _entMainMjrId)
		{
			int count = -1;
			return GetByEntMainMjrId(transactionManager, _entMainMjrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ENTITY_MAIN key.
		///		FK_SC_SCHDL_PERIOD_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMjrId">ألماجور</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEntMainMjrId(TransactionManager transactionManager, System.Decimal? _entMainMjrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainMjrId(transactionManager, _entMainMjrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ENTITY_MAIN key.
		///		fkScSchdlPeriodEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMjrId">ألماجور</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEntMainMjrId(System.Decimal? _entMainMjrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainMjrId(null, _entMainMjrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ENTITY_MAIN key.
		///		fkScSchdlPeriodEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainMjrId">ألماجور</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public TList<ScSchdlPeriod> GetByEntMainMjrId(System.Decimal? _entMainMjrId, int start, int pageLength,out int count)
		{
			return GetByEntMainMjrId(null, _entMainMjrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_PERIOD_ENTITY_MAIN key.
		///		FK_SC_SCHDL_PERIOD_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainMjrId">ألماجور</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlPeriod objects.</returns>
		public abstract TList<ScSchdlPeriod> GetByEntMainMjrId(TransactionManager transactionManager, System.Decimal? _entMainMjrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScSchdlPeriod Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlPeriodKey key, int start, int pageLength)
		{
			return GetByScSchdlPeriodId(transactionManager, key.ScSchdlPeriodId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHDL_PERIOD index.
		/// </summary>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlPeriod GetByScSchdlPeriodId(System.Decimal _scSchdlPeriodId)
		{
			int count = -1;
			return GetByScSchdlPeriodId(null,_scSchdlPeriodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_PERIOD index.
		/// </summary>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlPeriod GetByScSchdlPeriodId(System.Decimal _scSchdlPeriodId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlPeriodId(null, _scSchdlPeriodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_PERIOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlPeriod GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal _scSchdlPeriodId)
		{
			int count = -1;
			return GetByScSchdlPeriodId(transactionManager, _scSchdlPeriodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_PERIOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlPeriod GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal _scSchdlPeriodId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlPeriodId(transactionManager, _scSchdlPeriodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_PERIOD index.
		/// </summary>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlPeriod GetByScSchdlPeriodId(System.Decimal _scSchdlPeriodId, int start, int pageLength, out int count)
		{
			return GetByScSchdlPeriodId(null, _scSchdlPeriodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_PERIOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId">فترات الجدول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScSchdlPeriod GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal _scSchdlPeriodId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScSchdlPeriod&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScSchdlPeriod&gt;"/></returns>
		public static TList<ScSchdlPeriod> Fill(IDataReader reader, TList<ScSchdlPeriod> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScSchdlPeriod c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScSchdlPeriod")
					.Append("|").Append((System.Decimal)reader["SC_SCHDL_PERIOD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScSchdlPeriod>(
					key.ToString(), // EntityTrackingKey
					"ScSchdlPeriod",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScSchdlPeriod();
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
					c.ScSchdlPeriodId = (System.Decimal)reader["SC_SCHDL_PERIOD_ID"];
					c.OriginalScSchdlPeriodId = c.ScSchdlPeriodId;
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.SchdlPeriodAr = Convert.IsDBNull(reader["SCHDL_PERIOD_AR"]) ? null : (System.String)reader["SCHDL_PERIOD_AR"];
					c.SchdlPeriodEn = Convert.IsDBNull(reader["SCHDL_PERIOD_EN"]) ? null : (System.String)reader["SCHDL_PERIOD_EN"];
					c.PeriodFrom = Convert.IsDBNull(reader["PERIOD_FROM"]) ? null : (System.DateTime?)reader["PERIOD_FROM"];
					c.PeriodTo = Convert.IsDBNull(reader["PERIOD_TO"]) ? null : (System.DateTime?)reader["PERIOD_TO"];
					c.EntMainMjrId = Convert.IsDBNull(reader["ENT_MAIN_MJR_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_MJR_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScSchdlPeriod entity)
		{
			if (!reader.Read()) return;
			
			entity.ScSchdlPeriodId = (System.Decimal)reader[((int)ScSchdlPeriodColumn.ScSchdlPeriodId - 1)];
			entity.OriginalScSchdlPeriodId = (System.Decimal)reader["SC_SCHDL_PERIOD_ID"];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)ScSchdlPeriodColumn.AsFacultyInfoId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)ScSchdlPeriodColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)ScSchdlPeriodColumn.EdCodeSemesterId - 1)];
			entity.SchdlPeriodAr = (reader.IsDBNull(((int)ScSchdlPeriodColumn.SchdlPeriodAr - 1)))?null:(System.String)reader[((int)ScSchdlPeriodColumn.SchdlPeriodAr - 1)];
			entity.SchdlPeriodEn = (reader.IsDBNull(((int)ScSchdlPeriodColumn.SchdlPeriodEn - 1)))?null:(System.String)reader[((int)ScSchdlPeriodColumn.SchdlPeriodEn - 1)];
			entity.PeriodFrom = (reader.IsDBNull(((int)ScSchdlPeriodColumn.PeriodFrom - 1)))?null:(System.DateTime?)reader[((int)ScSchdlPeriodColumn.PeriodFrom - 1)];
			entity.PeriodTo = (reader.IsDBNull(((int)ScSchdlPeriodColumn.PeriodTo - 1)))?null:(System.DateTime?)reader[((int)ScSchdlPeriodColumn.PeriodTo - 1)];
			entity.EntMainMjrId = (reader.IsDBNull(((int)ScSchdlPeriodColumn.EntMainMjrId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlPeriodColumn.EntMainMjrId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)ScSchdlPeriodColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)ScSchdlPeriodColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)ScSchdlPeriodColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlPeriodColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScSchdlPeriod entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScSchdlPeriodId = (System.Decimal)dataRow["SC_SCHDL_PERIOD_ID"];
			entity.OriginalScSchdlPeriodId = (System.Decimal)dataRow["SC_SCHDL_PERIOD_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.SchdlPeriodAr = Convert.IsDBNull(dataRow["SCHDL_PERIOD_AR"]) ? null : (System.String)dataRow["SCHDL_PERIOD_AR"];
			entity.SchdlPeriodEn = Convert.IsDBNull(dataRow["SCHDL_PERIOD_EN"]) ? null : (System.String)dataRow["SCHDL_PERIOD_EN"];
			entity.PeriodFrom = Convert.IsDBNull(dataRow["PERIOD_FROM"]) ? null : (System.DateTime?)dataRow["PERIOD_FROM"];
			entity.PeriodTo = Convert.IsDBNull(dataRow["PERIOD_TO"]) ? null : (System.DateTime?)dataRow["PERIOD_TO"];
			entity.EntMainMjrId = Convert.IsDBNull(dataRow["ENT_MAIN_MJR_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_MJR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlPeriod"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSchdlPeriod Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlPeriod entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EntMainMjrIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainMjrIdSource", deepLoadType, innerList) 
				&& entity.EntMainMjrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainMjrId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainMjrIdSource = tmpEntity;
				else
					entity.EntMainMjrIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainMjrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainMjrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainMjrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainMjrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainMjrIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScSchdlPeriodId methods when available
			
			#region ScTchngSlotCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScTchngSlot>|ScTchngSlotCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngSlotCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScTchngSlotCollection = DataRepository.ScTchngSlotProvider.GetByScSchdlPeriodId(transactionManager, entity.ScSchdlPeriodId);

				if (deep && entity.ScTchngSlotCollection.Count > 0)
				{
					deepHandles.Add("ScTchngSlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScTchngSlot>) DataRepository.ScTchngSlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScTchngSlotCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScTchngDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScTchngDay>|ScTchngDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScTchngDayCollection = DataRepository.ScTchngDayProvider.GetByScSchdlPeriodId(transactionManager, entity.ScSchdlPeriodId);

				if (deep && entity.ScTchngDayCollection.Count > 0)
				{
					deepHandles.Add("ScTchngDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScTchngDay>) DataRepository.ScTchngDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScTchngDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlHdr>|ScSchdlHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlHdrCollection = DataRepository.ScSchdlHdrProvider.GetByScSchdlPeriodId(transactionManager, entity.ScSchdlPeriodId);

				if (deep && entity.ScSchdlHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlHdr>) DataRepository.ScSchdlHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlHdrCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScSchdlPeriod object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScSchdlPeriod instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSchdlPeriod Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlPeriod entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region EntMainMjrIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainMjrIdSource", deepSaveType, innerList) 
				&& entity.EntMainMjrIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainMjrIdSource);
				entity.EntMainMjrId = entity.EntMainMjrIdSource.EntMainId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScTchngSlot>
				if (CanDeepSave(entity.ScTchngSlotCollection, "List<ScTchngSlot>|ScTchngSlotCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScTchngSlot child in entity.ScTchngSlotCollection)
					{
						if(child.ScSchdlPeriodIdSource != null)
						{
							child.ScSchdlPeriodId = child.ScSchdlPeriodIdSource.ScSchdlPeriodId;
						}
						else
						{
							child.ScSchdlPeriodId = entity.ScSchdlPeriodId;
						}

					}

					if (entity.ScTchngSlotCollection.Count > 0 || entity.ScTchngSlotCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScTchngSlotProvider.Save(transactionManager, entity.ScTchngSlotCollection);
						
						deepHandles.Add("ScTchngSlotCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScTchngSlot >) DataRepository.ScTchngSlotProvider.DeepSave,
							new object[] { transactionManager, entity.ScTchngSlotCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScTchngDay>
				if (CanDeepSave(entity.ScTchngDayCollection, "List<ScTchngDay>|ScTchngDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScTchngDay child in entity.ScTchngDayCollection)
					{
						if(child.ScSchdlPeriodIdSource != null)
						{
							child.ScSchdlPeriodId = child.ScSchdlPeriodIdSource.ScSchdlPeriodId;
						}
						else
						{
							child.ScSchdlPeriodId = entity.ScSchdlPeriodId;
						}

					}

					if (entity.ScTchngDayCollection.Count > 0 || entity.ScTchngDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScTchngDayProvider.Save(transactionManager, entity.ScTchngDayCollection);
						
						deepHandles.Add("ScTchngDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScTchngDay >) DataRepository.ScTchngDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScTchngDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSchdlHdr>
				if (CanDeepSave(entity.ScSchdlHdrCollection, "List<ScSchdlHdr>|ScSchdlHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlHdr child in entity.ScSchdlHdrCollection)
					{
						if(child.ScSchdlPeriodIdSource != null)
						{
							child.ScSchdlPeriodId = child.ScSchdlPeriodIdSource.ScSchdlPeriodId;
						}
						else
						{
							child.ScSchdlPeriodId = entity.ScSchdlPeriodId;
						}

					}

					if (entity.ScSchdlHdrCollection.Count > 0 || entity.ScSchdlHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlHdrProvider.Save(transactionManager, entity.ScSchdlHdrCollection);
						
						deepHandles.Add("ScSchdlHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlHdr >) DataRepository.ScSchdlHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlHdrCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScSchdlPeriodChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScSchdlPeriod</c>
	///</summary>
	public enum ScSchdlPeriodChildEntityTypes
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
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainMjrIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>ScSchdlPeriod</c> as OneToMany for ScTchngSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScTchngSlot>))]
		ScTchngSlotCollection,
		///<summary>
		/// Collection of <c>ScSchdlPeriod</c> as OneToMany for ScTchngDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScTchngDay>))]
		ScTchngDayCollection,
		///<summary>
		/// Collection of <c>ScSchdlPeriod</c> as OneToMany for ScSchdlHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlHdr>))]
		ScSchdlHdrCollection,
	}
	
	#endregion ScSchdlPeriodChildEntityTypes
	
	#region ScSchdlPeriodFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScSchdlPeriodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlPeriod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSchdlPeriodFilterBuilder : SqlFilterBuilder<ScSchdlPeriodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlPeriodFilterBuilder class.
		/// </summary>
		public ScSchdlPeriodFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlPeriodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSchdlPeriodFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlPeriodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSchdlPeriodFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSchdlPeriodFilterBuilder
	
	#region ScSchdlPeriodParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScSchdlPeriodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlPeriod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSchdlPeriodParameterBuilder : ParameterizedSqlFilterBuilder<ScSchdlPeriodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlPeriodParameterBuilder class.
		/// </summary>
		public ScSchdlPeriodParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlPeriodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSchdlPeriodParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlPeriodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSchdlPeriodParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSchdlPeriodParameterBuilder
	
	#region ScSchdlPeriodSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScSchdlPeriodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlPeriod"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScSchdlPeriodSortBuilder : SqlSortBuilder<ScSchdlPeriodColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlPeriodSqlSortBuilder class.
		/// </summary>
		public ScSchdlPeriodSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScSchdlPeriodSortBuilder
	
} // end namespace
