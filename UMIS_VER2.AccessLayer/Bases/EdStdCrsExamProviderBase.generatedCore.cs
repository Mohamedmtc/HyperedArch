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
	/// This class is the base class for any <see cref="EdStdCrsExamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStdCrsExamProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStdCrsExam, UMIS_VER2.BusinessLyer.EdStdCrsExamKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdCrsExamKey key)
		{
			return Delete(transactionManager, key.EdStdCrsExamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStdCrsExamId)
		{
			return Delete(null, _edStdCrsExamId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStdCrsExamId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="_edCodeCourseStatusOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeCourseStatusOldId(System.Decimal? _edCodeCourseStatusOldId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusOldId(_edCodeCourseStatusOldId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdCrsExam> GetByEdCodeCourseStatusOldId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusOldId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusOldId(transactionManager, _edCodeCourseStatusOldId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeCourseStatusOldId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusOldId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusOldId(transactionManager, _edCodeCourseStatusOldId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS key.
		///		fkEdStdCrsExamEdCodeCourseStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStatusOldId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeCourseStatusOldId(System.Decimal? _edCodeCourseStatusOldId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseStatusOldId(null, _edCodeCourseStatusOldId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS key.
		///		fkEdStdCrsExamEdCodeCourseStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStatusOldId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeCourseStatusOldId(System.Decimal? _edCodeCourseStatusOldId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseStatusOldId(null, _edCodeCourseStatusOldId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public abstract TList<EdStdCrsExam> GetByEdCodeCourseStatusOldId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusOldId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS1 key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS1 Description: 
		/// </summary>
		/// <param name="_edCodeCourseStatusNewId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeCourseStatusNewId(System.Decimal? _edCodeCourseStatusNewId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusNewId(_edCodeCourseStatusNewId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS1 key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusNewId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdCrsExam> GetByEdCodeCourseStatusNewId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusNewId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusNewId(transactionManager, _edCodeCourseStatusNewId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS1 key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeCourseStatusNewId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusNewId(transactionManager, _edCodeCourseStatusNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS1 key.
		///		fkEdStdCrsExamEdCodeCourseStatus1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStatusNewId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeCourseStatusNewId(System.Decimal? _edCodeCourseStatusNewId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseStatusNewId(null, _edCodeCourseStatusNewId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS1 key.
		///		fkEdStdCrsExamEdCodeCourseStatus1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStatusNewId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeCourseStatusNewId(System.Decimal? _edCodeCourseStatusNewId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseStatusNewId(null, _edCodeCourseStatusNewId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS1 key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_COURSE_STATUS1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public abstract TList<EdStdCrsExam> GetByEdCodeCourseStatusNewId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStatusNewId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeGradingOldId">التقدير السابق</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeGradingOldId(System.Decimal? _edCodeGradingOldId)
		{
			int count = -1;
			return GetByEdCodeGradingOldId(_edCodeGradingOldId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingOldId">التقدير السابق</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdCrsExam> GetByEdCodeGradingOldId(TransactionManager transactionManager, System.Decimal? _edCodeGradingOldId)
		{
			int count = -1;
			return GetByEdCodeGradingOldId(transactionManager, _edCodeGradingOldId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingOldId">التقدير السابق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeGradingOldId(TransactionManager transactionManager, System.Decimal? _edCodeGradingOldId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingOldId(transactionManager, _edCodeGradingOldId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING key.
		///		fkEdStdCrsExamEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingOldId">التقدير السابق</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeGradingOldId(System.Decimal? _edCodeGradingOldId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingOldId(null, _edCodeGradingOldId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING key.
		///		fkEdStdCrsExamEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingOldId">التقدير السابق</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeGradingOldId(System.Decimal? _edCodeGradingOldId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingOldId(null, _edCodeGradingOldId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingOldId">التقدير السابق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public abstract TList<EdStdCrsExam> GetByEdCodeGradingOldId(TransactionManager transactionManager, System.Decimal? _edCodeGradingOldId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING1 key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="_edCodeGradingNewId">التقدير الجديد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeGradingNewId(System.Decimal? _edCodeGradingNewId)
		{
			int count = -1;
			return GetByEdCodeGradingNewId(_edCodeGradingNewId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING1 key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingNewId">التقدير الجديد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdCrsExam> GetByEdCodeGradingNewId(TransactionManager transactionManager, System.Decimal? _edCodeGradingNewId)
		{
			int count = -1;
			return GetByEdCodeGradingNewId(transactionManager, _edCodeGradingNewId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING1 key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingNewId">التقدير الجديد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeGradingNewId(TransactionManager transactionManager, System.Decimal? _edCodeGradingNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingNewId(transactionManager, _edCodeGradingNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING1 key.
		///		fkEdStdCrsExamEdCodeGrading1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingNewId">التقدير الجديد</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeGradingNewId(System.Decimal? _edCodeGradingNewId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingNewId(null, _edCodeGradingNewId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING1 key.
		///		fkEdStdCrsExamEdCodeGrading1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingNewId">التقدير الجديد</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCodeGradingNewId(System.Decimal? _edCodeGradingNewId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingNewId(null, _edCodeGradingNewId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_ED_CODE_GRADING1 key.
		///		FK_ED_STD_CRS_EXAM_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingNewId">التقدير الجديد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public abstract TList<EdStdCrsExam> GetByEdCodeGradingNewId(TransactionManager transactionManager, System.Decimal? _edCodeGradingNewId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL key.
		///		FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="_gsCodePassFailOldId">مؤشر النجاح</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByGsCodePassFailOldId(System.Decimal? _gsCodePassFailOldId)
		{
			int count = -1;
			return GetByGsCodePassFailOldId(_gsCodePassFailOldId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL key.
		///		FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailOldId">مؤشر النجاح</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdCrsExam> GetByGsCodePassFailOldId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailOldId)
		{
			int count = -1;
			return GetByGsCodePassFailOldId(transactionManager, _gsCodePassFailOldId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL key.
		///		FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailOldId">مؤشر النجاح</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByGsCodePassFailOldId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailOldId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailOldId(transactionManager, _gsCodePassFailOldId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL key.
		///		fkEdStdCrsExamGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailOldId">مؤشر النجاح</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByGsCodePassFailOldId(System.Decimal? _gsCodePassFailOldId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePassFailOldId(null, _gsCodePassFailOldId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL key.
		///		fkEdStdCrsExamGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailOldId">مؤشر النجاح</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByGsCodePassFailOldId(System.Decimal? _gsCodePassFailOldId, int start, int pageLength,out int count)
		{
			return GetByGsCodePassFailOldId(null, _gsCodePassFailOldId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL key.
		///		FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailOldId">مؤشر النجاح</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public abstract TList<EdStdCrsExam> GetByGsCodePassFailOldId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailOldId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL1 key.
		///		FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL1 Description: 
		/// </summary>
		/// <param name="_gsCodePassFailNewId">مؤشر النجاح</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByGsCodePassFailNewId(System.Decimal? _gsCodePassFailNewId)
		{
			int count = -1;
			return GetByGsCodePassFailNewId(_gsCodePassFailNewId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL1 key.
		///		FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailNewId">مؤشر النجاح</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdCrsExam> GetByGsCodePassFailNewId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailNewId)
		{
			int count = -1;
			return GetByGsCodePassFailNewId(transactionManager, _gsCodePassFailNewId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL1 key.
		///		FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailNewId">مؤشر النجاح</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByGsCodePassFailNewId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailNewId(transactionManager, _gsCodePassFailNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL1 key.
		///		fkEdStdCrsExamGsCodePassFail1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailNewId">مؤشر النجاح</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByGsCodePassFailNewId(System.Decimal? _gsCodePassFailNewId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePassFailNewId(null, _gsCodePassFailNewId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL1 key.
		///		fkEdStdCrsExamGsCodePassFail1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailNewId">مؤشر النجاح</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByGsCodePassFailNewId(System.Decimal? _gsCodePassFailNewId, int start, int pageLength,out int count)
		{
			return GetByGsCodePassFailNewId(null, _gsCodePassFailNewId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL1 key.
		///		FK_ED_STD_CRS_EXAM_GS_CODE_PASS_FAIL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailNewId">مؤشر النجاح</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public abstract TList<EdStdCrsExam> GetByGsCodePassFailNewId(TransactionManager transactionManager, System.Decimal? _gsCodePassFailNewId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_CDE_REEXAM_TYPE key.
		///		FK_ED_STD_CRS_RE_EXAM_ED_CDE_REEXAM_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(_edCdeExamTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_CDE_REEXAM_TYPE key.
		///		FK_ED_STD_CRS_RE_EXAM_ED_CDE_REEXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdCrsExam> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_CDE_REEXAM_TYPE key.
		///		FK_ED_STD_CRS_RE_EXAM_ED_CDE_REEXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_CDE_REEXAM_TYPE key.
		///		fkEdStdCrsReExamEdCdeReexamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_CDE_REEXAM_TYPE key.
		///		fkEdStdCrsReExamEdCdeReexamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_CDE_REEXAM_TYPE key.
		///		FK_ED_STD_CRS_RE_EXAM_ED_CDE_REEXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public abstract TList<EdStdCrsExam> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_STUD_COURSE_REG key.
		///		FK_ED_STD_CRS_RE_EXAM_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(_edStudCourseRegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_STUD_COURSE_REG key.
		///		FK_ED_STD_CRS_RE_EXAM_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		/// <remarks></remarks>
		public TList<EdStdCrsExam> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_STUD_COURSE_REG key.
		///		FK_ED_STD_CRS_RE_EXAM_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_STUD_COURSE_REG key.
		///		fkEdStdCrsReExamEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_STUD_COURSE_REG key.
		///		fkEdStdCrsReExamEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public TList<EdStdCrsExam> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STD_CRS_RE_EXAM_ED_STUD_COURSE_REG key.
		///		FK_ED_STD_CRS_RE_EXAM_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStdCrsExam objects.</returns>
		public abstract TList<EdStdCrsExam> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStdCrsExam Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdCrsExamKey key, int start, int pageLength)
		{
			return GetByEdStdCrsExamId(transactionManager, key.EdStdCrsExamId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STD_CRS_RE_EXAM index.
		/// </summary>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStdCrsExamId(System.Decimal _edStdCrsExamId)
		{
			int count = -1;
			return GetByEdStdCrsExamId(null,_edStdCrsExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_CRS_RE_EXAM index.
		/// </summary>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStdCrsExamId(System.Decimal _edStdCrsExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStdCrsExamId(null, _edStdCrsExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_CRS_RE_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStdCrsExamId(TransactionManager transactionManager, System.Decimal _edStdCrsExamId)
		{
			int count = -1;
			return GetByEdStdCrsExamId(transactionManager, _edStdCrsExamId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_CRS_RE_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStdCrsExamId(TransactionManager transactionManager, System.Decimal _edStdCrsExamId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStdCrsExamId(transactionManager, _edStdCrsExamId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_CRS_RE_EXAM index.
		/// </summary>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStdCrsExamId(System.Decimal _edStdCrsExamId, int start, int pageLength, out int count)
		{
			return GetByEdStdCrsExamId(null, _edStdCrsExamId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STD_CRS_RE_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStdCrsExamId">درجات اعادة امتحان امتحان طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStdCrsExamId(TransactionManager transactionManager, System.Decimal _edStdCrsExamId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STD_CRS_EXAM index.
		/// </summary>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStudCourseRegIdEdCdeExamTypeId(System.Decimal _edStudCourseRegId, System.Decimal _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCdeExamTypeId(null,_edStudCourseRegId, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STD_CRS_EXAM index.
		/// </summary>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStudCourseRegIdEdCdeExamTypeId(System.Decimal _edStudCourseRegId, System.Decimal _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCdeExamTypeId(null, _edStudCourseRegId, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STD_CRS_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStudCourseRegIdEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, System.Decimal _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCdeExamTypeId(transactionManager, _edStudCourseRegId, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STD_CRS_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStudCourseRegIdEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, System.Decimal _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCdeExamTypeId(transactionManager, _edStudCourseRegId, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STD_CRS_EXAM index.
		/// </summary>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStudCourseRegIdEdCdeExamTypeId(System.Decimal _edStudCourseRegId, System.Decimal _edCdeExamTypeId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegIdEdCdeExamTypeId(null, _edStudCourseRegId, _edCdeExamTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STD_CRS_EXAM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId">مسلسل تسجيل طالب مقرر</param>
		/// <param name="_edCdeExamTypeId">نوع اعادة الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStdCrsExam GetByEdStudCourseRegIdEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, System.Decimal _edCdeExamTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStdCrsExam&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStdCrsExam&gt;"/></returns>
		public static TList<EdStdCrsExam> Fill(IDataReader reader, TList<EdStdCrsExam> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStdCrsExam c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStdCrsExam")
					.Append("|").Append((System.Decimal)reader["ED_STD_CRS_EXAM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStdCrsExam>(
					key.ToString(), // EntityTrackingKey
					"EdStdCrsExam",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStdCrsExam();
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
					c.EdStdCrsExamId = (System.Decimal)reader["ED_STD_CRS_EXAM_ID"];
					c.OriginalEdStdCrsExamId = c.EdStdCrsExamId;
					c.EdStudCourseRegId = (System.Decimal)reader["ED_STUD_COURSE_REG_ID"];
					c.EdCdeExamTypeId = (System.Decimal)reader["ED_CDE_EXAM_TYPE_ID"];
					c.ExamDate = Convert.IsDBNull(reader["EXAM_DATE"]) ? null : (System.DateTime?)reader["EXAM_DATE"];
					c.CrsMarkOld = Convert.IsDBNull(reader["CRS_MARK_OLD"]) ? null : (System.Decimal?)reader["CRS_MARK_OLD"];
					c.EdCodeCourseStatusOldId = Convert.IsDBNull(reader["ED_CODE_COURSE_STATUS_OLD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_STATUS_OLD_ID"];
					c.EdCodeGradingOldId = Convert.IsDBNull(reader["ED_CODE_GRADING_OLD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_OLD_ID"];
					c.GsCodePassFailOldId = Convert.IsDBNull(reader["GS_CODE_PASS_FAIL_OLD_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PASS_FAIL_OLD_ID"];
					c.ClemencyMark = Convert.IsDBNull(reader["CLEMENCY_MARK"]) ? null : (System.Decimal?)reader["CLEMENCY_MARK"];
					c.RaiseMark = Convert.IsDBNull(reader["RAISE_MARK"]) ? null : (System.Decimal?)reader["RAISE_MARK"];
					c.CrsMarkNew = Convert.IsDBNull(reader["CRS_MARK_NEW"]) ? null : (System.Decimal?)reader["CRS_MARK_NEW"];
					c.CrsPoint = Convert.IsDBNull(reader["CRS_POINT"]) ? null : (System.Decimal?)reader["CRS_POINT"];
					c.EdCodeCourseStatusNewId = Convert.IsDBNull(reader["ED_CODE_COURSE_STATUS_NEW_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_STATUS_NEW_ID"];
					c.EdCodeGradingNewId = Convert.IsDBNull(reader["ED_CODE_GRADING_NEW_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_NEW_ID"];
					c.GsCodePassFailNewId = Convert.IsDBNull(reader["GS_CODE_PASS_FAIL_NEW_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PASS_FAIL_NEW_ID"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Decimal?)reader["APPROVE_FLG"];
					c.AbsFlg = Convert.IsDBNull(reader["ABS_FLG"]) ? null : (System.Decimal?)reader["ABS_FLG"];
					c.CelemApplyFlg = Convert.IsDBNull(reader["CELEM_APPLY_FLG"]) ? null : (System.Decimal?)reader["CELEM_APPLY_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStdCrsExam entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStdCrsExamId = (System.Decimal)reader[((int)EdStdCrsExamColumn.EdStdCrsExamId - 1)];
			entity.OriginalEdStdCrsExamId = (System.Decimal)reader["ED_STD_CRS_EXAM_ID"];
			entity.EdStudCourseRegId = (System.Decimal)reader[((int)EdStdCrsExamColumn.EdStudCourseRegId - 1)];
			entity.EdCdeExamTypeId = (System.Decimal)reader[((int)EdStdCrsExamColumn.EdCdeExamTypeId - 1)];
			entity.ExamDate = (reader.IsDBNull(((int)EdStdCrsExamColumn.ExamDate - 1)))?null:(System.DateTime?)reader[((int)EdStdCrsExamColumn.ExamDate - 1)];
			entity.CrsMarkOld = (reader.IsDBNull(((int)EdStdCrsExamColumn.CrsMarkOld - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.CrsMarkOld - 1)];
			entity.EdCodeCourseStatusOldId = (reader.IsDBNull(((int)EdStdCrsExamColumn.EdCodeCourseStatusOldId - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.EdCodeCourseStatusOldId - 1)];
			entity.EdCodeGradingOldId = (reader.IsDBNull(((int)EdStdCrsExamColumn.EdCodeGradingOldId - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.EdCodeGradingOldId - 1)];
			entity.GsCodePassFailOldId = (reader.IsDBNull(((int)EdStdCrsExamColumn.GsCodePassFailOldId - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.GsCodePassFailOldId - 1)];
			entity.ClemencyMark = (reader.IsDBNull(((int)EdStdCrsExamColumn.ClemencyMark - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.ClemencyMark - 1)];
			entity.RaiseMark = (reader.IsDBNull(((int)EdStdCrsExamColumn.RaiseMark - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.RaiseMark - 1)];
			entity.CrsMarkNew = (reader.IsDBNull(((int)EdStdCrsExamColumn.CrsMarkNew - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.CrsMarkNew - 1)];
			entity.CrsPoint = (reader.IsDBNull(((int)EdStdCrsExamColumn.CrsPoint - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.CrsPoint - 1)];
			entity.EdCodeCourseStatusNewId = (reader.IsDBNull(((int)EdStdCrsExamColumn.EdCodeCourseStatusNewId - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.EdCodeCourseStatusNewId - 1)];
			entity.EdCodeGradingNewId = (reader.IsDBNull(((int)EdStdCrsExamColumn.EdCodeGradingNewId - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.EdCodeGradingNewId - 1)];
			entity.GsCodePassFailNewId = (reader.IsDBNull(((int)EdStdCrsExamColumn.GsCodePassFailNewId - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.GsCodePassFailNewId - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EdStdCrsExamColumn.ApproveFlg - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.ApproveFlg - 1)];
			entity.AbsFlg = (reader.IsDBNull(((int)EdStdCrsExamColumn.AbsFlg - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.AbsFlg - 1)];
			entity.CelemApplyFlg = (reader.IsDBNull(((int)EdStdCrsExamColumn.CelemApplyFlg - 1)))?null:(System.Decimal?)reader[((int)EdStdCrsExamColumn.CelemApplyFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStdCrsExam entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStdCrsExamId = (System.Decimal)dataRow["ED_STD_CRS_EXAM_ID"];
			entity.OriginalEdStdCrsExamId = (System.Decimal)dataRow["ED_STD_CRS_EXAM_ID"];
			entity.EdStudCourseRegId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.EdCdeExamTypeId = (System.Decimal)dataRow["ED_CDE_EXAM_TYPE_ID"];
			entity.ExamDate = Convert.IsDBNull(dataRow["EXAM_DATE"]) ? null : (System.DateTime?)dataRow["EXAM_DATE"];
			entity.CrsMarkOld = Convert.IsDBNull(dataRow["CRS_MARK_OLD"]) ? null : (System.Decimal?)dataRow["CRS_MARK_OLD"];
			entity.EdCodeCourseStatusOldId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_STATUS_OLD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_STATUS_OLD_ID"];
			entity.EdCodeGradingOldId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_OLD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_OLD_ID"];
			entity.GsCodePassFailOldId = Convert.IsDBNull(dataRow["GS_CODE_PASS_FAIL_OLD_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PASS_FAIL_OLD_ID"];
			entity.ClemencyMark = Convert.IsDBNull(dataRow["CLEMENCY_MARK"]) ? null : (System.Decimal?)dataRow["CLEMENCY_MARK"];
			entity.RaiseMark = Convert.IsDBNull(dataRow["RAISE_MARK"]) ? null : (System.Decimal?)dataRow["RAISE_MARK"];
			entity.CrsMarkNew = Convert.IsDBNull(dataRow["CRS_MARK_NEW"]) ? null : (System.Decimal?)dataRow["CRS_MARK_NEW"];
			entity.CrsPoint = Convert.IsDBNull(dataRow["CRS_POINT"]) ? null : (System.Decimal?)dataRow["CRS_POINT"];
			entity.EdCodeCourseStatusNewId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_STATUS_NEW_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_STATUS_NEW_ID"];
			entity.EdCodeGradingNewId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_NEW_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_NEW_ID"];
			entity.GsCodePassFailNewId = Convert.IsDBNull(dataRow["GS_CODE_PASS_FAIL_NEW_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PASS_FAIL_NEW_ID"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Decimal?)dataRow["APPROVE_FLG"];
			entity.AbsFlg = Convert.IsDBNull(dataRow["ABS_FLG"]) ? null : (System.Decimal?)dataRow["ABS_FLG"];
			entity.CelemApplyFlg = Convert.IsDBNull(dataRow["CELEM_APPLY_FLG"]) ? null : (System.Decimal?)dataRow["CELEM_APPLY_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStdCrsExam"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStdCrsExam Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdCrsExam entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeCourseStatusOldIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseStatus|EdCodeCourseStatusOldIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseStatusOldIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseStatusOldId ?? 0.0m);
				EdCodeCourseStatus tmpEntity = EntityManager.LocateEntity<EdCodeCourseStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseStatusOldIdSource = tmpEntity;
				else
					entity.EdCodeCourseStatusOldIdSource = DataRepository.EdCodeCourseStatusProvider.GetByEdCodeCourseStatusId(transactionManager, (entity.EdCodeCourseStatusOldId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseStatusOldIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseStatusOldIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseStatusProvider.DeepLoad(transactionManager, entity.EdCodeCourseStatusOldIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseStatusOldIdSource

			#region EdCodeCourseStatusNewIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseStatus|EdCodeCourseStatusNewIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseStatusNewIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseStatusNewId ?? 0.0m);
				EdCodeCourseStatus tmpEntity = EntityManager.LocateEntity<EdCodeCourseStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseStatusNewIdSource = tmpEntity;
				else
					entity.EdCodeCourseStatusNewIdSource = DataRepository.EdCodeCourseStatusProvider.GetByEdCodeCourseStatusId(transactionManager, (entity.EdCodeCourseStatusNewId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseStatusNewIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseStatusNewIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseStatusProvider.DeepLoad(transactionManager, entity.EdCodeCourseStatusNewIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseStatusNewIdSource

			#region EdCodeGradingOldIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeGradingOldIdSource", deepLoadType, innerList) 
				&& entity.EdCodeGradingOldIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeGradingOldId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeGradingOldIdSource = tmpEntity;
				else
					entity.EdCodeGradingOldIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.EdCodeGradingOldId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeGradingOldIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeGradingOldIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.EdCodeGradingOldIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeGradingOldIdSource

			#region EdCodeGradingNewIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|EdCodeGradingNewIdSource", deepLoadType, innerList) 
				&& entity.EdCodeGradingNewIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeGradingNewId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeGradingNewIdSource = tmpEntity;
				else
					entity.EdCodeGradingNewIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.EdCodeGradingNewId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeGradingNewIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeGradingNewIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.EdCodeGradingNewIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeGradingNewIdSource

			#region GsCodePassFailOldIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|GsCodePassFailOldIdSource", deepLoadType, innerList) 
				&& entity.GsCodePassFailOldIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodePassFailOldId ?? 0.0m);
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePassFailOldIdSource = tmpEntity;
				else
					entity.GsCodePassFailOldIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, (entity.GsCodePassFailOldId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePassFailOldIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePassFailOldIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.GsCodePassFailOldIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePassFailOldIdSource

			#region GsCodePassFailNewIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|GsCodePassFailNewIdSource", deepLoadType, innerList) 
				&& entity.GsCodePassFailNewIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodePassFailNewId ?? 0.0m);
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePassFailNewIdSource = tmpEntity;
				else
					entity.GsCodePassFailNewIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, (entity.GsCodePassFailNewId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePassFailNewIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePassFailNewIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.GsCodePassFailNewIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePassFailNewIdSource

			#region EdCdeExamTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExamTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCdeExamTypeId;
				EdCdeExamType tmpEntity = EntityManager.LocateEntity<EdCdeExamType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExamType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExamTypeIdSource = tmpEntity;
				else
					entity.EdCdeExamTypeIdSource = DataRepository.EdCdeExamTypeProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeExamTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeExamTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeExamTypeProvider.DeepLoad(transactionManager, entity.EdCdeExamTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeExamTypeIdSource

			#region EdStudCourseRegIdSource	
			if (CanDeepLoad(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseRegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudCourseRegId;
				EdStudCourseReg tmpEntity = EntityManager.LocateEntity<EdStudCourseReg>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseReg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseRegIdSource = tmpEntity;
				else
					entity.EdStudCourseRegIdSource = DataRepository.EdStudCourseRegProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStdCrsExamId methods when available
			
			#region EdStdCrsExamAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdCrsExamAssess>|EdStdCrsExamAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdCrsExamAssessCollection = DataRepository.EdStdCrsExamAssessProvider.GetByEdStdCrsExamId(transactionManager, entity.EdStdCrsExamId);

				if (deep && entity.EdStdCrsExamAssessCollection.Count > 0)
				{
					deepHandles.Add("EdStdCrsExamAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdCrsExamAssess>) DataRepository.EdStdCrsExamAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdCrsExamAssessCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStdCrsExam object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStdCrsExam instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStdCrsExam Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStdCrsExam entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeCourseStatusOldIdSource
			if (CanDeepSave(entity, "EdCodeCourseStatus|EdCodeCourseStatusOldIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseStatusOldIdSource != null)
			{
				DataRepository.EdCodeCourseStatusProvider.Save(transactionManager, entity.EdCodeCourseStatusOldIdSource);
				entity.EdCodeCourseStatusOldId = entity.EdCodeCourseStatusOldIdSource.EdCodeCourseStatusId;
			}
			#endregion 
			
			#region EdCodeCourseStatusNewIdSource
			if (CanDeepSave(entity, "EdCodeCourseStatus|EdCodeCourseStatusNewIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseStatusNewIdSource != null)
			{
				DataRepository.EdCodeCourseStatusProvider.Save(transactionManager, entity.EdCodeCourseStatusNewIdSource);
				entity.EdCodeCourseStatusNewId = entity.EdCodeCourseStatusNewIdSource.EdCodeCourseStatusId;
			}
			#endregion 
			
			#region EdCodeGradingOldIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingOldIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingOldIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingOldIdSource);
				entity.EdCodeGradingOldId = entity.EdCodeGradingOldIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EdCodeGradingNewIdSource
			if (CanDeepSave(entity, "EdCodeGrading|EdCodeGradingNewIdSource", deepSaveType, innerList) 
				&& entity.EdCodeGradingNewIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.EdCodeGradingNewIdSource);
				entity.EdCodeGradingNewId = entity.EdCodeGradingNewIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region GsCodePassFailOldIdSource
			if (CanDeepSave(entity, "GsCodePassFail|GsCodePassFailOldIdSource", deepSaveType, innerList) 
				&& entity.GsCodePassFailOldIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.GsCodePassFailOldIdSource);
				entity.GsCodePassFailOldId = entity.GsCodePassFailOldIdSource.GsCodePassFailId;
			}
			#endregion 
			
			#region GsCodePassFailNewIdSource
			if (CanDeepSave(entity, "GsCodePassFail|GsCodePassFailNewIdSource", deepSaveType, innerList) 
				&& entity.GsCodePassFailNewIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.GsCodePassFailNewIdSource);
				entity.GsCodePassFailNewId = entity.GsCodePassFailNewIdSource.GsCodePassFailId;
			}
			#endregion 
			
			#region EdCdeExamTypeIdSource
			if (CanDeepSave(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExamTypeIdSource != null)
			{
				DataRepository.EdCdeExamTypeProvider.Save(transactionManager, entity.EdCdeExamTypeIdSource);
				entity.EdCdeExamTypeId = entity.EdCdeExamTypeIdSource.EdCdeExamTypeId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStdCrsExamAssess>
				if (CanDeepSave(entity.EdStdCrsExamAssessCollection, "List<EdStdCrsExamAssess>|EdStdCrsExamAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdCrsExamAssess child in entity.EdStdCrsExamAssessCollection)
					{
						if(child.EdStdCrsExamIdSource != null)
						{
							child.EdStdCrsExamId = child.EdStdCrsExamIdSource.EdStdCrsExamId;
						}
						else
						{
							child.EdStdCrsExamId = entity.EdStdCrsExamId;
						}

					}

					if (entity.EdStdCrsExamAssessCollection.Count > 0 || entity.EdStdCrsExamAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdCrsExamAssessProvider.Save(transactionManager, entity.EdStdCrsExamAssessCollection);
						
						deepHandles.Add("EdStdCrsExamAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdCrsExamAssess >) DataRepository.EdStdCrsExamAssessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdCrsExamAssessCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStdCrsExamChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStdCrsExam</c>
	///</summary>
	public enum EdStdCrsExamChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseStatus</c> at EdCodeCourseStatusOldIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseStatus))]
		EdCodeCourseStatus,
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingOldIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>GsCodePassFail</c> at GsCodePassFailOldIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePassFail))]
		GsCodePassFail,
		
		///<summary>
		/// Composite Property for <c>EdCdeExamType</c> at EdCdeExamTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamType))]
		EdCdeExamType,
		
		///<summary>
		/// Composite Property for <c>EdStudCourseReg</c> at EdStudCourseRegIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseReg))]
		EdStudCourseReg,
		///<summary>
		/// Collection of <c>EdStdCrsExam</c> as OneToMany for EdStdCrsExamAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdCrsExamAssess>))]
		EdStdCrsExamAssessCollection,
	}
	
	#endregion EdStdCrsExamChildEntityTypes
	
	#region EdStdCrsExamFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStdCrsExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStdCrsExam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStdCrsExamFilterBuilder : SqlFilterBuilder<EdStdCrsExamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamFilterBuilder class.
		/// </summary>
		public EdStdCrsExamFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStdCrsExamFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStdCrsExamFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStdCrsExamFilterBuilder
	
	#region EdStdCrsExamParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStdCrsExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStdCrsExam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStdCrsExamParameterBuilder : ParameterizedSqlFilterBuilder<EdStdCrsExamColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamParameterBuilder class.
		/// </summary>
		public EdStdCrsExamParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStdCrsExamParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStdCrsExamParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStdCrsExamParameterBuilder
	
	#region EdStdCrsExamSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStdCrsExamColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStdCrsExam"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStdCrsExamSortBuilder : SqlSortBuilder<EdStdCrsExamColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStdCrsExamSqlSortBuilder class.
		/// </summary>
		public EdStdCrsExamSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStdCrsExamSortBuilder
	
} // end namespace
