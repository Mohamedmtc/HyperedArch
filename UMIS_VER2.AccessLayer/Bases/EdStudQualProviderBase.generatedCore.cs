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
	/// This class is the base class for any <see cref="EdStudQualProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudQualProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudQual, UMIS_VER2.BusinessLyer.EdStudQualKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQualKey key)
		{
			return Delete(transactionManager, key.EdStudQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudQualId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudQualId)
		{
			return Delete(null, _edStudQualId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudQualId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0280 key.
		///		FK_AUTO_0280 Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0280 key.
		///		FK_AUTO_0280 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0280 key.
		///		FK_AUTO_0280 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0280 key.
		///		fkAuto0280 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0280 key.
		///		fkAuto0280 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0280 key.
		///		FK_AUTO_0280 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_QUAL_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_QUAL_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_QUAL_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APP_REG_HISTORY key.
		///		fkEdStudQualAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APP_REG_HISTORY key.
		///		fkEdStudQualAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APP_REG_HISTORY key.
		///		FK_ED_STUD_QUAL_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APPLICANT key.
		///		FK_ED_STUD_QUAL_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APPLICANT key.
		///		FK_ED_STUD_QUAL_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APPLICANT key.
		///		FK_ED_STUD_QUAL_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APPLICANT key.
		///		fkEdStudQualAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APPLICANT key.
		///		fkEdStudQualAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_APPLICANT key.
		///		FK_ED_STUD_QUAL_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_STUD_QUAL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(_admCdeExamGrdngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_STUD_QUAL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_STUD_QUAL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		fkEdStudQualAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		fkEdStudQualAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmCdeExamGrdngId(System.Decimal? _admCdeExamGrdngId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ED_STUD_QUAL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">NU:PG QUAL GRADE</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal? _admCdeExamGrdngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_QUAL_STATUS key.
		///		FK_ED_STUD_QUAL_ADM_CDE_QUAL_STATUS Description: 
		/// </summary>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmCdeQualStatusId(System.Int32? _admCdeQualStatusId)
		{
			int count = -1;
			return GetByAdmCdeQualStatusId(_admCdeQualStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_QUAL_STATUS key.
		///		FK_ED_STUD_QUAL_ADM_CDE_QUAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByAdmCdeQualStatusId(TransactionManager transactionManager, System.Int32? _admCdeQualStatusId)
		{
			int count = -1;
			return GetByAdmCdeQualStatusId(transactionManager, _admCdeQualStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_QUAL_STATUS key.
		///		FK_ED_STUD_QUAL_ADM_CDE_QUAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmCdeQualStatusId(TransactionManager transactionManager, System.Int32? _admCdeQualStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeQualStatusId(transactionManager, _admCdeQualStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_QUAL_STATUS key.
		///		fkEdStudQualAdmCdeQualStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmCdeQualStatusId(System.Int32? _admCdeQualStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeQualStatusId(null, _admCdeQualStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_QUAL_STATUS key.
		///		fkEdStudQualAdmCdeQualStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByAdmCdeQualStatusId(System.Int32? _admCdeQualStatusId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeQualStatusId(null, _admCdeQualStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ADM_CDE_QUAL_STATUS key.
		///		FK_ED_STUD_QUAL_ADM_CDE_QUAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeQualStatusId">EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByAdmCdeQualStatusId(TransactionManager transactionManager, System.Int32? _admCdeQualStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_BRN key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="_edCdeQualBrnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualBrnId(System.Decimal? _edCdeQualBrnId)
		{
			int count = -1;
			return GetByEdCdeQualBrnId(_edCdeQualBrnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_BRN key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByEdCdeQualBrnId(TransactionManager transactionManager, System.Decimal? _edCdeQualBrnId)
		{
			int count = -1;
			return GetByEdCdeQualBrnId(transactionManager, _edCdeQualBrnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_BRN key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualBrnId(TransactionManager transactionManager, System.Decimal? _edCdeQualBrnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualBrnId(transactionManager, _edCdeQualBrnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_BRN key.
		///		fkEdStudQualEdCdeQualBrn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualBrnId(System.Decimal? _edCdeQualBrnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeQualBrnId(null, _edCdeQualBrnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_BRN key.
		///		fkEdStudQualEdCdeQualBrn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualBrnId(System.Decimal? _edCdeQualBrnId, int start, int pageLength,out int count)
		{
			return GetByEdCdeQualBrnId(null, _edCdeQualBrnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_BRN key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_BRN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByEdCdeQualBrnId(TransactionManager transactionManager, System.Decimal? _edCdeQualBrnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_CAT key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="_edCdeQualCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualCatId(System.Decimal? _edCdeQualCatId)
		{
			int count = -1;
			return GetByEdCdeQualCatId(_edCdeQualCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_CAT key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal? _edCdeQualCatId)
		{
			int count = -1;
			return GetByEdCdeQualCatId(transactionManager, _edCdeQualCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_CAT key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal? _edCdeQualCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualCatId(transactionManager, _edCdeQualCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_CAT key.
		///		fkEdStudQualEdCdeQualCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualCatId(System.Decimal? _edCdeQualCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeQualCatId(null, _edCdeQualCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_CAT key.
		///		fkEdStudQualEdCdeQualCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualCatId(System.Decimal? _edCdeQualCatId, int start, int pageLength,out int count)
		{
			return GetByEdCdeQualCatId(null, _edCdeQualCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_CAT key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal? _edCdeQualCatId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_PHASE key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_PHASE Description: 
		/// </summary>
		/// <param name="_edCdeQualPhase"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualPhase(System.Decimal? _edCdeQualPhase)
		{
			int count = -1;
			return GetByEdCdeQualPhase(_edCdeQualPhase, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_PHASE key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByEdCdeQualPhase(TransactionManager transactionManager, System.Decimal? _edCdeQualPhase)
		{
			int count = -1;
			return GetByEdCdeQualPhase(transactionManager, _edCdeQualPhase, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_PHASE key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualPhase(TransactionManager transactionManager, System.Decimal? _edCdeQualPhase, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualPhase(transactionManager, _edCdeQualPhase, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_PHASE key.
		///		fkEdStudQualEdCdeQualPhase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualPhase(System.Decimal? _edCdeQualPhase, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeQualPhase(null, _edCdeQualPhase, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_PHASE key.
		///		fkEdStudQualEdCdeQualPhase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualPhase(System.Decimal? _edCdeQualPhase, int start, int pageLength,out int count)
		{
			return GetByEdCdeQualPhase(null, _edCdeQualPhase, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_PHASE key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualPhase"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByEdCdeQualPhase(TransactionManager transactionManager, System.Decimal? _edCdeQualPhase, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_STATUS key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_STATUS Description: 
		/// </summary>
		/// <param name="_edCdeQualStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualStatusId(System.Int32? _edCdeQualStatusId)
		{
			int count = -1;
			return GetByEdCdeQualStatusId(_edCdeQualStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_STATUS key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByEdCdeQualStatusId(TransactionManager transactionManager, System.Int32? _edCdeQualStatusId)
		{
			int count = -1;
			return GetByEdCdeQualStatusId(transactionManager, _edCdeQualStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_STATUS key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualStatusId(TransactionManager transactionManager, System.Int32? _edCdeQualStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualStatusId(transactionManager, _edCdeQualStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_STATUS key.
		///		fkEdStudQualEdCdeQualStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualStatusId(System.Int32? _edCdeQualStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeQualStatusId(null, _edCdeQualStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_STATUS key.
		///		fkEdStudQualEdCdeQualStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeQualStatusId(System.Int32? _edCdeQualStatusId, int start, int pageLength,out int count)
		{
			return GetByEdCdeQualStatusId(null, _edCdeQualStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_QUAL_STATUS key.
		///		FK_ED_STUD_QUAL_ED_CDE_QUAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByEdCdeQualStatusId(TransactionManager transactionManager, System.Int32? _edCdeQualStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_SCHOOL_GRADE key.
		///		FK_ED_STUD_QUAL_ED_CDE_SCHOOL_GRADE Description: 
		/// </summary>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeSchoolGradeId(System.Int32? _edCdeSchoolGradeId)
		{
			int count = -1;
			return GetByEdCdeSchoolGradeId(_edCdeSchoolGradeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_SCHOOL_GRADE key.
		///		FK_ED_STUD_QUAL_ED_CDE_SCHOOL_GRADE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByEdCdeSchoolGradeId(TransactionManager transactionManager, System.Int32? _edCdeSchoolGradeId)
		{
			int count = -1;
			return GetByEdCdeSchoolGradeId(transactionManager, _edCdeSchoolGradeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_SCHOOL_GRADE key.
		///		FK_ED_STUD_QUAL_ED_CDE_SCHOOL_GRADE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeSchoolGradeId(TransactionManager transactionManager, System.Int32? _edCdeSchoolGradeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeSchoolGradeId(transactionManager, _edCdeSchoolGradeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_SCHOOL_GRADE key.
		///		fkEdStudQualEdCdeSchoolGrade Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeSchoolGradeId(System.Int32? _edCdeSchoolGradeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeSchoolGradeId(null, _edCdeSchoolGradeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_SCHOOL_GRADE key.
		///		fkEdStudQualEdCdeSchoolGrade Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByEdCdeSchoolGradeId(System.Int32? _edCdeSchoolGradeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeSchoolGradeId(null, _edCdeSchoolGradeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_ED_CDE_SCHOOL_GRADE key.
		///		FK_ED_STUD_QUAL_ED_CDE_SCHOOL_GRADE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSchoolGradeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByEdCdeSchoolGradeId(TransactionManager transactionManager, System.Int32? _edCdeSchoolGradeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_FACULTY key.
		///		FK_ED_STUD_QUAL_GS_CDE_FACULTY Description: 
		/// </summary>
		/// <param name="_gsCdeFacultyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeFacultyId(System.Decimal? _gsCdeFacultyId)
		{
			int count = -1;
			return GetByGsCdeFacultyId(_gsCdeFacultyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_FACULTY key.
		///		FK_ED_STUD_QUAL_GS_CDE_FACULTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeFacultyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByGsCdeFacultyId(TransactionManager transactionManager, System.Decimal? _gsCdeFacultyId)
		{
			int count = -1;
			return GetByGsCdeFacultyId(transactionManager, _gsCdeFacultyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_FACULTY key.
		///		FK_ED_STUD_QUAL_GS_CDE_FACULTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeFacultyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeFacultyId(TransactionManager transactionManager, System.Decimal? _gsCdeFacultyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeFacultyId(transactionManager, _gsCdeFacultyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_FACULTY key.
		///		fkEdStudQualGsCdeFaculty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeFacultyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeFacultyId(System.Decimal? _gsCdeFacultyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeFacultyId(null, _gsCdeFacultyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_FACULTY key.
		///		fkEdStudQualGsCdeFaculty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeFacultyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeFacultyId(System.Decimal? _gsCdeFacultyId, int start, int pageLength,out int count)
		{
			return GetByGsCdeFacultyId(null, _gsCdeFacultyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_FACULTY key.
		///		FK_ED_STUD_QUAL_GS_CDE_FACULTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeFacultyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByGsCdeFacultyId(TransactionManager transactionManager, System.Decimal? _gsCdeFacultyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL key.
		///		FK_ED_STUD_QUAL_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="_gsCdeSchoolId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeSchoolId(System.Decimal? _gsCdeSchoolId)
		{
			int count = -1;
			return GetByGsCdeSchoolId(_gsCdeSchoolId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL key.
		///		FK_ED_STUD_QUAL_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByGsCdeSchoolId(TransactionManager transactionManager, System.Decimal? _gsCdeSchoolId)
		{
			int count = -1;
			return GetByGsCdeSchoolId(transactionManager, _gsCdeSchoolId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL key.
		///		FK_ED_STUD_QUAL_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeSchoolId(TransactionManager transactionManager, System.Decimal? _gsCdeSchoolId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSchoolId(transactionManager, _gsCdeSchoolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL key.
		///		fkEdStudQualGsCdeSchool Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSchoolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeSchoolId(System.Decimal? _gsCdeSchoolId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeSchoolId(null, _gsCdeSchoolId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL key.
		///		fkEdStudQualGsCdeSchool Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSchoolId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeSchoolId(System.Decimal? _gsCdeSchoolId, int start, int pageLength,out int count)
		{
			return GetByGsCdeSchoolId(null, _gsCdeSchoolId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL key.
		///		FK_ED_STUD_QUAL_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByGsCdeSchoolId(TransactionManager transactionManager, System.Decimal? _gsCdeSchoolId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL_TYPE key.
		///		FK_ED_STUD_QUAL_GS_CDE_SCHOOL_TYPE Description: 
		/// </summary>
		/// <param name="_gsCdeSchoolTypeId">EJUST</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeSchoolTypeId(System.Int32? _gsCdeSchoolTypeId)
		{
			int count = -1;
			return GetByGsCdeSchoolTypeId(_gsCdeSchoolTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL_TYPE key.
		///		FK_ED_STUD_QUAL_GS_CDE_SCHOOL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolTypeId">EJUST</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByGsCdeSchoolTypeId(TransactionManager transactionManager, System.Int32? _gsCdeSchoolTypeId)
		{
			int count = -1;
			return GetByGsCdeSchoolTypeId(transactionManager, _gsCdeSchoolTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL_TYPE key.
		///		FK_ED_STUD_QUAL_GS_CDE_SCHOOL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolTypeId">EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeSchoolTypeId(TransactionManager transactionManager, System.Int32? _gsCdeSchoolTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSchoolTypeId(transactionManager, _gsCdeSchoolTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL_TYPE key.
		///		fkEdStudQualGsCdeSchoolType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSchoolTypeId">EJUST</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeSchoolTypeId(System.Int32? _gsCdeSchoolTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeSchoolTypeId(null, _gsCdeSchoolTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL_TYPE key.
		///		fkEdStudQualGsCdeSchoolType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSchoolTypeId">EJUST</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeSchoolTypeId(System.Int32? _gsCdeSchoolTypeId, int start, int pageLength,out int count)
		{
			return GetByGsCdeSchoolTypeId(null, _gsCdeSchoolTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_SCHOOL_TYPE key.
		///		FK_ED_STUD_QUAL_GS_CDE_SCHOOL_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolTypeId">EJUST</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByGsCdeSchoolTypeId(TransactionManager transactionManager, System.Int32? _gsCdeSchoolTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_UNIVERSITIES key.
		///		FK_ED_STUD_QUAL_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(_gsCdeUniversitiesId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_UNIVERSITIES key.
		///		FK_ED_STUD_QUAL_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(transactionManager, _gsCdeUniversitiesId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_UNIVERSITIES key.
		///		FK_ED_STUD_QUAL_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(transactionManager, _gsCdeUniversitiesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_UNIVERSITIES key.
		///		fkEdStudQualGsCdeUniversities Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeUniversitiesId(null, _gsCdeUniversitiesId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_UNIVERSITIES key.
		///		fkEdStudQualGsCdeUniversities Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId, int start, int pageLength,out int count)
		{
			return GetByGsCdeUniversitiesId(null, _gsCdeUniversitiesId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CDE_UNIVERSITIES key.
		///		FK_ED_STUD_QUAL_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CODE_LANGUAGE key.
		///		FK_ED_STUD_QUAL_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CODE_LANGUAGE key.
		///		FK_ED_STUD_QUAL_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQual> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CODE_LANGUAGE key.
		///		FK_ED_STUD_QUAL_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CODE_LANGUAGE key.
		///		fkEdStudQualGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CODE_LANGUAGE key.
		///		fkEdStudQualGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public TList<EdStudQual> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GS_CODE_LANGUAGE key.
		///		FK_ED_STUD_QUAL_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQual objects.</returns>
		public abstract TList<EdStudQual> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudQual Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQualKey key, int start, int pageLength)
		{
			return GetByEdStudQualId(transactionManager, key.EdStudQualId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_QUAL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeQualId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public TList<EdStudQual> GetByEdCodeQualId(System.Decimal _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(null,_edCodeQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_QUAL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public TList<EdStudQual> GetByEdCodeQualId(System.Decimal _edCodeQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_QUAL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public TList<EdStudQual> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_QUAL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public TList<EdStudQual> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal _edCodeQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_QUAL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public TList<EdStudQual> GetByEdCodeQualId(System.Decimal _edCodeQualId, int start, int pageLength, out int count)
		{
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_QUAL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public abstract TList<EdStudQual> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal _edCodeQualId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public TList<EdStudQual> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(null,_gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public TList<EdStudQual> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public TList<EdStudQual> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public TList<EdStudQual> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public TList<EdStudQual> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudQual&gt;"/> class.</returns>
		public abstract TList<EdStudQual> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="_edStudQualId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudQualId(System.Decimal _edStudQualId)
		{
			int count = -1;
			return GetByEdStudQualId(null,_edStudQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="_edStudQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudQualId(System.Decimal _edStudQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudQualId(null, _edStudQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudQualId(TransactionManager transactionManager, System.Decimal _edStudQualId)
		{
			int count = -1;
			return GetByEdStudQualId(transactionManager, _edStudQualId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudQualId(TransactionManager transactionManager, System.Decimal _edStudQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudQualId(transactionManager, _edStudQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="_edStudQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudQualId(System.Decimal _edStudQualId, int start, int pageLength, out int count)
		{
			return GetByEdStudQualId(null, _edStudQualId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudQualId(TransactionManager transactionManager, System.Decimal _edStudQualId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="_qualDate">End Date</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(System.Decimal? _edStudId, System.Decimal _edCodeQualId, System.DateTime? _qualDate, System.Decimal? _admApplicantId, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(null,_edStudId, _edCodeQualId, _qualDate, _admApplicantId, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="_qualDate">End Date</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(System.Decimal? _edStudId, System.Decimal _edCodeQualId, System.DateTime? _qualDate, System.Decimal? _admApplicantId, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(null, _edStudId, _edCodeQualId, _qualDate, _admApplicantId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="_qualDate">End Date</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal _edCodeQualId, System.DateTime? _qualDate, System.Decimal? _admApplicantId, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(transactionManager, _edStudId, _edCodeQualId, _qualDate, _admApplicantId, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="_qualDate">End Date</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal _edCodeQualId, System.DateTime? _qualDate, System.Decimal? _admApplicantId, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(transactionManager, _edStudId, _edCodeQualId, _qualDate, _admApplicantId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="_qualDate">End Date</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(System.Decimal? _edStudId, System.Decimal _edCodeQualId, System.DateTime? _qualDate, System.Decimal? _admApplicantId, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(null, _edStudId, _edCodeQualId, _qualDate, _admApplicantId, _admAppRegHistoryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_QUAL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="_qualDate">End Date</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdEdCodeQualIdQualDateAdmApplicantIdAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal _edCodeQualId, System.DateTime? _qualDate, System.Decimal? _admApplicantId, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_QUAL_ADM_FLG index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admissionFlg"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, System.Decimal _admissionFlg)
		{
			int count = -1;
			return GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(null,_edStudId, _admAppRegHistoryId, _admissionFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_QUAL_ADM_FLG index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admissionFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, System.Decimal _admissionFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(null, _edStudId, _admAppRegHistoryId, _admissionFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_QUAL_ADM_FLG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admissionFlg"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, System.Decimal _admissionFlg)
		{
			int count = -1;
			return GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(transactionManager, _edStudId, _admAppRegHistoryId, _admissionFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_QUAL_ADM_FLG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admissionFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, System.Decimal _admissionFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(transactionManager, _edStudId, _admAppRegHistoryId, _admissionFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_QUAL_ADM_FLG index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admissionFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, System.Decimal _admissionFlg, int start, int pageLength, out int count)
		{
			return GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(null, _edStudId, _admAppRegHistoryId, _admissionFlg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_QUAL_ADM_FLG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admissionFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudQual GetByEdStudIdAdmAppRegHistoryIdAdmissionFlg(TransactionManager transactionManager, System.Decimal? _edStudId, System.Decimal? _admAppRegHistoryId, System.Decimal _admissionFlg, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudQual&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudQual&gt;"/></returns>
		public static TList<EdStudQual> Fill(IDataReader reader, TList<EdStudQual> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudQual c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudQual")
					.Append("|").Append((System.Decimal)reader["ED_STUD_QUAL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudQual>(
					key.ToString(), // EntityTrackingKey
					"EdStudQual",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudQual();
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
					c.EdStudQualId = (System.Decimal)reader["ED_STUD_QUAL_ID"];
					c.OriginalEdStudQualId = c.EdStudQualId;
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EdCodeQualId = (System.Decimal)reader["ED_CODE_QUAL_ID"];
					c.SchoolName = Convert.IsDBNull(reader["SCHOOL_NAME"]) ? null : (System.String)reader["SCHOOL_NAME"];
					c.QualDate = Convert.IsDBNull(reader["QUAL_DATE"]) ? null : (System.DateTime?)reader["QUAL_DATE"];
					c.QualTotMark = Convert.IsDBNull(reader["QUAL_TOT_MARK"]) ? null : (System.Decimal?)reader["QUAL_TOT_MARK"];
					c.TotalDegree = Convert.IsDBNull(reader["TOTAL_DEGREE"]) ? null : (System.Decimal?)reader["TOTAL_DEGREE"];
					c.TotalPercent = (System.Decimal)reader["TOTAL_PERCENT"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.EdCdeQualBrnId = Convert.IsDBNull(reader["ED_CDE_QUAL_BRN_ID"]) ? null : (System.Decimal?)reader["ED_CDE_QUAL_BRN_ID"];
					c.GsCdeSchoolId = Convert.IsDBNull(reader["GS_CDE_SCHOOL_ID"]) ? null : (System.Decimal?)reader["GS_CDE_SCHOOL_ID"];
					c.StudSeatNum = Convert.IsDBNull(reader["STUD_SEAT_NUM"]) ? null : (System.Decimal?)reader["STUD_SEAT_NUM"];
					c.EnglishPercent = Convert.IsDBNull(reader["ENGLISH_PERCENT"]) ? null : (System.Decimal?)reader["ENGLISH_PERCENT"];
					c.ConvertedPercent = Convert.IsDBNull(reader["CONVERTED_PERCENT"]) ? null : (System.Decimal?)reader["CONVERTED_PERCENT"];
					c.EdCdeQualCatId = Convert.IsDBNull(reader["ED_CDE_QUAL_CAT_ID"]) ? null : (System.Decimal?)reader["ED_CDE_QUAL_CAT_ID"];
					c.AdmissionFlg = (System.Decimal)reader["ADMISSION_FLG"];
					c.GsCdeUniversitiesId = Convert.IsDBNull(reader["GS_CDE_UNIVERSITIES_ID"]) ? null : (System.Decimal?)reader["GS_CDE_UNIVERSITIES_ID"];
					c.Tofel = Convert.IsDBNull(reader["TOFEL"]) ? null : (System.Decimal?)reader["TOFEL"];
					c.Cgpa = Convert.IsDBNull(reader["CGPA"]) ? null : (System.Decimal?)reader["CGPA"];
					c.QualRank = Convert.IsDBNull(reader["QUAL_RANK"]) ? null : (System.Int32?)reader["QUAL_RANK"];
					c.EdCdeQualPhase = Convert.IsDBNull(reader["ED_CDE_QUAL_PHASE"]) ? null : (System.Decimal?)reader["ED_CDE_QUAL_PHASE"];
					c.EdCdeQualStatusId = Convert.IsDBNull(reader["ED_CDE_QUAL_STATUS_ID"]) ? null : (System.Int32?)reader["ED_CDE_QUAL_STATUS_ID"];
					c.QualStartDate = Convert.IsDBNull(reader["QUAL_START_DATE"]) ? null : (System.DateTime?)reader["QUAL_START_DATE"];
					c.GsCodeLanguageId = Convert.IsDBNull(reader["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_LANGUAGE_ID"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.AdmCdeExamGrdngId = Convert.IsDBNull(reader["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_EXAM_GRDNG_ID"];
					c.QualDescEn = Convert.IsDBNull(reader["QUAL_DESC_EN"]) ? null : (System.String)reader["QUAL_DESC_EN"];
					c.QualBrnDescEn = Convert.IsDBNull(reader["QUAL_BRN_DESC_EN"]) ? null : (System.String)reader["QUAL_BRN_DESC_EN"];
					c.GsCdeFacultyId = Convert.IsDBNull(reader["GS_CDE_FACULTY_ID"]) ? null : (System.Decimal?)reader["GS_CDE_FACULTY_ID"];
					c.GsCdeSchoolTypeId = Convert.IsDBNull(reader["GS_CDE_SCHOOL_TYPE_ID"]) ? null : (System.Int32?)reader["GS_CDE_SCHOOL_TYPE_ID"];
					c.AdmCdeQualStatusId = Convert.IsDBNull(reader["ADM_CDE_QUAL_STATUS_ID"]) ? null : (System.Int32?)reader["ADM_CDE_QUAL_STATUS_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.QualRsltUsr = Convert.IsDBNull(reader["QUAL_RSLT_USR"]) ? null : (System.String)reader["QUAL_RSLT_USR"];
					c.QualRsltPwd = Convert.IsDBNull(reader["QUAL_RSLT_PWD"]) ? null : (System.String)reader["QUAL_RSLT_PWD"];
					c.EdCdeSchoolGradeId = Convert.IsDBNull(reader["ED_CDE_SCHOOL_GRADE_ID"]) ? null : (System.Int32?)reader["ED_CDE_SCHOOL_GRADE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudQual entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudQualId = (System.Decimal)reader[((int)EdStudQualColumn.EdStudQualId - 1)];
			entity.OriginalEdStudQualId = (System.Decimal)reader["ED_STUD_QUAL_ID"];
			entity.EdStudId = (reader.IsDBNull(((int)EdStudQualColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.EdStudId - 1)];
			entity.EdCodeQualId = (System.Decimal)reader[((int)EdStudQualColumn.EdCodeQualId - 1)];
			entity.SchoolName = (reader.IsDBNull(((int)EdStudQualColumn.SchoolName - 1)))?null:(System.String)reader[((int)EdStudQualColumn.SchoolName - 1)];
			entity.QualDate = (reader.IsDBNull(((int)EdStudQualColumn.QualDate - 1)))?null:(System.DateTime?)reader[((int)EdStudQualColumn.QualDate - 1)];
			entity.QualTotMark = (reader.IsDBNull(((int)EdStudQualColumn.QualTotMark - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.QualTotMark - 1)];
			entity.TotalDegree = (reader.IsDBNull(((int)EdStudQualColumn.TotalDegree - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.TotalDegree - 1)];
			entity.TotalPercent = (System.Decimal)reader[((int)EdStudQualColumn.TotalPercent - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)EdStudQualColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.GsCountryNodeId - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)EdStudQualColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.AdmApplicantId - 1)];
			entity.EdCdeQualBrnId = (reader.IsDBNull(((int)EdStudQualColumn.EdCdeQualBrnId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.EdCdeQualBrnId - 1)];
			entity.GsCdeSchoolId = (reader.IsDBNull(((int)EdStudQualColumn.GsCdeSchoolId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.GsCdeSchoolId - 1)];
			entity.StudSeatNum = (reader.IsDBNull(((int)EdStudQualColumn.StudSeatNum - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.StudSeatNum - 1)];
			entity.EnglishPercent = (reader.IsDBNull(((int)EdStudQualColumn.EnglishPercent - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.EnglishPercent - 1)];
			entity.ConvertedPercent = (reader.IsDBNull(((int)EdStudQualColumn.ConvertedPercent - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.ConvertedPercent - 1)];
			entity.EdCdeQualCatId = (reader.IsDBNull(((int)EdStudQualColumn.EdCdeQualCatId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.EdCdeQualCatId - 1)];
			entity.AdmissionFlg = (System.Decimal)reader[((int)EdStudQualColumn.AdmissionFlg - 1)];
			entity.GsCdeUniversitiesId = (reader.IsDBNull(((int)EdStudQualColumn.GsCdeUniversitiesId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.GsCdeUniversitiesId - 1)];
			entity.Tofel = (reader.IsDBNull(((int)EdStudQualColumn.Tofel - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.Tofel - 1)];
			entity.Cgpa = (reader.IsDBNull(((int)EdStudQualColumn.Cgpa - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.Cgpa - 1)];
			entity.QualRank = (reader.IsDBNull(((int)EdStudQualColumn.QualRank - 1)))?null:(System.Int32?)reader[((int)EdStudQualColumn.QualRank - 1)];
			entity.EdCdeQualPhase = (reader.IsDBNull(((int)EdStudQualColumn.EdCdeQualPhase - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.EdCdeQualPhase - 1)];
			entity.EdCdeQualStatusId = (reader.IsDBNull(((int)EdStudQualColumn.EdCdeQualStatusId - 1)))?null:(System.Int32?)reader[((int)EdStudQualColumn.EdCdeQualStatusId - 1)];
			entity.QualStartDate = (reader.IsDBNull(((int)EdStudQualColumn.QualStartDate - 1)))?null:(System.DateTime?)reader[((int)EdStudQualColumn.QualStartDate - 1)];
			entity.GsCodeLanguageId = (reader.IsDBNull(((int)EdStudQualColumn.GsCodeLanguageId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.GsCodeLanguageId - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)EdStudQualColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.AdmAppRegHistoryId - 1)];
			entity.AdmCdeExamGrdngId = (reader.IsDBNull(((int)EdStudQualColumn.AdmCdeExamGrdngId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.AdmCdeExamGrdngId - 1)];
			entity.QualDescEn = (reader.IsDBNull(((int)EdStudQualColumn.QualDescEn - 1)))?null:(System.String)reader[((int)EdStudQualColumn.QualDescEn - 1)];
			entity.QualBrnDescEn = (reader.IsDBNull(((int)EdStudQualColumn.QualBrnDescEn - 1)))?null:(System.String)reader[((int)EdStudQualColumn.QualBrnDescEn - 1)];
			entity.GsCdeFacultyId = (reader.IsDBNull(((int)EdStudQualColumn.GsCdeFacultyId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualColumn.GsCdeFacultyId - 1)];
			entity.GsCdeSchoolTypeId = (reader.IsDBNull(((int)EdStudQualColumn.GsCdeSchoolTypeId - 1)))?null:(System.Int32?)reader[((int)EdStudQualColumn.GsCdeSchoolTypeId - 1)];
			entity.AdmCdeQualStatusId = (reader.IsDBNull(((int)EdStudQualColumn.AdmCdeQualStatusId - 1)))?null:(System.Int32?)reader[((int)EdStudQualColumn.AdmCdeQualStatusId - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudQualColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudQualColumn.Notes - 1)];
			entity.QualRsltUsr = (reader.IsDBNull(((int)EdStudQualColumn.QualRsltUsr - 1)))?null:(System.String)reader[((int)EdStudQualColumn.QualRsltUsr - 1)];
			entity.QualRsltPwd = (reader.IsDBNull(((int)EdStudQualColumn.QualRsltPwd - 1)))?null:(System.String)reader[((int)EdStudQualColumn.QualRsltPwd - 1)];
			entity.EdCdeSchoolGradeId = (reader.IsDBNull(((int)EdStudQualColumn.EdCdeSchoolGradeId - 1)))?null:(System.Int32?)reader[((int)EdStudQualColumn.EdCdeSchoolGradeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudQual entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudQualId = (System.Decimal)dataRow["ED_STUD_QUAL_ID"];
			entity.OriginalEdStudQualId = (System.Decimal)dataRow["ED_STUD_QUAL_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.EdCodeQualId = (System.Decimal)dataRow["ED_CODE_QUAL_ID"];
			entity.SchoolName = Convert.IsDBNull(dataRow["SCHOOL_NAME"]) ? null : (System.String)dataRow["SCHOOL_NAME"];
			entity.QualDate = Convert.IsDBNull(dataRow["QUAL_DATE"]) ? null : (System.DateTime?)dataRow["QUAL_DATE"];
			entity.QualTotMark = Convert.IsDBNull(dataRow["QUAL_TOT_MARK"]) ? null : (System.Decimal?)dataRow["QUAL_TOT_MARK"];
			entity.TotalDegree = Convert.IsDBNull(dataRow["TOTAL_DEGREE"]) ? null : (System.Decimal?)dataRow["TOTAL_DEGREE"];
			entity.TotalPercent = (System.Decimal)dataRow["TOTAL_PERCENT"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.EdCdeQualBrnId = Convert.IsDBNull(dataRow["ED_CDE_QUAL_BRN_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_QUAL_BRN_ID"];
			entity.GsCdeSchoolId = Convert.IsDBNull(dataRow["GS_CDE_SCHOOL_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_SCHOOL_ID"];
			entity.StudSeatNum = Convert.IsDBNull(dataRow["STUD_SEAT_NUM"]) ? null : (System.Decimal?)dataRow["STUD_SEAT_NUM"];
			entity.EnglishPercent = Convert.IsDBNull(dataRow["ENGLISH_PERCENT"]) ? null : (System.Decimal?)dataRow["ENGLISH_PERCENT"];
			entity.ConvertedPercent = Convert.IsDBNull(dataRow["CONVERTED_PERCENT"]) ? null : (System.Decimal?)dataRow["CONVERTED_PERCENT"];
			entity.EdCdeQualCatId = Convert.IsDBNull(dataRow["ED_CDE_QUAL_CAT_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_QUAL_CAT_ID"];
			entity.AdmissionFlg = (System.Decimal)dataRow["ADMISSION_FLG"];
			entity.GsCdeUniversitiesId = Convert.IsDBNull(dataRow["GS_CDE_UNIVERSITIES_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_UNIVERSITIES_ID"];
			entity.Tofel = Convert.IsDBNull(dataRow["TOFEL"]) ? null : (System.Decimal?)dataRow["TOFEL"];
			entity.Cgpa = Convert.IsDBNull(dataRow["CGPA"]) ? null : (System.Decimal?)dataRow["CGPA"];
			entity.QualRank = Convert.IsDBNull(dataRow["QUAL_RANK"]) ? null : (System.Int32?)dataRow["QUAL_RANK"];
			entity.EdCdeQualPhase = Convert.IsDBNull(dataRow["ED_CDE_QUAL_PHASE"]) ? null : (System.Decimal?)dataRow["ED_CDE_QUAL_PHASE"];
			entity.EdCdeQualStatusId = Convert.IsDBNull(dataRow["ED_CDE_QUAL_STATUS_ID"]) ? null : (System.Int32?)dataRow["ED_CDE_QUAL_STATUS_ID"];
			entity.QualStartDate = Convert.IsDBNull(dataRow["QUAL_START_DATE"]) ? null : (System.DateTime?)dataRow["QUAL_START_DATE"];
			entity.GsCodeLanguageId = Convert.IsDBNull(dataRow["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.AdmCdeExamGrdngId = Convert.IsDBNull(dataRow["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_EXAM_GRDNG_ID"];
			entity.QualDescEn = Convert.IsDBNull(dataRow["QUAL_DESC_EN"]) ? null : (System.String)dataRow["QUAL_DESC_EN"];
			entity.QualBrnDescEn = Convert.IsDBNull(dataRow["QUAL_BRN_DESC_EN"]) ? null : (System.String)dataRow["QUAL_BRN_DESC_EN"];
			entity.GsCdeFacultyId = Convert.IsDBNull(dataRow["GS_CDE_FACULTY_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_FACULTY_ID"];
			entity.GsCdeSchoolTypeId = Convert.IsDBNull(dataRow["GS_CDE_SCHOOL_TYPE_ID"]) ? null : (System.Int32?)dataRow["GS_CDE_SCHOOL_TYPE_ID"];
			entity.AdmCdeQualStatusId = Convert.IsDBNull(dataRow["ADM_CDE_QUAL_STATUS_ID"]) ? null : (System.Int32?)dataRow["ADM_CDE_QUAL_STATUS_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.QualRsltUsr = Convert.IsDBNull(dataRow["QUAL_RSLT_USR"]) ? null : (System.String)dataRow["QUAL_RSLT_USR"];
			entity.QualRsltPwd = Convert.IsDBNull(dataRow["QUAL_RSLT_PWD"]) ? null : (System.String)dataRow["QUAL_RSLT_PWD"];
			entity.EdCdeSchoolGradeId = Convert.IsDBNull(dataRow["ED_CDE_SCHOOL_GRADE_ID"]) ? null : (System.Int32?)dataRow["ED_CDE_SCHOOL_GRADE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudQual"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudQual Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQual entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region AdmCdeExamGrdngIdSource	
			if (CanDeepLoad(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeExamGrdngId ?? 0.0m);
				AdmCdeExamGrdng tmpEntity = EntityManager.LocateEntity<AdmCdeExamGrdng>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeExamGrdng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeExamGrdngIdSource = tmpEntity;
				else
					entity.AdmCdeExamGrdngIdSource = DataRepository.AdmCdeExamGrdngProvider.GetByAdmCdeExamGrdngId(transactionManager, (entity.AdmCdeExamGrdngId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeExamGrdngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeExamGrdngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeExamGrdngProvider.DeepLoad(transactionManager, entity.AdmCdeExamGrdngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeExamGrdngIdSource

			#region AdmCdeQualStatusIdSource	
			if (CanDeepLoad(entity, "AdmCdeQualStatus|AdmCdeQualStatusIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeQualStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeQualStatusId ?? (int)0);
				AdmCdeQualStatus tmpEntity = EntityManager.LocateEntity<AdmCdeQualStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeQualStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeQualStatusIdSource = tmpEntity;
				else
					entity.AdmCdeQualStatusIdSource = DataRepository.AdmCdeQualStatusProvider.GetByAdmCdeQualStatusId(transactionManager, (entity.AdmCdeQualStatusId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeQualStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeQualStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeQualStatusProvider.DeepLoad(transactionManager, entity.AdmCdeQualStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeQualStatusIdSource

			#region EdCdeQualBrnIdSource	
			if (CanDeepLoad(entity, "EdCdeQualBrn|EdCdeQualBrnIdSource", deepLoadType, innerList) 
				&& entity.EdCdeQualBrnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeQualBrnId ?? 0.0m);
				EdCdeQualBrn tmpEntity = EntityManager.LocateEntity<EdCdeQualBrn>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualBrn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeQualBrnIdSource = tmpEntity;
				else
					entity.EdCdeQualBrnIdSource = DataRepository.EdCdeQualBrnProvider.GetByEdCdeQualBrnId(transactionManager, (entity.EdCdeQualBrnId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualBrnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeQualBrnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeQualBrnProvider.DeepLoad(transactionManager, entity.EdCdeQualBrnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeQualBrnIdSource

			#region EdCdeQualCatIdSource	
			if (CanDeepLoad(entity, "EdCdeQualCat|EdCdeQualCatIdSource", deepLoadType, innerList) 
				&& entity.EdCdeQualCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeQualCatId ?? 0.0m);
				EdCdeQualCat tmpEntity = EntityManager.LocateEntity<EdCdeQualCat>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeQualCatIdSource = tmpEntity;
				else
					entity.EdCdeQualCatIdSource = DataRepository.EdCdeQualCatProvider.GetByEdCdeQualCatId(transactionManager, (entity.EdCdeQualCatId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeQualCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeQualCatProvider.DeepLoad(transactionManager, entity.EdCdeQualCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeQualCatIdSource

			#region EdCdeQualPhaseSource	
			if (CanDeepLoad(entity, "EdCdeQualPhase|EdCdeQualPhaseSource", deepLoadType, innerList) 
				&& entity.EdCdeQualPhaseSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeQualPhase ?? 0.0m);
				EdCdeQualPhase tmpEntity = EntityManager.LocateEntity<EdCdeQualPhase>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualPhase), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeQualPhaseSource = tmpEntity;
				else
					entity.EdCdeQualPhaseSource = DataRepository.EdCdeQualPhaseProvider.GetByEdCdeQualPhase(transactionManager, (entity.EdCdeQualPhase ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualPhaseSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeQualPhaseSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeQualPhaseProvider.DeepLoad(transactionManager, entity.EdCdeQualPhaseSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeQualPhaseSource

			#region EdCdeQualStatusIdSource	
			if (CanDeepLoad(entity, "EdCdeQualStatus|EdCdeQualStatusIdSource", deepLoadType, innerList) 
				&& entity.EdCdeQualStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeQualStatusId ?? (int)0);
				EdCdeQualStatus tmpEntity = EntityManager.LocateEntity<EdCdeQualStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeQualStatusIdSource = tmpEntity;
				else
					entity.EdCdeQualStatusIdSource = DataRepository.EdCdeQualStatusProvider.GetByEdCdeQualStatusId(transactionManager, (entity.EdCdeQualStatusId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeQualStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeQualStatusProvider.DeepLoad(transactionManager, entity.EdCdeQualStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeQualStatusIdSource

			#region EdCdeSchoolGradeIdSource	
			if (CanDeepLoad(entity, "EdCdeSchoolGrade|EdCdeSchoolGradeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeSchoolGradeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeSchoolGradeId ?? (int)0);
				EdCdeSchoolGrade tmpEntity = EntityManager.LocateEntity<EdCdeSchoolGrade>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeSchoolGrade), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeSchoolGradeIdSource = tmpEntity;
				else
					entity.EdCdeSchoolGradeIdSource = DataRepository.EdCdeSchoolGradeProvider.GetByEdCdeSchoolGradeId(transactionManager, (entity.EdCdeSchoolGradeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeSchoolGradeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeSchoolGradeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeSchoolGradeProvider.DeepLoad(transactionManager, entity.EdCdeSchoolGradeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeSchoolGradeIdSource

			#region EdCodeQualIdSource	
			if (CanDeepLoad(entity, "EdCodeQual|EdCodeQualIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeQualId;
				EdCodeQual tmpEntity = EntityManager.LocateEntity<EdCodeQual>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeQual), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualIdSource = tmpEntity;
				else
					entity.EdCodeQualIdSource = DataRepository.EdCodeQualProvider.GetByEdCodeQualId(transactionManager, entity.EdCodeQualId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeQualIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeQualProvider.DeepLoad(transactionManager, entity.EdCodeQualIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeQualIdSource

			#region GsCdeFacultyIdSource	
			if (CanDeepLoad(entity, "GsCdeFaculty|GsCdeFacultyIdSource", deepLoadType, innerList) 
				&& entity.GsCdeFacultyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeFacultyId ?? 0.0m);
				GsCdeFaculty tmpEntity = EntityManager.LocateEntity<GsCdeFaculty>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeFaculty), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeFacultyIdSource = tmpEntity;
				else
					entity.GsCdeFacultyIdSource = DataRepository.GsCdeFacultyProvider.GetByGsCdeFacultyId(transactionManager, (entity.GsCdeFacultyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeFacultyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeFacultyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeFacultyProvider.DeepLoad(transactionManager, entity.GsCdeFacultyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeFacultyIdSource

			#region GsCdeSchoolIdSource	
			if (CanDeepLoad(entity, "GsCdeSchool|GsCdeSchoolIdSource", deepLoadType, innerList) 
				&& entity.GsCdeSchoolIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeSchoolId ?? 0.0m);
				GsCdeSchool tmpEntity = EntityManager.LocateEntity<GsCdeSchool>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeSchool), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeSchoolIdSource = tmpEntity;
				else
					entity.GsCdeSchoolIdSource = DataRepository.GsCdeSchoolProvider.GetByGsCdeSchoolId(transactionManager, (entity.GsCdeSchoolId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeSchoolIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeSchoolIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeSchoolProvider.DeepLoad(transactionManager, entity.GsCdeSchoolIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeSchoolIdSource

			#region GsCdeSchoolTypeIdSource	
			if (CanDeepLoad(entity, "GsCdeSchoolType|GsCdeSchoolTypeIdSource", deepLoadType, innerList) 
				&& entity.GsCdeSchoolTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeSchoolTypeId ?? (int)0);
				GsCdeSchoolType tmpEntity = EntityManager.LocateEntity<GsCdeSchoolType>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeSchoolType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeSchoolTypeIdSource = tmpEntity;
				else
					entity.GsCdeSchoolTypeIdSource = DataRepository.GsCdeSchoolTypeProvider.GetByGsCdeSchoolTypeId(transactionManager, (entity.GsCdeSchoolTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeSchoolTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeSchoolTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeSchoolTypeProvider.DeepLoad(transactionManager, entity.GsCdeSchoolTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeSchoolTypeIdSource

			#region GsCdeUniversitiesIdSource	
			if (CanDeepLoad(entity, "GsCdeUniversities|GsCdeUniversitiesIdSource", deepLoadType, innerList) 
				&& entity.GsCdeUniversitiesIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeUniversitiesId ?? 0.0m);
				GsCdeUniversities tmpEntity = EntityManager.LocateEntity<GsCdeUniversities>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeUniversities), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeUniversitiesIdSource = tmpEntity;
				else
					entity.GsCdeUniversitiesIdSource = DataRepository.GsCdeUniversitiesProvider.GetByGsCdeUniversitiesId(transactionManager, (entity.GsCdeUniversitiesId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeUniversitiesIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeUniversitiesIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeUniversitiesProvider.DeepLoad(transactionManager, entity.GsCdeUniversitiesIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeUniversitiesIdSource

			#region GsCodeLanguageIdSource	
			if (CanDeepLoad(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepLoadType, innerList) 
				&& entity.GsCodeLanguageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeLanguageId ?? 0.0m);
				GsCodeLanguage tmpEntity = EntityManager.LocateEntity<GsCodeLanguage>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeLanguage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeLanguageIdSource = tmpEntity;
				else
					entity.GsCodeLanguageIdSource = DataRepository.GsCodeLanguageProvider.GetByGsCodeLanguageId(transactionManager, (entity.GsCodeLanguageId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeLanguageIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeLanguageIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeLanguageProvider.DeepLoad(transactionManager, entity.GsCodeLanguageIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeLanguageIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudQualId methods when available
			
			#region EdStudFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByEdStudQualId(transactionManager, entity.EdStudQualId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQualGroup>|EdStudQualGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualGroupCollection = DataRepository.EdStudQualGroupProvider.GetByEdStudQualId(transactionManager, entity.EdStudQualId);

				if (deep && entity.EdStudQualGroupCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQualGroup>) DataRepository.EdStudQualGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualSubjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQualSubject>|EdStudQualSubjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualSubjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualSubjectCollection = DataRepository.EdStudQualSubjectProvider.GetByEdStudQualId(transactionManager, entity.EdStudQualId);

				if (deep && entity.EdStudQualSubjectCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQualSubject>) DataRepository.EdStudQualSubjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualSubjectCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudQual object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudQual instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudQual Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQual entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AdmCdeExamGrdngIdSource
			if (CanDeepSave(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource != null)
			{
				DataRepository.AdmCdeExamGrdngProvider.Save(transactionManager, entity.AdmCdeExamGrdngIdSource);
				entity.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
			}
			#endregion 
			
			#region AdmCdeQualStatusIdSource
			if (CanDeepSave(entity, "AdmCdeQualStatus|AdmCdeQualStatusIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeQualStatusIdSource != null)
			{
				DataRepository.AdmCdeQualStatusProvider.Save(transactionManager, entity.AdmCdeQualStatusIdSource);
				entity.AdmCdeQualStatusId = entity.AdmCdeQualStatusIdSource.AdmCdeQualStatusId;
			}
			#endregion 
			
			#region EdCdeQualBrnIdSource
			if (CanDeepSave(entity, "EdCdeQualBrn|EdCdeQualBrnIdSource", deepSaveType, innerList) 
				&& entity.EdCdeQualBrnIdSource != null)
			{
				DataRepository.EdCdeQualBrnProvider.Save(transactionManager, entity.EdCdeQualBrnIdSource);
				entity.EdCdeQualBrnId = entity.EdCdeQualBrnIdSource.EdCdeQualBrnId;
			}
			#endregion 
			
			#region EdCdeQualCatIdSource
			if (CanDeepSave(entity, "EdCdeQualCat|EdCdeQualCatIdSource", deepSaveType, innerList) 
				&& entity.EdCdeQualCatIdSource != null)
			{
				DataRepository.EdCdeQualCatProvider.Save(transactionManager, entity.EdCdeQualCatIdSource);
				entity.EdCdeQualCatId = entity.EdCdeQualCatIdSource.EdCdeQualCatId;
			}
			#endregion 
			
			#region EdCdeQualPhaseSource
			if (CanDeepSave(entity, "EdCdeQualPhase|EdCdeQualPhaseSource", deepSaveType, innerList) 
				&& entity.EdCdeQualPhaseSource != null)
			{
				DataRepository.EdCdeQualPhaseProvider.Save(transactionManager, entity.EdCdeQualPhaseSource);
				entity.EdCdeQualPhase = entity.EdCdeQualPhaseSource.EdCdeQualPhase;
			}
			#endregion 
			
			#region EdCdeQualStatusIdSource
			if (CanDeepSave(entity, "EdCdeQualStatus|EdCdeQualStatusIdSource", deepSaveType, innerList) 
				&& entity.EdCdeQualStatusIdSource != null)
			{
				DataRepository.EdCdeQualStatusProvider.Save(transactionManager, entity.EdCdeQualStatusIdSource);
				entity.EdCdeQualStatusId = entity.EdCdeQualStatusIdSource.EdCdeQualStatusId;
			}
			#endregion 
			
			#region EdCdeSchoolGradeIdSource
			if (CanDeepSave(entity, "EdCdeSchoolGrade|EdCdeSchoolGradeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeSchoolGradeIdSource != null)
			{
				DataRepository.EdCdeSchoolGradeProvider.Save(transactionManager, entity.EdCdeSchoolGradeIdSource);
				entity.EdCdeSchoolGradeId = entity.EdCdeSchoolGradeIdSource.EdCdeSchoolGradeId;
			}
			#endregion 
			
			#region EdCodeQualIdSource
			if (CanDeepSave(entity, "EdCodeQual|EdCodeQualIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualIdSource != null)
			{
				DataRepository.EdCodeQualProvider.Save(transactionManager, entity.EdCodeQualIdSource);
				entity.EdCodeQualId = entity.EdCodeQualIdSource.EdCodeQualId;
			}
			#endregion 
			
			#region GsCdeFacultyIdSource
			if (CanDeepSave(entity, "GsCdeFaculty|GsCdeFacultyIdSource", deepSaveType, innerList) 
				&& entity.GsCdeFacultyIdSource != null)
			{
				DataRepository.GsCdeFacultyProvider.Save(transactionManager, entity.GsCdeFacultyIdSource);
				entity.GsCdeFacultyId = entity.GsCdeFacultyIdSource.GsCdeFacultyId;
			}
			#endregion 
			
			#region GsCdeSchoolIdSource
			if (CanDeepSave(entity, "GsCdeSchool|GsCdeSchoolIdSource", deepSaveType, innerList) 
				&& entity.GsCdeSchoolIdSource != null)
			{
				DataRepository.GsCdeSchoolProvider.Save(transactionManager, entity.GsCdeSchoolIdSource);
				entity.GsCdeSchoolId = entity.GsCdeSchoolIdSource.GsCdeSchoolId;
			}
			#endregion 
			
			#region GsCdeSchoolTypeIdSource
			if (CanDeepSave(entity, "GsCdeSchoolType|GsCdeSchoolTypeIdSource", deepSaveType, innerList) 
				&& entity.GsCdeSchoolTypeIdSource != null)
			{
				DataRepository.GsCdeSchoolTypeProvider.Save(transactionManager, entity.GsCdeSchoolTypeIdSource);
				entity.GsCdeSchoolTypeId = entity.GsCdeSchoolTypeIdSource.GsCdeSchoolTypeId;
			}
			#endregion 
			
			#region GsCdeUniversitiesIdSource
			if (CanDeepSave(entity, "GsCdeUniversities|GsCdeUniversitiesIdSource", deepSaveType, innerList) 
				&& entity.GsCdeUniversitiesIdSource != null)
			{
				DataRepository.GsCdeUniversitiesProvider.Save(transactionManager, entity.GsCdeUniversitiesIdSource);
				entity.GsCdeUniversitiesId = entity.GsCdeUniversitiesIdSource.GsCdeUniversitiesId;
			}
			#endregion 
			
			#region GsCodeLanguageIdSource
			if (CanDeepSave(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepSaveType, innerList) 
				&& entity.GsCodeLanguageIdSource != null)
			{
				DataRepository.GsCodeLanguageProvider.Save(transactionManager, entity.GsCodeLanguageIdSource);
				entity.GsCodeLanguageId = entity.GsCodeLanguageIdSource.GsCodeLanguageId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.EdStudQualIdSource != null)
						{
							child.EdStudQualId = child.EdStudQualIdSource.EdStudQualId;
						}
						else
						{
							child.EdStudQualId = entity.EdStudQualId;
						}

					}

					if (entity.EdStudFacultyCollection.Count > 0 || entity.EdStudFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollection);
						
						deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQualGroup>
				if (CanDeepSave(entity.EdStudQualGroupCollection, "List<EdStudQualGroup>|EdStudQualGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQualGroup child in entity.EdStudQualGroupCollection)
					{
						if(child.EdStudQualIdSource != null)
						{
							child.EdStudQualId = child.EdStudQualIdSource.EdStudQualId;
						}
						else
						{
							child.EdStudQualId = entity.EdStudQualId;
						}

					}

					if (entity.EdStudQualGroupCollection.Count > 0 || entity.EdStudQualGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualGroupProvider.Save(transactionManager, entity.EdStudQualGroupCollection);
						
						deepHandles.Add("EdStudQualGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQualGroup >) DataRepository.EdStudQualGroupProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQualSubject>
				if (CanDeepSave(entity.EdStudQualSubjectCollection, "List<EdStudQualSubject>|EdStudQualSubjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQualSubject child in entity.EdStudQualSubjectCollection)
					{
						if(child.EdStudQualIdSource != null)
						{
							child.EdStudQualId = child.EdStudQualIdSource.EdStudQualId;
						}
						else
						{
							child.EdStudQualId = entity.EdStudQualId;
						}

					}

					if (entity.EdStudQualSubjectCollection.Count > 0 || entity.EdStudQualSubjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualSubjectProvider.Save(transactionManager, entity.EdStudQualSubjectCollection);
						
						deepHandles.Add("EdStudQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQualSubject >) DataRepository.EdStudQualSubjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualSubjectCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudQualChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudQual</c>
	///</summary>
	public enum EdStudQualChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
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
		/// Composite Property for <c>AdmCdeExamGrdng</c> at AdmCdeExamGrdngIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeExamGrdng))]
		AdmCdeExamGrdng,
		
		///<summary>
		/// Composite Property for <c>AdmCdeQualStatus</c> at AdmCdeQualStatusIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeQualStatus))]
		AdmCdeQualStatus,
		
		///<summary>
		/// Composite Property for <c>EdCdeQualBrn</c> at EdCdeQualBrnIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualBrn))]
		EdCdeQualBrn,
		
		///<summary>
		/// Composite Property for <c>EdCdeQualCat</c> at EdCdeQualCatIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualCat))]
		EdCdeQualCat,
		
		///<summary>
		/// Composite Property for <c>EdCdeQualPhase</c> at EdCdeQualPhaseSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualPhase))]
		EdCdeQualPhase,
		
		///<summary>
		/// Composite Property for <c>EdCdeQualStatus</c> at EdCdeQualStatusIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualStatus))]
		EdCdeQualStatus,
		
		///<summary>
		/// Composite Property for <c>EdCdeSchoolGrade</c> at EdCdeSchoolGradeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeSchoolGrade))]
		EdCdeSchoolGrade,
		
		///<summary>
		/// Composite Property for <c>EdCodeQual</c> at EdCodeQualIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeQual))]
		EdCodeQual,
		
		///<summary>
		/// Composite Property for <c>GsCdeFaculty</c> at GsCdeFacultyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeFaculty))]
		GsCdeFaculty,
		
		///<summary>
		/// Composite Property for <c>GsCdeSchool</c> at GsCdeSchoolIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeSchool))]
		GsCdeSchool,
		
		///<summary>
		/// Composite Property for <c>GsCdeSchoolType</c> at GsCdeSchoolTypeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeSchoolType))]
		GsCdeSchoolType,
		
		///<summary>
		/// Composite Property for <c>GsCdeUniversities</c> at GsCdeUniversitiesIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeUniversities))]
		GsCdeUniversities,
		
		///<summary>
		/// Composite Property for <c>GsCodeLanguage</c> at GsCodeLanguageIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeLanguage))]
		GsCodeLanguage,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		///<summary>
		/// Collection of <c>EdStudQual</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
		///<summary>
		/// Collection of <c>EdStudQual</c> as OneToMany for EdStudQualGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQualGroup>))]
		EdStudQualGroupCollection,
		///<summary>
		/// Collection of <c>EdStudQual</c> as OneToMany for EdStudQualSubjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQualSubject>))]
		EdStudQualSubjectCollection,
	}
	
	#endregion EdStudQualChildEntityTypes
	
	#region EdStudQualFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudQualFilterBuilder : SqlFilterBuilder<EdStudQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudQualFilterBuilder class.
		/// </summary>
		public EdStudQualFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudQualFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudQualFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudQualFilterBuilder
	
	#region EdStudQualParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudQual"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudQualParameterBuilder : ParameterizedSqlFilterBuilder<EdStudQualColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudQualParameterBuilder class.
		/// </summary>
		public EdStudQualParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudQualParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudQualParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudQualParameterBuilder
	
	#region EdStudQualSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudQualColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudQual"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudQualSortBuilder : SqlSortBuilder<EdStudQualColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudQualSqlSortBuilder class.
		/// </summary>
		public EdStudQualSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudQualSortBuilder
	
} // end namespace
