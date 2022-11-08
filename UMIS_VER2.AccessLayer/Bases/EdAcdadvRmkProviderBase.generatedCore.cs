﻿#region Using directives

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
	/// This class is the base class for any <see cref="EdAcdadvRmkProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdAcdadvRmkProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdAcdadvRmk, UMIS_VER2.BusinessLyer.EdAcdadvRmkKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcdadvRmkKey key)
		{
			return Delete(transactionManager, key.EdAcdadvRmkId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edAcdadvRmkId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edAcdadvRmkId)
		{
			return Delete(null, _edAcdadvRmkId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcdadvRmkId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edAcdadvRmkId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_ACAD_YEAR key.
		///		FK_ED_ACDADV_RMK_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_ACAD_YEAR key.
		///		FK_ED_ACDADV_RMK_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcdadvRmk> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_ACAD_YEAR key.
		///		FK_ED_ACDADV_RMK_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_ACAD_YEAR key.
		///		fkEdAcdadvRmkEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_ACAD_YEAR key.
		///		fkEdAcdadvRmkEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_ACAD_YEAR key.
		///		FK_ED_ACDADV_RMK_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public abstract TList<EdAcdadvRmk> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_CODE_SEMESTER key.
		///		FK_ED_ACDADV_RMK_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_CODE_SEMESTER key.
		///		FK_ED_ACDADV_RMK_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcdadvRmk> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_CODE_SEMESTER key.
		///		FK_ED_ACDADV_RMK_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_CODE_SEMESTER key.
		///		fkEdAcdadvRmkEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_CODE_SEMESTER key.
		///		fkEdAcdadvRmkEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_CODE_SEMESTER key.
		///		FK_ED_ACDADV_RMK_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public abstract TList<EdAcdadvRmk> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_STUD key.
		///		FK_ED_ACDADV_RMK_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_STUD key.
		///		FK_ED_ACDADV_RMK_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcdadvRmk> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_STUD key.
		///		FK_ED_ACDADV_RMK_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_STUD key.
		///		fkEdAcdadvRmkEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_STUD key.
		///		fkEdAcdadvRmkEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_ED_STUD key.
		///		FK_ED_ACDADV_RMK_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public abstract TList<EdAcdadvRmk> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_SA_STF_MEMBER key.
		///		FK_ED_ACDADV_RMK_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_SA_STF_MEMBER key.
		///		FK_ED_ACDADV_RMK_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcdadvRmk> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_SA_STF_MEMBER key.
		///		FK_ED_ACDADV_RMK_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_SA_STF_MEMBER key.
		///		fkEdAcdadvRmkSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_SA_STF_MEMBER key.
		///		fkEdAcdadvRmkSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public TList<EdAcdadvRmk> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACDADV_RMK_SA_STF_MEMBER key.
		///		FK_ED_ACDADV_RMK_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcdadvRmk objects.</returns>
		public abstract TList<EdAcdadvRmk> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdAcdadvRmk Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcdadvRmkKey key, int start, int pageLength)
		{
			return GetByEdAcdadvRmkId(transactionManager, key.EdAcdadvRmkId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="_edAcdadvRmkId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdAcdadvRmkId(System.Decimal _edAcdadvRmkId)
		{
			int count = -1;
			return GetByEdAcdadvRmkId(null,_edAcdadvRmkId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="_edAcdadvRmkId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdAcdadvRmkId(System.Decimal _edAcdadvRmkId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcdadvRmkId(null, _edAcdadvRmkId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcdadvRmkId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdAcdadvRmkId(TransactionManager transactionManager, System.Decimal _edAcdadvRmkId)
		{
			int count = -1;
			return GetByEdAcdadvRmkId(transactionManager, _edAcdadvRmkId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcdadvRmkId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdAcdadvRmkId(TransactionManager transactionManager, System.Decimal _edAcdadvRmkId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcdadvRmkId(transactionManager, _edAcdadvRmkId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="_edAcdadvRmkId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdAcdadvRmkId(System.Decimal _edAcdadvRmkId, int start, int pageLength, out int count)
		{
			return GetByEdAcdadvRmkId(null, _edAcdadvRmkId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcdadvRmkId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdAcdadvRmkId(TransactionManager transactionManager, System.Decimal _edAcdadvRmkId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_rmkDate"></param>
		/// <param name="_rmkTitle"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(System.Decimal _edStudId, System.DateTime _rmkDate, System.String _rmkTitle, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(null,_edStudId, _rmkDate, _rmkTitle, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_rmkDate"></param>
		/// <param name="_rmkTitle"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(System.Decimal _edStudId, System.DateTime _rmkDate, System.String _rmkTitle, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(null, _edStudId, _rmkDate, _rmkTitle, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_rmkDate"></param>
		/// <param name="_rmkTitle"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edStudId, System.DateTime _rmkDate, System.String _rmkTitle, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(transactionManager, _edStudId, _rmkDate, _rmkTitle, _edAcadYearId, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_rmkDate"></param>
		/// <param name="_rmkTitle"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edStudId, System.DateTime _rmkDate, System.String _rmkTitle, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(transactionManager, _edStudId, _rmkDate, _rmkTitle, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_rmkDate"></param>
		/// <param name="_rmkTitle"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(System.Decimal _edStudId, System.DateTime _rmkDate, System.String _rmkTitle, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(null, _edStudId, _rmkDate, _rmkTitle, _edAcadYearId, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACDADV_RMK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_rmkDate"></param>
		/// <param name="_rmkTitle"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcdadvRmk GetByEdStudIdRmkDateRmkTitleEdAcadYearIdEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edStudId, System.DateTime _rmkDate, System.String _rmkTitle, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdAcdadvRmk&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdAcdadvRmk&gt;"/></returns>
		public static TList<EdAcdadvRmk> Fill(IDataReader reader, TList<EdAcdadvRmk> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdAcdadvRmk c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdAcdadvRmk")
					.Append("|").Append((System.Decimal)reader["ED_ACDADV_RMK_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdAcdadvRmk>(
					key.ToString(), // EntityTrackingKey
					"EdAcdadvRmk",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdAcdadvRmk();
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
					c.EdAcdadvRmkId = (System.Decimal)reader["ED_ACDADV_RMK_ID"];
					c.OriginalEdAcdadvRmkId = c.EdAcdadvRmkId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.RmkDate = (System.DateTime)reader["RMK_DATE"];
					c.RmkTitle = (System.String)reader["RMK_TITLE"];
					c.RmkDtl = (System.String)reader["RMK_DTL"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdAcdadvRmk entity)
		{
			if (!reader.Read()) return;
			
			entity.EdAcdadvRmkId = (System.Decimal)reader[((int)EdAcdadvRmkColumn.EdAcdadvRmkId - 1)];
			entity.OriginalEdAcdadvRmkId = (System.Decimal)reader["ED_ACDADV_RMK_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)EdAcdadvRmkColumn.EdStudId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)EdAcdadvRmkColumn.SaStfMemberId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdAcdadvRmkColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdAcdadvRmkColumn.EdCodeSemesterId - 1)];
			entity.RmkDate = (System.DateTime)reader[((int)EdAcdadvRmkColumn.RmkDate - 1)];
			entity.RmkTitle = (System.String)reader[((int)EdAcdadvRmkColumn.RmkTitle - 1)];
			entity.RmkDtl = (System.String)reader[((int)EdAcdadvRmkColumn.RmkDtl - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdAcdadvRmk entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdAcdadvRmkId = (System.Decimal)dataRow["ED_ACDADV_RMK_ID"];
			entity.OriginalEdAcdadvRmkId = (System.Decimal)dataRow["ED_ACDADV_RMK_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.RmkDate = (System.DateTime)dataRow["RMK_DATE"];
			entity.RmkTitle = (System.String)dataRow["RMK_TITLE"];
			entity.RmkDtl = (System.String)dataRow["RMK_DTL"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcdadvRmk"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAcdadvRmk Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcdadvRmk entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdAcdadvRmk object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdAcdadvRmk instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAcdadvRmk Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcdadvRmk entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region EdAcdadvRmkChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdAcdadvRmk</c>
	///</summary>
	public enum EdAcdadvRmkChildEntityTypes
	{
		
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
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion EdAcdadvRmkChildEntityTypes
	
	#region EdAcdadvRmkFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdAcdadvRmkColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcdadvRmk"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAcdadvRmkFilterBuilder : SqlFilterBuilder<EdAcdadvRmkColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcdadvRmkFilterBuilder class.
		/// </summary>
		public EdAcdadvRmkFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAcdadvRmkFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAcdadvRmkFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAcdadvRmkFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAcdadvRmkFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAcdadvRmkFilterBuilder
	
	#region EdAcdadvRmkParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdAcdadvRmkColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcdadvRmk"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAcdadvRmkParameterBuilder : ParameterizedSqlFilterBuilder<EdAcdadvRmkColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcdadvRmkParameterBuilder class.
		/// </summary>
		public EdAcdadvRmkParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAcdadvRmkParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAcdadvRmkParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAcdadvRmkParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAcdadvRmkParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAcdadvRmkParameterBuilder
	
	#region EdAcdadvRmkSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdAcdadvRmkColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcdadvRmk"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdAcdadvRmkSortBuilder : SqlSortBuilder<EdAcdadvRmkColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcdadvRmkSqlSortBuilder class.
		/// </summary>
		public EdAcdadvRmkSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdAcdadvRmkSortBuilder
	
} // end namespace
