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
	/// This class is the base class for any <see cref="SpoOfferStudExceptionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoOfferStudExceptionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoOfferStudException, UMIS_VER2.BusinessLyer.SpoOfferStudExceptionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoOfferStudExceptionKey key)
		{
			return Delete(transactionManager, key.SpoOfferStudExceptionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoOfferStudExceptionId">يتم تسجيل حصول الطالب علي الاستثناء الخاص بالطالب المستفيد من منحة 100% و قل معدله التراكمي في السنة عن 3 .
		/// 		/// يتم هذا الاستثناء مرة واحدة فقط خلال السنوات الدراسية للطالب
		/// 		/// . Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoOfferStudExceptionId)
		{
			return Delete(null, _spoOfferStudExceptionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoOfferStudExceptionId">يتم تسجيل حصول الطالب علي الاستثناء الخاص بالطالب المستفيد من منحة 100% و قل معدله التراكمي في السنة عن 3 .
		/// 		/// يتم هذا الاستثناء مرة واحدة فقط خلال السنوات الدراسية للطالب
		/// 		/// . Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoOfferStudExceptionId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_ED_ACAD_YEAR key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_ED_ACAD_YEAR key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		/// <remarks></remarks>
		public TList<SpoOfferStudException> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_ED_ACAD_YEAR key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_ED_ACAD_YEAR key.
		///		fkSpoOfferStudExceptionEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_ED_ACAD_YEAR key.
		///		fkSpoOfferStudExceptionEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_ED_ACAD_YEAR key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public abstract TList<SpoOfferStudException> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_GS_CODE_REQ_STATUS key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_GS_CODE_REQ_STATUS key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		/// <remarks></remarks>
		public TList<SpoOfferStudException> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_GS_CODE_REQ_STATUS key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_GS_CODE_REQ_STATUS key.
		///		fkSpoOfferStudExceptionGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_GS_CODE_REQ_STATUS key.
		///		fkSpoOfferStudExceptionGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_GS_CODE_REQ_STATUS key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public abstract TList<SpoOfferStudException> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_OFFER key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(_spoSponsorOfferId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_OFFER key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		/// <remarks></remarks>
		public TList<SpoOfferStudException> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_OFFER key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_OFFER key.
		///		fkSpoOfferStudExceptionSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_OFFER key.
		///		fkSpoOfferStudExceptionSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_OFFER key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public abstract TList<SpoOfferStudException> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_STUD key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_STUD Description: 
		/// </summary>
		/// <param name="_spoSponsorStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetBySpoSponsorStudId(System.Decimal _spoSponsorStudId)
		{
			int count = -1;
			return GetBySpoSponsorStudId(_spoSponsorStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_STUD key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		/// <remarks></remarks>
		public TList<SpoOfferStudException> GetBySpoSponsorStudId(TransactionManager transactionManager, System.Decimal _spoSponsorStudId)
		{
			int count = -1;
			return GetBySpoSponsorStudId(transactionManager, _spoSponsorStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_STUD key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetBySpoSponsorStudId(TransactionManager transactionManager, System.Decimal _spoSponsorStudId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorStudId(transactionManager, _spoSponsorStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_STUD key.
		///		fkSpoOfferStudExceptionSpoSponsorStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetBySpoSponsorStudId(System.Decimal _spoSponsorStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorStudId(null, _spoSponsorStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_STUD key.
		///		fkSpoOfferStudExceptionSpoSponsorStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetBySpoSponsorStudId(System.Decimal _spoSponsorStudId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorStudId(null, _spoSponsorStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_STUD key.
		///		FK_SPO_OFFER_STUD_EXCEPTION_SPO_SPONSOR_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public abstract TList<SpoOfferStudException> GetBySpoSponsorStudId(TransactionManager transactionManager, System.Decimal _spoSponsorStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_EXCEPTION_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_EXCEPTION_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_EXCEPTION_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_EXCEPTION_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		/// <remarks></remarks>
		public TList<SpoOfferStudException> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_EXCEPTION_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_EXCEPTION_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_EXCEPTION_ED_CODE_SEMESTER key.
		///		fkSpoSponsorExceptionEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_EXCEPTION_ED_CODE_SEMESTER key.
		///		fkSpoSponsorExceptionEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public TList<SpoOfferStudException> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_EXCEPTION_ED_CODE_SEMESTER key.
		///		FK_SPO_SPONSOR_EXCEPTION_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoOfferStudException objects.</returns>
		public abstract TList<SpoOfferStudException> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoOfferStudException Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoOfferStudExceptionKey key, int start, int pageLength)
		{
			return GetBySpoOfferStudExceptionId(transactionManager, key.SpoOfferStudExceptionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_OFFER_STUD_EXCEPTION index.
		/// </summary>
		/// <param name="_spoOfferStudExceptionId">يتم تسجيل حصول الطالب علي الاستثناء الخاص بالطالب المستفيد من منحة 100% و قل معدله التراكمي في السنة عن 3 .
		/// 		/// يتم هذا الاستثناء مرة واحدة فقط خلال السنوات الدراسية للطالب
		/// 		/// </param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoOfferStudException GetBySpoOfferStudExceptionId(System.Decimal _spoOfferStudExceptionId)
		{
			int count = -1;
			return GetBySpoOfferStudExceptionId(null,_spoOfferStudExceptionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_OFFER_STUD_EXCEPTION index.
		/// </summary>
		/// <param name="_spoOfferStudExceptionId">يتم تسجيل حصول الطالب علي الاستثناء الخاص بالطالب المستفيد من منحة 100% و قل معدله التراكمي في السنة عن 3 .
		/// 		/// يتم هذا الاستثناء مرة واحدة فقط خلال السنوات الدراسية للطالب
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoOfferStudException GetBySpoOfferStudExceptionId(System.Decimal _spoOfferStudExceptionId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoOfferStudExceptionId(null, _spoOfferStudExceptionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_OFFER_STUD_EXCEPTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoOfferStudExceptionId">يتم تسجيل حصول الطالب علي الاستثناء الخاص بالطالب المستفيد من منحة 100% و قل معدله التراكمي في السنة عن 3 .
		/// 		/// يتم هذا الاستثناء مرة واحدة فقط خلال السنوات الدراسية للطالب
		/// 		/// </param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoOfferStudException GetBySpoOfferStudExceptionId(TransactionManager transactionManager, System.Decimal _spoOfferStudExceptionId)
		{
			int count = -1;
			return GetBySpoOfferStudExceptionId(transactionManager, _spoOfferStudExceptionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_OFFER_STUD_EXCEPTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoOfferStudExceptionId">يتم تسجيل حصول الطالب علي الاستثناء الخاص بالطالب المستفيد من منحة 100% و قل معدله التراكمي في السنة عن 3 .
		/// 		/// يتم هذا الاستثناء مرة واحدة فقط خلال السنوات الدراسية للطالب
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoOfferStudException GetBySpoOfferStudExceptionId(TransactionManager transactionManager, System.Decimal _spoOfferStudExceptionId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoOfferStudExceptionId(transactionManager, _spoOfferStudExceptionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_OFFER_STUD_EXCEPTION index.
		/// </summary>
		/// <param name="_spoOfferStudExceptionId">يتم تسجيل حصول الطالب علي الاستثناء الخاص بالطالب المستفيد من منحة 100% و قل معدله التراكمي في السنة عن 3 .
		/// 		/// يتم هذا الاستثناء مرة واحدة فقط خلال السنوات الدراسية للطالب
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoOfferStudException GetBySpoOfferStudExceptionId(System.Decimal _spoOfferStudExceptionId, int start, int pageLength, out int count)
		{
			return GetBySpoOfferStudExceptionId(null, _spoOfferStudExceptionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_OFFER_STUD_EXCEPTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoOfferStudExceptionId">يتم تسجيل حصول الطالب علي الاستثناء الخاص بالطالب المستفيد من منحة 100% و قل معدله التراكمي في السنة عن 3 .
		/// 		/// يتم هذا الاستثناء مرة واحدة فقط خلال السنوات الدراسية للطالب
		/// 		/// </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoOfferStudException GetBySpoOfferStudExceptionId(TransactionManager transactionManager, System.Decimal _spoOfferStudExceptionId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoOfferStudException&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoOfferStudException&gt;"/></returns>
		public static TList<SpoOfferStudException> Fill(IDataReader reader, TList<SpoOfferStudException> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoOfferStudException c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoOfferStudException")
					.Append("|").Append((System.Decimal)reader["SPO_OFFER_STUD_EXCEPTION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoOfferStudException>(
					key.ToString(), // EntityTrackingKey
					"SpoOfferStudException",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoOfferStudException();
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
					c.SpoOfferStudExceptionId = (System.Decimal)reader["SPO_OFFER_STUD_EXCEPTION_ID"];
					c.OriginalSpoOfferStudExceptionId = c.SpoOfferStudExceptionId;
					c.SpoSponsorOfferId = (System.Decimal)reader["SPO_SPONSOR_OFFER_ID"];
					c.SpoSponsorStudId = (System.Decimal)reader["SPO_SPONSOR_STUD_ID"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.SpoPercentUpdt = Convert.IsDBNull(reader["SPO_PERCENT_UPDT"]) ? null : (System.Decimal?)reader["SPO_PERCENT_UPDT"];
					c.SpoAmountUpdt = Convert.IsDBNull(reader["SPO_AMOUNT_UPDT"]) ? null : (System.Decimal?)reader["SPO_AMOUNT_UPDT"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.GsCodeReqStatusId = Convert.IsDBNull(reader["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)reader["GS_CODE_REQ_STATUS_ID"];
					c.ApproveFlg = (System.Decimal)reader["APPROVE_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoOfferStudException entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoOfferStudExceptionId = (System.Decimal)reader[((int)SpoOfferStudExceptionColumn.SpoOfferStudExceptionId - 1)];
			entity.OriginalSpoOfferStudExceptionId = (System.Decimal)reader["SPO_OFFER_STUD_EXCEPTION_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)reader[((int)SpoOfferStudExceptionColumn.SpoSponsorOfferId - 1)];
			entity.SpoSponsorStudId = (System.Decimal)reader[((int)SpoOfferStudExceptionColumn.SpoSponsorStudId - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)SpoOfferStudExceptionColumn.ReqDate - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)SpoOfferStudExceptionColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)SpoOfferStudExceptionColumn.EdCodeSemesterId - 1)];
			entity.SpoPercentUpdt = (reader.IsDBNull(((int)SpoOfferStudExceptionColumn.SpoPercentUpdt - 1)))?null:(System.Decimal?)reader[((int)SpoOfferStudExceptionColumn.SpoPercentUpdt - 1)];
			entity.SpoAmountUpdt = (reader.IsDBNull(((int)SpoOfferStudExceptionColumn.SpoAmountUpdt - 1)))?null:(System.Decimal?)reader[((int)SpoOfferStudExceptionColumn.SpoAmountUpdt - 1)];
			entity.Notes = (reader.IsDBNull(((int)SpoOfferStudExceptionColumn.Notes - 1)))?null:(System.String)reader[((int)SpoOfferStudExceptionColumn.Notes - 1)];
			entity.GsCodeReqStatusId = (reader.IsDBNull(((int)SpoOfferStudExceptionColumn.GsCodeReqStatusId - 1)))?null:(System.Decimal?)reader[((int)SpoOfferStudExceptionColumn.GsCodeReqStatusId - 1)];
			entity.ApproveFlg = (System.Decimal)reader[((int)SpoOfferStudExceptionColumn.ApproveFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SpoOfferStudExceptionColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SpoOfferStudExceptionColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SpoOfferStudExceptionColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SpoOfferStudExceptionColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoOfferStudException entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoOfferStudExceptionId = (System.Decimal)dataRow["SPO_OFFER_STUD_EXCEPTION_ID"];
			entity.OriginalSpoOfferStudExceptionId = (System.Decimal)dataRow["SPO_OFFER_STUD_EXCEPTION_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)dataRow["SPO_SPONSOR_OFFER_ID"];
			entity.SpoSponsorStudId = (System.Decimal)dataRow["SPO_SPONSOR_STUD_ID"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.SpoPercentUpdt = Convert.IsDBNull(dataRow["SPO_PERCENT_UPDT"]) ? null : (System.Decimal?)dataRow["SPO_PERCENT_UPDT"];
			entity.SpoAmountUpdt = Convert.IsDBNull(dataRow["SPO_AMOUNT_UPDT"]) ? null : (System.Decimal?)dataRow["SPO_AMOUNT_UPDT"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.GsCodeReqStatusId = Convert.IsDBNull(dataRow["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.ApproveFlg = (System.Decimal)dataRow["APPROVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoOfferStudException"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoOfferStudException Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoOfferStudException entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SpoSponsorOfferIdSource	
			if (CanDeepLoad(entity, "SpoSponsorOffer|SpoSponsorOfferIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorOfferIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SpoSponsorOfferId;
				SpoSponsorOffer tmpEntity = EntityManager.LocateEntity<SpoSponsorOffer>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorOffer), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorOfferIdSource = tmpEntity;
				else
					entity.SpoSponsorOfferIdSource = DataRepository.SpoSponsorOfferProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorOfferIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorOfferProvider.DeepLoad(transactionManager, entity.SpoSponsorOfferIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorOfferIdSource

			#region SpoSponsorStudIdSource	
			if (CanDeepLoad(entity, "SpoSponsorStud|SpoSponsorStudIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SpoSponsorStudId;
				SpoSponsorStud tmpEntity = EntityManager.LocateEntity<SpoSponsorStud>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorStudIdSource = tmpEntity;
				else
					entity.SpoSponsorStudIdSource = DataRepository.SpoSponsorStudProvider.GetBySpoSponsorStudId(transactionManager, entity.SpoSponsorStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorStudProvider.DeepLoad(transactionManager, entity.SpoSponsorStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorStudIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoOfferStudException object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoOfferStudException instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoOfferStudException Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoOfferStudException entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsCodeReqStatusIdSource
			if (CanDeepSave(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReqStatusIdSource != null)
			{
				DataRepository.GsCodeReqStatusProvider.Save(transactionManager, entity.GsCodeReqStatusIdSource);
				entity.GsCodeReqStatusId = entity.GsCodeReqStatusIdSource.GsCodeReqStatusId;
			}
			#endregion 
			
			#region SpoSponsorOfferIdSource
			if (CanDeepSave(entity, "SpoSponsorOffer|SpoSponsorOfferIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorOfferIdSource != null)
			{
				DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferIdSource);
				entity.SpoSponsorOfferId = entity.SpoSponsorOfferIdSource.SpoSponsorOfferId;
			}
			#endregion 
			
			#region SpoSponsorStudIdSource
			if (CanDeepSave(entity, "SpoSponsorStud|SpoSponsorStudIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorStudIdSource != null)
			{
				DataRepository.SpoSponsorStudProvider.Save(transactionManager, entity.SpoSponsorStudIdSource);
				entity.SpoSponsorStudId = entity.SpoSponsorStudIdSource.SpoSponsorStudId;
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
	
	#region SpoOfferStudExceptionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoOfferStudException</c>
	///</summary>
	public enum SpoOfferStudExceptionChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
		
		///<summary>
		/// Composite Property for <c>SpoSponsorOffer</c> at SpoSponsorOfferIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsorOffer))]
		SpoSponsorOffer,
		
		///<summary>
		/// Composite Property for <c>SpoSponsorStud</c> at SpoSponsorStudIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsorStud))]
		SpoSponsorStud,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
	}
	
	#endregion SpoOfferStudExceptionChildEntityTypes
	
	#region SpoOfferStudExceptionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoOfferStudExceptionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoOfferStudException"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoOfferStudExceptionFilterBuilder : SqlFilterBuilder<SpoOfferStudExceptionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoOfferStudExceptionFilterBuilder class.
		/// </summary>
		public SpoOfferStudExceptionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoOfferStudExceptionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoOfferStudExceptionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoOfferStudExceptionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoOfferStudExceptionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoOfferStudExceptionFilterBuilder
	
	#region SpoOfferStudExceptionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoOfferStudExceptionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoOfferStudException"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoOfferStudExceptionParameterBuilder : ParameterizedSqlFilterBuilder<SpoOfferStudExceptionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoOfferStudExceptionParameterBuilder class.
		/// </summary>
		public SpoOfferStudExceptionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoOfferStudExceptionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoOfferStudExceptionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoOfferStudExceptionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoOfferStudExceptionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoOfferStudExceptionParameterBuilder
	
	#region SpoOfferStudExceptionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoOfferStudExceptionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoOfferStudException"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoOfferStudExceptionSortBuilder : SqlSortBuilder<SpoOfferStudExceptionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoOfferStudExceptionSqlSortBuilder class.
		/// </summary>
		public SpoOfferStudExceptionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoOfferStudExceptionSortBuilder
	
} // end namespace
