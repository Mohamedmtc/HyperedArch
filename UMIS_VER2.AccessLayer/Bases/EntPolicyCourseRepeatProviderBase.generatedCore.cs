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
	/// This class is the base class for any <see cref="EntPolicyCourseRepeatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyCourseRepeatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat, UMIS_VER2.BusinessLyer.EntPolicyCourseRepeatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyCourseRepeatKey key)
		{
			return Delete(transactionManager, key.EntPolicyCourseRepeatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyCourseRepeatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyCourseRepeatId)
		{
			return Delete(null, _entPolicyCourseRepeatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyCourseRepeatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyCourseRepeatId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_BYLAW key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_BYLAW key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyCourseRepeat> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_BYLAW key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_BYLAW key.
		///		fkEntPolicyCourseRepeatEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_BYLAW key.
		///		fkEntPolicyCourseRepeatEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_BYLAW key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public abstract TList<EntPolicyCourseRepeat> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING1 key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="_edCodeMinGradId">اقل تقدير لتسجيل المقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeMinGradId(System.Decimal? _edCodeMinGradId)
		{
			int count = -1;
			return GetByEdCodeMinGradId(_edCodeMinGradId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING1 key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeMinGradId">اقل تقدير لتسجيل المقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyCourseRepeat> GetByEdCodeMinGradId(TransactionManager transactionManager, System.Decimal? _edCodeMinGradId)
		{
			int count = -1;
			return GetByEdCodeMinGradId(transactionManager, _edCodeMinGradId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING1 key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeMinGradId">اقل تقدير لتسجيل المقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeMinGradId(TransactionManager transactionManager, System.Decimal? _edCodeMinGradId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeMinGradId(transactionManager, _edCodeMinGradId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING1 key.
		///		fkEntPolicyCourseRepeatEdCodeGrading1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeMinGradId">اقل تقدير لتسجيل المقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeMinGradId(System.Decimal? _edCodeMinGradId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeMinGradId(null, _edCodeMinGradId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING1 key.
		///		fkEntPolicyCourseRepeatEdCodeGrading1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeMinGradId">اقل تقدير لتسجيل المقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeMinGradId(System.Decimal? _edCodeMinGradId, int start, int pageLength,out int count)
		{
			return GetByEdCodeMinGradId(null, _edCodeMinGradId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING1 key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeMinGradId">اقل تقدير لتسجيل المقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public abstract TList<EntPolicyCourseRepeat> GetByEdCodeMinGradId(TransactionManager transactionManager, System.Decimal? _edCodeMinGradId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING2 key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING2 Description: 
		/// </summary>
		/// <param name="_gradingMoreThanOneId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByGradingMoreThanOneId(System.Decimal? _gradingMoreThanOneId)
		{
			int count = -1;
			return GetByGradingMoreThanOneId(_gradingMoreThanOneId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING2 key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gradingMoreThanOneId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyCourseRepeat> GetByGradingMoreThanOneId(TransactionManager transactionManager, System.Decimal? _gradingMoreThanOneId)
		{
			int count = -1;
			return GetByGradingMoreThanOneId(transactionManager, _gradingMoreThanOneId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING2 key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gradingMoreThanOneId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByGradingMoreThanOneId(TransactionManager transactionManager, System.Decimal? _gradingMoreThanOneId, int start, int pageLength)
		{
			int count = -1;
			return GetByGradingMoreThanOneId(transactionManager, _gradingMoreThanOneId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING2 key.
		///		fkEntPolicyCourseRepeatEdCodeGrading2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gradingMoreThanOneId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByGradingMoreThanOneId(System.Decimal? _gradingMoreThanOneId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGradingMoreThanOneId(null, _gradingMoreThanOneId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING2 key.
		///		fkEntPolicyCourseRepeatEdCodeGrading2 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gradingMoreThanOneId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByGradingMoreThanOneId(System.Decimal? _gradingMoreThanOneId, int start, int pageLength,out int count)
		{
			return GetByGradingMoreThanOneId(null, _gradingMoreThanOneId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING2 key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_GRADING2 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gradingMoreThanOneId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public abstract TList<EntPolicyCourseRepeat> GetByGradingMoreThanOneId(TransactionManager transactionManager, System.Decimal? _gradingMoreThanOneId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_SEMESTER_TYPE key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_SEMESTER_TYPE Description: 
		/// </summary>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل : اجبارى- اختيارى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(_edCodeSemesterTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_SEMESTER_TYPE key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_SEMESTER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل : اجبارى- اختيارى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyCourseRepeat> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_SEMESTER_TYPE key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_SEMESTER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل : اجبارى- اختيارى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_SEMESTER_TYPE key.
		///		fkEntPolicyCourseRepeatEdCodeSemesterType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل : اجبارى- اختيارى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_SEMESTER_TYPE key.
		///		fkEntPolicyCourseRepeatEdCodeSemesterType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل : اجبارى- اختيارى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_SEMESTER_TYPE key.
		///		FK_ENT_POLICY_COURSE_REPEAT_ED_CODE_SEMESTER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل : اجبارى- اختيارى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat objects.</returns>
		public abstract TList<EntPolicyCourseRepeat> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyCourseRepeatKey key, int start, int pageLength)
		{
			return GetByEntPolicyCourseRepeatId(transactionManager, key.EntPolicyCourseRepeatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId">اقصى تقدير  للمقرر -اعلى المقبول</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(null,_edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId">اقصى تقدير  للمقرر -اعلى المقبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">اقصى تقدير  للمقرر -اعلى المقبول</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">اقصى تقدير  للمقرر -اعلى المقبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="_edCodeGradingId">اقصى تقدير  للمقرر -اعلى المقبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeGradingId(System.Decimal? _edCodeGradingId, int start, int pageLength, out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_GRADING_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">اقصى تقدير  للمقرر -اعلى المقبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public abstract TList<EntPolicyCourseRepeat> GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _edCodeGradingId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_REPEAT_RULE__1 index.
		/// </summary>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeRepeatRuleId(System.Decimal _edCodeRepeatRuleId)
		{
			int count = -1;
			return GetByEdCodeRepeatRuleId(null,_edCodeRepeatRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_REPEAT_RULE__1 index.
		/// </summary>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeRepeatRuleId(System.Decimal _edCodeRepeatRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeRepeatRuleId(null, _edCodeRepeatRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_REPEAT_RULE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeRepeatRuleId(TransactionManager transactionManager, System.Decimal _edCodeRepeatRuleId)
		{
			int count = -1;
			return GetByEdCodeRepeatRuleId(transactionManager, _edCodeRepeatRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_REPEAT_RULE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeRepeatRuleId(TransactionManager transactionManager, System.Decimal _edCodeRepeatRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeRepeatRuleId(transactionManager, _edCodeRepeatRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_REPEAT_RULE__1 index.
		/// </summary>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEdCodeRepeatRuleId(System.Decimal _edCodeRepeatRuleId, int start, int pageLength, out int count)
		{
			return GetByEdCodeRepeatRuleId(null, _edCodeRepeatRuleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_REPEAT_RULE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeRepeatRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public abstract TList<EntPolicyCourseRepeat> GetByEdCodeRepeatRuleId(TransactionManager transactionManager, System.Decimal _edCodeRepeatRuleId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId">related to current bylaw</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(null,_entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId">related to current bylaw</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId">related to current bylaw</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId">related to current bylaw</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyGradingHdrId(transactionManager, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="_entPolicyGradingHdrId">related to current bylaw</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public TList<EntPolicyCourseRepeat> GetByEntPolicyGradingHdrId(System.Decimal? _entPolicyGradingHdrId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyGradingHdrId(null, _entPolicyGradingHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_GRADING_H_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyGradingHdrId">related to current bylaw</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/> class.</returns>
		public abstract TList<EntPolicyCourseRepeat> GetByEntPolicyGradingHdrId(TransactionManager transactionManager, System.Decimal? _entPolicyGradingHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_COURSE_REPEAT index.
		/// </summary>
		/// <param name="_entPolicyCourseRepeatId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat GetByEntPolicyCourseRepeatId(System.Decimal _entPolicyCourseRepeatId)
		{
			int count = -1;
			return GetByEntPolicyCourseRepeatId(null,_entPolicyCourseRepeatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_COURSE_REPEAT index.
		/// </summary>
		/// <param name="_entPolicyCourseRepeatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat GetByEntPolicyCourseRepeatId(System.Decimal _entPolicyCourseRepeatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyCourseRepeatId(null, _entPolicyCourseRepeatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_COURSE_REPEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyCourseRepeatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat GetByEntPolicyCourseRepeatId(TransactionManager transactionManager, System.Decimal _entPolicyCourseRepeatId)
		{
			int count = -1;
			return GetByEntPolicyCourseRepeatId(transactionManager, _entPolicyCourseRepeatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_COURSE_REPEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyCourseRepeatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat GetByEntPolicyCourseRepeatId(TransactionManager transactionManager, System.Decimal _entPolicyCourseRepeatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyCourseRepeatId(transactionManager, _entPolicyCourseRepeatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_COURSE_REPEAT index.
		/// </summary>
		/// <param name="_entPolicyCourseRepeatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat GetByEntPolicyCourseRepeatId(System.Decimal _entPolicyCourseRepeatId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyCourseRepeatId(null, _entPolicyCourseRepeatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_COURSE_REPEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyCourseRepeatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat GetByEntPolicyCourseRepeatId(TransactionManager transactionManager, System.Decimal _entPolicyCourseRepeatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyCourseRepeat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyCourseRepeat&gt;"/></returns>
		public static TList<EntPolicyCourseRepeat> Fill(IDataReader reader, TList<EntPolicyCourseRepeat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyCourseRepeat")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_COURSE_REPEAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyCourseRepeat>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyCourseRepeat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat();
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
					c.EntPolicyCourseRepeatId = (System.Decimal)reader["ENT_POLICY_COURSE_REPEAT_ID"];
					c.OriginalEntPolicyCourseRepeatId = c.EntPolicyCourseRepeatId;
					c.MaxRepeatCoreNo = (System.Decimal)reader["MAX_REPEAT_CORE_NO"];
					c.MaxRepeatElctNo = (System.Decimal)reader["MAX_REPEAT_ELCT_NO"];
					c.EdCodeRepeatRuleId = (System.Decimal)reader["ED_CODE_REPEAT_RULE_ID"];
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.RepeatFlg = Convert.IsDBNull(reader["REPEAT_FLG"]) ? null : (System.Decimal?)reader["REPEAT_FLG"];
					c.EdCodeMinGradId = Convert.IsDBNull(reader["ED_CODE_MIN_GRAD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_MIN_GRAD_ID"];
					c.EdCodeGradingId = Convert.IsDBNull(reader["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_ID"];
					c.EntPolicyGradingHdrId = Convert.IsDBNull(reader["ENT_POLICY_GRADING_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_POLICY_GRADING_HDR_ID"];
					c.MaxReptCourse = Convert.IsDBNull(reader["MAX_REPT_COURSE"]) ? null : (System.Decimal?)reader["MAX_REPT_COURSE"];
					c.MaxReptCh = Convert.IsDBNull(reader["MAX_REPT_CH"]) ? null : (System.Int32?)reader["MAX_REPT_CH"];
					c.EdCodeSemesterTypeId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_TYPE_ID"];
					c.ExecuseFlg = Convert.IsDBNull(reader["EXECUSE_FLG"]) ? null : (System.Decimal?)reader["EXECUSE_FLG"];
					c.FailedCountFlag = Convert.IsDBNull(reader["FailedCount_Flag"]) ? null : (System.Boolean?)reader["FailedCount_Flag"];
					c.GradingMoreThanOneId = Convert.IsDBNull(reader["GradingMoreThanOne_ID"]) ? null : (System.Decimal?)reader["GradingMoreThanOne_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyCourseRepeatId = (System.Decimal)reader[((int)EntPolicyCourseRepeatColumn.EntPolicyCourseRepeatId - 1)];
			entity.OriginalEntPolicyCourseRepeatId = (System.Decimal)reader["ENT_POLICY_COURSE_REPEAT_ID"];
			entity.MaxRepeatCoreNo = (System.Decimal)reader[((int)EntPolicyCourseRepeatColumn.MaxRepeatCoreNo - 1)];
			entity.MaxRepeatElctNo = (System.Decimal)reader[((int)EntPolicyCourseRepeatColumn.MaxRepeatElctNo - 1)];
			entity.EdCodeRepeatRuleId = (System.Decimal)reader[((int)EntPolicyCourseRepeatColumn.EdCodeRepeatRuleId - 1)];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseRepeatColumn.EdBylawId - 1)];
			entity.RepeatFlg = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.RepeatFlg - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseRepeatColumn.RepeatFlg - 1)];
			entity.EdCodeMinGradId = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.EdCodeMinGradId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseRepeatColumn.EdCodeMinGradId - 1)];
			entity.EdCodeGradingId = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.EdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseRepeatColumn.EdCodeGradingId - 1)];
			entity.EntPolicyGradingHdrId = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.EntPolicyGradingHdrId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseRepeatColumn.EntPolicyGradingHdrId - 1)];
			entity.MaxReptCourse = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.MaxReptCourse - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseRepeatColumn.MaxReptCourse - 1)];
			entity.MaxReptCh = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.MaxReptCh - 1)))?null:(System.Int32?)reader[((int)EntPolicyCourseRepeatColumn.MaxReptCh - 1)];
			entity.EdCodeSemesterTypeId = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.EdCodeSemesterTypeId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseRepeatColumn.EdCodeSemesterTypeId - 1)];
			entity.ExecuseFlg = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.ExecuseFlg - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseRepeatColumn.ExecuseFlg - 1)];
			entity.FailedCountFlag = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.FailedCountFlag - 1)))?null:(System.Boolean?)reader[((int)EntPolicyCourseRepeatColumn.FailedCountFlag - 1)];
			entity.GradingMoreThanOneId = (reader.IsDBNull(((int)EntPolicyCourseRepeatColumn.GradingMoreThanOneId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseRepeatColumn.GradingMoreThanOneId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyCourseRepeatId = (System.Decimal)dataRow["ENT_POLICY_COURSE_REPEAT_ID"];
			entity.OriginalEntPolicyCourseRepeatId = (System.Decimal)dataRow["ENT_POLICY_COURSE_REPEAT_ID"];
			entity.MaxRepeatCoreNo = (System.Decimal)dataRow["MAX_REPEAT_CORE_NO"];
			entity.MaxRepeatElctNo = (System.Decimal)dataRow["MAX_REPEAT_ELCT_NO"];
			entity.EdCodeRepeatRuleId = (System.Decimal)dataRow["ED_CODE_REPEAT_RULE_ID"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.RepeatFlg = Convert.IsDBNull(dataRow["REPEAT_FLG"]) ? null : (System.Decimal?)dataRow["REPEAT_FLG"];
			entity.EdCodeMinGradId = Convert.IsDBNull(dataRow["ED_CODE_MIN_GRAD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_MIN_GRAD_ID"];
			entity.EdCodeGradingId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_ID"];
			entity.EntPolicyGradingHdrId = Convert.IsDBNull(dataRow["ENT_POLICY_GRADING_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_POLICY_GRADING_HDR_ID"];
			entity.MaxReptCourse = Convert.IsDBNull(dataRow["MAX_REPT_COURSE"]) ? null : (System.Decimal?)dataRow["MAX_REPT_COURSE"];
			entity.MaxReptCh = Convert.IsDBNull(dataRow["MAX_REPT_CH"]) ? null : (System.Int32?)dataRow["MAX_REPT_CH"];
			entity.EdCodeSemesterTypeId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_TYPE_ID"];
			entity.ExecuseFlg = Convert.IsDBNull(dataRow["EXECUSE_FLG"]) ? null : (System.Decimal?)dataRow["EXECUSE_FLG"];
			entity.FailedCountFlag = Convert.IsDBNull(dataRow["FailedCount_Flag"]) ? null : (System.Boolean?)dataRow["FailedCount_Flag"];
			entity.GradingMoreThanOneId = Convert.IsDBNull(dataRow["GradingMoreThanOne_ID"]) ? null : (System.Decimal?)dataRow["GradingMoreThanOne_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdBylawIdSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdSource", deepLoadType, innerList) 
				&& entity.EdBylawIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdBylawId ?? 0.0m);
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdSource = tmpEntity;
				else
					entity.EdBylawIdSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, (entity.EdBylawId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdSource

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

			#region EdCodeMinGradIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeMinGradIdSource", deepLoadType, innerList) 
				&& entity.EdCodeMinGradIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeMinGradId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeMinGradIdSource = tmpEntity;
				else
					entity.EdCodeMinGradIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.EdCodeMinGradId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeMinGradIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeMinGradIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.EdCodeMinGradIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeMinGradIdSource

			#region GradingMoreThanOneIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|GradingMoreThanOneIdSource", deepLoadType, innerList) 
				&& entity.GradingMoreThanOneIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GradingMoreThanOneId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GradingMoreThanOneIdSource = tmpEntity;
				else
					entity.GradingMoreThanOneIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.GradingMoreThanOneId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GradingMoreThanOneIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GradingMoreThanOneIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.GradingMoreThanOneIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GradingMoreThanOneIdSource

			#region EdCodeRepeatRuleIdSource	
			if (CanDeepLoad(entity, "EdCodeRepeatRule|EdCodeRepeatRuleIdSource", deepLoadType, innerList) 
				&& entity.EdCodeRepeatRuleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeRepeatRuleId;
				EdCodeRepeatRule tmpEntity = EntityManager.LocateEntity<EdCodeRepeatRule>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeRepeatRule), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeRepeatRuleIdSource = tmpEntity;
				else
					entity.EdCodeRepeatRuleIdSource = DataRepository.EdCodeRepeatRuleProvider.GetByEdCodeRepeatRuleId(transactionManager, entity.EdCodeRepeatRuleId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeRepeatRuleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeRepeatRuleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeRepeatRuleProvider.DeepLoad(transactionManager, entity.EdCodeRepeatRuleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeRepeatRuleIdSource

			#region EdCodeSemesterTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeSemesterType|EdCodeSemesterTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterTypeId ?? 0.0m);
				EdCodeSemesterType tmpEntity = EntityManager.LocateEntity<EdCodeSemesterType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemesterType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterTypeIdSource = tmpEntity;
				else
					entity.EdCodeSemesterTypeIdSource = DataRepository.EdCodeSemesterTypeProvider.GetByEdCodeSemesterTypeId(transactionManager, (entity.EdCodeSemesterTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterTypeProvider.DeepLoad(transactionManager, entity.EdCodeSemesterTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterTypeIdSource

			#region EntPolicyGradingHdrIdSource	
			if (CanDeepLoad(entity, "EntPolicyGradingHdr|EntPolicyGradingHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyGradingHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntPolicyGradingHdrId ?? 0.0m);
				EntPolicyGradingHdr tmpEntity = EntityManager.LocateEntity<EntPolicyGradingHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyGradingHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyGradingHdrIdSource = tmpEntity;
				else
					entity.EntPolicyGradingHdrIdSource = DataRepository.EntPolicyGradingHdrProvider.GetByEntPolicyGradingHdrId(transactionManager, (entity.EntPolicyGradingHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyGradingHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyGradingHdrProvider.DeepLoad(transactionManager, entity.EntPolicyGradingHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyGradingHdrIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
			}
			#endregion 
			
			#region EdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingIdSource);
				entity.EdCodeGradingId = entity.EdCodeGradingIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EdCodeMinGradIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeMinGradIdSource", deepSaveType, innerList) 
				&& entity.EdCodeMinGradIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeMinGradIdSource);
				entity.EdCodeMinGradId = entity.EdCodeMinGradIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region GradingMoreThanOneIdSource
			if (CanDeepSave(entity, "EdCodeGrading|GradingMoreThanOneIdSource", deepSaveType, innerList) 
				&& entity.GradingMoreThanOneIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.GradingMoreThanOneIdSource);
				entity.GradingMoreThanOneId = entity.GradingMoreThanOneIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EdCodeRepeatRuleIdSource
			if (CanDeepSave(entity, "EdCodeRepeatRule|EdCodeRepeatRuleIdSource", deepSaveType, innerList) 
				&& entity.EdCodeRepeatRuleIdSource != null)
			{
				DataRepository.EdCodeRepeatRuleProvider.Save(transactionManager, entity.EdCodeRepeatRuleIdSource);
				entity.EdCodeRepeatRuleId = entity.EdCodeRepeatRuleIdSource.EdCodeRepeatRuleId;
			}
			#endregion 
			
			#region EdCodeSemesterTypeIdSource
			if (CanDeepSave(entity, "EdCodeSemesterType|EdCodeSemesterTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterTypeIdSource != null)
			{
				DataRepository.EdCodeSemesterTypeProvider.Save(transactionManager, entity.EdCodeSemesterTypeIdSource);
				entity.EdCodeSemesterTypeId = entity.EdCodeSemesterTypeIdSource.EdCodeSemesterTypeId;
			}
			#endregion 
			
			#region EntPolicyGradingHdrIdSource
			if (CanDeepSave(entity, "EntPolicyGradingHdr|EntPolicyGradingHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyGradingHdrIdSource != null)
			{
				DataRepository.EntPolicyGradingHdrProvider.Save(transactionManager, entity.EntPolicyGradingHdrIdSource);
				entity.EntPolicyGradingHdrId = entity.EntPolicyGradingHdrIdSource.EntPolicyGradingHdrId;
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
	
	#region EntPolicyCourseRepeatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyCourseRepeat</c>
	///</summary>
	public enum EntPolicyCourseRepeatChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdCodeRepeatRule</c> at EdCodeRepeatRuleIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeRepeatRule))]
		EdCodeRepeatRule,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemesterType</c> at EdCodeSemesterTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemesterType))]
		EdCodeSemesterType,
		
		///<summary>
		/// Composite Property for <c>EntPolicyGradingHdr</c> at EntPolicyGradingHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyGradingHdr))]
		EntPolicyGradingHdr,
	}
	
	#endregion EntPolicyCourseRepeatChildEntityTypes
	
	#region EntPolicyCourseRepeatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyCourseRepeatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyCourseRepeat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyCourseRepeatFilterBuilder : SqlFilterBuilder<EntPolicyCourseRepeatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseRepeatFilterBuilder class.
		/// </summary>
		public EntPolicyCourseRepeatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseRepeatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyCourseRepeatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseRepeatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyCourseRepeatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyCourseRepeatFilterBuilder
	
	#region EntPolicyCourseRepeatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyCourseRepeatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyCourseRepeat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyCourseRepeatParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyCourseRepeatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseRepeatParameterBuilder class.
		/// </summary>
		public EntPolicyCourseRepeatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseRepeatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyCourseRepeatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseRepeatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyCourseRepeatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyCourseRepeatParameterBuilder
	
	#region EntPolicyCourseRepeatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyCourseRepeatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyCourseRepeat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyCourseRepeatSortBuilder : SqlSortBuilder<EntPolicyCourseRepeatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseRepeatSqlSortBuilder class.
		/// </summary>
		public EntPolicyCourseRepeatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyCourseRepeatSortBuilder
	
} // end namespace
