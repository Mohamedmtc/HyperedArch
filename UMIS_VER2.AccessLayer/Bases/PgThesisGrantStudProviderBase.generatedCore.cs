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
	/// This class is the base class for any <see cref="PgThesisGrantStudProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisGrantStudProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisGrantStud, UMIS_VER2.BusinessLyer.PgThesisGrantStudKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisGrantStudKey key)
		{
			return Delete(transactionManager, key.PgThesisGrantStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisGrantStudId">منح الدرجة فقط لو PG_CDE_COMM_RECOMMEND_ID=1. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisGrantStudId)
		{
			return Delete(null, _pgThesisGrantStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGrantStudId">منح الدرجة فقط لو PG_CDE_COMM_RECOMMEND_ID=1. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisGrantStudId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_CODE_GRADING key.
		///		FK_PG_THESIS_GRANT_STUD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeGradingId">تقدير المنح</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(_edCodeGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_CODE_GRADING key.
		///		FK_PG_THESIS_GRANT_STUD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">تقدير المنح</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisGrantStud> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_CODE_GRADING key.
		///		FK_PG_THESIS_GRANT_STUD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">تقدير المنح</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_CODE_GRADING key.
		///		fkPgThesisGrantStudEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId">تقدير المنح</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_CODE_GRADING key.
		///		fkPgThesisGrantStudEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingId">تقدير المنح</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_CODE_GRADING key.
		///		FK_PG_THESIS_GRANT_STUD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">تقدير المنح</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public abstract TList<PgThesisGrantStud> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_COURSE key.
		///		FK_PG_THESIS_GRANT_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_COURSE key.
		///		FK_PG_THESIS_GRANT_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisGrantStud> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_COURSE key.
		///		FK_PG_THESIS_GRANT_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_COURSE key.
		///		fkPgThesisGrantStudEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_COURSE key.
		///		fkPgThesisGrantStudEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_ED_COURSE key.
		///		FK_PG_THESIS_GRANT_STUD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مقرر البحث العلم - مقرر الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public abstract TList<PgThesisGrantStud> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_GS_CDE_HONOR key.
		///		FK_PG_THESIS_GRANT_STUD_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="_gsCdeHonorId">مرتبة الشرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(_gsCdeHonorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_GS_CDE_HONOR key.
		///		FK_PG_THESIS_GRANT_STUD_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId">مرتبة الشرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisGrantStud> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_GS_CDE_HONOR key.
		///		FK_PG_THESIS_GRANT_STUD_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId">مرتبة الشرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_GS_CDE_HONOR key.
		///		fkPgThesisGrantStudGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId">مرتبة الشرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_GS_CDE_HONOR key.
		///		fkPgThesisGrantStudGsCdeHonor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeHonorId">مرتبة الشرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByGsCdeHonorId(System.Decimal? _gsCdeHonorId, int start, int pageLength,out int count)
		{
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_GS_CDE_HONOR key.
		///		FK_PG_THESIS_GRANT_STUD_GS_CDE_HONOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId">مرتبة الشرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public abstract TList<PgThesisGrantStud> GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal? _gsCdeHonorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم- فى حالة المنح فقط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisCommRecommendId(System.Decimal _pgThesisCommRecommendId)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(_pgThesisCommRecommendId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم- فى حالة المنح فقط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisGrantStud> GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal _pgThesisCommRecommendId)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(transactionManager, _pgThesisCommRecommendId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم- فى حالة المنح فقط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal _pgThesisCommRecommendId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommRecommendId(transactionManager, _pgThesisCommRecommendId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_COMM_RECOMMEND key.
		///		fkPgThesisGrantStudPgThesisCommRecommend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم- فى حالة المنح فقط</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisCommRecommendId(System.Decimal _pgThesisCommRecommendId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommRecommendId(null, _pgThesisCommRecommendId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_COMM_RECOMMEND key.
		///		fkPgThesisGrantStudPgThesisCommRecommend Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم- فى حالة المنح فقط</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisCommRecommendId(System.Decimal _pgThesisCommRecommendId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommRecommendId(null, _pgThesisCommRecommendId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_COMM_RECOMMEND key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_COMM_RECOMMEND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommRecommendId">توصيات لجنة المناقشة والحكم- فى حالة المنح فقط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public abstract TList<PgThesisGrantStud> GetByPgThesisCommRecommendId(TransactionManager transactionManager, System.Decimal _pgThesisCommRecommendId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_GRANT_DEGREE key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_GRANT_DEGREE Description: 
		/// </summary>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisGrantDegreeId(System.Decimal _pgThesisGrantDegreeId)
		{
			int count = -1;
			return GetByPgThesisGrantDegreeId(_pgThesisGrantDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_GRANT_DEGREE key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_GRANT_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisGrantStud> GetByPgThesisGrantDegreeId(TransactionManager transactionManager, System.Decimal _pgThesisGrantDegreeId)
		{
			int count = -1;
			return GetByPgThesisGrantDegreeId(transactionManager, _pgThesisGrantDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_GRANT_DEGREE key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_GRANT_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisGrantDegreeId(TransactionManager transactionManager, System.Decimal _pgThesisGrantDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGrantDegreeId(transactionManager, _pgThesisGrantDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_GRANT_DEGREE key.
		///		fkPgThesisGrantStudPgThesisGrantDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisGrantDegreeId(System.Decimal _pgThesisGrantDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisGrantDegreeId(null, _pgThesisGrantDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_GRANT_DEGREE key.
		///		fkPgThesisGrantStudPgThesisGrantDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisGrantDegreeId(System.Decimal _pgThesisGrantDegreeId, int start, int pageLength,out int count)
		{
			return GetByPgThesisGrantDegreeId(null, _pgThesisGrantDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_GRANT_DEGREE key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_GRANT_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGrantDegreeId">قرار منح الدرجة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public abstract TList<PgThesisGrantStud> GetByPgThesisGrantDegreeId(TransactionManager transactionManager, System.Decimal _pgThesisGrantDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_STUD key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_STUD key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisGrantStud> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_STUD key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_STUD key.
		///		fkPgThesisGrantStudPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_STUD key.
		///		fkPgThesisGrantStudPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public TList<PgThesisGrantStud> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_GRANT_STUD_PG_THESIS_STUD key.
		///		FK_PG_THESIS_GRANT_STUD_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisGrantStud objects.</returns>
		public abstract TList<PgThesisGrantStud> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisGrantStud Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisGrantStudKey key, int start, int pageLength)
		{
			return GetByPgThesisGrantStudId(transactionManager, key.PgThesisGrantStudId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_GRANT_STUD index.
		/// </summary>
		/// <param name="_pgThesisGrantStudId">منح الدرجة فقط لو PG_CDE_COMM_RECOMMEND_ID=1</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisGrantStud GetByPgThesisGrantStudId(System.Decimal _pgThesisGrantStudId)
		{
			int count = -1;
			return GetByPgThesisGrantStudId(null,_pgThesisGrantStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_GRANT_STUD index.
		/// </summary>
		/// <param name="_pgThesisGrantStudId">منح الدرجة فقط لو PG_CDE_COMM_RECOMMEND_ID=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisGrantStud GetByPgThesisGrantStudId(System.Decimal _pgThesisGrantStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGrantStudId(null, _pgThesisGrantStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_GRANT_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGrantStudId">منح الدرجة فقط لو PG_CDE_COMM_RECOMMEND_ID=1</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisGrantStud GetByPgThesisGrantStudId(TransactionManager transactionManager, System.Decimal _pgThesisGrantStudId)
		{
			int count = -1;
			return GetByPgThesisGrantStudId(transactionManager, _pgThesisGrantStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_GRANT_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGrantStudId">منح الدرجة فقط لو PG_CDE_COMM_RECOMMEND_ID=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisGrantStud GetByPgThesisGrantStudId(TransactionManager transactionManager, System.Decimal _pgThesisGrantStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGrantStudId(transactionManager, _pgThesisGrantStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_GRANT_STUD index.
		/// </summary>
		/// <param name="_pgThesisGrantStudId">منح الدرجة فقط لو PG_CDE_COMM_RECOMMEND_ID=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisGrantStud GetByPgThesisGrantStudId(System.Decimal _pgThesisGrantStudId, int start, int pageLength, out int count)
		{
			return GetByPgThesisGrantStudId(null, _pgThesisGrantStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_GRANT_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGrantStudId">منح الدرجة فقط لو PG_CDE_COMM_RECOMMEND_ID=1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisGrantStud GetByPgThesisGrantStudId(TransactionManager transactionManager, System.Decimal _pgThesisGrantStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisGrantStud&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisGrantStud&gt;"/></returns>
		public static TList<PgThesisGrantStud> Fill(IDataReader reader, TList<PgThesisGrantStud> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisGrantStud c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisGrantStud")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_GRANT_STUD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisGrantStud>(
					key.ToString(), // EntityTrackingKey
					"PgThesisGrantStud",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisGrantStud();
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
					c.PgThesisGrantStudId = (System.Decimal)reader["PG_THESIS_GRANT_STUD_ID"];
					c.OriginalPgThesisGrantStudId = c.PgThesisGrantStudId;
					c.PgThesisGrantDegreeId = (System.Decimal)reader["PG_THESIS_GRANT_DEGREE_ID"];
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.PgThesisCommRecommendId = (System.Decimal)reader["PG_THESIS_COMM_RECOMMEND_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.GsCdeHonorId = Convert.IsDBNull(reader["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)reader["GS_CDE_HONOR_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisGrantStud entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisGrantStudId = (System.Decimal)reader[((int)PgThesisGrantStudColumn.PgThesisGrantStudId - 1)];
			entity.OriginalPgThesisGrantStudId = (System.Decimal)reader["PG_THESIS_GRANT_STUD_ID"];
			entity.PgThesisGrantDegreeId = (System.Decimal)reader[((int)PgThesisGrantStudColumn.PgThesisGrantDegreeId - 1)];
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisGrantStudColumn.PgThesisStudId - 1)];
			entity.PgThesisCommRecommendId = (System.Decimal)reader[((int)PgThesisGrantStudColumn.PgThesisCommRecommendId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)PgThesisGrantStudColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)PgThesisGrantStudColumn.EdCourseId - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)PgThesisGrantStudColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)PgThesisGrantStudColumn.EdCodeGradingId - 1)];
			entity.GsCdeHonorId = (reader.IsDBNull(((int)PgThesisGrantStudColumn.GsCdeHonorId - 1)))?null:(System.Decimal?)reader[((int)PgThesisGrantStudColumn.GsCdeHonorId - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisGrantStudColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisGrantStudColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisGrantStudColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisGrantStudColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisGrantStudColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisGrantStudColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisGrantStud entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisGrantStudId = (System.Decimal)dataRow["PG_THESIS_GRANT_STUD_ID"];
			entity.OriginalPgThesisGrantStudId = (System.Decimal)dataRow["PG_THESIS_GRANT_STUD_ID"];
			entity.PgThesisGrantDegreeId = (System.Decimal)dataRow["PG_THESIS_GRANT_DEGREE_ID"];
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.PgThesisCommRecommendId = (System.Decimal)dataRow["PG_THESIS_COMM_RECOMMEND_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.GsCdeHonorId = Convert.IsDBNull(dataRow["GS_CDE_HONOR_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_HONOR_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisGrantStud"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisGrantStud Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisGrantStud entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeGradingIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeGradingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeGradingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeGradingId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeGradingIdSource = tmpEntity;
				else
					entity.EdCodeGradingIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.EdCodeGradingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeGradingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeGradingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.EdCodeGradingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeGradingIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

			#region GsCdeHonorIdSource	
			if (CanDeepLoad(entity, "GsCdeHonor|GsCdeHonorIdSource", deepLoadType, innerList) 
				&& entity.GsCdeHonorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeHonorId ?? 0.0m);
				GsCdeHonor tmpEntity = EntityManager.LocateEntity<GsCdeHonor>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeHonor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeHonorIdSource = tmpEntity;
				else
					entity.GsCdeHonorIdSource = DataRepository.GsCdeHonorProvider.GetByGsCdeHonorId(transactionManager, (entity.GsCdeHonorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeHonorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeHonorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeHonorProvider.DeepLoad(transactionManager, entity.GsCdeHonorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeHonorIdSource

			#region PgThesisCommRecommendIdSource	
			if (CanDeepLoad(entity, "PgThesisCommRecommend|PgThesisCommRecommendIdSource", deepLoadType, innerList) 
				&& entity.PgThesisCommRecommendIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisCommRecommendId;
				PgThesisCommRecommend tmpEntity = EntityManager.LocateEntity<PgThesisCommRecommend>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisCommRecommend), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisCommRecommendIdSource = tmpEntity;
				else
					entity.PgThesisCommRecommendIdSource = DataRepository.PgThesisCommRecommendProvider.GetByPgThesisCommRecommendId(transactionManager, entity.PgThesisCommRecommendId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommRecommendIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisCommRecommendIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisCommRecommendProvider.DeepLoad(transactionManager, entity.PgThesisCommRecommendIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisCommRecommendIdSource

			#region PgThesisGrantDegreeIdSource	
			if (CanDeepLoad(entity, "PgThesisGrantDegree|PgThesisGrantDegreeIdSource", deepLoadType, innerList) 
				&& entity.PgThesisGrantDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisGrantDegreeId;
				PgThesisGrantDegree tmpEntity = EntityManager.LocateEntity<PgThesisGrantDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisGrantDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisGrantDegreeIdSource = tmpEntity;
				else
					entity.PgThesisGrantDegreeIdSource = DataRepository.PgThesisGrantDegreeProvider.GetByPgThesisGrantDegreeId(transactionManager, entity.PgThesisGrantDegreeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisGrantDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisGrantDegreeProvider.DeepLoad(transactionManager, entity.PgThesisGrantDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisGrantDegreeIdSource

			#region PgThesisStudIdSource	
			if (CanDeepLoad(entity, "PgThesisStud|PgThesisStudIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisStudId;
				PgThesisStud tmpEntity = EntityManager.LocateEntity<PgThesisStud>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudIdSource = tmpEntity;
				else
					entity.PgThesisStudIdSource = DataRepository.PgThesisStudProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisGrantStud object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisGrantStud instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisGrantStud Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisGrantStud entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingIdSource);
				entity.EdCodeGradingId = entity.EdCodeGradingIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region GsCdeHonorIdSource
			if (CanDeepSave(entity, "GsCdeHonor|GsCdeHonorIdSource", deepSaveType, innerList) 
				&& entity.GsCdeHonorIdSource != null)
			{
				DataRepository.GsCdeHonorProvider.Save(transactionManager, entity.GsCdeHonorIdSource);
				entity.GsCdeHonorId = entity.GsCdeHonorIdSource.GsCdeHonorId;
			}
			#endregion 
			
			#region PgThesisCommRecommendIdSource
			if (CanDeepSave(entity, "PgThesisCommRecommend|PgThesisCommRecommendIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommRecommendIdSource != null)
			{
				DataRepository.PgThesisCommRecommendProvider.Save(transactionManager, entity.PgThesisCommRecommendIdSource);
				entity.PgThesisCommRecommendId = entity.PgThesisCommRecommendIdSource.PgThesisCommRecommendId;
			}
			#endregion 
			
			#region PgThesisGrantDegreeIdSource
			if (CanDeepSave(entity, "PgThesisGrantDegree|PgThesisGrantDegreeIdSource", deepSaveType, innerList) 
				&& entity.PgThesisGrantDegreeIdSource != null)
			{
				DataRepository.PgThesisGrantDegreeProvider.Save(transactionManager, entity.PgThesisGrantDegreeIdSource);
				entity.PgThesisGrantDegreeId = entity.PgThesisGrantDegreeIdSource.PgThesisGrantDegreeId;
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
	
	#region PgThesisGrantStudChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisGrantStud</c>
	///</summary>
	public enum PgThesisGrantStudChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>GsCdeHonor</c> at GsCdeHonorIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeHonor))]
		GsCdeHonor,
		
		///<summary>
		/// Composite Property for <c>PgThesisCommRecommend</c> at PgThesisCommRecommendIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisCommRecommend))]
		PgThesisCommRecommend,
		
		///<summary>
		/// Composite Property for <c>PgThesisGrantDegree</c> at PgThesisGrantDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisGrantDegree))]
		PgThesisGrantDegree,
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
	}
	
	#endregion PgThesisGrantStudChildEntityTypes
	
	#region PgThesisGrantStudFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisGrantStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisGrantStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisGrantStudFilterBuilder : SqlFilterBuilder<PgThesisGrantStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisGrantStudFilterBuilder class.
		/// </summary>
		public PgThesisGrantStudFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisGrantStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisGrantStudFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisGrantStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisGrantStudFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisGrantStudFilterBuilder
	
	#region PgThesisGrantStudParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisGrantStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisGrantStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisGrantStudParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisGrantStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisGrantStudParameterBuilder class.
		/// </summary>
		public PgThesisGrantStudParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisGrantStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisGrantStudParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisGrantStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisGrantStudParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisGrantStudParameterBuilder
	
	#region PgThesisGrantStudSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisGrantStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisGrantStud"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisGrantStudSortBuilder : SqlSortBuilder<PgThesisGrantStudColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisGrantStudSqlSortBuilder class.
		/// </summary>
		public PgThesisGrantStudSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisGrantStudSortBuilder
	
} // end namespace
