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
	/// This class is the base class for any <see cref="PgAttchdDocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgAttchdDocProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgAttchdDoc, UMIS_VER2.BusinessLyer.PgAttchdDocKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgAttchdDocKey key)
		{
			return Delete(transactionManager, key.PgAttchdDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgAttchdDocId">مرفقات الرسالة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgAttchdDocId)
		{
			return Delete(null, _pgAttchdDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgAttchdDocId">مرفقات الرسالة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgAttchdDocId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_GS_CODE_APPROVAL_FUNC key.
		///		FK_PG_ATTCHD_DOC_GS_CODE_APPROVAL_FUNC Description: 
		/// </summary>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByGsCodeApprovalFuncId(System.Decimal? _gsCodeApprovalFuncId)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(_gsCodeApprovalFuncId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_GS_CODE_APPROVAL_FUNC key.
		///		FK_PG_ATTCHD_DOC_GS_CODE_APPROVAL_FUNC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal? _gsCodeApprovalFuncId)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(transactionManager, _gsCodeApprovalFuncId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_GS_CODE_APPROVAL_FUNC key.
		///		FK_PG_ATTCHD_DOC_GS_CODE_APPROVAL_FUNC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal? _gsCodeApprovalFuncId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalFuncId(transactionManager, _gsCodeApprovalFuncId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_GS_CODE_APPROVAL_FUNC key.
		///		fkPgAttchdDocGsCodeApprovalFunc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByGsCodeApprovalFuncId(System.Decimal? _gsCodeApprovalFuncId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeApprovalFuncId(null, _gsCodeApprovalFuncId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_GS_CODE_APPROVAL_FUNC key.
		///		fkPgAttchdDocGsCodeApprovalFunc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByGsCodeApprovalFuncId(System.Decimal? _gsCodeApprovalFuncId, int start, int pageLength,out int count)
		{
			return GetByGsCodeApprovalFuncId(null, _gsCodeApprovalFuncId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_GS_CODE_APPROVAL_FUNC key.
		///		FK_PG_ATTCHD_DOC_GS_CODE_APPROVAL_FUNC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalFuncId">اسم الوظيفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByGsCodeApprovalFuncId(TransactionManager transactionManager, System.Decimal? _gsCodeApprovalFuncId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_CONFERENCE key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_CONFERENCE Description: 
		/// </summary>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudConferenceId(System.Decimal? _pgStudConferenceId)
		{
			int count = -1;
			return GetByPgStudConferenceId(_pgStudConferenceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_CONFERENCE key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_CONFERENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgStudConferenceId(TransactionManager transactionManager, System.Decimal? _pgStudConferenceId)
		{
			int count = -1;
			return GetByPgStudConferenceId(transactionManager, _pgStudConferenceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_CONFERENCE key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_CONFERENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudConferenceId(TransactionManager transactionManager, System.Decimal? _pgStudConferenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudConferenceId(transactionManager, _pgStudConferenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_CONFERENCE key.
		///		fkPgAttchdDocPgStudConference Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudConferenceId(System.Decimal? _pgStudConferenceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgStudConferenceId(null, _pgStudConferenceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_CONFERENCE key.
		///		fkPgAttchdDocPgStudConference Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudConferenceId(System.Decimal? _pgStudConferenceId, int start, int pageLength,out int count)
		{
			return GetByPgStudConferenceId(null, _pgStudConferenceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_CONFERENCE key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_CONFERENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudConferenceId">تسجيل بيانات حضور المؤتمرات العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgStudConferenceId(TransactionManager transactionManager, System.Decimal? _pgStudConferenceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_PUBLISH key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_PUBLISH Description: 
		/// </summary>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudPublishId(System.Decimal? _pgStudPublishId)
		{
			int count = -1;
			return GetByPgStudPublishId(_pgStudPublishId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_PUBLISH key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_PUBLISH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgStudPublishId(TransactionManager transactionManager, System.Decimal? _pgStudPublishId)
		{
			int count = -1;
			return GetByPgStudPublishId(transactionManager, _pgStudPublishId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_PUBLISH key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_PUBLISH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudPublishId(TransactionManager transactionManager, System.Decimal? _pgStudPublishId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudPublishId(transactionManager, _pgStudPublishId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_PUBLISH key.
		///		fkPgAttchdDocPgStudPublish Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudPublishId(System.Decimal? _pgStudPublishId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgStudPublishId(null, _pgStudPublishId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_PUBLISH key.
		///		fkPgAttchdDocPgStudPublish Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudPublishId(System.Decimal? _pgStudPublishId, int start, int pageLength,out int count)
		{
			return GetByPgStudPublishId(null, _pgStudPublishId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_PUBLISH key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_PUBLISH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudPublishId">تسجيل بيانات نشر بحث علمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgStudPublishId(TransactionManager transactionManager, System.Decimal? _pgStudPublishId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudTravelId(System.Decimal? _pgStudTravelId)
		{
			int count = -1;
			return GetByPgStudTravelId(_pgStudTravelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal? _pgStudTravelId)
		{
			int count = -1;
			return GetByPgStudTravelId(transactionManager, _pgStudTravelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal? _pgStudTravelId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudTravelId(transactionManager, _pgStudTravelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL key.
		///		fkPgAttchdDocPgStudTravel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudTravelId(System.Decimal? _pgStudTravelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgStudTravelId(null, _pgStudTravelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL key.
		///		fkPgAttchdDocPgStudTravel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudTravelId(System.Decimal? _pgStudTravelId, int start, int pageLength,out int count)
		{
			return GetByPgStudTravelId(null, _pgStudTravelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelId">سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgStudTravelId(TransactionManager transactionManager, System.Decimal? _pgStudTravelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL_EXTEND key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL_EXTEND Description: 
		/// </summary>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudTravelExtendId(System.Decimal? _pgStudTravelExtendId)
		{
			int count = -1;
			return GetByPgStudTravelExtendId(_pgStudTravelExtendId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL_EXTEND key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgStudTravelExtendId(TransactionManager transactionManager, System.Decimal? _pgStudTravelExtendId)
		{
			int count = -1;
			return GetByPgStudTravelExtendId(transactionManager, _pgStudTravelExtendId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL_EXTEND key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudTravelExtendId(TransactionManager transactionManager, System.Decimal? _pgStudTravelExtendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgStudTravelExtendId(transactionManager, _pgStudTravelExtendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL_EXTEND key.
		///		fkPgAttchdDocPgStudTravelExtend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudTravelExtendId(System.Decimal? _pgStudTravelExtendId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgStudTravelExtendId(null, _pgStudTravelExtendId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL_EXTEND key.
		///		fkPgAttchdDocPgStudTravelExtend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgStudTravelExtendId(System.Decimal? _pgStudTravelExtendId, int start, int pageLength,out int count)
		{
			return GetByPgStudTravelExtendId(null, _pgStudTravelExtendId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL_EXTEND key.
		///		FK_PG_ATTCHD_DOC_PG_STUD_TRAVEL_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgStudTravelExtendId">مد سفر الطلاب للخارج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgStudTravelExtendId(TransactionManager transactionManager, System.Decimal? _pgStudTravelExtendId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommId(System.Decimal? _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(_pgThesisCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal? _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal? _pgThesisCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM key.
		///		fkPgAttchdDocPgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommId(System.Decimal? _pgThesisCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM key.
		///		fkPgAttchdDocPgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommId(System.Decimal? _pgThesisCommId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal? _pgThesisCommId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommRecommendId(System.Decimal? _pgThesisCommRecommendId)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(_pgThesisCommRecommendId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal? _pgThesisCommRecommendId)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(transactionManager, _pgThesisCommRecommendId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal? _pgThesisCommRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(transactionManager, _pgThesisCommRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RECOMMEND key.
		///		fkPgAttchdDocPgThesisCommRecommend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommRecommendId(System.Decimal? _pgThesisCommRecommendId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommRecommendId(null, _pgThesisCommRecommendId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RECOMMEND key.
		///		fkPgAttchdDocPgThesisCommRecommend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommRecommendId(System.Decimal? _pgThesisCommRecommendId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommRecommendId(null, _pgThesisCommRecommendId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal? _pgThesisCommRecommendId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RPT Description: 
		/// </summary>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommRptId(System.Decimal? _pgThesisCommRptId)
		{
			int count = -1;
			return GetByPgThesisCommRptId(_pgThesisCommRptId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgThesisCommRptId(TransactionManager transactionManager, System.Decimal? _pgThesisCommRptId)
		{
			int count = -1;
			return GetByPgThesisCommRptId(transactionManager, _pgThesisCommRptId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommRptId(TransactionManager transactionManager, System.Decimal? _pgThesisCommRptId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommRptId(transactionManager, _pgThesisCommRptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RPT key.
		///		fkPgAttchdDocPgThesisCommRpt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommRptId(System.Decimal? _pgThesisCommRptId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommRptId(null, _pgThesisCommRptId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RPT key.
		///		fkPgAttchdDocPgThesisCommRpt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisCommRptId(System.Decimal? _pgThesisCommRptId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommRptId(null, _pgThesisCommRptId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_COMM_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRptId">تقارير لجنة التحكيم:
		/// 		/// في حالة منح الدرجة يتم تسجيل الأتى
		/// 		/// 
		/// 		/// 
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgThesisCommRptId(TransactionManager transactionManager, System.Decimal? _pgThesisCommRptId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_GRANT_DEGREE key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_GRANT_DEGREE Description: 
		/// </summary>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisGrantDegreeId(System.Decimal _pgThesisGrantDegreeId)
		{
			int count = -1;
			return GetByPgThesisGrantDegreeId(_pgThesisGrantDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_GRANT_DEGREE key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_GRANT_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgThesisGrantDegreeId(TransactionManager transactionManager, System.Decimal _pgThesisGrantDegreeId)
		{
			int count = -1;
			return GetByPgThesisGrantDegreeId(transactionManager, _pgThesisGrantDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_GRANT_DEGREE key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_GRANT_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisGrantDegreeId(TransactionManager transactionManager, System.Decimal _pgThesisGrantDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGrantDegreeId(transactionManager, _pgThesisGrantDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_GRANT_DEGREE key.
		///		fkPgAttchdDocPgThesisGrantDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisGrantDegreeId(System.Decimal _pgThesisGrantDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisGrantDegreeId(null, _pgThesisGrantDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_GRANT_DEGREE key.
		///		fkPgAttchdDocPgThesisGrantDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisGrantDegreeId(System.Decimal _pgThesisGrantDegreeId, int start, int pageLength,out int count)
		{
			return GetByPgThesisGrantDegreeId(null, _pgThesisGrantDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_GRANT_DEGREE key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_GRANT_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgThesisGrantDegreeId(TransactionManager transactionManager, System.Decimal _pgThesisGrantDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SEMINAR key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_SEMINAR Description: 
		/// </summary>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisSeminarId(System.Decimal? _pgThesisSeminarId)
		{
			int count = -1;
			return GetByPgThesisSeminarId(_pgThesisSeminarId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SEMINAR key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_SEMINAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgThesisSeminarId(TransactionManager transactionManager, System.Decimal? _pgThesisSeminarId)
		{
			int count = -1;
			return GetByPgThesisSeminarId(transactionManager, _pgThesisSeminarId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SEMINAR key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_SEMINAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisSeminarId(TransactionManager transactionManager, System.Decimal? _pgThesisSeminarId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSeminarId(transactionManager, _pgThesisSeminarId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SEMINAR key.
		///		fkPgAttchdDocPgThesisSeminar Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisSeminarId(System.Decimal? _pgThesisSeminarId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisSeminarId(null, _pgThesisSeminarId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SEMINAR key.
		///		fkPgAttchdDocPgThesisSeminar Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisSeminarId(System.Decimal? _pgThesisSeminarId, int start, int pageLength,out int count)
		{
			return GetByPgThesisSeminarId(null, _pgThesisSeminarId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SEMINAR key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_SEMINAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSeminarId">تسجيل الندوة التعريفية (السيمينار)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgThesisSeminarId(TransactionManager transactionManager, System.Decimal? _pgThesisSeminarId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudId(System.Decimal? _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD key.
		///		fkPgAttchdDocPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudId(System.Decimal? _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD key.
		///		fkPgAttchdDocPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudId(System.Decimal? _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_EXTEND key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD_EXTEND Description: 
		/// </summary>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudExtendId(System.Decimal? _pgThesisStudExtendId)
		{
			int count = -1;
			return GetByPgThesisStudExtendId(_pgThesisStudExtendId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_EXTEND key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgThesisStudExtendId(TransactionManager transactionManager, System.Decimal? _pgThesisStudExtendId)
		{
			int count = -1;
			return GetByPgThesisStudExtendId(transactionManager, _pgThesisStudExtendId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_EXTEND key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudExtendId(TransactionManager transactionManager, System.Decimal? _pgThesisStudExtendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudExtendId(transactionManager, _pgThesisStudExtendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_EXTEND key.
		///		fkPgAttchdDocPgThesisStudExtend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudExtendId(System.Decimal? _pgThesisStudExtendId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudExtendId(null, _pgThesisStudExtendId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_EXTEND key.
		///		fkPgAttchdDocPgThesisStudExtend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudExtendId(System.Decimal? _pgThesisStudExtendId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudExtendId(null, _pgThesisStudExtendId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_EXTEND key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD_EXTEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudExtendId">مد الفترة القانونية لتسجيل الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgThesisStudExtendId(TransactionManager transactionManager, System.Decimal? _pgThesisStudExtendId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD_RSRCH_STRTGY Description: 
		/// </summary>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudRsrchStrtgyId(System.Decimal? _pgThesisStudRsrchStrtgyId)
		{
			int count = -1;
			return GetByPgThesisStudRsrchStrtgyId(_pgThesisStudRsrchStrtgyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD_RSRCH_STRTGY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgThesisStudRsrchStrtgyId(TransactionManager transactionManager, System.Decimal? _pgThesisStudRsrchStrtgyId)
		{
			int count = -1;
			return GetByPgThesisStudRsrchStrtgyId(transactionManager, _pgThesisStudRsrchStrtgyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD_RSRCH_STRTGY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudRsrchStrtgyId(TransactionManager transactionManager, System.Decimal? _pgThesisStudRsrchStrtgyId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudRsrchStrtgyId(transactionManager, _pgThesisStudRsrchStrtgyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		fkPgAttchdDocPgThesisStudRsrchStrtgy Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudRsrchStrtgyId(System.Decimal? _pgThesisStudRsrchStrtgyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudRsrchStrtgyId(null, _pgThesisStudRsrchStrtgyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		fkPgAttchdDocPgThesisStudRsrchStrtgy Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisStudRsrchStrtgyId(System.Decimal? _pgThesisStudRsrchStrtgyId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudRsrchStrtgyId(null, _pgThesisStudRsrchStrtgyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_STUD_RSRCH_STRTGY key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_STUD_RSRCH_STRTGY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgThesisStudRsrchStrtgyId(TransactionManager transactionManager, System.Decimal? _pgThesisStudRsrchStrtgyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SUPERVISOR_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_SUPERVISOR_RPT Description: 
		/// </summary>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisSupervisorRptId(System.Decimal? _pgThesisSupervisorRptId)
		{
			int count = -1;
			return GetByPgThesisSupervisorRptId(_pgThesisSupervisorRptId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SUPERVISOR_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_SUPERVISOR_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgThesisSupervisorRptId(TransactionManager transactionManager, System.Decimal? _pgThesisSupervisorRptId)
		{
			int count = -1;
			return GetByPgThesisSupervisorRptId(transactionManager, _pgThesisSupervisorRptId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SUPERVISOR_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_SUPERVISOR_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisSupervisorRptId(TransactionManager transactionManager, System.Decimal? _pgThesisSupervisorRptId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSupervisorRptId(transactionManager, _pgThesisSupervisorRptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SUPERVISOR_RPT key.
		///		fkPgAttchdDocPgThesisSupervisorRpt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisSupervisorRptId(System.Decimal? _pgThesisSupervisorRptId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisSupervisorRptId(null, _pgThesisSupervisorRptId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SUPERVISOR_RPT key.
		///		fkPgAttchdDocPgThesisSupervisorRpt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisSupervisorRptId(System.Decimal? _pgThesisSupervisorRptId, int start, int pageLength,out int count)
		{
			return GetByPgThesisSupervisorRptId(null, _pgThesisSupervisorRptId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_SUPERVISOR_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_SUPERVISOR_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorRptId">تقارير  لجنة الاشراف الدورية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgThesisSupervisorRptId(TransactionManager transactionManager, System.Decimal? _pgThesisSupervisorRptId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_VALIDITY_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_VALIDITY_RPT Description: 
		/// </summary>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisValidityRptId(System.Decimal? _pgThesisValidityRptId)
		{
			int count = -1;
			return GetByPgThesisValidityRptId(_pgThesisValidityRptId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_VALIDITY_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_VALIDITY_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<PgAttchdDoc> GetByPgThesisValidityRptId(TransactionManager transactionManager, System.Decimal? _pgThesisValidityRptId)
		{
			int count = -1;
			return GetByPgThesisValidityRptId(transactionManager, _pgThesisValidityRptId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_VALIDITY_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_VALIDITY_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisValidityRptId(TransactionManager transactionManager, System.Decimal? _pgThesisValidityRptId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisValidityRptId(transactionManager, _pgThesisValidityRptId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_VALIDITY_RPT key.
		///		fkPgAttchdDocPgThesisValidityRpt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisValidityRptId(System.Decimal? _pgThesisValidityRptId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisValidityRptId(null, _pgThesisValidityRptId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_VALIDITY_RPT key.
		///		fkPgAttchdDocPgThesisValidityRpt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public TList<PgAttchdDoc> GetByPgThesisValidityRptId(System.Decimal? _pgThesisValidityRptId, int start, int pageLength,out int count)
		{
			return GetByPgThesisValidityRptId(null, _pgThesisValidityRptId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_ATTCHD_DOC_PG_THESIS_VALIDITY_RPT key.
		///		FK_PG_ATTCHD_DOC_PG_THESIS_VALIDITY_RPT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisValidityRptId">تقرير صلاحية الرسالة للمناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgAttchdDoc objects.</returns>
		public abstract TList<PgAttchdDoc> GetByPgThesisValidityRptId(TransactionManager transactionManager, System.Decimal? _pgThesisValidityRptId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgAttchdDoc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgAttchdDocKey key, int start, int pageLength)
		{
			return GetByPgAttchdDocId(transactionManager, key.PgAttchdDocId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_ATTCHD_DOC index.
		/// </summary>
		/// <param name="_pgAttchdDocId">مرفقات الرسالة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgAttchdDoc GetByPgAttchdDocId(System.Decimal _pgAttchdDocId)
		{
			int count = -1;
			return GetByPgAttchdDocId(null,_pgAttchdDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_ATTCHD_DOC index.
		/// </summary>
		/// <param name="_pgAttchdDocId">مرفقات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgAttchdDoc GetByPgAttchdDocId(System.Decimal _pgAttchdDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgAttchdDocId(null, _pgAttchdDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_ATTCHD_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgAttchdDocId">مرفقات الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgAttchdDoc GetByPgAttchdDocId(TransactionManager transactionManager, System.Decimal _pgAttchdDocId)
		{
			int count = -1;
			return GetByPgAttchdDocId(transactionManager, _pgAttchdDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_ATTCHD_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgAttchdDocId">مرفقات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgAttchdDoc GetByPgAttchdDocId(TransactionManager transactionManager, System.Decimal _pgAttchdDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgAttchdDocId(transactionManager, _pgAttchdDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_ATTCHD_DOC index.
		/// </summary>
		/// <param name="_pgAttchdDocId">مرفقات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgAttchdDoc GetByPgAttchdDocId(System.Decimal _pgAttchdDocId, int start, int pageLength, out int count)
		{
			return GetByPgAttchdDocId(null, _pgAttchdDocId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_ATTCHD_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgAttchdDocId">مرفقات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgAttchdDoc GetByPgAttchdDocId(TransactionManager transactionManager, System.Decimal _pgAttchdDocId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgAttchdDoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgAttchdDoc&gt;"/></returns>
		public static TList<PgAttchdDoc> Fill(IDataReader reader, TList<PgAttchdDoc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgAttchdDoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgAttchdDoc")
					.Append("|").Append((System.Decimal)reader["PG_ATTCHD_DOC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgAttchdDoc>(
					key.ToString(), // EntityTrackingKey
					"PgAttchdDoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgAttchdDoc();
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
					c.PgAttchdDocId = (System.Decimal)reader["PG_ATTCHD_DOC_ID"];
					c.OriginalPgAttchdDocId = c.PgAttchdDocId;
					c.GsCodeApprovalFuncId = Convert.IsDBNull(reader["GS_CODE_APPROVAL_FUNC_ID"]) ? null : (System.Decimal?)reader["GS_CODE_APPROVAL_FUNC_ID"];
					c.PgThesisStudId = Convert.IsDBNull(reader["PG_THESIS_STUD_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_STUD_ID"];
					c.PgThesisCommId = Convert.IsDBNull(reader["PG_THESIS_COMM_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_COMM_ID"];
					c.PgThesisSupervisorRptId = Convert.IsDBNull(reader["PG_THESIS_SUPERVISOR_RPT_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_SUPERVISOR_RPT_ID"];
					c.PgThesisStudRsrchStrtgyId = Convert.IsDBNull(reader["PG_THESIS_STUD_RSRCH_STRTGY_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_STUD_RSRCH_STRTGY_ID"];
					c.PgThesisSeminarId = Convert.IsDBNull(reader["PG_THESIS_SEMINAR_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_SEMINAR_ID"];
					c.PgThesisStudExtendId = Convert.IsDBNull(reader["PG_THESIS_STUD_EXTEND_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_STUD_EXTEND_ID"];
					c.PgStudConferenceId = Convert.IsDBNull(reader["PG_STUD_CONFERENCE_ID"]) ? null : (System.Decimal?)reader["PG_STUD_CONFERENCE_ID"];
					c.PgStudPublishId = Convert.IsDBNull(reader["PG_STUD_PUBLISH_ID"]) ? null : (System.Decimal?)reader["PG_STUD_PUBLISH_ID"];
					c.PgStudTravelId = Convert.IsDBNull(reader["PG_STUD_TRAVEL_ID"]) ? null : (System.Decimal?)reader["PG_STUD_TRAVEL_ID"];
					c.PgStudTravelExtendId = Convert.IsDBNull(reader["PG_STUD_TRAVEL_EXTEND_ID"]) ? null : (System.Decimal?)reader["PG_STUD_TRAVEL_EXTEND_ID"];
					c.PgThesisValidityRptId = Convert.IsDBNull(reader["PG_THESIS_VALIDITY_RPT_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_VALIDITY_RPT_ID"];
					c.PgThesisCommRecommendId = Convert.IsDBNull(reader["PG_THESIS_COMM_RECOMMEND_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_COMM_RECOMMEND_ID"];
					c.PgThesisCommRptId = Convert.IsDBNull(reader["PG_THESIS_COMM_RPT_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_COMM_RPT_ID"];
					c.PgThesisGrantDegreeId = (System.Decimal)reader["PG_THESIS_GRANT_DEGREE_ID"];
					c.DocNotes = Convert.IsDBNull(reader["DOC_NOTES"]) ? null : (System.String)reader["DOC_NOTES"];
					c.AttchdDocPath = (System.String)reader["ATTCHD_DOC_PATH"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgAttchdDoc entity)
		{
			if (!reader.Read()) return;
			
			entity.PgAttchdDocId = (System.Decimal)reader[((int)PgAttchdDocColumn.PgAttchdDocId - 1)];
			entity.OriginalPgAttchdDocId = (System.Decimal)reader["PG_ATTCHD_DOC_ID"];
			entity.GsCodeApprovalFuncId = (reader.IsDBNull(((int)PgAttchdDocColumn.GsCodeApprovalFuncId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.GsCodeApprovalFuncId - 1)];
			entity.PgThesisStudId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgThesisStudId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgThesisStudId - 1)];
			entity.PgThesisCommId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgThesisCommId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgThesisCommId - 1)];
			entity.PgThesisSupervisorRptId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgThesisSupervisorRptId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgThesisSupervisorRptId - 1)];
			entity.PgThesisStudRsrchStrtgyId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgThesisStudRsrchStrtgyId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgThesisStudRsrchStrtgyId - 1)];
			entity.PgThesisSeminarId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgThesisSeminarId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgThesisSeminarId - 1)];
			entity.PgThesisStudExtendId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgThesisStudExtendId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgThesisStudExtendId - 1)];
			entity.PgStudConferenceId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgStudConferenceId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgStudConferenceId - 1)];
			entity.PgStudPublishId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgStudPublishId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgStudPublishId - 1)];
			entity.PgStudTravelId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgStudTravelId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgStudTravelId - 1)];
			entity.PgStudTravelExtendId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgStudTravelExtendId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgStudTravelExtendId - 1)];
			entity.PgThesisValidityRptId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgThesisValidityRptId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgThesisValidityRptId - 1)];
			entity.PgThesisCommRecommendId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgThesisCommRecommendId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgThesisCommRecommendId - 1)];
			entity.PgThesisCommRptId = (reader.IsDBNull(((int)PgAttchdDocColumn.PgThesisCommRptId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.PgThesisCommRptId - 1)];
			entity.PgThesisGrantDegreeId = (System.Decimal)reader[((int)PgAttchdDocColumn.PgThesisGrantDegreeId - 1)];
			entity.DocNotes = (reader.IsDBNull(((int)PgAttchdDocColumn.DocNotes - 1)))?null:(System.String)reader[((int)PgAttchdDocColumn.DocNotes - 1)];
			entity.AttchdDocPath = (System.String)reader[((int)PgAttchdDocColumn.AttchdDocPath - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgAttchdDocColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgAttchdDocColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgAttchdDocColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgAttchdDocColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgAttchdDoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgAttchdDocId = (System.Decimal)dataRow["PG_ATTCHD_DOC_ID"];
			entity.OriginalPgAttchdDocId = (System.Decimal)dataRow["PG_ATTCHD_DOC_ID"];
			entity.GsCodeApprovalFuncId = Convert.IsDBNull(dataRow["GS_CODE_APPROVAL_FUNC_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_APPROVAL_FUNC_ID"];
			entity.PgThesisStudId = Convert.IsDBNull(dataRow["PG_THESIS_STUD_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_STUD_ID"];
			entity.PgThesisCommId = Convert.IsDBNull(dataRow["PG_THESIS_COMM_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_COMM_ID"];
			entity.PgThesisSupervisorRptId = Convert.IsDBNull(dataRow["PG_THESIS_SUPERVISOR_RPT_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_SUPERVISOR_RPT_ID"];
			entity.PgThesisStudRsrchStrtgyId = Convert.IsDBNull(dataRow["PG_THESIS_STUD_RSRCH_STRTGY_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_STUD_RSRCH_STRTGY_ID"];
			entity.PgThesisSeminarId = Convert.IsDBNull(dataRow["PG_THESIS_SEMINAR_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_SEMINAR_ID"];
			entity.PgThesisStudExtendId = Convert.IsDBNull(dataRow["PG_THESIS_STUD_EXTEND_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_STUD_EXTEND_ID"];
			entity.PgStudConferenceId = Convert.IsDBNull(dataRow["PG_STUD_CONFERENCE_ID"]) ? null : (System.Decimal?)dataRow["PG_STUD_CONFERENCE_ID"];
			entity.PgStudPublishId = Convert.IsDBNull(dataRow["PG_STUD_PUBLISH_ID"]) ? null : (System.Decimal?)dataRow["PG_STUD_PUBLISH_ID"];
			entity.PgStudTravelId = Convert.IsDBNull(dataRow["PG_STUD_TRAVEL_ID"]) ? null : (System.Decimal?)dataRow["PG_STUD_TRAVEL_ID"];
			entity.PgStudTravelExtendId = Convert.IsDBNull(dataRow["PG_STUD_TRAVEL_EXTEND_ID"]) ? null : (System.Decimal?)dataRow["PG_STUD_TRAVEL_EXTEND_ID"];
			entity.PgThesisValidityRptId = Convert.IsDBNull(dataRow["PG_THESIS_VALIDITY_RPT_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_VALIDITY_RPT_ID"];
			entity.PgThesisCommRecommendId = Convert.IsDBNull(dataRow["PG_THESIS_COMM_RECOMMEND_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_COMM_RECOMMEND_ID"];
			entity.PgThesisCommRptId = Convert.IsDBNull(dataRow["PG_THESIS_COMM_RPT_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_COMM_RPT_ID"];
			entity.PgThesisGrantDegreeId = (System.Decimal)dataRow["PG_THESIS_GRANT_DEGREE_ID"];
			entity.DocNotes = Convert.IsDBNull(dataRow["DOC_NOTES"]) ? null : (System.String)dataRow["DOC_NOTES"];
			entity.AttchdDocPath = (System.String)dataRow["ATTCHD_DOC_PATH"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgAttchdDoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgAttchdDoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgAttchdDoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeApprovalFuncIdSource	
			if (CanDeepLoad(entity, "GsCodeApprovalFunc|GsCodeApprovalFuncIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalFuncIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeApprovalFuncId ?? 0.0m);
				GsCodeApprovalFunc tmpEntity = EntityManager.LocateEntity<GsCodeApprovalFunc>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApprovalFunc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalFuncIdSource = tmpEntity;
				else
					entity.GsCodeApprovalFuncIdSource = DataRepository.GsCodeApprovalFuncProvider.GetByGsCodeApprovalFuncId(transactionManager, (entity.GsCodeApprovalFuncId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalFuncIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalFuncIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalFuncProvider.DeepLoad(transactionManager, entity.GsCodeApprovalFuncIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalFuncIdSource

			#region PgStudConferenceIdSource	
			if (CanDeepLoad(entity, "PgStudConference|PgStudConferenceIdSource", deepLoadType, innerList) 
				&& entity.PgStudConferenceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgStudConferenceId ?? 0.0m);
				PgStudConference tmpEntity = EntityManager.LocateEntity<PgStudConference>(EntityLocator.ConstructKeyFromPkItems(typeof(PgStudConference), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgStudConferenceIdSource = tmpEntity;
				else
					entity.PgStudConferenceIdSource = DataRepository.PgStudConferenceProvider.GetByPgStudConferenceId(transactionManager, (entity.PgStudConferenceId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudConferenceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgStudConferenceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgStudConferenceProvider.DeepLoad(transactionManager, entity.PgStudConferenceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgStudConferenceIdSource

			#region PgStudPublishIdSource	
			if (CanDeepLoad(entity, "PgStudPublish|PgStudPublishIdSource", deepLoadType, innerList) 
				&& entity.PgStudPublishIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgStudPublishId ?? 0.0m);
				PgStudPublish tmpEntity = EntityManager.LocateEntity<PgStudPublish>(EntityLocator.ConstructKeyFromPkItems(typeof(PgStudPublish), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgStudPublishIdSource = tmpEntity;
				else
					entity.PgStudPublishIdSource = DataRepository.PgStudPublishProvider.GetByPgStudPublishId(transactionManager, (entity.PgStudPublishId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudPublishIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgStudPublishIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgStudPublishProvider.DeepLoad(transactionManager, entity.PgStudPublishIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgStudPublishIdSource

			#region PgStudTravelIdSource	
			if (CanDeepLoad(entity, "PgStudTravel|PgStudTravelIdSource", deepLoadType, innerList) 
				&& entity.PgStudTravelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgStudTravelId ?? 0.0m);
				PgStudTravel tmpEntity = EntityManager.LocateEntity<PgStudTravel>(EntityLocator.ConstructKeyFromPkItems(typeof(PgStudTravel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgStudTravelIdSource = tmpEntity;
				else
					entity.PgStudTravelIdSource = DataRepository.PgStudTravelProvider.GetByPgStudTravelId(transactionManager, (entity.PgStudTravelId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudTravelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgStudTravelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgStudTravelProvider.DeepLoad(transactionManager, entity.PgStudTravelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgStudTravelIdSource

			#region PgStudTravelExtendIdSource	
			if (CanDeepLoad(entity, "PgStudTravelExtend|PgStudTravelExtendIdSource", deepLoadType, innerList) 
				&& entity.PgStudTravelExtendIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgStudTravelExtendId ?? 0.0m);
				PgStudTravelExtend tmpEntity = EntityManager.LocateEntity<PgStudTravelExtend>(EntityLocator.ConstructKeyFromPkItems(typeof(PgStudTravelExtend), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgStudTravelExtendIdSource = tmpEntity;
				else
					entity.PgStudTravelExtendIdSource = DataRepository.PgStudTravelExtendProvider.GetByPgStudTravelExtendId(transactionManager, (entity.PgStudTravelExtendId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudTravelExtendIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgStudTravelExtendIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgStudTravelExtendProvider.DeepLoad(transactionManager, entity.PgStudTravelExtendIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgStudTravelExtendIdSource

			#region PgThesisCommIdSource	
			if (CanDeepLoad(entity, "PgThesisComm|PgThesisCommIdSource", deepLoadType, innerList) 
				&& entity.PgThesisCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisCommId ?? 0.0m);
				PgThesisComm tmpEntity = EntityManager.LocateEntity<PgThesisComm>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisCommIdSource = tmpEntity;
				else
					entity.PgThesisCommIdSource = DataRepository.PgThesisCommProvider.GetByPgThesisCommId(transactionManager, (entity.PgThesisCommId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisCommProvider.DeepLoad(transactionManager, entity.PgThesisCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisCommIdSource

			#region PgThesisCommRecommendIdSource	
			if (CanDeepLoad(entity, "PgThesisCommRecommend|PgThesisCommRecommendIdSource", deepLoadType, innerList) 
				&& entity.PgThesisCommRecommendIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisCommRecommendId ?? 0.0m);
				PgThesisCommRecommend tmpEntity = EntityManager.LocateEntity<PgThesisCommRecommend>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisCommRecommend), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisCommRecommendIdSource = tmpEntity;
				else
					entity.PgThesisCommRecommendIdSource = DataRepository.PgThesisCommRecommendProvider.GetByPgThesisCommRecommendId(transactionManager, (entity.PgThesisCommRecommendId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommRecommendIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisCommRecommendIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisCommRecommendProvider.DeepLoad(transactionManager, entity.PgThesisCommRecommendIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisCommRecommendIdSource

			#region PgThesisCommRptIdSource	
			if (CanDeepLoad(entity, "PgThesisCommRpt|PgThesisCommRptIdSource", deepLoadType, innerList) 
				&& entity.PgThesisCommRptIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisCommRptId ?? 0.0m);
				PgThesisCommRpt tmpEntity = EntityManager.LocateEntity<PgThesisCommRpt>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisCommRpt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisCommRptIdSource = tmpEntity;
				else
					entity.PgThesisCommRptIdSource = DataRepository.PgThesisCommRptProvider.GetByPgThesisCommRptId(transactionManager, (entity.PgThesisCommRptId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommRptIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisCommRptIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisCommRptProvider.DeepLoad(transactionManager, entity.PgThesisCommRptIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisCommRptIdSource

			#region PgThesisGrantDegreeIdSource	
			if (CanDeepLoad(entity, "PgThesisGrantDegree|PgThesisGrantDegreeIdSource", deepLoadType, innerList) 
				&& entity.PgThesisGrantDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisGrantDegreeId;
				PgThesisGrantDegree tmpEntity = EntityManager.LocateEntity<PgThesisGrantDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisGrantDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisGrantDegreeIdSource = tmpEntity;
				else
					entity.PgThesisGrantDegreeIdSource = DataRepository.PgThesisGrantDegreeProvider.GetByPgThesisGrantDegreeId(transactionManager, entity.PgThesisGrantDegreeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisGrantDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisGrantDegreeProvider.DeepLoad(transactionManager, entity.PgThesisGrantDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisGrantDegreeIdSource

			#region PgThesisSeminarIdSource	
			if (CanDeepLoad(entity, "PgThesisSeminar|PgThesisSeminarIdSource", deepLoadType, innerList) 
				&& entity.PgThesisSeminarIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisSeminarId ?? 0.0m);
				PgThesisSeminar tmpEntity = EntityManager.LocateEntity<PgThesisSeminar>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisSeminar), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisSeminarIdSource = tmpEntity;
				else
					entity.PgThesisSeminarIdSource = DataRepository.PgThesisSeminarProvider.GetByPgThesisSeminarId(transactionManager, (entity.PgThesisSeminarId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSeminarIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisSeminarIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisSeminarProvider.DeepLoad(transactionManager, entity.PgThesisSeminarIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisSeminarIdSource

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

			#region PgThesisStudExtendIdSource	
			if (CanDeepLoad(entity, "PgThesisStudExtend|PgThesisStudExtendIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudExtendIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisStudExtendId ?? 0.0m);
				PgThesisStudExtend tmpEntity = EntityManager.LocateEntity<PgThesisStudExtend>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStudExtend), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudExtendIdSource = tmpEntity;
				else
					entity.PgThesisStudExtendIdSource = DataRepository.PgThesisStudExtendProvider.GetByPgThesisStudExtendId(transactionManager, (entity.PgThesisStudExtendId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudExtendIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudExtendIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudExtendProvider.DeepLoad(transactionManager, entity.PgThesisStudExtendIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudExtendIdSource

			#region PgThesisStudRsrchStrtgyIdSource	
			if (CanDeepLoad(entity, "PgThesisStudRsrchStrtgy|PgThesisStudRsrchStrtgyIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudRsrchStrtgyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisStudRsrchStrtgyId ?? 0.0m);
				PgThesisStudRsrchStrtgy tmpEntity = EntityManager.LocateEntity<PgThesisStudRsrchStrtgy>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStudRsrchStrtgy), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudRsrchStrtgyIdSource = tmpEntity;
				else
					entity.PgThesisStudRsrchStrtgyIdSource = DataRepository.PgThesisStudRsrchStrtgyProvider.GetByPgThesisStudRsrchStrtgyId(transactionManager, (entity.PgThesisStudRsrchStrtgyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudRsrchStrtgyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudRsrchStrtgyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudRsrchStrtgyProvider.DeepLoad(transactionManager, entity.PgThesisStudRsrchStrtgyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudRsrchStrtgyIdSource

			#region PgThesisSupervisorRptIdSource	
			if (CanDeepLoad(entity, "PgThesisSupervisorRpt|PgThesisSupervisorRptIdSource", deepLoadType, innerList) 
				&& entity.PgThesisSupervisorRptIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisSupervisorRptId ?? 0.0m);
				PgThesisSupervisorRpt tmpEntity = EntityManager.LocateEntity<PgThesisSupervisorRpt>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisSupervisorRpt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisSupervisorRptIdSource = tmpEntity;
				else
					entity.PgThesisSupervisorRptIdSource = DataRepository.PgThesisSupervisorRptProvider.GetByPgThesisSupervisorRptId(transactionManager, (entity.PgThesisSupervisorRptId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSupervisorRptIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisSupervisorRptIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisSupervisorRptProvider.DeepLoad(transactionManager, entity.PgThesisSupervisorRptIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisSupervisorRptIdSource

			#region PgThesisValidityRptIdSource	
			if (CanDeepLoad(entity, "PgThesisValidityRpt|PgThesisValidityRptIdSource", deepLoadType, innerList) 
				&& entity.PgThesisValidityRptIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisValidityRptId ?? 0.0m);
				PgThesisValidityRpt tmpEntity = EntityManager.LocateEntity<PgThesisValidityRpt>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisValidityRpt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisValidityRptIdSource = tmpEntity;
				else
					entity.PgThesisValidityRptIdSource = DataRepository.PgThesisValidityRptProvider.GetByPgThesisValidityRptId(transactionManager, (entity.PgThesisValidityRptId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisValidityRptIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisValidityRptIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisValidityRptProvider.DeepLoad(transactionManager, entity.PgThesisValidityRptIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisValidityRptIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgAttchdDoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgAttchdDoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgAttchdDoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgAttchdDoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeApprovalFuncIdSource
			if (CanDeepSave(entity, "GsCodeApprovalFunc|GsCodeApprovalFuncIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalFuncIdSource != null)
			{
				DataRepository.GsCodeApprovalFuncProvider.Save(transactionManager, entity.GsCodeApprovalFuncIdSource);
				entity.GsCodeApprovalFuncId = entity.GsCodeApprovalFuncIdSource.GsCodeApprovalFuncId;
			}
			#endregion 
			
			#region PgStudConferenceIdSource
			if (CanDeepSave(entity, "PgStudConference|PgStudConferenceIdSource", deepSaveType, innerList) 
				&& entity.PgStudConferenceIdSource != null)
			{
				DataRepository.PgStudConferenceProvider.Save(transactionManager, entity.PgStudConferenceIdSource);
				entity.PgStudConferenceId = entity.PgStudConferenceIdSource.PgStudConferenceId;
			}
			#endregion 
			
			#region PgStudPublishIdSource
			if (CanDeepSave(entity, "PgStudPublish|PgStudPublishIdSource", deepSaveType, innerList) 
				&& entity.PgStudPublishIdSource != null)
			{
				DataRepository.PgStudPublishProvider.Save(transactionManager, entity.PgStudPublishIdSource);
				entity.PgStudPublishId = entity.PgStudPublishIdSource.PgStudPublishId;
			}
			#endregion 
			
			#region PgStudTravelIdSource
			if (CanDeepSave(entity, "PgStudTravel|PgStudTravelIdSource", deepSaveType, innerList) 
				&& entity.PgStudTravelIdSource != null)
			{
				DataRepository.PgStudTravelProvider.Save(transactionManager, entity.PgStudTravelIdSource);
				entity.PgStudTravelId = entity.PgStudTravelIdSource.PgStudTravelId;
			}
			#endregion 
			
			#region PgStudTravelExtendIdSource
			if (CanDeepSave(entity, "PgStudTravelExtend|PgStudTravelExtendIdSource", deepSaveType, innerList) 
				&& entity.PgStudTravelExtendIdSource != null)
			{
				DataRepository.PgStudTravelExtendProvider.Save(transactionManager, entity.PgStudTravelExtendIdSource);
				entity.PgStudTravelExtendId = entity.PgStudTravelExtendIdSource.PgStudTravelExtendId;
			}
			#endregion 
			
			#region PgThesisCommIdSource
			if (CanDeepSave(entity, "PgThesisComm|PgThesisCommIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommIdSource != null)
			{
				DataRepository.PgThesisCommProvider.Save(transactionManager, entity.PgThesisCommIdSource);
				entity.PgThesisCommId = entity.PgThesisCommIdSource.PgThesisCommId;
			}
			#endregion 
			
			#region PgThesisCommRecommendIdSource
			if (CanDeepSave(entity, "PgThesisCommRecommend|PgThesisCommRecommendIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommRecommendIdSource != null)
			{
				DataRepository.PgThesisCommRecommendProvider.Save(transactionManager, entity.PgThesisCommRecommendIdSource);
				entity.PgThesisCommRecommendId = entity.PgThesisCommRecommendIdSource.PgThesisCommRecommendId;
			}
			#endregion 
			
			#region PgThesisCommRptIdSource
			if (CanDeepSave(entity, "PgThesisCommRpt|PgThesisCommRptIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommRptIdSource != null)
			{
				DataRepository.PgThesisCommRptProvider.Save(transactionManager, entity.PgThesisCommRptIdSource);
				entity.PgThesisCommRptId = entity.PgThesisCommRptIdSource.PgThesisCommRptId;
			}
			#endregion 
			
			#region PgThesisGrantDegreeIdSource
			if (CanDeepSave(entity, "PgThesisGrantDegree|PgThesisGrantDegreeIdSource", deepSaveType, innerList) 
				&& entity.PgThesisGrantDegreeIdSource != null)
			{
				DataRepository.PgThesisGrantDegreeProvider.Save(transactionManager, entity.PgThesisGrantDegreeIdSource);
				entity.PgThesisGrantDegreeId = entity.PgThesisGrantDegreeIdSource.PgThesisGrantDegreeId;
			}
			#endregion 
			
			#region PgThesisSeminarIdSource
			if (CanDeepSave(entity, "PgThesisSeminar|PgThesisSeminarIdSource", deepSaveType, innerList) 
				&& entity.PgThesisSeminarIdSource != null)
			{
				DataRepository.PgThesisSeminarProvider.Save(transactionManager, entity.PgThesisSeminarIdSource);
				entity.PgThesisSeminarId = entity.PgThesisSeminarIdSource.PgThesisSeminarId;
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
			
			#region PgThesisStudExtendIdSource
			if (CanDeepSave(entity, "PgThesisStudExtend|PgThesisStudExtendIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudExtendIdSource != null)
			{
				DataRepository.PgThesisStudExtendProvider.Save(transactionManager, entity.PgThesisStudExtendIdSource);
				entity.PgThesisStudExtendId = entity.PgThesisStudExtendIdSource.PgThesisStudExtendId;
			}
			#endregion 
			
			#region PgThesisStudRsrchStrtgyIdSource
			if (CanDeepSave(entity, "PgThesisStudRsrchStrtgy|PgThesisStudRsrchStrtgyIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudRsrchStrtgyIdSource != null)
			{
				DataRepository.PgThesisStudRsrchStrtgyProvider.Save(transactionManager, entity.PgThesisStudRsrchStrtgyIdSource);
				entity.PgThesisStudRsrchStrtgyId = entity.PgThesisStudRsrchStrtgyIdSource.PgThesisStudRsrchStrtgyId;
			}
			#endregion 
			
			#region PgThesisSupervisorRptIdSource
			if (CanDeepSave(entity, "PgThesisSupervisorRpt|PgThesisSupervisorRptIdSource", deepSaveType, innerList) 
				&& entity.PgThesisSupervisorRptIdSource != null)
			{
				DataRepository.PgThesisSupervisorRptProvider.Save(transactionManager, entity.PgThesisSupervisorRptIdSource);
				entity.PgThesisSupervisorRptId = entity.PgThesisSupervisorRptIdSource.PgThesisSupervisorRptId;
			}
			#endregion 
			
			#region PgThesisValidityRptIdSource
			if (CanDeepSave(entity, "PgThesisValidityRpt|PgThesisValidityRptIdSource", deepSaveType, innerList) 
				&& entity.PgThesisValidityRptIdSource != null)
			{
				DataRepository.PgThesisValidityRptProvider.Save(transactionManager, entity.PgThesisValidityRptIdSource);
				entity.PgThesisValidityRptId = entity.PgThesisValidityRptIdSource.PgThesisValidityRptId;
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
	
	#region PgAttchdDocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgAttchdDoc</c>
	///</summary>
	public enum PgAttchdDocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeApprovalFunc</c> at GsCodeApprovalFuncIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApprovalFunc))]
		GsCodeApprovalFunc,
		
		///<summary>
		/// Composite Property for <c>PgStudConference</c> at PgStudConferenceIdSource
		///</summary>
		[ChildEntityType(typeof(PgStudConference))]
		PgStudConference,
		
		///<summary>
		/// Composite Property for <c>PgStudPublish</c> at PgStudPublishIdSource
		///</summary>
		[ChildEntityType(typeof(PgStudPublish))]
		PgStudPublish,
		
		///<summary>
		/// Composite Property for <c>PgStudTravel</c> at PgStudTravelIdSource
		///</summary>
		[ChildEntityType(typeof(PgStudTravel))]
		PgStudTravel,
		
		///<summary>
		/// Composite Property for <c>PgStudTravelExtend</c> at PgStudTravelExtendIdSource
		///</summary>
		[ChildEntityType(typeof(PgStudTravelExtend))]
		PgStudTravelExtend,
		
		///<summary>
		/// Composite Property for <c>PgThesisComm</c> at PgThesisCommIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisComm))]
		PgThesisComm,
		
		///<summary>
		/// Composite Property for <c>PgThesisCommRecommend</c> at PgThesisCommRecommendIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisCommRecommend))]
		PgThesisCommRecommend,
		
		///<summary>
		/// Composite Property for <c>PgThesisCommRpt</c> at PgThesisCommRptIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisCommRpt))]
		PgThesisCommRpt,
		
		///<summary>
		/// Composite Property for <c>PgThesisGrantDegree</c> at PgThesisGrantDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisGrantDegree))]
		PgThesisGrantDegree,
		
		///<summary>
		/// Composite Property for <c>PgThesisSeminar</c> at PgThesisSeminarIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisSeminar))]
		PgThesisSeminar,
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		
		///<summary>
		/// Composite Property for <c>PgThesisStudExtend</c> at PgThesisStudExtendIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStudExtend))]
		PgThesisStudExtend,
		
		///<summary>
		/// Composite Property for <c>PgThesisStudRsrchStrtgy</c> at PgThesisStudRsrchStrtgyIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStudRsrchStrtgy))]
		PgThesisStudRsrchStrtgy,
		
		///<summary>
		/// Composite Property for <c>PgThesisSupervisorRpt</c> at PgThesisSupervisorRptIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisSupervisorRpt))]
		PgThesisSupervisorRpt,
		
		///<summary>
		/// Composite Property for <c>PgThesisValidityRpt</c> at PgThesisValidityRptIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisValidityRpt))]
		PgThesisValidityRpt,
	}
	
	#endregion PgAttchdDocChildEntityTypes
	
	#region PgAttchdDocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgAttchdDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgAttchdDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgAttchdDocFilterBuilder : SqlFilterBuilder<PgAttchdDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgAttchdDocFilterBuilder class.
		/// </summary>
		public PgAttchdDocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgAttchdDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgAttchdDocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgAttchdDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgAttchdDocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgAttchdDocFilterBuilder
	
	#region PgAttchdDocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgAttchdDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgAttchdDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgAttchdDocParameterBuilder : ParameterizedSqlFilterBuilder<PgAttchdDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgAttchdDocParameterBuilder class.
		/// </summary>
		public PgAttchdDocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgAttchdDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgAttchdDocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgAttchdDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgAttchdDocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgAttchdDocParameterBuilder
	
	#region PgAttchdDocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgAttchdDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgAttchdDoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgAttchdDocSortBuilder : SqlSortBuilder<PgAttchdDocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgAttchdDocSqlSortBuilder class.
		/// </summary>
		public PgAttchdDocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgAttchdDocSortBuilder
	
} // end namespace
