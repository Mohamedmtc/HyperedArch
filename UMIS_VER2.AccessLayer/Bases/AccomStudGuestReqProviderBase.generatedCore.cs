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
	/// This class is the base class for any <see cref="AccomStudGuestReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudGuestReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudGuestReq, UMIS_VER2.BusinessLyer.AccomStudGuestReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudGuestReqKey key)
		{
			return Delete(transactionManager, key.AccomStudGuestReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudGuestReqId">طلب ضيافة "من خلال الطالب او مشرف السكن". Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudGuestReqId)
		{
			return Delete(null, _accomStudGuestReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqId">طلب ضيافة "من خلال الطالب او مشرف السكن". Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudGuestReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_GUEST_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		public TList<AccomStudGuestReq> GetByAccomStudBookId(System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(_accomStudBookId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_GUEST_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudGuestReq> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_GUEST_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		public TList<AccomStudGuestReq> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_ACCOM_STUD_BOOK key.
		///		fkAccomStudGuestReqAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		public TList<AccomStudGuestReq> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_ACCOM_STUD_BOOK key.
		///		fkAccomStudGuestReqAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		public TList<AccomStudGuestReq> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength,out int count)
		{
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_GUEST_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		public abstract TList<AccomStudGuestReq> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_GUEST_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId">:حالة الطلب
		/// 		/// معتمد 1
		/// 		/// مرفوض 2
		/// 		///  قيد الاجراء  1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		public TList<AccomStudGuestReq> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_GUEST_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">:حالة الطلب
		/// 		/// معتمد 1
		/// 		/// مرفوض 2
		/// 		///  قيد الاجراء  1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudGuestReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_GUEST_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">:حالة الطلب
		/// 		/// معتمد 1
		/// 		/// مرفوض 2
		/// 		///  قيد الاجراء  1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		public TList<AccomStudGuestReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_GS_CODE_REQ_STATUS key.
		///		fkAccomStudGuestReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId">:حالة الطلب
		/// 		/// معتمد 1
		/// 		/// مرفوض 2
		/// 		///  قيد الاجراء  1</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		public TList<AccomStudGuestReq> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_GS_CODE_REQ_STATUS key.
		///		fkAccomStudGuestReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId">:حالة الطلب
		/// 		/// معتمد 1
		/// 		/// مرفوض 2
		/// 		///  قيد الاجراء  1</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		public TList<AccomStudGuestReq> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_GUEST_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">:حالة الطلب
		/// 		/// معتمد 1
		/// 		/// مرفوض 2
		/// 		///  قيد الاجراء  1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReq objects.</returns>
		public abstract TList<AccomStudGuestReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudGuestReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudGuestReqKey key, int start, int pageLength)
		{
			return GetByAccomStudGuestReqId(transactionManager, key.AccomStudGuestReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="_accomStudGuestReqId">طلب ضيافة "من خلال الطالب او مشرف السكن"</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudGuestReq GetByAccomStudGuestReqId(System.Decimal _accomStudGuestReqId)
		{
			int count = -1;
			return GetByAccomStudGuestReqId(null,_accomStudGuestReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="_accomStudGuestReqId">طلب ضيافة "من خلال الطالب او مشرف السكن"</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudGuestReq GetByAccomStudGuestReqId(System.Decimal _accomStudGuestReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudGuestReqId(null, _accomStudGuestReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqId">طلب ضيافة "من خلال الطالب او مشرف السكن"</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudGuestReq GetByAccomStudGuestReqId(TransactionManager transactionManager, System.Decimal _accomStudGuestReqId)
		{
			int count = -1;
			return GetByAccomStudGuestReqId(transactionManager, _accomStudGuestReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqId">طلب ضيافة "من خلال الطالب او مشرف السكن"</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudGuestReq GetByAccomStudGuestReqId(TransactionManager transactionManager, System.Decimal _accomStudGuestReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudGuestReqId(transactionManager, _accomStudGuestReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="_accomStudGuestReqId">طلب ضيافة "من خلال الطالب او مشرف السكن"</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudGuestReq GetByAccomStudGuestReqId(System.Decimal _accomStudGuestReqId, int start, int pageLength, out int count)
		{
			return GetByAccomStudGuestReqId(null, _accomStudGuestReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqId">طلب ضيافة "من خلال الطالب او مشرف السكن"</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudGuestReq GetByAccomStudGuestReqId(TransactionManager transactionManager, System.Decimal _accomStudGuestReqId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="_fromDate">من تاريخ مدة المكوث</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AccomStudGuestReq&gt;"/> class.</returns>
		public TList<AccomStudGuestReq> GetByFromDateAccomStudBookId(System.DateTime? _fromDate, System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByFromDateAccomStudBookId(null,_fromDate, _accomStudBookId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="_fromDate">من تاريخ مدة المكوث</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AccomStudGuestReq&gt;"/> class.</returns>
		public TList<AccomStudGuestReq> GetByFromDateAccomStudBookId(System.DateTime? _fromDate, System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count = -1;
			return GetByFromDateAccomStudBookId(null, _fromDate, _accomStudBookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_fromDate">من تاريخ مدة المكوث</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AccomStudGuestReq&gt;"/> class.</returns>
		public TList<AccomStudGuestReq> GetByFromDateAccomStudBookId(TransactionManager transactionManager, System.DateTime? _fromDate, System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByFromDateAccomStudBookId(transactionManager, _fromDate, _accomStudBookId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_fromDate">من تاريخ مدة المكوث</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AccomStudGuestReq&gt;"/> class.</returns>
		public TList<AccomStudGuestReq> GetByFromDateAccomStudBookId(TransactionManager transactionManager, System.DateTime? _fromDate, System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count = -1;
			return GetByFromDateAccomStudBookId(transactionManager, _fromDate, _accomStudBookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="_fromDate">من تاريخ مدة المكوث</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AccomStudGuestReq&gt;"/> class.</returns>
		public TList<AccomStudGuestReq> GetByFromDateAccomStudBookId(System.DateTime? _fromDate, System.Decimal _accomStudBookId, int start, int pageLength, out int count)
		{
			return GetByFromDateAccomStudBookId(null, _fromDate, _accomStudBookId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_GUEST_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_fromDate">من تاريخ مدة المكوث</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AccomStudGuestReq&gt;"/> class.</returns>
		public abstract TList<AccomStudGuestReq> GetByFromDateAccomStudBookId(TransactionManager transactionManager, System.DateTime? _fromDate, System.Decimal _accomStudBookId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudGuestReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudGuestReq&gt;"/></returns>
		public static TList<AccomStudGuestReq> Fill(IDataReader reader, TList<AccomStudGuestReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudGuestReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudGuestReq")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_GUEST_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudGuestReq>(
					key.ToString(), // EntityTrackingKey
					"AccomStudGuestReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudGuestReq();
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
					c.AccomStudGuestReqId = (System.Decimal)reader["ACCOM_STUD_GUEST_REQ_ID"];
					c.OriginalAccomStudGuestReqId = c.AccomStudGuestReqId;
					c.AccomStudBookId = (System.Decimal)reader["ACCOM_STUD_BOOK_ID"];
					c.GsCodeReqStatusId = Convert.IsDBNull(reader["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)reader["GS_CODE_REQ_STATUS_ID"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Int32?)reader["APPROVE_FLG"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudGuestReq entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudGuestReqId = (System.Decimal)reader[((int)AccomStudGuestReqColumn.AccomStudGuestReqId - 1)];
			entity.OriginalAccomStudGuestReqId = (System.Decimal)reader["ACCOM_STUD_GUEST_REQ_ID"];
			entity.AccomStudBookId = (System.Decimal)reader[((int)AccomStudGuestReqColumn.AccomStudBookId - 1)];
			entity.GsCodeReqStatusId = (reader.IsDBNull(((int)AccomStudGuestReqColumn.GsCodeReqStatusId - 1)))?null:(System.Decimal?)reader[((int)AccomStudGuestReqColumn.GsCodeReqStatusId - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)AccomStudGuestReqColumn.ApproveFlg - 1)))?null:(System.Int32?)reader[((int)AccomStudGuestReqColumn.ApproveFlg - 1)];
			entity.FromDate = (reader.IsDBNull(((int)AccomStudGuestReqColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudGuestReqColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)AccomStudGuestReqColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudGuestReqColumn.ToDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)AccomStudGuestReqColumn.Notes - 1)))?null:(System.String)reader[((int)AccomStudGuestReqColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudGuestReqColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudGuestReqColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudGuestReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudGuestReqColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudGuestReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudGuestReqId = (System.Decimal)dataRow["ACCOM_STUD_GUEST_REQ_ID"];
			entity.OriginalAccomStudGuestReqId = (System.Decimal)dataRow["ACCOM_STUD_GUEST_REQ_ID"];
			entity.AccomStudBookId = (System.Decimal)dataRow["ACCOM_STUD_BOOK_ID"];
			entity.GsCodeReqStatusId = Convert.IsDBNull(dataRow["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Int32?)dataRow["APPROVE_FLG"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudGuestReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudGuestReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCodeReqStatusIdSource	
			if (CanDeepLoad(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReqStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeReqStatusId ?? 0.0m);
				GsCodeReqStatus tmpEntity = EntityManager.LocateEntity<GsCodeReqStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReqStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReqStatusIdSource = tmpEntity;
				else
					entity.GsCodeReqStatusIdSource = DataRepository.GsCodeReqStatusProvider.GetByGsCodeReqStatusId(transactionManager, (entity.GsCodeReqStatusId ?? 0.0m));		
				
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
			// Deep load child collections  - Call GetByAccomStudGuestReqId methods when available
			
			#region AccomStudGuestReqDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudGuestReqDtl>|AccomStudGuestReqDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudGuestReqDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudGuestReqDtlCollection = DataRepository.AccomStudGuestReqDtlProvider.GetByAccomStudGuestReqId(transactionManager, entity.AccomStudGuestReqId);

				if (deep && entity.AccomStudGuestReqDtlCollection.Count > 0)
				{
					deepHandles.Add("AccomStudGuestReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudGuestReqDtl>) DataRepository.AccomStudGuestReqDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudGuestReqDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudGuestReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudGuestReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudGuestReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudGuestReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AccomStudGuestReqDtl>
				if (CanDeepSave(entity.AccomStudGuestReqDtlCollection, "List<AccomStudGuestReqDtl>|AccomStudGuestReqDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudGuestReqDtl child in entity.AccomStudGuestReqDtlCollection)
					{
						if(child.AccomStudGuestReqIdSource != null)
						{
							child.AccomStudGuestReqId = child.AccomStudGuestReqIdSource.AccomStudGuestReqId;
						}
						else
						{
							child.AccomStudGuestReqId = entity.AccomStudGuestReqId;
						}

					}

					if (entity.AccomStudGuestReqDtlCollection.Count > 0 || entity.AccomStudGuestReqDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudGuestReqDtlProvider.Save(transactionManager, entity.AccomStudGuestReqDtlCollection);
						
						deepHandles.Add("AccomStudGuestReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudGuestReqDtl >) DataRepository.AccomStudGuestReqDtlProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudGuestReqDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomStudGuestReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudGuestReq</c>
	///</summary>
	public enum AccomStudGuestReqChildEntityTypes
	{
		
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
		///<summary>
		/// Collection of <c>AccomStudGuestReq</c> as OneToMany for AccomStudGuestReqDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudGuestReqDtl>))]
		AccomStudGuestReqDtlCollection,
	}
	
	#endregion AccomStudGuestReqChildEntityTypes
	
	#region AccomStudGuestReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudGuestReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudGuestReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudGuestReqFilterBuilder : SqlFilterBuilder<AccomStudGuestReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqFilterBuilder class.
		/// </summary>
		public AccomStudGuestReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudGuestReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudGuestReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudGuestReqFilterBuilder
	
	#region AccomStudGuestReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudGuestReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudGuestReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudGuestReqParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudGuestReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqParameterBuilder class.
		/// </summary>
		public AccomStudGuestReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudGuestReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudGuestReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudGuestReqParameterBuilder
	
	#region AccomStudGuestReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudGuestReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudGuestReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudGuestReqSortBuilder : SqlSortBuilder<AccomStudGuestReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqSqlSortBuilder class.
		/// </summary>
		public AccomStudGuestReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudGuestReqSortBuilder
	
} // end namespace
