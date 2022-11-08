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
	/// This class is the base class for any <see cref="RsrchStudRegisterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class RsrchStudRegisterProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.RsrchStudRegister, UMIS_VER2.BusinessLyer.RsrchStudRegisterKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudRegisterKey key)
		{
			return Delete(transactionManager, key.RsrchStudRegisterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _rsrchStudRegisterId)
		{
			return Delete(null, _rsrchStudRegisterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_AS_FACULTY_INFO key.
		///		FK_RSRCH_STUD_REGISTER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_AS_FACULTY_INFO key.
		///		FK_RSRCH_STUD_REGISTER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudRegister> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_AS_FACULTY_INFO key.
		///		FK_RSRCH_STUD_REGISTER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_AS_FACULTY_INFO key.
		///		fkRsrchStudRegisterAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_AS_FACULTY_INFO key.
		///		fkRsrchStudRegisterAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_AS_FACULTY_INFO key.
		///		FK_RSRCH_STUD_REGISTER_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public abstract TList<RsrchStudRegister> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_ACAD_YEAR key.
		///		FK_RSRCH_STUD_REGISTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_ACAD_YEAR key.
		///		FK_RSRCH_STUD_REGISTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudRegister> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_ACAD_YEAR key.
		///		FK_RSRCH_STUD_REGISTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_ACAD_YEAR key.
		///		fkRsrchStudRegisterEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_ACAD_YEAR key.
		///		fkRsrchStudRegisterEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_ACAD_YEAR key.
		///		FK_RSRCH_STUD_REGISTER_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public abstract TList<RsrchStudRegister> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_CODE_SEMESTER key.
		///		FK_RSRCH_STUD_REGISTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_CODE_SEMESTER key.
		///		FK_RSRCH_STUD_REGISTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		/// <remarks></remarks>
		public TList<RsrchStudRegister> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_CODE_SEMESTER key.
		///		FK_RSRCH_STUD_REGISTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_CODE_SEMESTER key.
		///		fkRsrchStudRegisterEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_CODE_SEMESTER key.
		///		fkRsrchStudRegisterEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public TList<RsrchStudRegister> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RSRCH_STUD_REGISTER_ED_CODE_SEMESTER key.
		///		FK_RSRCH_STUD_REGISTER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.RsrchStudRegister objects.</returns>
		public abstract TList<RsrchStudRegister> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.RsrchStudRegister Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudRegisterKey key, int start, int pageLength)
		{
			return GetByRsrchStudRegisterId(transactionManager, key.RsrchStudRegisterId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudRegister GetByRsrchStudRegisterId(System.Decimal _rsrchStudRegisterId)
		{
			int count = -1;
			return GetByRsrchStudRegisterId(null,_rsrchStudRegisterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudRegister GetByRsrchStudRegisterId(System.Decimal _rsrchStudRegisterId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterId(null, _rsrchStudRegisterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudRegister GetByRsrchStudRegisterId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterId)
		{
			int count = -1;
			return GetByRsrchStudRegisterId(transactionManager, _rsrchStudRegisterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudRegister GetByRsrchStudRegisterId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchStudRegisterId(transactionManager, _rsrchStudRegisterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchStudRegister GetByRsrchStudRegisterId(System.Decimal _rsrchStudRegisterId, int start, int pageLength, out int count)
		{
			return GetByRsrchStudRegisterId(null, _rsrchStudRegisterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchStudRegisterId">اختيار العنوان المقترح للبحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.RsrchStudRegister GetByRsrchStudRegisterId(TransactionManager transactionManager, System.Decimal _rsrchStudRegisterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegister&gt;"/> class.</returns>
		public TList<RsrchStudRegister> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegister&gt;"/> class.</returns>
		public TList<RsrchStudRegister> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegister&gt;"/> class.</returns>
		public TList<RsrchStudRegister> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegister&gt;"/> class.</returns>
		public TList<RsrchStudRegister> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegister&gt;"/> class.</returns>
		public TList<RsrchStudRegister> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_RSRCH_STUD_REGISTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;RsrchStudRegister&gt;"/> class.</returns>
		public abstract TList<RsrchStudRegister> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;RsrchStudRegister&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;RsrchStudRegister&gt;"/></returns>
		public static TList<RsrchStudRegister> Fill(IDataReader reader, TList<RsrchStudRegister> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.RsrchStudRegister c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("RsrchStudRegister")
					.Append("|").Append((System.Decimal)reader["RSRCH_STUD_REGISTER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<RsrchStudRegister>(
					key.ToString(), // EntityTrackingKey
					"RsrchStudRegister",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.RsrchStudRegister();
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
					c.RsrchStudRegisterId = (System.Decimal)reader["RSRCH_STUD_REGISTER_ID"];
					c.OriginalRsrchStudRegisterId = c.RsrchStudRegisterId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.SubmitFlg = Convert.IsDBNull(reader["SUBMIT_FLG"]) ? null : (System.Boolean?)reader["SUBMIT_FLG"];
					c.SubmitDate = Convert.IsDBNull(reader["SUBMIT_DATE"]) ? null : (System.DateTime?)reader["SUBMIT_DATE"];
					c.AuditFlg = Convert.IsDBNull(reader["AUDIT_FLG"]) ? null : (System.Boolean?)reader["AUDIT_FLG"];
					c.AuditDate = Convert.IsDBNull(reader["AUDIT_DATE"]) ? null : (System.DateTime?)reader["AUDIT_DATE"];
					c.SeUserEnterId = Convert.IsDBNull(reader["SE_USER_ENTER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ENTER_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.RsrchStudRegister entity)
		{
			if (!reader.Read()) return;
			
			entity.RsrchStudRegisterId = (System.Decimal)reader[((int)RsrchStudRegisterColumn.RsrchStudRegisterId - 1)];
			entity.OriginalRsrchStudRegisterId = (System.Decimal)reader["RSRCH_STUD_REGISTER_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)RsrchStudRegisterColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)RsrchStudRegisterColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)RsrchStudRegisterColumn.EdStudId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)RsrchStudRegisterColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)RsrchStudRegisterColumn.AsFacultyInfoId - 1)];
			entity.SubmitFlg = (reader.IsDBNull(((int)RsrchStudRegisterColumn.SubmitFlg - 1)))?null:(System.Boolean?)reader[((int)RsrchStudRegisterColumn.SubmitFlg - 1)];
			entity.SubmitDate = (reader.IsDBNull(((int)RsrchStudRegisterColumn.SubmitDate - 1)))?null:(System.DateTime?)reader[((int)RsrchStudRegisterColumn.SubmitDate - 1)];
			entity.AuditFlg = (reader.IsDBNull(((int)RsrchStudRegisterColumn.AuditFlg - 1)))?null:(System.Boolean?)reader[((int)RsrchStudRegisterColumn.AuditFlg - 1)];
			entity.AuditDate = (reader.IsDBNull(((int)RsrchStudRegisterColumn.AuditDate - 1)))?null:(System.DateTime?)reader[((int)RsrchStudRegisterColumn.AuditDate - 1)];
			entity.SeUserEnterId = (reader.IsDBNull(((int)RsrchStudRegisterColumn.SeUserEnterId - 1)))?null:(System.Decimal?)reader[((int)RsrchStudRegisterColumn.SeUserEnterId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)RsrchStudRegisterColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)RsrchStudRegisterColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)RsrchStudRegisterColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)RsrchStudRegisterColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.RsrchStudRegister entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.RsrchStudRegisterId = (System.Decimal)dataRow["RSRCH_STUD_REGISTER_ID"];
			entity.OriginalRsrchStudRegisterId = (System.Decimal)dataRow["RSRCH_STUD_REGISTER_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.SubmitFlg = Convert.IsDBNull(dataRow["SUBMIT_FLG"]) ? null : (System.Boolean?)dataRow["SUBMIT_FLG"];
			entity.SubmitDate = Convert.IsDBNull(dataRow["SUBMIT_DATE"]) ? null : (System.DateTime?)dataRow["SUBMIT_DATE"];
			entity.AuditFlg = Convert.IsDBNull(dataRow["AUDIT_FLG"]) ? null : (System.Boolean?)dataRow["AUDIT_FLG"];
			entity.AuditDate = Convert.IsDBNull(dataRow["AUDIT_DATE"]) ? null : (System.DateTime?)dataRow["AUDIT_DATE"];
			entity.SeUserEnterId = Convert.IsDBNull(dataRow["SE_USER_ENTER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ENTER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchStudRegister"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchStudRegister Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudRegister entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByRsrchStudRegisterId methods when available
			
			#region RsrchStudRegisterDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudRegisterDtl>|RsrchStudRegisterDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudRegisterDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudRegisterDtlCollection = DataRepository.RsrchStudRegisterDtlProvider.GetByRsrchStudRegisterId(transactionManager, entity.RsrchStudRegisterId);

				if (deep && entity.RsrchStudRegisterDtlCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudRegisterDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudRegisterDtl>) DataRepository.RsrchStudRegisterDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudRegisterDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.RsrchStudRegister object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.RsrchStudRegister instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchStudRegister Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchStudRegister entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<RsrchStudRegisterDtl>
				if (CanDeepSave(entity.RsrchStudRegisterDtlCollection, "List<RsrchStudRegisterDtl>|RsrchStudRegisterDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudRegisterDtl child in entity.RsrchStudRegisterDtlCollection)
					{
						if(child.RsrchStudRegisterIdSource != null)
						{
							child.RsrchStudRegisterId = child.RsrchStudRegisterIdSource.RsrchStudRegisterId;
						}
						else
						{
							child.RsrchStudRegisterId = entity.RsrchStudRegisterId;
						}

					}

					if (entity.RsrchStudRegisterDtlCollection.Count > 0 || entity.RsrchStudRegisterDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudRegisterDtlProvider.Save(transactionManager, entity.RsrchStudRegisterDtlCollection);
						
						deepHandles.Add("RsrchStudRegisterDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudRegisterDtl >) DataRepository.RsrchStudRegisterDtlProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudRegisterDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region RsrchStudRegisterChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.RsrchStudRegister</c>
	///</summary>
	public enum RsrchStudRegisterChildEntityTypes
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
		/// Collection of <c>RsrchStudRegister</c> as OneToMany for RsrchStudRegisterDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudRegisterDtl>))]
		RsrchStudRegisterDtlCollection,
	}
	
	#endregion RsrchStudRegisterChildEntityTypes
	
	#region RsrchStudRegisterFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;RsrchStudRegisterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchStudRegister"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchStudRegisterFilterBuilder : SqlFilterBuilder<RsrchStudRegisterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterFilterBuilder class.
		/// </summary>
		public RsrchStudRegisterFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchStudRegisterFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchStudRegisterFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchStudRegisterFilterBuilder
	
	#region RsrchStudRegisterParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;RsrchStudRegisterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchStudRegister"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchStudRegisterParameterBuilder : ParameterizedSqlFilterBuilder<RsrchStudRegisterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterParameterBuilder class.
		/// </summary>
		public RsrchStudRegisterParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchStudRegisterParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchStudRegisterParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchStudRegisterParameterBuilder
	
	#region RsrchStudRegisterSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;RsrchStudRegisterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchStudRegister"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class RsrchStudRegisterSortBuilder : SqlSortBuilder<RsrchStudRegisterColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchStudRegisterSqlSortBuilder class.
		/// </summary>
		public RsrchStudRegisterSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion RsrchStudRegisterSortBuilder
	
} // end namespace
