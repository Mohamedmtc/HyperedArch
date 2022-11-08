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
	/// This class is the base class for any <see cref="EdStudIntTrnsStateToProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudIntTrnsStateToProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo, UMIS_VER2.BusinessLyer.EdStudIntTrnsStateToKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrnsStateToKey key)
		{
			return Delete(transactionManager, key.EdStudIntTrnsStateToId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudIntTrnsStateToId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudIntTrnsStateToId)
		{
			return Delete(null, _edStudIntTrnsStateToId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsStateToId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudIntTrnsStateToId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsStateTo> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_AS_FACULTY_INFO key.
		///		fkEdStudIntTrnsStateToAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_AS_FACULTY_INFO key.
		///		fkEdStudIntTrnsStateToAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_AS_FACULTY_INFO key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public abstract TList<EdStudIntTrnsStateTo> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsStateTo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_ACAD_YEAR key.
		///		fkEdStudIntTrnsStateToEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_ACAD_YEAR key.
		///		fkEdStudIntTrnsStateToEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_ACAD_YEAR key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public abstract TList<EdStudIntTrnsStateTo> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawIdFrom"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdBylawIdFrom(System.Decimal? _edBylawIdFrom)
		{
			int count = -1;
			return GetByEdBylawIdFrom(_edBylawIdFrom, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawIdFrom"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsStateTo> GetByEdBylawIdFrom(TransactionManager transactionManager, System.Decimal? _edBylawIdFrom)
		{
			int count = -1;
			return GetByEdBylawIdFrom(transactionManager, _edBylawIdFrom, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawIdFrom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdBylawIdFrom(TransactionManager transactionManager, System.Decimal? _edBylawIdFrom, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdFrom(transactionManager, _edBylawIdFrom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW key.
		///		fkEdStudIntTrnsStateToEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawIdFrom"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdBylawIdFrom(System.Decimal? _edBylawIdFrom, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawIdFrom(null, _edBylawIdFrom, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW key.
		///		fkEdStudIntTrnsStateToEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawIdFrom"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdBylawIdFrom(System.Decimal? _edBylawIdFrom, int start, int pageLength,out int count)
		{
			return GetByEdBylawIdFrom(null, _edBylawIdFrom, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawIdFrom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public abstract TList<EdStudIntTrnsStateTo> GetByEdBylawIdFrom(TransactionManager transactionManager, System.Decimal? _edBylawIdFrom, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW1 key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW1 Description: 
		/// </summary>
		/// <param name="_edBylawIdTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdBylawIdTo(System.Decimal? _edBylawIdTo)
		{
			int count = -1;
			return GetByEdBylawIdTo(_edBylawIdTo, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW1 key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawIdTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsStateTo> GetByEdBylawIdTo(TransactionManager transactionManager, System.Decimal? _edBylawIdTo)
		{
			int count = -1;
			return GetByEdBylawIdTo(transactionManager, _edBylawIdTo, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW1 key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawIdTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdBylawIdTo(TransactionManager transactionManager, System.Decimal? _edBylawIdTo, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdTo(transactionManager, _edBylawIdTo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW1 key.
		///		fkEdStudIntTrnsStateToEdBylaw1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawIdTo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdBylawIdTo(System.Decimal? _edBylawIdTo, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawIdTo(null, _edBylawIdTo, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW1 key.
		///		fkEdStudIntTrnsStateToEdBylaw1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawIdTo"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdBylawIdTo(System.Decimal? _edBylawIdTo, int start, int pageLength,out int count)
		{
			return GetByEdBylawIdTo(null, _edBylawIdTo, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW1 key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_BYLAW1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawIdTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public abstract TList<EdStudIntTrnsStateTo> GetByEdBylawIdTo(TransactionManager transactionManager, System.Decimal? _edBylawIdTo, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsStateTo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_SEMESTER key.
		///		fkEdStudIntTrnsStateToEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_SEMESTER key.
		///		fkEdStudIntTrnsStateToEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public abstract TList<EdStudIntTrnsStateTo> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_STATE_STATUS key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_STATE_STATUS Description: 
		/// </summary>
		/// <param name="_edCodeStateStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdCodeStateStatusId(System.Decimal? _edCodeStateStatusId)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(_edCodeStateStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_STATE_STATUS key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_STATE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsStateTo> GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal? _edCodeStateStatusId)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(transactionManager, _edCodeStateStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_STATE_STATUS key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_STATE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal? _edCodeStateStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStateStatusId(transactionManager, _edCodeStateStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_STATE_STATUS key.
		///		fkEdStudIntTrnsStateToEdCodeStateStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdCodeStateStatusId(System.Decimal? _edCodeStateStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeStateStatusId(null, _edCodeStateStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_STATE_STATUS key.
		///		fkEdStudIntTrnsStateToEdCodeStateStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdCodeStateStatusId(System.Decimal? _edCodeStateStatusId, int start, int pageLength,out int count)
		{
			return GetByEdCodeStateStatusId(null, _edCodeStateStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_STATE_STATUS key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_CODE_STATE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStateStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public abstract TList<EdStudIntTrnsStateTo> GetByEdCodeStateStatusId(TransactionManager transactionManager, System.Decimal? _edCodeStateStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsStateTo> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD key.
		///		fkEdStudIntTrnsStateToEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD key.
		///		fkEdStudIntTrnsStateToEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public abstract TList<EdStudIntTrnsStateTo> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD_INT_TRNS key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="_edStudIntTrnsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(_edStudIntTrnsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD_INT_TRNS key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsStateTo> GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(transactionManager, _edStudIntTrnsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD_INT_TRNS key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(transactionManager, _edStudIntTrnsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD_INT_TRNS key.
		///		fkEdStudIntTrnsStateToEdStudIntTrns Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudIntTrnsId(null, _edStudIntTrnsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD_INT_TRNS key.
		///		fkEdStudIntTrnsStateToEdStudIntTrns Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId, int start, int pageLength,out int count)
		{
			return GetByEdStudIntTrnsId(null, _edStudIntTrnsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD_INT_TRNS key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public abstract TList<EdStudIntTrnsStateTo> GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ENTITY_MAIN key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ENTITY_MAIN key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudIntTrnsStateTo> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ENTITY_MAIN key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ENTITY_MAIN key.
		///		fkEdStudIntTrnsStateToEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ENTITY_MAIN key.
		///		fkEdStudIntTrnsStateToEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public TList<EdStudIntTrnsStateTo> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_INT_TRNS_STATE_TO_ENTITY_MAIN key.
		///		FK_ED_STUD_INT_TRNS_STATE_TO_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo objects.</returns>
		public abstract TList<EdStudIntTrnsStateTo> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrnsStateToKey key, int start, int pageLength)
		{
			return GetByEdStudIntTrnsStateToId(transactionManager, key.EdStudIntTrnsStateToId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_STUD_INT_TRANS_STATE_TO index.
		/// </summary>
		/// <param name="_edStudIntTrnsStateToId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo GetByEdStudIntTrnsStateToId(System.Decimal _edStudIntTrnsStateToId)
		{
			int count = -1;
			return GetByEdStudIntTrnsStateToId(null,_edStudIntTrnsStateToId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_INT_TRANS_STATE_TO index.
		/// </summary>
		/// <param name="_edStudIntTrnsStateToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo GetByEdStudIntTrnsStateToId(System.Decimal _edStudIntTrnsStateToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsStateToId(null, _edStudIntTrnsStateToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_INT_TRANS_STATE_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsStateToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo GetByEdStudIntTrnsStateToId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsStateToId)
		{
			int count = -1;
			return GetByEdStudIntTrnsStateToId(transactionManager, _edStudIntTrnsStateToId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_INT_TRANS_STATE_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsStateToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo GetByEdStudIntTrnsStateToId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsStateToId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsStateToId(transactionManager, _edStudIntTrnsStateToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_INT_TRANS_STATE_TO index.
		/// </summary>
		/// <param name="_edStudIntTrnsStateToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo GetByEdStudIntTrnsStateToId(System.Decimal _edStudIntTrnsStateToId, int start, int pageLength, out int count)
		{
			return GetByEdStudIntTrnsStateToId(null, _edStudIntTrnsStateToId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_STUD_INT_TRANS_STATE_TO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsStateToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo GetByEdStudIntTrnsStateToId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsStateToId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudIntTrnsStateTo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudIntTrnsStateTo&gt;"/></returns>
		public static TList<EdStudIntTrnsStateTo> Fill(IDataReader reader, TList<EdStudIntTrnsStateTo> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudIntTrnsStateTo")
					.Append("|").Append((System.Decimal)reader["ED_STUD_INT_TRNS_STATE_TO_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudIntTrnsStateTo>(
					key.ToString(), // EntityTrackingKey
					"EdStudIntTrnsStateTo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo();
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
					c.EdStudIntTrnsStateToId = (System.Decimal)reader["ED_STUD_INT_TRNS_STATE_TO_ID"];
					c.OriginalEdStudIntTrnsStateToId = c.EdStudIntTrnsStateToId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EdCodeStateStatusId = Convert.IsDBNull(reader["ED_CODE_STATE_STATUS_ID"]) ? null : (System.Decimal?)reader["ED_CODE_STATE_STATUS_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdStudIntTrnsId = (System.Decimal)reader["ED_STUD_INT_TRNS_ID"];
					c.EdBylawIdFrom = Convert.IsDBNull(reader["ED_BYLAW_ID_From"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID_From"];
					c.EdBylawIdTo = Convert.IsDBNull(reader["ED_BYLAW_ID_To"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID_To"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudIntTrnsStateToId = (System.Decimal)reader[((int)EdStudIntTrnsStateToColumn.EdStudIntTrnsStateToId - 1)];
			entity.OriginalEdStudIntTrnsStateToId = (System.Decimal)reader["ED_STUD_INT_TRNS_STATE_TO_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)EdStudIntTrnsStateToColumn.EntMainId - 1)];
			entity.EdCodeStateStatusId = (reader.IsDBNull(((int)EdStudIntTrnsStateToColumn.EdCodeStateStatusId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsStateToColumn.EdCodeStateStatusId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudIntTrnsStateToColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsStateToColumn.AsFacultyInfoId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)EdStudIntTrnsStateToColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsStateToColumn.EdStudId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)EdStudIntTrnsStateToColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsStateToColumn.EdCodeSemesterId - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EdStudIntTrnsStateToColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsStateToColumn.EdAcadYearId - 1)];
			entity.EdStudIntTrnsId = (System.Decimal)reader[((int)EdStudIntTrnsStateToColumn.EdStudIntTrnsId - 1)];
			entity.EdBylawIdFrom = (reader.IsDBNull(((int)EdStudIntTrnsStateToColumn.EdBylawIdFrom - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsStateToColumn.EdBylawIdFrom - 1)];
			entity.EdBylawIdTo = (reader.IsDBNull(((int)EdStudIntTrnsStateToColumn.EdBylawIdTo - 1)))?null:(System.Decimal?)reader[((int)EdStudIntTrnsStateToColumn.EdBylawIdTo - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudIntTrnsStateToId = (System.Decimal)dataRow["ED_STUD_INT_TRNS_STATE_TO_ID"];
			entity.OriginalEdStudIntTrnsStateToId = (System.Decimal)dataRow["ED_STUD_INT_TRNS_STATE_TO_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdCodeStateStatusId = Convert.IsDBNull(dataRow["ED_CODE_STATE_STATUS_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_STATE_STATUS_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdStudIntTrnsId = (System.Decimal)dataRow["ED_STUD_INT_TRNS_ID"];
			entity.EdBylawIdFrom = Convert.IsDBNull(dataRow["ED_BYLAW_ID_From"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID_From"];
			entity.EdBylawIdTo = Convert.IsDBNull(dataRow["ED_BYLAW_ID_To"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID_To"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
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

			#region EdBylawIdFromSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdFromSource", deepLoadType, innerList) 
				&& entity.EdBylawIdFromSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdBylawIdFrom ?? 0.0m);
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdFromSource = tmpEntity;
				else
					entity.EdBylawIdFromSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, (entity.EdBylawIdFrom ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdFromSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdFromSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdFromSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdFromSource

			#region EdBylawIdToSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdToSource", deepLoadType, innerList) 
				&& entity.EdBylawIdToSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdBylawIdTo ?? 0.0m);
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdToSource = tmpEntity;
				else
					entity.EdBylawIdToSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, (entity.EdBylawIdTo ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdToSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdToSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdToSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdToSource

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

			#region EdCodeStateStatusIdSource	
			if (CanDeepLoad(entity, "EdCodeStateStatus|EdCodeStateStatusIdSource", deepLoadType, innerList) 
				&& entity.EdCodeStateStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeStateStatusId ?? 0.0m);
				EdCodeStateStatus tmpEntity = EntityManager.LocateEntity<EdCodeStateStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeStateStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeStateStatusIdSource = tmpEntity;
				else
					entity.EdCodeStateStatusIdSource = DataRepository.EdCodeStateStatusProvider.GetByEdCodeStateStatusId(transactionManager, (entity.EdCodeStateStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeStateStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeStateStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeStateStatusProvider.DeepLoad(transactionManager, entity.EdCodeStateStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeStateStatusIdSource

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
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

			#region EdStudIntTrnsIdSource	
			if (CanDeepLoad(entity, "EdStudIntTrns|EdStudIntTrnsIdSource", deepLoadType, innerList) 
				&& entity.EdStudIntTrnsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudIntTrnsId;
				EdStudIntTrns tmpEntity = EntityManager.LocateEntity<EdStudIntTrns>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudIntTrns), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIntTrnsIdSource = tmpEntity;
				else
					entity.EdStudIntTrnsIdSource = DataRepository.EdStudIntTrnsProvider.GetByEdStudIntTrnsId(transactionManager, entity.EdStudIntTrnsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIntTrnsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudIntTrnsProvider.DeepLoad(transactionManager, entity.EdStudIntTrnsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIntTrnsIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdBylawIdFromSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdFromSource", deepSaveType, innerList) 
				&& entity.EdBylawIdFromSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdFromSource);
				entity.EdBylawIdFrom = entity.EdBylawIdFromSource.EdBylawId;
			}
			#endregion 
			
			#region EdBylawIdToSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdToSource", deepSaveType, innerList) 
				&& entity.EdBylawIdToSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdToSource);
				entity.EdBylawIdTo = entity.EdBylawIdToSource.EdBylawId;
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
			
			#region EdCodeStateStatusIdSource
			if (CanDeepSave(entity, "EdCodeStateStatus|EdCodeStateStatusIdSource", deepSaveType, innerList) 
				&& entity.EdCodeStateStatusIdSource != null)
			{
				DataRepository.EdCodeStateStatusProvider.Save(transactionManager, entity.EdCodeStateStatusIdSource);
				entity.EdCodeStateStatusId = entity.EdCodeStateStatusIdSource.EdCodeStateStatusId;
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
			
			#region EdStudIntTrnsIdSource
			if (CanDeepSave(entity, "EdStudIntTrns|EdStudIntTrnsIdSource", deepSaveType, innerList) 
				&& entity.EdStudIntTrnsIdSource != null)
			{
				DataRepository.EdStudIntTrnsProvider.Save(transactionManager, entity.EdStudIntTrnsIdSource);
				entity.EdStudIntTrnsId = entity.EdStudIntTrnsIdSource.EdStudIntTrnsId;
			}
			#endregion 
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
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
	
	#region EdStudIntTrnsStateToChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudIntTrnsStateTo</c>
	///</summary>
	public enum EdStudIntTrnsStateToChildEntityTypes
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
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdFromSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EdCodeStateStatus</c> at EdCodeStateStatusIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeStateStatus))]
		EdCodeStateStatus,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>EdStudIntTrns</c> at EdStudIntTrnsIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudIntTrns))]
		EdStudIntTrns,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion EdStudIntTrnsStateToChildEntityTypes
	
	#region EdStudIntTrnsStateToFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudIntTrnsStateToColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudIntTrnsStateTo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudIntTrnsStateToFilterBuilder : SqlFilterBuilder<EdStudIntTrnsStateToColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsStateToFilterBuilder class.
		/// </summary>
		public EdStudIntTrnsStateToFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsStateToFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudIntTrnsStateToFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsStateToFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudIntTrnsStateToFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudIntTrnsStateToFilterBuilder
	
	#region EdStudIntTrnsStateToParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudIntTrnsStateToColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudIntTrnsStateTo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudIntTrnsStateToParameterBuilder : ParameterizedSqlFilterBuilder<EdStudIntTrnsStateToColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsStateToParameterBuilder class.
		/// </summary>
		public EdStudIntTrnsStateToParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsStateToParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudIntTrnsStateToParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsStateToParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudIntTrnsStateToParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudIntTrnsStateToParameterBuilder
	
	#region EdStudIntTrnsStateToSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudIntTrnsStateToColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudIntTrnsStateTo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudIntTrnsStateToSortBuilder : SqlSortBuilder<EdStudIntTrnsStateToColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudIntTrnsStateToSqlSortBuilder class.
		/// </summary>
		public EdStudIntTrnsStateToSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudIntTrnsStateToSortBuilder
	
} // end namespace
