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
	/// This class is the base class for any <see cref="SaServTerminProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaServTerminProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaServTermin, UMIS_VER2.BusinessLyer.SaServTerminKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaServTerminKey key)
		{
			return Delete(transactionManager, key.SaServTerminId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saServTerminId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saServTerminId)
		{
			return Delete(null, _saServTerminId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saServTerminId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saServTerminId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0367 key.
		///		FK_AUTO_0367 Description: 
		/// </summary>
		/// <param name="_saTransferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaTransferId(System.Decimal? _saTransferId)
		{
			int count = -1;
			return GetBySaTransferId(_saTransferId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0367 key.
		///		FK_AUTO_0367 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTransferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		/// <remarks></remarks>
		public TList<SaServTermin> GetBySaTransferId(TransactionManager transactionManager, System.Decimal? _saTransferId)
		{
			int count = -1;
			return GetBySaTransferId(transactionManager, _saTransferId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0367 key.
		///		FK_AUTO_0367 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTransferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaTransferId(TransactionManager transactionManager, System.Decimal? _saTransferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaTransferId(transactionManager, _saTransferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0367 key.
		///		fkAuto0367 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saTransferId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaTransferId(System.Decimal? _saTransferId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaTransferId(null, _saTransferId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0367 key.
		///		fkAuto0367 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saTransferId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaTransferId(System.Decimal? _saTransferId, int start, int pageLength,out int count)
		{
			return GetBySaTransferId(null, _saTransferId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0367 key.
		///		FK_AUTO_0367 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saTransferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public abstract TList<SaServTermin> GetBySaTransferId(TransactionManager transactionManager, System.Decimal? _saTransferId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e2 key.
		///		FK_AUTO_04e2 Description: 
		/// </summary>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeServTerminRsnId(System.Decimal _saCodeServTerminRsnId)
		{
			int count = -1;
			return GetBySaCodeServTerminRsnId(_saCodeServTerminRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e2 key.
		///		FK_AUTO_04e2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		/// <remarks></remarks>
		public TList<SaServTermin> GetBySaCodeServTerminRsnId(TransactionManager transactionManager, System.Decimal _saCodeServTerminRsnId)
		{
			int count = -1;
			return GetBySaCodeServTerminRsnId(transactionManager, _saCodeServTerminRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e2 key.
		///		FK_AUTO_04e2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeServTerminRsnId(TransactionManager transactionManager, System.Decimal _saCodeServTerminRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeServTerminRsnId(transactionManager, _saCodeServTerminRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e2 key.
		///		fkAuto04e2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeServTerminRsnId(System.Decimal _saCodeServTerminRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeServTerminRsnId(null, _saCodeServTerminRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e2 key.
		///		fkAuto04e2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeServTerminRsnId(System.Decimal _saCodeServTerminRsnId, int start, int pageLength,out int count)
		{
			return GetBySaCodeServTerminRsnId(null, _saCodeServTerminRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e2 key.
		///		FK_AUTO_04e2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeServTerminRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public abstract TList<SaServTermin> GetBySaCodeServTerminRsnId(TransactionManager transactionManager, System.Decimal _saCodeServTerminRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_AS_FACULTY_INFO key.
		///		FK_SA_SERV_TERMIN_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_AS_FACULTY_INFO key.
		///		FK_SA_SERV_TERMIN_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		/// <remarks></remarks>
		public TList<SaServTermin> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_AS_FACULTY_INFO key.
		///		FK_SA_SERV_TERMIN_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_AS_FACULTY_INFO key.
		///		fkSaServTerminAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_AS_FACULTY_INFO key.
		///		fkSaServTerminAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_AS_FACULTY_INFO key.
		///		FK_SA_SERV_TERMIN_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public abstract TList<SaServTermin> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_ED_ACAD_YEAR key.
		///		FK_SA_SERV_TERMIN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_ED_ACAD_YEAR key.
		///		FK_SA_SERV_TERMIN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		/// <remarks></remarks>
		public TList<SaServTermin> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_ED_ACAD_YEAR key.
		///		FK_SA_SERV_TERMIN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_ED_ACAD_YEAR key.
		///		fkSaServTerminEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_ED_ACAD_YEAR key.
		///		fkSaServTerminEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_ED_ACAD_YEAR key.
		///		FK_SA_SERV_TERMIN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public abstract TList<SaServTermin> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_GS_APPROVAL_H key.
		///		FK_SA_SERV_TERMIN_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByGsApprovalHId(System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(_gsApprovalHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_GS_APPROVAL_H key.
		///		FK_SA_SERV_TERMIN_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		/// <remarks></remarks>
		public TList<SaServTermin> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_GS_APPROVAL_H key.
		///		FK_SA_SERV_TERMIN_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_GS_APPROVAL_H key.
		///		fkSaServTerminGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_GS_APPROVAL_H key.
		///		fkSaServTerminGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength,out int count)
		{
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_GS_APPROVAL_H key.
		///		FK_SA_SERV_TERMIN_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public abstract TList<SaServTermin> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_JOB_STATUS key.
		///		FK_SA_SERV_TERMIN_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="_saCodeJobStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeJobStatusId(System.Decimal? _saCodeJobStatusId)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(_saCodeJobStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_JOB_STATUS key.
		///		FK_SA_SERV_TERMIN_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		/// <remarks></remarks>
		public TList<SaServTermin> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal? _saCodeJobStatusId)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(transactionManager, _saCodeJobStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_JOB_STATUS key.
		///		FK_SA_SERV_TERMIN_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal? _saCodeJobStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(transactionManager, _saCodeJobStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_JOB_STATUS key.
		///		fkSaServTerminSaCodeJobStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeJobStatusId(System.Decimal? _saCodeJobStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeJobStatusId(null, _saCodeJobStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_JOB_STATUS key.
		///		fkSaServTerminSaCodeJobStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeJobStatusId(System.Decimal? _saCodeJobStatusId, int start, int pageLength,out int count)
		{
			return GetBySaCodeJobStatusId(null, _saCodeJobStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_JOB_STATUS key.
		///		FK_SA_SERV_TERMIN_SA_CODE_JOB_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public abstract TList<SaServTermin> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal? _saCodeJobStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG key.
		///		FK_SA_SERV_TERMIN_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG key.
		///		FK_SA_SERV_TERMIN_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		/// <remarks></remarks>
		public TList<SaServTermin> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG key.
		///		FK_SA_SERV_TERMIN_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG key.
		///		fkSaServTerminSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG key.
		///		fkSaServTerminSaCodeScDeg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG key.
		///		FK_SA_SERV_TERMIN_SA_CODE_SC_DEG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public abstract TList<SaServTermin> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG1 key.
		///		FK_SA_SERV_TERMIN_SA_CODE_SC_DEG1 Description: 
		/// </summary>
		/// <param name="_saCodeScDegOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeScDegOldId(System.Decimal? _saCodeScDegOldId)
		{
			int count = -1;
			return GetBySaCodeScDegOldId(_saCodeScDegOldId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG1 key.
		///		FK_SA_SERV_TERMIN_SA_CODE_SC_DEG1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		/// <remarks></remarks>
		public TList<SaServTermin> GetBySaCodeScDegOldId(TransactionManager transactionManager, System.Decimal? _saCodeScDegOldId)
		{
			int count = -1;
			return GetBySaCodeScDegOldId(transactionManager, _saCodeScDegOldId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG1 key.
		///		FK_SA_SERV_TERMIN_SA_CODE_SC_DEG1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeScDegOldId(TransactionManager transactionManager, System.Decimal? _saCodeScDegOldId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegOldId(transactionManager, _saCodeScDegOldId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG1 key.
		///		fkSaServTerminSaCodeScDeg1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegOldId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeScDegOldId(System.Decimal? _saCodeScDegOldId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegOldId(null, _saCodeScDegOldId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG1 key.
		///		fkSaServTerminSaCodeScDeg1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegOldId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaCodeScDegOldId(System.Decimal? _saCodeScDegOldId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegOldId(null, _saCodeScDegOldId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_CODE_SC_DEG1 key.
		///		FK_SA_SERV_TERMIN_SA_CODE_SC_DEG1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public abstract TList<SaServTermin> GetBySaCodeScDegOldId(TransactionManager transactionManager, System.Decimal? _saCodeScDegOldId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_STF_MEMBER key.
		///		FK_SA_SERV_TERMIN_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_STF_MEMBER key.
		///		FK_SA_SERV_TERMIN_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		/// <remarks></remarks>
		public TList<SaServTermin> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_STF_MEMBER key.
		///		FK_SA_SERV_TERMIN_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_STF_MEMBER key.
		///		fkSaServTerminSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_STF_MEMBER key.
		///		fkSaServTerminSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public TList<SaServTermin> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SERV_TERMIN_SA_STF_MEMBER key.
		///		FK_SA_SERV_TERMIN_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaServTermin objects.</returns>
		public abstract TList<SaServTermin> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaServTermin Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaServTerminKey key, int start, int pageLength)
		{
			return GetBySaServTerminId(transactionManager, key.SaServTerminId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_SERV_TERMIN index.
		/// </summary>
		/// <param name="_saServTerminId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaServTermin GetBySaServTerminId(System.Decimal _saServTerminId)
		{
			int count = -1;
			return GetBySaServTerminId(null,_saServTerminId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SERV_TERMIN index.
		/// </summary>
		/// <param name="_saServTerminId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaServTermin GetBySaServTerminId(System.Decimal _saServTerminId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaServTerminId(null, _saServTerminId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SERV_TERMIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saServTerminId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaServTermin GetBySaServTerminId(TransactionManager transactionManager, System.Decimal _saServTerminId)
		{
			int count = -1;
			return GetBySaServTerminId(transactionManager, _saServTerminId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SERV_TERMIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saServTerminId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaServTermin GetBySaServTerminId(TransactionManager transactionManager, System.Decimal _saServTerminId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaServTerminId(transactionManager, _saServTerminId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SERV_TERMIN index.
		/// </summary>
		/// <param name="_saServTerminId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaServTermin GetBySaServTerminId(System.Decimal _saServTerminId, int start, int pageLength, out int count)
		{
			return GetBySaServTerminId(null, _saServTerminId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SERV_TERMIN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saServTerminId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaServTermin GetBySaServTerminId(TransactionManager transactionManager, System.Decimal _saServTerminId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaServTermin&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaServTermin&gt;"/></returns>
		public static TList<SaServTermin> Fill(IDataReader reader, TList<SaServTermin> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaServTermin c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaServTermin")
					.Append("|").Append((System.Decimal)reader["SA_SERV_TERMIN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaServTermin>(
					key.ToString(), // EntityTrackingKey
					"SaServTermin",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaServTermin();
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
					c.SaServTerminId = (System.Decimal)reader["SA_SERV_TERMIN_ID"];
					c.OriginalSaServTerminId = c.SaServTerminId;
					c.EmpEndDate = (System.DateTime)reader["EMP_END_DATE"];
					c.DecisionNum = (System.String)reader["DECISION_NUM"];
					c.DecisionDate = (System.DateTime)reader["DECISION_DATE"];
					c.DecisionSumm = Convert.IsDBNull(reader["DECISION_SUMM"]) ? null : (System.String)reader["DECISION_SUMM"];
					c.DecisionExecDate = (System.DateTime)reader["DECISION_EXEC_DATE"];
					c.IsEmp = (System.Decimal)reader["IS_EMP"];
					c.RewardAmt = Convert.IsDBNull(reader["REWARD_AMT"]) ? null : (System.Decimal?)reader["REWARD_AMT"];
					c.IsYearEnd = (System.Decimal)reader["IS_YEAR_END"];
					c.Coments = Convert.IsDBNull(reader["COMENTS"]) ? null : (System.String)reader["COMENTS"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.SaCodeServTerminRsnId = (System.Decimal)reader["SA_CODE_SERV_TERMIN_RSN_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.GsApprovalHId = (System.Decimal)reader["GS_APPROVAL_H_ID"];
					c.DoesAffectStaffStat = Convert.IsDBNull(reader["DOES_AFFECT_STAFF_STAT"]) ? null : (System.Decimal?)reader["DOES_AFFECT_STAFF_STAT"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.StfPensionPayPlace = Convert.IsDBNull(reader["STF_PENSION_PAY_PLACE"]) ? null : (System.String)reader["STF_PENSION_PAY_PLACE"];
					c.SaTransferId = Convert.IsDBNull(reader["SA_TRANSFER_ID"]) ? null : (System.Decimal?)reader["SA_TRANSFER_ID"];
					c.SaCodeScDegId = Convert.IsDBNull(reader["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_SC_DEG_ID"];
					c.SaCodeScDegOldId = Convert.IsDBNull(reader["SA_CODE_SC_DEG_OLD_ID"]) ? null : (System.Decimal?)reader["SA_CODE_SC_DEG_OLD_ID"];
					c.SaCodeJobStatusId = Convert.IsDBNull(reader["SA_CODE_JOB_STATUS_ID"]) ? null : (System.Decimal?)reader["SA_CODE_JOB_STATUS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaServTermin entity)
		{
			if (!reader.Read()) return;
			
			entity.SaServTerminId = (System.Decimal)reader[((int)SaServTerminColumn.SaServTerminId - 1)];
			entity.OriginalSaServTerminId = (System.Decimal)reader["SA_SERV_TERMIN_ID"];
			entity.EmpEndDate = (System.DateTime)reader[((int)SaServTerminColumn.EmpEndDate - 1)];
			entity.DecisionNum = (System.String)reader[((int)SaServTerminColumn.DecisionNum - 1)];
			entity.DecisionDate = (System.DateTime)reader[((int)SaServTerminColumn.DecisionDate - 1)];
			entity.DecisionSumm = (reader.IsDBNull(((int)SaServTerminColumn.DecisionSumm - 1)))?null:(System.String)reader[((int)SaServTerminColumn.DecisionSumm - 1)];
			entity.DecisionExecDate = (System.DateTime)reader[((int)SaServTerminColumn.DecisionExecDate - 1)];
			entity.IsEmp = (System.Decimal)reader[((int)SaServTerminColumn.IsEmp - 1)];
			entity.RewardAmt = (reader.IsDBNull(((int)SaServTerminColumn.RewardAmt - 1)))?null:(System.Decimal?)reader[((int)SaServTerminColumn.RewardAmt - 1)];
			entity.IsYearEnd = (System.Decimal)reader[((int)SaServTerminColumn.IsYearEnd - 1)];
			entity.Coments = (reader.IsDBNull(((int)SaServTerminColumn.Coments - 1)))?null:(System.String)reader[((int)SaServTerminColumn.Coments - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)SaServTerminColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)SaServTerminColumn.EdAcadYearId - 1)];
			entity.SaCodeServTerminRsnId = (System.Decimal)reader[((int)SaServTerminColumn.SaCodeServTerminRsnId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaServTerminColumn.SaStfMemberId - 1)];
			entity.GsApprovalHId = (System.Decimal)reader[((int)SaServTerminColumn.GsApprovalHId - 1)];
			entity.DoesAffectStaffStat = (reader.IsDBNull(((int)SaServTerminColumn.DoesAffectStaffStat - 1)))?null:(System.Decimal?)reader[((int)SaServTerminColumn.DoesAffectStaffStat - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaServTerminColumn.AsFacultyInfoId - 1)];
			entity.StfPensionPayPlace = (reader.IsDBNull(((int)SaServTerminColumn.StfPensionPayPlace - 1)))?null:(System.String)reader[((int)SaServTerminColumn.StfPensionPayPlace - 1)];
			entity.SaTransferId = (reader.IsDBNull(((int)SaServTerminColumn.SaTransferId - 1)))?null:(System.Decimal?)reader[((int)SaServTerminColumn.SaTransferId - 1)];
			entity.SaCodeScDegId = (reader.IsDBNull(((int)SaServTerminColumn.SaCodeScDegId - 1)))?null:(System.Decimal?)reader[((int)SaServTerminColumn.SaCodeScDegId - 1)];
			entity.SaCodeScDegOldId = (reader.IsDBNull(((int)SaServTerminColumn.SaCodeScDegOldId - 1)))?null:(System.Decimal?)reader[((int)SaServTerminColumn.SaCodeScDegOldId - 1)];
			entity.SaCodeJobStatusId = (reader.IsDBNull(((int)SaServTerminColumn.SaCodeJobStatusId - 1)))?null:(System.Decimal?)reader[((int)SaServTerminColumn.SaCodeJobStatusId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaServTermin entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaServTerminId = (System.Decimal)dataRow["SA_SERV_TERMIN_ID"];
			entity.OriginalSaServTerminId = (System.Decimal)dataRow["SA_SERV_TERMIN_ID"];
			entity.EmpEndDate = (System.DateTime)dataRow["EMP_END_DATE"];
			entity.DecisionNum = (System.String)dataRow["DECISION_NUM"];
			entity.DecisionDate = (System.DateTime)dataRow["DECISION_DATE"];
			entity.DecisionSumm = Convert.IsDBNull(dataRow["DECISION_SUMM"]) ? null : (System.String)dataRow["DECISION_SUMM"];
			entity.DecisionExecDate = (System.DateTime)dataRow["DECISION_EXEC_DATE"];
			entity.IsEmp = (System.Decimal)dataRow["IS_EMP"];
			entity.RewardAmt = Convert.IsDBNull(dataRow["REWARD_AMT"]) ? null : (System.Decimal?)dataRow["REWARD_AMT"];
			entity.IsYearEnd = (System.Decimal)dataRow["IS_YEAR_END"];
			entity.Coments = Convert.IsDBNull(dataRow["COMENTS"]) ? null : (System.String)dataRow["COMENTS"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.SaCodeServTerminRsnId = (System.Decimal)dataRow["SA_CODE_SERV_TERMIN_RSN_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.GsApprovalHId = (System.Decimal)dataRow["GS_APPROVAL_H_ID"];
			entity.DoesAffectStaffStat = Convert.IsDBNull(dataRow["DOES_AFFECT_STAFF_STAT"]) ? null : (System.Decimal?)dataRow["DOES_AFFECT_STAFF_STAT"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.StfPensionPayPlace = Convert.IsDBNull(dataRow["STF_PENSION_PAY_PLACE"]) ? null : (System.String)dataRow["STF_PENSION_PAY_PLACE"];
			entity.SaTransferId = Convert.IsDBNull(dataRow["SA_TRANSFER_ID"]) ? null : (System.Decimal?)dataRow["SA_TRANSFER_ID"];
			entity.SaCodeScDegId = Convert.IsDBNull(dataRow["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_SC_DEG_ID"];
			entity.SaCodeScDegOldId = Convert.IsDBNull(dataRow["SA_CODE_SC_DEG_OLD_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_SC_DEG_OLD_ID"];
			entity.SaCodeJobStatusId = Convert.IsDBNull(dataRow["SA_CODE_JOB_STATUS_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_JOB_STATUS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaServTermin"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaServTermin Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaServTermin entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaTransferIdSource	
			if (CanDeepLoad(entity, "SaTransfer|SaTransferIdSource", deepLoadType, innerList) 
				&& entity.SaTransferIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaTransferId ?? 0.0m);
				SaTransfer tmpEntity = EntityManager.LocateEntity<SaTransfer>(EntityLocator.ConstructKeyFromPkItems(typeof(SaTransfer), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaTransferIdSource = tmpEntity;
				else
					entity.SaTransferIdSource = DataRepository.SaTransferProvider.GetBySaTransferId(transactionManager, (entity.SaTransferId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTransferIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaTransferIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaTransferProvider.DeepLoad(transactionManager, entity.SaTransferIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaTransferIdSource

			#region SaCodeServTerminRsnIdSource	
			if (CanDeepLoad(entity, "SaCodeServTerminRsn|SaCodeServTerminRsnIdSource", deepLoadType, innerList) 
				&& entity.SaCodeServTerminRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeServTerminRsnId;
				SaCodeServTerminRsn tmpEntity = EntityManager.LocateEntity<SaCodeServTerminRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeServTerminRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeServTerminRsnIdSource = tmpEntity;
				else
					entity.SaCodeServTerminRsnIdSource = DataRepository.SaCodeServTerminRsnProvider.GetBySaCodeServTerminRsnId(transactionManager, entity.SaCodeServTerminRsnId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeServTerminRsnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeServTerminRsnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeServTerminRsnProvider.DeepLoad(transactionManager, entity.SaCodeServTerminRsnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeServTerminRsnIdSource

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

			#region GsApprovalHIdSource	
			if (CanDeepLoad(entity, "GsApprovalH|GsApprovalHIdSource", deepLoadType, innerList) 
				&& entity.GsApprovalHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsApprovalHId;
				GsApprovalH tmpEntity = EntityManager.LocateEntity<GsApprovalH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsApprovalH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsApprovalHIdSource = tmpEntity;
				else
					entity.GsApprovalHIdSource = DataRepository.GsApprovalHProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsApprovalHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsApprovalHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsApprovalHProvider.DeepLoad(transactionManager, entity.GsApprovalHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsApprovalHIdSource

			#region SaCodeJobStatusIdSource	
			if (CanDeepLoad(entity, "SaCodeJobStatus|SaCodeJobStatusIdSource", deepLoadType, innerList) 
				&& entity.SaCodeJobStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeJobStatusId ?? 0.0m);
				SaCodeJobStatus tmpEntity = EntityManager.LocateEntity<SaCodeJobStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeJobStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeJobStatusIdSource = tmpEntity;
				else
					entity.SaCodeJobStatusIdSource = DataRepository.SaCodeJobStatusProvider.GetBySaCodeJobStatusId(transactionManager, (entity.SaCodeJobStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeJobStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeJobStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeJobStatusProvider.DeepLoad(transactionManager, entity.SaCodeJobStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeJobStatusIdSource

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeScDegId ?? 0.0m);
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, (entity.SaCodeScDegId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeScDegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeScDegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeScDegProvider.DeepLoad(transactionManager, entity.SaCodeScDegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeScDegIdSource

			#region SaCodeScDegOldIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegOldIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegOldIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeScDegOldId ?? 0.0m);
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegOldIdSource = tmpEntity;
				else
					entity.SaCodeScDegOldIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, (entity.SaCodeScDegOldId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeScDegOldIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeScDegOldIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeScDegProvider.DeepLoad(transactionManager, entity.SaCodeScDegOldIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeScDegOldIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaServTermin object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaServTermin instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaServTermin Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaServTermin entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaTransferIdSource
			if (CanDeepSave(entity, "SaTransfer|SaTransferIdSource", deepSaveType, innerList) 
				&& entity.SaTransferIdSource != null)
			{
				DataRepository.SaTransferProvider.Save(transactionManager, entity.SaTransferIdSource);
				entity.SaTransferId = entity.SaTransferIdSource.SaTransferId;
			}
			#endregion 
			
			#region SaCodeServTerminRsnIdSource
			if (CanDeepSave(entity, "SaCodeServTerminRsn|SaCodeServTerminRsnIdSource", deepSaveType, innerList) 
				&& entity.SaCodeServTerminRsnIdSource != null)
			{
				DataRepository.SaCodeServTerminRsnProvider.Save(transactionManager, entity.SaCodeServTerminRsnIdSource);
				entity.SaCodeServTerminRsnId = entity.SaCodeServTerminRsnIdSource.SaCodeServTerminRsnId;
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
			
			#region GsApprovalHIdSource
			if (CanDeepSave(entity, "GsApprovalH|GsApprovalHIdSource", deepSaveType, innerList) 
				&& entity.GsApprovalHIdSource != null)
			{
				DataRepository.GsApprovalHProvider.Save(transactionManager, entity.GsApprovalHIdSource);
				entity.GsApprovalHId = entity.GsApprovalHIdSource.GsApprovalHId;
			}
			#endregion 
			
			#region SaCodeJobStatusIdSource
			if (CanDeepSave(entity, "SaCodeJobStatus|SaCodeJobStatusIdSource", deepSaveType, innerList) 
				&& entity.SaCodeJobStatusIdSource != null)
			{
				DataRepository.SaCodeJobStatusProvider.Save(transactionManager, entity.SaCodeJobStatusIdSource);
				entity.SaCodeJobStatusId = entity.SaCodeJobStatusIdSource.SaCodeJobStatusId;
			}
			#endregion 
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
			}
			#endregion 
			
			#region SaCodeScDegOldIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegOldIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegOldIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegOldIdSource);
				entity.SaCodeScDegOldId = entity.SaCodeScDegOldIdSource.SaCodeScDegId;
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
	
	#region SaServTerminChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaServTermin</c>
	///</summary>
	public enum SaServTerminChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaTransfer</c> at SaTransferIdSource
		///</summary>
		[ChildEntityType(typeof(SaTransfer))]
		SaTransfer,
		
		///<summary>
		/// Composite Property for <c>SaCodeServTerminRsn</c> at SaCodeServTerminRsnIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeServTerminRsn))]
		SaCodeServTerminRsn,
		
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
		/// Composite Property for <c>GsApprovalH</c> at GsApprovalHIdSource
		///</summary>
		[ChildEntityType(typeof(GsApprovalH))]
		GsApprovalH,
		
		///<summary>
		/// Composite Property for <c>SaCodeJobStatus</c> at SaCodeJobStatusIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeJobStatus))]
		SaCodeJobStatus,
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion SaServTerminChildEntityTypes
	
	#region SaServTerminFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaServTerminColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaServTermin"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaServTerminFilterBuilder : SqlFilterBuilder<SaServTerminColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaServTerminFilterBuilder class.
		/// </summary>
		public SaServTerminFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaServTerminFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaServTerminFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaServTerminFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaServTerminFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaServTerminFilterBuilder
	
	#region SaServTerminParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaServTerminColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaServTermin"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaServTerminParameterBuilder : ParameterizedSqlFilterBuilder<SaServTerminColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaServTerminParameterBuilder class.
		/// </summary>
		public SaServTerminParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaServTerminParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaServTerminParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaServTerminParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaServTerminParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaServTerminParameterBuilder
	
	#region SaServTerminSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaServTerminColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaServTermin"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaServTerminSortBuilder : SqlSortBuilder<SaServTerminColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaServTerminSqlSortBuilder class.
		/// </summary>
		public SaServTerminSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaServTerminSortBuilder
	
} // end namespace
