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
	/// This class is the base class for any <see cref="EdStudSemesterExtProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudSemesterExtProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudSemesterExt, UMIS_VER2.BusinessLyer.EdStudSemesterExtKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterExtKey key)
		{
			return Delete(transactionManager, key.EdStudSemesterExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudSemesterExtId">بيانات اضافية للسجل الدراسي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudSemesterExtId)
		{
			return Delete(null, _edStudSemesterExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterExtId">بيانات اضافية للسجل الدراسي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudSemesterExtId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeGradingId">تقدير الفصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(_edCodeGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">تقدير الفصل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterExt> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">تقدير الفصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING key.
		///		fkEdStudSemesterExtEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId">تقدير الفصل</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING key.
		///		fkEdStudSemesterExtEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId">تقدير الفصل</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">تقدير الفصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public abstract TList<EdStudSemesterExt> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="_edCodeAccumGradingId">تقدير التراكمى
		/// 		/// تقدير للفرقة الدراسية (الفصل الأول + الفصل الثاني)</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeAccumGradingId(System.Decimal? _edCodeAccumGradingId)
		{
			int count = -1;
			return GetByEdCodeAccumGradingId(_edCodeAccumGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeAccumGradingId">تقدير التراكمى
		/// 		/// تقدير للفرقة الدراسية (الفصل الأول + الفصل الثاني)</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterExt> GetByEdCodeAccumGradingId(TransactionManager transactionManager, System.Decimal? _edCodeAccumGradingId)
		{
			int count = -1;
			return GetByEdCodeAccumGradingId(transactionManager, _edCodeAccumGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeAccumGradingId">تقدير التراكمى
		/// 		/// تقدير للفرقة الدراسية (الفصل الأول + الفصل الثاني)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeAccumGradingId(TransactionManager transactionManager, System.Decimal? _edCodeAccumGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeAccumGradingId(transactionManager, _edCodeAccumGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING1 key.
		///		fkEdStudSemesterExtEdCodeGrading1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeAccumGradingId">تقدير التراكمى
		/// 		/// تقدير للفرقة الدراسية (الفصل الأول + الفصل الثاني)</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeAccumGradingId(System.Decimal? _edCodeAccumGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeAccumGradingId(null, _edCodeAccumGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING1 key.
		///		fkEdStudSemesterExtEdCodeGrading1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeAccumGradingId">تقدير التراكمى
		/// 		/// تقدير للفرقة الدراسية (الفصل الأول + الفصل الثاني)</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeAccumGradingId(System.Decimal? _edCodeAccumGradingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeAccumGradingId(null, _edCodeAccumGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeAccumGradingId">تقدير التراكمى
		/// 		/// تقدير للفرقة الدراسية (الفصل الأول + الفصل الثاني)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public abstract TList<EdStudSemesterExt> GetByEdCodeAccumGradingId(TransactionManager transactionManager, System.Decimal? _edCodeAccumGradingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_STUD_CASE key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_STUD_CASE Description: 
		/// </summary>
		/// <param name="_edCodeStudCaseId">مستجد- باقى للاعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeStudCaseId(System.Decimal? _edCodeStudCaseId)
		{
			int count = -1;
			return GetByEdCodeStudCaseId(_edCodeStudCaseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_STUD_CASE key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_STUD_CASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudCaseId">مستجد- باقى للاعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterExt> GetByEdCodeStudCaseId(TransactionManager transactionManager, System.Decimal? _edCodeStudCaseId)
		{
			int count = -1;
			return GetByEdCodeStudCaseId(transactionManager, _edCodeStudCaseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_STUD_CASE key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_STUD_CASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudCaseId">مستجد- باقى للاعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeStudCaseId(TransactionManager transactionManager, System.Decimal? _edCodeStudCaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudCaseId(transactionManager, _edCodeStudCaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_STUD_CASE key.
		///		fkEdStudSemesterExtEdCodeStudCase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudCaseId">مستجد- باقى للاعادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeStudCaseId(System.Decimal? _edCodeStudCaseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeStudCaseId(null, _edCodeStudCaseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_STUD_CASE key.
		///		fkEdStudSemesterExtEdCodeStudCase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStudCaseId">مستجد- باقى للاعادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdCodeStudCaseId(System.Decimal? _edCodeStudCaseId, int start, int pageLength,out int count)
		{
			return GetByEdCodeStudCaseId(null, _edCodeStudCaseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_CODE_STUD_CASE key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_CODE_STUD_CASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudCaseId">مستجد- باقى للاعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public abstract TList<EdStudSemesterExt> GetByEdCodeStudCaseId(TransactionManager transactionManager, System.Decimal? _edCodeStudCaseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterExt> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_STUD_SEMESTER key.
		///		fkEdStudSemesterExtEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_STUD_SEMESTER key.
		///		fkEdStudSemesterExtEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_SEMESTER_EXT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public abstract TList<EdStudSemesterExt> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ENT_MAJOR_PHASE key.
		///		FK_ED_STUD_SEMESTER_EXT_ENT_MAJOR_PHASE Description: 
		/// </summary>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEntMajorPhaseId(System.Decimal? _entMajorPhaseId)
		{
			int count = -1;
			return GetByEntMajorPhaseId(_entMajorPhaseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ENT_MAJOR_PHASE key.
		///		FK_ED_STUD_SEMESTER_EXT_ENT_MAJOR_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudSemesterExt> GetByEntMajorPhaseId(TransactionManager transactionManager, System.Decimal? _entMajorPhaseId)
		{
			int count = -1;
			return GetByEntMajorPhaseId(transactionManager, _entMajorPhaseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ENT_MAJOR_PHASE key.
		///		FK_ED_STUD_SEMESTER_EXT_ENT_MAJOR_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEntMajorPhaseId(TransactionManager transactionManager, System.Decimal? _entMajorPhaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMajorPhaseId(transactionManager, _entMajorPhaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ENT_MAJOR_PHASE key.
		///		fkEdStudSemesterExtEntMajorPhase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEntMajorPhaseId(System.Decimal? _entMajorPhaseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMajorPhaseId(null, _entMajorPhaseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ENT_MAJOR_PHASE key.
		///		fkEdStudSemesterExtEntMajorPhase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public TList<EdStudSemesterExt> GetByEntMajorPhaseId(System.Decimal? _entMajorPhaseId, int start, int pageLength,out int count)
		{
			return GetByEntMajorPhaseId(null, _entMajorPhaseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_SEMESTER_EXT_ENT_MAJOR_PHASE key.
		///		FK_ED_STUD_SEMESTER_EXT_ENT_MAJOR_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudSemesterExt objects.</returns>
		public abstract TList<EdStudSemesterExt> GetByEntMajorPhaseId(TransactionManager transactionManager, System.Decimal? _entMajorPhaseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudSemesterExt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterExtKey key, int start, int pageLength)
		{
			return GetByEdStudSemesterExtId(transactionManager, key.EdStudSemesterExtId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_SEMESTER_EXT index.
		/// </summary>
		/// <param name="_edStudSemesterExtId">بيانات اضافية للسجل الدراسي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterExt GetByEdStudSemesterExtId(System.Decimal _edStudSemesterExtId)
		{
			int count = -1;
			return GetByEdStudSemesterExtId(null,_edStudSemesterExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_EXT index.
		/// </summary>
		/// <param name="_edStudSemesterExtId">بيانات اضافية للسجل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterExt GetByEdStudSemesterExtId(System.Decimal _edStudSemesterExtId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterExtId(null, _edStudSemesterExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterExtId">بيانات اضافية للسجل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterExt GetByEdStudSemesterExtId(TransactionManager transactionManager, System.Decimal _edStudSemesterExtId)
		{
			int count = -1;
			return GetByEdStudSemesterExtId(transactionManager, _edStudSemesterExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterExtId">بيانات اضافية للسجل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterExt GetByEdStudSemesterExtId(TransactionManager transactionManager, System.Decimal _edStudSemesterExtId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterExtId(transactionManager, _edStudSemesterExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_EXT index.
		/// </summary>
		/// <param name="_edStudSemesterExtId">بيانات اضافية للسجل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudSemesterExt GetByEdStudSemesterExtId(System.Decimal _edStudSemesterExtId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterExtId(null, _edStudSemesterExtId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_SEMESTER_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterExtId">بيانات اضافية للسجل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudSemesterExt GetByEdStudSemesterExtId(TransactionManager transactionManager, System.Decimal _edStudSemesterExtId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudSemesterExt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudSemesterExt&gt;"/></returns>
		public static TList<EdStudSemesterExt> Fill(IDataReader reader, TList<EdStudSemesterExt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudSemesterExt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudSemesterExt")
					.Append("|").Append((System.Decimal)reader["ED_STUD_SEMESTER_EXT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudSemesterExt>(
					key.ToString(), // EntityTrackingKey
					"EdStudSemesterExt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudSemesterExt();
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
					c.EdStudSemesterExtId = (System.Decimal)reader["ED_STUD_SEMESTER_EXT_ID"];
					c.OriginalEdStudSemesterExtId = c.EdStudSemesterExtId;
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.EdCodeStudCaseId = Convert.IsDBNull(reader["ED_CODE_STUD_CASE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_STUD_CASE_ID"];
					c.EntMajorPhaseId = Convert.IsDBNull(reader["ENT_MAJOR_PHASE_ID"]) ? null : (System.Decimal?)reader["ENT_MAJOR_PHASE_ID"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.EdCodeAccumGradingId = Convert.IsDBNull(reader["ED_CODE_ACCUM_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_ACCUM_GRADING_ID"];
					c.SemMark = Convert.IsDBNull(reader["SEM_MARK"]) ? null : (System.Decimal?)reader["SEM_MARK"];
					c.AccumMark = Convert.IsDBNull(reader["ACCUM_MARK"]) ? null : (System.Decimal?)reader["ACCUM_MARK"];
					c.AccumPercent = Convert.IsDBNull(reader["ACCUM_PERCENT"]) ? null : (System.Decimal?)reader["ACCUM_PERCENT"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = (System.DateTime)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudSemesterExt entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudSemesterExtId = (System.Decimal)reader[((int)EdStudSemesterExtColumn.EdStudSemesterExtId - 1)];
			entity.OriginalEdStudSemesterExtId = (System.Decimal)reader["ED_STUD_SEMESTER_EXT_ID"];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudSemesterExtColumn.EdStudSemesterId - 1)];
			entity.EdCodeStudCaseId = (reader.IsDBNull(((int)EdStudSemesterExtColumn.EdCodeStudCaseId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterExtColumn.EdCodeStudCaseId - 1)];
			entity.EntMajorPhaseId = (reader.IsDBNull(((int)EdStudSemesterExtColumn.EntMajorPhaseId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterExtColumn.EntMajorPhaseId - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)EdStudSemesterExtColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterExtColumn.EdCodeGradingId - 1)];
			entity.EdCodeAccumGradingId = (reader.IsDBNull(((int)EdStudSemesterExtColumn.EdCodeAccumGradingId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterExtColumn.EdCodeAccumGradingId - 1)];
			entity.SemMark = (reader.IsDBNull(((int)EdStudSemesterExtColumn.SemMark - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterExtColumn.SemMark - 1)];
			entity.AccumMark = (reader.IsDBNull(((int)EdStudSemesterExtColumn.AccumMark - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterExtColumn.AccumMark - 1)];
			entity.AccumPercent = (reader.IsDBNull(((int)EdStudSemesterExtColumn.AccumPercent - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterExtColumn.AccumPercent - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStudSemesterExtColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterExtColumn.SeFormId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudSemesterExtColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudSemesterExtColumn.SeUserId - 1)];
			entity.LastDate = (System.DateTime)reader[((int)EdStudSemesterExtColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudSemesterExt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudSemesterExtId = (System.Decimal)dataRow["ED_STUD_SEMESTER_EXT_ID"];
			entity.OriginalEdStudSemesterExtId = (System.Decimal)dataRow["ED_STUD_SEMESTER_EXT_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EdCodeStudCaseId = Convert.IsDBNull(dataRow["ED_CODE_STUD_CASE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_STUD_CASE_ID"];
			entity.EntMajorPhaseId = Convert.IsDBNull(dataRow["ENT_MAJOR_PHASE_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAJOR_PHASE_ID"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.EdCodeAccumGradingId = Convert.IsDBNull(dataRow["ED_CODE_ACCUM_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_ACCUM_GRADING_ID"];
			entity.SemMark = Convert.IsDBNull(dataRow["SEM_MARK"]) ? null : (System.Decimal?)dataRow["SEM_MARK"];
			entity.AccumMark = Convert.IsDBNull(dataRow["ACCUM_MARK"]) ? null : (System.Decimal?)dataRow["ACCUM_MARK"];
			entity.AccumPercent = Convert.IsDBNull(dataRow["ACCUM_PERCENT"]) ? null : (System.Decimal?)dataRow["ACCUM_PERCENT"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = (System.DateTime)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudSemesterExt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudSemesterExt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterExt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdCodeAccumGradingIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeAccumGradingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeAccumGradingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeAccumGradingId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeAccumGradingIdSource = tmpEntity;
				else
					entity.EdCodeAccumGradingIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.EdCodeAccumGradingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeAccumGradingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeAccumGradingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.EdCodeAccumGradingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeAccumGradingIdSource

			#region EdCodeStudCaseIdSource	
			if (CanDeepLoad(entity, "EdCodeStudCase|EdCodeStudCaseIdSource", deepLoadType, innerList) 
				&& entity.EdCodeStudCaseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeStudCaseId ?? 0.0m);
				EdCodeStudCase tmpEntity = EntityManager.LocateEntity<EdCodeStudCase>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeStudCase), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeStudCaseIdSource = tmpEntity;
				else
					entity.EdCodeStudCaseIdSource = DataRepository.EdCodeStudCaseProvider.GetByEdCodeStudCaseId(transactionManager, (entity.EdCodeStudCaseId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeStudCaseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeStudCaseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeStudCaseProvider.DeepLoad(transactionManager, entity.EdCodeStudCaseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeStudCaseIdSource

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

			#region EntMajorPhaseIdSource	
			if (CanDeepLoad(entity, "EntMajorPhase|EntMajorPhaseIdSource", deepLoadType, innerList) 
				&& entity.EntMajorPhaseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMajorPhaseId ?? 0.0m);
				EntMajorPhase tmpEntity = EntityManager.LocateEntity<EntMajorPhase>(EntityLocator.ConstructKeyFromPkItems(typeof(EntMajorPhase), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMajorPhaseIdSource = tmpEntity;
				else
					entity.EntMajorPhaseIdSource = DataRepository.EntMajorPhaseProvider.GetByEntMajorPhaseId(transactionManager, (entity.EntMajorPhaseId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMajorPhaseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMajorPhaseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntMajorPhaseProvider.DeepLoad(transactionManager, entity.EntMajorPhaseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMajorPhaseIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudSemesterExt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudSemesterExt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudSemesterExt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudSemesterExt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingIdSource);
				entity.EdCodeGradingId = entity.EdCodeGradingIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EdCodeAccumGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeAccumGradingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeAccumGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeAccumGradingIdSource);
				entity.EdCodeAccumGradingId = entity.EdCodeAccumGradingIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EdCodeStudCaseIdSource
			if (CanDeepSave(entity, "EdCodeStudCase|EdCodeStudCaseIdSource", deepSaveType, innerList) 
				&& entity.EdCodeStudCaseIdSource != null)
			{
				DataRepository.EdCodeStudCaseProvider.Save(transactionManager, entity.EdCodeStudCaseIdSource);
				entity.EdCodeStudCaseId = entity.EdCodeStudCaseIdSource.EdCodeStudCaseId;
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
			
			#region EntMajorPhaseIdSource
			if (CanDeepSave(entity, "EntMajorPhase|EntMajorPhaseIdSource", deepSaveType, innerList) 
				&& entity.EntMajorPhaseIdSource != null)
			{
				DataRepository.EntMajorPhaseProvider.Save(transactionManager, entity.EntMajorPhaseIdSource);
				entity.EntMajorPhaseId = entity.EntMajorPhaseIdSource.EntMajorPhaseId;
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
	
	#region EdStudSemesterExtChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudSemesterExt</c>
	///</summary>
	public enum EdStudSemesterExtChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdCodeStudCase</c> at EdCodeStudCaseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeStudCase))]
		EdCodeStudCase,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>EntMajorPhase</c> at EntMajorPhaseIdSource
		///</summary>
		[ChildEntityType(typeof(EntMajorPhase))]
		EntMajorPhase,
	}
	
	#endregion EdStudSemesterExtChildEntityTypes
	
	#region EdStudSemesterExtFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudSemesterExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemesterExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudSemesterExtFilterBuilder : SqlFilterBuilder<EdStudSemesterExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterExtFilterBuilder class.
		/// </summary>
		public EdStudSemesterExtFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudSemesterExtFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudSemesterExtFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudSemesterExtFilterBuilder
	
	#region EdStudSemesterExtParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudSemesterExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemesterExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudSemesterExtParameterBuilder : ParameterizedSqlFilterBuilder<EdStudSemesterExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterExtParameterBuilder class.
		/// </summary>
		public EdStudSemesterExtParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudSemesterExtParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudSemesterExtParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudSemesterExtParameterBuilder
	
	#region EdStudSemesterExtSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudSemesterExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudSemesterExt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudSemesterExtSortBuilder : SqlSortBuilder<EdStudSemesterExtColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudSemesterExtSqlSortBuilder class.
		/// </summary>
		public EdStudSemesterExtSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudSemesterExtSortBuilder
	
} // end namespace
