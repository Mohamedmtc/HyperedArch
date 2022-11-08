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
	/// This class is the base class for any <see cref="EdStudGuardProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudGuardProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudGuard, UMIS_VER2.BusinessLyer.EdStudGuardKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGuardKey key)
		{
			return Delete(transactionManager, key.EdStudGuardId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudGuardId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudGuardId)
		{
			return Delete(null, _edStudGuardId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGuardId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudGuardId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ADM_APPLICANT key.
		///		FK_ED_STUD_GUARD_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ADM_APPLICANT key.
		///		FK_ED_STUD_GUARD_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudGuard> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ADM_APPLICANT key.
		///		FK_ED_STUD_GUARD_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ADM_APPLICANT key.
		///		fkEdStudGuardAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ADM_APPLICANT key.
		///		fkEdStudGuardAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ADM_APPLICANT key.
		///		FK_ED_STUD_GUARD_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public abstract TList<EdStudGuard> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_GUARD key.
		///		FK_ED_STUD_GUARD_ED_GUARD Description: 
		/// </summary>
		/// <param name="_edGuardId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByEdGuardId(System.Decimal _edGuardId)
		{
			int count = -1;
			return GetByEdGuardId(_edGuardId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_GUARD key.
		///		FK_ED_STUD_GUARD_ED_GUARD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGuardId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudGuard> GetByEdGuardId(TransactionManager transactionManager, System.Decimal _edGuardId)
		{
			int count = -1;
			return GetByEdGuardId(transactionManager, _edGuardId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_GUARD key.
		///		FK_ED_STUD_GUARD_ED_GUARD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGuardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByEdGuardId(TransactionManager transactionManager, System.Decimal _edGuardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdGuardId(transactionManager, _edGuardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_GUARD key.
		///		fkEdStudGuardEdGuard Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edGuardId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByEdGuardId(System.Decimal _edGuardId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdGuardId(null, _edGuardId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_GUARD key.
		///		fkEdStudGuardEdGuard Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edGuardId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByEdGuardId(System.Decimal _edGuardId, int start, int pageLength,out int count)
		{
			return GetByEdGuardId(null, _edGuardId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_GUARD key.
		///		FK_ED_STUD_GUARD_ED_GUARD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGuardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public abstract TList<EdStudGuard> GetByEdGuardId(TransactionManager transactionManager, System.Decimal _edGuardId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_STUD key.
		///		FK_ED_STUD_GUARD_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_STUD key.
		///		FK_ED_STUD_GUARD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudGuard> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_STUD key.
		///		FK_ED_STUD_GUARD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_STUD key.
		///		fkEdStudGuardEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_STUD key.
		///		fkEdStudGuardEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_ED_STUD key.
		///		FK_ED_STUD_GUARD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public abstract TList<EdStudGuard> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_KINSHIP key.
		///		FK_ED_STUD_GUARD_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId)
		{
			int count = -1;
			return GetByGsCodeRelationId(_gsCodeRelationId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_KINSHIP key.
		///		FK_ED_STUD_GUARD_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudGuard> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId)
		{
			int count = -1;
			return GetByGsCodeRelationId(transactionManager, _gsCodeRelationId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_KINSHIP key.
		///		FK_ED_STUD_GUARD_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeRelationId(transactionManager, _gsCodeRelationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_KINSHIP key.
		///		fkEdStudGuardGsCodeKinship Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeRelationId(null, _gsCodeRelationId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_KINSHIP key.
		///		fkEdStudGuardGsCodeKinship Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetByGsCodeRelationId(System.Decimal _gsCodeRelationId, int start, int pageLength,out int count)
		{
			return GetByGsCodeRelationId(null, _gsCodeRelationId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_KINSHIP key.
		///		FK_ED_STUD_GUARD_GS_CODE_KINSHIP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeRelationId">صلة القرابة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public abstract TList<EdStudGuard> GetByGsCodeRelationId(TransactionManager transactionManager, System.Decimal _gsCodeRelationId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_RLTD_SE_USER key.
		///		FK_SE_USER_RLTD_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserPrntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetBySeUserPrntId(System.Decimal? _seUserPrntId)
		{
			int count = -1;
			return GetBySeUserPrntId(_seUserPrntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_RLTD_SE_USER key.
		///		FK_SE_USER_RLTD_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserPrntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudGuard> GetBySeUserPrntId(TransactionManager transactionManager, System.Decimal? _seUserPrntId)
		{
			int count = -1;
			return GetBySeUserPrntId(transactionManager, _seUserPrntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_RLTD_SE_USER key.
		///		FK_SE_USER_RLTD_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserPrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetBySeUserPrntId(TransactionManager transactionManager, System.Decimal? _seUserPrntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserPrntId(transactionManager, _seUserPrntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_RLTD_SE_USER key.
		///		fkSeUserRltdSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserPrntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetBySeUserPrntId(System.Decimal? _seUserPrntId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserPrntId(null, _seUserPrntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_RLTD_SE_USER key.
		///		fkSeUserRltdSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserPrntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public TList<EdStudGuard> GetBySeUserPrntId(System.Decimal? _seUserPrntId, int start, int pageLength,out int count)
		{
			return GetBySeUserPrntId(null, _seUserPrntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_RLTD_SE_USER key.
		///		FK_SE_USER_RLTD_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserPrntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGuard objects.</returns>
		public abstract TList<EdStudGuard> GetBySeUserPrntId(TransactionManager transactionManager, System.Decimal? _seUserPrntId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudGuard Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGuardKey key, int start, int pageLength)
		{
			return GetByEdStudGuardId(transactionManager, key.EdStudGuardId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_GUARD index.
		/// </summary>
		/// <param name="_edStudGuardId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGuard GetByEdStudGuardId(System.Decimal _edStudGuardId)
		{
			int count = -1;
			return GetByEdStudGuardId(null,_edStudGuardId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_GUARD index.
		/// </summary>
		/// <param name="_edStudGuardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGuard GetByEdStudGuardId(System.Decimal _edStudGuardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudGuardId(null, _edStudGuardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_GUARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGuardId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGuard GetByEdStudGuardId(TransactionManager transactionManager, System.Decimal _edStudGuardId)
		{
			int count = -1;
			return GetByEdStudGuardId(transactionManager, _edStudGuardId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_GUARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGuardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGuard GetByEdStudGuardId(TransactionManager transactionManager, System.Decimal _edStudGuardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudGuardId(transactionManager, _edStudGuardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_GUARD index.
		/// </summary>
		/// <param name="_edStudGuardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGuard GetByEdStudGuardId(System.Decimal _edStudGuardId, int start, int pageLength, out int count)
		{
			return GetByEdStudGuardId(null, _edStudGuardId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_GUARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGuardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudGuard GetByEdStudGuardId(TransactionManager transactionManager, System.Decimal _edStudGuardId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudGuard&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudGuard&gt;"/></returns>
		public static TList<EdStudGuard> Fill(IDataReader reader, TList<EdStudGuard> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudGuard c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudGuard")
					.Append("|").Append((System.Decimal)reader["ED_STUD_GUARD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudGuard>(
					key.ToString(), // EntityTrackingKey
					"EdStudGuard",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudGuard();
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
					c.EdStudGuardId = (System.Decimal)reader["ED_STUD_GUARD_ID"];
					c.OriginalEdStudGuardId = c.EdStudGuardId;
					c.GsCodeRelationId = (System.Decimal)reader["GS_CODE_RELATION_ID"];
					c.SeUserPrntId = Convert.IsDBNull(reader["SE_USER_PRNT_ID"]) ? null : (System.Decimal?)reader["SE_USER_PRNT_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EdGuardId = (System.Decimal)reader["ED_GUARD_ID"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.MainFlg = (System.Decimal)reader["MAIN_FLG"];
					c.OrderOfStud = (System.Decimal)reader["ORDER_OF_STUD"];
					c.FeesFlg = Convert.IsDBNull(reader["FEES_FLG"]) ? null : (System.Boolean?)reader["FEES_FLG"];
					c.EmrgncyFlg = Convert.IsDBNull(reader["EMRGNCY_FLG"]) ? null : (System.Boolean?)reader["EMRGNCY_FLG"];
					c.GuardOrdr = Convert.IsDBNull(reader["GUARD_ORDR"]) ? null : (System.Int32?)reader["GUARD_ORDR"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudGuard entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudGuardId = (System.Decimal)reader[((int)EdStudGuardColumn.EdStudGuardId - 1)];
			entity.OriginalEdStudGuardId = (System.Decimal)reader["ED_STUD_GUARD_ID"];
			entity.GsCodeRelationId = (System.Decimal)reader[((int)EdStudGuardColumn.GsCodeRelationId - 1)];
			entity.SeUserPrntId = (reader.IsDBNull(((int)EdStudGuardColumn.SeUserPrntId - 1)))?null:(System.Decimal?)reader[((int)EdStudGuardColumn.SeUserPrntId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)EdStudGuardColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)EdStudGuardColumn.EdStudId - 1)];
			entity.EdGuardId = (System.Decimal)reader[((int)EdStudGuardColumn.EdGuardId - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)EdStudGuardColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)EdStudGuardColumn.AdmApplicantId - 1)];
			entity.MainFlg = (System.Decimal)reader[((int)EdStudGuardColumn.MainFlg - 1)];
			entity.OrderOfStud = (System.Decimal)reader[((int)EdStudGuardColumn.OrderOfStud - 1)];
			entity.FeesFlg = (reader.IsDBNull(((int)EdStudGuardColumn.FeesFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudGuardColumn.FeesFlg - 1)];
			entity.EmrgncyFlg = (reader.IsDBNull(((int)EdStudGuardColumn.EmrgncyFlg - 1)))?null:(System.Boolean?)reader[((int)EdStudGuardColumn.EmrgncyFlg - 1)];
			entity.GuardOrdr = (reader.IsDBNull(((int)EdStudGuardColumn.GuardOrdr - 1)))?null:(System.Int32?)reader[((int)EdStudGuardColumn.GuardOrdr - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudGuardColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudGuardColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudGuardColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudGuardColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudGuard entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudGuardId = (System.Decimal)dataRow["ED_STUD_GUARD_ID"];
			entity.OriginalEdStudGuardId = (System.Decimal)dataRow["ED_STUD_GUARD_ID"];
			entity.GsCodeRelationId = (System.Decimal)dataRow["GS_CODE_RELATION_ID"];
			entity.SeUserPrntId = Convert.IsDBNull(dataRow["SE_USER_PRNT_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_PRNT_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.EdGuardId = (System.Decimal)dataRow["ED_GUARD_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.MainFlg = (System.Decimal)dataRow["MAIN_FLG"];
			entity.OrderOfStud = (System.Decimal)dataRow["ORDER_OF_STUD"];
			entity.FeesFlg = Convert.IsDBNull(dataRow["FEES_FLG"]) ? null : (System.Boolean?)dataRow["FEES_FLG"];
			entity.EmrgncyFlg = Convert.IsDBNull(dataRow["EMRGNCY_FLG"]) ? null : (System.Boolean?)dataRow["EMRGNCY_FLG"];
			entity.GuardOrdr = Convert.IsDBNull(dataRow["GUARD_ORDR"]) ? null : (System.Int32?)dataRow["GUARD_ORDR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudGuard"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudGuard Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGuard entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdGuardIdSource	
			if (CanDeepLoad(entity, "EdGuard|EdGuardIdSource", deepLoadType, innerList) 
				&& entity.EdGuardIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdGuardId;
				EdGuard tmpEntity = EntityManager.LocateEntity<EdGuard>(EntityLocator.ConstructKeyFromPkItems(typeof(EdGuard), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdGuardIdSource = tmpEntity;
				else
					entity.EdGuardIdSource = DataRepository.EdGuardProvider.GetByEdGuardId(transactionManager, entity.EdGuardId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGuardIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdGuardIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdGuardProvider.DeepLoad(transactionManager, entity.EdGuardIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdGuardIdSource

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

			#region GsCodeRelationIdSource	
			if (CanDeepLoad(entity, "GsCodeKinship|GsCodeRelationIdSource", deepLoadType, innerList) 
				&& entity.GsCodeRelationIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeRelationId;
				GsCodeKinship tmpEntity = EntityManager.LocateEntity<GsCodeKinship>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeKinship), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeRelationIdSource = tmpEntity;
				else
					entity.GsCodeRelationIdSource = DataRepository.GsCodeKinshipProvider.GetByGsCodeRelationId(transactionManager, entity.GsCodeRelationId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeRelationIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeRelationIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeKinshipProvider.DeepLoad(transactionManager, entity.GsCodeRelationIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeRelationIdSource

			#region SeUserPrntIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserPrntIdSource", deepLoadType, innerList) 
				&& entity.SeUserPrntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserPrntId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserPrntIdSource = tmpEntity;
				else
					entity.SeUserPrntIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserPrntId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserPrntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserPrntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserPrntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserPrntIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudGuard object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudGuard instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudGuard Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGuard entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdGuardIdSource
			if (CanDeepSave(entity, "EdGuard|EdGuardIdSource", deepSaveType, innerList) 
				&& entity.EdGuardIdSource != null)
			{
				DataRepository.EdGuardProvider.Save(transactionManager, entity.EdGuardIdSource);
				entity.EdGuardId = entity.EdGuardIdSource.EdGuardId;
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
			
			#region GsCodeRelationIdSource
			if (CanDeepSave(entity, "GsCodeKinship|GsCodeRelationIdSource", deepSaveType, innerList) 
				&& entity.GsCodeRelationIdSource != null)
			{
				DataRepository.GsCodeKinshipProvider.Save(transactionManager, entity.GsCodeRelationIdSource);
				entity.GsCodeRelationId = entity.GsCodeRelationIdSource.GsCodeRelationId;
			}
			#endregion 
			
			#region SeUserPrntIdSource
			if (CanDeepSave(entity, "SeUser|SeUserPrntIdSource", deepSaveType, innerList) 
				&& entity.SeUserPrntIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserPrntIdSource);
				entity.SeUserPrntId = entity.SeUserPrntIdSource.SeUserId;
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
	
	#region EdStudGuardChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudGuard</c>
	///</summary>
	public enum EdStudGuardChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>EdGuard</c> at EdGuardIdSource
		///</summary>
		[ChildEntityType(typeof(EdGuard))]
		EdGuard,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCodeKinship</c> at GsCodeRelationIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeKinship))]
		GsCodeKinship,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserPrntIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion EdStudGuardChildEntityTypes
	
	#region EdStudGuardFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudGuardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudGuard"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudGuardFilterBuilder : SqlFilterBuilder<EdStudGuardColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudGuardFilterBuilder class.
		/// </summary>
		public EdStudGuardFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudGuardFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudGuardFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudGuardFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudGuardFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudGuardFilterBuilder
	
	#region EdStudGuardParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudGuardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudGuard"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudGuardParameterBuilder : ParameterizedSqlFilterBuilder<EdStudGuardColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudGuardParameterBuilder class.
		/// </summary>
		public EdStudGuardParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudGuardParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudGuardParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudGuardParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudGuardParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudGuardParameterBuilder
	
	#region EdStudGuardSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudGuardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudGuard"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudGuardSortBuilder : SqlSortBuilder<EdStudGuardColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudGuardSqlSortBuilder class.
		/// </summary>
		public EdStudGuardSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudGuardSortBuilder
	
} // end namespace
