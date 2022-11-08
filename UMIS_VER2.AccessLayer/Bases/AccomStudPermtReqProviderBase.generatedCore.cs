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
	/// This class is the base class for any <see cref="AccomStudPermtReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudPermtReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudPermtReq, UMIS_VER2.BusinessLyer.AccomStudPermtReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudPermtReqKey key)
		{
			return Delete(transactionManager, key.AccomStudPermtReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudPermtReqId">تصريح الخروج للطلاب الاناث-.-طلب مبيت خارج السكن. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudPermtReqId)
		{
			return Delete(null, _accomStudPermtReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudPermtReqId">تصريح الخروج للطلاب الاناث-.-طلب مبيت خارج السكن. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudPermtReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_ACCOM_STUD_RESPONSIBLE key.
		///		FK_ACCOM_STUD_PERMT_ACCOM_STUD_RESPONSIBLE Description: 
		/// </summary>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomStudResponsibleId(System.Decimal? _accomStudResponsibleId)
		{
			int count = -1;
			return GetByAccomStudResponsibleId(_accomStudResponsibleId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_ACCOM_STUD_RESPONSIBLE key.
		///		FK_ACCOM_STUD_PERMT_ACCOM_STUD_RESPONSIBLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudPermtReq> GetByAccomStudResponsibleId(TransactionManager transactionManager, System.Decimal? _accomStudResponsibleId)
		{
			int count = -1;
			return GetByAccomStudResponsibleId(transactionManager, _accomStudResponsibleId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_ACCOM_STUD_RESPONSIBLE key.
		///		FK_ACCOM_STUD_PERMT_ACCOM_STUD_RESPONSIBLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomStudResponsibleId(TransactionManager transactionManager, System.Decimal? _accomStudResponsibleId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudResponsibleId(transactionManager, _accomStudResponsibleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_ACCOM_STUD_RESPONSIBLE key.
		///		fkAccomStudPermtAccomStudResponsible Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomStudResponsibleId(System.Decimal? _accomStudResponsibleId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudResponsibleId(null, _accomStudResponsibleId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_ACCOM_STUD_RESPONSIBLE key.
		///		fkAccomStudPermtAccomStudResponsible Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomStudResponsibleId(System.Decimal? _accomStudResponsibleId, int start, int pageLength,out int count)
		{
			return GetByAccomStudResponsibleId(null, _accomStudResponsibleId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_ACCOM_STUD_RESPONSIBLE key.
		///		FK_ACCOM_STUD_PERMT_ACCOM_STUD_RESPONSIBLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudResponsibleId">الاشخاص المصرح لهم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public abstract TList<AccomStudPermtReq> GetByAccomStudResponsibleId(TransactionManager transactionManager, System.Decimal? _accomStudResponsibleId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_CDE_PERMT_TYPE key.
		///		FK_ACCOM_STUD_PERMT_REQ_ACCOM_CDE_PERMT_TYPE Description: 
		/// </summary>
		/// <param name="_accomCdePermtTypeId">نوع التصريح</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomCdePermtTypeId(System.Int32 _accomCdePermtTypeId)
		{
			int count = -1;
			return GetByAccomCdePermtTypeId(_accomCdePermtTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_CDE_PERMT_TYPE key.
		///		FK_ACCOM_STUD_PERMT_REQ_ACCOM_CDE_PERMT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePermtTypeId">نوع التصريح</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudPermtReq> GetByAccomCdePermtTypeId(TransactionManager transactionManager, System.Int32 _accomCdePermtTypeId)
		{
			int count = -1;
			return GetByAccomCdePermtTypeId(transactionManager, _accomCdePermtTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_CDE_PERMT_TYPE key.
		///		FK_ACCOM_STUD_PERMT_REQ_ACCOM_CDE_PERMT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePermtTypeId">نوع التصريح</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomCdePermtTypeId(TransactionManager transactionManager, System.Int32 _accomCdePermtTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdePermtTypeId(transactionManager, _accomCdePermtTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_CDE_PERMT_TYPE key.
		///		fkAccomStudPermtReqAccomCdePermtType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdePermtTypeId">نوع التصريح</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomCdePermtTypeId(System.Int32 _accomCdePermtTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomCdePermtTypeId(null, _accomCdePermtTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_CDE_PERMT_TYPE key.
		///		fkAccomStudPermtReqAccomCdePermtType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdePermtTypeId">نوع التصريح</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomCdePermtTypeId(System.Int32 _accomCdePermtTypeId, int start, int pageLength,out int count)
		{
			return GetByAccomCdePermtTypeId(null, _accomCdePermtTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_CDE_PERMT_TYPE key.
		///		FK_ACCOM_STUD_PERMT_REQ_ACCOM_CDE_PERMT_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdePermtTypeId">نوع التصريح</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public abstract TList<AccomStudPermtReq> GetByAccomCdePermtTypeId(TransactionManager transactionManager, System.Int32 _accomCdePermtTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_PERMT_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomStudBookId(System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(_accomStudBookId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_PERMT_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudPermtReq> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_PERMT_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_STUD_BOOK key.
		///		fkAccomStudPermtReqAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_STUD_BOOK key.
		///		fkAccomStudPermtReqAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength,out int count)
		{
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_PERMT_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public abstract TList<AccomStudPermtReq> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_PERMT_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_PERMT_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudPermtReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_PERMT_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_GS_CODE_REQ_STATUS key.
		///		fkAccomStudPermtReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_GS_CODE_REQ_STATUS key.
		///		fkAccomStudPermtReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public TList<AccomStudPermtReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_PERMT_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_PERMT_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudPermtReq objects.</returns>
		public abstract TList<AccomStudPermtReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudPermtReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudPermtReqKey key, int start, int pageLength)
		{
			return GetByAccomStudPermtReqId(transactionManager, key.AccomStudPermtReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_PERMT_REQ index.
		/// </summary>
		/// <param name="_accomStudPermtReqId">تصريح الخروج للطلاب الاناث-.-طلب مبيت خارج السكن</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudPermtReq GetByAccomStudPermtReqId(System.Decimal _accomStudPermtReqId)
		{
			int count = -1;
			return GetByAccomStudPermtReqId(null,_accomStudPermtReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_PERMT_REQ index.
		/// </summary>
		/// <param name="_accomStudPermtReqId">تصريح الخروج للطلاب الاناث-.-طلب مبيت خارج السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudPermtReq GetByAccomStudPermtReqId(System.Decimal _accomStudPermtReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudPermtReqId(null, _accomStudPermtReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_PERMT_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudPermtReqId">تصريح الخروج للطلاب الاناث-.-طلب مبيت خارج السكن</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudPermtReq GetByAccomStudPermtReqId(TransactionManager transactionManager, System.Decimal _accomStudPermtReqId)
		{
			int count = -1;
			return GetByAccomStudPermtReqId(transactionManager, _accomStudPermtReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_PERMT_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudPermtReqId">تصريح الخروج للطلاب الاناث-.-طلب مبيت خارج السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudPermtReq GetByAccomStudPermtReqId(TransactionManager transactionManager, System.Decimal _accomStudPermtReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudPermtReqId(transactionManager, _accomStudPermtReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_PERMT_REQ index.
		/// </summary>
		/// <param name="_accomStudPermtReqId">تصريح الخروج للطلاب الاناث-.-طلب مبيت خارج السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudPermtReq GetByAccomStudPermtReqId(System.Decimal _accomStudPermtReqId, int start, int pageLength, out int count)
		{
			return GetByAccomStudPermtReqId(null, _accomStudPermtReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_PERMT_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudPermtReqId">تصريح الخروج للطلاب الاناث-.-طلب مبيت خارج السكن</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudPermtReq GetByAccomStudPermtReqId(TransactionManager transactionManager, System.Decimal _accomStudPermtReqId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudPermtReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudPermtReq&gt;"/></returns>
		public static TList<AccomStudPermtReq> Fill(IDataReader reader, TList<AccomStudPermtReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudPermtReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudPermtReq")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_PERMT_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudPermtReq>(
					key.ToString(), // EntityTrackingKey
					"AccomStudPermtReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudPermtReq();
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
					c.AccomStudPermtReqId = (System.Decimal)reader["ACCOM_STUD_PERMT_REQ_ID"];
					c.OriginalAccomStudPermtReqId = c.AccomStudPermtReqId;
					c.AccomCdePermtTypeId = (System.Int32)reader["ACCOM_CDE_PERMT_TYPE_ID"];
					c.AccomStudBookId = (System.Decimal)reader["ACCOM_STUD_BOOK_ID"];
					c.ReqDate = Convert.IsDBNull(reader["REQ_DATE"]) ? null : (System.DateTime?)reader["REQ_DATE"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.FromTime = Convert.IsDBNull(reader["FROM_TIME"]) ? null : (System.DateTime?)reader["FROM_TIME"];
					c.ToTime = Convert.IsDBNull(reader["TO_TIME"]) ? null : (System.DateTime?)reader["TO_TIME"];
					c.Reason = Convert.IsDBNull(reader["REASON"]) ? null : (System.String)reader["REASON"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.AccomStudResponsibleId = Convert.IsDBNull(reader["ACCOM_STUD_RESPONSIBLE_ID"]) ? null : (System.Decimal?)reader["ACCOM_STUD_RESPONSIBLE_ID"];
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.ApproveFlg = (System.Int32)reader["APPROVE_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudPermtReq entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudPermtReqId = (System.Decimal)reader[((int)AccomStudPermtReqColumn.AccomStudPermtReqId - 1)];
			entity.OriginalAccomStudPermtReqId = (System.Decimal)reader["ACCOM_STUD_PERMT_REQ_ID"];
			entity.AccomCdePermtTypeId = (System.Int32)reader[((int)AccomStudPermtReqColumn.AccomCdePermtTypeId - 1)];
			entity.AccomStudBookId = (System.Decimal)reader[((int)AccomStudPermtReqColumn.AccomStudBookId - 1)];
			entity.ReqDate = (reader.IsDBNull(((int)AccomStudPermtReqColumn.ReqDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudPermtReqColumn.ReqDate - 1)];
			entity.FromDate = (reader.IsDBNull(((int)AccomStudPermtReqColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudPermtReqColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)AccomStudPermtReqColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudPermtReqColumn.ToDate - 1)];
			entity.FromTime = (reader.IsDBNull(((int)AccomStudPermtReqColumn.FromTime - 1)))?null:(System.DateTime?)reader[((int)AccomStudPermtReqColumn.FromTime - 1)];
			entity.ToTime = (reader.IsDBNull(((int)AccomStudPermtReqColumn.ToTime - 1)))?null:(System.DateTime?)reader[((int)AccomStudPermtReqColumn.ToTime - 1)];
			entity.Reason = (reader.IsDBNull(((int)AccomStudPermtReqColumn.Reason - 1)))?null:(System.String)reader[((int)AccomStudPermtReqColumn.Reason - 1)];
			entity.Notes = (reader.IsDBNull(((int)AccomStudPermtReqColumn.Notes - 1)))?null:(System.String)reader[((int)AccomStudPermtReqColumn.Notes - 1)];
			entity.AccomStudResponsibleId = (reader.IsDBNull(((int)AccomStudPermtReqColumn.AccomStudResponsibleId - 1)))?null:(System.Decimal?)reader[((int)AccomStudPermtReqColumn.AccomStudResponsibleId - 1)];
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)AccomStudPermtReqColumn.GsCodeReqStatusId - 1)];
			entity.ApproveFlg = (System.Int32)reader[((int)AccomStudPermtReqColumn.ApproveFlg - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudPermtReqColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudPermtReqColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudPermtReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudPermtReqColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudPermtReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudPermtReqId = (System.Decimal)dataRow["ACCOM_STUD_PERMT_REQ_ID"];
			entity.OriginalAccomStudPermtReqId = (System.Decimal)dataRow["ACCOM_STUD_PERMT_REQ_ID"];
			entity.AccomCdePermtTypeId = (System.Int32)dataRow["ACCOM_CDE_PERMT_TYPE_ID"];
			entity.AccomStudBookId = (System.Decimal)dataRow["ACCOM_STUD_BOOK_ID"];
			entity.ReqDate = Convert.IsDBNull(dataRow["REQ_DATE"]) ? null : (System.DateTime?)dataRow["REQ_DATE"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.FromTime = Convert.IsDBNull(dataRow["FROM_TIME"]) ? null : (System.DateTime?)dataRow["FROM_TIME"];
			entity.ToTime = Convert.IsDBNull(dataRow["TO_TIME"]) ? null : (System.DateTime?)dataRow["TO_TIME"];
			entity.Reason = Convert.IsDBNull(dataRow["REASON"]) ? null : (System.String)dataRow["REASON"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.AccomStudResponsibleId = Convert.IsDBNull(dataRow["ACCOM_STUD_RESPONSIBLE_ID"]) ? null : (System.Decimal?)dataRow["ACCOM_STUD_RESPONSIBLE_ID"];
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.ApproveFlg = (System.Int32)dataRow["APPROVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudPermtReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudPermtReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudPermtReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomStudResponsibleIdSource	
			if (CanDeepLoad(entity, "AccomStudResponsible|AccomStudResponsibleIdSource", deepLoadType, innerList) 
				&& entity.AccomStudResponsibleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AccomStudResponsibleId ?? 0.0m);
				AccomStudResponsible tmpEntity = EntityManager.LocateEntity<AccomStudResponsible>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomStudResponsible), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomStudResponsibleIdSource = tmpEntity;
				else
					entity.AccomStudResponsibleIdSource = DataRepository.AccomStudResponsibleProvider.GetByAccomStudResponsibleId(transactionManager, (entity.AccomStudResponsibleId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudResponsibleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomStudResponsibleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomStudResponsibleProvider.DeepLoad(transactionManager, entity.AccomStudResponsibleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomStudResponsibleIdSource

			#region AccomCdePermtTypeIdSource	
			if (CanDeepLoad(entity, "AccomCdePermtType|AccomCdePermtTypeIdSource", deepLoadType, innerList) 
				&& entity.AccomCdePermtTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomCdePermtTypeId;
				AccomCdePermtType tmpEntity = EntityManager.LocateEntity<AccomCdePermtType>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomCdePermtType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomCdePermtTypeIdSource = tmpEntity;
				else
					entity.AccomCdePermtTypeIdSource = DataRepository.AccomCdePermtTypeProvider.GetByAccomCdePermtTypeId(transactionManager, entity.AccomCdePermtTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomCdePermtTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomCdePermtTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomCdePermtTypeProvider.DeepLoad(transactionManager, entity.AccomCdePermtTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomCdePermtTypeIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudPermtReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudPermtReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudPermtReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudPermtReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomStudResponsibleIdSource
			if (CanDeepSave(entity, "AccomStudResponsible|AccomStudResponsibleIdSource", deepSaveType, innerList) 
				&& entity.AccomStudResponsibleIdSource != null)
			{
				DataRepository.AccomStudResponsibleProvider.Save(transactionManager, entity.AccomStudResponsibleIdSource);
				entity.AccomStudResponsibleId = entity.AccomStudResponsibleIdSource.AccomStudResponsibleId;
			}
			#endregion 
			
			#region AccomCdePermtTypeIdSource
			if (CanDeepSave(entity, "AccomCdePermtType|AccomCdePermtTypeIdSource", deepSaveType, innerList) 
				&& entity.AccomCdePermtTypeIdSource != null)
			{
				DataRepository.AccomCdePermtTypeProvider.Save(transactionManager, entity.AccomCdePermtTypeIdSource);
				entity.AccomCdePermtTypeId = entity.AccomCdePermtTypeIdSource.AccomCdePermtTypeId;
			}
			#endregion 
			
			#region AccomStudBookIdSource
			if (CanDeepSave(entity, "AccomStudBook|AccomStudBookIdSource", deepSaveType, innerList) 
				&& entity.AccomStudBookIdSource != null)
			{
				DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookIdSource);
				entity.AccomStudBookId = entity.AccomStudBookIdSource.AccomStudBookId;
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
	
	#region AccomStudPermtReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudPermtReq</c>
	///</summary>
	public enum AccomStudPermtReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomStudResponsible</c> at AccomStudResponsibleIdSource
		///</summary>
		[ChildEntityType(typeof(AccomStudResponsible))]
		AccomStudResponsible,
		
		///<summary>
		/// Composite Property for <c>AccomCdePermtType</c> at AccomCdePermtTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AccomCdePermtType))]
		AccomCdePermtType,
		
		///<summary>
		/// Composite Property for <c>AccomStudBook</c> at AccomStudBookIdSource
		///</summary>
		[ChildEntityType(typeof(AccomStudBook))]
		AccomStudBook,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
	}
	
	#endregion AccomStudPermtReqChildEntityTypes
	
	#region AccomStudPermtReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudPermtReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudPermtReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudPermtReqFilterBuilder : SqlFilterBuilder<AccomStudPermtReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudPermtReqFilterBuilder class.
		/// </summary>
		public AccomStudPermtReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudPermtReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudPermtReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudPermtReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudPermtReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudPermtReqFilterBuilder
	
	#region AccomStudPermtReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudPermtReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudPermtReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudPermtReqParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudPermtReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudPermtReqParameterBuilder class.
		/// </summary>
		public AccomStudPermtReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudPermtReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudPermtReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudPermtReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudPermtReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudPermtReqParameterBuilder
	
	#region AccomStudPermtReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudPermtReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudPermtReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudPermtReqSortBuilder : SqlSortBuilder<AccomStudPermtReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudPermtReqSqlSortBuilder class.
		/// </summary>
		public AccomStudPermtReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudPermtReqSortBuilder
	
} // end namespace
