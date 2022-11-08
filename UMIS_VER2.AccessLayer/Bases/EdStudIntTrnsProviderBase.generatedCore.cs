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
	/// This class is the base class for any <see cref="EdStudIntTrnsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudIntTrnsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudIntTrns, UMIS_VER2.BusinessLyer.EdStudIntTrnsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrnsKey key)
		{
			return Delete(transactionManager, key.EdStudIntTrnsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudIntTrnsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudIntTrnsId)
		{
			return Delete(null, _edStudIntTrnsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ED_STUD_INT_TRNS_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByAdmCodeTransferTypeId(System.Decimal _admCodeTransferTypeId)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(_admCodeTransferTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ED_STUD_INT_TRNS_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrns> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal _admCodeTransferTypeId)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(transactionManager, _admCodeTransferTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ED_STUD_INT_TRNS_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal _admCodeTransferTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(transactionManager, _admCodeTransferTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ADM_CODE_TRANSFER_TYPE key.
		///		fkEdStudIntTrnsAdmCodeTransferType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByAdmCodeTransferTypeId(System.Decimal _admCodeTransferTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCodeTransferTypeId(null, _admCodeTransferTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ADM_CODE_TRANSFER_TYPE key.
		///		fkEdStudIntTrnsAdmCodeTransferType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByAdmCodeTransferTypeId(System.Decimal _admCodeTransferTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCodeTransferTypeId(null, _admCodeTransferTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ED_STUD_INT_TRNS_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public abstract TList<EdStudIntTrns> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal _admCodeTransferTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrns> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_AS_FACULTY_INFO key.
		///		fkEdStudIntTrnsAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_AS_FACULTY_INFO key.
		///		fkEdStudIntTrnsAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public abstract TList<EdStudIntTrns> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrns> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR key.
		///		fkEdStudIntTrnsEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR key.
		///		fkEdStudIntTrnsEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public abstract TList<EdStudIntTrns> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="_edAcadYearReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdAcadYearReqId(System.Decimal? _edAcadYearReqId)
		{
			int count = -1;
			return GetByEdAcadYearReqId(_edAcadYearReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrns> GetByEdAcadYearReqId(TransactionManager transactionManager, System.Decimal? _edAcadYearReqId)
		{
			int count = -1;
			return GetByEdAcadYearReqId(transactionManager, _edAcadYearReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdAcadYearReqId(TransactionManager transactionManager, System.Decimal? _edAcadYearReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearReqId(transactionManager, _edAcadYearReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR1 key.
		///		fkEdStudIntTrnsEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdAcadYearReqId(System.Decimal? _edAcadYearReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearReqId(null, _edAcadYearReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR1 key.
		///		fkEdStudIntTrnsEdAcadYear1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearReqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdAcadYearReqId(System.Decimal? _edAcadYearReqId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearReqId(null, _edAcadYearReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR1 key.
		///		FK_ED_STUD_INT_TRNS_ED_ACAD_YEAR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public abstract TList<EdStudIntTrns> GetByEdAcadYearReqId(TransactionManager transactionManager, System.Decimal? _edAcadYearReqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrns> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER key.
		///		fkEdStudIntTrnsEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER key.
		///		fkEdStudIntTrnsEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public abstract TList<EdStudIntTrns> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="_edCodeSemesterReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdCodeSemesterReqId(System.Decimal? _edCodeSemesterReqId)
		{
			int count = -1;
			return GetByEdCodeSemesterReqId(_edCodeSemesterReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrns> GetByEdCodeSemesterReqId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterReqId)
		{
			int count = -1;
			return GetByEdCodeSemesterReqId(transactionManager, _edCodeSemesterReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdCodeSemesterReqId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterReqId(transactionManager, _edCodeSemesterReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER1 key.
		///		fkEdStudIntTrnsEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdCodeSemesterReqId(System.Decimal? _edCodeSemesterReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterReqId(null, _edCodeSemesterReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER1 key.
		///		fkEdStudIntTrnsEdCodeSemester1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterReqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdCodeSemesterReqId(System.Decimal? _edCodeSemesterReqId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterReqId(null, _edCodeSemesterReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER1 key.
		///		FK_ED_STUD_INT_TRNS_ED_CODE_SEMESTER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public abstract TList<EdStudIntTrns> GetByEdCodeSemesterReqId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterReqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrns> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_STUD key.
		///		fkEdStudIntTrnsEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_STUD key.
		///		fkEdStudIntTrnsEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public abstract TList<EdStudIntTrns> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_INT_TRNS_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_INT_TRNS_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrns> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_INT_TRNS_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_GS_CODE_REQ_STATUS key.
		///		fkEdStudIntTrnsGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_GS_CODE_REQ_STATUS key.
		///		fkEdStudIntTrnsGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public TList<EdStudIntTrns> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_INT_TRNS_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrns objects.</returns>
		public abstract TList<EdStudIntTrns> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudIntTrns Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrnsKey key, int start, int pageLength)
		{
			return GetByEdStudIntTrnsId(transactionManager, key.EdStudIntTrnsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_INT_TRANSFER index.
		/// </summary>
		/// <param name="_edStudIntTrnsId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrns GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(null,_edStudIntTrnsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_INT_TRANSFER index.
		/// </summary>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrns GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(null, _edStudIntTrnsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_INT_TRANSFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrns GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(transactionManager, _edStudIntTrnsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_INT_TRANSFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrns GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(transactionManager, _edStudIntTrnsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_INT_TRANSFER index.
		/// </summary>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrns GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId, int start, int pageLength, out int count)
		{
			return GetByEdStudIntTrnsId(null, _edStudIntTrnsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_INT_TRANSFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudIntTrns GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudIntTrns&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudIntTrns&gt;"/></returns>
		public static TList<EdStudIntTrns> Fill(IDataReader reader, TList<EdStudIntTrns> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudIntTrns c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudIntTrns")
					.Append("|").Append((System.Decimal)reader["ED_STUD_INT_TRNS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudIntTrns>(
					key.ToString(), // EntityTrackingKey
					"EdStudIntTrns",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudIntTrns();
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
					c.EdStudIntTrnsId = (System.Decimal)reader["ED_STUD_INT_TRNS_ID"];
					c.OriginalEdStudIntTrnsId = c.EdStudIntTrnsId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.ReqDate = Convert.IsDBNull(reader["REQ_DATE"]) ? null : (System.DateTime?)reader["REQ_DATE"];
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.ReqStatusDate = Convert.IsDBNull(reader["REQ_STATUS_DATE"]) ? null : (System.DateTime?)reader["REQ_STATUS_DATE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.IsApplied = (System.Decimal)reader["IS_APPLIED"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AdmCodeTransferTypeId = (System.Decimal)reader["ADM_CODE_TRANSFER_TYPE_ID"];
					c.EdAcadYearReqId = Convert.IsDBNull(reader["ED_ACAD_YEAR_REQ_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_REQ_ID"];
					c.EdCodeSemesterReqId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_REQ_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_REQ_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudIntTrns entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudIntTrnsId = (System.Decimal)reader[((int)EdStudIntTrnsColumn.EdStudIntTrnsId - 1)];
			entity.OriginalEdStudIntTrnsId = (System.Decimal)reader["ED_STUD_INT_TRNS_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudIntTrnsColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdStudIntTrnsColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdStudIntTrnsColumn.EdCodeSemesterId - 1)];
			entity.ReqDate = (reader.IsDBNull(((int)EdStudIntTrnsColumn.ReqDate - 1)))?null:(System.DateTime?)reader[((int)EdStudIntTrnsColumn.ReqDate - 1)];
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)EdStudIntTrnsColumn.GsCodeReqStatusId - 1)];
			entity.ReqStatusDate = (reader.IsDBNull(((int)EdStudIntTrnsColumn.ReqStatusDate - 1)))?null:(System.DateTime?)reader[((int)EdStudIntTrnsColumn.ReqStatusDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudIntTrnsColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudIntTrnsColumn.Notes - 1)];
			entity.IsApplied = (System.Decimal)reader[((int)EdStudIntTrnsColumn.IsApplied - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudIntTrnsColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsColumn.AsFacultyInfoId - 1)];
			entity.AdmCodeTransferTypeId = (System.Decimal)reader[((int)EdStudIntTrnsColumn.AdmCodeTransferTypeId - 1)];
			entity.EdAcadYearReqId = (reader.IsDBNull(((int)EdStudIntTrnsColumn.EdAcadYearReqId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsColumn.EdAcadYearReqId - 1)];
			entity.EdCodeSemesterReqId = (reader.IsDBNull(((int)EdStudIntTrnsColumn.EdCodeSemesterReqId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsColumn.EdCodeSemesterReqId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudIntTrns entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudIntTrnsId = (System.Decimal)dataRow["ED_STUD_INT_TRNS_ID"];
			entity.OriginalEdStudIntTrnsId = (System.Decimal)dataRow["ED_STUD_INT_TRNS_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.ReqDate = Convert.IsDBNull(dataRow["REQ_DATE"]) ? null : (System.DateTime?)dataRow["REQ_DATE"];
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.ReqStatusDate = Convert.IsDBNull(dataRow["REQ_STATUS_DATE"]) ? null : (System.DateTime?)dataRow["REQ_STATUS_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.IsApplied = (System.Decimal)dataRow["IS_APPLIED"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AdmCodeTransferTypeId = (System.Decimal)dataRow["ADM_CODE_TRANSFER_TYPE_ID"];
			entity.EdAcadYearReqId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_REQ_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_REQ_ID"];
			entity.EdCodeSemesterReqId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_REQ_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_REQ_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrns"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudIntTrns Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrns entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCodeTransferTypeIdSource	
			if (CanDeepLoad(entity, "AdmCodeTransferType|AdmCodeTransferTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmCodeTransferTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCodeTransferTypeId;
				AdmCodeTransferType tmpEntity = EntityManager.LocateEntity<AdmCodeTransferType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCodeTransferType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCodeTransferTypeIdSource = tmpEntity;
				else
					entity.AdmCodeTransferTypeIdSource = DataRepository.AdmCodeTransferTypeProvider.GetByAdmCodeTransferTypeId(transactionManager, entity.AdmCodeTransferTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeTransferTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCodeTransferTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCodeTransferTypeProvider.DeepLoad(transactionManager, entity.AdmCodeTransferTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCodeTransferTypeIdSource

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

			#region EdAcadYearReqIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearReqIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearReqId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearReqIdSource = tmpEntity;
				else
					entity.EdAcadYearReqIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearReqId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearReqIdSource

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

			#region EdCodeSemesterReqIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterReqIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterReqId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterReqIdSource = tmpEntity;
				else
					entity.EdCodeSemesterReqIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterReqId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterReqIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudIntTrnsId methods when available
			
			#region EdStudIntTrnsStateToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateToCollection = DataRepository.EdStudIntTrnsStateToProvider.GetByEdStudIntTrnsId(transactionManager, entity.EdStudIntTrnsId);

				if (deep && entity.EdStudIntTrnsStateToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateTo>) DataRepository.EdStudIntTrnsStateToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByEdStudIntTrnsId(transactionManager, entity.EdStudIntTrnsId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateFromCollection = DataRepository.EdStudIntTrnsStateFromProvider.GetByEdStudIntTrnsId(transactionManager, entity.EdStudIntTrnsId);

				if (deep && entity.EdStudIntTrnsStateFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateFrom>) DataRepository.EdStudIntTrnsStateFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByEdStudIntTrnsId(transactionManager, entity.EdStudIntTrnsId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmIntTransferAcceptanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmIntTransferAcceptance>|AdmIntTransferAcceptanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmIntTransferAcceptanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmIntTransferAcceptanceCollection = DataRepository.AdmIntTransferAcceptanceProvider.GetByEdStudIntTrnsId(transactionManager, entity.EdStudIntTrnsId);

				if (deep && entity.AdmIntTransferAcceptanceCollection.Count > 0)
				{
					deepHandles.Add("AdmIntTransferAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmIntTransferAcceptance>) DataRepository.AdmIntTransferAcceptanceProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmIntTransferAcceptanceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudIntTrns object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudIntTrns instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudIntTrns Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrns entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCodeTransferTypeIdSource
			if (CanDeepSave(entity, "AdmCodeTransferType|AdmCodeTransferTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCodeTransferTypeIdSource != null)
			{
				DataRepository.AdmCodeTransferTypeProvider.Save(transactionManager, entity.AdmCodeTransferTypeIdSource);
				entity.AdmCodeTransferTypeId = entity.AdmCodeTransferTypeIdSource.AdmCodeTransferTypeId;
			}
			#endregion 
			
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
			
			#region EdAcadYearReqIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearReqIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearReqIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearReqIdSource);
				entity.EdAcadYearReqId = entity.EdAcadYearReqIdSource.EdAcadYearId;
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
			
			#region EdCodeSemesterReqIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterReqIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterReqIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterReqIdSource);
				entity.EdCodeSemesterReqId = entity.EdCodeSemesterReqIdSource.EdCodeSemesterId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudIntTrnsStateTo>
				if (CanDeepSave(entity.EdStudIntTrnsStateToCollection, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateTo child in entity.EdStudIntTrnsStateToCollection)
					{
						if(child.EdStudIntTrnsIdSource != null)
						{
							child.EdStudIntTrnsId = child.EdStudIntTrnsIdSource.EdStudIntTrnsId;
						}
						else
						{
							child.EdStudIntTrnsId = entity.EdStudIntTrnsId;
						}

					}

					if (entity.EdStudIntTrnsStateToCollection.Count > 0 || entity.EdStudIntTrnsStateToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateToProvider.Save(transactionManager, entity.EdStudIntTrnsStateToCollection);
						
						deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateTo >) DataRepository.EdStudIntTrnsStateToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseTo>
				if (CanDeepSave(entity.EdStudIntTrnsCourseToCollection, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseTo child in entity.EdStudIntTrnsCourseToCollection)
					{
						if(child.EdStudIntTrnsIdSource != null)
						{
							child.EdStudIntTrnsId = child.EdStudIntTrnsIdSource.EdStudIntTrnsId;
						}
						else
						{
							child.EdStudIntTrnsId = entity.EdStudIntTrnsId;
						}

					}

					if (entity.EdStudIntTrnsCourseToCollection.Count > 0 || entity.EdStudIntTrnsCourseToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseToProvider.Save(transactionManager, entity.EdStudIntTrnsCourseToCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseTo >) DataRepository.EdStudIntTrnsCourseToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateFrom>
				if (CanDeepSave(entity.EdStudIntTrnsStateFromCollection, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateFrom child in entity.EdStudIntTrnsStateFromCollection)
					{
						if(child.EdStudIntTrnsIdSource != null)
						{
							child.EdStudIntTrnsId = child.EdStudIntTrnsIdSource.EdStudIntTrnsId;
						}
						else
						{
							child.EdStudIntTrnsId = entity.EdStudIntTrnsId;
						}

					}

					if (entity.EdStudIntTrnsStateFromCollection.Count > 0 || entity.EdStudIntTrnsStateFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateFromProvider.Save(transactionManager, entity.EdStudIntTrnsStateFromCollection);
						
						deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateFrom >) DataRepository.EdStudIntTrnsStateFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseFrom>
				if (CanDeepSave(entity.EdStudIntTrnsCourseFromCollection, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseFrom child in entity.EdStudIntTrnsCourseFromCollection)
					{
						if(child.EdStudIntTrnsIdSource != null)
						{
							child.EdStudIntTrnsId = child.EdStudIntTrnsIdSource.EdStudIntTrnsId;
						}
						else
						{
							child.EdStudIntTrnsId = entity.EdStudIntTrnsId;
						}

					}

					if (entity.EdStudIntTrnsCourseFromCollection.Count > 0 || entity.EdStudIntTrnsCourseFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseFromProvider.Save(transactionManager, entity.EdStudIntTrnsCourseFromCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseFrom >) DataRepository.EdStudIntTrnsCourseFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmIntTransferAcceptance>
				if (CanDeepSave(entity.AdmIntTransferAcceptanceCollection, "List<AdmIntTransferAcceptance>|AdmIntTransferAcceptanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmIntTransferAcceptance child in entity.AdmIntTransferAcceptanceCollection)
					{
						if(child.EdStudIntTrnsIdSource != null)
						{
							child.EdStudIntTrnsId = child.EdStudIntTrnsIdSource.EdStudIntTrnsId;
						}
						else
						{
							child.EdStudIntTrnsId = entity.EdStudIntTrnsId;
						}

					}

					if (entity.AdmIntTransferAcceptanceCollection.Count > 0 || entity.AdmIntTransferAcceptanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmIntTransferAcceptanceProvider.Save(transactionManager, entity.AdmIntTransferAcceptanceCollection);
						
						deepHandles.Add("AdmIntTransferAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmIntTransferAcceptance >) DataRepository.AdmIntTransferAcceptanceProvider.DeepSave,
							new object[] { transactionManager, entity.AdmIntTransferAcceptanceCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudIntTrnsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudIntTrns</c>
	///</summary>
	public enum EdStudIntTrnsChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCodeTransferType</c> at AdmCodeTransferTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCodeTransferType))]
		AdmCodeTransferType,
		
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
		/// Collection of <c>EdStudIntTrns</c> as OneToMany for EdStudIntTrnsStateToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateTo>))]
		EdStudIntTrnsStateToCollection,
		///<summary>
		/// Collection of <c>EdStudIntTrns</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>EdStudIntTrns</c> as OneToMany for EdStudIntTrnsStateFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateFrom>))]
		EdStudIntTrnsStateFromCollection,
		///<summary>
		/// Collection of <c>EdStudIntTrns</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>EdStudIntTrns</c> as OneToMany for AdmIntTransferAcceptanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmIntTransferAcceptance>))]
		AdmIntTransferAcceptanceCollection,
	}
	
	#endregion EdStudIntTrnsChildEntityTypes
	
	#region EdStudIntTrnsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudIntTrnsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudIntTrns"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudIntTrnsFilterBuilder : SqlFilterBuilder<EdStudIntTrnsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsFilterBuilder class.
		/// </summary>
		public EdStudIntTrnsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudIntTrnsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudIntTrnsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudIntTrnsFilterBuilder
	
	#region EdStudIntTrnsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudIntTrnsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudIntTrns"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudIntTrnsParameterBuilder : ParameterizedSqlFilterBuilder<EdStudIntTrnsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsParameterBuilder class.
		/// </summary>
		public EdStudIntTrnsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudIntTrnsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudIntTrnsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudIntTrnsParameterBuilder
	
	#region EdStudIntTrnsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudIntTrnsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudIntTrns"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudIntTrnsSortBuilder : SqlSortBuilder<EdStudIntTrnsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsSqlSortBuilder class.
		/// </summary>
		public EdStudIntTrnsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudIntTrnsSortBuilder
	
} // end namespace
