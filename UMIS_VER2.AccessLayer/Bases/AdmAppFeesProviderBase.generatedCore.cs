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
	/// This class is the base class for any <see cref="AdmAppFeesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppFeesProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppFees, UMIS_VER2.BusinessLyer.AdmAppFeesKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppFeesKey key)
		{
			return Delete(transactionManager, key.AdmAppFeesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppFeesId">Like FEE_STUD_FEE_ITEM XXسداد رسوم القبولXX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppFeesId)
		{
			return Delete(null, _admAppFeesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeesId">Like FEE_STUD_FEE_ITEM XXسداد رسوم القبولXX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppFeesId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_APP_FEES_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(_admOpenAcadSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_APP_FEES_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppFees> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_APP_FEES_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmAppFeesAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmAppFeesAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId, int start, int pageLength,out int count)
		{
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_APP_FEES_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public abstract TList<AdmAppFees> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_FEE_CODE_BANKS key.
		///		FK_ADM_APP_FEES_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="_feeCodeBankId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(_feeCodeBankId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_FEE_CODE_BANKS key.
		///		FK_ADM_APP_FEES_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppFees> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_FEE_CODE_BANKS key.
		///		FK_ADM_APP_FEES_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_FEE_CODE_BANKS key.
		///		fkAdmAppFeesFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_FEE_CODE_BANKS key.
		///		fkAdmAppFeesFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_FEE_CODE_BANKS key.
		///		FK_ADM_APP_FEES_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public abstract TList<AdmAppFees> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_CURRENCY key.
		///		FK_ADM_APP_FEES_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_CURRENCY key.
		///		FK_ADM_APP_FEES_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppFees> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_CURRENCY key.
		///		FK_ADM_APP_FEES_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_CURRENCY key.
		///		fkAdmAppFeesGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_CURRENCY key.
		///		fkAdmAppFeesGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_CURRENCY key.
		///		FK_ADM_APP_FEES_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public abstract TList<AdmAppFees> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_PAY_METHOD key.
		///		FK_ADM_APP_FEES_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="_gsCodePayMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByGsCodePayMethodId(System.Decimal? _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(_gsCodePayMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_PAY_METHOD key.
		///		FK_ADM_APP_FEES_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppFees> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal? _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_PAY_METHOD key.
		///		FK_ADM_APP_FEES_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal? _gsCodePayMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_PAY_METHOD key.
		///		fkAdmAppFeesGsCodePayMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByGsCodePayMethodId(System.Decimal? _gsCodePayMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_PAY_METHOD key.
		///		fkAdmAppFeesGsCodePayMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetByGsCodePayMethodId(System.Decimal? _gsCodePayMethodId, int start, int pageLength,out int count)
		{
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_GS_CODE_PAY_METHOD key.
		///		FK_ADM_APP_FEES_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public abstract TList<AdmAppFees> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal? _gsCodePayMethodId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_SE_USER key.
		///		FK_ADM_APP_FEES_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_SE_USER key.
		///		FK_ADM_APP_FEES_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppFees> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_SE_USER key.
		///		FK_ADM_APP_FEES_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_SE_USER key.
		///		fkAdmAppFeesSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_SE_USER key.
		///		fkAdmAppFeesSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public TList<AdmAppFees> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEES_SE_USER key.
		///		FK_ADM_APP_FEES_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFees objects.</returns>
		public abstract TList<AdmAppFees> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppFees Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppFeesKey key, int start, int pageLength)
		{
			return GetByAdmAppFeesId(transactionManager, key.AdmAppFeesId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public TList<AdmAppFees> GetByAdmApplicantId(System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(null,_admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public TList<AdmAppFees> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public TList<AdmAppFees> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public TList<AdmAppFees> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public TList<AdmAppFees> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public abstract TList<AdmAppFees> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_CDE_FEE_ID_1 index.
		/// </summary>
		/// <param name="_admCdeFeeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public TList<AdmAppFees> GetByAdmCdeFeeId(System.Decimal _admCdeFeeId)
		{
			int count = -1;
			return GetByAdmCdeFeeId(null,_admCdeFeeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_FEE_ID_1 index.
		/// </summary>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public TList<AdmAppFees> GetByAdmCdeFeeId(System.Decimal _admCdeFeeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeFeeId(null, _admCdeFeeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_FEE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public TList<AdmAppFees> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal _admCdeFeeId)
		{
			int count = -1;
			return GetByAdmCdeFeeId(transactionManager, _admCdeFeeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_FEE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public TList<AdmAppFees> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal _admCdeFeeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeFeeId(transactionManager, _admCdeFeeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_FEE_ID_1 index.
		/// </summary>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public TList<AdmAppFees> GetByAdmCdeFeeId(System.Decimal _admCdeFeeId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeFeeId(null, _admCdeFeeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_FEE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppFees&gt;"/> class.</returns>
		public abstract TList<AdmAppFees> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal _admCdeFeeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_FEES index.
		/// </summary>
		/// <param name="_admAppFeesId">Like FEE_STUD_FEE_ITEM XXسداد رسوم القبولXX</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFees GetByAdmAppFeesId(System.Decimal _admAppFeesId)
		{
			int count = -1;
			return GetByAdmAppFeesId(null,_admAppFeesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_FEES index.
		/// </summary>
		/// <param name="_admAppFeesId">Like FEE_STUD_FEE_ITEM XXسداد رسوم القبولXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFees GetByAdmAppFeesId(System.Decimal _admAppFeesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppFeesId(null, _admAppFeesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_FEES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeesId">Like FEE_STUD_FEE_ITEM XXسداد رسوم القبولXX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFees GetByAdmAppFeesId(TransactionManager transactionManager, System.Decimal _admAppFeesId)
		{
			int count = -1;
			return GetByAdmAppFeesId(transactionManager, _admAppFeesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_FEES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeesId">Like FEE_STUD_FEE_ITEM XXسداد رسوم القبولXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFees GetByAdmAppFeesId(TransactionManager transactionManager, System.Decimal _admAppFeesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppFeesId(transactionManager, _admAppFeesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_FEES index.
		/// </summary>
		/// <param name="_admAppFeesId">Like FEE_STUD_FEE_ITEM XXسداد رسوم القبولXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFees GetByAdmAppFeesId(System.Decimal _admAppFeesId, int start, int pageLength, out int count)
		{
			return GetByAdmAppFeesId(null, _admAppFeesId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_FEES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeesId">Like FEE_STUD_FEE_ITEM XXسداد رسوم القبولXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppFees GetByAdmAppFeesId(TransactionManager transactionManager, System.Decimal _admAppFeesId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppFees&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppFees&gt;"/></returns>
		public static TList<AdmAppFees> Fill(IDataReader reader, TList<AdmAppFees> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppFees c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppFees")
					.Append("|").Append((System.Decimal)reader["ADM_APP_FEES_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppFees>(
					key.ToString(), // EntityTrackingKey
					"AdmAppFees",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppFees();
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
					c.AdmAppFeesId = (System.Decimal)reader["ADM_APP_FEES_ID"];
					c.OriginalAdmAppFeesId = c.AdmAppFeesId;
					c.AdmCdeFeeId = (System.Decimal)reader["ADM_CDE_FEE_ID"];
					c.AdmApplicantId = (System.Decimal)reader["ADM_APPLICANT_ID"];
					c.IsPayed = Convert.IsDBNull(reader["IS_PAYED"]) ? null : (System.Decimal?)reader["IS_PAYED"];
					c.AdmOpenAcadSemesterId = Convert.IsDBNull(reader["ADM_OPEN_ACAD_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
					c.ReceiptNum = Convert.IsDBNull(reader["RECEIPT_NUM"]) ? null : (System.String)reader["RECEIPT_NUM"];
					c.ReceiptDate = Convert.IsDBNull(reader["RECEIPT_DATE"]) ? null : (System.DateTime?)reader["RECEIPT_DATE"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.GsCodePayMethodId = Convert.IsDBNull(reader["GS_CODE_PAY_METHOD_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PAY_METHOD_ID"];
					c.FeeCodeBankId = Convert.IsDBNull(reader["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_BANK_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.CheqNum = Convert.IsDBNull(reader["CHEQ_NUM"]) ? null : (System.String)reader["CHEQ_NUM"];
					c.AccntNum = Convert.IsDBNull(reader["ACCNT_NUM"]) ? null : (System.String)reader["ACCNT_NUM"];
					c.AttchdDoc = Convert.IsDBNull(reader["ATTCHD_DOC"]) ? null : (System.String)reader["ATTCHD_DOC"];
					c.UserName = Convert.IsDBNull(reader["User_Name"]) ? null : (System.String)reader["User_Name"];
					c.FeeAmount = Convert.IsDBNull(reader["FEE_AMOUNT"]) ? null : (System.Decimal?)reader["FEE_AMOUNT"];
					c.FeeRemainAmount = Convert.IsDBNull(reader["FEE_REMAIN_AMOUNT"]) ? null : (System.Decimal?)reader["FEE_REMAIN_AMOUNT"];
					c.CancelFlg = Convert.IsDBNull(reader["CANCEL_FLG"]) ? null : (System.Boolean?)reader["CANCEL_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppFees entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppFeesId = (System.Decimal)reader[((int)AdmAppFeesColumn.AdmAppFeesId - 1)];
			entity.OriginalAdmAppFeesId = (System.Decimal)reader["ADM_APP_FEES_ID"];
			entity.AdmCdeFeeId = (System.Decimal)reader[((int)AdmAppFeesColumn.AdmCdeFeeId - 1)];
			entity.AdmApplicantId = (System.Decimal)reader[((int)AdmAppFeesColumn.AdmApplicantId - 1)];
			entity.IsPayed = (reader.IsDBNull(((int)AdmAppFeesColumn.IsPayed - 1)))?null:(System.Decimal?)reader[((int)AdmAppFeesColumn.IsPayed - 1)];
			entity.AdmOpenAcadSemesterId = (reader.IsDBNull(((int)AdmAppFeesColumn.AdmOpenAcadSemesterId - 1)))?null:(System.Decimal?)reader[((int)AdmAppFeesColumn.AdmOpenAcadSemesterId - 1)];
			entity.ReceiptNum = (reader.IsDBNull(((int)AdmAppFeesColumn.ReceiptNum - 1)))?null:(System.String)reader[((int)AdmAppFeesColumn.ReceiptNum - 1)];
			entity.ReceiptDate = (reader.IsDBNull(((int)AdmAppFeesColumn.ReceiptDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppFeesColumn.ReceiptDate - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)AdmAppFeesColumn.GsCodeCurrencyId - 1)];
			entity.GsCodePayMethodId = (reader.IsDBNull(((int)AdmAppFeesColumn.GsCodePayMethodId - 1)))?null:(System.Decimal?)reader[((int)AdmAppFeesColumn.GsCodePayMethodId - 1)];
			entity.FeeCodeBankId = (reader.IsDBNull(((int)AdmAppFeesColumn.FeeCodeBankId - 1)))?null:(System.Decimal?)reader[((int)AdmAppFeesColumn.FeeCodeBankId - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmAppFeesColumn.Notes - 1)))?null:(System.String)reader[((int)AdmAppFeesColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppFeesColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppFeesColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppFeesColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppFeesColumn.LastDate - 1)];
			entity.CheqNum = (reader.IsDBNull(((int)AdmAppFeesColumn.CheqNum - 1)))?null:(System.String)reader[((int)AdmAppFeesColumn.CheqNum - 1)];
			entity.AccntNum = (reader.IsDBNull(((int)AdmAppFeesColumn.AccntNum - 1)))?null:(System.String)reader[((int)AdmAppFeesColumn.AccntNum - 1)];
			entity.AttchdDoc = (reader.IsDBNull(((int)AdmAppFeesColumn.AttchdDoc - 1)))?null:(System.String)reader[((int)AdmAppFeesColumn.AttchdDoc - 1)];
			entity.UserName = (reader.IsDBNull(((int)AdmAppFeesColumn.UserName - 1)))?null:(System.String)reader[((int)AdmAppFeesColumn.UserName - 1)];
			entity.FeeAmount = (reader.IsDBNull(((int)AdmAppFeesColumn.FeeAmount - 1)))?null:(System.Decimal?)reader[((int)AdmAppFeesColumn.FeeAmount - 1)];
			entity.FeeRemainAmount = (reader.IsDBNull(((int)AdmAppFeesColumn.FeeRemainAmount - 1)))?null:(System.Decimal?)reader[((int)AdmAppFeesColumn.FeeRemainAmount - 1)];
			entity.CancelFlg = (reader.IsDBNull(((int)AdmAppFeesColumn.CancelFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppFeesColumn.CancelFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppFees entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppFeesId = (System.Decimal)dataRow["ADM_APP_FEES_ID"];
			entity.OriginalAdmAppFeesId = (System.Decimal)dataRow["ADM_APP_FEES_ID"];
			entity.AdmCdeFeeId = (System.Decimal)dataRow["ADM_CDE_FEE_ID"];
			entity.AdmApplicantId = (System.Decimal)dataRow["ADM_APPLICANT_ID"];
			entity.IsPayed = Convert.IsDBNull(dataRow["IS_PAYED"]) ? null : (System.Decimal?)dataRow["IS_PAYED"];
			entity.AdmOpenAcadSemesterId = Convert.IsDBNull(dataRow["ADM_OPEN_ACAD_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.ReceiptNum = Convert.IsDBNull(dataRow["RECEIPT_NUM"]) ? null : (System.String)dataRow["RECEIPT_NUM"];
			entity.ReceiptDate = Convert.IsDBNull(dataRow["RECEIPT_DATE"]) ? null : (System.DateTime?)dataRow["RECEIPT_DATE"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.GsCodePayMethodId = Convert.IsDBNull(dataRow["GS_CODE_PAY_METHOD_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PAY_METHOD_ID"];
			entity.FeeCodeBankId = Convert.IsDBNull(dataRow["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_BANK_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.CheqNum = Convert.IsDBNull(dataRow["CHEQ_NUM"]) ? null : (System.String)dataRow["CHEQ_NUM"];
			entity.AccntNum = Convert.IsDBNull(dataRow["ACCNT_NUM"]) ? null : (System.String)dataRow["ACCNT_NUM"];
			entity.AttchdDoc = Convert.IsDBNull(dataRow["ATTCHD_DOC"]) ? null : (System.String)dataRow["ATTCHD_DOC"];
			entity.UserName = Convert.IsDBNull(dataRow["User_Name"]) ? null : (System.String)dataRow["User_Name"];
			entity.FeeAmount = Convert.IsDBNull(dataRow["FEE_AMOUNT"]) ? null : (System.Decimal?)dataRow["FEE_AMOUNT"];
			entity.FeeRemainAmount = Convert.IsDBNull(dataRow["FEE_REMAIN_AMOUNT"]) ? null : (System.Decimal?)dataRow["FEE_REMAIN_AMOUNT"];
			entity.CancelFlg = Convert.IsDBNull(dataRow["CANCEL_FLG"]) ? null : (System.Boolean?)dataRow["CANCEL_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppFees"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppFees Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppFees entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmApplicantId;
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);		
				
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

			#region AdmCdeFeeIdSource	
			if (CanDeepLoad(entity, "AdmCdeFee|AdmCdeFeeIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeFeeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdeFeeId;
				AdmCdeFee tmpEntity = EntityManager.LocateEntity<AdmCdeFee>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeFee), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeFeeIdSource = tmpEntity;
				else
					entity.AdmCdeFeeIdSource = DataRepository.AdmCdeFeeProvider.GetByAdmCdeFeeId(transactionManager, entity.AdmCdeFeeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeFeeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeFeeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeFeeProvider.DeepLoad(transactionManager, entity.AdmCdeFeeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeFeeIdSource

			#region AdmOpenAcadSemesterIdSource	
			if (CanDeepLoad(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepLoadType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmOpenAcadSemesterId ?? 0.0m);
				AdmOpenAcadSemester tmpEntity = EntityManager.LocateEntity<AdmOpenAcadSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmOpenAcadSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmOpenAcadSemesterIdSource = tmpEntity;
				else
					entity.AdmOpenAcadSemesterIdSource = DataRepository.AdmOpenAcadSemesterProvider.GetByAdmOpenAcadSemesterId(transactionManager, (entity.AdmOpenAcadSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOpenAcadSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmOpenAcadSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmOpenAcadSemesterProvider.DeepLoad(transactionManager, entity.AdmOpenAcadSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmOpenAcadSemesterIdSource

			#region FeeCodeBankIdSource	
			if (CanDeepLoad(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeBankIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeBankId ?? 0.0m);
				FeeCodeBanks tmpEntity = EntityManager.LocateEntity<FeeCodeBanks>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeBanks), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeBankIdSource = tmpEntity;
				else
					entity.FeeCodeBankIdSource = DataRepository.FeeCodeBanksProvider.GetByFeeCodeBankId(transactionManager, (entity.FeeCodeBankId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeBankIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeBankIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeBanksProvider.DeepLoad(transactionManager, entity.FeeCodeBankIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeBankIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeCurrencyId;
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.GsCodeCurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCurrencyIdSource

			#region GsCodePayMethodIdSource	
			if (CanDeepLoad(entity, "GsCodePayMethod|GsCodePayMethodIdSource", deepLoadType, innerList) 
				&& entity.GsCodePayMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodePayMethodId ?? 0.0m);
				GsCodePayMethod tmpEntity = EntityManager.LocateEntity<GsCodePayMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePayMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePayMethodIdSource = tmpEntity;
				else
					entity.GsCodePayMethodIdSource = DataRepository.GsCodePayMethodProvider.GetByGsCodePayMethodId(transactionManager, (entity.GsCodePayMethodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePayMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePayMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePayMethodProvider.DeepLoad(transactionManager, entity.GsCodePayMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePayMethodIdSource

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
			// Deep load child collections  - Call GetByAdmAppFeesId methods when available
			
			#region FeeStudVoucherItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherItemCollection = DataRepository.FeeStudVoucherItemProvider.GetByAdmAppFeesId(transactionManager, entity.AdmAppFeesId);

				if (deep && entity.FeeStudVoucherItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherItem>) DataRepository.FeeStudVoucherItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefndStdDetCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefndStdDet>|FeeRefndStdDetCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdDetCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefndStdDetCollection = DataRepository.FeeRefndStdDetProvider.GetByAdmAppFeesId(transactionManager, entity.AdmAppFeesId);

				if (deep && entity.FeeRefndStdDetCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdDetCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdDet>) DataRepository.FeeRefndStdDetProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdDetCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppFees object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppFees instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppFees Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppFees entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AdmCdeFeeIdSource
			if (CanDeepSave(entity, "AdmCdeFee|AdmCdeFeeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeFeeIdSource != null)
			{
				DataRepository.AdmCdeFeeProvider.Save(transactionManager, entity.AdmCdeFeeIdSource);
				entity.AdmCdeFeeId = entity.AdmCdeFeeIdSource.AdmCdeFeeId;
			}
			#endregion 
			
			#region AdmOpenAcadSemesterIdSource
			if (CanDeepSave(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepSaveType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource != null)
			{
				DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterIdSource);
				entity.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
			}
			#endregion 
			
			#region FeeCodeBankIdSource
			if (CanDeepSave(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeBankIdSource != null)
			{
				DataRepository.FeeCodeBanksProvider.Save(transactionManager, entity.FeeCodeBankIdSource);
				entity.FeeCodeBankId = entity.FeeCodeBankIdSource.FeeCodeBankId;
			}
			#endregion 
			
			#region GsCodeCurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.GsCodeCurrencyIdSource);
				entity.GsCodeCurrencyId = entity.GsCodeCurrencyIdSource.GsCodeCurrencyId;
			}
			#endregion 
			
			#region GsCodePayMethodIdSource
			if (CanDeepSave(entity, "GsCodePayMethod|GsCodePayMethodIdSource", deepSaveType, innerList) 
				&& entity.GsCodePayMethodIdSource != null)
			{
				DataRepository.GsCodePayMethodProvider.Save(transactionManager, entity.GsCodePayMethodIdSource);
				entity.GsCodePayMethodId = entity.GsCodePayMethodIdSource.GsCodePayMethodId;
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
	
			#region List<FeeStudVoucherItem>
				if (CanDeepSave(entity.FeeStudVoucherItemCollection, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherItem child in entity.FeeStudVoucherItemCollection)
					{
						if(child.AdmAppFeesIdSource != null)
						{
							child.AdmAppFeesId = child.AdmAppFeesIdSource.AdmAppFeesId;
						}
						else
						{
							child.AdmAppFeesId = entity.AdmAppFeesId;
						}

					}

					if (entity.FeeStudVoucherItemCollection.Count > 0 || entity.FeeStudVoucherItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherItemProvider.Save(transactionManager, entity.FeeStudVoucherItemCollection);
						
						deepHandles.Add("FeeStudVoucherItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucherItem >) DataRepository.FeeStudVoucherItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefndStdDet>
				if (CanDeepSave(entity.FeeRefndStdDetCollection, "List<FeeRefndStdDet>|FeeRefndStdDetCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefndStdDet child in entity.FeeRefndStdDetCollection)
					{
						if(child.AdmAppFeesIdSource != null)
						{
							child.AdmAppFeesId = child.AdmAppFeesIdSource.AdmAppFeesId;
						}
						else
						{
							child.AdmAppFeesId = entity.AdmAppFeesId;
						}

					}

					if (entity.FeeRefndStdDetCollection.Count > 0 || entity.FeeRefndStdDetCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefndStdDetProvider.Save(transactionManager, entity.FeeRefndStdDetCollection);
						
						deepHandles.Add("FeeRefndStdDetCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefndStdDet >) DataRepository.FeeRefndStdDetProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefndStdDetCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmAppFeesChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppFees</c>
	///</summary>
	public enum AdmAppFeesChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>AdmCdeFee</c> at AdmCdeFeeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeFee))]
		AdmCdeFee,
		
		///<summary>
		/// Composite Property for <c>AdmOpenAcadSemester</c> at AdmOpenAcadSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(AdmOpenAcadSemester))]
		AdmOpenAcadSemester,
		
		///<summary>
		/// Composite Property for <c>FeeCodeBanks</c> at FeeCodeBankIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeBanks))]
		FeeCodeBanks,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		
		///<summary>
		/// Composite Property for <c>GsCodePayMethod</c> at GsCodePayMethodIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePayMethod))]
		GsCodePayMethod,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>AdmAppFees</c> as OneToMany for FeeStudVoucherItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherItem>))]
		FeeStudVoucherItemCollection,
		///<summary>
		/// Collection of <c>AdmAppFees</c> as OneToMany for FeeRefndStdDetCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdDet>))]
		FeeRefndStdDetCollection,
	}
	
	#endregion AdmAppFeesChildEntityTypes
	
	#region AdmAppFeesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppFeesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppFees"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppFeesFilterBuilder : SqlFilterBuilder<AdmAppFeesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppFeesFilterBuilder class.
		/// </summary>
		public AdmAppFeesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppFeesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppFeesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppFeesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppFeesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppFeesFilterBuilder
	
	#region AdmAppFeesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppFeesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppFees"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppFeesParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppFeesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppFeesParameterBuilder class.
		/// </summary>
		public AdmAppFeesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppFeesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppFeesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppFeesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppFeesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppFeesParameterBuilder
	
	#region AdmAppFeesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppFeesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppFees"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppFeesSortBuilder : SqlSortBuilder<AdmAppFeesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppFeesSqlSortBuilder class.
		/// </summary>
		public AdmAppFeesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppFeesSortBuilder
	
} // end namespace
