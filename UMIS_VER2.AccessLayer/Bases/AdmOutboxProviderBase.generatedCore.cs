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
	/// This class is the base class for any <see cref="AdmOutboxProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmOutboxProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmOutbox, UMIS_VER2.BusinessLyer.AdmOutboxKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmOutboxKey key)
		{
			return Delete(transactionManager, key.AdmOutboxId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admOutboxId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admOutboxId)
		{
			return Delete(null, _admOutboxId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOutboxId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admOutboxId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APP_MESSAGE key.
		///		FK_ADM_OUTBOX_ADM_APP_MESSAGE Description: 
		/// </summary>
		/// <param name="_admAppMessageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByAdmAppMessageId(System.Decimal _admAppMessageId)
		{
			int count = -1;
			return GetByAdmAppMessageId(_admAppMessageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APP_MESSAGE key.
		///		FK_ADM_OUTBOX_ADM_APP_MESSAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMessageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		/// <remarks></remarks>
		public TList<AdmOutbox> GetByAdmAppMessageId(TransactionManager transactionManager, System.Decimal _admAppMessageId)
		{
			int count = -1;
			return GetByAdmAppMessageId(transactionManager, _admAppMessageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APP_MESSAGE key.
		///		FK_ADM_OUTBOX_ADM_APP_MESSAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByAdmAppMessageId(TransactionManager transactionManager, System.Decimal _admAppMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppMessageId(transactionManager, _admAppMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APP_MESSAGE key.
		///		fkAdmOutboxAdmAppMessage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppMessageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByAdmAppMessageId(System.Decimal _admAppMessageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppMessageId(null, _admAppMessageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APP_MESSAGE key.
		///		fkAdmOutboxAdmAppMessage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppMessageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByAdmAppMessageId(System.Decimal _admAppMessageId, int start, int pageLength,out int count)
		{
			return GetByAdmAppMessageId(null, _admAppMessageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APP_MESSAGE key.
		///		FK_ADM_OUTBOX_ADM_APP_MESSAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public abstract TList<AdmOutbox> GetByAdmAppMessageId(TransactionManager transactionManager, System.Decimal _admAppMessageId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT2 key.
		///		FK_ADM_OUTBOX_ADM_APPLICANT2 Description: 
		/// </summary>
		/// <param name="_outMsgAppFrom"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgAppFrom(System.Decimal? _outMsgAppFrom)
		{
			int count = -1;
			return GetByOutMsgAppFrom(_outMsgAppFrom, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT2 key.
		///		FK_ADM_OUTBOX_ADM_APPLICANT2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgAppFrom"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		/// <remarks></remarks>
		public TList<AdmOutbox> GetByOutMsgAppFrom(TransactionManager transactionManager, System.Decimal? _outMsgAppFrom)
		{
			int count = -1;
			return GetByOutMsgAppFrom(transactionManager, _outMsgAppFrom, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT2 key.
		///		FK_ADM_OUTBOX_ADM_APPLICANT2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgAppFrom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgAppFrom(TransactionManager transactionManager, System.Decimal? _outMsgAppFrom, int start, int pageLength)
		{
			int count = -1;
			return GetByOutMsgAppFrom(transactionManager, _outMsgAppFrom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT2 key.
		///		fkAdmOutboxAdmApplicant2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_outMsgAppFrom"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgAppFrom(System.Decimal? _outMsgAppFrom, int start, int pageLength)
		{
			int count =  -1;
			return GetByOutMsgAppFrom(null, _outMsgAppFrom, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT2 key.
		///		fkAdmOutboxAdmApplicant2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_outMsgAppFrom"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgAppFrom(System.Decimal? _outMsgAppFrom, int start, int pageLength,out int count)
		{
			return GetByOutMsgAppFrom(null, _outMsgAppFrom, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT2 key.
		///		FK_ADM_OUTBOX_ADM_APPLICANT2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgAppFrom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public abstract TList<AdmOutbox> GetByOutMsgAppFrom(TransactionManager transactionManager, System.Decimal? _outMsgAppFrom, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT3 key.
		///		FK_ADM_OUTBOX_ADM_APPLICANT3 Description: 
		/// </summary>
		/// <param name="_outMsgAppTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgAppTo(System.Decimal? _outMsgAppTo)
		{
			int count = -1;
			return GetByOutMsgAppTo(_outMsgAppTo, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT3 key.
		///		FK_ADM_OUTBOX_ADM_APPLICANT3 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgAppTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		/// <remarks></remarks>
		public TList<AdmOutbox> GetByOutMsgAppTo(TransactionManager transactionManager, System.Decimal? _outMsgAppTo)
		{
			int count = -1;
			return GetByOutMsgAppTo(transactionManager, _outMsgAppTo, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT3 key.
		///		FK_ADM_OUTBOX_ADM_APPLICANT3 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgAppTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgAppTo(TransactionManager transactionManager, System.Decimal? _outMsgAppTo, int start, int pageLength)
		{
			int count = -1;
			return GetByOutMsgAppTo(transactionManager, _outMsgAppTo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT3 key.
		///		fkAdmOutboxAdmApplicant3 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_outMsgAppTo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgAppTo(System.Decimal? _outMsgAppTo, int start, int pageLength)
		{
			int count =  -1;
			return GetByOutMsgAppTo(null, _outMsgAppTo, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT3 key.
		///		fkAdmOutboxAdmApplicant3 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_outMsgAppTo"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgAppTo(System.Decimal? _outMsgAppTo, int start, int pageLength,out int count)
		{
			return GetByOutMsgAppTo(null, _outMsgAppTo, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_ADM_APPLICANT3 key.
		///		FK_ADM_OUTBOX_ADM_APPLICANT3 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgAppTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public abstract TList<AdmOutbox> GetByOutMsgAppTo(TransactionManager transactionManager, System.Decimal? _outMsgAppTo, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER key.
		///		FK_ADM_OUTBOX_SE_USER Description: 
		/// </summary>
		/// <param name="_outMsgUserFrom"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgUserFrom(System.Decimal? _outMsgUserFrom)
		{
			int count = -1;
			return GetByOutMsgUserFrom(_outMsgUserFrom, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER key.
		///		FK_ADM_OUTBOX_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgUserFrom"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		/// <remarks></remarks>
		public TList<AdmOutbox> GetByOutMsgUserFrom(TransactionManager transactionManager, System.Decimal? _outMsgUserFrom)
		{
			int count = -1;
			return GetByOutMsgUserFrom(transactionManager, _outMsgUserFrom, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER key.
		///		FK_ADM_OUTBOX_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgUserFrom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgUserFrom(TransactionManager transactionManager, System.Decimal? _outMsgUserFrom, int start, int pageLength)
		{
			int count = -1;
			return GetByOutMsgUserFrom(transactionManager, _outMsgUserFrom, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER key.
		///		fkAdmOutboxSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_outMsgUserFrom"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgUserFrom(System.Decimal? _outMsgUserFrom, int start, int pageLength)
		{
			int count =  -1;
			return GetByOutMsgUserFrom(null, _outMsgUserFrom, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER key.
		///		fkAdmOutboxSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_outMsgUserFrom"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgUserFrom(System.Decimal? _outMsgUserFrom, int start, int pageLength,out int count)
		{
			return GetByOutMsgUserFrom(null, _outMsgUserFrom, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER key.
		///		FK_ADM_OUTBOX_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgUserFrom"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public abstract TList<AdmOutbox> GetByOutMsgUserFrom(TransactionManager transactionManager, System.Decimal? _outMsgUserFrom, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER1 key.
		///		FK_ADM_OUTBOX_SE_USER1 Description: 
		/// </summary>
		/// <param name="_outMsgUserTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgUserTo(System.Decimal? _outMsgUserTo)
		{
			int count = -1;
			return GetByOutMsgUserTo(_outMsgUserTo, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER1 key.
		///		FK_ADM_OUTBOX_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgUserTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		/// <remarks></remarks>
		public TList<AdmOutbox> GetByOutMsgUserTo(TransactionManager transactionManager, System.Decimal? _outMsgUserTo)
		{
			int count = -1;
			return GetByOutMsgUserTo(transactionManager, _outMsgUserTo, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER1 key.
		///		FK_ADM_OUTBOX_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgUserTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgUserTo(TransactionManager transactionManager, System.Decimal? _outMsgUserTo, int start, int pageLength)
		{
			int count = -1;
			return GetByOutMsgUserTo(transactionManager, _outMsgUserTo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER1 key.
		///		fkAdmOutboxSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_outMsgUserTo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgUserTo(System.Decimal? _outMsgUserTo, int start, int pageLength)
		{
			int count =  -1;
			return GetByOutMsgUserTo(null, _outMsgUserTo, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER1 key.
		///		fkAdmOutboxSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_outMsgUserTo"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public TList<AdmOutbox> GetByOutMsgUserTo(System.Decimal? _outMsgUserTo, int start, int pageLength,out int count)
		{
			return GetByOutMsgUserTo(null, _outMsgUserTo, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_OUTBOX_SE_USER1 key.
		///		FK_ADM_OUTBOX_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_outMsgUserTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmOutbox objects.</returns>
		public abstract TList<AdmOutbox> GetByOutMsgUserTo(TransactionManager transactionManager, System.Decimal? _outMsgUserTo, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmOutbox Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmOutboxKey key, int start, int pageLength)
		{
			return GetByAdmOutboxId(transactionManager, key.AdmOutboxId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_OUTBOX index.
		/// </summary>
		/// <param name="_admOutboxId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOutbox GetByAdmOutboxId(System.Decimal _admOutboxId)
		{
			int count = -1;
			return GetByAdmOutboxId(null,_admOutboxId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_OUTBOX index.
		/// </summary>
		/// <param name="_admOutboxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOutbox GetByAdmOutboxId(System.Decimal _admOutboxId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOutboxId(null, _admOutboxId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_OUTBOX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOutboxId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOutbox GetByAdmOutboxId(TransactionManager transactionManager, System.Decimal _admOutboxId)
		{
			int count = -1;
			return GetByAdmOutboxId(transactionManager, _admOutboxId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_OUTBOX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOutboxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOutbox GetByAdmOutboxId(TransactionManager transactionManager, System.Decimal _admOutboxId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOutboxId(transactionManager, _admOutboxId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_OUTBOX index.
		/// </summary>
		/// <param name="_admOutboxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmOutbox GetByAdmOutboxId(System.Decimal _admOutboxId, int start, int pageLength, out int count)
		{
			return GetByAdmOutboxId(null, _admOutboxId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_OUTBOX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOutboxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmOutbox GetByAdmOutboxId(TransactionManager transactionManager, System.Decimal _admOutboxId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmOutbox&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmOutbox&gt;"/></returns>
		public static TList<AdmOutbox> Fill(IDataReader reader, TList<AdmOutbox> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmOutbox c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmOutbox")
					.Append("|").Append((System.Decimal)reader["ADM_OUTBOX_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmOutbox>(
					key.ToString(), // EntityTrackingKey
					"AdmOutbox",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmOutbox();
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
					c.AdmOutboxId = (System.Decimal)reader["ADM_OUTBOX_ID"];
					c.OriginalAdmOutboxId = c.AdmOutboxId;
					c.AdmAppMessageId = (System.Decimal)reader["ADM_APP_MESSAGE_ID"];
					c.OutMsgUserFrom = Convert.IsDBNull(reader["OUT_MSG_USER_FROM"]) ? null : (System.Decimal?)reader["OUT_MSG_USER_FROM"];
					c.OutMsgUserTo = Convert.IsDBNull(reader["OUT_MSG_USER_TO"]) ? null : (System.Decimal?)reader["OUT_MSG_USER_TO"];
					c.OutMsgAppFrom = Convert.IsDBNull(reader["OUT_MSG_APP_FROM"]) ? null : (System.Decimal?)reader["OUT_MSG_APP_FROM"];
					c.OutMsgAppTo = Convert.IsDBNull(reader["OUT_MSG_APP_TO"]) ? null : (System.Decimal?)reader["OUT_MSG_APP_TO"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmOutbox entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmOutboxId = (System.Decimal)reader[((int)AdmOutboxColumn.AdmOutboxId - 1)];
			entity.OriginalAdmOutboxId = (System.Decimal)reader["ADM_OUTBOX_ID"];
			entity.AdmAppMessageId = (System.Decimal)reader[((int)AdmOutboxColumn.AdmAppMessageId - 1)];
			entity.OutMsgUserFrom = (reader.IsDBNull(((int)AdmOutboxColumn.OutMsgUserFrom - 1)))?null:(System.Decimal?)reader[((int)AdmOutboxColumn.OutMsgUserFrom - 1)];
			entity.OutMsgUserTo = (reader.IsDBNull(((int)AdmOutboxColumn.OutMsgUserTo - 1)))?null:(System.Decimal?)reader[((int)AdmOutboxColumn.OutMsgUserTo - 1)];
			entity.OutMsgAppFrom = (reader.IsDBNull(((int)AdmOutboxColumn.OutMsgAppFrom - 1)))?null:(System.Decimal?)reader[((int)AdmOutboxColumn.OutMsgAppFrom - 1)];
			entity.OutMsgAppTo = (reader.IsDBNull(((int)AdmOutboxColumn.OutMsgAppTo - 1)))?null:(System.Decimal?)reader[((int)AdmOutboxColumn.OutMsgAppTo - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmOutbox entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmOutboxId = (System.Decimal)dataRow["ADM_OUTBOX_ID"];
			entity.OriginalAdmOutboxId = (System.Decimal)dataRow["ADM_OUTBOX_ID"];
			entity.AdmAppMessageId = (System.Decimal)dataRow["ADM_APP_MESSAGE_ID"];
			entity.OutMsgUserFrom = Convert.IsDBNull(dataRow["OUT_MSG_USER_FROM"]) ? null : (System.Decimal?)dataRow["OUT_MSG_USER_FROM"];
			entity.OutMsgUserTo = Convert.IsDBNull(dataRow["OUT_MSG_USER_TO"]) ? null : (System.Decimal?)dataRow["OUT_MSG_USER_TO"];
			entity.OutMsgAppFrom = Convert.IsDBNull(dataRow["OUT_MSG_APP_FROM"]) ? null : (System.Decimal?)dataRow["OUT_MSG_APP_FROM"];
			entity.OutMsgAppTo = Convert.IsDBNull(dataRow["OUT_MSG_APP_TO"]) ? null : (System.Decimal?)dataRow["OUT_MSG_APP_TO"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmOutbox"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmOutbox Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmOutbox entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region OutMsgAppFromSource	
			if (CanDeepLoad(entity, "AdmApplicant|OutMsgAppFromSource", deepLoadType, innerList) 
				&& entity.OutMsgAppFromSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.OutMsgAppFrom ?? 0.0m);
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.OutMsgAppFromSource = tmpEntity;
				else
					entity.OutMsgAppFromSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, (entity.OutMsgAppFrom ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'OutMsgAppFromSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.OutMsgAppFromSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmApplicantProvider.DeepLoad(transactionManager, entity.OutMsgAppFromSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion OutMsgAppFromSource

			#region OutMsgAppToSource	
			if (CanDeepLoad(entity, "AdmApplicant|OutMsgAppToSource", deepLoadType, innerList) 
				&& entity.OutMsgAppToSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.OutMsgAppTo ?? 0.0m);
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.OutMsgAppToSource = tmpEntity;
				else
					entity.OutMsgAppToSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, (entity.OutMsgAppTo ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'OutMsgAppToSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.OutMsgAppToSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmApplicantProvider.DeepLoad(transactionManager, entity.OutMsgAppToSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion OutMsgAppToSource

			#region OutMsgUserFromSource	
			if (CanDeepLoad(entity, "SeUser|OutMsgUserFromSource", deepLoadType, innerList) 
				&& entity.OutMsgUserFromSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.OutMsgUserFrom ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.OutMsgUserFromSource = tmpEntity;
				else
					entity.OutMsgUserFromSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.OutMsgUserFrom ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'OutMsgUserFromSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.OutMsgUserFromSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.OutMsgUserFromSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion OutMsgUserFromSource

			#region OutMsgUserToSource	
			if (CanDeepLoad(entity, "SeUser|OutMsgUserToSource", deepLoadType, innerList) 
				&& entity.OutMsgUserToSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.OutMsgUserTo ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.OutMsgUserToSource = tmpEntity;
				else
					entity.OutMsgUserToSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.OutMsgUserTo ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'OutMsgUserToSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.OutMsgUserToSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.OutMsgUserToSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion OutMsgUserToSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmOutbox object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmOutbox instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmOutbox Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmOutbox entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region OutMsgAppFromSource
			if (CanDeepSave(entity, "AdmApplicant|OutMsgAppFromSource", deepSaveType, innerList) 
				&& entity.OutMsgAppFromSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.OutMsgAppFromSource);
				entity.OutMsgAppFrom = entity.OutMsgAppFromSource.AdmApplicantId;
			}
			#endregion 
			
			#region OutMsgAppToSource
			if (CanDeepSave(entity, "AdmApplicant|OutMsgAppToSource", deepSaveType, innerList) 
				&& entity.OutMsgAppToSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.OutMsgAppToSource);
				entity.OutMsgAppTo = entity.OutMsgAppToSource.AdmApplicantId;
			}
			#endregion 
			
			#region OutMsgUserFromSource
			if (CanDeepSave(entity, "SeUser|OutMsgUserFromSource", deepSaveType, innerList) 
				&& entity.OutMsgUserFromSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.OutMsgUserFromSource);
				entity.OutMsgUserFrom = entity.OutMsgUserFromSource.SeUserId;
			}
			#endregion 
			
			#region OutMsgUserToSource
			if (CanDeepSave(entity, "SeUser|OutMsgUserToSource", deepSaveType, innerList) 
				&& entity.OutMsgUserToSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.OutMsgUserToSource);
				entity.OutMsgUserTo = entity.OutMsgUserToSource.SeUserId;
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
	
	#region AdmOutboxChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmOutbox</c>
	///</summary>
	public enum AdmOutboxChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppMessage</c> at AdmAppMessageIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppMessage))]
		AdmAppMessage,
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at OutMsgAppFromSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at OutMsgUserFromSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion AdmOutboxChildEntityTypes
	
	#region AdmOutboxFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmOutboxColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmOutbox"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmOutboxFilterBuilder : SqlFilterBuilder<AdmOutboxColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmOutboxFilterBuilder class.
		/// </summary>
		public AdmOutboxFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmOutboxFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmOutboxFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmOutboxFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmOutboxFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmOutboxFilterBuilder
	
	#region AdmOutboxParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmOutboxColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmOutbox"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmOutboxParameterBuilder : ParameterizedSqlFilterBuilder<AdmOutboxColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmOutboxParameterBuilder class.
		/// </summary>
		public AdmOutboxParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmOutboxParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmOutboxParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmOutboxParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmOutboxParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmOutboxParameterBuilder
	
	#region AdmOutboxSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmOutboxColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmOutbox"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmOutboxSortBuilder : SqlSortBuilder<AdmOutboxColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmOutboxSqlSortBuilder class.
		/// </summary>
		public AdmOutboxSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmOutboxSortBuilder
	
} // end namespace
