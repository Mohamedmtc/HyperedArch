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
	/// This class is the base class for any <see cref="EdGuardProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdGuardProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdGuard, UMIS_VER2.BusinessLyer.EdGuardKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdGuardKey key)
		{
			return Delete(transactionManager, key.EdGuardId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edGuardId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edGuardId)
		{
			return Delete(null, _edGuardId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGuardId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edGuardId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_CDE_MARITAL_STATUS key.
		///		FK_ED_GUARD_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCodeMaritalStateId(System.Decimal? _gsCodeMaritalStateId)
		{
			int count = -1;
			return GetByGsCodeMaritalStateId(_gsCodeMaritalStateId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_CDE_MARITAL_STATUS key.
		///		FK_ED_GUARD_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		/// <remarks></remarks>
		public TList<EdGuard> GetByGsCodeMaritalStateId(TransactionManager transactionManager, System.Decimal? _gsCodeMaritalStateId)
		{
			int count = -1;
			return GetByGsCodeMaritalStateId(transactionManager, _gsCodeMaritalStateId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_CDE_MARITAL_STATUS key.
		///		FK_ED_GUARD_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCodeMaritalStateId(TransactionManager transactionManager, System.Decimal? _gsCodeMaritalStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMaritalStateId(transactionManager, _gsCodeMaritalStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_CDE_MARITAL_STATUS key.
		///		fkEdGuardGsCdeMaritalStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCodeMaritalStateId(System.Decimal? _gsCodeMaritalStateId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeMaritalStateId(null, _gsCodeMaritalStateId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_CDE_MARITAL_STATUS key.
		///		fkEdGuardGsCdeMaritalStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCodeMaritalStateId(System.Decimal? _gsCodeMaritalStateId, int start, int pageLength,out int count)
		{
			return GetByGsCodeMaritalStateId(null, _gsCodeMaritalStateId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_CDE_MARITAL_STATUS key.
		///		FK_ED_GUARD_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMaritalStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public abstract TList<EdGuard> GetByGsCodeMaritalStateId(TransactionManager transactionManager, System.Decimal? _gsCodeMaritalStateId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_COUNTRY_NODE key.
		///		FK_ED_GUARD_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_COUNTRY_NODE key.
		///		FK_ED_GUARD_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		/// <remarks></remarks>
		public TList<EdGuard> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_COUNTRY_NODE key.
		///		FK_ED_GUARD_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_COUNTRY_NODE key.
		///		fkEdGuardGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_COUNTRY_NODE key.
		///		fkEdGuardGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_GUARD_GS_COUNTRY_NODE key.
		///		FK_ED_GUARD_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public abstract TList<EdGuard> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_EDUCATION_LEVEL key.
		///		FK_ED_STUD_GUARD_GS_CODE_EDUCATION_LEVEL Description: 
		/// </summary>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCodeEducationLevelId(System.Decimal? _gsCodeEducationLevelId)
		{
			int count = -1;
			return GetByGsCodeEducationLevelId(_gsCodeEducationLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_EDUCATION_LEVEL key.
		///		FK_ED_STUD_GUARD_GS_CODE_EDUCATION_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		/// <remarks></remarks>
		public TList<EdGuard> GetByGsCodeEducationLevelId(TransactionManager transactionManager, System.Decimal? _gsCodeEducationLevelId)
		{
			int count = -1;
			return GetByGsCodeEducationLevelId(transactionManager, _gsCodeEducationLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_EDUCATION_LEVEL key.
		///		FK_ED_STUD_GUARD_GS_CODE_EDUCATION_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCodeEducationLevelId(TransactionManager transactionManager, System.Decimal? _gsCodeEducationLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeEducationLevelId(transactionManager, _gsCodeEducationLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_EDUCATION_LEVEL key.
		///		fkEdStudGuardGsCodeEducationLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCodeEducationLevelId(System.Decimal? _gsCodeEducationLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeEducationLevelId(null, _gsCodeEducationLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_EDUCATION_LEVEL key.
		///		fkEdStudGuardGsCodeEducationLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetByGsCodeEducationLevelId(System.Decimal? _gsCodeEducationLevelId, int start, int pageLength,out int count)
		{
			return GetByGsCodeEducationLevelId(null, _gsCodeEducationLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_GS_CODE_EDUCATION_LEVEL key.
		///		FK_ED_STUD_GUARD_GS_CODE_EDUCATION_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeEducationLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public abstract TList<EdGuard> GetByGsCodeEducationLevelId(TransactionManager transactionManager, System.Decimal? _gsCodeEducationLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_SA_STF_MEMBER key.
		///		FK_ED_STUD_GUARD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_SA_STF_MEMBER key.
		///		FK_ED_STUD_GUARD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		/// <remarks></remarks>
		public TList<EdGuard> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_SA_STF_MEMBER key.
		///		FK_ED_STUD_GUARD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_SA_STF_MEMBER key.
		///		fkEdStudGuardSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_SA_STF_MEMBER key.
		///		fkEdStudGuardSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public TList<EdGuard> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_GUARD_SA_STF_MEMBER key.
		///		FK_ED_STUD_GUARD_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdGuard objects.</returns>
		public abstract TList<EdGuard> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdGuard Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdGuardKey key, int start, int pageLength)
		{
			return GetByEdGuardId(transactionManager, key.EdGuardId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_GUARD index.
		/// </summary>
		/// <param name="_edGuardId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGuard GetByEdGuardId(System.Decimal _edGuardId)
		{
			int count = -1;
			return GetByEdGuardId(null,_edGuardId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_GUARD index.
		/// </summary>
		/// <param name="_edGuardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGuard GetByEdGuardId(System.Decimal _edGuardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdGuardId(null, _edGuardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_GUARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGuardId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGuard GetByEdGuardId(TransactionManager transactionManager, System.Decimal _edGuardId)
		{
			int count = -1;
			return GetByEdGuardId(transactionManager, _edGuardId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_GUARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGuardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGuard GetByEdGuardId(TransactionManager transactionManager, System.Decimal _edGuardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdGuardId(transactionManager, _edGuardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_GUARD index.
		/// </summary>
		/// <param name="_edGuardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdGuard GetByEdGuardId(System.Decimal _edGuardId, int start, int pageLength, out int count)
		{
			return GetByEdGuardId(null, _edGuardId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_GUARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGuardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdGuard GetByEdGuardId(TransactionManager transactionManager, System.Decimal _edGuardId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdGuard&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdGuard&gt;"/></returns>
		public static TList<EdGuard> Fill(IDataReader reader, TList<EdGuard> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdGuard c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdGuard")
					.Append("|").Append((System.Decimal)reader["ED_GUARD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdGuard>(
					key.ToString(), // EntityTrackingKey
					"EdGuard",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdGuard();
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
					c.EdGuardId = (System.Decimal)reader["ED_GUARD_ID"];
					c.OriginalEdGuardId = c.EdGuardId;
					c.FullNameEn = Convert.IsDBNull(reader["FULL_NAME_EN"]) ? null : (System.String)reader["FULL_NAME_EN"];
					c.JobTitle = Convert.IsDBNull(reader["JOB_TITLE"]) ? null : (System.String)reader["JOB_TITLE"];
					c.PermAddr = Convert.IsDBNull(reader["PERM_ADDR"]) ? null : (System.String)reader["PERM_ADDR"];
					c.EMail = Convert.IsDBNull(reader["E_MAIL"]) ? null : (System.String)reader["E_MAIL"];
					c.PhoneNum = Convert.IsDBNull(reader["PHONE_NUM"]) ? null : (System.String)reader["PHONE_NUM"];
					c.MobileNum = Convert.IsDBNull(reader["MOBILE_NUM"]) ? null : (System.String)reader["MOBILE_NUM"];
					c.MonthIncome = Convert.IsDBNull(reader["MONTH_INCOME"]) ? null : (System.Decimal?)reader["MONTH_INCOME"];
					c.StaffFlg = (System.Decimal)reader["STAFF_FLG"];
					c.DiplomaticFlg = (System.Decimal)reader["DIPLOMATIC_FLG"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.BirthDate = Convert.IsDBNull(reader["BIRTH_DATE"]) ? null : (System.DateTime?)reader["BIRTH_DATE"];
					c.GsCodeMaritalStateId = Convert.IsDBNull(reader["GS_CODE_MARITAL_STATE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_MARITAL_STATE_ID"];
					c.GsCodeEducationLevelId = Convert.IsDBNull(reader["GS_CODE_EDUCATION_LEVEL_ID"]) ? null : (System.Decimal?)reader["GS_CODE_EDUCATION_LEVEL_ID"];
					c.CompanyName = Convert.IsDBNull(reader["COMPANY_NAME"]) ? null : (System.String)reader["COMPANY_NAME"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.FullNameAr = Convert.IsDBNull(reader["FULL_NAME_AR"]) ? null : (System.String)reader["FULL_NAME_AR"];
					c.Cpr = Convert.IsDBNull(reader["CPR"]) ? null : (System.String)reader["CPR"];
					c.PassporNo = Convert.IsDBNull(reader["PASSPOR_NO"]) ? null : (System.String)reader["PASSPOR_NO"];
					c.PassporExpireDate = Convert.IsDBNull(reader["PASSPOR_EXPIRE_DATE"]) ? null : (System.DateTime?)reader["PASSPOR_EXPIRE_DATE"];
					c.ResidentExpireDate = Convert.IsDBNull(reader["RESIDENT_EXPIRE_DATE"]) ? null : (System.DateTime?)reader["RESIDENT_EXPIRE_DATE"];
					c.ResidentId = Convert.IsDBNull(reader["RESIDENT_ID"]) ? null : (System.String)reader["RESIDENT_ID"];
					c.Username = Convert.IsDBNull(reader["USERNAME"]) ? null : (System.String)reader["USERNAME"];
					c.PasswordSalt = Convert.IsDBNull(reader["PASSWORD_SALT"]) ? null : (System.String)reader["PASSWORD_SALT"];
					c.PasswordHash = Convert.IsDBNull(reader["PASSWORD_HASH"]) ? null : (System.String)reader["PASSWORD_HASH"];
					c.SecurityQs = Convert.IsDBNull(reader["SECURITY_QS"]) ? null : (System.String)reader["SECURITY_QS"];
					c.SecurityQsAnsSalt = Convert.IsDBNull(reader["SECURITY_QS_ANS_SALT"]) ? null : (System.String)reader["SECURITY_QS_ANS_SALT"];
					c.SecurityQsAnsHash = Convert.IsDBNull(reader["SECURITY_QS_ANS_HASH"]) ? null : (System.String)reader["SECURITY_QS_ANS_HASH"];
					c.EmpFlg = Convert.IsDBNull(reader["EMP_FLG"]) ? null : (System.Decimal?)reader["EMP_FLG"];
					c.WorkAddress = Convert.IsDBNull(reader["WORK_ADDRESS"]) ? null : (System.String)reader["WORK_ADDRESS"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdGuard entity)
		{
			if (!reader.Read()) return;
			
			entity.EdGuardId = (System.Decimal)reader[((int)EdGuardColumn.EdGuardId - 1)];
			entity.OriginalEdGuardId = (System.Decimal)reader["ED_GUARD_ID"];
			entity.FullNameEn = (reader.IsDBNull(((int)EdGuardColumn.FullNameEn - 1)))?null:(System.String)reader[((int)EdGuardColumn.FullNameEn - 1)];
			entity.JobTitle = (reader.IsDBNull(((int)EdGuardColumn.JobTitle - 1)))?null:(System.String)reader[((int)EdGuardColumn.JobTitle - 1)];
			entity.PermAddr = (reader.IsDBNull(((int)EdGuardColumn.PermAddr - 1)))?null:(System.String)reader[((int)EdGuardColumn.PermAddr - 1)];
			entity.EMail = (reader.IsDBNull(((int)EdGuardColumn.EMail - 1)))?null:(System.String)reader[((int)EdGuardColumn.EMail - 1)];
			entity.PhoneNum = (reader.IsDBNull(((int)EdGuardColumn.PhoneNum - 1)))?null:(System.String)reader[((int)EdGuardColumn.PhoneNum - 1)];
			entity.MobileNum = (reader.IsDBNull(((int)EdGuardColumn.MobileNum - 1)))?null:(System.String)reader[((int)EdGuardColumn.MobileNum - 1)];
			entity.MonthIncome = (reader.IsDBNull(((int)EdGuardColumn.MonthIncome - 1)))?null:(System.Decimal?)reader[((int)EdGuardColumn.MonthIncome - 1)];
			entity.StaffFlg = (System.Decimal)reader[((int)EdGuardColumn.StaffFlg - 1)];
			entity.DiplomaticFlg = (System.Decimal)reader[((int)EdGuardColumn.DiplomaticFlg - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)EdGuardColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)EdGuardColumn.SaStfMemberId - 1)];
			entity.BirthDate = (reader.IsDBNull(((int)EdGuardColumn.BirthDate - 1)))?null:(System.DateTime?)reader[((int)EdGuardColumn.BirthDate - 1)];
			entity.GsCodeMaritalStateId = (reader.IsDBNull(((int)EdGuardColumn.GsCodeMaritalStateId - 1)))?null:(System.Decimal?)reader[((int)EdGuardColumn.GsCodeMaritalStateId - 1)];
			entity.GsCodeEducationLevelId = (reader.IsDBNull(((int)EdGuardColumn.GsCodeEducationLevelId - 1)))?null:(System.Decimal?)reader[((int)EdGuardColumn.GsCodeEducationLevelId - 1)];
			entity.CompanyName = (reader.IsDBNull(((int)EdGuardColumn.CompanyName - 1)))?null:(System.String)reader[((int)EdGuardColumn.CompanyName - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)EdGuardColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)EdGuardColumn.GsCountryNodeId - 1)];
			entity.FullNameAr = (reader.IsDBNull(((int)EdGuardColumn.FullNameAr - 1)))?null:(System.String)reader[((int)EdGuardColumn.FullNameAr - 1)];
			entity.Cpr = (reader.IsDBNull(((int)EdGuardColumn.Cpr - 1)))?null:(System.String)reader[((int)EdGuardColumn.Cpr - 1)];
			entity.PassporNo = (reader.IsDBNull(((int)EdGuardColumn.PassporNo - 1)))?null:(System.String)reader[((int)EdGuardColumn.PassporNo - 1)];
			entity.PassporExpireDate = (reader.IsDBNull(((int)EdGuardColumn.PassporExpireDate - 1)))?null:(System.DateTime?)reader[((int)EdGuardColumn.PassporExpireDate - 1)];
			entity.ResidentExpireDate = (reader.IsDBNull(((int)EdGuardColumn.ResidentExpireDate - 1)))?null:(System.DateTime?)reader[((int)EdGuardColumn.ResidentExpireDate - 1)];
			entity.ResidentId = (reader.IsDBNull(((int)EdGuardColumn.ResidentId - 1)))?null:(System.String)reader[((int)EdGuardColumn.ResidentId - 1)];
			entity.Username = (reader.IsDBNull(((int)EdGuardColumn.Username - 1)))?null:(System.String)reader[((int)EdGuardColumn.Username - 1)];
			entity.PasswordSalt = (reader.IsDBNull(((int)EdGuardColumn.PasswordSalt - 1)))?null:(System.String)reader[((int)EdGuardColumn.PasswordSalt - 1)];
			entity.PasswordHash = (reader.IsDBNull(((int)EdGuardColumn.PasswordHash - 1)))?null:(System.String)reader[((int)EdGuardColumn.PasswordHash - 1)];
			entity.SecurityQs = (reader.IsDBNull(((int)EdGuardColumn.SecurityQs - 1)))?null:(System.String)reader[((int)EdGuardColumn.SecurityQs - 1)];
			entity.SecurityQsAnsSalt = (reader.IsDBNull(((int)EdGuardColumn.SecurityQsAnsSalt - 1)))?null:(System.String)reader[((int)EdGuardColumn.SecurityQsAnsSalt - 1)];
			entity.SecurityQsAnsHash = (reader.IsDBNull(((int)EdGuardColumn.SecurityQsAnsHash - 1)))?null:(System.String)reader[((int)EdGuardColumn.SecurityQsAnsHash - 1)];
			entity.EmpFlg = (reader.IsDBNull(((int)EdGuardColumn.EmpFlg - 1)))?null:(System.Decimal?)reader[((int)EdGuardColumn.EmpFlg - 1)];
			entity.WorkAddress = (reader.IsDBNull(((int)EdGuardColumn.WorkAddress - 1)))?null:(System.String)reader[((int)EdGuardColumn.WorkAddress - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdGuard entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdGuardId = (System.Decimal)dataRow["ED_GUARD_ID"];
			entity.OriginalEdGuardId = (System.Decimal)dataRow["ED_GUARD_ID"];
			entity.FullNameEn = Convert.IsDBNull(dataRow["FULL_NAME_EN"]) ? null : (System.String)dataRow["FULL_NAME_EN"];
			entity.JobTitle = Convert.IsDBNull(dataRow["JOB_TITLE"]) ? null : (System.String)dataRow["JOB_TITLE"];
			entity.PermAddr = Convert.IsDBNull(dataRow["PERM_ADDR"]) ? null : (System.String)dataRow["PERM_ADDR"];
			entity.EMail = Convert.IsDBNull(dataRow["E_MAIL"]) ? null : (System.String)dataRow["E_MAIL"];
			entity.PhoneNum = Convert.IsDBNull(dataRow["PHONE_NUM"]) ? null : (System.String)dataRow["PHONE_NUM"];
			entity.MobileNum = Convert.IsDBNull(dataRow["MOBILE_NUM"]) ? null : (System.String)dataRow["MOBILE_NUM"];
			entity.MonthIncome = Convert.IsDBNull(dataRow["MONTH_INCOME"]) ? null : (System.Decimal?)dataRow["MONTH_INCOME"];
			entity.StaffFlg = (System.Decimal)dataRow["STAFF_FLG"];
			entity.DiplomaticFlg = (System.Decimal)dataRow["DIPLOMATIC_FLG"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.BirthDate = Convert.IsDBNull(dataRow["BIRTH_DATE"]) ? null : (System.DateTime?)dataRow["BIRTH_DATE"];
			entity.GsCodeMaritalStateId = Convert.IsDBNull(dataRow["GS_CODE_MARITAL_STATE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_MARITAL_STATE_ID"];
			entity.GsCodeEducationLevelId = Convert.IsDBNull(dataRow["GS_CODE_EDUCATION_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_EDUCATION_LEVEL_ID"];
			entity.CompanyName = Convert.IsDBNull(dataRow["COMPANY_NAME"]) ? null : (System.String)dataRow["COMPANY_NAME"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.FullNameAr = Convert.IsDBNull(dataRow["FULL_NAME_AR"]) ? null : (System.String)dataRow["FULL_NAME_AR"];
			entity.Cpr = Convert.IsDBNull(dataRow["CPR"]) ? null : (System.String)dataRow["CPR"];
			entity.PassporNo = Convert.IsDBNull(dataRow["PASSPOR_NO"]) ? null : (System.String)dataRow["PASSPOR_NO"];
			entity.PassporExpireDate = Convert.IsDBNull(dataRow["PASSPOR_EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["PASSPOR_EXPIRE_DATE"];
			entity.ResidentExpireDate = Convert.IsDBNull(dataRow["RESIDENT_EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["RESIDENT_EXPIRE_DATE"];
			entity.ResidentId = Convert.IsDBNull(dataRow["RESIDENT_ID"]) ? null : (System.String)dataRow["RESIDENT_ID"];
			entity.Username = Convert.IsDBNull(dataRow["USERNAME"]) ? null : (System.String)dataRow["USERNAME"];
			entity.PasswordSalt = Convert.IsDBNull(dataRow["PASSWORD_SALT"]) ? null : (System.String)dataRow["PASSWORD_SALT"];
			entity.PasswordHash = Convert.IsDBNull(dataRow["PASSWORD_HASH"]) ? null : (System.String)dataRow["PASSWORD_HASH"];
			entity.SecurityQs = Convert.IsDBNull(dataRow["SECURITY_QS"]) ? null : (System.String)dataRow["SECURITY_QS"];
			entity.SecurityQsAnsSalt = Convert.IsDBNull(dataRow["SECURITY_QS_ANS_SALT"]) ? null : (System.String)dataRow["SECURITY_QS_ANS_SALT"];
			entity.SecurityQsAnsHash = Convert.IsDBNull(dataRow["SECURITY_QS_ANS_HASH"]) ? null : (System.String)dataRow["SECURITY_QS_ANS_HASH"];
			entity.EmpFlg = Convert.IsDBNull(dataRow["EMP_FLG"]) ? null : (System.Decimal?)dataRow["EMP_FLG"];
			entity.WorkAddress = Convert.IsDBNull(dataRow["WORK_ADDRESS"]) ? null : (System.String)dataRow["WORK_ADDRESS"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdGuard"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdGuard Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdGuard entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeMaritalStateIdSource	
			if (CanDeepLoad(entity, "GsCdeMaritalStatus|GsCodeMaritalStateIdSource", deepLoadType, innerList) 
				&& entity.GsCodeMaritalStateIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeMaritalStateId ?? 0.0m);
				GsCdeMaritalStatus tmpEntity = EntityManager.LocateEntity<GsCdeMaritalStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeMaritalStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeMaritalStateIdSource = tmpEntity;
				else
					entity.GsCodeMaritalStateIdSource = DataRepository.GsCdeMaritalStatusProvider.GetByGsCdeMaritalStatusId(transactionManager, (entity.GsCodeMaritalStateId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeMaritalStateIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeMaritalStateIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeMaritalStatusProvider.DeepLoad(transactionManager, entity.GsCodeMaritalStateIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeMaritalStateIdSource

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource

			#region GsCodeEducationLevelIdSource	
			if (CanDeepLoad(entity, "GsCodeEducationLevel|GsCodeEducationLevelIdSource", deepLoadType, innerList) 
				&& entity.GsCodeEducationLevelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeEducationLevelId ?? 0.0m);
				GsCodeEducationLevel tmpEntity = EntityManager.LocateEntity<GsCodeEducationLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeEducationLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeEducationLevelIdSource = tmpEntity;
				else
					entity.GsCodeEducationLevelIdSource = DataRepository.GsCodeEducationLevelProvider.GetByGsCodeEducationLevelId(transactionManager, (entity.GsCodeEducationLevelId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeEducationLevelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeEducationLevelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeEducationLevelProvider.DeepLoad(transactionManager, entity.GsCodeEducationLevelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeEducationLevelIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
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
			// Deep load child collections  - Call GetByEdGuardId methods when available
			
			#region EdStudGuardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGuard>|EdStudGuardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGuardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGuardCollection = DataRepository.EdStudGuardProvider.GetByEdGuardId(transactionManager, entity.EdGuardId);

				if (deep && entity.EdStudGuardCollection.Count > 0)
				{
					deepHandles.Add("EdStudGuardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGuard>) DataRepository.EdStudGuardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGuardCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdGuard object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdGuard instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdGuard Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdGuard entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeMaritalStateIdSource
			if (CanDeepSave(entity, "GsCdeMaritalStatus|GsCodeMaritalStateIdSource", deepSaveType, innerList) 
				&& entity.GsCodeMaritalStateIdSource != null)
			{
				DataRepository.GsCdeMaritalStatusProvider.Save(transactionManager, entity.GsCodeMaritalStateIdSource);
				entity.GsCodeMaritalStateId = entity.GsCodeMaritalStateIdSource.GsCdeMaritalStatusId;
			}
			#endregion 
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			
			#region GsCodeEducationLevelIdSource
			if (CanDeepSave(entity, "GsCodeEducationLevel|GsCodeEducationLevelIdSource", deepSaveType, innerList) 
				&& entity.GsCodeEducationLevelIdSource != null)
			{
				DataRepository.GsCodeEducationLevelProvider.Save(transactionManager, entity.GsCodeEducationLevelIdSource);
				entity.GsCodeEducationLevelId = entity.GsCodeEducationLevelIdSource.GsCodeEducationLevelId;
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
	
			#region List<EdStudGuard>
				if (CanDeepSave(entity.EdStudGuardCollection, "List<EdStudGuard>|EdStudGuardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGuard child in entity.EdStudGuardCollection)
					{
						if(child.EdGuardIdSource != null)
						{
							child.EdGuardId = child.EdGuardIdSource.EdGuardId;
						}
						else
						{
							child.EdGuardId = entity.EdGuardId;
						}

					}

					if (entity.EdStudGuardCollection.Count > 0 || entity.EdStudGuardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGuardProvider.Save(transactionManager, entity.EdStudGuardCollection);
						
						deepHandles.Add("EdStudGuardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGuard >) DataRepository.EdStudGuardProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGuardCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdGuardChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdGuard</c>
	///</summary>
	public enum EdGuardChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCdeMaritalStatus</c> at GsCodeMaritalStateIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeMaritalStatus))]
		GsCdeMaritalStatus,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>GsCodeEducationLevel</c> at GsCodeEducationLevelIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeEducationLevel))]
		GsCodeEducationLevel,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		///<summary>
		/// Collection of <c>EdGuard</c> as OneToMany for EdStudGuardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGuard>))]
		EdStudGuardCollection,
	}
	
	#endregion EdGuardChildEntityTypes
	
	#region EdGuardFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdGuardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdGuard"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdGuardFilterBuilder : SqlFilterBuilder<EdGuardColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdGuardFilterBuilder class.
		/// </summary>
		public EdGuardFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdGuardFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdGuardFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdGuardFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdGuardFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdGuardFilterBuilder
	
	#region EdGuardParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdGuardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdGuard"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdGuardParameterBuilder : ParameterizedSqlFilterBuilder<EdGuardColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdGuardParameterBuilder class.
		/// </summary>
		public EdGuardParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdGuardParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdGuardParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdGuardParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdGuardParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdGuardParameterBuilder
	
	#region EdGuardSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdGuardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdGuard"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdGuardSortBuilder : SqlSortBuilder<EdGuardColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdGuardSqlSortBuilder class.
		/// </summary>
		public EdGuardSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdGuardSortBuilder
	
} // end namespace
