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
	/// This class is the base class for any <see cref="RsrchStudPostponeReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class RsrchStudPostponeReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.RsrchStudPostponeReq, UMIS_VER2.BusinessLyer.RsrchStudPostponeReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudPostponeReqKey key)
		{
			return Delete(transactionManager, key.RsrchStudPostponeReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_rsrchStudPostponeReqId">طلب تأجيل مناقشه بحث التخرج. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _rsrchStudPostponeReqId)
		{
			return Delete(null, _rsrchStudPostponeReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudPostponeReqId">طلب تأجيل مناقشه بحث التخرج. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _rsrchStudPostponeReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_AS_FACULTY_INFO key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_AS_FACULTY_INFO key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudPostponeReq> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_AS_FACULTY_INFO key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_AS_FACULTY_INFO key.
		///		fkRsrchStudPostponeReqAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_AS_FACULTY_INFO key.
		///		fkRsrchStudPostponeReqAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_AS_FACULTY_INFO key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public abstract TList<RsrchStudPostponeReq> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_ACAD_YEAR key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_ACAD_YEAR key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudPostponeReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_ACAD_YEAR key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_ACAD_YEAR key.
		///		fkRsrchStudPostponeReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_ACAD_YEAR key.
		///		fkRsrchStudPostponeReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_ACAD_YEAR key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public abstract TList<RsrchStudPostponeReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_CODE_SEMESTER key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_CODE_SEMESTER key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudPostponeReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_CODE_SEMESTER key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_CODE_SEMESTER key.
		///		fkRsrchStudPostponeReqEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_CODE_SEMESTER key.
		///		fkRsrchStudPostponeReqEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_CODE_SEMESTER key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public abstract TList<RsrchStudPostponeReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_STUD key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_STUD key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudPostponeReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_STUD key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_STUD key.
		///		fkRsrchStudPostponeReqEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_STUD key.
		///		fkRsrchStudPostponeReqEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_ED_STUD key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public abstract TList<RsrchStudPostponeReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_GS_CODE_REQ_STATUS key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId">حالة الطلب جديد - موافق- مرفوض</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_GS_CODE_REQ_STATUS key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب جديد - موافق- مرفوض</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudPostponeReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_GS_CODE_REQ_STATUS key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب جديد - موافق- مرفوض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_GS_CODE_REQ_STATUS key.
		///		fkRsrchStudPostponeReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب جديد - موافق- مرفوض</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_GS_CODE_REQ_STATUS key.
		///		fkRsrchStudPostponeReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب جديد - موافق- مرفوض</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_GS_CODE_REQ_STATUS key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب جديد - موافق- مرفوض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public abstract TList<RsrchStudPostponeReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_PG_THESIS_STUD key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByPgThesisStudId(System.Decimal? _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_PG_THESIS_STUD key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudPostponeReq> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_PG_THESIS_STUD key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_PG_THESIS_STUD key.
		///		fkRsrchStudPostponeReqPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByPgThesisStudId(System.Decimal? _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_PG_THESIS_STUD key.
		///		fkRsrchStudPostponeReqPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public TList<RsrchStudPostponeReq> GetByPgThesisStudId(System.Decimal? _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_POSTPONE_REQ_PG_THESIS_STUD key.
		///		FK_RSRCH_STUD_POSTPONE_REQ_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudPostponeReq objects.</returns>
		public abstract TList<RsrchStudPostponeReq> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.RsrchStudPostponeReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudPostponeReqKey key, int start, int pageLength)
		{
			return GetByRsrchStudPostponeReqId(transactionManager, key.RsrchStudPostponeReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudPostponeReq&gt;"/> class.</returns>
		public TList<RsrchStudPostponeReq> GetByEdAcadYearIdEdStudId(System.Decimal _edAcadYearId, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudId(null,_edAcadYearId, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudPostponeReq&gt;"/> class.</returns>
		public TList<RsrchStudPostponeReq> GetByEdAcadYearIdEdStudId(System.Decimal _edAcadYearId, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudId(null, _edAcadYearId, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudPostponeReq&gt;"/> class.</returns>
		public TList<RsrchStudPostponeReq> GetByEdAcadYearIdEdStudId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudId(transactionManager, _edAcadYearId, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudPostponeReq&gt;"/> class.</returns>
		public TList<RsrchStudPostponeReq> GetByEdAcadYearIdEdStudId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudId(transactionManager, _edAcadYearId, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudPostponeReq&gt;"/> class.</returns>
		public TList<RsrchStudPostponeReq> GetByEdAcadYearIdEdStudId(System.Decimal _edAcadYearId, System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdStudId(null, _edAcadYearId, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudPostponeReq&gt;"/> class.</returns>
		public abstract TList<RsrchStudPostponeReq> GetByEdAcadYearIdEdStudId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="_rsrchStudPostponeReqId">طلب تأجيل مناقشه بحث التخرج</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudPostponeReq GetByRsrchStudPostponeReqId(System.Decimal _rsrchStudPostponeReqId)
		{
			int count = -1;
			return GetByRsrchStudPostponeReqId(null,_rsrchStudPostponeReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="_rsrchStudPostponeReqId">طلب تأجيل مناقشه بحث التخرج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudPostponeReq GetByRsrchStudPostponeReqId(System.Decimal _rsrchStudPostponeReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudPostponeReqId(null, _rsrchStudPostponeReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudPostponeReqId">طلب تأجيل مناقشه بحث التخرج</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudPostponeReq GetByRsrchStudPostponeReqId(TransactionManager transactionManager, System.Decimal _rsrchStudPostponeReqId)
		{
			int count = -1;
			return GetByRsrchStudPostponeReqId(transactionManager, _rsrchStudPostponeReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudPostponeReqId">طلب تأجيل مناقشه بحث التخرج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudPostponeReq GetByRsrchStudPostponeReqId(TransactionManager transactionManager, System.Decimal _rsrchStudPostponeReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudPostponeReqId(transactionManager, _rsrchStudPostponeReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="_rsrchStudPostponeReqId">طلب تأجيل مناقشه بحث التخرج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudPostponeReq GetByRsrchStudPostponeReqId(System.Decimal _rsrchStudPostponeReqId, int start, int pageLength, out int count)
		{
			return GetByRsrchStudPostponeReqId(null, _rsrchStudPostponeReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_POSTPONE_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudPostponeReqId">طلب تأجيل مناقشه بحث التخرج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.RsrchStudPostponeReq GetByRsrchStudPostponeReqId(TransactionManager transactionManager, System.Decimal _rsrchStudPostponeReqId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;RsrchStudPostponeReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;RsrchStudPostponeReq&gt;"/></returns>
		public static TList<RsrchStudPostponeReq> Fill(IDataReader reader, TList<RsrchStudPostponeReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.RsrchStudPostponeReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("RsrchStudPostponeReq")
					.Append("|").Append((System.Decimal)reader["RSRCH_STUD_POSTPONE_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<RsrchStudPostponeReq>(
					key.ToString(), // EntityTrackingKey
					"RsrchStudPostponeReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.RsrchStudPostponeReq();
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
					c.RsrchStudPostponeReqId = (System.Decimal)reader["RSRCH_STUD_POSTPONE_REQ_ID"];
					c.OriginalRsrchStudPostponeReqId = c.RsrchStudPostponeReqId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.PgThesisStudId = Convert.IsDBNull(reader["PG_THESIS_STUD_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_STUD_ID"];
					c.ReqDate = Convert.IsDBNull(reader["REQ_DATE"]) ? null : (System.DateTime?)reader["REQ_DATE"];
					c.Reason = Convert.IsDBNull(reader["REASON"]) ? null : (System.String)reader["REASON"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SupervisorApproveDate = Convert.IsDBNull(reader["SUPERVISOR_APPROVE_DATE"]) ? null : (System.DateTime?)reader["SUPERVISOR_APPROVE_DATE"];
					c.AdvisorApproveDate = Convert.IsDBNull(reader["ADVISOR_APPROVE_DATE"]) ? null : (System.DateTime?)reader["ADVISOR_APPROVE_DATE"];
					c.DeanApproveDate = Convert.IsDBNull(reader["DEAN_APPROVE_DATE"]) ? null : (System.DateTime?)reader["DEAN_APPROVE_DATE"];
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Int32?)reader["APPROVE_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.RsrchStudPostponeReq entity)
		{
			if (!reader.Read()) return;
			
			entity.RsrchStudPostponeReqId = (System.Decimal)reader[((int)RsrchStudPostponeReqColumn.RsrchStudPostponeReqId - 1)];
			entity.OriginalRsrchStudPostponeReqId = (System.Decimal)reader["RSRCH_STUD_POSTPONE_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)RsrchStudPostponeReqColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)RsrchStudPostponeReqColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)RsrchStudPostponeReqColumn.EdStudId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)RsrchStudPostponeReqColumn.AsFacultyInfoId - 1)];
			entity.PgThesisStudId = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.PgThesisStudId - 1)))?null:(System.Decimal?)reader[((int)RsrchStudPostponeReqColumn.PgThesisStudId - 1)];
			entity.ReqDate = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.ReqDate - 1)))?null:(System.DateTime?)reader[((int)RsrchStudPostponeReqColumn.ReqDate - 1)];
			entity.Reason = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.Reason - 1)))?null:(System.String)reader[((int)RsrchStudPostponeReqColumn.Reason - 1)];
			entity.Notes = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.Notes - 1)))?null:(System.String)reader[((int)RsrchStudPostponeReqColumn.Notes - 1)];
			entity.SupervisorApproveDate = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.SupervisorApproveDate - 1)))?null:(System.DateTime?)reader[((int)RsrchStudPostponeReqColumn.SupervisorApproveDate - 1)];
			entity.AdvisorApproveDate = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.AdvisorApproveDate - 1)))?null:(System.DateTime?)reader[((int)RsrchStudPostponeReqColumn.AdvisorApproveDate - 1)];
			entity.DeanApproveDate = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.DeanApproveDate - 1)))?null:(System.DateTime?)reader[((int)RsrchStudPostponeReqColumn.DeanApproveDate - 1)];
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)RsrchStudPostponeReqColumn.GsCodeReqStatusId - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)RsrchStudPostponeReqColumn.ApproveDate - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.ApproveFlg - 1)))?null:(System.Int32?)reader[((int)RsrchStudPostponeReqColumn.ApproveFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)RsrchStudPostponeReqColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)RsrchStudPostponeReqColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)RsrchStudPostponeReqColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.RsrchStudPostponeReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.RsrchStudPostponeReqId = (System.Decimal)dataRow["RSRCH_STUD_POSTPONE_REQ_ID"];
			entity.OriginalRsrchStudPostponeReqId = (System.Decimal)dataRow["RSRCH_STUD_POSTPONE_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.PgThesisStudId = Convert.IsDBNull(dataRow["PG_THESIS_STUD_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_STUD_ID"];
			entity.ReqDate = Convert.IsDBNull(dataRow["REQ_DATE"]) ? null : (System.DateTime?)dataRow["REQ_DATE"];
			entity.Reason = Convert.IsDBNull(dataRow["REASON"]) ? null : (System.String)dataRow["REASON"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SupervisorApproveDate = Convert.IsDBNull(dataRow["SUPERVISOR_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["SUPERVISOR_APPROVE_DATE"];
			entity.AdvisorApproveDate = Convert.IsDBNull(dataRow["ADVISOR_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["ADVISOR_APPROVE_DATE"];
			entity.DeanApproveDate = Convert.IsDBNull(dataRow["DEAN_APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["DEAN_APPROVE_DATE"];
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Int32?)dataRow["APPROVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchStudPostponeReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchStudPostponeReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudPostponeReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCodeReqStatusIdSource	
			if (CanDeepLoad(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReqStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeReqStatusId;
				GsCodeReqStatus tmpEntity = EntityManager.LocateEntity<GsCodeReqStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReqStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReqStatusIdSource = tmpEntity;
				else
					entity.GsCodeReqStatusIdSource = DataRepository.GsCodeReqStatusProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeReqStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeReqStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeReqStatusProvider.DeepLoad(transactionManager, entity.GsCodeReqStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeReqStatusIdSource

			#region PgThesisStudIdSource	
			if (CanDeepLoad(entity, "PgThesisStud|PgThesisStudIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisStudId ?? 0.0m);
				PgThesisStud tmpEntity = EntityManager.LocateEntity<PgThesisStud>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudIdSource = tmpEntity;
				else
					entity.PgThesisStudIdSource = DataRepository.PgThesisStudProvider.GetByPgThesisStudId(transactionManager, (entity.PgThesisStudId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudProvider.DeepLoad(transactionManager, entity.PgThesisStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.RsrchStudPostponeReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.RsrchStudPostponeReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchStudPostponeReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudPostponeReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region GsCodeReqStatusIdSource
			if (CanDeepSave(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReqStatusIdSource != null)
			{
				DataRepository.GsCodeReqStatusProvider.Save(transactionManager, entity.GsCodeReqStatusIdSource);
				entity.GsCodeReqStatusId = entity.GsCodeReqStatusIdSource.GsCodeReqStatusId;
			}
			#endregion 
			
			#region PgThesisStudIdSource
			if (CanDeepSave(entity, "PgThesisStud|PgThesisStudIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudIdSource != null)
			{
				DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudIdSource);
				entity.PgThesisStudId = entity.PgThesisStudIdSource.PgThesisStudId;
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
	
	#region RsrchStudPostponeReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.RsrchStudPostponeReq</c>
	///</summary>
	public enum RsrchStudPostponeReqChildEntityTypes
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
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
	}
	
	#endregion RsrchStudPostponeReqChildEntityTypes
	
	#region RsrchStudPostponeReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;RsrchStudPostponeReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchStudPostponeReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchStudPostponeReqFilterBuilder : SqlFilterBuilder<RsrchStudPostponeReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchStudPostponeReqFilterBuilder class.
		/// </summary>
		public RsrchStudPostponeReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudPostponeReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchStudPostponeReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudPostponeReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchStudPostponeReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchStudPostponeReqFilterBuilder
	
	#region RsrchStudPostponeReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;RsrchStudPostponeReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchStudPostponeReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchStudPostponeReqParameterBuilder : ParameterizedSqlFilterBuilder<RsrchStudPostponeReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchStudPostponeReqParameterBuilder class.
		/// </summary>
		public RsrchStudPostponeReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudPostponeReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchStudPostponeReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudPostponeReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchStudPostponeReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchStudPostponeReqParameterBuilder
	
	#region RsrchStudPostponeReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;RsrchStudPostponeReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchStudPostponeReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class RsrchStudPostponeReqSortBuilder : SqlSortBuilder<RsrchStudPostponeReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchStudPostponeReqSqlSortBuilder class.
		/// </summary>
		public RsrchStudPostponeReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion RsrchStudPostponeReqSortBuilder
	
} // end namespace
