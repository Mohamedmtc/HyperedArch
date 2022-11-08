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
	/// This class is the base class for any <see cref="AdmCdeAppStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeAppStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeAppStatus, UMIS_VER2.BusinessLyer.AdmCdeAppStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAppStatusKey key)
		{
			return Delete(transactionManager, key.AdmCdeAppStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeAppStatusId">حالة المتقدم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCdeAppStatusId)
		{
			return Delete(null, _admCdeAppStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppStatusId">حالة المتقدم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCdeAppStatusId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_FEE key.
		///		FK_ADM_CDE_APP_STATUS_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByAdmCdeFeeId(System.Decimal? _admCdeFeeId)
		{
			int count = -1;
			return GetByAdmCdeFeeId(_admCdeFeeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_FEE key.
		///		FK_ADM_CDE_APP_STATUS_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdeAppStatus> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal? _admCdeFeeId)
		{
			int count = -1;
			return GetByAdmCdeFeeId(transactionManager, _admCdeFeeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_FEE key.
		///		FK_ADM_CDE_APP_STATUS_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal? _admCdeFeeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeFeeId(transactionManager, _admCdeFeeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_FEE key.
		///		fkAdmCdeAppStatusAdmCdeFee Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByAdmCdeFeeId(System.Decimal? _admCdeFeeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeFeeId(null, _admCdeFeeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_FEE key.
		///		fkAdmCdeAppStatusAdmCdeFee Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByAdmCdeFeeId(System.Decimal? _admCdeFeeId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeFeeId(null, _admCdeFeeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_FEE key.
		///		FK_ADM_CDE_APP_STATUS_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId">لائحة بنود مصروفات القبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public abstract TList<AdmCdeAppStatus> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal? _admCdeFeeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_STATUS key.
		///		FK_ADM_CDE_APP_STATUS_ADM_CDE_STATUS Description: 
		/// </summary>
		/// <param name="_admCdeStatusPrereqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByAdmCdeStatusPrereqId(System.Decimal? _admCdeStatusPrereqId)
		{
			int count = -1;
			return GetByAdmCdeStatusPrereqId(_admCdeStatusPrereqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_STATUS key.
		///		FK_ADM_CDE_APP_STATUS_ADM_CDE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusPrereqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdeAppStatus> GetByAdmCdeStatusPrereqId(TransactionManager transactionManager, System.Decimal? _admCdeStatusPrereqId)
		{
			int count = -1;
			return GetByAdmCdeStatusPrereqId(transactionManager, _admCdeStatusPrereqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_STATUS key.
		///		FK_ADM_CDE_APP_STATUS_ADM_CDE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusPrereqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByAdmCdeStatusPrereqId(TransactionManager transactionManager, System.Decimal? _admCdeStatusPrereqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusPrereqId(transactionManager, _admCdeStatusPrereqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_STATUS key.
		///		fkAdmCdeAppStatusAdmCdeStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeStatusPrereqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByAdmCdeStatusPrereqId(System.Decimal? _admCdeStatusPrereqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeStatusPrereqId(null, _admCdeStatusPrereqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_STATUS key.
		///		fkAdmCdeAppStatusAdmCdeStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeStatusPrereqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByAdmCdeStatusPrereqId(System.Decimal? _admCdeStatusPrereqId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeStatusPrereqId(null, _admCdeStatusPrereqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ADM_CDE_STATUS key.
		///		FK_ADM_CDE_APP_STATUS_ADM_CDE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusPrereqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public abstract TList<AdmCdeAppStatus> GetByAdmCdeStatusPrereqId(TransactionManager transactionManager, System.Decimal? _admCdeStatusPrereqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ENTITY_MAIN key.
		///		FK_ADM_CDE_APP_STATUS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">الكليه-default =NULL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ENTITY_MAIN key.
		///		FK_ADM_CDE_APP_STATUS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الكليه-default =NULL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdeAppStatus> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ENTITY_MAIN key.
		///		FK_ADM_CDE_APP_STATUS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الكليه-default =NULL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ENTITY_MAIN key.
		///		fkAdmCdeAppStatusEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">الكليه-default =NULL</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ENTITY_MAIN key.
		///		fkAdmCdeAppStatusEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">الكليه-default =NULL</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_ENTITY_MAIN key.
		///		FK_ADM_CDE_APP_STATUS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">الكليه-default =NULL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public abstract TList<AdmCdeAppStatus> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_SV_AUTO_MSG_TMPLT key.
		///		FK_ADM_CDE_APP_STATUS_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetBySvAutoMsgTmpltId(System.Decimal? _svAutoMsgTmpltId)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(_svAutoMsgTmpltId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_SV_AUTO_MSG_TMPLT key.
		///		FK_ADM_CDE_APP_STATUS_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdeAppStatus> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal? _svAutoMsgTmpltId)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(transactionManager, _svAutoMsgTmpltId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_SV_AUTO_MSG_TMPLT key.
		///		FK_ADM_CDE_APP_STATUS_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal? _svAutoMsgTmpltId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(transactionManager, _svAutoMsgTmpltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_SV_AUTO_MSG_TMPLT key.
		///		fkAdmCdeAppStatusSvAutoMsgTmplt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetBySvAutoMsgTmpltId(System.Decimal? _svAutoMsgTmpltId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvAutoMsgTmpltId(null, _svAutoMsgTmpltId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_SV_AUTO_MSG_TMPLT key.
		///		fkAdmCdeAppStatusSvAutoMsgTmplt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public TList<AdmCdeAppStatus> GetBySvAutoMsgTmpltId(System.Decimal? _svAutoMsgTmpltId, int start, int pageLength,out int count)
		{
			return GetBySvAutoMsgTmpltId(null, _svAutoMsgTmpltId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_APP_STATUS_SV_AUTO_MSG_TMPLT key.
		///		FK_ADM_CDE_APP_STATUS_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeAppStatus objects.</returns>
		public abstract TList<AdmCdeAppStatus> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal? _svAutoMsgTmpltId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeAppStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAppStatusKey key, int start, int pageLength)
		{
			return GetByAdmCdeAppStatusId(transactionManager, key.AdmCdeAppStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_APP_STATUS index.
		/// </summary>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAppStatus GetByAdmCdeAppStatusId(System.Decimal _admCdeAppStatusId)
		{
			int count = -1;
			return GetByAdmCdeAppStatusId(null,_admCdeAppStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_APP_STATUS index.
		/// </summary>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAppStatus GetByAdmCdeAppStatusId(System.Decimal _admCdeAppStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppStatusId(null, _admCdeAppStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_APP_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAppStatus GetByAdmCdeAppStatusId(TransactionManager transactionManager, System.Decimal _admCdeAppStatusId)
		{
			int count = -1;
			return GetByAdmCdeAppStatusId(transactionManager, _admCdeAppStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_APP_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAppStatus GetByAdmCdeAppStatusId(TransactionManager transactionManager, System.Decimal _admCdeAppStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppStatusId(transactionManager, _admCdeAppStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_APP_STATUS index.
		/// </summary>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeAppStatus GetByAdmCdeAppStatusId(System.Decimal _admCdeAppStatusId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeAppStatusId(null, _admCdeAppStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_APP_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeAppStatus GetByAdmCdeAppStatusId(TransactionManager transactionManager, System.Decimal _admCdeAppStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeAppStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeAppStatus&gt;"/></returns>
		public static TList<AdmCdeAppStatus> Fill(IDataReader reader, TList<AdmCdeAppStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeAppStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeAppStatus")
					.Append("|").Append((System.Decimal)reader["ADM_CDE_APP_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeAppStatus>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeAppStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeAppStatus();
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
					c.AdmCdeAppStatusId = (System.Decimal)reader["ADM_CDE_APP_STATUS_ID"];
					c.OriginalAdmCdeAppStatusId = c.AdmCdeAppStatusId;
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.AppStatusAr = Convert.IsDBNull(reader["APP_STATUS_AR"]) ? null : (System.String)reader["APP_STATUS_AR"];
					c.AppStatusEn = Convert.IsDBNull(reader["APP_STATUS_EN"]) ? null : (System.String)reader["APP_STATUS_EN"];
					c.StatusOrder = Convert.IsDBNull(reader["STATUS_ORDER"]) ? null : (System.Int32?)reader["STATUS_ORDER"];
					c.SvAutoMsgTmpltId = Convert.IsDBNull(reader["SV_AUTO_MSG_TMPLT_ID"]) ? null : (System.Decimal?)reader["SV_AUTO_MSG_TMPLT_ID"];
					c.OrientFlg = Convert.IsDBNull(reader["ORIENT_FLG"]) ? null : (System.Int32?)reader["ORIENT_FLG"];
					c.IsLast = Convert.IsDBNull(reader["IS_LAST"]) ? null : (System.Boolean?)reader["IS_LAST"];
					c.AdmCdeStatusPrereqId = Convert.IsDBNull(reader["ADM_CDE_STATUS_PREREQ_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_STATUS_PREREQ_ID"];
					c.AdmCdeFeeId = Convert.IsDBNull(reader["ADM_CDE_FEE_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_FEE_ID"];
					c.EnumId = Convert.IsDBNull(reader["ENUM_ID"]) ? null : (System.Int32?)reader["ENUM_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeAppStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeAppStatusId = (System.Decimal)reader[((int)AdmCdeAppStatusColumn.AdmCdeAppStatusId - 1)];
			entity.OriginalAdmCdeAppStatusId = (System.Decimal)reader["ADM_CDE_APP_STATUS_ID"];
			entity.EntMainId = (reader.IsDBNull(((int)AdmCdeAppStatusColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)AdmCdeAppStatusColumn.EntMainId - 1)];
			entity.AppStatusAr = (reader.IsDBNull(((int)AdmCdeAppStatusColumn.AppStatusAr - 1)))?null:(System.String)reader[((int)AdmCdeAppStatusColumn.AppStatusAr - 1)];
			entity.AppStatusEn = (reader.IsDBNull(((int)AdmCdeAppStatusColumn.AppStatusEn - 1)))?null:(System.String)reader[((int)AdmCdeAppStatusColumn.AppStatusEn - 1)];
			entity.StatusOrder = (reader.IsDBNull(((int)AdmCdeAppStatusColumn.StatusOrder - 1)))?null:(System.Int32?)reader[((int)AdmCdeAppStatusColumn.StatusOrder - 1)];
			entity.SvAutoMsgTmpltId = (reader.IsDBNull(((int)AdmCdeAppStatusColumn.SvAutoMsgTmpltId - 1)))?null:(System.Decimal?)reader[((int)AdmCdeAppStatusColumn.SvAutoMsgTmpltId - 1)];
			entity.OrientFlg = (reader.IsDBNull(((int)AdmCdeAppStatusColumn.OrientFlg - 1)))?null:(System.Int32?)reader[((int)AdmCdeAppStatusColumn.OrientFlg - 1)];
			entity.IsLast = (reader.IsDBNull(((int)AdmCdeAppStatusColumn.IsLast - 1)))?null:(System.Boolean?)reader[((int)AdmCdeAppStatusColumn.IsLast - 1)];
			entity.AdmCdeStatusPrereqId = (reader.IsDBNull(((int)AdmCdeAppStatusColumn.AdmCdeStatusPrereqId - 1)))?null:(System.Decimal?)reader[((int)AdmCdeAppStatusColumn.AdmCdeStatusPrereqId - 1)];
			entity.AdmCdeFeeId = (reader.IsDBNull(((int)AdmCdeAppStatusColumn.AdmCdeFeeId - 1)))?null:(System.Decimal?)reader[((int)AdmCdeAppStatusColumn.AdmCdeFeeId - 1)];
			entity.EnumId = (reader.IsDBNull(((int)AdmCdeAppStatusColumn.EnumId - 1)))?null:(System.Int32?)reader[((int)AdmCdeAppStatusColumn.EnumId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeAppStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeAppStatusId = (System.Decimal)dataRow["ADM_CDE_APP_STATUS_ID"];
			entity.OriginalAdmCdeAppStatusId = (System.Decimal)dataRow["ADM_CDE_APP_STATUS_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.AppStatusAr = Convert.IsDBNull(dataRow["APP_STATUS_AR"]) ? null : (System.String)dataRow["APP_STATUS_AR"];
			entity.AppStatusEn = Convert.IsDBNull(dataRow["APP_STATUS_EN"]) ? null : (System.String)dataRow["APP_STATUS_EN"];
			entity.StatusOrder = Convert.IsDBNull(dataRow["STATUS_ORDER"]) ? null : (System.Int32?)dataRow["STATUS_ORDER"];
			entity.SvAutoMsgTmpltId = Convert.IsDBNull(dataRow["SV_AUTO_MSG_TMPLT_ID"]) ? null : (System.Decimal?)dataRow["SV_AUTO_MSG_TMPLT_ID"];
			entity.OrientFlg = Convert.IsDBNull(dataRow["ORIENT_FLG"]) ? null : (System.Int32?)dataRow["ORIENT_FLG"];
			entity.IsLast = Convert.IsDBNull(dataRow["IS_LAST"]) ? null : (System.Boolean?)dataRow["IS_LAST"];
			entity.AdmCdeStatusPrereqId = Convert.IsDBNull(dataRow["ADM_CDE_STATUS_PREREQ_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_STATUS_PREREQ_ID"];
			entity.AdmCdeFeeId = Convert.IsDBNull(dataRow["ADM_CDE_FEE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_FEE_ID"];
			entity.EnumId = Convert.IsDBNull(dataRow["ENUM_ID"]) ? null : (System.Int32?)dataRow["ENUM_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeAppStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeAppStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAppStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeFeeIdSource	
			if (CanDeepLoad(entity, "AdmCdeFee|AdmCdeFeeIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeFeeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeFeeId ?? 0.0m);
				AdmCdeFee tmpEntity = EntityManager.LocateEntity<AdmCdeFee>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeFee), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeFeeIdSource = tmpEntity;
				else
					entity.AdmCdeFeeIdSource = DataRepository.AdmCdeFeeProvider.GetByAdmCdeFeeId(transactionManager, (entity.AdmCdeFeeId ?? 0.0m));		
				
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

			#region AdmCdeStatusPrereqIdSource	
			if (CanDeepLoad(entity, "AdmCdeStatus|AdmCdeStatusPrereqIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeStatusPrereqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeStatusPrereqId ?? 0.0m);
				AdmCdeStatus tmpEntity = EntityManager.LocateEntity<AdmCdeStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeStatusPrereqIdSource = tmpEntity;
				else
					entity.AdmCdeStatusPrereqIdSource = DataRepository.AdmCdeStatusProvider.GetByAdmCdeStatusId(transactionManager, (entity.AdmCdeStatusPrereqId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeStatusPrereqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeStatusPrereqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeStatusProvider.DeepLoad(transactionManager, entity.AdmCdeStatusPrereqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeStatusPrereqIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainId ?? 0.0m));		
				
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

			#region SvAutoMsgTmpltIdSource	
			if (CanDeepLoad(entity, "SvAutoMsgTmplt|SvAutoMsgTmpltIdSource", deepLoadType, innerList) 
				&& entity.SvAutoMsgTmpltIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvAutoMsgTmpltId ?? 0.0m);
				SvAutoMsgTmplt tmpEntity = EntityManager.LocateEntity<SvAutoMsgTmplt>(EntityLocator.ConstructKeyFromPkItems(typeof(SvAutoMsgTmplt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvAutoMsgTmpltIdSource = tmpEntity;
				else
					entity.SvAutoMsgTmpltIdSource = DataRepository.SvAutoMsgTmpltProvider.GetBySvAutoMsgTmpltId(transactionManager, (entity.SvAutoMsgTmpltId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvAutoMsgTmpltIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvAutoMsgTmpltIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvAutoMsgTmpltProvider.DeepLoad(transactionManager, entity.SvAutoMsgTmpltIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvAutoMsgTmpltIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeAppStatusId methods when available
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByAdmCdeAppStatusId(transactionManager, entity.AdmCdeAppStatusId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeAppStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeAppStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeAppStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeAppStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeFeeIdSource
			if (CanDeepSave(entity, "AdmCdeFee|AdmCdeFeeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeFeeIdSource != null)
			{
				DataRepository.AdmCdeFeeProvider.Save(transactionManager, entity.AdmCdeFeeIdSource);
				entity.AdmCdeFeeId = entity.AdmCdeFeeIdSource.AdmCdeFeeId;
			}
			#endregion 
			
			#region AdmCdeStatusPrereqIdSource
			if (CanDeepSave(entity, "AdmCdeStatus|AdmCdeStatusPrereqIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeStatusPrereqIdSource != null)
			{
				DataRepository.AdmCdeStatusProvider.Save(transactionManager, entity.AdmCdeStatusPrereqIdSource);
				entity.AdmCdeStatusPrereqId = entity.AdmCdeStatusPrereqIdSource.AdmCdeStatusId;
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
			
			#region SvAutoMsgTmpltIdSource
			if (CanDeepSave(entity, "SvAutoMsgTmplt|SvAutoMsgTmpltIdSource", deepSaveType, innerList) 
				&& entity.SvAutoMsgTmpltIdSource != null)
			{
				DataRepository.SvAutoMsgTmpltProvider.Save(transactionManager, entity.SvAutoMsgTmpltIdSource);
				entity.SvAutoMsgTmpltId = entity.SvAutoMsgTmpltIdSource.SvAutoMsgTmpltId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.AdmCdeAppStatusIdSource != null)
						{
							child.AdmCdeAppStatusId = child.AdmCdeAppStatusIdSource.AdmCdeAppStatusId;
						}
						else
						{
							child.AdmCdeAppStatusId = entity.AdmCdeAppStatusId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeAppStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeAppStatus</c>
	///</summary>
	public enum AdmCdeAppStatusChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeFee</c> at AdmCdeFeeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeFee))]
		AdmCdeFee,
		
		///<summary>
		/// Composite Property for <c>AdmCdeStatus</c> at AdmCdeStatusPrereqIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeStatus))]
		AdmCdeStatus,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SvAutoMsgTmplt</c> at SvAutoMsgTmpltIdSource
		///</summary>
		[ChildEntityType(typeof(SvAutoMsgTmplt))]
		SvAutoMsgTmplt,
		///<summary>
		/// Collection of <c>AdmCdeAppStatus</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
	}
	
	#endregion AdmCdeAppStatusChildEntityTypes
	
	#region AdmCdeAppStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeAppStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeAppStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeAppStatusFilterBuilder : SqlFilterBuilder<AdmCdeAppStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppStatusFilterBuilder class.
		/// </summary>
		public AdmCdeAppStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeAppStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeAppStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeAppStatusFilterBuilder
	
	#region AdmCdeAppStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeAppStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeAppStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeAppStatusParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeAppStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppStatusParameterBuilder class.
		/// </summary>
		public AdmCdeAppStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeAppStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeAppStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeAppStatusParameterBuilder
	
	#region AdmCdeAppStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeAppStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeAppStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeAppStatusSortBuilder : SqlSortBuilder<AdmCdeAppStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeAppStatusSqlSortBuilder class.
		/// </summary>
		public AdmCdeAppStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeAppStatusSortBuilder
	
} // end namespace
