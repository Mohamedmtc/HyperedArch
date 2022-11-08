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
	/// This class is the base class for any <see cref="EdResidencyStudProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdResidencyStudProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdResidencyStud, UMIS_VER2.BusinessLyer.EdResidencyStudKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdResidencyStudKey key)
		{
			return Delete(transactionManager, key.EdResidencyStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edResidencyStudId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edResidencyStudId)
		{
			return Delete(null, _edResidencyStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edResidencyStudId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edResidencyStudId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_AS_FACULTY_INFO key.
		///		FK_ED_RESIDENCY_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_AS_FACULTY_INFO key.
		///		FK_ED_RESIDENCY_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdResidencyStud> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_AS_FACULTY_INFO key.
		///		FK_ED_RESIDENCY_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_AS_FACULTY_INFO key.
		///		fkEdResidencyStudAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_AS_FACULTY_INFO key.
		///		fkEdResidencyStudAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_AS_FACULTY_INFO key.
		///		FK_ED_RESIDENCY_STUD_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public abstract TList<EdResidencyStud> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD key.
		///		FK_ED_RESIDENCY_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD key.
		///		FK_ED_RESIDENCY_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdResidencyStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD key.
		///		FK_ED_RESIDENCY_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD key.
		///		fkEdResidencyStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD key.
		///		fkEdResidencyStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD key.
		///		FK_ED_RESIDENCY_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public abstract TList<EdResidencyStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD_SEMESTER key.
		///		FK_ED_RESIDENCY_STUD_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD_SEMESTER key.
		///		FK_ED_RESIDENCY_STUD_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdResidencyStud> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD_SEMESTER key.
		///		FK_ED_RESIDENCY_STUD_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD_SEMESTER key.
		///		fkEdResidencyStudEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD_SEMESTER key.
		///		fkEdResidencyStudEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_ED_STUD_SEMESTER key.
		///		FK_ED_RESIDENCY_STUD_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public abstract TList<EdResidencyStud> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_GS_CODE_PASS_FAIL key.
		///		FK_ED_RESIDENCY_STUD_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(_gsCodePassFailId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_GS_CODE_PASS_FAIL key.
		///		FK_ED_RESIDENCY_STUD_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		/// <remarks></remarks>
		public TList<EdResidencyStud> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_GS_CODE_PASS_FAIL key.
		///		FK_ED_RESIDENCY_STUD_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_GS_CODE_PASS_FAIL key.
		///		fkEdResidencyStudGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_GS_CODE_PASS_FAIL key.
		///		fkEdResidencyStudGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public TList<EdResidencyStud> GetByGsCodePassFailId(System.Decimal? _gsCodePassFailId, int start, int pageLength,out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_RESIDENCY_STUD_GS_CODE_PASS_FAIL key.
		///		FK_ED_RESIDENCY_STUD_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdResidencyStud objects.</returns>
		public abstract TList<EdResidencyStud> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdResidencyStud Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdResidencyStudKey key, int start, int pageLength)
		{
			return GetByEdResidencyStudId(transactionManager, key.EdResidencyStudId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_RESIDENCY_STUD index.
		/// </summary>
		/// <param name="_edResidencyStudId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdResidencyStud GetByEdResidencyStudId(System.Decimal _edResidencyStudId)
		{
			int count = -1;
			return GetByEdResidencyStudId(null,_edResidencyStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_RESIDENCY_STUD index.
		/// </summary>
		/// <param name="_edResidencyStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdResidencyStud GetByEdResidencyStudId(System.Decimal _edResidencyStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdResidencyStudId(null, _edResidencyStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_RESIDENCY_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edResidencyStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdResidencyStud GetByEdResidencyStudId(TransactionManager transactionManager, System.Decimal _edResidencyStudId)
		{
			int count = -1;
			return GetByEdResidencyStudId(transactionManager, _edResidencyStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_RESIDENCY_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edResidencyStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdResidencyStud GetByEdResidencyStudId(TransactionManager transactionManager, System.Decimal _edResidencyStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdResidencyStudId(transactionManager, _edResidencyStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_RESIDENCY_STUD index.
		/// </summary>
		/// <param name="_edResidencyStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdResidencyStud GetByEdResidencyStudId(System.Decimal _edResidencyStudId, int start, int pageLength, out int count)
		{
			return GetByEdResidencyStudId(null, _edResidencyStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_RESIDENCY_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edResidencyStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdResidencyStud GetByEdResidencyStudId(TransactionManager transactionManager, System.Decimal _edResidencyStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdResidencyStud&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdResidencyStud&gt;"/></returns>
		public static TList<EdResidencyStud> Fill(IDataReader reader, TList<EdResidencyStud> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdResidencyStud c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdResidencyStud")
					.Append("|").Append((System.Decimal)reader["ED_RESIDENCY_STUD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdResidencyStud>(
					key.ToString(), // EntityTrackingKey
					"EdResidencyStud",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdResidencyStud();
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
					c.EdResidencyStudId = (System.Decimal)reader["ED_RESIDENCY_STUD_ID"];
					c.OriginalEdResidencyStudId = c.EdResidencyStudId;
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.Location = Convert.IsDBNull(reader["LOCATION"]) ? null : (System.String)reader["LOCATION"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.GsCodePassFailId = Convert.IsDBNull(reader["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PASS_FAIL_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdResidencyStud entity)
		{
			if (!reader.Read()) return;
			
			entity.EdResidencyStudId = (System.Decimal)reader[((int)EdResidencyStudColumn.EdResidencyStudId - 1)];
			entity.OriginalEdResidencyStudId = (System.Decimal)reader["ED_RESIDENCY_STUD_ID"];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdResidencyStudColumn.EdStudSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdResidencyStudColumn.EdStudId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)EdResidencyStudColumn.AsFacultyInfoId - 1)];
			entity.FromDate = (reader.IsDBNull(((int)EdResidencyStudColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)EdResidencyStudColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)EdResidencyStudColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)EdResidencyStudColumn.ToDate - 1)];
			entity.Location = (reader.IsDBNull(((int)EdResidencyStudColumn.Location - 1)))?null:(System.String)reader[((int)EdResidencyStudColumn.Location - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdResidencyStudColumn.Notes - 1)))?null:(System.String)reader[((int)EdResidencyStudColumn.Notes - 1)];
			entity.GsCodePassFailId = (reader.IsDBNull(((int)EdResidencyStudColumn.GsCodePassFailId - 1)))?null:(System.Decimal?)reader[((int)EdResidencyStudColumn.GsCodePassFailId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdResidencyStudColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdResidencyStudColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdResidencyStudColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdResidencyStudColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdResidencyStud entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdResidencyStudId = (System.Decimal)dataRow["ED_RESIDENCY_STUD_ID"];
			entity.OriginalEdResidencyStudId = (System.Decimal)dataRow["ED_RESIDENCY_STUD_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.Location = Convert.IsDBNull(dataRow["LOCATION"]) ? null : (System.String)dataRow["LOCATION"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.GsCodePassFailId = Convert.IsDBNull(dataRow["GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PASS_FAIL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdResidencyStud"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdResidencyStud Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdResidencyStud entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudSemesterId;
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource

			#region GsCodePassFailIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|GsCodePassFailIdSource", deepLoadType, innerList) 
				&& entity.GsCodePassFailIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodePassFailId ?? 0.0m);
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePassFailIdSource = tmpEntity;
				else
					entity.GsCodePassFailIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, (entity.GsCodePassFailId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePassFailIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePassFailIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.GsCodePassFailIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePassFailIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdResidencyStud object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdResidencyStud instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdResidencyStud Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdResidencyStud entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region GsCodePassFailIdSource
			if (CanDeepSave(entity, "GsCodePassFail|GsCodePassFailIdSource", deepSaveType, innerList) 
				&& entity.GsCodePassFailIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.GsCodePassFailIdSource);
				entity.GsCodePassFailId = entity.GsCodePassFailIdSource.GsCodePassFailId;
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
	
	#region EdResidencyStudChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdResidencyStud</c>
	///</summary>
	public enum EdResidencyStudChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>GsCodePassFail</c> at GsCodePassFailIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePassFail))]
		GsCodePassFail,
	}
	
	#endregion EdResidencyStudChildEntityTypes
	
	#region EdResidencyStudFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdResidencyStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdResidencyStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdResidencyStudFilterBuilder : SqlFilterBuilder<EdResidencyStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdResidencyStudFilterBuilder class.
		/// </summary>
		public EdResidencyStudFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdResidencyStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdResidencyStudFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdResidencyStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdResidencyStudFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdResidencyStudFilterBuilder
	
	#region EdResidencyStudParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdResidencyStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdResidencyStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdResidencyStudParameterBuilder : ParameterizedSqlFilterBuilder<EdResidencyStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdResidencyStudParameterBuilder class.
		/// </summary>
		public EdResidencyStudParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdResidencyStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdResidencyStudParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdResidencyStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdResidencyStudParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdResidencyStudParameterBuilder
	
	#region EdResidencyStudSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdResidencyStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdResidencyStud"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdResidencyStudSortBuilder : SqlSortBuilder<EdResidencyStudColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdResidencyStudSqlSortBuilder class.
		/// </summary>
		public EdResidencyStudSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdResidencyStudSortBuilder
	
} // end namespace
