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
	/// This class is the base class for any <see cref="IntegUserAdLogDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class IntegUserAdLogDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.IntegUserAdLogDtl, UMIS_VER2.BusinessLyer.IntegUserAdLogDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegUserAdLogDtlKey key)
		{
			return Delete(transactionManager, key.IntegUserAdLogDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_integUserAdLogDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _integUserAdLogDtlId)
		{
			return Delete(null, _integUserAdLogDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _integUserAdLogDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_ED_STUD key.
		///		FK_INTEG_USER_AD_LOG_DTL_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_ED_STUD key.
		///		FK_INTEG_USER_AD_LOG_DTL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		/// <remarks></remarks>
		public TList<IntegUserAdLogDtl> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_ED_STUD key.
		///		FK_INTEG_USER_AD_LOG_DTL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_ED_STUD key.
		///		fkIntegUserAdLogDtlEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_ED_STUD key.
		///		fkIntegUserAdLogDtlEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_ED_STUD key.
		///		FK_INTEG_USER_AD_LOG_DTL_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public abstract TList<IntegUserAdLogDtl> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_CDE_ERROR_TYPE key.
		///		FK_INTEG_USER_AD_LOG_DTL_INTEG_CDE_ERROR_TYPE Description: 
		/// </summary>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByIntegCdeErrorTypeId(System.Int32 _integCdeErrorTypeId)
		{
			int count = -1;
			return GetByIntegCdeErrorTypeId(_integCdeErrorTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_CDE_ERROR_TYPE key.
		///		FK_INTEG_USER_AD_LOG_DTL_INTEG_CDE_ERROR_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		/// <remarks></remarks>
		public TList<IntegUserAdLogDtl> GetByIntegCdeErrorTypeId(TransactionManager transactionManager, System.Int32 _integCdeErrorTypeId)
		{
			int count = -1;
			return GetByIntegCdeErrorTypeId(transactionManager, _integCdeErrorTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_CDE_ERROR_TYPE key.
		///		FK_INTEG_USER_AD_LOG_DTL_INTEG_CDE_ERROR_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByIntegCdeErrorTypeId(TransactionManager transactionManager, System.Int32 _integCdeErrorTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegCdeErrorTypeId(transactionManager, _integCdeErrorTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_CDE_ERROR_TYPE key.
		///		fkIntegUserAdLogDtlIntegCdeErrorType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByIntegCdeErrorTypeId(System.Int32 _integCdeErrorTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByIntegCdeErrorTypeId(null, _integCdeErrorTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_CDE_ERROR_TYPE key.
		///		fkIntegUserAdLogDtlIntegCdeErrorType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByIntegCdeErrorTypeId(System.Int32 _integCdeErrorTypeId, int start, int pageLength,out int count)
		{
			return GetByIntegCdeErrorTypeId(null, _integCdeErrorTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_CDE_ERROR_TYPE key.
		///		FK_INTEG_USER_AD_LOG_DTL_INTEG_CDE_ERROR_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public abstract TList<IntegUserAdLogDtl> GetByIntegCdeErrorTypeId(TransactionManager transactionManager, System.Int32 _integCdeErrorTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_USER_AD_LOG_HDR key.
		///		FK_INTEG_USER_AD_LOG_DTL_INTEG_USER_AD_LOG_HDR Description: 
		/// </summary>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByIntegUserAdLogHdrId(System.Decimal _integUserAdLogHdrId)
		{
			int count = -1;
			return GetByIntegUserAdLogHdrId(_integUserAdLogHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_USER_AD_LOG_HDR key.
		///		FK_INTEG_USER_AD_LOG_DTL_INTEG_USER_AD_LOG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		/// <remarks></remarks>
		public TList<IntegUserAdLogDtl> GetByIntegUserAdLogHdrId(TransactionManager transactionManager, System.Decimal _integUserAdLogHdrId)
		{
			int count = -1;
			return GetByIntegUserAdLogHdrId(transactionManager, _integUserAdLogHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_USER_AD_LOG_HDR key.
		///		FK_INTEG_USER_AD_LOG_DTL_INTEG_USER_AD_LOG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByIntegUserAdLogHdrId(TransactionManager transactionManager, System.Decimal _integUserAdLogHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegUserAdLogHdrId(transactionManager, _integUserAdLogHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_USER_AD_LOG_HDR key.
		///		fkIntegUserAdLogDtlIntegUserAdLogHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByIntegUserAdLogHdrId(System.Decimal _integUserAdLogHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByIntegUserAdLogHdrId(null, _integUserAdLogHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_USER_AD_LOG_HDR key.
		///		fkIntegUserAdLogDtlIntegUserAdLogHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetByIntegUserAdLogHdrId(System.Decimal _integUserAdLogHdrId, int start, int pageLength,out int count)
		{
			return GetByIntegUserAdLogHdrId(null, _integUserAdLogHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_INTEG_USER_AD_LOG_HDR key.
		///		FK_INTEG_USER_AD_LOG_DTL_INTEG_USER_AD_LOG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public abstract TList<IntegUserAdLogDtl> GetByIntegUserAdLogHdrId(TransactionManager transactionManager, System.Decimal _integUserAdLogHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SA_STF_MEMBER key.
		///		FK_INTEG_USER_AD_LOG_DTL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SA_STF_MEMBER key.
		///		FK_INTEG_USER_AD_LOG_DTL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		/// <remarks></remarks>
		public TList<IntegUserAdLogDtl> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SA_STF_MEMBER key.
		///		FK_INTEG_USER_AD_LOG_DTL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SA_STF_MEMBER key.
		///		fkIntegUserAdLogDtlSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SA_STF_MEMBER key.
		///		fkIntegUserAdLogDtlSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SA_STF_MEMBER key.
		///		FK_INTEG_USER_AD_LOG_DTL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public abstract TList<IntegUserAdLogDtl> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SE_USER key.
		///		FK_INTEG_USER_AD_LOG_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SE_USER key.
		///		FK_INTEG_USER_AD_LOG_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		/// <remarks></remarks>
		public TList<IntegUserAdLogDtl> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SE_USER key.
		///		FK_INTEG_USER_AD_LOG_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SE_USER key.
		///		fkIntegUserAdLogDtlSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SE_USER key.
		///		fkIntegUserAdLogDtlSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public TList<IntegUserAdLogDtl> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_INTEG_USER_AD_LOG_DTL_SE_USER key.
		///		FK_INTEG_USER_AD_LOG_DTL_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.IntegUserAdLogDtl objects.</returns>
		public abstract TList<IntegUserAdLogDtl> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.IntegUserAdLogDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegUserAdLogDtlKey key, int start, int pageLength)
		{
			return GetByIntegUserAdLogDtlId(transactionManager, key.IntegUserAdLogDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_INTEG_USER_AD_LOG_DTL index.
		/// </summary>
		/// <param name="_integUserAdLogDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegUserAdLogDtl GetByIntegUserAdLogDtlId(System.Decimal _integUserAdLogDtlId)
		{
			int count = -1;
			return GetByIntegUserAdLogDtlId(null,_integUserAdLogDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_USER_AD_LOG_DTL index.
		/// </summary>
		/// <param name="_integUserAdLogDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegUserAdLogDtl GetByIntegUserAdLogDtlId(System.Decimal _integUserAdLogDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegUserAdLogDtlId(null, _integUserAdLogDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_USER_AD_LOG_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegUserAdLogDtl GetByIntegUserAdLogDtlId(TransactionManager transactionManager, System.Decimal _integUserAdLogDtlId)
		{
			int count = -1;
			return GetByIntegUserAdLogDtlId(transactionManager, _integUserAdLogDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_USER_AD_LOG_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegUserAdLogDtl GetByIntegUserAdLogDtlId(TransactionManager transactionManager, System.Decimal _integUserAdLogDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegUserAdLogDtlId(transactionManager, _integUserAdLogDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_USER_AD_LOG_DTL index.
		/// </summary>
		/// <param name="_integUserAdLogDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegUserAdLogDtl GetByIntegUserAdLogDtlId(System.Decimal _integUserAdLogDtlId, int start, int pageLength, out int count)
		{
			return GetByIntegUserAdLogDtlId(null, _integUserAdLogDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_USER_AD_LOG_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integUserAdLogDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.IntegUserAdLogDtl GetByIntegUserAdLogDtlId(TransactionManager transactionManager, System.Decimal _integUserAdLogDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;IntegUserAdLogDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;IntegUserAdLogDtl&gt;"/></returns>
		public static TList<IntegUserAdLogDtl> Fill(IDataReader reader, TList<IntegUserAdLogDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.IntegUserAdLogDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("IntegUserAdLogDtl")
					.Append("|").Append((System.Decimal)reader["INTEG_USER_AD_LOG_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<IntegUserAdLogDtl>(
					key.ToString(), // EntityTrackingKey
					"IntegUserAdLogDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.IntegUserAdLogDtl();
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
					c.IntegUserAdLogDtlId = (System.Decimal)reader["INTEG_USER_AD_LOG_DTL_ID"];
					c.OriginalIntegUserAdLogDtlId = c.IntegUserAdLogDtlId;
					c.IntegUserAdLogHdrId = (System.Decimal)reader["INTEG_USER_AD_LOG_HDR_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.FailFlg = Convert.IsDBNull(reader["FAIL_FLG"]) ? null : (System.Boolean?)reader["FAIL_FLG"];
					c.IntegCdeErrorTypeId = (System.Int32)reader["INTEG_CDE_ERROR_TYPE_ID"];
					c.ErrorMsg = Convert.IsDBNull(reader["ERROR_MSG"]) ? null : (System.String)reader["ERROR_MSG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.IntegUserAdLogDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.IntegUserAdLogDtlId = (System.Decimal)reader[((int)IntegUserAdLogDtlColumn.IntegUserAdLogDtlId - 1)];
			entity.OriginalIntegUserAdLogDtlId = (System.Decimal)reader["INTEG_USER_AD_LOG_DTL_ID"];
			entity.IntegUserAdLogHdrId = (System.Decimal)reader[((int)IntegUserAdLogDtlColumn.IntegUserAdLogHdrId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)IntegUserAdLogDtlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)IntegUserAdLogDtlColumn.SeUserId - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)IntegUserAdLogDtlColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)IntegUserAdLogDtlColumn.SaStfMemberId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)IntegUserAdLogDtlColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)IntegUserAdLogDtlColumn.EdStudId - 1)];
			entity.FailFlg = (reader.IsDBNull(((int)IntegUserAdLogDtlColumn.FailFlg - 1)))?null:(System.Boolean?)reader[((int)IntegUserAdLogDtlColumn.FailFlg - 1)];
			entity.IntegCdeErrorTypeId = (System.Int32)reader[((int)IntegUserAdLogDtlColumn.IntegCdeErrorTypeId - 1)];
			entity.ErrorMsg = (reader.IsDBNull(((int)IntegUserAdLogDtlColumn.ErrorMsg - 1)))?null:(System.String)reader[((int)IntegUserAdLogDtlColumn.ErrorMsg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.IntegUserAdLogDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IntegUserAdLogDtlId = (System.Decimal)dataRow["INTEG_USER_AD_LOG_DTL_ID"];
			entity.OriginalIntegUserAdLogDtlId = (System.Decimal)dataRow["INTEG_USER_AD_LOG_DTL_ID"];
			entity.IntegUserAdLogHdrId = (System.Decimal)dataRow["INTEG_USER_AD_LOG_HDR_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.FailFlg = Convert.IsDBNull(dataRow["FAIL_FLG"]) ? null : (System.Boolean?)dataRow["FAIL_FLG"];
			entity.IntegCdeErrorTypeId = (System.Int32)dataRow["INTEG_CDE_ERROR_TYPE_ID"];
			entity.ErrorMsg = Convert.IsDBNull(dataRow["ERROR_MSG"]) ? null : (System.String)dataRow["ERROR_MSG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegUserAdLogDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegUserAdLogDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegUserAdLogDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region IntegCdeErrorTypeIdSource	
			if (CanDeepLoad(entity, "IntegCdeErrorType|IntegCdeErrorTypeIdSource", deepLoadType, innerList) 
				&& entity.IntegCdeErrorTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.IntegCdeErrorTypeId;
				IntegCdeErrorType tmpEntity = EntityManager.LocateEntity<IntegCdeErrorType>(EntityLocator.ConstructKeyFromPkItems(typeof(IntegCdeErrorType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.IntegCdeErrorTypeIdSource = tmpEntity;
				else
					entity.IntegCdeErrorTypeIdSource = DataRepository.IntegCdeErrorTypeProvider.GetByIntegCdeErrorTypeId(transactionManager, entity.IntegCdeErrorTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IntegCdeErrorTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.IntegCdeErrorTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.IntegCdeErrorTypeProvider.DeepLoad(transactionManager, entity.IntegCdeErrorTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion IntegCdeErrorTypeIdSource

			#region IntegUserAdLogHdrIdSource	
			if (CanDeepLoad(entity, "IntegUserAdLogHdr|IntegUserAdLogHdrIdSource", deepLoadType, innerList) 
				&& entity.IntegUserAdLogHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.IntegUserAdLogHdrId;
				IntegUserAdLogHdr tmpEntity = EntityManager.LocateEntity<IntegUserAdLogHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(IntegUserAdLogHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.IntegUserAdLogHdrIdSource = tmpEntity;
				else
					entity.IntegUserAdLogHdrIdSource = DataRepository.IntegUserAdLogHdrProvider.GetByIntegUserAdLogHdrId(transactionManager, entity.IntegUserAdLogHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IntegUserAdLogHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.IntegUserAdLogHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.IntegUserAdLogHdrProvider.DeepLoad(transactionManager, entity.IntegUserAdLogHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion IntegUserAdLogHdrIdSource

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

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.IntegUserAdLogDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.IntegUserAdLogDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegUserAdLogDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegUserAdLogDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region IntegCdeErrorTypeIdSource
			if (CanDeepSave(entity, "IntegCdeErrorType|IntegCdeErrorTypeIdSource", deepSaveType, innerList) 
				&& entity.IntegCdeErrorTypeIdSource != null)
			{
				DataRepository.IntegCdeErrorTypeProvider.Save(transactionManager, entity.IntegCdeErrorTypeIdSource);
				entity.IntegCdeErrorTypeId = entity.IntegCdeErrorTypeIdSource.IntegCdeErrorTypeId;
			}
			#endregion 
			
			#region IntegUserAdLogHdrIdSource
			if (CanDeepSave(entity, "IntegUserAdLogHdr|IntegUserAdLogHdrIdSource", deepSaveType, innerList) 
				&& entity.IntegUserAdLogHdrIdSource != null)
			{
				DataRepository.IntegUserAdLogHdrProvider.Save(transactionManager, entity.IntegUserAdLogHdrIdSource);
				entity.IntegUserAdLogHdrId = entity.IntegUserAdLogHdrIdSource.IntegUserAdLogHdrId;
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
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
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
	
	#region IntegUserAdLogDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.IntegUserAdLogDtl</c>
	///</summary>
	public enum IntegUserAdLogDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>IntegCdeErrorType</c> at IntegCdeErrorTypeIdSource
		///</summary>
		[ChildEntityType(typeof(IntegCdeErrorType))]
		IntegCdeErrorType,
		
		///<summary>
		/// Composite Property for <c>IntegUserAdLogHdr</c> at IntegUserAdLogHdrIdSource
		///</summary>
		[ChildEntityType(typeof(IntegUserAdLogHdr))]
		IntegUserAdLogHdr,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion IntegUserAdLogDtlChildEntityTypes
	
	#region IntegUserAdLogDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;IntegUserAdLogDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegUserAdLogDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegUserAdLogDtlFilterBuilder : SqlFilterBuilder<IntegUserAdLogDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogDtlFilterBuilder class.
		/// </summary>
		public IntegUserAdLogDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegUserAdLogDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegUserAdLogDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegUserAdLogDtlFilterBuilder
	
	#region IntegUserAdLogDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;IntegUserAdLogDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegUserAdLogDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegUserAdLogDtlParameterBuilder : ParameterizedSqlFilterBuilder<IntegUserAdLogDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogDtlParameterBuilder class.
		/// </summary>
		public IntegUserAdLogDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegUserAdLogDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegUserAdLogDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegUserAdLogDtlParameterBuilder
	
	#region IntegUserAdLogDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;IntegUserAdLogDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegUserAdLogDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class IntegUserAdLogDtlSortBuilder : SqlSortBuilder<IntegUserAdLogDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegUserAdLogDtlSqlSortBuilder class.
		/// </summary>
		public IntegUserAdLogDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion IntegUserAdLogDtlSortBuilder
	
} // end namespace
