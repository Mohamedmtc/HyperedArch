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
	/// This class is the base class for any <see cref="AdmAppInterviewExamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppInterviewExamProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppInterviewExam, UMIS_VER2.BusinessLyer.AdmAppInterviewExamKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppInterviewExamKey key)
		{
			return Delete(transactionManager, key.AdmAppInterviewExamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppInterviewExamId">اختبار انترفيو  لكل رغبة للمتقدم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppInterviewExamId)
		{
			return Delete(null, _admAppInterviewExamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppInterviewExamId">اختبار انترفيو  لكل رغبة للمتقدم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppInterviewExamId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppInterviewExam> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_APP_REG_HISTORY key.
		///		fkAdmAppInterviewExamAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_APP_REG_HISTORY key.
		///		fkAdmAppInterviewExamAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public abstract TList<AdmAppInterviewExam> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="_admCdePlacementExamId">interview_flg=1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(_admCdePlacementExamId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">interview_flg=1</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppInterviewExam> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">interview_flg=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdePlacementExamId(transactionManager, _admCdePlacementExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmAppInterviewExamAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId">interview_flg=1</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		fkAdmAppInterviewExamAdmCdePlacementExam Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdePlacementExamId">interview_flg=1</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByAdmCdePlacementExamId(System.Decimal _admCdePlacementExamId, int start, int pageLength,out int count)
		{
			return GetByAdmCdePlacementExamId(null, _admCdePlacementExamId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ADM_CDE_PLACEMENT_EXAM key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ADM_CDE_PLACEMENT_EXAM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdePlacementExamId">interview_flg=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public abstract TList<AdmAppInterviewExam> GetByAdmCdePlacementExamId(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ENTITY_MAIN key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">التخصص-  تاب الرغبات</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ENTITY_MAIN key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">التخصص-  تاب الرغبات</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppInterviewExam> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ENTITY_MAIN key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">التخصص-  تاب الرغبات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ENTITY_MAIN key.
		///		fkAdmAppInterviewExamEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">التخصص-  تاب الرغبات</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ENTITY_MAIN key.
		///		fkAdmAppInterviewExamEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">التخصص-  تاب الرغبات</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_ENTITY_MAIN key.
		///		FK_ADM_APP_INTERVIEW_EXAM_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">التخصص-  تاب الرغبات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public abstract TList<AdmAppInterviewExam> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_SA_STF_MEMBER key.
		///		FK_ADM_APP_INTERVIEW_EXAM_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId">EjustPGINTER</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_SA_STF_MEMBER key.
		///		FK_ADM_APP_INTERVIEW_EXAM_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">EjustPGINTER</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppInterviewExam> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_SA_STF_MEMBER key.
		///		FK_ADM_APP_INTERVIEW_EXAM_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">EjustPGINTER</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_SA_STF_MEMBER key.
		///		fkAdmAppInterviewExamSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId">EjustPGINTER</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_SA_STF_MEMBER key.
		///		fkAdmAppInterviewExamSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId">EjustPGINTER</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public TList<AdmAppInterviewExam> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_INTERVIEW_EXAM_SA_STF_MEMBER key.
		///		FK_ADM_APP_INTERVIEW_EXAM_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">EjustPGINTER</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppInterviewExam objects.</returns>
		public abstract TList<AdmAppInterviewExam> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppInterviewExam Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppInterviewExamKey key, int start, int pageLength)
		{
			return GetByAdmAppInterviewExamId(transactionManager, key.AdmAppInterviewExamId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_INTERVIEW_EXAM index.
		/// </summary>
		/// <param name="_admAppInterviewExamId">اختبار انترفيو  لكل رغبة للمتقدم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppInterviewExam GetByAdmAppInterviewExamId(System.Decimal _admAppInterviewExamId)
		{
			int count = -1;
			return GetByAdmAppInterviewExamId(null,_admAppInterviewExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_INTERVIEW_EXAM index.
		/// </summary>
		/// <param name="_admAppInterviewExamId">اختبار انترفيو  لكل رغبة للمتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppInterviewExam GetByAdmAppInterviewExamId(System.Decimal _admAppInterviewExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppInterviewExamId(null, _admAppInterviewExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_INTERVIEW_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppInterviewExamId">اختبار انترفيو  لكل رغبة للمتقدم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppInterviewExam GetByAdmAppInterviewExamId(TransactionManager transactionManager, System.Decimal _admAppInterviewExamId)
		{
			int count = -1;
			return GetByAdmAppInterviewExamId(transactionManager, _admAppInterviewExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_INTERVIEW_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppInterviewExamId">اختبار انترفيو  لكل رغبة للمتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppInterviewExam GetByAdmAppInterviewExamId(TransactionManager transactionManager, System.Decimal _admAppInterviewExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppInterviewExamId(transactionManager, _admAppInterviewExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_INTERVIEW_EXAM index.
		/// </summary>
		/// <param name="_admAppInterviewExamId">اختبار انترفيو  لكل رغبة للمتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppInterviewExam GetByAdmAppInterviewExamId(System.Decimal _admAppInterviewExamId, int start, int pageLength, out int count)
		{
			return GetByAdmAppInterviewExamId(null, _admAppInterviewExamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_INTERVIEW_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppInterviewExamId">اختبار انترفيو  لكل رغبة للمتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppInterviewExam GetByAdmAppInterviewExamId(TransactionManager transactionManager, System.Decimal _admAppInterviewExamId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppInterviewExam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppInterviewExam&gt;"/></returns>
		public static TList<AdmAppInterviewExam> Fill(IDataReader reader, TList<AdmAppInterviewExam> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppInterviewExam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppInterviewExam")
					.Append("|").Append((System.Decimal)reader["ADM_APP_INTERVIEW_EXAM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppInterviewExam>(
					key.ToString(), // EntityTrackingKey
					"AdmAppInterviewExam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppInterviewExam();
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
					c.AdmAppInterviewExamId = (System.Decimal)reader["ADM_APP_INTERVIEW_EXAM_ID"];
					c.OriginalAdmAppInterviewExamId = c.AdmAppInterviewExamId;
					c.AdmAppRegHistoryId = (System.Decimal)reader["ADM_APP_REG_HISTORY_ID"];
					c.AdmCdePlacementExamId = (System.Decimal)reader["ADM_CDE_PLACEMENT_EXAM_ID"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.ExamDate = (System.DateTime)reader["EXAM_DATE"];
					c.TimeFrom = Convert.IsDBNull(reader["TIME_FROM"]) ? null : (System.DateTime?)reader["TIME_FROM"];
					c.TimeTo = Convert.IsDBNull(reader["TIME_TO"]) ? null : (System.DateTime?)reader["TIME_TO"];
					c.Location = Convert.IsDBNull(reader["LOCATION"]) ? null : (System.String)reader["LOCATION"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.Mark = Convert.IsDBNull(reader["MARK"]) ? null : (System.Decimal?)reader["MARK"];
					c.PassFlg = Convert.IsDBNull(reader["PASS_FLG"]) ? null : (System.Decimal?)reader["PASS_FLG"];
					c.AbsFlg = Convert.IsDBNull(reader["ABS_FLG"]) ? null : (System.Boolean?)reader["ABS_FLG"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Boolean?)reader["APPROVE_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppInterviewExam entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppInterviewExamId = (System.Decimal)reader[((int)AdmAppInterviewExamColumn.AdmAppInterviewExamId - 1)];
			entity.OriginalAdmAppInterviewExamId = (System.Decimal)reader["ADM_APP_INTERVIEW_EXAM_ID"];
			entity.AdmAppRegHistoryId = (System.Decimal)reader[((int)AdmAppInterviewExamColumn.AdmAppRegHistoryId - 1)];
			entity.AdmCdePlacementExamId = (System.Decimal)reader[((int)AdmAppInterviewExamColumn.AdmCdePlacementExamId - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)AdmAppInterviewExamColumn.EntMainId - 1)];
			entity.ExamDate = (System.DateTime)reader[((int)AdmAppInterviewExamColumn.ExamDate - 1)];
			entity.TimeFrom = (reader.IsDBNull(((int)AdmAppInterviewExamColumn.TimeFrom - 1)))?null:(System.DateTime?)reader[((int)AdmAppInterviewExamColumn.TimeFrom - 1)];
			entity.TimeTo = (reader.IsDBNull(((int)AdmAppInterviewExamColumn.TimeTo - 1)))?null:(System.DateTime?)reader[((int)AdmAppInterviewExamColumn.TimeTo - 1)];
			entity.Location = (reader.IsDBNull(((int)AdmAppInterviewExamColumn.Location - 1)))?null:(System.String)reader[((int)AdmAppInterviewExamColumn.Location - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)AdmAppInterviewExamColumn.SaStfMemberId - 1)];
			entity.Mark = (reader.IsDBNull(((int)AdmAppInterviewExamColumn.Mark - 1)))?null:(System.Decimal?)reader[((int)AdmAppInterviewExamColumn.Mark - 1)];
			entity.PassFlg = (reader.IsDBNull(((int)AdmAppInterviewExamColumn.PassFlg - 1)))?null:(System.Decimal?)reader[((int)AdmAppInterviewExamColumn.PassFlg - 1)];
			entity.AbsFlg = (reader.IsDBNull(((int)AdmAppInterviewExamColumn.AbsFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppInterviewExamColumn.AbsFlg - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)AdmAppInterviewExamColumn.ApproveFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppInterviewExamColumn.ApproveFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmAppInterviewExamColumn.Notes - 1)))?null:(System.String)reader[((int)AdmAppInterviewExamColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppInterviewExamColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppInterviewExamColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppInterviewExamColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppInterviewExamColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppInterviewExam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppInterviewExamId = (System.Decimal)dataRow["ADM_APP_INTERVIEW_EXAM_ID"];
			entity.OriginalAdmAppInterviewExamId = (System.Decimal)dataRow["ADM_APP_INTERVIEW_EXAM_ID"];
			entity.AdmAppRegHistoryId = (System.Decimal)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.AdmCdePlacementExamId = (System.Decimal)dataRow["ADM_CDE_PLACEMENT_EXAM_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.ExamDate = (System.DateTime)dataRow["EXAM_DATE"];
			entity.TimeFrom = Convert.IsDBNull(dataRow["TIME_FROM"]) ? null : (System.DateTime?)dataRow["TIME_FROM"];
			entity.TimeTo = Convert.IsDBNull(dataRow["TIME_TO"]) ? null : (System.DateTime?)dataRow["TIME_TO"];
			entity.Location = Convert.IsDBNull(dataRow["LOCATION"]) ? null : (System.String)dataRow["LOCATION"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.Mark = Convert.IsDBNull(dataRow["MARK"]) ? null : (System.Decimal?)dataRow["MARK"];
			entity.PassFlg = Convert.IsDBNull(dataRow["PASS_FLG"]) ? null : (System.Decimal?)dataRow["PASS_FLG"];
			entity.AbsFlg = Convert.IsDBNull(dataRow["ABS_FLG"]) ? null : (System.Boolean?)dataRow["ABS_FLG"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Boolean?)dataRow["APPROVE_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppInterviewExam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppInterviewExam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppInterviewExam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region AdmCdePlacementExamIdSource	
			if (CanDeepLoad(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepLoadType, innerList) 
				&& entity.AdmCdePlacementExamIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdePlacementExamId;
				AdmCdePlacementExam tmpEntity = EntityManager.LocateEntity<AdmCdePlacementExam>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdePlacementExam), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdePlacementExamIdSource = tmpEntity;
				else
					entity.AdmCdePlacementExamIdSource = DataRepository.AdmCdePlacementExamProvider.GetByAdmCdePlacementExamId(transactionManager, entity.AdmCdePlacementExamId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacementExamIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdePlacementExamIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdePlacementExamProvider.DeepLoad(transactionManager, entity.AdmCdePlacementExamIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdePlacementExamIdSource

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

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppInterviewExam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppInterviewExam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppInterviewExam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppInterviewExam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AdmCdePlacementExamIdSource
			if (CanDeepSave(entity, "AdmCdePlacementExam|AdmCdePlacementExamIdSource", deepSaveType, innerList) 
				&& entity.AdmCdePlacementExamIdSource != null)
			{
				DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamIdSource);
				entity.AdmCdePlacementExamId = entity.AdmCdePlacementExamIdSource.AdmCdePlacementExamId;
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
	
	#region AdmAppInterviewExamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppInterviewExam</c>
	///</summary>
	public enum AdmAppInterviewExamChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AdmCdePlacementExam</c> at AdmCdePlacementExamIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdePlacementExam))]
		AdmCdePlacementExam,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion AdmAppInterviewExamChildEntityTypes
	
	#region AdmAppInterviewExamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppInterviewExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppInterviewExam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppInterviewExamFilterBuilder : SqlFilterBuilder<AdmAppInterviewExamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppInterviewExamFilterBuilder class.
		/// </summary>
		public AdmAppInterviewExamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppInterviewExamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppInterviewExamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppInterviewExamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppInterviewExamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppInterviewExamFilterBuilder
	
	#region AdmAppInterviewExamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppInterviewExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppInterviewExam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppInterviewExamParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppInterviewExamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppInterviewExamParameterBuilder class.
		/// </summary>
		public AdmAppInterviewExamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppInterviewExamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppInterviewExamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppInterviewExamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppInterviewExamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppInterviewExamParameterBuilder
	
	#region AdmAppInterviewExamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppInterviewExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppInterviewExam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppInterviewExamSortBuilder : SqlSortBuilder<AdmAppInterviewExamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppInterviewExamSqlSortBuilder class.
		/// </summary>
		public AdmAppInterviewExamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppInterviewExamSortBuilder
	
} // end namespace
