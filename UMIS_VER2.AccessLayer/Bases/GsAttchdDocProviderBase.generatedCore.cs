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
	/// This class is the base class for any <see cref="GsAttchdDocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsAttchdDocProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsAttchdDoc, UMIS_VER2.BusinessLyer.GsAttchdDocKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsAttchdDocKey key)
		{
			return Delete(transactionManager, key.GsAttchdDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsAttchdDocId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsAttchdDocId)
		{
			return Delete(null, _gsAttchdDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAttchdDocId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsAttchdDocId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_HONOR key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_HONOR Description: 
		/// </summary>
		/// <param name="_admAppHonorId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppHonorId(System.Decimal? _admAppHonorId)
		{
			int count = -1;
			return GetByAdmAppHonorId(_admAppHonorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_HONOR key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByAdmAppHonorId(TransactionManager transactionManager, System.Decimal? _admAppHonorId)
		{
			int count = -1;
			return GetByAdmAppHonorId(transactionManager, _admAppHonorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_HONOR key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppHonorId(TransactionManager transactionManager, System.Decimal? _admAppHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppHonorId(transactionManager, _admAppHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_HONOR key.
		///		fkGsAttchdDocAdmAppHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppHonorId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppHonorId(System.Decimal? _admAppHonorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppHonorId(null, _admAppHonorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_HONOR key.
		///		fkGsAttchdDocAdmAppHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppHonorId">XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppHonorId(System.Decimal? _admAppHonorId, int start, int pageLength,out int count)
		{
			return GetByAdmAppHonorId(null, _admAppHonorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_HONOR key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppHonorId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByAdmAppHonorId(TransactionManager transactionManager, System.Decimal? _admAppHonorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_INFO key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_INFO Description: 
		/// </summary>
		/// <param name="_admAppInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppInfoId(System.Decimal? _admAppInfoId)
		{
			int count = -1;
			return GetByAdmAppInfoId(_admAppInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_INFO key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByAdmAppInfoId(TransactionManager transactionManager, System.Decimal? _admAppInfoId)
		{
			int count = -1;
			return GetByAdmAppInfoId(transactionManager, _admAppInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_INFO key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppInfoId(TransactionManager transactionManager, System.Decimal? _admAppInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppInfoId(transactionManager, _admAppInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_INFO key.
		///		fkGsAttchdDocAdmAppInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppInfoId(System.Decimal? _admAppInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppInfoId(null, _admAppInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_INFO key.
		///		fkGsAttchdDocAdmAppInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppInfoId(System.Decimal? _admAppInfoId, int start, int pageLength,out int count)
		{
			return GetByAdmAppInfoId(null, _admAppInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_INFO key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByAdmAppInfoId(TransactionManager transactionManager, System.Decimal? _admAppInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_PLACEMENT_EXAM key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="_admAppPlacementExamId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppPlacementExamId(System.Decimal? _admAppPlacementExamId)
		{
			int count = -1;
			return GetByAdmAppPlacementExamId(_admAppPlacementExamId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_PLACEMENT_EXAM key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppPlacementExamId">XX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByAdmAppPlacementExamId(TransactionManager transactionManager, System.Decimal? _admAppPlacementExamId)
		{
			int count = -1;
			return GetByAdmAppPlacementExamId(transactionManager, _admAppPlacementExamId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_PLACEMENT_EXAM key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppPlacementExamId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppPlacementExamId(TransactionManager transactionManager, System.Decimal? _admAppPlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppPlacementExamId(transactionManager, _admAppPlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_PLACEMENT_EXAM key.
		///		fkGsAttchdDocAdmAppPlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppPlacementExamId">XX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppPlacementExamId(System.Decimal? _admAppPlacementExamId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppPlacementExamId(null, _admAppPlacementExamId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_PLACEMENT_EXAM key.
		///		fkGsAttchdDocAdmAppPlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppPlacementExamId">XX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByAdmAppPlacementExamId(System.Decimal? _admAppPlacementExamId, int start, int pageLength,out int count)
		{
			return GetByAdmAppPlacementExamId(null, _admAppPlacementExamId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ADM_APP_PLACEMENT_EXAM key.
		///		FK_GS_ATTCHD_DOC_ADM_APP_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppPlacementExamId">XX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByAdmAppPlacementExamId(TransactionManager transactionManager, System.Decimal? _admAppPlacementExamId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_EXAM_STUD_ABSENCE key.
		///		FK_GS_ATTCHD_DOC_ED_EXAM_STUD_ABSENCE Description: 
		/// </summary>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdExamStudAbsenceId(System.Decimal? _edExamStudAbsenceId)
		{
			int count = -1;
			return GetByEdExamStudAbsenceId(_edExamStudAbsenceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_EXAM_STUD_ABSENCE key.
		///		FK_GS_ATTCHD_DOC_ED_EXAM_STUD_ABSENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdExamStudAbsenceId(TransactionManager transactionManager, System.Decimal? _edExamStudAbsenceId)
		{
			int count = -1;
			return GetByEdExamStudAbsenceId(transactionManager, _edExamStudAbsenceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_EXAM_STUD_ABSENCE key.
		///		FK_GS_ATTCHD_DOC_ED_EXAM_STUD_ABSENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdExamStudAbsenceId(TransactionManager transactionManager, System.Decimal? _edExamStudAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamStudAbsenceId(transactionManager, _edExamStudAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_EXAM_STUD_ABSENCE key.
		///		fkGsAttchdDocEdExamStudAbsence Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdExamStudAbsenceId(System.Decimal? _edExamStudAbsenceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdExamStudAbsenceId(null, _edExamStudAbsenceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_EXAM_STUD_ABSENCE key.
		///		fkGsAttchdDocEdExamStudAbsence Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdExamStudAbsenceId(System.Decimal? _edExamStudAbsenceId, int start, int pageLength,out int count)
		{
			return GetByEdExamStudAbsenceId(null, _edExamStudAbsenceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_EXAM_STUD_ABSENCE key.
		///		FK_GS_ATTCHD_DOC_ED_EXAM_STUD_ABSENCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamStudAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdExamStudAbsenceId(TransactionManager transactionManager, System.Decimal? _edExamStudAbsenceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_GRADUATION_AWARD key.
		///		FK_GS_ATTCHD_DOC_ED_GRADUATION_AWARD Description: 
		/// </summary>
		/// <param name="_edGraduationAwardId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdGraduationAwardId(System.Decimal? _edGraduationAwardId)
		{
			int count = -1;
			return GetByEdGraduationAwardId(_edGraduationAwardId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_GRADUATION_AWARD key.
		///		FK_GS_ATTCHD_DOC_ED_GRADUATION_AWARD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdGraduationAwardId(TransactionManager transactionManager, System.Decimal? _edGraduationAwardId)
		{
			int count = -1;
			return GetByEdGraduationAwardId(transactionManager, _edGraduationAwardId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_GRADUATION_AWARD key.
		///		FK_GS_ATTCHD_DOC_ED_GRADUATION_AWARD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdGraduationAwardId(TransactionManager transactionManager, System.Decimal? _edGraduationAwardId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdGraduationAwardId(transactionManager, _edGraduationAwardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_GRADUATION_AWARD key.
		///		fkGsAttchdDocEdGraduationAward Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdGraduationAwardId(System.Decimal? _edGraduationAwardId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdGraduationAwardId(null, _edGraduationAwardId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_GRADUATION_AWARD key.
		///		fkGsAttchdDocEdGraduationAward Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdGraduationAwardId(System.Decimal? _edGraduationAwardId, int start, int pageLength,out int count)
		{
			return GetByEdGraduationAwardId(null, _edGraduationAwardId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_GRADUATION_AWARD key.
		///		FK_GS_ATTCHD_DOC_ED_GRADUATION_AWARD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edGraduationAwardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdGraduationAwardId(TransactionManager transactionManager, System.Decimal? _edGraduationAwardId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CHEAT key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_CHEAT Description: 
		/// </summary>
		/// <param name="_edStudCheatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCheatId(System.Decimal? _edStudCheatId)
		{
			int count = -1;
			return GetByEdStudCheatId(_edStudCheatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CHEAT key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_CHEAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCheatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdStudCheatId(TransactionManager transactionManager, System.Decimal? _edStudCheatId)
		{
			int count = -1;
			return GetByEdStudCheatId(transactionManager, _edStudCheatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CHEAT key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_CHEAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCheatId(TransactionManager transactionManager, System.Decimal? _edStudCheatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCheatId(transactionManager, _edStudCheatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CHEAT key.
		///		fkGsAttchdDocEdStudCheat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCheatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCheatId(System.Decimal? _edStudCheatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCheatId(null, _edStudCheatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CHEAT key.
		///		fkGsAttchdDocEdStudCheat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCheatId(System.Decimal? _edStudCheatId, int start, int pageLength,out int count)
		{
			return GetByEdStudCheatId(null, _edStudCheatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CHEAT key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_CHEAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCheatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdStudCheatId(TransactionManager transactionManager, System.Decimal? _edStudCheatId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CLRNC_REQ key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_CLRNC_REQ Description: 
		/// </summary>
		/// <param name="_edStudClrncReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudClrncReqId(System.Decimal? _edStudClrncReqId)
		{
			int count = -1;
			return GetByEdStudClrncReqId(_edStudClrncReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CLRNC_REQ key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_CLRNC_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdStudClrncReqId(TransactionManager transactionManager, System.Decimal? _edStudClrncReqId)
		{
			int count = -1;
			return GetByEdStudClrncReqId(transactionManager, _edStudClrncReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CLRNC_REQ key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_CLRNC_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudClrncReqId(TransactionManager transactionManager, System.Decimal? _edStudClrncReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudClrncReqId(transactionManager, _edStudClrncReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CLRNC_REQ key.
		///		fkGsAttchdDocEdStudClrncReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudClrncReqId(System.Decimal? _edStudClrncReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudClrncReqId(null, _edStudClrncReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CLRNC_REQ key.
		///		fkGsAttchdDocEdStudClrncReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudClrncReqId(System.Decimal? _edStudClrncReqId, int start, int pageLength,out int count)
		{
			return GetByEdStudClrncReqId(null, _edStudClrncReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_CLRNC_REQ key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_CLRNC_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdStudClrncReqId(TransactionManager transactionManager, System.Decimal? _edStudClrncReqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_CHNG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_CHNG Description: 
		/// </summary>
		/// <param name="_edStudCourseChngId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseChngId(System.Decimal? _edStudCourseChngId)
		{
			int count = -1;
			return GetByEdStudCourseChngId(_edStudCourseChngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_CHNG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_CHNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseChngId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdStudCourseChngId(TransactionManager transactionManager, System.Decimal? _edStudCourseChngId)
		{
			int count = -1;
			return GetByEdStudCourseChngId(transactionManager, _edStudCourseChngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_CHNG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_CHNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseChngId(TransactionManager transactionManager, System.Decimal? _edStudCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseChngId(transactionManager, _edStudCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_CHNG key.
		///		fkGsAttchdDocEdStudCourseChng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseChngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseChngId(System.Decimal? _edStudCourseChngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseChngId(null, _edStudCourseChngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_CHNG key.
		///		fkGsAttchdDocEdStudCourseChng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseChngId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseChngId(System.Decimal? _edStudCourseChngId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseChngId(null, _edStudCourseChngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_CHNG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_CHNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdStudCourseChngId(TransactionManager transactionManager, System.Decimal? _edStudCourseChngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_GRD_CHNG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_GRD_CHNG Description: 
		/// </summary>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseGrdChngId(System.Decimal? _edStudCourseGrdChngId)
		{
			int count = -1;
			return GetByEdStudCourseGrdChngId(_edStudCourseGrdChngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_GRD_CHNG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_GRD_CHNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdStudCourseGrdChngId(TransactionManager transactionManager, System.Decimal? _edStudCourseGrdChngId)
		{
			int count = -1;
			return GetByEdStudCourseGrdChngId(transactionManager, _edStudCourseGrdChngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_GRD_CHNG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_GRD_CHNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseGrdChngId(TransactionManager transactionManager, System.Decimal? _edStudCourseGrdChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseGrdChngId(transactionManager, _edStudCourseGrdChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_GRD_CHNG key.
		///		fkGsAttchdDocEdStudCourseGrdChng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseGrdChngId(System.Decimal? _edStudCourseGrdChngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseGrdChngId(null, _edStudCourseGrdChngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_GRD_CHNG key.
		///		fkGsAttchdDocEdStudCourseGrdChng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseGrdChngId(System.Decimal? _edStudCourseGrdChngId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseGrdChngId(null, _edStudCourseGrdChngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_GRD_CHNG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_GRD_CHNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseGrdChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdStudCourseGrdChngId(TransactionManager transactionManager, System.Decimal? _edStudCourseGrdChngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_REG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseRegId(System.Decimal? _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(_edStudCourseRegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_REG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal? _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_REG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal? _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_REG key.
		///		fkGsAttchdDocEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseRegId(System.Decimal? _edStudCourseRegId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_REG key.
		///		fkGsAttchdDocEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudCourseRegId(System.Decimal? _edStudCourseRegId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_COURSE_REG key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal? _edStudCourseRegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_ENROLL_CHANGE key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_ENROLL_CHANGE Description: 
		/// </summary>
		/// <param name="_edStudEnrollChangeId">مسلسل تغيير حالة قيد طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudEnrollChangeId(System.Decimal? _edStudEnrollChangeId)
		{
			int count = -1;
			return GetByEdStudEnrollChangeId(_edStudEnrollChangeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_ENROLL_CHANGE key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_ENROLL_CHANGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudEnrollChangeId">مسلسل تغيير حالة قيد طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdStudEnrollChangeId(TransactionManager transactionManager, System.Decimal? _edStudEnrollChangeId)
		{
			int count = -1;
			return GetByEdStudEnrollChangeId(transactionManager, _edStudEnrollChangeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_ENROLL_CHANGE key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_ENROLL_CHANGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudEnrollChangeId">مسلسل تغيير حالة قيد طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudEnrollChangeId(TransactionManager transactionManager, System.Decimal? _edStudEnrollChangeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudEnrollChangeId(transactionManager, _edStudEnrollChangeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_ENROLL_CHANGE key.
		///		fkGsAttchdDocEdStudEnrollChange Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudEnrollChangeId">مسلسل تغيير حالة قيد طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudEnrollChangeId(System.Decimal? _edStudEnrollChangeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudEnrollChangeId(null, _edStudEnrollChangeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_ENROLL_CHANGE key.
		///		fkGsAttchdDocEdStudEnrollChange Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudEnrollChangeId">مسلسل تغيير حالة قيد طالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudEnrollChangeId(System.Decimal? _edStudEnrollChangeId, int start, int pageLength,out int count)
		{
			return GetByEdStudEnrollChangeId(null, _edStudEnrollChangeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_ENROLL_CHANGE key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_ENROLL_CHANGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudEnrollChangeId">مسلسل تغيير حالة قيد طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdStudEnrollChangeId(TransactionManager transactionManager, System.Decimal? _edStudEnrollChangeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="_edStudViolId">المخالفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolId(System.Decimal? _edStudViolId)
		{
			int count = -1;
			return GetByEdStudViolId(_edStudViolId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId">المخالفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdStudViolId(TransactionManager transactionManager, System.Decimal? _edStudViolId)
		{
			int count = -1;
			return GetByEdStudViolId(transactionManager, _edStudViolId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId">المخالفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolId(TransactionManager transactionManager, System.Decimal? _edStudViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolId(transactionManager, _edStudViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL key.
		///		fkGsAttchdDocEdStudViol Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudViolId">المخالفة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolId(System.Decimal? _edStudViolId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudViolId(null, _edStudViolId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL key.
		///		fkGsAttchdDocEdStudViol Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudViolId">المخالفة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolId(System.Decimal? _edStudViolId, int start, int pageLength,out int count)
		{
			return GetByEdStudViolId(null, _edStudViolId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolId">المخالفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdStudViolId(TransactionManager transactionManager, System.Decimal? _edStudViolId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL_APPEAL key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL_APPEAL Description: 
		/// </summary>
		/// <param name="_edStudViolAppealId">التظلم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolAppealId(System.Decimal? _edStudViolAppealId)
		{
			int count = -1;
			return GetByEdStudViolAppealId(_edStudViolAppealId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL_APPEAL key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL_APPEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolAppealId">التظلم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdStudViolAppealId(TransactionManager transactionManager, System.Decimal? _edStudViolAppealId)
		{
			int count = -1;
			return GetByEdStudViolAppealId(transactionManager, _edStudViolAppealId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL_APPEAL key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL_APPEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolAppealId">التظلم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolAppealId(TransactionManager transactionManager, System.Decimal? _edStudViolAppealId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolAppealId(transactionManager, _edStudViolAppealId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL_APPEAL key.
		///		fkGsAttchdDocEdStudViolAppeal Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudViolAppealId">التظلم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolAppealId(System.Decimal? _edStudViolAppealId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudViolAppealId(null, _edStudViolAppealId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL_APPEAL key.
		///		fkGsAttchdDocEdStudViolAppeal Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudViolAppealId">التظلم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolAppealId(System.Decimal? _edStudViolAppealId, int start, int pageLength,out int count)
		{
			return GetByEdStudViolAppealId(null, _edStudViolAppealId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL_APPEAL key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL_APPEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolAppealId">التظلم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdStudViolAppealId(TransactionManager transactionManager, System.Decimal? _edStudViolAppealId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL1 key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL1 Description: 
		/// </summary>
		/// <param name="_edStudViolInvestId">مجلس التأديب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolInvestId(System.Decimal? _edStudViolInvestId)
		{
			int count = -1;
			return GetByEdStudViolInvestId(_edStudViolInvestId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL1 key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolInvestId">مجلس التأديب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByEdStudViolInvestId(TransactionManager transactionManager, System.Decimal? _edStudViolInvestId)
		{
			int count = -1;
			return GetByEdStudViolInvestId(transactionManager, _edStudViolInvestId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL1 key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolInvestId">مجلس التأديب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolInvestId(TransactionManager transactionManager, System.Decimal? _edStudViolInvestId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudViolInvestId(transactionManager, _edStudViolInvestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL1 key.
		///		fkGsAttchdDocEdStudViol1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudViolInvestId">مجلس التأديب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolInvestId(System.Decimal? _edStudViolInvestId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudViolInvestId(null, _edStudViolInvestId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL1 key.
		///		fkGsAttchdDocEdStudViol1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudViolInvestId">مجلس التأديب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByEdStudViolInvestId(System.Decimal? _edStudViolInvestId, int start, int pageLength,out int count)
		{
			return GetByEdStudViolInvestId(null, _edStudViolInvestId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_ED_STUD_VIOL1 key.
		///		FK_GS_ATTCHD_DOC_ED_STUD_VIOL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudViolInvestId">مجلس التأديب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByEdStudViolInvestId(TransactionManager transactionManager, System.Decimal? _edStudViolInvestId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_FEE_STUD_DISC key.
		///		FK_GS_ATTCHD_DOC_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="_feeStudDiscId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByFeeStudDiscId(System.Decimal? _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(_feeStudDiscId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_FEE_STUD_DISC key.
		///		FK_GS_ATTCHD_DOC_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal? _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_FEE_STUD_DISC key.
		///		FK_GS_ATTCHD_DOC_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal? _feeStudDiscId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_FEE_STUD_DISC key.
		///		fkGsAttchdDocFeeStudDisc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudDiscId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByFeeStudDiscId(System.Decimal? _feeStudDiscId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_FEE_STUD_DISC key.
		///		fkGsAttchdDocFeeStudDisc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByFeeStudDiscId(System.Decimal? _feeStudDiscId, int start, int pageLength,out int count)
		{
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_FEE_STUD_DISC key.
		///		FK_GS_ATTCHD_DOC_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal? _feeStudDiscId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_PG_THESIS_STUD key.
		///		FK_GS_ATTCHD_DOC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByPgThesisStudId(System.Decimal? _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_PG_THESIS_STUD key.
		///		FK_GS_ATTCHD_DOC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_PG_THESIS_STUD key.
		///		FK_GS_ATTCHD_DOC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_PG_THESIS_STUD key.
		///		fkGsAttchdDocPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByPgThesisStudId(System.Decimal? _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_PG_THESIS_STUD key.
		///		fkGsAttchdDocPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetByPgThesisStudId(System.Decimal? _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_PG_THESIS_STUD key.
		///		FK_GS_ATTCHD_DOC_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal? _pgThesisStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_SV_MESSAGE key.
		///		FK_GS_ATTCHD_DOC_SV_MESSAGE Description: 
		/// </summary>
		/// <param name="_svMessageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetBySvMessageId(System.Decimal? _svMessageId)
		{
			int count = -1;
			return GetBySvMessageId(_svMessageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_SV_MESSAGE key.
		///		FK_GS_ATTCHD_DOC_SV_MESSAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsAttchdDoc> GetBySvMessageId(TransactionManager transactionManager, System.Decimal? _svMessageId)
		{
			int count = -1;
			return GetBySvMessageId(transactionManager, _svMessageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_SV_MESSAGE key.
		///		FK_GS_ATTCHD_DOC_SV_MESSAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetBySvMessageId(TransactionManager transactionManager, System.Decimal? _svMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvMessageId(transactionManager, _svMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_SV_MESSAGE key.
		///		fkGsAttchdDocSvMessage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svMessageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetBySvMessageId(System.Decimal? _svMessageId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvMessageId(null, _svMessageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_SV_MESSAGE key.
		///		fkGsAttchdDocSvMessage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svMessageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public TList<GsAttchdDoc> GetBySvMessageId(System.Decimal? _svMessageId, int start, int pageLength,out int count)
		{
			return GetBySvMessageId(null, _svMessageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ATTCHD_DOC_SV_MESSAGE key.
		///		FK_GS_ATTCHD_DOC_SV_MESSAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAttchdDoc objects.</returns>
		public abstract TList<GsAttchdDoc> GetBySvMessageId(TransactionManager transactionManager, System.Decimal? _svMessageId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsAttchdDoc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsAttchdDocKey key, int start, int pageLength)
		{
			return GetByGsAttchdDocId(transactionManager, key.GsAttchdDocId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_ATTCHD_DOC index.
		/// </summary>
		/// <param name="_gsAttchdDocId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsAttchdDoc GetByGsAttchdDocId(System.Decimal _gsAttchdDocId)
		{
			int count = -1;
			return GetByGsAttchdDocId(null,_gsAttchdDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_ATTCHD_DOC index.
		/// </summary>
		/// <param name="_gsAttchdDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsAttchdDoc GetByGsAttchdDocId(System.Decimal _gsAttchdDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsAttchdDocId(null, _gsAttchdDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_ATTCHD_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAttchdDocId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsAttchdDoc GetByGsAttchdDocId(TransactionManager transactionManager, System.Decimal _gsAttchdDocId)
		{
			int count = -1;
			return GetByGsAttchdDocId(transactionManager, _gsAttchdDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_ATTCHD_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAttchdDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsAttchdDoc GetByGsAttchdDocId(TransactionManager transactionManager, System.Decimal _gsAttchdDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsAttchdDocId(transactionManager, _gsAttchdDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_ATTCHD_DOC index.
		/// </summary>
		/// <param name="_gsAttchdDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsAttchdDoc GetByGsAttchdDocId(System.Decimal _gsAttchdDocId, int start, int pageLength, out int count)
		{
			return GetByGsAttchdDocId(null, _gsAttchdDocId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_ATTCHD_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAttchdDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsAttchdDoc GetByGsAttchdDocId(TransactionManager transactionManager, System.Decimal _gsAttchdDocId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsAttchdDoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsAttchdDoc&gt;"/></returns>
		public static TList<GsAttchdDoc> Fill(IDataReader reader, TList<GsAttchdDoc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsAttchdDoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsAttchdDoc")
					.Append("|").Append((System.Decimal)reader["GS_ATTCHD_DOC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsAttchdDoc>(
					key.ToString(), // EntityTrackingKey
					"GsAttchdDoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsAttchdDoc();
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
					c.GsAttchdDocId = (System.Decimal)reader["GS_ATTCHD_DOC_ID"];
					c.OriginalGsAttchdDocId = c.GsAttchdDocId;
					c.EdStudEnrollChangeId = Convert.IsDBNull(reader["ED_STUD_ENROLL_CHANGE_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ENROLL_CHANGE_ID"];
					c.EdStudCheatId = Convert.IsDBNull(reader["ED_STUD_CHEAT_ID"]) ? null : (System.Decimal?)reader["ED_STUD_CHEAT_ID"];
					c.AdmAppPlacementExamId = Convert.IsDBNull(reader["ADM_APP_PLACEMENT_EXAM_ID"]) ? null : (System.Decimal?)reader["ADM_APP_PLACEMENT_EXAM_ID"];
					c.AdmAppHonorId = Convert.IsDBNull(reader["ADM_APP_HONOR_ID"]) ? null : (System.Decimal?)reader["ADM_APP_HONOR_ID"];
					c.AdmAppInfoId = Convert.IsDBNull(reader["ADM_APP_INFO_ID"]) ? null : (System.Decimal?)reader["ADM_APP_INFO_ID"];
					c.SvMessageId = Convert.IsDBNull(reader["SV_MESSAGE_ID"]) ? null : (System.Decimal?)reader["SV_MESSAGE_ID"];
					c.EdStudCourseRegId = Convert.IsDBNull(reader["ED_STUD_COURSE_REG_ID"]) ? null : (System.Decimal?)reader["ED_STUD_COURSE_REG_ID"];
					c.FeeStudDiscId = Convert.IsDBNull(reader["FEE_STUD_DISC_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_DISC_ID"];
					c.EdExamStudAbsenceId = Convert.IsDBNull(reader["ED_EXAM_STUD_ABSENCE_ID"]) ? null : (System.Decimal?)reader["ED_EXAM_STUD_ABSENCE_ID"];
					c.EdStudCourseChngId = Convert.IsDBNull(reader["ED_STUD_COURSE_CHNG_ID"]) ? null : (System.Decimal?)reader["ED_STUD_COURSE_CHNG_ID"];
					c.EdStudCourseGrdChngId = Convert.IsDBNull(reader["ED_STUD_COURSE_GRD_CHNG_ID"]) ? null : (System.Decimal?)reader["ED_STUD_COURSE_GRD_CHNG_ID"];
					c.EdStudClrncReqId = Convert.IsDBNull(reader["ED_STUD_CLRNC_REQ_ID"]) ? null : (System.Decimal?)reader["ED_STUD_CLRNC_REQ_ID"];
					c.EdStudViolId = Convert.IsDBNull(reader["ED_STUD_VIOL_ID"]) ? null : (System.Decimal?)reader["ED_STUD_VIOL_ID"];
					c.EdStudViolInvestId = Convert.IsDBNull(reader["ED_STUD_VIOL_INVEST_ID"]) ? null : (System.Decimal?)reader["ED_STUD_VIOL_INVEST_ID"];
					c.EdStudViolAppealId = Convert.IsDBNull(reader["ED_STUD_VIOL_APPEAL_ID"]) ? null : (System.Decimal?)reader["ED_STUD_VIOL_APPEAL_ID"];
					c.AttchdDocPath = (System.String)reader["ATTCHD_DOC_PATH"];
					c.DocNotes = Convert.IsDBNull(reader["DOC_NOTES"]) ? null : (System.String)reader["DOC_NOTES"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.OrgDocAttached = Convert.IsDBNull(reader["ORG_DOC_ATTACHED"]) ? null : (System.Boolean?)reader["ORG_DOC_ATTACHED"];
					c.PgThesisStudId = Convert.IsDBNull(reader["PG_THESIS_STUD_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_STUD_ID"];
					c.EdGraduationAwardId = Convert.IsDBNull(reader["ED_GRADUATION_AWARD_ID"]) ? null : (System.Decimal?)reader["ED_GRADUATION_AWARD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsAttchdDoc entity)
		{
			if (!reader.Read()) return;
			
			entity.GsAttchdDocId = (System.Decimal)reader[((int)GsAttchdDocColumn.GsAttchdDocId - 1)];
			entity.OriginalGsAttchdDocId = (System.Decimal)reader["GS_ATTCHD_DOC_ID"];
			entity.EdStudEnrollChangeId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdStudEnrollChangeId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdStudEnrollChangeId - 1)];
			entity.EdStudCheatId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdStudCheatId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdStudCheatId - 1)];
			entity.AdmAppPlacementExamId = (reader.IsDBNull(((int)GsAttchdDocColumn.AdmAppPlacementExamId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.AdmAppPlacementExamId - 1)];
			entity.AdmAppHonorId = (reader.IsDBNull(((int)GsAttchdDocColumn.AdmAppHonorId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.AdmAppHonorId - 1)];
			entity.AdmAppInfoId = (reader.IsDBNull(((int)GsAttchdDocColumn.AdmAppInfoId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.AdmAppInfoId - 1)];
			entity.SvMessageId = (reader.IsDBNull(((int)GsAttchdDocColumn.SvMessageId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.SvMessageId - 1)];
			entity.EdStudCourseRegId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdStudCourseRegId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdStudCourseRegId - 1)];
			entity.FeeStudDiscId = (reader.IsDBNull(((int)GsAttchdDocColumn.FeeStudDiscId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.FeeStudDiscId - 1)];
			entity.EdExamStudAbsenceId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdExamStudAbsenceId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdExamStudAbsenceId - 1)];
			entity.EdStudCourseChngId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdStudCourseChngId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdStudCourseChngId - 1)];
			entity.EdStudCourseGrdChngId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdStudCourseGrdChngId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdStudCourseGrdChngId - 1)];
			entity.EdStudClrncReqId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdStudClrncReqId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdStudClrncReqId - 1)];
			entity.EdStudViolId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdStudViolId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdStudViolId - 1)];
			entity.EdStudViolInvestId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdStudViolInvestId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdStudViolInvestId - 1)];
			entity.EdStudViolAppealId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdStudViolAppealId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdStudViolAppealId - 1)];
			entity.AttchdDocPath = (System.String)reader[((int)GsAttchdDocColumn.AttchdDocPath - 1)];
			entity.DocNotes = (reader.IsDBNull(((int)GsAttchdDocColumn.DocNotes - 1)))?null:(System.String)reader[((int)GsAttchdDocColumn.DocNotes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)GsAttchdDocColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)GsAttchdDocColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)GsAttchdDocColumn.LastDate - 1)];
			entity.OrgDocAttached = (reader.IsDBNull(((int)GsAttchdDocColumn.OrgDocAttached - 1)))?null:(System.Boolean?)reader[((int)GsAttchdDocColumn.OrgDocAttached - 1)];
			entity.PgThesisStudId = (reader.IsDBNull(((int)GsAttchdDocColumn.PgThesisStudId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.PgThesisStudId - 1)];
			entity.EdGraduationAwardId = (reader.IsDBNull(((int)GsAttchdDocColumn.EdGraduationAwardId - 1)))?null:(System.Decimal?)reader[((int)GsAttchdDocColumn.EdGraduationAwardId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsAttchdDoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsAttchdDocId = (System.Decimal)dataRow["GS_ATTCHD_DOC_ID"];
			entity.OriginalGsAttchdDocId = (System.Decimal)dataRow["GS_ATTCHD_DOC_ID"];
			entity.EdStudEnrollChangeId = Convert.IsDBNull(dataRow["ED_STUD_ENROLL_CHANGE_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ENROLL_CHANGE_ID"];
			entity.EdStudCheatId = Convert.IsDBNull(dataRow["ED_STUD_CHEAT_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_CHEAT_ID"];
			entity.AdmAppPlacementExamId = Convert.IsDBNull(dataRow["ADM_APP_PLACEMENT_EXAM_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_PLACEMENT_EXAM_ID"];
			entity.AdmAppHonorId = Convert.IsDBNull(dataRow["ADM_APP_HONOR_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_HONOR_ID"];
			entity.AdmAppInfoId = Convert.IsDBNull(dataRow["ADM_APP_INFO_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_INFO_ID"];
			entity.SvMessageId = Convert.IsDBNull(dataRow["SV_MESSAGE_ID"]) ? null : (System.Decimal?)dataRow["SV_MESSAGE_ID"];
			entity.EdStudCourseRegId = Convert.IsDBNull(dataRow["ED_STUD_COURSE_REG_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.FeeStudDiscId = Convert.IsDBNull(dataRow["FEE_STUD_DISC_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_DISC_ID"];
			entity.EdExamStudAbsenceId = Convert.IsDBNull(dataRow["ED_EXAM_STUD_ABSENCE_ID"]) ? null : (System.Decimal?)dataRow["ED_EXAM_STUD_ABSENCE_ID"];
			entity.EdStudCourseChngId = Convert.IsDBNull(dataRow["ED_STUD_COURSE_CHNG_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_COURSE_CHNG_ID"];
			entity.EdStudCourseGrdChngId = Convert.IsDBNull(dataRow["ED_STUD_COURSE_GRD_CHNG_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_COURSE_GRD_CHNG_ID"];
			entity.EdStudClrncReqId = Convert.IsDBNull(dataRow["ED_STUD_CLRNC_REQ_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_CLRNC_REQ_ID"];
			entity.EdStudViolId = Convert.IsDBNull(dataRow["ED_STUD_VIOL_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_VIOL_ID"];
			entity.EdStudViolInvestId = Convert.IsDBNull(dataRow["ED_STUD_VIOL_INVEST_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_VIOL_INVEST_ID"];
			entity.EdStudViolAppealId = Convert.IsDBNull(dataRow["ED_STUD_VIOL_APPEAL_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_VIOL_APPEAL_ID"];
			entity.AttchdDocPath = (System.String)dataRow["ATTCHD_DOC_PATH"];
			entity.DocNotes = Convert.IsDBNull(dataRow["DOC_NOTES"]) ? null : (System.String)dataRow["DOC_NOTES"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.OrgDocAttached = Convert.IsDBNull(dataRow["ORG_DOC_ATTACHED"]) ? null : (System.Boolean?)dataRow["ORG_DOC_ATTACHED"];
			entity.PgThesisStudId = Convert.IsDBNull(dataRow["PG_THESIS_STUD_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_STUD_ID"];
			entity.EdGraduationAwardId = Convert.IsDBNull(dataRow["ED_GRADUATION_AWARD_ID"]) ? null : (System.Decimal?)dataRow["ED_GRADUATION_AWARD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsAttchdDoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsAttchdDoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsAttchdDoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppHonorIdSource	
			if (CanDeepLoad(entity, "AdmAppHonor|AdmAppHonorIdSource", deepLoadType, innerList) 
				&& entity.AdmAppHonorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppHonorId ?? 0.0m);
				AdmAppHonor tmpEntity = EntityManager.LocateEntity<AdmAppHonor>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppHonor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppHonorIdSource = tmpEntity;
				else
					entity.AdmAppHonorIdSource = DataRepository.AdmAppHonorProvider.GetByAdmAppHonorId(transactionManager, (entity.AdmAppHonorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppHonorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppHonorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppHonorProvider.DeepLoad(transactionManager, entity.AdmAppHonorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppHonorIdSource

			#region AdmAppInfoIdSource	
			if (CanDeepLoad(entity, "AdmAppInfo|AdmAppInfoIdSource", deepLoadType, innerList) 
				&& entity.AdmAppInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppInfoId ?? 0.0m);
				AdmAppInfo tmpEntity = EntityManager.LocateEntity<AdmAppInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppInfoIdSource = tmpEntity;
				else
					entity.AdmAppInfoIdSource = DataRepository.AdmAppInfoProvider.GetByAdmAppInfoId(transactionManager, (entity.AdmAppInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppInfoProvider.DeepLoad(transactionManager, entity.AdmAppInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppInfoIdSource

			#region AdmAppPlacementExamIdSource	
			if (CanDeepLoad(entity, "AdmAppPlacementExam|AdmAppPlacementExamIdSource", deepLoadType, innerList) 
				&& entity.AdmAppPlacementExamIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppPlacementExamId ?? 0.0m);
				AdmAppPlacementExam tmpEntity = EntityManager.LocateEntity<AdmAppPlacementExam>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppPlacementExam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppPlacementExamIdSource = tmpEntity;
				else
					entity.AdmAppPlacementExamIdSource = DataRepository.AdmAppPlacementExamProvider.GetByAdmAppPlacementExamId(transactionManager, (entity.AdmAppPlacementExamId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPlacementExamIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppPlacementExamIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppPlacementExamProvider.DeepLoad(transactionManager, entity.AdmAppPlacementExamIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppPlacementExamIdSource

			#region EdExamStudAbsenceIdSource	
			if (CanDeepLoad(entity, "EdExamStudAbsence|EdExamStudAbsenceIdSource", deepLoadType, innerList) 
				&& entity.EdExamStudAbsenceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdExamStudAbsenceId ?? 0.0m);
				EdExamStudAbsence tmpEntity = EntityManager.LocateEntity<EdExamStudAbsence>(EntityLocator.ConstructKeyFromPkItems(typeof(EdExamStudAbsence), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdExamStudAbsenceIdSource = tmpEntity;
				else
					entity.EdExamStudAbsenceIdSource = DataRepository.EdExamStudAbsenceProvider.GetByEdExamStudAbsenceId(transactionManager, (entity.EdExamStudAbsenceId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamStudAbsenceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdExamStudAbsenceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdExamStudAbsenceProvider.DeepLoad(transactionManager, entity.EdExamStudAbsenceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdExamStudAbsenceIdSource

			#region EdGraduationAwardIdSource	
			if (CanDeepLoad(entity, "EdGraduationAward|EdGraduationAwardIdSource", deepLoadType, innerList) 
				&& entity.EdGraduationAwardIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdGraduationAwardId ?? 0.0m);
				EdGraduationAward tmpEntity = EntityManager.LocateEntity<EdGraduationAward>(EntityLocator.ConstructKeyFromPkItems(typeof(EdGraduationAward), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdGraduationAwardIdSource = tmpEntity;
				else
					entity.EdGraduationAwardIdSource = DataRepository.EdGraduationAwardProvider.GetByEdGraduationAwardId(transactionManager, (entity.EdGraduationAwardId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGraduationAwardIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdGraduationAwardIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdGraduationAwardProvider.DeepLoad(transactionManager, entity.EdGraduationAwardIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdGraduationAwardIdSource

			#region EdStudCheatIdSource	
			if (CanDeepLoad(entity, "EdStudCheat|EdStudCheatIdSource", deepLoadType, innerList) 
				&& entity.EdStudCheatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudCheatId ?? 0.0m);
				EdStudCheat tmpEntity = EntityManager.LocateEntity<EdStudCheat>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCheat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCheatIdSource = tmpEntity;
				else
					entity.EdStudCheatIdSource = DataRepository.EdStudCheatProvider.GetByEdStudCheatId(transactionManager, (entity.EdStudCheatId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCheatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCheatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCheatProvider.DeepLoad(transactionManager, entity.EdStudCheatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCheatIdSource

			#region EdStudClrncReqIdSource	
			if (CanDeepLoad(entity, "EdStudClrncReq|EdStudClrncReqIdSource", deepLoadType, innerList) 
				&& entity.EdStudClrncReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudClrncReqId ?? 0.0m);
				EdStudClrncReq tmpEntity = EntityManager.LocateEntity<EdStudClrncReq>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudClrncReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudClrncReqIdSource = tmpEntity;
				else
					entity.EdStudClrncReqIdSource = DataRepository.EdStudClrncReqProvider.GetByEdStudClrncReqId(transactionManager, (entity.EdStudClrncReqId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudClrncReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudClrncReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudClrncReqProvider.DeepLoad(transactionManager, entity.EdStudClrncReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudClrncReqIdSource

			#region EdStudCourseChngIdSource	
			if (CanDeepLoad(entity, "EdStudCourseChng|EdStudCourseChngIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseChngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudCourseChngId ?? 0.0m);
				EdStudCourseChng tmpEntity = EntityManager.LocateEntity<EdStudCourseChng>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseChng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseChngIdSource = tmpEntity;
				else
					entity.EdStudCourseChngIdSource = DataRepository.EdStudCourseChngProvider.GetByEdStudCourseChngId(transactionManager, (entity.EdStudCourseChngId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseChngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseChngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseChngProvider.DeepLoad(transactionManager, entity.EdStudCourseChngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseChngIdSource

			#region EdStudCourseGrdChngIdSource	
			if (CanDeepLoad(entity, "EdStudCourseGrdChng|EdStudCourseGrdChngIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseGrdChngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudCourseGrdChngId ?? 0.0m);
				EdStudCourseGrdChng tmpEntity = EntityManager.LocateEntity<EdStudCourseGrdChng>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseGrdChng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseGrdChngIdSource = tmpEntity;
				else
					entity.EdStudCourseGrdChngIdSource = DataRepository.EdStudCourseGrdChngProvider.GetByEdStudCourseGrdChngId(transactionManager, (entity.EdStudCourseGrdChngId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseGrdChngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseGrdChngProvider.DeepLoad(transactionManager, entity.EdStudCourseGrdChngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseGrdChngIdSource

			#region EdStudCourseRegIdSource	
			if (CanDeepLoad(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseRegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudCourseRegId ?? 0.0m);
				EdStudCourseReg tmpEntity = EntityManager.LocateEntity<EdStudCourseReg>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseReg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseRegIdSource = tmpEntity;
				else
					entity.EdStudCourseRegIdSource = DataRepository.EdStudCourseRegProvider.GetByEdStudCourseRegId(transactionManager, (entity.EdStudCourseRegId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseRegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseRegProvider.DeepLoad(transactionManager, entity.EdStudCourseRegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseRegIdSource

			#region EdStudEnrollChangeIdSource	
			if (CanDeepLoad(entity, "EdStudEnrollChange|EdStudEnrollChangeIdSource", deepLoadType, innerList) 
				&& entity.EdStudEnrollChangeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudEnrollChangeId ?? 0.0m);
				EdStudEnrollChange tmpEntity = EntityManager.LocateEntity<EdStudEnrollChange>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudEnrollChange), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudEnrollChangeIdSource = tmpEntity;
				else
					entity.EdStudEnrollChangeIdSource = DataRepository.EdStudEnrollChangeProvider.GetByEdStudEnrollChangeId(transactionManager, (entity.EdStudEnrollChangeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudEnrollChangeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudEnrollChangeProvider.DeepLoad(transactionManager, entity.EdStudEnrollChangeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudEnrollChangeIdSource

			#region EdStudViolIdSource	
			if (CanDeepLoad(entity, "EdStudViol|EdStudViolIdSource", deepLoadType, innerList) 
				&& entity.EdStudViolIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudViolId ?? 0.0m);
				EdStudViol tmpEntity = EntityManager.LocateEntity<EdStudViol>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudViol), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudViolIdSource = tmpEntity;
				else
					entity.EdStudViolIdSource = DataRepository.EdStudViolProvider.GetByEdStudViolId(transactionManager, (entity.EdStudViolId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudViolIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudViolProvider.DeepLoad(transactionManager, entity.EdStudViolIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudViolIdSource

			#region EdStudViolAppealIdSource	
			if (CanDeepLoad(entity, "EdStudViolAppeal|EdStudViolAppealIdSource", deepLoadType, innerList) 
				&& entity.EdStudViolAppealIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudViolAppealId ?? 0.0m);
				EdStudViolAppeal tmpEntity = EntityManager.LocateEntity<EdStudViolAppeal>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudViolAppeal), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudViolAppealIdSource = tmpEntity;
				else
					entity.EdStudViolAppealIdSource = DataRepository.EdStudViolAppealProvider.GetByEdStudViolAppealId(transactionManager, (entity.EdStudViolAppealId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolAppealIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudViolAppealIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudViolAppealProvider.DeepLoad(transactionManager, entity.EdStudViolAppealIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudViolAppealIdSource

			#region EdStudViolInvestIdSource	
			if (CanDeepLoad(entity, "EdStudViol|EdStudViolInvestIdSource", deepLoadType, innerList) 
				&& entity.EdStudViolInvestIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudViolInvestId ?? 0.0m);
				EdStudViol tmpEntity = EntityManager.LocateEntity<EdStudViol>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudViol), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudViolInvestIdSource = tmpEntity;
				else
					entity.EdStudViolInvestIdSource = DataRepository.EdStudViolProvider.GetByEdStudViolId(transactionManager, (entity.EdStudViolInvestId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolInvestIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudViolInvestIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudViolProvider.DeepLoad(transactionManager, entity.EdStudViolInvestIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudViolInvestIdSource

			#region FeeStudDiscIdSource	
			if (CanDeepLoad(entity, "FeeStudDisc|FeeStudDiscIdSource", deepLoadType, innerList) 
				&& entity.FeeStudDiscIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudDiscId ?? 0.0m);
				FeeStudDisc tmpEntity = EntityManager.LocateEntity<FeeStudDisc>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudDisc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudDiscIdSource = tmpEntity;
				else
					entity.FeeStudDiscIdSource = DataRepository.FeeStudDiscProvider.GetByFeeStudDiscId(transactionManager, (entity.FeeStudDiscId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudDiscIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudDiscProvider.DeepLoad(transactionManager, entity.FeeStudDiscIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudDiscIdSource

			#region PgThesisStudIdSource	
			if (CanDeepLoad(entity, "PgThesisStud|PgThesisStudIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisStudId ?? 0.0m);
				PgThesisStud tmpEntity = EntityManager.LocateEntity<PgThesisStud>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudIdSource = tmpEntity;
				else
					entity.PgThesisStudIdSource = DataRepository.PgThesisStudProvider.GetByPgThesisStudId(transactionManager, (entity.PgThesisStudId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudProvider.DeepLoad(transactionManager, entity.PgThesisStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudIdSource

			#region SvMessageIdSource	
			if (CanDeepLoad(entity, "SvMessage|SvMessageIdSource", deepLoadType, innerList) 
				&& entity.SvMessageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvMessageId ?? 0.0m);
				SvMessage tmpEntity = EntityManager.LocateEntity<SvMessage>(EntityLocator.ConstructKeyFromPkItems(typeof(SvMessage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvMessageIdSource = tmpEntity;
				else
					entity.SvMessageIdSource = DataRepository.SvMessageProvider.GetBySvMessageId(transactionManager, (entity.SvMessageId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMessageIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvMessageIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvMessageProvider.DeepLoad(transactionManager, entity.SvMessageIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvMessageIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsAttchdDoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsAttchdDoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsAttchdDoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsAttchdDoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppHonorIdSource
			if (CanDeepSave(entity, "AdmAppHonor|AdmAppHonorIdSource", deepSaveType, innerList) 
				&& entity.AdmAppHonorIdSource != null)
			{
				DataRepository.AdmAppHonorProvider.Save(transactionManager, entity.AdmAppHonorIdSource);
				entity.AdmAppHonorId = entity.AdmAppHonorIdSource.AdmAppHonorId;
			}
			#endregion 
			
			#region AdmAppInfoIdSource
			if (CanDeepSave(entity, "AdmAppInfo|AdmAppInfoIdSource", deepSaveType, innerList) 
				&& entity.AdmAppInfoIdSource != null)
			{
				DataRepository.AdmAppInfoProvider.Save(transactionManager, entity.AdmAppInfoIdSource);
				entity.AdmAppInfoId = entity.AdmAppInfoIdSource.AdmAppInfoId;
			}
			#endregion 
			
			#region AdmAppPlacementExamIdSource
			if (CanDeepSave(entity, "AdmAppPlacementExam|AdmAppPlacementExamIdSource", deepSaveType, innerList) 
				&& entity.AdmAppPlacementExamIdSource != null)
			{
				DataRepository.AdmAppPlacementExamProvider.Save(transactionManager, entity.AdmAppPlacementExamIdSource);
				entity.AdmAppPlacementExamId = entity.AdmAppPlacementExamIdSource.AdmAppPlacementExamId;
			}
			#endregion 
			
			#region EdExamStudAbsenceIdSource
			if (CanDeepSave(entity, "EdExamStudAbsence|EdExamStudAbsenceIdSource", deepSaveType, innerList) 
				&& entity.EdExamStudAbsenceIdSource != null)
			{
				DataRepository.EdExamStudAbsenceProvider.Save(transactionManager, entity.EdExamStudAbsenceIdSource);
				entity.EdExamStudAbsenceId = entity.EdExamStudAbsenceIdSource.EdExamStudAbsenceId;
			}
			#endregion 
			
			#region EdGraduationAwardIdSource
			if (CanDeepSave(entity, "EdGraduationAward|EdGraduationAwardIdSource", deepSaveType, innerList) 
				&& entity.EdGraduationAwardIdSource != null)
			{
				DataRepository.EdGraduationAwardProvider.Save(transactionManager, entity.EdGraduationAwardIdSource);
				entity.EdGraduationAwardId = entity.EdGraduationAwardIdSource.EdGraduationAwardId;
			}
			#endregion 
			
			#region EdStudCheatIdSource
			if (CanDeepSave(entity, "EdStudCheat|EdStudCheatIdSource", deepSaveType, innerList) 
				&& entity.EdStudCheatIdSource != null)
			{
				DataRepository.EdStudCheatProvider.Save(transactionManager, entity.EdStudCheatIdSource);
				entity.EdStudCheatId = entity.EdStudCheatIdSource.EdStudCheatId;
			}
			#endregion 
			
			#region EdStudClrncReqIdSource
			if (CanDeepSave(entity, "EdStudClrncReq|EdStudClrncReqIdSource", deepSaveType, innerList) 
				&& entity.EdStudClrncReqIdSource != null)
			{
				DataRepository.EdStudClrncReqProvider.Save(transactionManager, entity.EdStudClrncReqIdSource);
				entity.EdStudClrncReqId = entity.EdStudClrncReqIdSource.EdStudClrncReqId;
			}
			#endregion 
			
			#region EdStudCourseChngIdSource
			if (CanDeepSave(entity, "EdStudCourseChng|EdStudCourseChngIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseChngIdSource != null)
			{
				DataRepository.EdStudCourseChngProvider.Save(transactionManager, entity.EdStudCourseChngIdSource);
				entity.EdStudCourseChngId = entity.EdStudCourseChngIdSource.EdStudCourseChngId;
			}
			#endregion 
			
			#region EdStudCourseGrdChngIdSource
			if (CanDeepSave(entity, "EdStudCourseGrdChng|EdStudCourseGrdChngIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseGrdChngIdSource != null)
			{
				DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngIdSource);
				entity.EdStudCourseGrdChngId = entity.EdStudCourseGrdChngIdSource.EdStudCourseGrdChngId;
			}
			#endregion 
			
			#region EdStudCourseRegIdSource
			if (CanDeepSave(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseRegIdSource != null)
			{
				DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegIdSource);
				entity.EdStudCourseRegId = entity.EdStudCourseRegIdSource.EdStudCourseRegId;
			}
			#endregion 
			
			#region EdStudEnrollChangeIdSource
			if (CanDeepSave(entity, "EdStudEnrollChange|EdStudEnrollChangeIdSource", deepSaveType, innerList) 
				&& entity.EdStudEnrollChangeIdSource != null)
			{
				DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeIdSource);
				entity.EdStudEnrollChangeId = entity.EdStudEnrollChangeIdSource.EdStudEnrollChangeId;
			}
			#endregion 
			
			#region EdStudViolIdSource
			if (CanDeepSave(entity, "EdStudViol|EdStudViolIdSource", deepSaveType, innerList) 
				&& entity.EdStudViolIdSource != null)
			{
				DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolIdSource);
				entity.EdStudViolId = entity.EdStudViolIdSource.EdStudViolId;
			}
			#endregion 
			
			#region EdStudViolAppealIdSource
			if (CanDeepSave(entity, "EdStudViolAppeal|EdStudViolAppealIdSource", deepSaveType, innerList) 
				&& entity.EdStudViolAppealIdSource != null)
			{
				DataRepository.EdStudViolAppealProvider.Save(transactionManager, entity.EdStudViolAppealIdSource);
				entity.EdStudViolAppealId = entity.EdStudViolAppealIdSource.EdStudViolAppealId;
			}
			#endregion 
			
			#region EdStudViolInvestIdSource
			if (CanDeepSave(entity, "EdStudViol|EdStudViolInvestIdSource", deepSaveType, innerList) 
				&& entity.EdStudViolInvestIdSource != null)
			{
				DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolInvestIdSource);
				entity.EdStudViolInvestId = entity.EdStudViolInvestIdSource.EdStudViolId;
			}
			#endregion 
			
			#region FeeStudDiscIdSource
			if (CanDeepSave(entity, "FeeStudDisc|FeeStudDiscIdSource", deepSaveType, innerList) 
				&& entity.FeeStudDiscIdSource != null)
			{
				DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscIdSource);
				entity.FeeStudDiscId = entity.FeeStudDiscIdSource.FeeStudDiscId;
			}
			#endregion 
			
			#region PgThesisStudIdSource
			if (CanDeepSave(entity, "PgThesisStud|PgThesisStudIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudIdSource != null)
			{
				DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudIdSource);
				entity.PgThesisStudId = entity.PgThesisStudIdSource.PgThesisStudId;
			}
			#endregion 
			
			#region SvMessageIdSource
			if (CanDeepSave(entity, "SvMessage|SvMessageIdSource", deepSaveType, innerList) 
				&& entity.SvMessageIdSource != null)
			{
				DataRepository.SvMessageProvider.Save(transactionManager, entity.SvMessageIdSource);
				entity.SvMessageId = entity.SvMessageIdSource.SvMessageId;
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
	
	#region GsAttchdDocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsAttchdDoc</c>
	///</summary>
	public enum GsAttchdDocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppHonor</c> at AdmAppHonorIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppHonor))]
		AdmAppHonor,
		
		///<summary>
		/// Composite Property for <c>AdmAppInfo</c> at AdmAppInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppInfo))]
		AdmAppInfo,
		
		///<summary>
		/// Composite Property for <c>AdmAppPlacementExam</c> at AdmAppPlacementExamIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppPlacementExam))]
		AdmAppPlacementExam,
		
		///<summary>
		/// Composite Property for <c>EdExamStudAbsence</c> at EdExamStudAbsenceIdSource
		///</summary>
		[ChildEntityType(typeof(EdExamStudAbsence))]
		EdExamStudAbsence,
		
		///<summary>
		/// Composite Property for <c>EdGraduationAward</c> at EdGraduationAwardIdSource
		///</summary>
		[ChildEntityType(typeof(EdGraduationAward))]
		EdGraduationAward,
		
		///<summary>
		/// Composite Property for <c>EdStudCheat</c> at EdStudCheatIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCheat))]
		EdStudCheat,
		
		///<summary>
		/// Composite Property for <c>EdStudClrncReq</c> at EdStudClrncReqIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudClrncReq))]
		EdStudClrncReq,
		
		///<summary>
		/// Composite Property for <c>EdStudCourseChng</c> at EdStudCourseChngIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseChng))]
		EdStudCourseChng,
		
		///<summary>
		/// Composite Property for <c>EdStudCourseGrdChng</c> at EdStudCourseGrdChngIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseGrdChng))]
		EdStudCourseGrdChng,
		
		///<summary>
		/// Composite Property for <c>EdStudCourseReg</c> at EdStudCourseRegIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseReg))]
		EdStudCourseReg,
		
		///<summary>
		/// Composite Property for <c>EdStudEnrollChange</c> at EdStudEnrollChangeIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudEnrollChange))]
		EdStudEnrollChange,
		
		///<summary>
		/// Composite Property for <c>EdStudViol</c> at EdStudViolIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudViol))]
		EdStudViol,
		
		///<summary>
		/// Composite Property for <c>EdStudViolAppeal</c> at EdStudViolAppealIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudViolAppeal))]
		EdStudViolAppeal,
		
		///<summary>
		/// Composite Property for <c>FeeStudDisc</c> at FeeStudDiscIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudDisc))]
		FeeStudDisc,
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		
		///<summary>
		/// Composite Property for <c>SvMessage</c> at SvMessageIdSource
		///</summary>
		[ChildEntityType(typeof(SvMessage))]
		SvMessage,
	}
	
	#endregion GsAttchdDocChildEntityTypes
	
	#region GsAttchdDocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsAttchdDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsAttchdDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsAttchdDocFilterBuilder : SqlFilterBuilder<GsAttchdDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsAttchdDocFilterBuilder class.
		/// </summary>
		public GsAttchdDocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsAttchdDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsAttchdDocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsAttchdDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsAttchdDocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsAttchdDocFilterBuilder
	
	#region GsAttchdDocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsAttchdDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsAttchdDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsAttchdDocParameterBuilder : ParameterizedSqlFilterBuilder<GsAttchdDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsAttchdDocParameterBuilder class.
		/// </summary>
		public GsAttchdDocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsAttchdDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsAttchdDocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsAttchdDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsAttchdDocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsAttchdDocParameterBuilder
	
	#region GsAttchdDocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsAttchdDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsAttchdDoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsAttchdDocSortBuilder : SqlSortBuilder<GsAttchdDocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsAttchdDocSqlSortBuilder class.
		/// </summary>
		public GsAttchdDocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsAttchdDocSortBuilder
	
} // end namespace
