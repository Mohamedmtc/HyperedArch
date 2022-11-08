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
	/// This class is the base class for any <see cref="AccomStudAbsenceWarnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudAbsenceWarnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn, UMIS_VER2.BusinessLyer.AccomStudAbsenceWarnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudAbsenceWarnKey key)
		{
			return Delete(transactionManager, key.AccomStudAbsenceWarnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudAbsenceWarnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudAbsenceWarnId)
		{
			return Delete(null, _accomStudAbsenceWarnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudAbsenceWarnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudAbsenceWarnId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ACCOM_CDE_WARN key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ACCOM_CDE_WARN Description: 
		/// </summary>
		/// <param name="_accomCdeWarnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByAccomCdeWarnId(System.Int32 _accomCdeWarnId)
		{
			int count = -1;
			return GetByAccomCdeWarnId(_accomCdeWarnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ACCOM_CDE_WARN key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ACCOM_CDE_WARN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudAbsenceWarn> GetByAccomCdeWarnId(TransactionManager transactionManager, System.Int32 _accomCdeWarnId)
		{
			int count = -1;
			return GetByAccomCdeWarnId(transactionManager, _accomCdeWarnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ACCOM_CDE_WARN key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ACCOM_CDE_WARN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByAccomCdeWarnId(TransactionManager transactionManager, System.Int32 _accomCdeWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeWarnId(transactionManager, _accomCdeWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ACCOM_CDE_WARN key.
		///		fkAccomStudAbsenceWarnAccomCdeWarn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByAccomCdeWarnId(System.Int32 _accomCdeWarnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomCdeWarnId(null, _accomCdeWarnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ACCOM_CDE_WARN key.
		///		fkAccomStudAbsenceWarnAccomCdeWarn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByAccomCdeWarnId(System.Int32 _accomCdeWarnId, int start, int pageLength,out int count)
		{
			return GetByAccomCdeWarnId(null, _accomCdeWarnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ACCOM_CDE_WARN key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ACCOM_CDE_WARN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public abstract TList<AccomStudAbsenceWarn> GetByAccomCdeWarnId(TransactionManager transactionManager, System.Int32 _accomCdeWarnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudAbsenceWarn> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_ACAD_YEAR key.
		///		fkAccomStudAbsenceWarnEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_ACAD_YEAR key.
		///		fkAccomStudAbsenceWarnEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public abstract TList<AccomStudAbsenceWarn> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudAbsenceWarn> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_CODE_SEMESTER key.
		///		fkAccomStudAbsenceWarnEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_CODE_SEMESTER key.
		///		fkAccomStudAbsenceWarnEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public abstract TList<AccomStudAbsenceWarn> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_STUD key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_STUD key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudAbsenceWarn> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_STUD key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_STUD key.
		///		fkAccomStudAbsenceWarnEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_STUD key.
		///		fkAccomStudAbsenceWarnEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public TList<AccomStudAbsenceWarn> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_ABSENCE_WARN_ED_STUD key.
		///		FK_ACCOM_STUD_ABSENCE_WARN_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn objects.</returns>
		public abstract TList<AccomStudAbsenceWarn> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudAbsenceWarnKey key, int start, int pageLength)
		{
			return GetByAccomStudAbsenceWarnId(transactionManager, key.AccomStudAbsenceWarnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="_accomStudAbsenceWarnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByAccomStudAbsenceWarnId(System.Decimal _accomStudAbsenceWarnId)
		{
			int count = -1;
			return GetByAccomStudAbsenceWarnId(null,_accomStudAbsenceWarnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="_accomStudAbsenceWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByAccomStudAbsenceWarnId(System.Decimal _accomStudAbsenceWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudAbsenceWarnId(null, _accomStudAbsenceWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudAbsenceWarnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByAccomStudAbsenceWarnId(TransactionManager transactionManager, System.Decimal _accomStudAbsenceWarnId)
		{
			int count = -1;
			return GetByAccomStudAbsenceWarnId(transactionManager, _accomStudAbsenceWarnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudAbsenceWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByAccomStudAbsenceWarnId(TransactionManager transactionManager, System.Decimal _accomStudAbsenceWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudAbsenceWarnId(transactionManager, _accomStudAbsenceWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="_accomStudAbsenceWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByAccomStudAbsenceWarnId(System.Decimal _accomStudAbsenceWarnId, int start, int pageLength, out int count)
		{
			return GetByAccomStudAbsenceWarnId(null, _accomStudAbsenceWarnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudAbsenceWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByAccomStudAbsenceWarnId(TransactionManager transactionManager, System.Decimal _accomStudAbsenceWarnId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fajrFlg"></param>
		/// <param name="_accomCdeWarnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Boolean _fajrFlg, System.Int32 _accomCdeWarnId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(null,_edStudId, _edAcadYearId, _edCodeSemesterId, _fajrFlg, _accomCdeWarnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fajrFlg"></param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Boolean _fajrFlg, System.Int32 _accomCdeWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, _fajrFlg, _accomCdeWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fajrFlg"></param>
		/// <param name="_accomCdeWarnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Boolean _fajrFlg, System.Int32 _accomCdeWarnId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, _fajrFlg, _accomCdeWarnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fajrFlg"></param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Boolean _fajrFlg, System.Int32 _accomCdeWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, _fajrFlg, _accomCdeWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fajrFlg"></param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Boolean _fajrFlg, System.Int32 _accomCdeWarnId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, _fajrFlg, _accomCdeWarnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_ABSENCE_WARN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="_fajrFlg"></param>
		/// <param name="_accomCdeWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn GetByEdStudIdEdAcadYearIdEdCodeSemesterIdFajrFlgAccomCdeWarnId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, System.Boolean _fajrFlg, System.Int32 _accomCdeWarnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudAbsenceWarn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudAbsenceWarn&gt;"/></returns>
		public static TList<AccomStudAbsenceWarn> Fill(IDataReader reader, TList<AccomStudAbsenceWarn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudAbsenceWarn")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_ABSENCE_WARN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudAbsenceWarn>(
					key.ToString(), // EntityTrackingKey
					"AccomStudAbsenceWarn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn();
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
					c.AccomStudAbsenceWarnId = (System.Decimal)reader["ACCOM_STUD_ABSENCE_WARN_ID"];
					c.OriginalAccomStudAbsenceWarnId = c.AccomStudAbsenceWarnId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.FajrFlg = (System.Boolean)reader["FAJR_FLG"];
					c.AbsDayCount = (System.Int32)reader["ABS_DAY_COUNT"];
					c.AccomCdeWarnId = (System.Int32)reader["ACCOM_CDE_WARN_ID"];
					c.WarnDate = Convert.IsDBNull(reader["WARN_DATE"]) ? null : (System.DateTime?)reader["WARN_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudAbsenceWarnId = (System.Decimal)reader[((int)AccomStudAbsenceWarnColumn.AccomStudAbsenceWarnId - 1)];
			entity.OriginalAccomStudAbsenceWarnId = (System.Decimal)reader["ACCOM_STUD_ABSENCE_WARN_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)AccomStudAbsenceWarnColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)AccomStudAbsenceWarnColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)AccomStudAbsenceWarnColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)AccomStudAbsenceWarnColumn.EdStudId - 1)];
			entity.FajrFlg = (System.Boolean)reader[((int)AccomStudAbsenceWarnColumn.FajrFlg - 1)];
			entity.AbsDayCount = (System.Int32)reader[((int)AccomStudAbsenceWarnColumn.AbsDayCount - 1)];
			entity.AccomCdeWarnId = (System.Int32)reader[((int)AccomStudAbsenceWarnColumn.AccomCdeWarnId - 1)];
			entity.WarnDate = (reader.IsDBNull(((int)AccomStudAbsenceWarnColumn.WarnDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudAbsenceWarnColumn.WarnDate - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudAbsenceWarnColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudAbsenceWarnColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudAbsenceWarnColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudAbsenceWarnColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudAbsenceWarnId = (System.Decimal)dataRow["ACCOM_STUD_ABSENCE_WARN_ID"];
			entity.OriginalAccomStudAbsenceWarnId = (System.Decimal)dataRow["ACCOM_STUD_ABSENCE_WARN_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.FajrFlg = (System.Boolean)dataRow["FAJR_FLG"];
			entity.AbsDayCount = (System.Int32)dataRow["ABS_DAY_COUNT"];
			entity.AccomCdeWarnId = (System.Int32)dataRow["ACCOM_CDE_WARN_ID"];
			entity.WarnDate = Convert.IsDBNull(dataRow["WARN_DATE"]) ? null : (System.DateTime?)dataRow["WARN_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomCdeWarnIdSource	
			if (CanDeepLoad(entity, "AccomCdeWarn|AccomCdeWarnIdSource", deepLoadType, innerList) 
				&& entity.AccomCdeWarnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomCdeWarnId;
				AccomCdeWarn tmpEntity = EntityManager.LocateEntity<AccomCdeWarn>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomCdeWarn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomCdeWarnIdSource = tmpEntity;
				else
					entity.AccomCdeWarnIdSource = DataRepository.AccomCdeWarnProvider.GetByAccomCdeWarnId(transactionManager, entity.AccomCdeWarnId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomCdeWarnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomCdeWarnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomCdeWarnProvider.DeepLoad(transactionManager, entity.AccomCdeWarnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomCdeWarnIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomCdeWarnIdSource
			if (CanDeepSave(entity, "AccomCdeWarn|AccomCdeWarnIdSource", deepSaveType, innerList) 
				&& entity.AccomCdeWarnIdSource != null)
			{
				DataRepository.AccomCdeWarnProvider.Save(transactionManager, entity.AccomCdeWarnIdSource);
				entity.AccomCdeWarnId = entity.AccomCdeWarnIdSource.AccomCdeWarnId;
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
	
	#region AccomStudAbsenceWarnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudAbsenceWarn</c>
	///</summary>
	public enum AccomStudAbsenceWarnChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomCdeWarn</c> at AccomCdeWarnIdSource
		///</summary>
		[ChildEntityType(typeof(AccomCdeWarn))]
		AccomCdeWarn,
		
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
	
	#endregion AccomStudAbsenceWarnChildEntityTypes
	
	#region AccomStudAbsenceWarnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudAbsenceWarnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudAbsenceWarn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudAbsenceWarnFilterBuilder : SqlFilterBuilder<AccomStudAbsenceWarnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceWarnFilterBuilder class.
		/// </summary>
		public AccomStudAbsenceWarnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceWarnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudAbsenceWarnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceWarnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudAbsenceWarnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudAbsenceWarnFilterBuilder
	
	#region AccomStudAbsenceWarnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudAbsenceWarnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudAbsenceWarn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudAbsenceWarnParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudAbsenceWarnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceWarnParameterBuilder class.
		/// </summary>
		public AccomStudAbsenceWarnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceWarnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudAbsenceWarnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceWarnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudAbsenceWarnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudAbsenceWarnParameterBuilder
	
	#region AccomStudAbsenceWarnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudAbsenceWarnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudAbsenceWarn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudAbsenceWarnSortBuilder : SqlSortBuilder<AccomStudAbsenceWarnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudAbsenceWarnSqlSortBuilder class.
		/// </summary>
		public AccomStudAbsenceWarnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudAbsenceWarnSortBuilder
	
} // end namespace
