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
	/// This class is the base class for any <see cref="AccomStudReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudReq, UMIS_VER2.BusinessLyer.AccomStudReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudReqKey key)
		{
			return Delete(transactionManager, key.AccomStudReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudReqId)
		{
			return Delete(null, _accomStudReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ACCOM_CDE_ROOM_TYPE key.
		///		FK_ACCOM_STUD_REQ_ACCOM_CDE_ROOM_TYPE Description: 
		/// </summary>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة  فردى ثنائي ثلاثى....</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByAccomCdeRoomTypeId(System.Int32? _accomCdeRoomTypeId)
		{
			int count = -1;
			return GetByAccomCdeRoomTypeId(_accomCdeRoomTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ACCOM_CDE_ROOM_TYPE key.
		///		FK_ACCOM_STUD_REQ_ACCOM_CDE_ROOM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة  فردى ثنائي ثلاثى....</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudReq> GetByAccomCdeRoomTypeId(TransactionManager transactionManager, System.Int32? _accomCdeRoomTypeId)
		{
			int count = -1;
			return GetByAccomCdeRoomTypeId(transactionManager, _accomCdeRoomTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ACCOM_CDE_ROOM_TYPE key.
		///		FK_ACCOM_STUD_REQ_ACCOM_CDE_ROOM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة  فردى ثنائي ثلاثى....</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByAccomCdeRoomTypeId(TransactionManager transactionManager, System.Int32? _accomCdeRoomTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeRoomTypeId(transactionManager, _accomCdeRoomTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ACCOM_CDE_ROOM_TYPE key.
		///		fkAccomStudReqAccomCdeRoomType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة  فردى ثنائي ثلاثى....</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByAccomCdeRoomTypeId(System.Int32? _accomCdeRoomTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomCdeRoomTypeId(null, _accomCdeRoomTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ACCOM_CDE_ROOM_TYPE key.
		///		fkAccomStudReqAccomCdeRoomType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة  فردى ثنائي ثلاثى....</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByAccomCdeRoomTypeId(System.Int32? _accomCdeRoomTypeId, int start, int pageLength,out int count)
		{
			return GetByAccomCdeRoomTypeId(null, _accomCdeRoomTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ACCOM_CDE_ROOM_TYPE key.
		///		FK_ACCOM_STUD_REQ_ACCOM_CDE_ROOM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeRoomTypeId">نوع الغرفة  فردى ثنائي ثلاثى....</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public abstract TList<AccomStudReq> GetByAccomCdeRoomTypeId(TransactionManager transactionManager, System.Int32? _accomCdeRoomTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_ACAD_YEAR key.
		///		fkAccomStudReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_ACAD_YEAR key.
		///		fkAccomStudReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public abstract TList<AccomStudReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_CODE_SEMESTER key.
		///		fkAccomStudReqEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_CODE_SEMESTER key.
		///		fkAccomStudReqEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_REQ_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public abstract TList<AccomStudReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_STUD key.
		///		FK_ACCOM_STUD_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_STUD key.
		///		FK_ACCOM_STUD_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_STUD key.
		///		FK_ACCOM_STUD_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_STUD key.
		///		fkAccomStudReqEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_STUD key.
		///		fkAccomStudReqEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_ED_STUD key.
		///		FK_ACCOM_STUD_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public abstract TList<AccomStudReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_CODE_ITEM key.
		///		FK_ACCOM_STUD_REQ_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId">FEE_CODE_TYPE_ID=10*</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_CODE_ITEM key.
		///		FK_ACCOM_STUD_REQ_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">FEE_CODE_TYPE_ID=10*</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudReq> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_CODE_ITEM key.
		///		FK_ACCOM_STUD_REQ_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">FEE_CODE_TYPE_ID=10*</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_CODE_ITEM key.
		///		fkAccomStudReqFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">FEE_CODE_TYPE_ID=10*</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_CODE_ITEM key.
		///		fkAccomStudReqFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">FEE_CODE_TYPE_ID=10*</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_CODE_ITEM key.
		///		FK_ACCOM_STUD_REQ_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">FEE_CODE_TYPE_ID=10*</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public abstract TList<AccomStudReq> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_STUD_FEE_ITEM key.
		///		FK_ACCOM_STUD_REQ_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudFeeItemId">بند مصروف سكن على الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(_feeStudFeeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_STUD_FEE_ITEM key.
		///		FK_ACCOM_STUD_REQ_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بند مصروف سكن على الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudReq> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_STUD_FEE_ITEM key.
		///		FK_ACCOM_STUD_REQ_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بند مصروف سكن على الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_STUD_FEE_ITEM key.
		///		fkAccomStudReqFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بند مصروف سكن على الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_STUD_FEE_ITEM key.
		///		fkAccomStudReqFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بند مصروف سكن على الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_FEE_STUD_FEE_ITEM key.
		///		FK_ACCOM_STUD_REQ_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بند مصروف سكن على الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public abstract TList<AccomStudReq> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_CURRENCY key.
		///		FK_ACCOM_STUD_REQ_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId">العملة =default*</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_CURRENCY key.
		///		FK_ACCOM_STUD_REQ_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">العملة =default*</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudReq> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_CURRENCY key.
		///		FK_ACCOM_STUD_REQ_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">العملة =default*</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_CURRENCY key.
		///		fkAccomStudReqGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">العملة =default*</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_CURRENCY key.
		///		fkAccomStudReqGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">العملة =default*</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_CURRENCY key.
		///		FK_ACCOM_STUD_REQ_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">العملة =default*</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public abstract TList<AccomStudReq> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		fkAccomStudReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		fkAccomStudReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public TList<AccomStudReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">حالة الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudReq objects.</returns>
		public abstract TList<AccomStudReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudReqKey key, int start, int pageLength)
		{
			return GetByAccomStudReqId(transactionManager, key.AccomStudReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_REQ index.
		/// </summary>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudReq GetByAccomStudReqId(System.Decimal _accomStudReqId)
		{
			int count = -1;
			return GetByAccomStudReqId(null,_accomStudReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_REQ index.
		/// </summary>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudReq GetByAccomStudReqId(System.Decimal _accomStudReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudReqId(null, _accomStudReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudReq GetByAccomStudReqId(TransactionManager transactionManager, System.Decimal _accomStudReqId)
		{
			int count = -1;
			return GetByAccomStudReqId(transactionManager, _accomStudReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudReq GetByAccomStudReqId(TransactionManager transactionManager, System.Decimal _accomStudReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudReqId(transactionManager, _accomStudReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_REQ index.
		/// </summary>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudReq GetByAccomStudReqId(System.Decimal _accomStudReqId, int start, int pageLength, out int count)
		{
			return GetByAccomStudReqId(null, _accomStudReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudReqId">Accomodation  طلب اقامة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudReq GetByAccomStudReqId(TransactionManager transactionManager, System.Decimal _accomStudReqId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudReq&gt;"/></returns>
		public static TList<AccomStudReq> Fill(IDataReader reader, TList<AccomStudReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudReq")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudReq>(
					key.ToString(), // EntityTrackingKey
					"AccomStudReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudReq();
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
					c.AccomStudReqId = (System.Decimal)reader["ACCOM_STUD_REQ_ID"];
					c.OriginalAccomStudReqId = c.AccomStudReqId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.MaritalFlg = (System.Boolean)reader["MARITAL_FLG"];
					c.AccomInFlg = (System.Boolean)reader["ACCOM_IN_FLG"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.AccomCdeRoomTypeId = Convert.IsDBNull(reader["ACCOM_CDE_ROOM_TYPE_ID"]) ? null : (System.Int32?)reader["ACCOM_CDE_ROOM_TYPE_ID"];
					c.FeeCodeItemId = Convert.IsDBNull(reader["FEE_CODE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_ITEM_ID"];
					c.FeeAmount = Convert.IsDBNull(reader["FEE_AMOUNT"]) ? null : (System.Decimal?)reader["FEE_AMOUNT"];
					c.GsCodeCurrencyId = Convert.IsDBNull(reader["GS_CODE_CURRENCY_ID"]) ? null : (System.Decimal?)reader["GS_CODE_CURRENCY_ID"];
					c.FeeStudFeeItemId = Convert.IsDBNull(reader["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_FEE_ITEM_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Int32?)reader["APPROVE_FLG"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
					c.AttchdDocPath = Convert.IsDBNull(reader["ATTCHD_DOC_PATH"]) ? null : (System.String)reader["ATTCHD_DOC_PATH"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.ReqNum = Convert.IsDBNull(reader["REQ_NUM"]) ? null : (System.Decimal?)reader["REQ_NUM"];
					c.AirCondFlg = Convert.IsDBNull(reader["AIR_COND_FLG"]) ? null : (System.Boolean?)reader["AIR_COND_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudReq entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudReqId = (System.Decimal)reader[((int)AccomStudReqColumn.AccomStudReqId - 1)];
			entity.OriginalAccomStudReqId = (System.Decimal)reader["ACCOM_STUD_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)AccomStudReqColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)AccomStudReqColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)AccomStudReqColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)AccomStudReqColumn.EdStudId - 1)];
			entity.MaritalFlg = (System.Boolean)reader[((int)AccomStudReqColumn.MaritalFlg - 1)];
			entity.AccomInFlg = (System.Boolean)reader[((int)AccomStudReqColumn.AccomInFlg - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)AccomStudReqColumn.ReqDate - 1)];
			entity.AccomCdeRoomTypeId = (reader.IsDBNull(((int)AccomStudReqColumn.AccomCdeRoomTypeId - 1)))?null:(System.Int32?)reader[((int)AccomStudReqColumn.AccomCdeRoomTypeId - 1)];
			entity.FeeCodeItemId = (reader.IsDBNull(((int)AccomStudReqColumn.FeeCodeItemId - 1)))?null:(System.Decimal?)reader[((int)AccomStudReqColumn.FeeCodeItemId - 1)];
			entity.FeeAmount = (reader.IsDBNull(((int)AccomStudReqColumn.FeeAmount - 1)))?null:(System.Decimal?)reader[((int)AccomStudReqColumn.FeeAmount - 1)];
			entity.GsCodeCurrencyId = (reader.IsDBNull(((int)AccomStudReqColumn.GsCodeCurrencyId - 1)))?null:(System.Decimal?)reader[((int)AccomStudReqColumn.GsCodeCurrencyId - 1)];
			entity.FeeStudFeeItemId = (reader.IsDBNull(((int)AccomStudReqColumn.FeeStudFeeItemId - 1)))?null:(System.Decimal?)reader[((int)AccomStudReqColumn.FeeStudFeeItemId - 1)];
			entity.Notes = (reader.IsDBNull(((int)AccomStudReqColumn.Notes - 1)))?null:(System.String)reader[((int)AccomStudReqColumn.Notes - 1)];
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)AccomStudReqColumn.GsCodeReqStatusId - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)AccomStudReqColumn.ApproveFlg - 1)))?null:(System.Int32?)reader[((int)AccomStudReqColumn.ApproveFlg - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)AccomStudReqColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudReqColumn.ApproveDate - 1)];
			entity.AttchdDocPath = (reader.IsDBNull(((int)AccomStudReqColumn.AttchdDocPath - 1)))?null:(System.String)reader[((int)AccomStudReqColumn.AttchdDocPath - 1)];
			entity.FromDate = (reader.IsDBNull(((int)AccomStudReqColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudReqColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)AccomStudReqColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudReqColumn.ToDate - 1)];
			entity.ReqNum = (reader.IsDBNull(((int)AccomStudReqColumn.ReqNum - 1)))?null:(System.Decimal?)reader[((int)AccomStudReqColumn.ReqNum - 1)];
			entity.AirCondFlg = (reader.IsDBNull(((int)AccomStudReqColumn.AirCondFlg - 1)))?null:(System.Boolean?)reader[((int)AccomStudReqColumn.AirCondFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudReqColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudReqColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudReqColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudReqId = (System.Decimal)dataRow["ACCOM_STUD_REQ_ID"];
			entity.OriginalAccomStudReqId = (System.Decimal)dataRow["ACCOM_STUD_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.MaritalFlg = (System.Boolean)dataRow["MARITAL_FLG"];
			entity.AccomInFlg = (System.Boolean)dataRow["ACCOM_IN_FLG"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.AccomCdeRoomTypeId = Convert.IsDBNull(dataRow["ACCOM_CDE_ROOM_TYPE_ID"]) ? null : (System.Int32?)dataRow["ACCOM_CDE_ROOM_TYPE_ID"];
			entity.FeeCodeItemId = Convert.IsDBNull(dataRow["FEE_CODE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_ITEM_ID"];
			entity.FeeAmount = Convert.IsDBNull(dataRow["FEE_AMOUNT"]) ? null : (System.Decimal?)dataRow["FEE_AMOUNT"];
			entity.GsCodeCurrencyId = Convert.IsDBNull(dataRow["GS_CODE_CURRENCY_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_CURRENCY_ID"];
			entity.FeeStudFeeItemId = Convert.IsDBNull(dataRow["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Int32?)dataRow["APPROVE_FLG"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
			entity.AttchdDocPath = Convert.IsDBNull(dataRow["ATTCHD_DOC_PATH"]) ? null : (System.String)dataRow["ATTCHD_DOC_PATH"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.ReqNum = Convert.IsDBNull(dataRow["REQ_NUM"]) ? null : (System.Decimal?)dataRow["REQ_NUM"];
			entity.AirCondFlg = Convert.IsDBNull(dataRow["AIR_COND_FLG"]) ? null : (System.Boolean?)dataRow["AIR_COND_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomCdeRoomTypeIdSource	
			if (CanDeepLoad(entity, "AccomCdeRoomType|AccomCdeRoomTypeIdSource", deepLoadType, innerList) 
				&& entity.AccomCdeRoomTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AccomCdeRoomTypeId ?? (int)0);
				AccomCdeRoomType tmpEntity = EntityManager.LocateEntity<AccomCdeRoomType>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomCdeRoomType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomCdeRoomTypeIdSource = tmpEntity;
				else
					entity.AccomCdeRoomTypeIdSource = DataRepository.AccomCdeRoomTypeProvider.GetByAccomCdeRoomTypeId(transactionManager, (entity.AccomCdeRoomTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomCdeRoomTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomCdeRoomTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomCdeRoomTypeProvider.DeepLoad(transactionManager, entity.AccomCdeRoomTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomCdeRoomTypeIdSource

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

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeItemId ?? 0.0m);
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, (entity.FeeCodeItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemIdSource

			#region FeeStudFeeItemIdSource	
			if (CanDeepLoad(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeStudFeeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudFeeItemId ?? 0.0m);
				FeeStudFeeItem tmpEntity = EntityManager.LocateEntity<FeeStudFeeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudFeeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudFeeItemIdSource = tmpEntity;
				else
					entity.FeeStudFeeItemIdSource = DataRepository.FeeStudFeeItemProvider.GetByFeeStudFeeItemId(transactionManager, (entity.FeeStudFeeItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudFeeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudFeeItemProvider.DeepLoad(transactionManager, entity.FeeStudFeeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudFeeItemIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeCurrencyId ?? 0.0m);
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, (entity.GsCodeCurrencyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.GsCodeCurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCurrencyIdSource

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
			// Deep load child collections  - Call GetByAccomStudReqId methods when available
			
			#region AccomWfRequestApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomWfRequestApprove>|AccomWfRequestApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomWfRequestApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomWfRequestApproveCollection = DataRepository.AccomWfRequestApproveProvider.GetByAccomStudReqId(transactionManager, entity.AccomStudReqId);

				if (deep && entity.AccomWfRequestApproveCollection.Count > 0)
				{
					deepHandles.Add("AccomWfRequestApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomWfRequestApprove>) DataRepository.AccomWfRequestApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomWfRequestApproveCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomCdeRoomTypeIdSource
			if (CanDeepSave(entity, "AccomCdeRoomType|AccomCdeRoomTypeIdSource", deepSaveType, innerList) 
				&& entity.AccomCdeRoomTypeIdSource != null)
			{
				DataRepository.AccomCdeRoomTypeProvider.Save(transactionManager, entity.AccomCdeRoomTypeIdSource);
				entity.AccomCdeRoomTypeId = entity.AccomCdeRoomTypeIdSource.AccomCdeRoomTypeId;
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
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
			}
			#endregion 
			
			#region FeeStudFeeItemIdSource
			if (CanDeepSave(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeStudFeeItemIdSource != null)
			{
				DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemIdSource);
				entity.FeeStudFeeItemId = entity.FeeStudFeeItemIdSource.FeeStudFeeItemId;
			}
			#endregion 
			
			#region GsCodeCurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.GsCodeCurrencyIdSource);
				entity.GsCodeCurrencyId = entity.GsCodeCurrencyIdSource.GsCodeCurrencyId;
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
	
			#region List<AccomWfRequestApprove>
				if (CanDeepSave(entity.AccomWfRequestApproveCollection, "List<AccomWfRequestApprove>|AccomWfRequestApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomWfRequestApprove child in entity.AccomWfRequestApproveCollection)
					{
						if(child.AccomStudReqIdSource != null)
						{
							child.AccomStudReqId = child.AccomStudReqIdSource.AccomStudReqId;
						}
						else
						{
							child.AccomStudReqId = entity.AccomStudReqId;
						}

					}

					if (entity.AccomWfRequestApproveCollection.Count > 0 || entity.AccomWfRequestApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomWfRequestApproveProvider.Save(transactionManager, entity.AccomWfRequestApproveCollection);
						
						deepHandles.Add("AccomWfRequestApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomWfRequestApprove >) DataRepository.AccomWfRequestApproveProvider.DeepSave,
							new object[] { transactionManager, entity.AccomWfRequestApproveCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomStudReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudReq</c>
	///</summary>
	public enum AccomStudReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomCdeRoomType</c> at AccomCdeRoomTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AccomCdeRoomType))]
		AccomCdeRoomType,
		
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
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>FeeStudFeeItem</c> at FeeStudFeeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudFeeItem))]
		FeeStudFeeItem,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
		///<summary>
		/// Collection of <c>AccomStudReq</c> as OneToMany for AccomWfRequestApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomWfRequestApprove>))]
		AccomWfRequestApproveCollection,
	}
	
	#endregion AccomStudReqChildEntityTypes
	
	#region AccomStudReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudReqFilterBuilder : SqlFilterBuilder<AccomStudReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudReqFilterBuilder class.
		/// </summary>
		public AccomStudReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudReqFilterBuilder
	
	#region AccomStudReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudReqParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudReqParameterBuilder class.
		/// </summary>
		public AccomStudReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudReqParameterBuilder
	
	#region AccomStudReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudReqSortBuilder : SqlSortBuilder<AccomStudReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudReqSqlSortBuilder class.
		/// </summary>
		public AccomStudReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudReqSortBuilder
	
} // end namespace
