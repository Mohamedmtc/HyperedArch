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
	/// This class is the base class for any <see cref="AdmAppTransReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppTransReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppTransReq, UMIS_VER2.BusinessLyer.AdmAppTransReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransReqKey key)
		{
			return Delete(transactionManager, key.AdmAppTransReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppTransReqId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppTransReqId)
		{
			return Delete(null, _admAppTransReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppTransReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_TRANS_REQ_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_TRANS_REQ_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppTransReq> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_TRANS_REQ_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_APP_REG_HISTORY key.
		///		fkAdmAppTransReqAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_APP_REG_HISTORY key.
		///		fkAdmAppTransReqAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_TRANS_REQ_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public abstract TList<AdmAppTransReq> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ADM_APP_TRANS_REQ_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="_admCodeTransferTypeId">خارجى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAdmCodeTransferTypeId(System.Decimal? _admCodeTransferTypeId)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(_admCodeTransferTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ADM_APP_TRANS_REQ_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId">خارجى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppTransReq> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal? _admCodeTransferTypeId)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(transactionManager, _admCodeTransferTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ADM_APP_TRANS_REQ_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId">خارجى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal? _admCodeTransferTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeTransferTypeId(transactionManager, _admCodeTransferTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_CODE_TRANSFER_TYPE key.
		///		fkAdmAppTransReqAdmCodeTransferType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeTransferTypeId">خارجى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAdmCodeTransferTypeId(System.Decimal? _admCodeTransferTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCodeTransferTypeId(null, _admCodeTransferTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_CODE_TRANSFER_TYPE key.
		///		fkAdmAppTransReqAdmCodeTransferType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeTransferTypeId">خارجى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAdmCodeTransferTypeId(System.Decimal? _admCodeTransferTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCodeTransferTypeId(null, _admCodeTransferTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ADM_CODE_TRANSFER_TYPE key.
		///		FK_ADM_APP_TRANS_REQ_ADM_CODE_TRANSFER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeTransferTypeId">خارجى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public abstract TList<AdmAppTransReq> GetByAdmCodeTransferTypeId(TransactionManager transactionManager, System.Decimal? _admCodeTransferTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_AS_FACULTY_INFO key.
		///		FK_ADM_APP_TRANS_REQ_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_AS_FACULTY_INFO key.
		///		FK_ADM_APP_TRANS_REQ_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppTransReq> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_AS_FACULTY_INFO key.
		///		FK_ADM_APP_TRANS_REQ_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_AS_FACULTY_INFO key.
		///		fkAdmAppTransReqAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_AS_FACULTY_INFO key.
		///		fkAdmAppTransReqAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_AS_FACULTY_INFO key.
		///		FK_ADM_APP_TRANS_REQ_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public abstract TList<AdmAppTransReq> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL key.
		///		FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByEdCodeLevelReqId(System.Decimal? _edCodeLevelReqId)
		{
			int count = -1;
			return GetByEdCodeLevelReqId(_edCodeLevelReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL key.
		///		FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppTransReq> GetByEdCodeLevelReqId(TransactionManager transactionManager, System.Decimal? _edCodeLevelReqId)
		{
			int count = -1;
			return GetByEdCodeLevelReqId(transactionManager, _edCodeLevelReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL key.
		///		FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByEdCodeLevelReqId(TransactionManager transactionManager, System.Decimal? _edCodeLevelReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelReqId(transactionManager, _edCodeLevelReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL key.
		///		fkAdmAppTransReqEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByEdCodeLevelReqId(System.Decimal? _edCodeLevelReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelReqId(null, _edCodeLevelReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL key.
		///		fkAdmAppTransReqEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelReqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByEdCodeLevelReqId(System.Decimal? _edCodeLevelReqId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelReqId(null, _edCodeLevelReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL key.
		///		FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public abstract TList<AdmAppTransReq> GetByEdCodeLevelReqId(TransactionManager transactionManager, System.Decimal? _edCodeLevelReqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL1 key.
		///		FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL1 Description: 
		/// </summary>
		/// <param name="_edCodeLevelAppId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByEdCodeLevelAppId(System.Decimal? _edCodeLevelAppId)
		{
			int count = -1;
			return GetByEdCodeLevelAppId(_edCodeLevelAppId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL1 key.
		///		FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelAppId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppTransReq> GetByEdCodeLevelAppId(TransactionManager transactionManager, System.Decimal? _edCodeLevelAppId)
		{
			int count = -1;
			return GetByEdCodeLevelAppId(transactionManager, _edCodeLevelAppId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL1 key.
		///		FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelAppId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByEdCodeLevelAppId(TransactionManager transactionManager, System.Decimal? _edCodeLevelAppId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelAppId(transactionManager, _edCodeLevelAppId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL1 key.
		///		fkAdmAppTransReqEdCodeLevel1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelAppId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByEdCodeLevelAppId(System.Decimal? _edCodeLevelAppId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelAppId(null, _edCodeLevelAppId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL1 key.
		///		fkAdmAppTransReqEdCodeLevel1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelAppId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByEdCodeLevelAppId(System.Decimal? _edCodeLevelAppId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelAppId(null, _edCodeLevelAppId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL1 key.
		///		FK_ADM_APP_TRANS_REQ_ED_CODE_LEVEL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelAppId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public abstract TList<AdmAppTransReq> GetByEdCodeLevelAppId(TransactionManager transactionManager, System.Decimal? _edCodeLevelAppId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_TRANS_REQ_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">الدولة المحول منها</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_TRANS_REQ_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الدولة المحول منها</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppTransReq> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_TRANS_REQ_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الدولة المحول منها</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_GS_COUNTRY_NODE key.
		///		fkAdmAppTransReqGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">الدولة المحول منها</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_GS_COUNTRY_NODE key.
		///		fkAdmAppTransReqGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">الدولة المحول منها</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public TList<AdmAppTransReq> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_TRANS_REQ_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_TRANS_REQ_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الدولة المحول منها</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppTransReq objects.</returns>
		public abstract TList<AdmAppTransReq> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppTransReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransReqKey key, int start, int pageLength)
		{
			return GetByAdmAppTransReqId(transactionManager, key.AdmAppTransReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public TList<AdmAppTransReq> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(null,_entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public TList<AdmAppTransReq> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public TList<AdmAppTransReq> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public TList<AdmAppTransReq> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public TList<AdmAppTransReq> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public abstract TList<AdmAppTransReq> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public TList<AdmAppTransReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null,_gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public TList<AdmAppTransReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public TList<AdmAppTransReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public TList<AdmAppTransReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public TList<AdmAppTransReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransReq&gt;"/> class.</returns>
		public abstract TList<AdmAppTransReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_TRANSFER index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransReq GetByAdmAppTransReqId(System.Decimal _admAppTransReqId)
		{
			int count = -1;
			return GetByAdmAppTransReqId(null,_admAppTransReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANSFER index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransReq GetByAdmAppTransReqId(System.Decimal _admAppTransReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqId(null, _admAppTransReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANSFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransReq GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId)
		{
			int count = -1;
			return GetByAdmAppTransReqId(transactionManager, _admAppTransReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANSFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransReq GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqId(transactionManager, _admAppTransReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANSFER index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransReq GetByAdmAppTransReqId(System.Decimal _admAppTransReqId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTransReqId(null, _admAppTransReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANSFER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppTransReq GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppTransReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppTransReq&gt;"/></returns>
		public static TList<AdmAppTransReq> Fill(IDataReader reader, TList<AdmAppTransReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppTransReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppTransReq")
					.Append("|").Append((System.Decimal)reader["ADM_APP_TRANS_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppTransReq>(
					key.ToString(), // EntityTrackingKey
					"AdmAppTransReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppTransReq();
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
					c.AdmAppTransReqId = (System.Decimal)reader["ADM_APP_TRANS_REQ_ID"];
					c.OriginalAdmAppTransReqId = c.AdmAppTransReqId;
					c.AdmAppRegHistoryId = (System.Decimal)reader["ADM_APP_REG_HISTORY_ID"];
					c.UnivName = Convert.IsDBNull(reader["UNIV_NAME"]) ? null : (System.String)reader["UNIV_NAME"];
					c.FacName = Convert.IsDBNull(reader["FAC_NAME"]) ? null : (System.String)reader["FAC_NAME"];
					c.PrvSemesterNo = Convert.IsDBNull(reader["PRV_SEMESTER_NO"]) ? null : (System.Decimal?)reader["PRV_SEMESTER_NO"];
					c.PrvChNo = Convert.IsDBNull(reader["PRV_CH_NO"]) ? null : (System.Decimal?)reader["PRV_CH_NO"];
					c.PrvCgpa = Convert.IsDBNull(reader["PRV_CGPA"]) ? null : (System.Decimal?)reader["PRV_CGPA"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.TransferReason = Convert.IsDBNull(reader["TRANSFER_REASON"]) ? null : (System.String)reader["TRANSFER_REASON"];
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.ReqStatusDate = Convert.IsDBNull(reader["REQ_STATUS_DATE"]) ? null : (System.DateTime?)reader["REQ_STATUS_DATE"];
					c.IsApplied = (System.Decimal)reader["IS_APPLIED"];
					c.AdmCodeTransferTypeId = Convert.IsDBNull(reader["ADM_CODE_TRANSFER_TYPE_ID"]) ? null : (System.Decimal?)reader["ADM_CODE_TRANSFER_TYPE_ID"];
					c.EdCodeLevelReqId = Convert.IsDBNull(reader["ED_CODE_LEVEL_REQ_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_REQ_ID"];
					c.EdCodeLevelAppId = Convert.IsDBNull(reader["ED_CODE_LEVEL_APP_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_APP_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.MajorName = Convert.IsDBNull(reader["MAJOR_NAME"]) ? null : (System.String)reader["MAJOR_NAME"];
					c.LastYear = Convert.IsDBNull(reader["LAST_YEAR"]) ? null : (System.String)reader["LAST_YEAR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppTransReq entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppTransReqId = (System.Decimal)reader[((int)AdmAppTransReqColumn.AdmAppTransReqId - 1)];
			entity.OriginalAdmAppTransReqId = (System.Decimal)reader["ADM_APP_TRANS_REQ_ID"];
			entity.AdmAppRegHistoryId = (System.Decimal)reader[((int)AdmAppTransReqColumn.AdmAppRegHistoryId - 1)];
			entity.UnivName = (reader.IsDBNull(((int)AdmAppTransReqColumn.UnivName - 1)))?null:(System.String)reader[((int)AdmAppTransReqColumn.UnivName - 1)];
			entity.FacName = (reader.IsDBNull(((int)AdmAppTransReqColumn.FacName - 1)))?null:(System.String)reader[((int)AdmAppTransReqColumn.FacName - 1)];
			entity.PrvSemesterNo = (reader.IsDBNull(((int)AdmAppTransReqColumn.PrvSemesterNo - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransReqColumn.PrvSemesterNo - 1)];
			entity.PrvChNo = (reader.IsDBNull(((int)AdmAppTransReqColumn.PrvChNo - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransReqColumn.PrvChNo - 1)];
			entity.PrvCgpa = (reader.IsDBNull(((int)AdmAppTransReqColumn.PrvCgpa - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransReqColumn.PrvCgpa - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)AdmAppTransReqColumn.EntMainId - 1)];
			entity.TransferReason = (reader.IsDBNull(((int)AdmAppTransReqColumn.TransferReason - 1)))?null:(System.String)reader[((int)AdmAppTransReqColumn.TransferReason - 1)];
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)AdmAppTransReqColumn.GsCodeReqStatusId - 1)];
			entity.ReqStatusDate = (reader.IsDBNull(((int)AdmAppTransReqColumn.ReqStatusDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppTransReqColumn.ReqStatusDate - 1)];
			entity.IsApplied = (System.Decimal)reader[((int)AdmAppTransReqColumn.IsApplied - 1)];
			entity.AdmCodeTransferTypeId = (reader.IsDBNull(((int)AdmAppTransReqColumn.AdmCodeTransferTypeId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransReqColumn.AdmCodeTransferTypeId - 1)];
			entity.EdCodeLevelReqId = (reader.IsDBNull(((int)AdmAppTransReqColumn.EdCodeLevelReqId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransReqColumn.EdCodeLevelReqId - 1)];
			entity.EdCodeLevelAppId = (reader.IsDBNull(((int)AdmAppTransReqColumn.EdCodeLevelAppId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransReqColumn.EdCodeLevelAppId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)AdmAppTransReqColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransReqColumn.AsFacultyInfoId - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)AdmAppTransReqColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)AdmAppTransReqColumn.GsCountryNodeId - 1)];
			entity.MajorName = (reader.IsDBNull(((int)AdmAppTransReqColumn.MajorName - 1)))?null:(System.String)reader[((int)AdmAppTransReqColumn.MajorName - 1)];
			entity.LastYear = (reader.IsDBNull(((int)AdmAppTransReqColumn.LastYear - 1)))?null:(System.String)reader[((int)AdmAppTransReqColumn.LastYear - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppTransReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppTransReqId = (System.Decimal)dataRow["ADM_APP_TRANS_REQ_ID"];
			entity.OriginalAdmAppTransReqId = (System.Decimal)dataRow["ADM_APP_TRANS_REQ_ID"];
			entity.AdmAppRegHistoryId = (System.Decimal)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.UnivName = Convert.IsDBNull(dataRow["UNIV_NAME"]) ? null : (System.String)dataRow["UNIV_NAME"];
			entity.FacName = Convert.IsDBNull(dataRow["FAC_NAME"]) ? null : (System.String)dataRow["FAC_NAME"];
			entity.PrvSemesterNo = Convert.IsDBNull(dataRow["PRV_SEMESTER_NO"]) ? null : (System.Decimal?)dataRow["PRV_SEMESTER_NO"];
			entity.PrvChNo = Convert.IsDBNull(dataRow["PRV_CH_NO"]) ? null : (System.Decimal?)dataRow["PRV_CH_NO"];
			entity.PrvCgpa = Convert.IsDBNull(dataRow["PRV_CGPA"]) ? null : (System.Decimal?)dataRow["PRV_CGPA"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.TransferReason = Convert.IsDBNull(dataRow["TRANSFER_REASON"]) ? null : (System.String)dataRow["TRANSFER_REASON"];
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.ReqStatusDate = Convert.IsDBNull(dataRow["REQ_STATUS_DATE"]) ? null : (System.DateTime?)dataRow["REQ_STATUS_DATE"];
			entity.IsApplied = (System.Decimal)dataRow["IS_APPLIED"];
			entity.AdmCodeTransferTypeId = Convert.IsDBNull(dataRow["ADM_CODE_TRANSFER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CODE_TRANSFER_TYPE_ID"];
			entity.EdCodeLevelReqId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_REQ_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_REQ_ID"];
			entity.EdCodeLevelAppId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_APP_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_APP_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.MajorName = Convert.IsDBNull(dataRow["MAJOR_NAME"]) ? null : (System.String)dataRow["MAJOR_NAME"];
			entity.LastYear = Convert.IsDBNull(dataRow["LAST_YEAR"]) ? null : (System.String)dataRow["LAST_YEAR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppTransReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppRegHistoryId;
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppRegHistoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppRegHistoryProvider.DeepLoad(transactionManager, entity.AdmAppRegHistoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppRegHistoryIdSource

			#region AdmCodeTransferTypeIdSource	
			if (CanDeepLoad(entity, "AdmCodeTransferType|AdmCodeTransferTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmCodeTransferTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCodeTransferTypeId ?? 0.0m);
				AdmCodeTransferType tmpEntity = EntityManager.LocateEntity<AdmCodeTransferType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCodeTransferType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCodeTransferTypeIdSource = tmpEntity;
				else
					entity.AdmCodeTransferTypeIdSource = DataRepository.AdmCodeTransferTypeProvider.GetByAdmCodeTransferTypeId(transactionManager, (entity.AdmCodeTransferTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeTransferTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCodeTransferTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCodeTransferTypeProvider.DeepLoad(transactionManager, entity.AdmCodeTransferTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCodeTransferTypeIdSource

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

			#region EdCodeLevelReqIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelReqIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLevelReqId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelReqIdSource = tmpEntity;
				else
					entity.EdCodeLevelReqIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelReqId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelReqIdSource

			#region EdCodeLevelAppIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelAppIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelAppIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLevelAppId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelAppIdSource = tmpEntity;
				else
					entity.EdCodeLevelAppIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelAppId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelAppIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelAppIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelAppIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelAppIdSource

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

			#region GsCodeReqStatusIdSource	
			if (CanDeepLoad(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReqStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeReqStatusId;
				GsCodeReqStatus tmpEntity = EntityManager.LocateEntity<GsCodeReqStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReqStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReqStatusIdSource = tmpEntity;
				else
					entity.GsCodeReqStatusIdSource = DataRepository.GsCodeReqStatusProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeReqStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeReqStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeReqStatusProvider.DeepLoad(transactionManager, entity.GsCodeReqStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeReqStatusIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmAppTransReqId methods when available
			
			#region AdmAppTransBalanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransBalance>|AdmAppTransBalanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransBalanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransBalanceCollection = DataRepository.AdmAppTransBalanceProvider.GetByAdmAppTransReqId(transactionManager, entity.AdmAppTransReqId);

				if (deep && entity.AdmAppTransBalanceCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransBalance>) DataRepository.AdmAppTransBalanceProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransBalanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransToCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransToCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransToCourseCollection = DataRepository.AdmAppTransToCourseProvider.GetByAdmAppTransReqId(transactionManager, entity.AdmAppTransReqId);

				if (deep && entity.AdmAppTransToCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransToCourse>) DataRepository.AdmAppTransToCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTransferAcceptanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTransferAcceptance>|AdmTransferAcceptanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTransferAcceptanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTransferAcceptanceCollection = DataRepository.AdmTransferAcceptanceProvider.GetByAdmAppTransReqId(transactionManager, entity.AdmAppTransReqId);

				if (deep && entity.AdmTransferAcceptanceCollection.Count > 0)
				{
					deepHandles.Add("AdmTransferAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTransferAcceptance>) DataRepository.AdmTransferAcceptanceProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTransferAcceptanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransFromCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransFromCourse>|AdmAppTransFromCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransFromCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransFromCourseCollection = DataRepository.AdmAppTransFromCourseProvider.GetByAdmAppTransReqId(transactionManager, entity.AdmAppTransReqId);

				if (deep && entity.AdmAppTransFromCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransFromCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransFromCourse>) DataRepository.AdmAppTransFromCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransFromCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppTransReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppTransReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppTransReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppRegHistoryIdSource
			if (CanDeepSave(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepSaveType, innerList) 
				&& entity.AdmAppRegHistoryIdSource != null)
			{
				DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryIdSource);
				entity.AdmAppRegHistoryId = entity.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
			}
			#endregion 
			
			#region AdmCodeTransferTypeIdSource
			if (CanDeepSave(entity, "AdmCodeTransferType|AdmCodeTransferTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCodeTransferTypeIdSource != null)
			{
				DataRepository.AdmCodeTransferTypeProvider.Save(transactionManager, entity.AdmCodeTransferTypeIdSource);
				entity.AdmCodeTransferTypeId = entity.AdmCodeTransferTypeIdSource.AdmCodeTransferTypeId;
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
			
			#region EdCodeLevelReqIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelReqIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelReqIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelReqIdSource);
				entity.EdCodeLevelReqId = entity.EdCodeLevelReqIdSource.EdCodeLevelId;
			}
			#endregion 
			
			#region EdCodeLevelAppIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelAppIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelAppIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelAppIdSource);
				entity.EdCodeLevelAppId = entity.EdCodeLevelAppIdSource.EdCodeLevelId;
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			
			#region GsCodeReqStatusIdSource
			if (CanDeepSave(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReqStatusIdSource != null)
			{
				DataRepository.GsCodeReqStatusProvider.Save(transactionManager, entity.GsCodeReqStatusIdSource);
				entity.GsCodeReqStatusId = entity.GsCodeReqStatusIdSource.GsCodeReqStatusId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppTransBalance>
				if (CanDeepSave(entity.AdmAppTransBalanceCollection, "List<AdmAppTransBalance>|AdmAppTransBalanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransBalance child in entity.AdmAppTransBalanceCollection)
					{
						if(child.AdmAppTransReqIdSource != null)
						{
							child.AdmAppTransReqId = child.AdmAppTransReqIdSource.AdmAppTransReqId;
						}
						else
						{
							child.AdmAppTransReqId = entity.AdmAppTransReqId;
						}

					}

					if (entity.AdmAppTransBalanceCollection.Count > 0 || entity.AdmAppTransBalanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransBalanceProvider.Save(transactionManager, entity.AdmAppTransBalanceCollection);
						
						deepHandles.Add("AdmAppTransBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransBalance >) DataRepository.AdmAppTransBalanceProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransBalanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppTransToCourse>
				if (CanDeepSave(entity.AdmAppTransToCourseCollection, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransToCourse child in entity.AdmAppTransToCourseCollection)
					{
						if(child.AdmAppTransReqIdSource != null)
						{
							child.AdmAppTransReqId = child.AdmAppTransReqIdSource.AdmAppTransReqId;
						}
						else
						{
							child.AdmAppTransReqId = entity.AdmAppTransReqId;
						}

					}

					if (entity.AdmAppTransToCourseCollection.Count > 0 || entity.AdmAppTransToCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransToCourseProvider.Save(transactionManager, entity.AdmAppTransToCourseCollection);
						
						deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransToCourse >) DataRepository.AdmAppTransToCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTransferAcceptance>
				if (CanDeepSave(entity.AdmTransferAcceptanceCollection, "List<AdmTransferAcceptance>|AdmTransferAcceptanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTransferAcceptance child in entity.AdmTransferAcceptanceCollection)
					{
						if(child.AdmAppTransReqIdSource != null)
						{
							child.AdmAppTransReqId = child.AdmAppTransReqIdSource.AdmAppTransReqId;
						}
						else
						{
							child.AdmAppTransReqId = entity.AdmAppTransReqId;
						}

					}

					if (entity.AdmTransferAcceptanceCollection.Count > 0 || entity.AdmTransferAcceptanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTransferAcceptanceProvider.Save(transactionManager, entity.AdmTransferAcceptanceCollection);
						
						deepHandles.Add("AdmTransferAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTransferAcceptance >) DataRepository.AdmTransferAcceptanceProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTransferAcceptanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppTransFromCourse>
				if (CanDeepSave(entity.AdmAppTransFromCourseCollection, "List<AdmAppTransFromCourse>|AdmAppTransFromCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransFromCourse child in entity.AdmAppTransFromCourseCollection)
					{
						if(child.AdmAppTransReqIdSource != null)
						{
							child.AdmAppTransReqId = child.AdmAppTransReqIdSource.AdmAppTransReqId;
						}
						else
						{
							child.AdmAppTransReqId = entity.AdmAppTransReqId;
						}

					}

					if (entity.AdmAppTransFromCourseCollection.Count > 0 || entity.AdmAppTransFromCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransFromCourseProvider.Save(transactionManager, entity.AdmAppTransFromCourseCollection);
						
						deepHandles.Add("AdmAppTransFromCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransFromCourse >) DataRepository.AdmAppTransFromCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransFromCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmAppTransReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppTransReq</c>
	///</summary>
	public enum AdmAppTransReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AdmCodeTransferType</c> at AdmCodeTransferTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCodeTransferType))]
		AdmCodeTransferType,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelReqIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
		///<summary>
		/// Collection of <c>AdmAppTransReq</c> as OneToMany for AdmAppTransBalanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransBalance>))]
		AdmAppTransBalanceCollection,
		///<summary>
		/// Collection of <c>AdmAppTransReq</c> as OneToMany for AdmAppTransToCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransToCourse>))]
		AdmAppTransToCourseCollection,
		///<summary>
		/// Collection of <c>AdmAppTransReq</c> as OneToMany for AdmTransferAcceptanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTransferAcceptance>))]
		AdmTransferAcceptanceCollection,
		///<summary>
		/// Collection of <c>AdmAppTransReq</c> as OneToMany for AdmAppTransFromCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransFromCourse>))]
		AdmAppTransFromCourseCollection,
	}
	
	#endregion AdmAppTransReqChildEntityTypes
	
	#region AdmAppTransReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppTransReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppTransReqFilterBuilder : SqlFilterBuilder<AdmAppTransReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransReqFilterBuilder class.
		/// </summary>
		public AdmAppTransReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppTransReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppTransReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppTransReqFilterBuilder
	
	#region AdmAppTransReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppTransReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppTransReqParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppTransReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransReqParameterBuilder class.
		/// </summary>
		public AdmAppTransReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppTransReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppTransReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppTransReqParameterBuilder
	
	#region AdmAppTransReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppTransReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppTransReqSortBuilder : SqlSortBuilder<AdmAppTransReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransReqSqlSortBuilder class.
		/// </summary>
		public AdmAppTransReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppTransReqSortBuilder
	
} // end namespace
