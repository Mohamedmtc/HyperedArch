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
	/// This class is the base class for any <see cref="AdmAppDisabilityProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppDisabilityProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppDisability, UMIS_VER2.BusinessLyer.AdmAppDisabilityKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppDisabilityKey key)
		{
			return Delete(transactionManager, key.AdmAppDisabilityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppDisabilityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppDisabilityId)
		{
			return Delete(null, _admAppDisabilityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppDisabilityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppDisabilityId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ADM_APPLICANT key.
		///		FK_ADM_APP_DISABILITY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ADM_APPLICANT key.
		///		FK_ADM_APP_DISABILITY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppDisability> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ADM_APPLICANT key.
		///		FK_ADM_APP_DISABILITY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ADM_APPLICANT key.
		///		fkAdmAppDisabilityAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ADM_APPLICANT key.
		///		fkAdmAppDisabilityAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ADM_APPLICANT key.
		///		FK_ADM_APP_DISABILITY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public abstract TList<AdmAppDisability> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD key.
		///		FK_ADM_APP_DISABILITY_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD key.
		///		FK_ADM_APP_DISABILITY_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppDisability> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD key.
		///		FK_ADM_APP_DISABILITY_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD key.
		///		fkAdmAppDisabilityEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD key.
		///		fkAdmAppDisabilityEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD key.
		///		FK_ADM_APP_DISABILITY_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public abstract TList<AdmAppDisability> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD_DISABILITY key.
		///		FK_ADM_APP_DISABILITY_ED_STUD_DISABILITY Description: 
		/// </summary>
		/// <param name="_edStudDisabilityId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByEdStudDisabilityId(System.Decimal? _edStudDisabilityId)
		{
			int count = -1;
			return GetByEdStudDisabilityId(_edStudDisabilityId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD_DISABILITY key.
		///		FK_ADM_APP_DISABILITY_ED_STUD_DISABILITY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudDisabilityId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppDisability> GetByEdStudDisabilityId(TransactionManager transactionManager, System.Decimal? _edStudDisabilityId)
		{
			int count = -1;
			return GetByEdStudDisabilityId(transactionManager, _edStudDisabilityId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD_DISABILITY key.
		///		FK_ADM_APP_DISABILITY_ED_STUD_DISABILITY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByEdStudDisabilityId(TransactionManager transactionManager, System.Decimal? _edStudDisabilityId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudDisabilityId(transactionManager, _edStudDisabilityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD_DISABILITY key.
		///		fkAdmAppDisabilityEdStudDisability Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudDisabilityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByEdStudDisabilityId(System.Decimal? _edStudDisabilityId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudDisabilityId(null, _edStudDisabilityId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD_DISABILITY key.
		///		fkAdmAppDisabilityEdStudDisability Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public TList<AdmAppDisability> GetByEdStudDisabilityId(System.Decimal? _edStudDisabilityId, int start, int pageLength,out int count)
		{
			return GetByEdStudDisabilityId(null, _edStudDisabilityId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DISABILITY_ED_STUD_DISABILITY key.
		///		FK_ADM_APP_DISABILITY_ED_STUD_DISABILITY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDisability objects.</returns>
		public abstract TList<AdmAppDisability> GetByEdStudDisabilityId(TransactionManager transactionManager, System.Decimal? _edStudDisabilityId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppDisability Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppDisabilityKey key, int start, int pageLength)
		{
			return GetByAdmAppDisabilityId(transactionManager, key.AdmAppDisabilityId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="_admAppDisabilityId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmAppDisabilityId(System.Decimal _admAppDisabilityId)
		{
			int count = -1;
			return GetByAdmAppDisabilityId(null,_admAppDisabilityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="_admAppDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmAppDisabilityId(System.Decimal _admAppDisabilityId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppDisabilityId(null, _admAppDisabilityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppDisabilityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmAppDisabilityId(TransactionManager transactionManager, System.Decimal _admAppDisabilityId)
		{
			int count = -1;
			return GetByAdmAppDisabilityId(transactionManager, _admAppDisabilityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmAppDisabilityId(TransactionManager transactionManager, System.Decimal _admAppDisabilityId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppDisabilityId(transactionManager, _admAppDisabilityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="_admAppDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmAppDisabilityId(System.Decimal _admAppDisabilityId, int start, int pageLength, out int count)
		{
			return GetByAdmAppDisabilityId(null, _admAppDisabilityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmAppDisabilityId(TransactionManager transactionManager, System.Decimal _admAppDisabilityId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudDisabilityId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmApplicantIdEdStudIdEdStudDisabilityId(System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _edStudDisabilityId)
		{
			int count = -1;
			return GetByAdmApplicantIdEdStudIdEdStudDisabilityId(null,_admApplicantId, _edStudId, _edStudDisabilityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmApplicantIdEdStudIdEdStudDisabilityId(System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _edStudDisabilityId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdEdStudIdEdStudDisabilityId(null, _admApplicantId, _edStudId, _edStudDisabilityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudDisabilityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmApplicantIdEdStudIdEdStudDisabilityId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _edStudDisabilityId)
		{
			int count = -1;
			return GetByAdmApplicantIdEdStudIdEdStudDisabilityId(transactionManager, _admApplicantId, _edStudId, _edStudDisabilityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmApplicantIdEdStudIdEdStudDisabilityId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _edStudDisabilityId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdEdStudIdEdStudDisabilityId(transactionManager, _admApplicantId, _edStudId, _edStudDisabilityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmApplicantIdEdStudIdEdStudDisabilityId(System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _edStudDisabilityId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantIdEdStudIdEdStudDisabilityId(null, _admApplicantId, _edStudId, _edStudDisabilityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_DISABILITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_edStudDisabilityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppDisability GetByAdmApplicantIdEdStudIdEdStudDisabilityId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _edStudDisabilityId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppDisability&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppDisability&gt;"/></returns>
		public static TList<AdmAppDisability> Fill(IDataReader reader, TList<AdmAppDisability> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppDisability c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppDisability")
					.Append("|").Append((System.Decimal)reader["ADM_APP_DISABILITY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppDisability>(
					key.ToString(), // EntityTrackingKey
					"AdmAppDisability",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppDisability();
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
					c.AdmAppDisabilityId = (System.Decimal)reader["ADM_APP_DISABILITY_ID"];
					c.OriginalAdmAppDisabilityId = c.AdmAppDisabilityId;
					c.EdStudDisabilityId = Convert.IsDBNull(reader["ED_STUD_DISABILITY_ID"]) ? null : (System.Decimal?)reader["ED_STUD_DISABILITY_ID"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppDisability entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppDisabilityId = (System.Decimal)reader[((int)AdmAppDisabilityColumn.AdmAppDisabilityId - 1)];
			entity.OriginalAdmAppDisabilityId = (System.Decimal)reader["ADM_APP_DISABILITY_ID"];
			entity.EdStudDisabilityId = (reader.IsDBNull(((int)AdmAppDisabilityColumn.EdStudDisabilityId - 1)))?null:(System.Decimal?)reader[((int)AdmAppDisabilityColumn.EdStudDisabilityId - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)AdmAppDisabilityColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)AdmAppDisabilityColumn.AdmApplicantId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)AdmAppDisabilityColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)AdmAppDisabilityColumn.EdStudId - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmAppDisabilityColumn.Notes - 1)))?null:(System.String)reader[((int)AdmAppDisabilityColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppDisabilityColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppDisabilityColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppDisabilityColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppDisabilityColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppDisability entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppDisabilityId = (System.Decimal)dataRow["ADM_APP_DISABILITY_ID"];
			entity.OriginalAdmAppDisabilityId = (System.Decimal)dataRow["ADM_APP_DISABILITY_ID"];
			entity.EdStudDisabilityId = Convert.IsDBNull(dataRow["ED_STUD_DISABILITY_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_DISABILITY_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppDisability"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppDisability Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppDisability entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmApplicantId ?? 0.0m);
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, (entity.AdmApplicantId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmApplicantIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmApplicantProvider.DeepLoad(transactionManager, entity.AdmApplicantIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmApplicantIdSource

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

			#region EdStudDisabilityIdSource	
			if (CanDeepLoad(entity, "EdStudDisability|EdStudDisabilityIdSource", deepLoadType, innerList) 
				&& entity.EdStudDisabilityIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudDisabilityId ?? 0.0m);
				EdStudDisability tmpEntity = EntityManager.LocateEntity<EdStudDisability>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudDisability), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudDisabilityIdSource = tmpEntity;
				else
					entity.EdStudDisabilityIdSource = DataRepository.EdStudDisabilityProvider.GetByEdStudDisabilityId(transactionManager, (entity.EdStudDisabilityId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudDisabilityIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudDisabilityIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudDisabilityProvider.DeepLoad(transactionManager, entity.EdStudDisabilityIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudDisabilityIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppDisability object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppDisability instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppDisability Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppDisability entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
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
			
			#region EdStudDisabilityIdSource
			if (CanDeepSave(entity, "EdStudDisability|EdStudDisabilityIdSource", deepSaveType, innerList) 
				&& entity.EdStudDisabilityIdSource != null)
			{
				DataRepository.EdStudDisabilityProvider.Save(transactionManager, entity.EdStudDisabilityIdSource);
				entity.EdStudDisabilityId = entity.EdStudDisabilityIdSource.EdStudDisabilityId;
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
	
	#region AdmAppDisabilityChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppDisability</c>
	///</summary>
	public enum AdmAppDisabilityChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>EdStudDisability</c> at EdStudDisabilityIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudDisability))]
		EdStudDisability,
	}
	
	#endregion AdmAppDisabilityChildEntityTypes
	
	#region AdmAppDisabilityFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppDisabilityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppDisability"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppDisabilityFilterBuilder : SqlFilterBuilder<AdmAppDisabilityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppDisabilityFilterBuilder class.
		/// </summary>
		public AdmAppDisabilityFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppDisabilityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppDisabilityFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppDisabilityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppDisabilityFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppDisabilityFilterBuilder
	
	#region AdmAppDisabilityParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppDisabilityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppDisability"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppDisabilityParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppDisabilityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppDisabilityParameterBuilder class.
		/// </summary>
		public AdmAppDisabilityParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppDisabilityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppDisabilityParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppDisabilityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppDisabilityParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppDisabilityParameterBuilder
	
	#region AdmAppDisabilitySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppDisabilityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppDisability"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppDisabilitySortBuilder : SqlSortBuilder<AdmAppDisabilityColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppDisabilitySqlSortBuilder class.
		/// </summary>
		public AdmAppDisabilitySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppDisabilitySortBuilder
	
} // end namespace
