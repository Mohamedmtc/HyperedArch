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
	/// This class is the base class for any <see cref="AdmInboxProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmInboxProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmInbox, UMIS_VER2.BusinessLyer.AdmInboxKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmInboxKey key)
		{
			return Delete(transactionManager, key.AdmInboxId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admInboxId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admInboxId)
		{
			return Delete(null, _admInboxId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admInboxId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admInboxId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APP_MESSAGE key.
		///		FK_ADM_INBOX_ADM_APP_MESSAGE Description: 
		/// </summary>
		/// <param name="_admAppMessageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByAdmAppMessageId(System.Decimal _admAppMessageId)
		{
			int count = -1;
			return GetByAdmAppMessageId(_admAppMessageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APP_MESSAGE key.
		///		FK_ADM_INBOX_ADM_APP_MESSAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMessageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		/// <remarks></remarks>
		public TList<AdmInbox> GetByAdmAppMessageId(TransactionManager transactionManager, System.Decimal _admAppMessageId)
		{
			int count = -1;
			return GetByAdmAppMessageId(transactionManager, _admAppMessageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APP_MESSAGE key.
		///		FK_ADM_INBOX_ADM_APP_MESSAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByAdmAppMessageId(TransactionManager transactionManager, System.Decimal _admAppMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppMessageId(transactionManager, _admAppMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APP_MESSAGE key.
		///		fkAdmInboxAdmAppMessage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppMessageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByAdmAppMessageId(System.Decimal _admAppMessageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppMessageId(null, _admAppMessageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APP_MESSAGE key.
		///		fkAdmInboxAdmAppMessage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppMessageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByAdmAppMessageId(System.Decimal _admAppMessageId, int start, int pageLength,out int count)
		{
			return GetByAdmAppMessageId(null, _admAppMessageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APP_MESSAGE key.
		///		FK_ADM_INBOX_ADM_APP_MESSAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public abstract TList<AdmInbox> GetByAdmAppMessageId(TransactionManager transactionManager, System.Decimal _admAppMessageId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT2 key.
		///		FK_ADM_INBOX_ADM_APPLICANT2 Description: 
		/// </summary>
		/// <param name="_inMsgAppFrom"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgAppFrom(System.Decimal? _inMsgAppFrom)
		{
			int count = -1;
			return GetByInMsgAppFrom(_inMsgAppFrom, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT2 key.
		///		FK_ADM_INBOX_ADM_APPLICANT2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgAppFrom"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		/// <remarks></remarks>
		public TList<AdmInbox> GetByInMsgAppFrom(TransactionManager transactionManager, System.Decimal? _inMsgAppFrom)
		{
			int count = -1;
			return GetByInMsgAppFrom(transactionManager, _inMsgAppFrom, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT2 key.
		///		FK_ADM_INBOX_ADM_APPLICANT2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgAppFrom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgAppFrom(TransactionManager transactionManager, System.Decimal? _inMsgAppFrom, int start, int pageLength)
		{
			int count = -1;
			return GetByInMsgAppFrom(transactionManager, _inMsgAppFrom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT2 key.
		///		fkAdmInboxAdmApplicant2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_inMsgAppFrom"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgAppFrom(System.Decimal? _inMsgAppFrom, int start, int pageLength)
		{
			int count =  -1;
			return GetByInMsgAppFrom(null, _inMsgAppFrom, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT2 key.
		///		fkAdmInboxAdmApplicant2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_inMsgAppFrom"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgAppFrom(System.Decimal? _inMsgAppFrom, int start, int pageLength,out int count)
		{
			return GetByInMsgAppFrom(null, _inMsgAppFrom, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT2 key.
		///		FK_ADM_INBOX_ADM_APPLICANT2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgAppFrom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public abstract TList<AdmInbox> GetByInMsgAppFrom(TransactionManager transactionManager, System.Decimal? _inMsgAppFrom, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT3 key.
		///		FK_ADM_INBOX_ADM_APPLICANT3 Description: 
		/// </summary>
		/// <param name="_inMsgAppTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgAppTo(System.Decimal? _inMsgAppTo)
		{
			int count = -1;
			return GetByInMsgAppTo(_inMsgAppTo, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT3 key.
		///		FK_ADM_INBOX_ADM_APPLICANT3 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgAppTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		/// <remarks></remarks>
		public TList<AdmInbox> GetByInMsgAppTo(TransactionManager transactionManager, System.Decimal? _inMsgAppTo)
		{
			int count = -1;
			return GetByInMsgAppTo(transactionManager, _inMsgAppTo, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT3 key.
		///		FK_ADM_INBOX_ADM_APPLICANT3 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgAppTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgAppTo(TransactionManager transactionManager, System.Decimal? _inMsgAppTo, int start, int pageLength)
		{
			int count = -1;
			return GetByInMsgAppTo(transactionManager, _inMsgAppTo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT3 key.
		///		fkAdmInboxAdmApplicant3 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_inMsgAppTo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgAppTo(System.Decimal? _inMsgAppTo, int start, int pageLength)
		{
			int count =  -1;
			return GetByInMsgAppTo(null, _inMsgAppTo, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT3 key.
		///		fkAdmInboxAdmApplicant3 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_inMsgAppTo"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgAppTo(System.Decimal? _inMsgAppTo, int start, int pageLength,out int count)
		{
			return GetByInMsgAppTo(null, _inMsgAppTo, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_ADM_APPLICANT3 key.
		///		FK_ADM_INBOX_ADM_APPLICANT3 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgAppTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public abstract TList<AdmInbox> GetByInMsgAppTo(TransactionManager transactionManager, System.Decimal? _inMsgAppTo, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER key.
		///		FK_ADM_INBOX_SE_USER Description: 
		/// </summary>
		/// <param name="_inMsgUserFrom"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgUserFrom(System.Decimal? _inMsgUserFrom)
		{
			int count = -1;
			return GetByInMsgUserFrom(_inMsgUserFrom, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER key.
		///		FK_ADM_INBOX_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgUserFrom"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		/// <remarks></remarks>
		public TList<AdmInbox> GetByInMsgUserFrom(TransactionManager transactionManager, System.Decimal? _inMsgUserFrom)
		{
			int count = -1;
			return GetByInMsgUserFrom(transactionManager, _inMsgUserFrom, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER key.
		///		FK_ADM_INBOX_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgUserFrom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgUserFrom(TransactionManager transactionManager, System.Decimal? _inMsgUserFrom, int start, int pageLength)
		{
			int count = -1;
			return GetByInMsgUserFrom(transactionManager, _inMsgUserFrom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER key.
		///		fkAdmInboxSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_inMsgUserFrom"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgUserFrom(System.Decimal? _inMsgUserFrom, int start, int pageLength)
		{
			int count =  -1;
			return GetByInMsgUserFrom(null, _inMsgUserFrom, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER key.
		///		fkAdmInboxSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_inMsgUserFrom"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgUserFrom(System.Decimal? _inMsgUserFrom, int start, int pageLength,out int count)
		{
			return GetByInMsgUserFrom(null, _inMsgUserFrom, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER key.
		///		FK_ADM_INBOX_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgUserFrom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public abstract TList<AdmInbox> GetByInMsgUserFrom(TransactionManager transactionManager, System.Decimal? _inMsgUserFrom, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER1 key.
		///		FK_ADM_INBOX_SE_USER1 Description: 
		/// </summary>
		/// <param name="_inMsgUserTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgUserTo(System.Decimal? _inMsgUserTo)
		{
			int count = -1;
			return GetByInMsgUserTo(_inMsgUserTo, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER1 key.
		///		FK_ADM_INBOX_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgUserTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		/// <remarks></remarks>
		public TList<AdmInbox> GetByInMsgUserTo(TransactionManager transactionManager, System.Decimal? _inMsgUserTo)
		{
			int count = -1;
			return GetByInMsgUserTo(transactionManager, _inMsgUserTo, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER1 key.
		///		FK_ADM_INBOX_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgUserTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgUserTo(TransactionManager transactionManager, System.Decimal? _inMsgUserTo, int start, int pageLength)
		{
			int count = -1;
			return GetByInMsgUserTo(transactionManager, _inMsgUserTo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER1 key.
		///		fkAdmInboxSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_inMsgUserTo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgUserTo(System.Decimal? _inMsgUserTo, int start, int pageLength)
		{
			int count =  -1;
			return GetByInMsgUserTo(null, _inMsgUserTo, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER1 key.
		///		fkAdmInboxSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_inMsgUserTo"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public TList<AdmInbox> GetByInMsgUserTo(System.Decimal? _inMsgUserTo, int start, int pageLength,out int count)
		{
			return GetByInMsgUserTo(null, _inMsgUserTo, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INBOX_SE_USER1 key.
		///		FK_ADM_INBOX_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_inMsgUserTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmInbox objects.</returns>
		public abstract TList<AdmInbox> GetByInMsgUserTo(TransactionManager transactionManager, System.Decimal? _inMsgUserTo, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmInbox Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmInboxKey key, int start, int pageLength)
		{
			return GetByAdmInboxId(transactionManager, key.AdmInboxId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_INBOX index.
		/// </summary>
		/// <param name="_admInboxId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmInbox GetByAdmInboxId(System.Decimal _admInboxId)
		{
			int count = -1;
			return GetByAdmInboxId(null,_admInboxId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_INBOX index.
		/// </summary>
		/// <param name="_admInboxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmInbox GetByAdmInboxId(System.Decimal _admInboxId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmInboxId(null, _admInboxId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_INBOX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admInboxId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmInbox GetByAdmInboxId(TransactionManager transactionManager, System.Decimal _admInboxId)
		{
			int count = -1;
			return GetByAdmInboxId(transactionManager, _admInboxId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_INBOX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admInboxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmInbox GetByAdmInboxId(TransactionManager transactionManager, System.Decimal _admInboxId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmInboxId(transactionManager, _admInboxId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_INBOX index.
		/// </summary>
		/// <param name="_admInboxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmInbox GetByAdmInboxId(System.Decimal _admInboxId, int start, int pageLength, out int count)
		{
			return GetByAdmInboxId(null, _admInboxId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_INBOX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admInboxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmInbox GetByAdmInboxId(TransactionManager transactionManager, System.Decimal _admInboxId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmInbox&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmInbox&gt;"/></returns>
		public static TList<AdmInbox> Fill(IDataReader reader, TList<AdmInbox> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmInbox c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmInbox")
					.Append("|").Append((System.Decimal)reader["ADM_INBOX_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmInbox>(
					key.ToString(), // EntityTrackingKey
					"AdmInbox",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmInbox();
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
					c.AdmInboxId = (System.Decimal)reader["ADM_INBOX_ID"];
					c.OriginalAdmInboxId = c.AdmInboxId;
					c.AdmAppMessageId = (System.Decimal)reader["ADM_APP_MESSAGE_ID"];
					c.InMsgUserFrom = Convert.IsDBNull(reader["IN_MSG_USER_FROM"]) ? null : (System.Decimal?)reader["IN_MSG_USER_FROM"];
					c.InMsgUserTo = Convert.IsDBNull(reader["IN_MSG_USER_TO"]) ? null : (System.Decimal?)reader["IN_MSG_USER_TO"];
					c.DelFlg = Convert.IsDBNull(reader["DEL_FLG"]) ? null : (System.Decimal?)reader["DEL_FLG"];
					c.OpenedFlg = (System.Decimal)reader["OPENED_FLG"];
					c.InMsgAppFrom = Convert.IsDBNull(reader["IN_MSG_APP_FROM"]) ? null : (System.Decimal?)reader["IN_MSG_APP_FROM"];
					c.InMsgAppTo = Convert.IsDBNull(reader["IN_MSG_APP_TO"]) ? null : (System.Decimal?)reader["IN_MSG_APP_TO"];
					c.AnswerFlg = Convert.IsDBNull(reader["ANSWER_FLG"]) ? null : (System.Decimal?)reader["ANSWER_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmInbox entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmInboxId = (System.Decimal)reader[((int)AdmInboxColumn.AdmInboxId - 1)];
			entity.OriginalAdmInboxId = (System.Decimal)reader["ADM_INBOX_ID"];
			entity.AdmAppMessageId = (System.Decimal)reader[((int)AdmInboxColumn.AdmAppMessageId - 1)];
			entity.InMsgUserFrom = (reader.IsDBNull(((int)AdmInboxColumn.InMsgUserFrom - 1)))?null:(System.Decimal?)reader[((int)AdmInboxColumn.InMsgUserFrom - 1)];
			entity.InMsgUserTo = (reader.IsDBNull(((int)AdmInboxColumn.InMsgUserTo - 1)))?null:(System.Decimal?)reader[((int)AdmInboxColumn.InMsgUserTo - 1)];
			entity.DelFlg = (reader.IsDBNull(((int)AdmInboxColumn.DelFlg - 1)))?null:(System.Decimal?)reader[((int)AdmInboxColumn.DelFlg - 1)];
			entity.OpenedFlg = (System.Decimal)reader[((int)AdmInboxColumn.OpenedFlg - 1)];
			entity.InMsgAppFrom = (reader.IsDBNull(((int)AdmInboxColumn.InMsgAppFrom - 1)))?null:(System.Decimal?)reader[((int)AdmInboxColumn.InMsgAppFrom - 1)];
			entity.InMsgAppTo = (reader.IsDBNull(((int)AdmInboxColumn.InMsgAppTo - 1)))?null:(System.Decimal?)reader[((int)AdmInboxColumn.InMsgAppTo - 1)];
			entity.AnswerFlg = (reader.IsDBNull(((int)AdmInboxColumn.AnswerFlg - 1)))?null:(System.Decimal?)reader[((int)AdmInboxColumn.AnswerFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmInbox entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmInboxId = (System.Decimal)dataRow["ADM_INBOX_ID"];
			entity.OriginalAdmInboxId = (System.Decimal)dataRow["ADM_INBOX_ID"];
			entity.AdmAppMessageId = (System.Decimal)dataRow["ADM_APP_MESSAGE_ID"];
			entity.InMsgUserFrom = Convert.IsDBNull(dataRow["IN_MSG_USER_FROM"]) ? null : (System.Decimal?)dataRow["IN_MSG_USER_FROM"];
			entity.InMsgUserTo = Convert.IsDBNull(dataRow["IN_MSG_USER_TO"]) ? null : (System.Decimal?)dataRow["IN_MSG_USER_TO"];
			entity.DelFlg = Convert.IsDBNull(dataRow["DEL_FLG"]) ? null : (System.Decimal?)dataRow["DEL_FLG"];
			entity.OpenedFlg = (System.Decimal)dataRow["OPENED_FLG"];
			entity.InMsgAppFrom = Convert.IsDBNull(dataRow["IN_MSG_APP_FROM"]) ? null : (System.Decimal?)dataRow["IN_MSG_APP_FROM"];
			entity.InMsgAppTo = Convert.IsDBNull(dataRow["IN_MSG_APP_TO"]) ? null : (System.Decimal?)dataRow["IN_MSG_APP_TO"];
			entity.AnswerFlg = Convert.IsDBNull(dataRow["ANSWER_FLG"]) ? null : (System.Decimal?)dataRow["ANSWER_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmInbox"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmInbox Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmInbox entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppMessageIdSource	
			if (CanDeepLoad(entity, "AdmAppMessage|AdmAppMessageIdSource", deepLoadType, innerList) 
				&& entity.AdmAppMessageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppMessageId;
				AdmAppMessage tmpEntity = EntityManager.LocateEntity<AdmAppMessage>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppMessage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppMessageIdSource = tmpEntity;
				else
					entity.AdmAppMessageIdSource = DataRepository.AdmAppMessageProvider.GetByAdmAppMessageId(transactionManager, entity.AdmAppMessageId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppMessageIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppMessageIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppMessageProvider.DeepLoad(transactionManager, entity.AdmAppMessageIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppMessageIdSource

			#region InMsgAppFromSource	
			if (CanDeepLoad(entity, "AdmApplicant|InMsgAppFromSource", deepLoadType, innerList) 
				&& entity.InMsgAppFromSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.InMsgAppFrom ?? 0.0m);
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.InMsgAppFromSource = tmpEntity;
				else
					entity.InMsgAppFromSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, (entity.InMsgAppFrom ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'InMsgAppFromSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.InMsgAppFromSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmApplicantProvider.DeepLoad(transactionManager, entity.InMsgAppFromSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion InMsgAppFromSource

			#region InMsgAppToSource	
			if (CanDeepLoad(entity, "AdmApplicant|InMsgAppToSource", deepLoadType, innerList) 
				&& entity.InMsgAppToSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.InMsgAppTo ?? 0.0m);
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.InMsgAppToSource = tmpEntity;
				else
					entity.InMsgAppToSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, (entity.InMsgAppTo ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'InMsgAppToSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.InMsgAppToSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmApplicantProvider.DeepLoad(transactionManager, entity.InMsgAppToSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion InMsgAppToSource

			#region InMsgUserFromSource	
			if (CanDeepLoad(entity, "SeUser|InMsgUserFromSource", deepLoadType, innerList) 
				&& entity.InMsgUserFromSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.InMsgUserFrom ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.InMsgUserFromSource = tmpEntity;
				else
					entity.InMsgUserFromSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.InMsgUserFrom ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'InMsgUserFromSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.InMsgUserFromSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.InMsgUserFromSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion InMsgUserFromSource

			#region InMsgUserToSource	
			if (CanDeepLoad(entity, "SeUser|InMsgUserToSource", deepLoadType, innerList) 
				&& entity.InMsgUserToSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.InMsgUserTo ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.InMsgUserToSource = tmpEntity;
				else
					entity.InMsgUserToSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.InMsgUserTo ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'InMsgUserToSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.InMsgUserToSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.InMsgUserToSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion InMsgUserToSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmInbox object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmInbox instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmInbox Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmInbox entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppMessageIdSource
			if (CanDeepSave(entity, "AdmAppMessage|AdmAppMessageIdSource", deepSaveType, innerList) 
				&& entity.AdmAppMessageIdSource != null)
			{
				DataRepository.AdmAppMessageProvider.Save(transactionManager, entity.AdmAppMessageIdSource);
				entity.AdmAppMessageId = entity.AdmAppMessageIdSource.AdmAppMessageId;
			}
			#endregion 
			
			#region InMsgAppFromSource
			if (CanDeepSave(entity, "AdmApplicant|InMsgAppFromSource", deepSaveType, innerList) 
				&& entity.InMsgAppFromSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.InMsgAppFromSource);
				entity.InMsgAppFrom = entity.InMsgAppFromSource.AdmApplicantId;
			}
			#endregion 
			
			#region InMsgAppToSource
			if (CanDeepSave(entity, "AdmApplicant|InMsgAppToSource", deepSaveType, innerList) 
				&& entity.InMsgAppToSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.InMsgAppToSource);
				entity.InMsgAppTo = entity.InMsgAppToSource.AdmApplicantId;
			}
			#endregion 
			
			#region InMsgUserFromSource
			if (CanDeepSave(entity, "SeUser|InMsgUserFromSource", deepSaveType, innerList) 
				&& entity.InMsgUserFromSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.InMsgUserFromSource);
				entity.InMsgUserFrom = entity.InMsgUserFromSource.SeUserId;
			}
			#endregion 
			
			#region InMsgUserToSource
			if (CanDeepSave(entity, "SeUser|InMsgUserToSource", deepSaveType, innerList) 
				&& entity.InMsgUserToSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.InMsgUserToSource);
				entity.InMsgUserTo = entity.InMsgUserToSource.SeUserId;
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
	
	#region AdmInboxChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmInbox</c>
	///</summary>
	public enum AdmInboxChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppMessage</c> at AdmAppMessageIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppMessage))]
		AdmAppMessage,
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at InMsgAppFromSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at InMsgUserFromSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion AdmInboxChildEntityTypes
	
	#region AdmInboxFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmInboxColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmInbox"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmInboxFilterBuilder : SqlFilterBuilder<AdmInboxColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmInboxFilterBuilder class.
		/// </summary>
		public AdmInboxFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmInboxFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmInboxFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmInboxFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmInboxFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmInboxFilterBuilder
	
	#region AdmInboxParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmInboxColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmInbox"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmInboxParameterBuilder : ParameterizedSqlFilterBuilder<AdmInboxColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmInboxParameterBuilder class.
		/// </summary>
		public AdmInboxParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmInboxParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmInboxParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmInboxParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmInboxParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmInboxParameterBuilder
	
	#region AdmInboxSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmInboxColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmInbox"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmInboxSortBuilder : SqlSortBuilder<AdmInboxColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmInboxSqlSortBuilder class.
		/// </summary>
		public AdmInboxSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmInboxSortBuilder
	
} // end namespace
