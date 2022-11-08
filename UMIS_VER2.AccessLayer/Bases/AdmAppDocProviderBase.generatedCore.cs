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
	/// This class is the base class for any <see cref="AdmAppDocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppDocProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppDoc, UMIS_VER2.BusinessLyer.AdmAppDocKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppDocKey key)
		{
			return Delete(transactionManager, key.AdmAppDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppDocId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppDocId)
		{
			return Delete(null, _admAppDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppDocId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppDocId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_DOC_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_DOC_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppDoc> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_DOC_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APP_REG_HISTORY key.
		///		fkAdmAppDocAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APP_REG_HISTORY key.
		///		fkAdmAppDocAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_DOC_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public abstract TList<AdmAppDoc> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APPLICANT key.
		///		FK_ADM_APP_DOC_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APPLICANT key.
		///		FK_ADM_APP_DOC_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppDoc> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APPLICANT key.
		///		FK_ADM_APP_DOC_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APPLICANT key.
		///		fkAdmAppDocAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APPLICANT key.
		///		fkAdmAppDocAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_APPLICANT key.
		///		FK_ADM_APP_DOC_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public abstract TList<AdmAppDoc> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_REQ_DOC key.
		///		FK_ADM_APP_DOC_ADM_REQ_DOC Description: 
		/// </summary>
		/// <param name="_admReqDocId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmReqDocId(System.Decimal? _admReqDocId)
		{
			int count = -1;
			return GetByAdmReqDocId(_admReqDocId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_REQ_DOC key.
		///		FK_ADM_APP_DOC_ADM_REQ_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admReqDocId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppDoc> GetByAdmReqDocId(TransactionManager transactionManager, System.Decimal? _admReqDocId)
		{
			int count = -1;
			return GetByAdmReqDocId(transactionManager, _admReqDocId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_REQ_DOC key.
		///		FK_ADM_APP_DOC_ADM_REQ_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admReqDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmReqDocId(TransactionManager transactionManager, System.Decimal? _admReqDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmReqDocId(transactionManager, _admReqDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_REQ_DOC key.
		///		fkAdmAppDocAdmReqDoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admReqDocId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmReqDocId(System.Decimal? _admReqDocId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmReqDocId(null, _admReqDocId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_REQ_DOC key.
		///		fkAdmAppDocAdmReqDoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admReqDocId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByAdmReqDocId(System.Decimal? _admReqDocId, int start, int pageLength,out int count)
		{
			return GetByAdmReqDocId(null, _admReqDocId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ADM_REQ_DOC key.
		///		FK_ADM_APP_DOC_ADM_REQ_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admReqDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public abstract TList<AdmAppDoc> GetByAdmReqDocId(TransactionManager transactionManager, System.Decimal? _admReqDocId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ED_STUD key.
		///		FK_ADM_APP_DOC_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ED_STUD key.
		///		FK_ADM_APP_DOC_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppDoc> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ED_STUD key.
		///		FK_ADM_APP_DOC_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ED_STUD key.
		///		fkAdmAppDocEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ED_STUD key.
		///		fkAdmAppDocEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_ED_STUD key.
		///		FK_ADM_APP_DOC_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public abstract TList<AdmAppDoc> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_GS_CDE_DOC key.
		///		FK_ADM_APP_DOC_GS_CDE_DOC Description: 
		/// </summary>
		/// <param name="_gsCdeDocId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByGsCdeDocId(System.Int32? _gsCdeDocId)
		{
			int count = -1;
			return GetByGsCdeDocId(_gsCdeDocId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_GS_CDE_DOC key.
		///		FK_ADM_APP_DOC_GS_CDE_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeDocId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppDoc> GetByGsCdeDocId(TransactionManager transactionManager, System.Int32? _gsCdeDocId)
		{
			int count = -1;
			return GetByGsCdeDocId(transactionManager, _gsCdeDocId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_GS_CDE_DOC key.
		///		FK_ADM_APP_DOC_GS_CDE_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByGsCdeDocId(TransactionManager transactionManager, System.Int32? _gsCdeDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeDocId(transactionManager, _gsCdeDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_GS_CDE_DOC key.
		///		fkAdmAppDocGsCdeDoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeDocId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByGsCdeDocId(System.Int32? _gsCdeDocId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeDocId(null, _gsCdeDocId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_GS_CDE_DOC key.
		///		fkAdmAppDocGsCdeDoc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeDocId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public TList<AdmAppDoc> GetByGsCdeDocId(System.Int32? _gsCdeDocId, int start, int pageLength,out int count)
		{
			return GetByGsCdeDocId(null, _gsCdeDocId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_DOC_GS_CDE_DOC key.
		///		FK_ADM_APP_DOC_GS_CDE_DOC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppDoc objects.</returns>
		public abstract TList<AdmAppDoc> GetByGsCdeDocId(TransactionManager transactionManager, System.Int32? _gsCdeDocId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppDoc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppDocKey key, int start, int pageLength)
		{
			return GetByAdmAppDocId(transactionManager, key.AdmAppDocId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="_admAppDocId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmAppDocId(System.Decimal _admAppDocId)
		{
			int count = -1;
			return GetByAdmAppDocId(null,_admAppDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="_admAppDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmAppDocId(System.Decimal _admAppDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppDocId(null, _admAppDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppDocId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmAppDocId(TransactionManager transactionManager, System.Decimal _admAppDocId)
		{
			int count = -1;
			return GetByAdmAppDocId(transactionManager, _admAppDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmAppDocId(TransactionManager transactionManager, System.Decimal _admAppDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppDocId(transactionManager, _admAppDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="_admAppDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmAppDocId(System.Decimal _admAppDocId, int start, int pageLength, out int count)
		{
			return GetByAdmAppDocId(null, _admAppDocId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmAppDocId(TransactionManager transactionManager, System.Decimal _admAppDocId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admReqDocId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _admReqDocId, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(null,_admApplicantId, _edStudId, _admReqDocId, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admReqDocId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _admReqDocId, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(null, _admApplicantId, _edStudId, _admReqDocId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admReqDocId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _admReqDocId, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(transactionManager, _admApplicantId, _edStudId, _admReqDocId, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admReqDocId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _admReqDocId, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(transactionManager, _admApplicantId, _edStudId, _admReqDocId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admReqDocId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _admReqDocId, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(null, _admApplicantId, _edStudId, _admReqDocId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_admReqDocId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppDoc GetByAdmApplicantIdEdStudIdAdmReqDocIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _edStudId, System.Decimal? _admReqDocId, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppDoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppDoc&gt;"/></returns>
		public static TList<AdmAppDoc> Fill(IDataReader reader, TList<AdmAppDoc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppDoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppDoc")
					.Append("|").Append((System.Decimal)reader["ADM_APP_DOC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppDoc>(
					key.ToString(), // EntityTrackingKey
					"AdmAppDoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppDoc();
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
					c.AdmAppDocId = (System.Decimal)reader["ADM_APP_DOC_ID"];
					c.OriginalAdmAppDocId = c.AdmAppDocId;
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.AdmReqDocId = Convert.IsDBNull(reader["ADM_REQ_DOC_ID"]) ? null : (System.Decimal?)reader["ADM_REQ_DOC_ID"];
					c.SubmitDate = Convert.IsDBNull(reader["SUBMIT_DATE"]) ? null : (System.DateTime?)reader["SUBMIT_DATE"];
					c.AppDocPath = Convert.IsDBNull(reader["APP_DOC_PATH"]) ? null : (System.String)reader["APP_DOC_PATH"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.RcvdFlg = Convert.IsDBNull(reader["RCVD_FLG"]) ? null : (System.Boolean?)reader["RCVD_FLG"];
					c.ReviewFlg = Convert.IsDBNull(reader["REVIEW_FLG"]) ? null : (System.Boolean?)reader["REVIEW_FLG"];
					c.GsCdeDocId = Convert.IsDBNull(reader["GS_CDE_DOC_ID"]) ? null : (System.Int32?)reader["GS_CDE_DOC_ID"];
					c.NeedUpdtFlg = Convert.IsDBNull(reader["NEED_UPDT_FLG"]) ? null : (System.Boolean?)reader["NEED_UPDT_FLG"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppDoc entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppDocId = (System.Decimal)reader[((int)AdmAppDocColumn.AdmAppDocId - 1)];
			entity.OriginalAdmAppDocId = (System.Decimal)reader["ADM_APP_DOC_ID"];
			entity.AdmApplicantId = (reader.IsDBNull(((int)AdmAppDocColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)AdmAppDocColumn.AdmApplicantId - 1)];
			entity.AdmReqDocId = (reader.IsDBNull(((int)AdmAppDocColumn.AdmReqDocId - 1)))?null:(System.Decimal?)reader[((int)AdmAppDocColumn.AdmReqDocId - 1)];
			entity.SubmitDate = (reader.IsDBNull(((int)AdmAppDocColumn.SubmitDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppDocColumn.SubmitDate - 1)];
			entity.AppDocPath = (reader.IsDBNull(((int)AdmAppDocColumn.AppDocPath - 1)))?null:(System.String)reader[((int)AdmAppDocColumn.AppDocPath - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)AdmAppDocColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)AdmAppDocColumn.EdStudId - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)AdmAppDocColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)AdmAppDocColumn.AdmAppRegHistoryId - 1)];
			entity.RcvdFlg = (reader.IsDBNull(((int)AdmAppDocColumn.RcvdFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppDocColumn.RcvdFlg - 1)];
			entity.ReviewFlg = (reader.IsDBNull(((int)AdmAppDocColumn.ReviewFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppDocColumn.ReviewFlg - 1)];
			entity.GsCdeDocId = (reader.IsDBNull(((int)AdmAppDocColumn.GsCdeDocId - 1)))?null:(System.Int32?)reader[((int)AdmAppDocColumn.GsCdeDocId - 1)];
			entity.NeedUpdtFlg = (reader.IsDBNull(((int)AdmAppDocColumn.NeedUpdtFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppDocColumn.NeedUpdtFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppDocColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppDocColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppDocColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppDocColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppDoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppDocId = (System.Decimal)dataRow["ADM_APP_DOC_ID"];
			entity.OriginalAdmAppDocId = (System.Decimal)dataRow["ADM_APP_DOC_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.AdmReqDocId = Convert.IsDBNull(dataRow["ADM_REQ_DOC_ID"]) ? null : (System.Decimal?)dataRow["ADM_REQ_DOC_ID"];
			entity.SubmitDate = Convert.IsDBNull(dataRow["SUBMIT_DATE"]) ? null : (System.DateTime?)dataRow["SUBMIT_DATE"];
			entity.AppDocPath = Convert.IsDBNull(dataRow["APP_DOC_PATH"]) ? null : (System.String)dataRow["APP_DOC_PATH"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.RcvdFlg = Convert.IsDBNull(dataRow["RCVD_FLG"]) ? null : (System.Boolean?)dataRow["RCVD_FLG"];
			entity.ReviewFlg = Convert.IsDBNull(dataRow["REVIEW_FLG"]) ? null : (System.Boolean?)dataRow["REVIEW_FLG"];
			entity.GsCdeDocId = Convert.IsDBNull(dataRow["GS_CDE_DOC_ID"]) ? null : (System.Int32?)dataRow["GS_CDE_DOC_ID"];
			entity.NeedUpdtFlg = Convert.IsDBNull(dataRow["NEED_UPDT_FLG"]) ? null : (System.Boolean?)dataRow["NEED_UPDT_FLG"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppDoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppDoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppDoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppRegHistoryId ?? 0.0m);
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, (entity.AdmAppRegHistoryId ?? 0.0m));		
				
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

			#region AdmReqDocIdSource	
			if (CanDeepLoad(entity, "AdmReqDoc|AdmReqDocIdSource", deepLoadType, innerList) 
				&& entity.AdmReqDocIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmReqDocId ?? 0.0m);
				AdmReqDoc tmpEntity = EntityManager.LocateEntity<AdmReqDoc>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmReqDoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmReqDocIdSource = tmpEntity;
				else
					entity.AdmReqDocIdSource = DataRepository.AdmReqDocProvider.GetByAdmReqDocId(transactionManager, (entity.AdmReqDocId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmReqDocIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmReqDocIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmReqDocProvider.DeepLoad(transactionManager, entity.AdmReqDocIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmReqDocIdSource

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

			#region GsCdeDocIdSource	
			if (CanDeepLoad(entity, "GsCdeDoc|GsCdeDocIdSource", deepLoadType, innerList) 
				&& entity.GsCdeDocIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeDocId ?? (int)0);
				GsCdeDoc tmpEntity = EntityManager.LocateEntity<GsCdeDoc>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeDoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeDocIdSource = tmpEntity;
				else
					entity.GsCdeDocIdSource = DataRepository.GsCdeDocProvider.GetByGsCdeDocId(transactionManager, (entity.GsCdeDocId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeDocIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeDocIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeDocProvider.DeepLoad(transactionManager, entity.GsCdeDocIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeDocIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppDoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppDoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppDoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppDoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
			}
			#endregion 
			
			#region AdmReqDocIdSource
			if (CanDeepSave(entity, "AdmReqDoc|AdmReqDocIdSource", deepSaveType, innerList) 
				&& entity.AdmReqDocIdSource != null)
			{
				DataRepository.AdmReqDocProvider.Save(transactionManager, entity.AdmReqDocIdSource);
				entity.AdmReqDocId = entity.AdmReqDocIdSource.AdmReqDocId;
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
			
			#region GsCdeDocIdSource
			if (CanDeepSave(entity, "GsCdeDoc|GsCdeDocIdSource", deepSaveType, innerList) 
				&& entity.GsCdeDocIdSource != null)
			{
				DataRepository.GsCdeDocProvider.Save(transactionManager, entity.GsCdeDocIdSource);
				entity.GsCdeDocId = entity.GsCdeDocIdSource.GsCdeDocId;
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
	
	#region AdmAppDocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppDoc</c>
	///</summary>
	public enum AdmAppDocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>AdmReqDoc</c> at AdmReqDocIdSource
		///</summary>
		[ChildEntityType(typeof(AdmReqDoc))]
		AdmReqDoc,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCdeDoc</c> at GsCdeDocIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeDoc))]
		GsCdeDoc,
	}
	
	#endregion AdmAppDocChildEntityTypes
	
	#region AdmAppDocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppDocFilterBuilder : SqlFilterBuilder<AdmAppDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppDocFilterBuilder class.
		/// </summary>
		public AdmAppDocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppDocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppDocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppDocFilterBuilder
	
	#region AdmAppDocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppDocParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppDocParameterBuilder class.
		/// </summary>
		public AdmAppDocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppDocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppDocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppDocParameterBuilder
	
	#region AdmAppDocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppDoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppDocSortBuilder : SqlSortBuilder<AdmAppDocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppDocSqlSortBuilder class.
		/// </summary>
		public AdmAppDocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppDocSortBuilder
	
} // end namespace
