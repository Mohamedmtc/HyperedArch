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
	/// This class is the base class for any <see cref="AccomStudBookProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudBookProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudBook, UMIS_VER2.BusinessLyer.AccomStudBookKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudBookKey key)
		{
			return Delete(transactionManager, key.AccomStudBookId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudBookId)
		{
			return Delete(null, _accomStudBookId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudBookId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_BED key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_BED Description: 
		/// </summary>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomBedId(System.Decimal _accomBedId)
		{
			int count = -1;
			return GetByAccomBedId(_accomBedId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_BED key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_BED Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudBook> GetByAccomBedId(TransactionManager transactionManager, System.Decimal _accomBedId)
		{
			int count = -1;
			return GetByAccomBedId(transactionManager, _accomBedId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_BED key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_BED Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomBedId(TransactionManager transactionManager, System.Decimal _accomBedId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomBedId(transactionManager, _accomBedId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_BED key.
		///		fkAccomStudBookAccomBed Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomBedId(System.Decimal _accomBedId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomBedId(null, _accomBedId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_BED key.
		///		fkAccomStudBookAccomBed Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomBedId(System.Decimal _accomBedId, int start, int pageLength,out int count)
		{
			return GetByAccomBedId(null, _accomBedId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_BED key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_BED Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public abstract TList<AccomStudBook> GetByAccomBedId(TransactionManager transactionManager, System.Decimal _accomBedId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_CDE_BOOK_STATUS key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_CDE_BOOK_STATUS Description: 
		/// </summary>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير
		/// 		/// Default=1 مع التسكين يدوى او الى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomCdeBookStatusId(System.Int32? _accomCdeBookStatusId)
		{
			int count = -1;
			return GetByAccomCdeBookStatusId(_accomCdeBookStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_CDE_BOOK_STATUS key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_CDE_BOOK_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير
		/// 		/// Default=1 مع التسكين يدوى او الى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudBook> GetByAccomCdeBookStatusId(TransactionManager transactionManager, System.Int32? _accomCdeBookStatusId)
		{
			int count = -1;
			return GetByAccomCdeBookStatusId(transactionManager, _accomCdeBookStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_CDE_BOOK_STATUS key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_CDE_BOOK_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير
		/// 		/// Default=1 مع التسكين يدوى او الى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomCdeBookStatusId(TransactionManager transactionManager, System.Int32? _accomCdeBookStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeBookStatusId(transactionManager, _accomCdeBookStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_CDE_BOOK_STATUS key.
		///		fkAccomStudBookAccomCdeBookStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير
		/// 		/// Default=1 مع التسكين يدوى او الى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomCdeBookStatusId(System.Int32? _accomCdeBookStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomCdeBookStatusId(null, _accomCdeBookStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_CDE_BOOK_STATUS key.
		///		fkAccomStudBookAccomCdeBookStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير
		/// 		/// Default=1 مع التسكين يدوى او الى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomCdeBookStatusId(System.Int32? _accomCdeBookStatusId, int start, int pageLength,out int count)
		{
			return GetByAccomCdeBookStatusId(null, _accomCdeBookStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_CDE_BOOK_STATUS key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_CDE_BOOK_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeBookStatusId">حالة حجز الغرفة-السرير
		/// 		/// Default=1 مع التسكين يدوى او الى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public abstract TList<AccomStudBook> GetByAccomCdeBookStatusId(TransactionManager transactionManager, System.Int32? _accomCdeBookStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_ROOM key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="_accomRoomId">الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomRoomId(System.Decimal _accomRoomId)
		{
			int count = -1;
			return GetByAccomRoomId(_accomRoomId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_ROOM key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudBook> GetByAccomRoomId(TransactionManager transactionManager, System.Decimal _accomRoomId)
		{
			int count = -1;
			return GetByAccomRoomId(transactionManager, _accomRoomId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_ROOM key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomRoomId(TransactionManager transactionManager, System.Decimal _accomRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomRoomId(transactionManager, _accomRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_ROOM key.
		///		fkAccomStudBookAccomRoom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomRoomId(System.Decimal _accomRoomId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomRoomId(null, _accomRoomId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_ROOM key.
		///		fkAccomStudBookAccomRoom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByAccomRoomId(System.Decimal _accomRoomId, int start, int pageLength,out int count)
		{
			return GetByAccomRoomId(null, _accomRoomId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ACCOM_ROOM key.
		///		FK_ACCOM_STUD_BOOK_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public abstract TList<AccomStudBook> GetByAccomRoomId(TransactionManager transactionManager, System.Decimal _accomRoomId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_BOOK_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_BOOK_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudBook> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_BOOK_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_ACAD_YEAR key.
		///		fkAccomStudBookEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_ACAD_YEAR key.
		///		fkAccomStudBookEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_ACAD_YEAR key.
		///		FK_ACCOM_STUD_BOOK_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public abstract TList<AccomStudBook> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_BOOK_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_BOOK_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudBook> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_BOOK_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_CODE_SEMESTER key.
		///		fkAccomStudBookEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_CODE_SEMESTER key.
		///		fkAccomStudBookEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_CODE_SEMESTER key.
		///		FK_ACCOM_STUD_BOOK_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public abstract TList<AccomStudBook> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_STUD key.
		///		FK_ACCOM_STUD_BOOK_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_STUD key.
		///		FK_ACCOM_STUD_BOOK_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudBook> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_STUD key.
		///		FK_ACCOM_STUD_BOOK_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_STUD key.
		///		fkAccomStudBookEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_STUD key.
		///		fkAccomStudBookEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public TList<AccomStudBook> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_BOOK_ED_STUD key.
		///		FK_ACCOM_STUD_BOOK_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudBook objects.</returns>
		public abstract TList<AccomStudBook> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudBook Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudBookKey key, int start, int pageLength)
		{
			return GetByAccomStudBookId(transactionManager, key.AccomStudBookId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudBook GetByAccomStudBookId(System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(null,_accomStudBookId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudBook GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudBook GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudBook GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudBook GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength, out int count)
		{
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudBook GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudBook GetByEdStudIdEdAcadYearIdEdCodeSemesterId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterId(null,_edStudId, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudBook GetByEdStudIdEdAcadYearIdEdCodeSemesterId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudBook GetByEdStudIdEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudBook GetByEdStudIdEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudBook GetByEdStudIdEdAcadYearIdEdCodeSemesterId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ACCOM_STUD_BOOK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">الطالب</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudBook GetByEdStudIdEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudBook&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudBook&gt;"/></returns>
		public static TList<AccomStudBook> Fill(IDataReader reader, TList<AccomStudBook> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudBook c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudBook")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_BOOK_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudBook>(
					key.ToString(), // EntityTrackingKey
					"AccomStudBook",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudBook();
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
					c.AccomStudBookId = (System.Decimal)reader["ACCOM_STUD_BOOK_ID"];
					c.OriginalAccomStudBookId = c.AccomStudBookId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.AccomRoomId = (System.Decimal)reader["ACCOM_ROOM_ID"];
					c.AccomBedId = (System.Decimal)reader["ACCOM_BED_ID"];
					c.ApproveFlg = (System.Int32)reader["APPROVE_FLG"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
					c.ByforceFlg = (System.Boolean)reader["BYFORCE_FLG"];
					c.LeaderFlg = (System.Boolean)reader["LEADER_FLG"];
					c.AccomCdeBookStatusId = Convert.IsDBNull(reader["ACCOM_CDE_BOOK_STATUS_ID"]) ? null : (System.Int32?)reader["ACCOM_CDE_BOOK_STATUS_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudBook entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudBookId = (System.Decimal)reader[((int)AccomStudBookColumn.AccomStudBookId - 1)];
			entity.OriginalAccomStudBookId = (System.Decimal)reader["ACCOM_STUD_BOOK_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)AccomStudBookColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)AccomStudBookColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)AccomStudBookColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)AccomStudBookColumn.EdStudId - 1)];
			entity.AccomRoomId = (System.Decimal)reader[((int)AccomStudBookColumn.AccomRoomId - 1)];
			entity.AccomBedId = (System.Decimal)reader[((int)AccomStudBookColumn.AccomBedId - 1)];
			entity.ApproveFlg = (System.Int32)reader[((int)AccomStudBookColumn.ApproveFlg - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)AccomStudBookColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudBookColumn.ApproveDate - 1)];
			entity.ByforceFlg = (System.Boolean)reader[((int)AccomStudBookColumn.ByforceFlg - 1)];
			entity.LeaderFlg = (System.Boolean)reader[((int)AccomStudBookColumn.LeaderFlg - 1)];
			entity.AccomCdeBookStatusId = (reader.IsDBNull(((int)AccomStudBookColumn.AccomCdeBookStatusId - 1)))?null:(System.Int32?)reader[((int)AccomStudBookColumn.AccomCdeBookStatusId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudBookColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudBookColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudBookColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudBookColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudBook entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudBookId = (System.Decimal)dataRow["ACCOM_STUD_BOOK_ID"];
			entity.OriginalAccomStudBookId = (System.Decimal)dataRow["ACCOM_STUD_BOOK_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.AccomRoomId = (System.Decimal)dataRow["ACCOM_ROOM_ID"];
			entity.AccomBedId = (System.Decimal)dataRow["ACCOM_BED_ID"];
			entity.ApproveFlg = (System.Int32)dataRow["APPROVE_FLG"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
			entity.ByforceFlg = (System.Boolean)dataRow["BYFORCE_FLG"];
			entity.LeaderFlg = (System.Boolean)dataRow["LEADER_FLG"];
			entity.AccomCdeBookStatusId = Convert.IsDBNull(dataRow["ACCOM_CDE_BOOK_STATUS_ID"]) ? null : (System.Int32?)dataRow["ACCOM_CDE_BOOK_STATUS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudBook"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudBook Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudBook entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomBedIdSource	
			if (CanDeepLoad(entity, "AccomBed|AccomBedIdSource", deepLoadType, innerList) 
				&& entity.AccomBedIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomBedId;
				AccomBed tmpEntity = EntityManager.LocateEntity<AccomBed>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomBed), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomBedIdSource = tmpEntity;
				else
					entity.AccomBedIdSource = DataRepository.AccomBedProvider.GetByAccomBedId(transactionManager, entity.AccomBedId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomBedIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomBedIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomBedProvider.DeepLoad(transactionManager, entity.AccomBedIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomBedIdSource

			#region AccomCdeBookStatusIdSource	
			if (CanDeepLoad(entity, "AccomCdeBookStatus|AccomCdeBookStatusIdSource", deepLoadType, innerList) 
				&& entity.AccomCdeBookStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AccomCdeBookStatusId ?? (int)0);
				AccomCdeBookStatus tmpEntity = EntityManager.LocateEntity<AccomCdeBookStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomCdeBookStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomCdeBookStatusIdSource = tmpEntity;
				else
					entity.AccomCdeBookStatusIdSource = DataRepository.AccomCdeBookStatusProvider.GetByAccomCdeBookStatusId(transactionManager, (entity.AccomCdeBookStatusId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomCdeBookStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomCdeBookStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomCdeBookStatusProvider.DeepLoad(transactionManager, entity.AccomCdeBookStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomCdeBookStatusIdSource

			#region AccomRoomIdSource	
			if (CanDeepLoad(entity, "AccomRoom|AccomRoomIdSource", deepLoadType, innerList) 
				&& entity.AccomRoomIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomRoomId;
				AccomRoom tmpEntity = EntityManager.LocateEntity<AccomRoom>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomRoom), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomRoomIdSource = tmpEntity;
				else
					entity.AccomRoomIdSource = DataRepository.AccomRoomProvider.GetByAccomRoomId(transactionManager, entity.AccomRoomId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomRoomIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomRoomIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomRoomProvider.DeepLoad(transactionManager, entity.AccomRoomIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomRoomIdSource

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
			// Deep load child collections  - Call GetByAccomStudBookId methods when available
			
			#region AccomStudPermtReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudPermtReq>|AccomStudPermtReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudPermtReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudPermtReqCollection = DataRepository.AccomStudPermtReqProvider.GetByAccomStudBookId(transactionManager, entity.AccomStudBookId);

				if (deep && entity.AccomStudPermtReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudPermtReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudPermtReq>) DataRepository.AccomStudPermtReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudPermtReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudLeaveReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudLeaveReq>|AccomStudLeaveReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudLeaveReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudLeaveReqCollection = DataRepository.AccomStudLeaveReqProvider.GetByAccomStudBookId(transactionManager, entity.AccomStudBookId);

				if (deep && entity.AccomStudLeaveReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudLeaveReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudLeaveReq>) DataRepository.AccomStudLeaveReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudLeaveReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudFeedReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudFeedReq>|AccomStudFeedReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudFeedReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudFeedReqCollection = DataRepository.AccomStudFeedReqProvider.GetByAccomStudBookId(transactionManager, entity.AccomStudBookId);

				if (deep && entity.AccomStudFeedReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudFeedReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudFeedReq>) DataRepository.AccomStudFeedReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudFeedReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudGuestReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudGuestReq>|AccomStudGuestReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudGuestReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudGuestReqCollection = DataRepository.AccomStudGuestReqProvider.GetByAccomStudBookId(transactionManager, entity.AccomStudBookId);

				if (deep && entity.AccomStudGuestReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudGuestReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudGuestReq>) DataRepository.AccomStudGuestReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudGuestReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudAbsence>|AccomStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudAbsenceCollection = DataRepository.AccomStudAbsenceProvider.GetByAccomStudBookId(transactionManager, entity.AccomStudBookId);

				if (deep && entity.AccomStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("AccomStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudAbsence>) DataRepository.AccomStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudDismissCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudDismiss>|AccomStudDismissCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudDismissCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudDismissCollection = DataRepository.AccomStudDismissProvider.GetByAccomStudBookId(transactionManager, entity.AccomStudBookId);

				if (deep && entity.AccomStudDismissCollection.Count > 0)
				{
					deepHandles.Add("AccomStudDismissCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudDismiss>) DataRepository.AccomStudDismissProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudDismissCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudLateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudLate>|AccomStudLateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudLateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudLateCollection = DataRepository.AccomStudLateProvider.GetByAccomStudBookId(transactionManager, entity.AccomStudBookId);

				if (deep && entity.AccomStudLateCollection.Count > 0)
				{
					deepHandles.Add("AccomStudLateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudLate>) DataRepository.AccomStudLateProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudLateCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudBook object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudBook instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudBook Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudBook entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomBedIdSource
			if (CanDeepSave(entity, "AccomBed|AccomBedIdSource", deepSaveType, innerList) 
				&& entity.AccomBedIdSource != null)
			{
				DataRepository.AccomBedProvider.Save(transactionManager, entity.AccomBedIdSource);
				entity.AccomBedId = entity.AccomBedIdSource.AccomBedId;
			}
			#endregion 
			
			#region AccomCdeBookStatusIdSource
			if (CanDeepSave(entity, "AccomCdeBookStatus|AccomCdeBookStatusIdSource", deepSaveType, innerList) 
				&& entity.AccomCdeBookStatusIdSource != null)
			{
				DataRepository.AccomCdeBookStatusProvider.Save(transactionManager, entity.AccomCdeBookStatusIdSource);
				entity.AccomCdeBookStatusId = entity.AccomCdeBookStatusIdSource.AccomCdeBookStatusId;
			}
			#endregion 
			
			#region AccomRoomIdSource
			if (CanDeepSave(entity, "AccomRoom|AccomRoomIdSource", deepSaveType, innerList) 
				&& entity.AccomRoomIdSource != null)
			{
				DataRepository.AccomRoomProvider.Save(transactionManager, entity.AccomRoomIdSource);
				entity.AccomRoomId = entity.AccomRoomIdSource.AccomRoomId;
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
	
			#region List<AccomStudPermtReq>
				if (CanDeepSave(entity.AccomStudPermtReqCollection, "List<AccomStudPermtReq>|AccomStudPermtReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudPermtReq child in entity.AccomStudPermtReqCollection)
					{
						if(child.AccomStudBookIdSource != null)
						{
							child.AccomStudBookId = child.AccomStudBookIdSource.AccomStudBookId;
						}
						else
						{
							child.AccomStudBookId = entity.AccomStudBookId;
						}

					}

					if (entity.AccomStudPermtReqCollection.Count > 0 || entity.AccomStudPermtReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudPermtReqProvider.Save(transactionManager, entity.AccomStudPermtReqCollection);
						
						deepHandles.Add("AccomStudPermtReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudPermtReq >) DataRepository.AccomStudPermtReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudPermtReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudLeaveReq>
				if (CanDeepSave(entity.AccomStudLeaveReqCollection, "List<AccomStudLeaveReq>|AccomStudLeaveReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudLeaveReq child in entity.AccomStudLeaveReqCollection)
					{
						if(child.AccomStudBookIdSource != null)
						{
							child.AccomStudBookId = child.AccomStudBookIdSource.AccomStudBookId;
						}
						else
						{
							child.AccomStudBookId = entity.AccomStudBookId;
						}

					}

					if (entity.AccomStudLeaveReqCollection.Count > 0 || entity.AccomStudLeaveReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudLeaveReqProvider.Save(transactionManager, entity.AccomStudLeaveReqCollection);
						
						deepHandles.Add("AccomStudLeaveReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudLeaveReq >) DataRepository.AccomStudLeaveReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudLeaveReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudFeedReq>
				if (CanDeepSave(entity.AccomStudFeedReqCollection, "List<AccomStudFeedReq>|AccomStudFeedReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudFeedReq child in entity.AccomStudFeedReqCollection)
					{
						if(child.AccomStudBookIdSource != null)
						{
							child.AccomStudBookId = child.AccomStudBookIdSource.AccomStudBookId;
						}
						else
						{
							child.AccomStudBookId = entity.AccomStudBookId;
						}

					}

					if (entity.AccomStudFeedReqCollection.Count > 0 || entity.AccomStudFeedReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudFeedReqProvider.Save(transactionManager, entity.AccomStudFeedReqCollection);
						
						deepHandles.Add("AccomStudFeedReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudFeedReq >) DataRepository.AccomStudFeedReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudFeedReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudGuestReq>
				if (CanDeepSave(entity.AccomStudGuestReqCollection, "List<AccomStudGuestReq>|AccomStudGuestReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudGuestReq child in entity.AccomStudGuestReqCollection)
					{
						if(child.AccomStudBookIdSource != null)
						{
							child.AccomStudBookId = child.AccomStudBookIdSource.AccomStudBookId;
						}
						else
						{
							child.AccomStudBookId = entity.AccomStudBookId;
						}

					}

					if (entity.AccomStudGuestReqCollection.Count > 0 || entity.AccomStudGuestReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudGuestReqProvider.Save(transactionManager, entity.AccomStudGuestReqCollection);
						
						deepHandles.Add("AccomStudGuestReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudGuestReq >) DataRepository.AccomStudGuestReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudGuestReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudAbsence>
				if (CanDeepSave(entity.AccomStudAbsenceCollection, "List<AccomStudAbsence>|AccomStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudAbsence child in entity.AccomStudAbsenceCollection)
					{
						if(child.AccomStudBookIdSource != null)
						{
							child.AccomStudBookId = child.AccomStudBookIdSource.AccomStudBookId;
						}
						else
						{
							child.AccomStudBookId = entity.AccomStudBookId;
						}

					}

					if (entity.AccomStudAbsenceCollection.Count > 0 || entity.AccomStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudAbsenceProvider.Save(transactionManager, entity.AccomStudAbsenceCollection);
						
						deepHandles.Add("AccomStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudAbsence >) DataRepository.AccomStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudDismiss>
				if (CanDeepSave(entity.AccomStudDismissCollection, "List<AccomStudDismiss>|AccomStudDismissCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudDismiss child in entity.AccomStudDismissCollection)
					{
						if(child.AccomStudBookIdSource != null)
						{
							child.AccomStudBookId = child.AccomStudBookIdSource.AccomStudBookId;
						}
						else
						{
							child.AccomStudBookId = entity.AccomStudBookId;
						}

					}

					if (entity.AccomStudDismissCollection.Count > 0 || entity.AccomStudDismissCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudDismissProvider.Save(transactionManager, entity.AccomStudDismissCollection);
						
						deepHandles.Add("AccomStudDismissCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudDismiss >) DataRepository.AccomStudDismissProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudDismissCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudLate>
				if (CanDeepSave(entity.AccomStudLateCollection, "List<AccomStudLate>|AccomStudLateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudLate child in entity.AccomStudLateCollection)
					{
						if(child.AccomStudBookIdSource != null)
						{
							child.AccomStudBookId = child.AccomStudBookIdSource.AccomStudBookId;
						}
						else
						{
							child.AccomStudBookId = entity.AccomStudBookId;
						}

					}

					if (entity.AccomStudLateCollection.Count > 0 || entity.AccomStudLateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudLateProvider.Save(transactionManager, entity.AccomStudLateCollection);
						
						deepHandles.Add("AccomStudLateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudLate >) DataRepository.AccomStudLateProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudLateCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomStudBookChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudBook</c>
	///</summary>
	public enum AccomStudBookChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomBed</c> at AccomBedIdSource
		///</summary>
		[ChildEntityType(typeof(AccomBed))]
		AccomBed,
		
		///<summary>
		/// Composite Property for <c>AccomCdeBookStatus</c> at AccomCdeBookStatusIdSource
		///</summary>
		[ChildEntityType(typeof(AccomCdeBookStatus))]
		AccomCdeBookStatus,
		
		///<summary>
		/// Composite Property for <c>AccomRoom</c> at AccomRoomIdSource
		///</summary>
		[ChildEntityType(typeof(AccomRoom))]
		AccomRoom,
		
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
		/// Collection of <c>AccomStudBook</c> as OneToMany for AccomStudPermtReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudPermtReq>))]
		AccomStudPermtReqCollection,
		///<summary>
		/// Collection of <c>AccomStudBook</c> as OneToMany for AccomStudLeaveReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudLeaveReq>))]
		AccomStudLeaveReqCollection,
		///<summary>
		/// Collection of <c>AccomStudBook</c> as OneToMany for AccomStudFeedReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudFeedReq>))]
		AccomStudFeedReqCollection,
		///<summary>
		/// Collection of <c>AccomStudBook</c> as OneToMany for AccomStudGuestReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudGuestReq>))]
		AccomStudGuestReqCollection,
		///<summary>
		/// Collection of <c>AccomStudBook</c> as OneToMany for AccomStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudAbsence>))]
		AccomStudAbsenceCollection,
		///<summary>
		/// Collection of <c>AccomStudBook</c> as OneToMany for AccomStudDismissCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudDismiss>))]
		AccomStudDismissCollection,
		///<summary>
		/// Collection of <c>AccomStudBook</c> as OneToMany for AccomStudLateCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudLate>))]
		AccomStudLateCollection,
	}
	
	#endregion AccomStudBookChildEntityTypes
	
	#region AccomStudBookFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudBookColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudBook"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudBookFilterBuilder : SqlFilterBuilder<AccomStudBookColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudBookFilterBuilder class.
		/// </summary>
		public AccomStudBookFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudBookFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudBookFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudBookFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudBookFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudBookFilterBuilder
	
	#region AccomStudBookParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudBookColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudBook"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudBookParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudBookColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudBookParameterBuilder class.
		/// </summary>
		public AccomStudBookParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudBookParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudBookParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudBookParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudBookParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudBookParameterBuilder
	
	#region AccomStudBookSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudBookColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudBook"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudBookSortBuilder : SqlSortBuilder<AccomStudBookColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudBookSqlSortBuilder class.
		/// </summary>
		public AccomStudBookSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudBookSortBuilder
	
} // end namespace
