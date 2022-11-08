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
	/// This class is the base class for any <see cref="MdiStudRecordProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiStudRecordProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiStudRecord, UMIS_VER2.BusinessLyer.MdiStudRecordKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudRecordKey key)
		{
			return Delete(transactionManager, key.MdiStudRecordId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiStudRecordId">سجل متابعة الطبية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiStudRecordId)
		{
			return Delete(null, _mdiStudRecordId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId">سجل متابعة الطبية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiStudRecordId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_ACAD_YEAR key.
		///		FK_MDI_STUD_RECORD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_ACAD_YEAR key.
		///		FK_MDI_STUD_RECORD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudRecord> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_ACAD_YEAR key.
		///		FK_MDI_STUD_RECORD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_ACAD_YEAR key.
		///		fkMdiStudRecordEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_ACAD_YEAR key.
		///		fkMdiStudRecordEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_ACAD_YEAR key.
		///		FK_MDI_STUD_RECORD_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public abstract TList<MdiStudRecord> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_CODE_SEMESTER key.
		///		FK_MDI_STUD_RECORD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_CODE_SEMESTER key.
		///		FK_MDI_STUD_RECORD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudRecord> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_CODE_SEMESTER key.
		///		FK_MDI_STUD_RECORD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_CODE_SEMESTER key.
		///		fkMdiStudRecordEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_CODE_SEMESTER key.
		///		fkMdiStudRecordEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_CODE_SEMESTER key.
		///		FK_MDI_STUD_RECORD_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public abstract TList<MdiStudRecord> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_STUD key.
		///		FK_MDI_STUD_RECORD_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_STUD key.
		///		FK_MDI_STUD_RECORD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudRecord> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_STUD key.
		///		FK_MDI_STUD_RECORD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_STUD key.
		///		fkMdiStudRecordEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_STUD key.
		///		fkMdiStudRecordEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public TList<MdiStudRecord> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_RECORD_ED_STUD key.
		///		FK_MDI_STUD_RECORD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudRecord objects.</returns>
		public abstract TList<MdiStudRecord> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MdiStudRecord Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudRecordKey key, int start, int pageLength)
		{
			return GetByMdiStudRecordId(transactionManager, key.MdiStudRecordId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="_mdiStudRecordId">سجل متابعة الطبية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudRecord GetByMdiStudRecordId(System.Decimal _mdiStudRecordId)
		{
			int count = -1;
			return GetByMdiStudRecordId(null,_mdiStudRecordId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="_mdiStudRecordId">سجل متابعة الطبية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudRecord GetByMdiStudRecordId(System.Decimal _mdiStudRecordId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordId(null, _mdiStudRecordId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId">سجل متابعة الطبية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudRecord GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId)
		{
			int count = -1;
			return GetByMdiStudRecordId(transactionManager, _mdiStudRecordId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId">سجل متابعة الطبية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudRecord GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudRecordId(transactionManager, _mdiStudRecordId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="_mdiStudRecordId">سجل متابعة الطبية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudRecord GetByMdiStudRecordId(System.Decimal _mdiStudRecordId, int start, int pageLength, out int count)
		{
			return GetByMdiStudRecordId(null, _mdiStudRecordId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudRecordId">سجل متابعة الطبية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudRecord GetByMdiStudRecordId(TransactionManager transactionManager, System.Decimal _mdiStudRecordId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rcrdDate">تاريخ السجل الطبى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudRecord GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Decimal? _edCodeSemesterId, System.DateTime? _rcrdDate)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(null,_edAcadYearId, _edStudId, _edCodeSemesterId, _rcrdDate, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rcrdDate">تاريخ السجل الطبى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudRecord GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Decimal? _edCodeSemesterId, System.DateTime? _rcrdDate, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(null, _edAcadYearId, _edStudId, _edCodeSemesterId, _rcrdDate, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rcrdDate">تاريخ السجل الطبى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudRecord GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Decimal? _edCodeSemesterId, System.DateTime? _rcrdDate)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(transactionManager, _edAcadYearId, _edStudId, _edCodeSemesterId, _rcrdDate, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rcrdDate">تاريخ السجل الطبى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudRecord GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Decimal? _edCodeSemesterId, System.DateTime? _rcrdDate, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(transactionManager, _edAcadYearId, _edStudId, _edCodeSemesterId, _rcrdDate, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rcrdDate">تاريخ السجل الطبى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudRecord GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Decimal? _edCodeSemesterId, System.DateTime? _rcrdDate, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(null, _edAcadYearId, _edStudId, _edCodeSemesterId, _rcrdDate, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_RECORD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId">مسلسل الطالب</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="_rcrdDate">تاريخ السجل الطبى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudRecord GetByEdAcadYearIdEdStudIdEdCodeSemesterIdRcrdDate(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Decimal? _edCodeSemesterId, System.DateTime? _rcrdDate, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiStudRecord&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiStudRecord&gt;"/></returns>
		public static TList<MdiStudRecord> Fill(IDataReader reader, TList<MdiStudRecord> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiStudRecord c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiStudRecord")
					.Append("|").Append((System.Decimal)reader["MDI_STUD_RECORD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiStudRecord>(
					key.ToString(), // EntityTrackingKey
					"MdiStudRecord",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiStudRecord();
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
					c.MdiStudRecordId = (System.Decimal)reader["MDI_STUD_RECORD_ID"];
					c.OriginalMdiStudRecordId = c.MdiStudRecordId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.RcrdDate = Convert.IsDBNull(reader["RCRD_DATE"]) ? null : (System.DateTime?)reader["RCRD_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiStudRecord entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiStudRecordId = (System.Decimal)reader[((int)MdiStudRecordColumn.MdiStudRecordId - 1)];
			entity.OriginalMdiStudRecordId = (System.Decimal)reader["MDI_STUD_RECORD_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)MdiStudRecordColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)MdiStudRecordColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)MdiStudRecordColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)MdiStudRecordColumn.EdStudId - 1)];
			entity.Notes = (reader.IsDBNull(((int)MdiStudRecordColumn.Notes - 1)))?null:(System.String)reader[((int)MdiStudRecordColumn.Notes - 1)];
			entity.RcrdDate = (reader.IsDBNull(((int)MdiStudRecordColumn.RcrdDate - 1)))?null:(System.DateTime?)reader[((int)MdiStudRecordColumn.RcrdDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiStudRecord entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiStudRecordId = (System.Decimal)dataRow["MDI_STUD_RECORD_ID"];
			entity.OriginalMdiStudRecordId = (System.Decimal)dataRow["MDI_STUD_RECORD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.RcrdDate = Convert.IsDBNull(dataRow["RCRD_DATE"]) ? null : (System.DateTime?)dataRow["RCRD_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudRecord"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudRecord Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudRecord entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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
				pkItems[0] = (entity.EdCodeSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterId ?? 0.0m));		
				
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

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMdiStudRecordId methods when available
			
			#region MdiStudLifeStyleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudLifeStyle>|MdiStudLifeStyleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudLifeStyleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudLifeStyleCollection = DataRepository.MdiStudLifeStyleProvider.GetByMdiStudRecordId(transactionManager, entity.MdiStudRecordId);

				if (deep && entity.MdiStudLifeStyleCollection.Count > 0)
				{
					deepHandles.Add("MdiStudLifeStyleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudLifeStyle>) DataRepository.MdiStudLifeStyleProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudLifeStyleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudInvstgCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudInvstg>|MdiStudInvstgCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudInvstgCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudInvstgCollection = DataRepository.MdiStudInvstgProvider.GetByMdiStudRecordId(transactionManager, entity.MdiStudRecordId);

				if (deep && entity.MdiStudInvstgCollection.Count > 0)
				{
					deepHandles.Add("MdiStudInvstgCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudInvstg>) DataRepository.MdiStudInvstgProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudInvstgCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudSignCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudSign>|MdiStudSignCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudSignCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudSignCollection = DataRepository.MdiStudSignProvider.GetByMdiStudRecordId(transactionManager, entity.MdiStudRecordId);

				if (deep && entity.MdiStudSignCollection.Count > 0)
				{
					deepHandles.Add("MdiStudSignCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudSign>) DataRepository.MdiStudSignProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudSignCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudFamHstryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudFamHstry>|MdiStudFamHstryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudFamHstryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudFamHstryCollection = DataRepository.MdiStudFamHstryProvider.GetByMdiStudRecordId(transactionManager, entity.MdiStudRecordId);

				if (deep && entity.MdiStudFamHstryCollection.Count > 0)
				{
					deepHandles.Add("MdiStudFamHstryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudFamHstry>) DataRepository.MdiStudFamHstryProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudFamHstryCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiStudRecord object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiStudRecord instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudRecord Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudRecord entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<MdiStudLifeStyle>
				if (CanDeepSave(entity.MdiStudLifeStyleCollection, "List<MdiStudLifeStyle>|MdiStudLifeStyleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudLifeStyle child in entity.MdiStudLifeStyleCollection)
					{
						if(child.MdiStudRecordIdSource != null)
						{
							child.MdiStudRecordId = child.MdiStudRecordIdSource.MdiStudRecordId;
						}
						else
						{
							child.MdiStudRecordId = entity.MdiStudRecordId;
						}

					}

					if (entity.MdiStudLifeStyleCollection.Count > 0 || entity.MdiStudLifeStyleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudLifeStyleProvider.Save(transactionManager, entity.MdiStudLifeStyleCollection);
						
						deepHandles.Add("MdiStudLifeStyleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudLifeStyle >) DataRepository.MdiStudLifeStyleProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudLifeStyleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudInvstg>
				if (CanDeepSave(entity.MdiStudInvstgCollection, "List<MdiStudInvstg>|MdiStudInvstgCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudInvstg child in entity.MdiStudInvstgCollection)
					{
						if(child.MdiStudRecordIdSource != null)
						{
							child.MdiStudRecordId = child.MdiStudRecordIdSource.MdiStudRecordId;
						}
						else
						{
							child.MdiStudRecordId = entity.MdiStudRecordId;
						}

					}

					if (entity.MdiStudInvstgCollection.Count > 0 || entity.MdiStudInvstgCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudInvstgProvider.Save(transactionManager, entity.MdiStudInvstgCollection);
						
						deepHandles.Add("MdiStudInvstgCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudInvstg >) DataRepository.MdiStudInvstgProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudInvstgCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudSign>
				if (CanDeepSave(entity.MdiStudSignCollection, "List<MdiStudSign>|MdiStudSignCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudSign child in entity.MdiStudSignCollection)
					{
						if(child.MdiStudRecordIdSource != null)
						{
							child.MdiStudRecordId = child.MdiStudRecordIdSource.MdiStudRecordId;
						}
						else
						{
							child.MdiStudRecordId = entity.MdiStudRecordId;
						}

					}

					if (entity.MdiStudSignCollection.Count > 0 || entity.MdiStudSignCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudSignProvider.Save(transactionManager, entity.MdiStudSignCollection);
						
						deepHandles.Add("MdiStudSignCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudSign >) DataRepository.MdiStudSignProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudSignCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudFamHstry>
				if (CanDeepSave(entity.MdiStudFamHstryCollection, "List<MdiStudFamHstry>|MdiStudFamHstryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudFamHstry child in entity.MdiStudFamHstryCollection)
					{
						if(child.MdiStudRecordIdSource != null)
						{
							child.MdiStudRecordId = child.MdiStudRecordIdSource.MdiStudRecordId;
						}
						else
						{
							child.MdiStudRecordId = entity.MdiStudRecordId;
						}

					}

					if (entity.MdiStudFamHstryCollection.Count > 0 || entity.MdiStudFamHstryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudFamHstryProvider.Save(transactionManager, entity.MdiStudFamHstryCollection);
						
						deepHandles.Add("MdiStudFamHstryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudFamHstry >) DataRepository.MdiStudFamHstryProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudFamHstryCollection, deepSaveType, childTypes, innerList }
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
	
	#region MdiStudRecordChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiStudRecord</c>
	///</summary>
	public enum MdiStudRecordChildEntityTypes
	{
		
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
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		///<summary>
		/// Collection of <c>MdiStudRecord</c> as OneToMany for MdiStudLifeStyleCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudLifeStyle>))]
		MdiStudLifeStyleCollection,
		///<summary>
		/// Collection of <c>MdiStudRecord</c> as OneToMany for MdiStudInvstgCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudInvstg>))]
		MdiStudInvstgCollection,
		///<summary>
		/// Collection of <c>MdiStudRecord</c> as OneToMany for MdiStudSignCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudSign>))]
		MdiStudSignCollection,
		///<summary>
		/// Collection of <c>MdiStudRecord</c> as OneToMany for MdiStudFamHstryCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudFamHstry>))]
		MdiStudFamHstryCollection,
	}
	
	#endregion MdiStudRecordChildEntityTypes
	
	#region MdiStudRecordFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiStudRecordColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudRecord"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudRecordFilterBuilder : SqlFilterBuilder<MdiStudRecordColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudRecordFilterBuilder class.
		/// </summary>
		public MdiStudRecordFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudRecordFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudRecordFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudRecordFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudRecordFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudRecordFilterBuilder
	
	#region MdiStudRecordParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiStudRecordColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudRecord"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudRecordParameterBuilder : ParameterizedSqlFilterBuilder<MdiStudRecordColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudRecordParameterBuilder class.
		/// </summary>
		public MdiStudRecordParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudRecordParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudRecordParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudRecordParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudRecordParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudRecordParameterBuilder
	
	#region MdiStudRecordSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiStudRecordColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudRecord"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiStudRecordSortBuilder : SqlSortBuilder<MdiStudRecordColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudRecordSqlSortBuilder class.
		/// </summary>
		public MdiStudRecordSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiStudRecordSortBuilder
	
} // end namespace
