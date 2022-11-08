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
	/// This class is the base class for any <see cref="AccomStudAbsenceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudAbsenceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudAbsence, UMIS_VER2.BusinessLyer.AccomStudAbsenceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudAbsenceKey key)
		{
			return Delete(transactionManager, key.AccomStudAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudAbsenceId">غياب الطلاب عن السكن. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudAbsenceId)
		{
			return Delete(null, _accomStudAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudAbsenceId">غياب الطلاب عن السكن. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudAbsenceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_ABSENCE_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByAccomStudBookId(System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(_accomStudBookId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_ABSENCE_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudAbsence> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_ABSENCE_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ACCOM_STUD_BOOK key.
		///		fkAccomStudAbsenceAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ACCOM_STUD_BOOK key.
		///		fkAccomStudAbsenceAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength,out int count)
		{
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_ABSENCE_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public abstract TList<AccomStudAbsence> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_ABSENCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_ABSENCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudAbsence> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_ABSENCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_ACAD_YEAR key.
		///		fkAccomStudAbsenceEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_ACAD_YEAR key.
		///		fkAccomStudAbsenceEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_ABSENCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public abstract TList<AccomStudAbsence> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_ABSENCE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_ABSENCE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudAbsence> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_ABSENCE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_CODE_SEMESTER key.
		///		fkAccomStudAbsenceEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_CODE_SEMESTER key.
		///		fkAccomStudAbsenceEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_ABSENCE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public abstract TList<AccomStudAbsence> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_STUD key.
		///		FK_ACCOM_STUD_ABSENCE_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_STUD key.
		///		FK_ACCOM_STUD_ABSENCE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudAbsence> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_STUD key.
		///		FK_ACCOM_STUD_ABSENCE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_STUD key.
		///		fkAccomStudAbsenceEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_STUD key.
		///		fkAccomStudAbsenceEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public TList<AccomStudAbsence> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_ED_STUD key.
		///		FK_ACCOM_STUD_ABSENCE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsence objects.</returns>
		public abstract TList<AccomStudAbsence> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudAbsence Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudAbsenceKey key, int start, int pageLength)
		{
			return GetByAccomStudAbsenceId(transactionManager, key.AccomStudAbsenceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_accomStudAbsenceId">غياب الطلاب عن السكن</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsence GetByAccomStudAbsenceId(System.Decimal _accomStudAbsenceId)
		{
			int count = -1;
			return GetByAccomStudAbsenceId(null,_accomStudAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_accomStudAbsenceId">غياب الطلاب عن السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsence GetByAccomStudAbsenceId(System.Decimal _accomStudAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudAbsenceId(null, _accomStudAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudAbsenceId">غياب الطلاب عن السكن</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsence GetByAccomStudAbsenceId(TransactionManager transactionManager, System.Decimal _accomStudAbsenceId)
		{
			int count = -1;
			return GetByAccomStudAbsenceId(transactionManager, _accomStudAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudAbsenceId">غياب الطلاب عن السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsence GetByAccomStudAbsenceId(TransactionManager transactionManager, System.Decimal _accomStudAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudAbsenceId(transactionManager, _accomStudAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_accomStudAbsenceId">غياب الطلاب عن السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsence GetByAccomStudAbsenceId(System.Decimal _accomStudAbsenceId, int start, int pageLength, out int count)
		{
			return GetByAccomStudAbsenceId(null, _accomStudAbsenceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudAbsenceId">غياب الطلاب عن السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudAbsence GetByAccomStudAbsenceId(TransactionManager transactionManager, System.Decimal _accomStudAbsenceId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_absDate">تاريخ الغياب</param>
		/// <param name="_fajrFlg"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsence GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.DateTime _absDate, System.Boolean _fajrFlg)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(null,_edAcadYearId, _edStudId, _absDate, _fajrFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_absDate">تاريخ الغياب</param>
		/// <param name="_fajrFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsence GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.DateTime _absDate, System.Boolean _fajrFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(null, _edAcadYearId, _edStudId, _absDate, _fajrFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_absDate">تاريخ الغياب</param>
		/// <param name="_fajrFlg"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsence GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.DateTime _absDate, System.Boolean _fajrFlg)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(transactionManager, _edAcadYearId, _edStudId, _absDate, _fajrFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_absDate">تاريخ الغياب</param>
		/// <param name="_fajrFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsence GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.DateTime _absDate, System.Boolean _fajrFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(transactionManager, _edAcadYearId, _edStudId, _absDate, _fajrFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_absDate">تاريخ الغياب</param>
		/// <param name="_fajrFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsence GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.DateTime _absDate, System.Boolean _fajrFlg, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(null, _edAcadYearId, _edStudId, _absDate, _fajrFlg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_absDate">تاريخ الغياب</param>
		/// <param name="_fajrFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudAbsence GetByEdAcadYearIdEdStudIdAbsDateFajrFlg(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.DateTime _absDate, System.Boolean _fajrFlg, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudAbsence&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudAbsence&gt;"/></returns>
		public static TList<AccomStudAbsence> Fill(IDataReader reader, TList<AccomStudAbsence> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudAbsence c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudAbsence")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_ABSENCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudAbsence>(
					key.ToString(), // EntityTrackingKey
					"AccomStudAbsence",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudAbsence();
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
					c.AccomStudAbsenceId = (System.Decimal)reader["ACCOM_STUD_ABSENCE_ID"];
					c.OriginalAccomStudAbsenceId = c.AccomStudAbsenceId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.AccomStudBookId = (System.Decimal)reader["ACCOM_STUD_BOOK_ID"];
					c.FajrFlg = (System.Boolean)reader["FAJR_FLG"];
					c.AbsDate = (System.DateTime)reader["ABS_DATE"];
					c.ExecuseFlg = (System.Boolean)reader["EXECUSE_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudAbsence entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudAbsenceId = (System.Decimal)reader[((int)AccomStudAbsenceColumn.AccomStudAbsenceId - 1)];
			entity.OriginalAccomStudAbsenceId = (System.Decimal)reader["ACCOM_STUD_ABSENCE_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)AccomStudAbsenceColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)AccomStudAbsenceColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)AccomStudAbsenceColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)AccomStudAbsenceColumn.EdCodeSemesterId - 1)];
			entity.AccomStudBookId = (System.Decimal)reader[((int)AccomStudAbsenceColumn.AccomStudBookId - 1)];
			entity.FajrFlg = (System.Boolean)reader[((int)AccomStudAbsenceColumn.FajrFlg - 1)];
			entity.AbsDate = (System.DateTime)reader[((int)AccomStudAbsenceColumn.AbsDate - 1)];
			entity.ExecuseFlg = (System.Boolean)reader[((int)AccomStudAbsenceColumn.ExecuseFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)AccomStudAbsenceColumn.Notes - 1)))?null:(System.String)reader[((int)AccomStudAbsenceColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudAbsenceColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudAbsenceColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudAbsenceColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudAbsenceColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudAbsence entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudAbsenceId = (System.Decimal)dataRow["ACCOM_STUD_ABSENCE_ID"];
			entity.OriginalAccomStudAbsenceId = (System.Decimal)dataRow["ACCOM_STUD_ABSENCE_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.AccomStudBookId = (System.Decimal)dataRow["ACCOM_STUD_BOOK_ID"];
			entity.FajrFlg = (System.Boolean)dataRow["FAJR_FLG"];
			entity.AbsDate = (System.DateTime)dataRow["ABS_DATE"];
			entity.ExecuseFlg = (System.Boolean)dataRow["EXECUSE_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsence"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudAbsence Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudAbsence entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomStudBookIdSource	
			if (CanDeepLoad(entity, "AccomStudBook|AccomStudBookIdSource", deepLoadType, innerList) 
				&& entity.AccomStudBookIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomStudBookId;
				AccomStudBook tmpEntity = EntityManager.LocateEntity<AccomStudBook>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomStudBook), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomStudBookIdSource = tmpEntity;
				else
					entity.AccomStudBookIdSource = DataRepository.AccomStudBookProvider.GetByAccomStudBookId(transactionManager, entity.AccomStudBookId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudBookIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomStudBookIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomStudBookProvider.DeepLoad(transactionManager, entity.AccomStudBookIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomStudBookIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudAbsence object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudAbsence instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudAbsence Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudAbsence entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomStudBookIdSource
			if (CanDeepSave(entity, "AccomStudBook|AccomStudBookIdSource", deepSaveType, innerList) 
				&& entity.AccomStudBookIdSource != null)
			{
				DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookIdSource);
				entity.AccomStudBookId = entity.AccomStudBookIdSource.AccomStudBookId;
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
	
	#region AccomStudAbsenceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudAbsence</c>
	///</summary>
	public enum AccomStudAbsenceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomStudBook</c> at AccomStudBookIdSource
		///</summary>
		[ChildEntityType(typeof(AccomStudBook))]
		AccomStudBook,
		
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
	}
	
	#endregion AccomStudAbsenceChildEntityTypes
	
	#region AccomStudAbsenceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudAbsenceFilterBuilder : SqlFilterBuilder<AccomStudAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceFilterBuilder class.
		/// </summary>
		public AccomStudAbsenceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudAbsenceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudAbsenceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudAbsenceFilterBuilder
	
	#region AccomStudAbsenceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudAbsenceParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceParameterBuilder class.
		/// </summary>
		public AccomStudAbsenceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudAbsenceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudAbsenceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudAbsenceParameterBuilder
	
	#region AccomStudAbsenceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudAbsence"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudAbsenceSortBuilder : SqlSortBuilder<AccomStudAbsenceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceSqlSortBuilder class.
		/// </summary>
		public AccomStudAbsenceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudAbsenceSortBuilder
	
} // end namespace
