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
	/// This class is the base class for any <see cref="EdStudCourseGrdChngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseGrdChngProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCourseGrdChng, UMIS_VER2.BusinessLyer.EdStudCourseGrdChngKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseGrdChngKey key)
		{
			return Delete(transactionManager, key.EdStudCourseGrdChngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCourseGrdChngId">طلب تعديل تقدير مقرر    -طلب تظلم في تقدير مقرر. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCourseGrdChngId)
		{
			return Delete(null, _edStudCourseGrdChngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseGrdChngId">طلب تعديل تقدير مقرر    -طلب تظلم في تقدير مقرر. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCourseGrdChngId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CDE_GRD_CHNG_RSN key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CDE_GRD_CHNG_RSN Description: 
		/// </summary>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCdeGrdChngRsnId(System.Decimal? _edCdeGrdChngRsnId)
		{
			int count = -1;
			return GetByEdCdeGrdChngRsnId(_edCdeGrdChngRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CDE_GRD_CHNG_RSN key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CDE_GRD_CHNG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseGrdChng> GetByEdCdeGrdChngRsnId(TransactionManager transactionManager, System.Decimal? _edCdeGrdChngRsnId)
		{
			int count = -1;
			return GetByEdCdeGrdChngRsnId(transactionManager, _edCdeGrdChngRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CDE_GRD_CHNG_RSN key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CDE_GRD_CHNG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCdeGrdChngRsnId(TransactionManager transactionManager, System.Decimal? _edCdeGrdChngRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeGrdChngRsnId(transactionManager, _edCdeGrdChngRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CDE_GRD_CHNG_RSN key.
		///		fkEdStudCourseGrdChngEdCdeGrdChngRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCdeGrdChngRsnId(System.Decimal? _edCdeGrdChngRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeGrdChngRsnId(null, _edCdeGrdChngRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CDE_GRD_CHNG_RSN key.
		///		fkEdStudCourseGrdChngEdCdeGrdChngRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCdeGrdChngRsnId(System.Decimal? _edCdeGrdChngRsnId, int start, int pageLength,out int count)
		{
			return GetByEdCdeGrdChngRsnId(null, _edCdeGrdChngRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CDE_GRD_CHNG_RSN key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CDE_GRD_CHNG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeGrdChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public abstract TList<EdStudCourseGrdChng> GetByEdCdeGrdChngRsnId(TransactionManager transactionManager, System.Decimal? _edCdeGrdChngRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="_edCodeCourseStsOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeCourseStsOldId(System.Decimal _edCodeCourseStsOldId)
		{
			int count = -1;
			return GetByEdCodeCourseStsOldId(_edCodeCourseStsOldId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStsOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseGrdChng> GetByEdCodeCourseStsOldId(TransactionManager transactionManager, System.Decimal _edCodeCourseStsOldId)
		{
			int count = -1;
			return GetByEdCodeCourseStsOldId(transactionManager, _edCodeCourseStsOldId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStsOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeCourseStsOldId(TransactionManager transactionManager, System.Decimal _edCodeCourseStsOldId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStsOldId(transactionManager, _edCodeCourseStsOldId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS key.
		///		fkEdStudCourseGrdChngEdCodeCourseStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStsOldId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeCourseStsOldId(System.Decimal _edCodeCourseStsOldId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseStsOldId(null, _edCodeCourseStsOldId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS key.
		///		fkEdStudCourseGrdChngEdCodeCourseStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStsOldId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeCourseStsOldId(System.Decimal _edCodeCourseStsOldId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseStsOldId(null, _edCodeCourseStsOldId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStsOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public abstract TList<EdStudCourseGrdChng> GetByEdCodeCourseStsOldId(TransactionManager transactionManager, System.Decimal _edCodeCourseStsOldId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS1 key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS1 Description: 
		/// </summary>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeCourseStsNewId(System.Decimal? _edCodeCourseStsNewId)
		{
			int count = -1;
			return GetByEdCodeCourseStsNewId(_edCodeCourseStsNewId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS1 key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseGrdChng> GetByEdCodeCourseStsNewId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStsNewId)
		{
			int count = -1;
			return GetByEdCodeCourseStsNewId(transactionManager, _edCodeCourseStsNewId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS1 key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeCourseStsNewId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStsNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStsNewId(transactionManager, _edCodeCourseStsNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS1 key.
		///		fkEdStudCourseGrdChngEdCodeCourseStatus1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeCourseStsNewId(System.Decimal? _edCodeCourseStsNewId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseStsNewId(null, _edCodeCourseStsNewId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS1 key.
		///		fkEdStudCourseGrdChngEdCodeCourseStatus1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeCourseStsNewId(System.Decimal? _edCodeCourseStsNewId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseStsNewId(null, _edCodeCourseStsNewId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS1 key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_COURSE_STATUS1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public abstract TList<EdStudCourseGrdChng> GetByEdCodeCourseStsNewId(TransactionManager transactionManager, System.Decimal? _edCodeCourseStsNewId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_edCodeGradingOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeGradingOldId(System.Decimal? _edCodeGradingOldId)
		{
			int count = -1;
			return GetByEdCodeGradingOldId(_edCodeGradingOldId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseGrdChng> GetByEdCodeGradingOldId(TransactionManager transactionManager, System.Decimal? _edCodeGradingOldId)
		{
			int count = -1;
			return GetByEdCodeGradingOldId(transactionManager, _edCodeGradingOldId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeGradingOldId(TransactionManager transactionManager, System.Decimal? _edCodeGradingOldId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingOldId(transactionManager, _edCodeGradingOldId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING key.
		///		fkEdStudCourseGrdChngEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeGradingOldId(System.Decimal? _edCodeGradingOldId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingOldId(null, _edCodeGradingOldId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING key.
		///		fkEdStudCourseGrdChngEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeGradingOldId(System.Decimal? _edCodeGradingOldId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingOldId(null, _edCodeGradingOldId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public abstract TList<EdStudCourseGrdChng> GetByEdCodeGradingOldId(TransactionManager transactionManager, System.Decimal? _edCodeGradingOldId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="_edCodeGradingNewId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeGradingNewId(System.Decimal? _edCodeGradingNewId)
		{
			int count = -1;
			return GetByEdCodeGradingNewId(_edCodeGradingNewId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseGrdChng> GetByEdCodeGradingNewId(TransactionManager transactionManager, System.Decimal? _edCodeGradingNewId)
		{
			int count = -1;
			return GetByEdCodeGradingNewId(transactionManager, _edCodeGradingNewId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeGradingNewId(TransactionManager transactionManager, System.Decimal? _edCodeGradingNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingNewId(transactionManager, _edCodeGradingNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING1 key.
		///		fkEdStudCourseGrdChngEdCodeGrading1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeGradingNewId(System.Decimal? _edCodeGradingNewId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeGradingNewId(null, _edCodeGradingNewId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING1 key.
		///		fkEdStudCourseGrdChngEdCodeGrading1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByEdCodeGradingNewId(System.Decimal? _edCodeGradingNewId, int start, int pageLength,out int count)
		{
			return GetByEdCodeGradingNewId(null, _edCodeGradingNewId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public abstract TList<EdStudCourseGrdChng> GetByEdCodeGradingNewId(TransactionManager transactionManager, System.Decimal? _edCodeGradingNewId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_FEE_STUD_FEE_ITEM key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(_feeStudFeeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_FEE_STUD_FEE_ITEM key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseGrdChng> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_FEE_STUD_FEE_ITEM key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_FEE_STUD_FEE_ITEM key.
		///		fkEdStudCourseGrdChngFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_FEE_STUD_FEE_ITEM key.
		///		fkEdStudCourseGrdChngFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_FEE_STUD_FEE_ITEM key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public abstract TList<EdStudCourseGrdChng> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SA_STF_MEMBER key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemApprovedById"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySaStfMemApprovedById(System.Decimal? _saStfMemApprovedById)
		{
			int count = -1;
			return GetBySaStfMemApprovedById(_saStfMemApprovedById, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SA_STF_MEMBER key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemApprovedById"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseGrdChng> GetBySaStfMemApprovedById(TransactionManager transactionManager, System.Decimal? _saStfMemApprovedById)
		{
			int count = -1;
			return GetBySaStfMemApprovedById(transactionManager, _saStfMemApprovedById, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SA_STF_MEMBER key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemApprovedById"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySaStfMemApprovedById(TransactionManager transactionManager, System.Decimal? _saStfMemApprovedById, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemApprovedById(transactionManager, _saStfMemApprovedById, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SA_STF_MEMBER key.
		///		fkEdStudCourseGrdChngSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemApprovedById"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySaStfMemApprovedById(System.Decimal? _saStfMemApprovedById, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemApprovedById(null, _saStfMemApprovedById, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SA_STF_MEMBER key.
		///		fkEdStudCourseGrdChngSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemApprovedById"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySaStfMemApprovedById(System.Decimal? _saStfMemApprovedById, int start, int pageLength,out int count)
		{
			return GetBySaStfMemApprovedById(null, _saStfMemApprovedById, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SA_STF_MEMBER key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemApprovedById"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public abstract TList<EdStudCourseGrdChng> GetBySaStfMemApprovedById(TransactionManager transactionManager, System.Decimal? _saStfMemApprovedById, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_CODE_USER_TYPE key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId">طالب-ستاف-رئيس قسم WF</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_CODE_USER_TYPE key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">طالب-ستاف-رئيس قسم WF</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseGrdChng> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_CODE_USER_TYPE key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">طالب-ستاف-رئيس قسم WF</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_CODE_USER_TYPE key.
		///		fkEdStudCourseGrdChngSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId">طالب-ستاف-رئيس قسم WF</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_CODE_USER_TYPE key.
		///		fkEdStudCourseGrdChngSeCodeUserType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId">طالب-ستاف-رئيس قسم WF</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_CODE_USER_TYPE key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId">طالب-ستاف-رئيس قسم WF</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public abstract TList<EdStudCourseGrdChng> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_FORM key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_FORM Description: 
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeFormId(System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(_seFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_FORM key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseGrdChng> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_FORM key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_FORM key.
		///		fkEdStudCourseGrdChngSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormId(null, _seFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_FORM key.
		///		fkEdStudCourseGrdChngSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength,out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_FORM key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public abstract TList<EdStudCourseGrdChng> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_USER key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_USER key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseGrdChng> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_USER key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_USER key.
		///		fkEdStudCourseGrdChngSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_USER key.
		///		fkEdStudCourseGrdChngSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public TList<EdStudCourseGrdChng> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_GRD_CHNG_SE_USER key.
		///		FK_ED_STUD_COURSE_GRD_CHNG_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseGrdChng objects.</returns>
		public abstract TList<EdStudCourseGrdChng> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCourseGrdChng Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseGrdChngKey key, int start, int pageLength)
		{
			return GetByEdStudCourseGrdChngId(transactionManager, key.EdStudCourseGrdChngId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseGrdChng&gt;"/> class.</returns>
		public TList<EdStudCourseGrdChng> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(null,_edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseGrdChng&gt;"/> class.</returns>
		public TList<EdStudCourseGrdChng> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseGrdChng&gt;"/> class.</returns>
		public TList<EdStudCourseGrdChng> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseGrdChng&gt;"/> class.</returns>
		public TList<EdStudCourseGrdChng> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseGrdChng&gt;"/> class.</returns>
		public TList<EdStudCourseGrdChng> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseGrdChng&gt;"/> class.</returns>
		public abstract TList<EdStudCourseGrdChng> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="_edStudCourseGrdChngId">طلب تعديل تقدير مقرر    -طلب تظلم في تقدير مقرر</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseGrdChngId(System.Decimal _edStudCourseGrdChngId)
		{
			int count = -1;
			return GetByEdStudCourseGrdChngId(null,_edStudCourseGrdChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="_edStudCourseGrdChngId">طلب تعديل تقدير مقرر    -طلب تظلم في تقدير مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseGrdChngId(System.Decimal _edStudCourseGrdChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseGrdChngId(null, _edStudCourseGrdChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseGrdChngId">طلب تعديل تقدير مقرر    -طلب تظلم في تقدير مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseGrdChngId(TransactionManager transactionManager, System.Decimal _edStudCourseGrdChngId)
		{
			int count = -1;
			return GetByEdStudCourseGrdChngId(transactionManager, _edStudCourseGrdChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseGrdChngId">طلب تعديل تقدير مقرر    -طلب تظلم في تقدير مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseGrdChngId(TransactionManager transactionManager, System.Decimal _edStudCourseGrdChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseGrdChngId(transactionManager, _edStudCourseGrdChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="_edStudCourseGrdChngId">طلب تعديل تقدير مقرر    -طلب تظلم في تقدير مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseGrdChngId(System.Decimal _edStudCourseGrdChngId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseGrdChngId(null, _edStudCourseGrdChngId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseGrdChngId">طلب تعديل تقدير مقرر    -طلب تظلم في تقدير مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseGrdChngId(TransactionManager transactionManager, System.Decimal _edStudCourseGrdChngId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(System.Decimal _edStudCourseRegId, System.Decimal? _edCodeCourseStsNewId, System.Decimal? _edCodeGradingOldId, System.Decimal? _edCodeGradingNewId)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(null,_edStudCourseRegId, _edCodeCourseStsNewId, _edCodeGradingOldId, _edCodeGradingNewId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(System.Decimal _edStudCourseRegId, System.Decimal? _edCodeCourseStsNewId, System.Decimal? _edCodeGradingOldId, System.Decimal? _edCodeGradingNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(null, _edStudCourseRegId, _edCodeCourseStsNewId, _edCodeGradingOldId, _edCodeGradingNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, System.Decimal? _edCodeCourseStsNewId, System.Decimal? _edCodeGradingOldId, System.Decimal? _edCodeGradingNewId)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(transactionManager, _edStudCourseRegId, _edCodeCourseStsNewId, _edCodeGradingOldId, _edCodeGradingNewId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, System.Decimal? _edCodeCourseStsNewId, System.Decimal? _edCodeGradingOldId, System.Decimal? _edCodeGradingNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(transactionManager, _edStudCourseRegId, _edCodeCourseStsNewId, _edCodeGradingOldId, _edCodeGradingNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(System.Decimal _edStudCourseRegId, System.Decimal? _edCodeCourseStsNewId, System.Decimal? _edCodeGradingOldId, System.Decimal? _edCodeGradingNewId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(null, _edStudCourseRegId, _edCodeCourseStsNewId, _edCodeGradingOldId, _edCodeGradingNewId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_GRD_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="_edCodeCourseStsNewId"></param>
		/// <param name="_edCodeGradingOldId"></param>
		/// <param name="_edCodeGradingNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseGrdChng GetByEdStudCourseRegIdEdCodeCourseStsNewIdEdCodeGradingOldIdEdCodeGradingNewId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, System.Decimal? _edCodeCourseStsNewId, System.Decimal? _edCodeGradingOldId, System.Decimal? _edCodeGradingNewId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCourseGrdChng&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCourseGrdChng&gt;"/></returns>
		public static TList<EdStudCourseGrdChng> Fill(IDataReader reader, TList<EdStudCourseGrdChng> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCourseGrdChng c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCourseGrdChng")
					.Append("|").Append((System.Decimal)reader["ED_STUD_COURSE_GRD_CHNG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCourseGrdChng>(
					key.ToString(), // EntityTrackingKey
					"EdStudCourseGrdChng",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCourseGrdChng();
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
					c.EdStudCourseGrdChngId = (System.Decimal)reader["ED_STUD_COURSE_GRD_CHNG_ID"];
					c.OriginalEdStudCourseGrdChngId = c.EdStudCourseGrdChngId;
					c.SeCodeUserTypeId = Convert.IsDBNull(reader["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)reader["SE_CODE_USER_TYPE_ID"];
					c.EdStudCourseRegId = (System.Decimal)reader["ED_STUD_COURSE_REG_ID"];
					c.EdCodeCourseStsOldId = (System.Decimal)reader["ED_CODE_COURSE_STS_OLD_ID"];
					c.EdCodeCourseStsNewId = Convert.IsDBNull(reader["ED_CODE_COURSE_STS_NEW_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_STS_NEW_ID"];
					c.EdCodeGradingOldId = Convert.IsDBNull(reader["ED_CODE_GRADING_OLD_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_OLD_ID"];
					c.EdCodeGradingNewId = Convert.IsDBNull(reader["ED_CODE_GRADING_NEW_ID"]) ? null : (System.Decimal?)reader["ED_CODE_GRADING_NEW_ID"];
					c.EdCdeGrdChngRsnId = Convert.IsDBNull(reader["ED_CDE_GRD_CHNG_RSN_ID"]) ? null : (System.Decimal?)reader["ED_CDE_GRD_CHNG_RSN_ID"];
					c.ReqDate = Convert.IsDBNull(reader["REQ_DATE"]) ? null : (System.DateTime?)reader["REQ_DATE"];
					c.DecisionNo = Convert.IsDBNull(reader["DECISION_NO"]) ? null : (System.String)reader["DECISION_NO"];
					c.DecisionDate = Convert.IsDBNull(reader["DECISION_DATE"]) ? null : (System.DateTime?)reader["DECISION_DATE"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Decimal?)reader["APPROVE_FLG"];
					c.SaStfMemApprovedById = Convert.IsDBNull(reader["SA_STF_MEM_APPROVED_BY_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEM_APPROVED_BY_ID"];
					c.IsLast = (System.Decimal)reader["IS_LAST"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.FeeStudFeeItemId = Convert.IsDBNull(reader["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_FEE_ITEM_ID"];
					c.CommFlg = Convert.IsDBNull(reader["COMM_FLG"]) ? null : (System.Int32?)reader["COMM_FLG"];
					c.StaffFlg = Convert.IsDBNull(reader["STAFF_FLG"]) ? null : (System.Int32?)reader["STAFF_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCourseGrdChng entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCourseGrdChngId = (System.Decimal)reader[((int)EdStudCourseGrdChngColumn.EdStudCourseGrdChngId - 1)];
			entity.OriginalEdStudCourseGrdChngId = (System.Decimal)reader["ED_STUD_COURSE_GRD_CHNG_ID"];
			entity.SeCodeUserTypeId = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.SeCodeUserTypeId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseGrdChngColumn.SeCodeUserTypeId - 1)];
			entity.EdStudCourseRegId = (System.Decimal)reader[((int)EdStudCourseGrdChngColumn.EdStudCourseRegId - 1)];
			entity.EdCodeCourseStsOldId = (System.Decimal)reader[((int)EdStudCourseGrdChngColumn.EdCodeCourseStsOldId - 1)];
			entity.EdCodeCourseStsNewId = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.EdCodeCourseStsNewId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseGrdChngColumn.EdCodeCourseStsNewId - 1)];
			entity.EdCodeGradingOldId = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.EdCodeGradingOldId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseGrdChngColumn.EdCodeGradingOldId - 1)];
			entity.EdCodeGradingNewId = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.EdCodeGradingNewId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseGrdChngColumn.EdCodeGradingNewId - 1)];
			entity.EdCdeGrdChngRsnId = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.EdCdeGrdChngRsnId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseGrdChngColumn.EdCdeGrdChngRsnId - 1)];
			entity.ReqDate = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.ReqDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseGrdChngColumn.ReqDate - 1)];
			entity.DecisionNo = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.DecisionNo - 1)))?null:(System.String)reader[((int)EdStudCourseGrdChngColumn.DecisionNo - 1)];
			entity.DecisionDate = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.DecisionDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseGrdChngColumn.DecisionDate - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.ApproveFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseGrdChngColumn.ApproveFlg - 1)];
			entity.SaStfMemApprovedById = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.SaStfMemApprovedById - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseGrdChngColumn.SaStfMemApprovedById - 1)];
			entity.IsLast = (System.Decimal)reader[((int)EdStudCourseGrdChngColumn.IsLast - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudCourseGrdChngColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseGrdChngColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseGrdChngColumn.SeUserId - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseGrdChngColumn.SeFormId - 1)];
			entity.FeeStudFeeItemId = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.FeeStudFeeItemId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseGrdChngColumn.FeeStudFeeItemId - 1)];
			entity.CommFlg = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.CommFlg - 1)))?null:(System.Int32?)reader[((int)EdStudCourseGrdChngColumn.CommFlg - 1)];
			entity.StaffFlg = (reader.IsDBNull(((int)EdStudCourseGrdChngColumn.StaffFlg - 1)))?null:(System.Int32?)reader[((int)EdStudCourseGrdChngColumn.StaffFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCourseGrdChng entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCourseGrdChngId = (System.Decimal)dataRow["ED_STUD_COURSE_GRD_CHNG_ID"];
			entity.OriginalEdStudCourseGrdChngId = (System.Decimal)dataRow["ED_STUD_COURSE_GRD_CHNG_ID"];
			entity.SeCodeUserTypeId = Convert.IsDBNull(dataRow["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.EdStudCourseRegId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.EdCodeCourseStsOldId = (System.Decimal)dataRow["ED_CODE_COURSE_STS_OLD_ID"];
			entity.EdCodeCourseStsNewId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_STS_NEW_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_STS_NEW_ID"];
			entity.EdCodeGradingOldId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_OLD_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_OLD_ID"];
			entity.EdCodeGradingNewId = Convert.IsDBNull(dataRow["ED_CODE_GRADING_NEW_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_GRADING_NEW_ID"];
			entity.EdCdeGrdChngRsnId = Convert.IsDBNull(dataRow["ED_CDE_GRD_CHNG_RSN_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_GRD_CHNG_RSN_ID"];
			entity.ReqDate = Convert.IsDBNull(dataRow["REQ_DATE"]) ? null : (System.DateTime?)dataRow["REQ_DATE"];
			entity.DecisionNo = Convert.IsDBNull(dataRow["DECISION_NO"]) ? null : (System.String)dataRow["DECISION_NO"];
			entity.DecisionDate = Convert.IsDBNull(dataRow["DECISION_DATE"]) ? null : (System.DateTime?)dataRow["DECISION_DATE"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Decimal?)dataRow["APPROVE_FLG"];
			entity.SaStfMemApprovedById = Convert.IsDBNull(dataRow["SA_STF_MEM_APPROVED_BY_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEM_APPROVED_BY_ID"];
			entity.IsLast = (System.Decimal)dataRow["IS_LAST"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.FeeStudFeeItemId = Convert.IsDBNull(dataRow["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.CommFlg = Convert.IsDBNull(dataRow["COMM_FLG"]) ? null : (System.Int32?)dataRow["COMM_FLG"];
			entity.StaffFlg = Convert.IsDBNull(dataRow["STAFF_FLG"]) ? null : (System.Int32?)dataRow["STAFF_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseGrdChng"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseGrdChng Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseGrdChng entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCdeGrdChngRsnIdSource	
			if (CanDeepLoad(entity, "EdCdeGrdChngRsn|EdCdeGrdChngRsnIdSource", deepLoadType, innerList) 
				&& entity.EdCdeGrdChngRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeGrdChngRsnId ?? 0.0m);
				EdCdeGrdChngRsn tmpEntity = EntityManager.LocateEntity<EdCdeGrdChngRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeGrdChngRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeGrdChngRsnIdSource = tmpEntity;
				else
					entity.EdCdeGrdChngRsnIdSource = DataRepository.EdCdeGrdChngRsnProvider.GetByEdCdeGrdChngRsnId(transactionManager, (entity.EdCdeGrdChngRsnId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeGrdChngRsnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeGrdChngRsnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeGrdChngRsnProvider.DeepLoad(transactionManager, entity.EdCdeGrdChngRsnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeGrdChngRsnIdSource

			#region EdCodeCourseStsOldIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseStatus|EdCodeCourseStsOldIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseStsOldIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeCourseStsOldId;
				EdCodeCourseStatus tmpEntity = EntityManager.LocateEntity<EdCodeCourseStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseStsOldIdSource = tmpEntity;
				else
					entity.EdCodeCourseStsOldIdSource = DataRepository.EdCodeCourseStatusProvider.GetByEdCodeCourseStatusId(transactionManager, entity.EdCodeCourseStsOldId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseStsOldIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseStsOldIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseStatusProvider.DeepLoad(transactionManager, entity.EdCodeCourseStsOldIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseStsOldIdSource

			#region EdCodeCourseStsNewIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseStatus|EdCodeCourseStsNewIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseStsNewIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseStsNewId ?? 0.0m);
				EdCodeCourseStatus tmpEntity = EntityManager.LocateEntity<EdCodeCourseStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseStsNewIdSource = tmpEntity;
				else
					entity.EdCodeCourseStsNewIdSource = DataRepository.EdCodeCourseStatusProvider.GetByEdCodeCourseStatusId(transactionManager, (entity.EdCodeCourseStsNewId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseStsNewIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseStsNewIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseStatusProvider.DeepLoad(transactionManager, entity.EdCodeCourseStsNewIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseStsNewIdSource

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

			#region FeeStudFeeItemIdSource	
			if (CanDeepLoad(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeStudFeeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudFeeItemId ?? 0.0m);
				FeeStudFeeItem tmpEntity = EntityManager.LocateEntity<FeeStudFeeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudFeeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudFeeItemIdSource = tmpEntity;
				else
					entity.FeeStudFeeItemIdSource = DataRepository.FeeStudFeeItemProvider.GetByFeeStudFeeItemId(transactionManager, (entity.FeeStudFeeItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudFeeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudFeeItemProvider.DeepLoad(transactionManager, entity.FeeStudFeeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudFeeItemIdSource

			#region SaStfMemApprovedByIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemApprovedByIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemApprovedByIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemApprovedById ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemApprovedByIdSource = tmpEntity;
				else
					entity.SaStfMemApprovedByIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemApprovedById ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemApprovedByIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemApprovedByIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemApprovedByIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemApprovedByIdSource

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeCodeUserTypeId ?? 0.0m);
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, (entity.SeCodeUserTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserTypeProvider.DeepLoad(transactionManager, entity.SeCodeUserTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserTypeIdSource

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeFormId ?? 0.0m);
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, (entity.SeFormId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudCourseGrdChngId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByEdStudCourseGrdChngId(transactionManager, entity.EdStudCourseGrdChngId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region WfCrsRsltApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WfCrsRsltApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.WfCrsRsltApproveCollection = DataRepository.WfCrsRsltApproveProvider.GetByEdStudCourseGrdChngId(transactionManager, entity.EdStudCourseGrdChngId);

				if (deep && entity.WfCrsRsltApproveCollection.Count > 0)
				{
					deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<WfCrsRsltApprove>) DataRepository.WfCrsRsltApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCourseGrdChng object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCourseGrdChng instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseGrdChng Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseGrdChng entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCdeGrdChngRsnIdSource
			if (CanDeepSave(entity, "EdCdeGrdChngRsn|EdCdeGrdChngRsnIdSource", deepSaveType, innerList) 
				&& entity.EdCdeGrdChngRsnIdSource != null)
			{
				DataRepository.EdCdeGrdChngRsnProvider.Save(transactionManager, entity.EdCdeGrdChngRsnIdSource);
				entity.EdCdeGrdChngRsnId = entity.EdCdeGrdChngRsnIdSource.EdCdeGrdChngRsnId;
			}
			#endregion 
			
			#region EdCodeCourseStsOldIdSource
			if (CanDeepSave(entity, "EdCodeCourseStatus|EdCodeCourseStsOldIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseStsOldIdSource != null)
			{
				DataRepository.EdCodeCourseStatusProvider.Save(transactionManager, entity.EdCodeCourseStsOldIdSource);
				entity.EdCodeCourseStsOldId = entity.EdCodeCourseStsOldIdSource.EdCodeCourseStatusId;
			}
			#endregion 
			
			#region EdCodeCourseStsNewIdSource
			if (CanDeepSave(entity, "EdCodeCourseStatus|EdCodeCourseStsNewIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseStsNewIdSource != null)
			{
				DataRepository.EdCodeCourseStatusProvider.Save(transactionManager, entity.EdCodeCourseStsNewIdSource);
				entity.EdCodeCourseStsNewId = entity.EdCodeCourseStsNewIdSource.EdCodeCourseStatusId;
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
			
			#region EdStudCourseRegIdSource
			if (CanDeepSave(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseRegIdSource != null)
			{
				DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegIdSource);
				entity.EdStudCourseRegId = entity.EdStudCourseRegIdSource.EdStudCourseRegId;
			}
			#endregion 
			
			#region FeeStudFeeItemIdSource
			if (CanDeepSave(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeStudFeeItemIdSource != null)
			{
				DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemIdSource);
				entity.FeeStudFeeItemId = entity.FeeStudFeeItemIdSource.FeeStudFeeItemId;
			}
			#endregion 
			
			#region SaStfMemApprovedByIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemApprovedByIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemApprovedByIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemApprovedByIdSource);
				entity.SaStfMemApprovedById = entity.SaStfMemApprovedByIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region SeCodeUserTypeIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeIdSource);
				entity.SeCodeUserTypeId = entity.SeCodeUserTypeIdSource.SeCodeUserTypeId;
			}
			#endregion 
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
			}
			#endregion 
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.EdStudCourseGrdChngIdSource != null)
						{
							child.EdStudCourseGrdChngId = child.EdStudCourseGrdChngIdSource.EdStudCourseGrdChngId;
						}
						else
						{
							child.EdStudCourseGrdChngId = entity.EdStudCourseGrdChngId;
						}

					}

					if (entity.GsAttchdDocCollection.Count > 0 || entity.GsAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollection);
						
						deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<WfCrsRsltApprove>
				if (CanDeepSave(entity.WfCrsRsltApproveCollection, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(WfCrsRsltApprove child in entity.WfCrsRsltApproveCollection)
					{
						if(child.EdStudCourseGrdChngIdSource != null)
						{
							child.EdStudCourseGrdChngId = child.EdStudCourseGrdChngIdSource.EdStudCourseGrdChngId;
						}
						else
						{
							child.EdStudCourseGrdChngId = entity.EdStudCourseGrdChngId;
						}

					}

					if (entity.WfCrsRsltApproveCollection.Count > 0 || entity.WfCrsRsltApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.WfCrsRsltApproveProvider.Save(transactionManager, entity.WfCrsRsltApproveCollection);
						
						deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< WfCrsRsltApprove >) DataRepository.WfCrsRsltApproveProvider.DeepSave,
							new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudCourseGrdChngChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCourseGrdChng</c>
	///</summary>
	public enum EdStudCourseGrdChngChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCdeGrdChngRsn</c> at EdCdeGrdChngRsnIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeGrdChngRsn))]
		EdCdeGrdChngRsn,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseStatus</c> at EdCodeCourseStsOldIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseStatus))]
		EdCodeCourseStatus,
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at EdCodeGradingOldIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdStudCourseReg</c> at EdStudCourseRegIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseReg))]
		EdStudCourseReg,
		
		///<summary>
		/// Composite Property for <c>FeeStudFeeItem</c> at FeeStudFeeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudFeeItem))]
		FeeStudFeeItem,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemApprovedByIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		
		///<summary>
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>EdStudCourseGrdChng</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
		///<summary>
		/// Collection of <c>EdStudCourseGrdChng</c> as OneToMany for WfCrsRsltApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<WfCrsRsltApprove>))]
		WfCrsRsltApproveCollection,
	}
	
	#endregion EdStudCourseGrdChngChildEntityTypes
	
	#region EdStudCourseGrdChngFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCourseGrdChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseGrdChng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseGrdChngFilterBuilder : SqlFilterBuilder<EdStudCourseGrdChngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseGrdChngFilterBuilder class.
		/// </summary>
		public EdStudCourseGrdChngFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseGrdChngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseGrdChngFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseGrdChngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseGrdChngFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseGrdChngFilterBuilder
	
	#region EdStudCourseGrdChngParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCourseGrdChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseGrdChng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseGrdChngParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCourseGrdChngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseGrdChngParameterBuilder class.
		/// </summary>
		public EdStudCourseGrdChngParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseGrdChngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseGrdChngParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseGrdChngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseGrdChngParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseGrdChngParameterBuilder
	
	#region EdStudCourseGrdChngSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCourseGrdChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseGrdChng"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCourseGrdChngSortBuilder : SqlSortBuilder<EdStudCourseGrdChngColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseGrdChngSqlSortBuilder class.
		/// </summary>
		public EdStudCourseGrdChngSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCourseGrdChngSortBuilder
	
} // end namespace
