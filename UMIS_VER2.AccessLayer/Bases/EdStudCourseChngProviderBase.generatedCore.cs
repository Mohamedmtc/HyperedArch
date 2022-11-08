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
	/// This class is the base class for any <see cref="EdStudCourseChngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseChngProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCourseChng, UMIS_VER2.BusinessLyer.EdStudCourseChngKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseChngKey key)
		{
			return Delete(transactionManager, key.EdStudCourseChngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCourseChngId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCourseChngId)
		{
			return Delete(null, _edStudCourseChngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseChngId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCourseChngId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_CDE_COURSE_CHNG_RSN key.
		///		FK_ED_STUD_COURSE_CHNG_ED_CDE_COURSE_CHNG_RSN Description: 
		/// </summary>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetByEdCdeCourseChngRsnId(System.Decimal? _edCdeCourseChngRsnId)
		{
			int count = -1;
			return GetByEdCdeCourseChngRsnId(_edCdeCourseChngRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_CDE_COURSE_CHNG_RSN key.
		///		FK_ED_STUD_COURSE_CHNG_ED_CDE_COURSE_CHNG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseChng> GetByEdCdeCourseChngRsnId(TransactionManager transactionManager, System.Decimal? _edCdeCourseChngRsnId)
		{
			int count = -1;
			return GetByEdCdeCourseChngRsnId(transactionManager, _edCdeCourseChngRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_CDE_COURSE_CHNG_RSN key.
		///		FK_ED_STUD_COURSE_CHNG_ED_CDE_COURSE_CHNG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetByEdCdeCourseChngRsnId(TransactionManager transactionManager, System.Decimal? _edCdeCourseChngRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeCourseChngRsnId(transactionManager, _edCdeCourseChngRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_CDE_COURSE_CHNG_RSN key.
		///		fkEdStudCourseChngEdCdeCourseChngRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetByEdCdeCourseChngRsnId(System.Decimal? _edCdeCourseChngRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeCourseChngRsnId(null, _edCdeCourseChngRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_CDE_COURSE_CHNG_RSN key.
		///		fkEdStudCourseChngEdCdeCourseChngRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetByEdCdeCourseChngRsnId(System.Decimal? _edCdeCourseChngRsnId, int start, int pageLength,out int count)
		{
			return GetByEdCdeCourseChngRsnId(null, _edCdeCourseChngRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_CDE_COURSE_CHNG_RSN key.
		///		FK_ED_STUD_COURSE_CHNG_ED_CDE_COURSE_CHNG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeCourseChngRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public abstract TList<EdStudCourseChng> GetByEdCdeCourseChngRsnId(TransactionManager transactionManager, System.Decimal? _edCdeCourseChngRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_CHNG_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="_edCourseSubId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetByEdCourseSubId(System.Decimal? _edCourseSubId)
		{
			int count = -1;
			return GetByEdCourseSubId(_edCourseSubId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_CHNG_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseSubId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseChng> GetByEdCourseSubId(TransactionManager transactionManager, System.Decimal? _edCourseSubId)
		{
			int count = -1;
			return GetByEdCourseSubId(transactionManager, _edCourseSubId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_CHNG_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseSubId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetByEdCourseSubId(TransactionManager transactionManager, System.Decimal? _edCourseSubId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseSubId(transactionManager, _edCourseSubId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_COURSE1 key.
		///		fkEdStudCourseChngEdCourse1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseSubId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetByEdCourseSubId(System.Decimal? _edCourseSubId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseSubId(null, _edCourseSubId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_COURSE1 key.
		///		fkEdStudCourseChngEdCourse1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseSubId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetByEdCourseSubId(System.Decimal? _edCourseSubId, int start, int pageLength,out int count)
		{
			return GetByEdCourseSubId(null, _edCourseSubId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_CHNG_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseSubId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public abstract TList<EdStudCourseChng> GetByEdCourseSubId(TransactionManager transactionManager, System.Decimal? _edCourseSubId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_FORM key.
		///		FK_ED_STUD_COURSE_CHNG_SE_FORM Description: 
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeFormId(System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(_seFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_FORM key.
		///		FK_ED_STUD_COURSE_CHNG_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseChng> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_FORM key.
		///		FK_ED_STUD_COURSE_CHNG_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_FORM key.
		///		fkEdStudCourseChngSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormId(null, _seFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_FORM key.
		///		fkEdStudCourseChngSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeFormId(System.Decimal? _seFormId, int start, int pageLength,out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_FORM key.
		///		FK_ED_STUD_COURSE_CHNG_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public abstract TList<EdStudCourseChng> GetBySeFormId(TransactionManager transactionManager, System.Decimal? _seFormId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER key.
		///		FK_ED_STUD_COURSE_CHNG_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER key.
		///		FK_ED_STUD_COURSE_CHNG_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseChng> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER key.
		///		FK_ED_STUD_COURSE_CHNG_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER key.
		///		fkEdStudCourseChngSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER key.
		///		fkEdStudCourseChngSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER key.
		///		FK_ED_STUD_COURSE_CHNG_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public abstract TList<EdStudCourseChng> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER1 key.
		///		FK_ED_STUD_COURSE_CHNG_SE_USER1 Description: 
		/// </summary>
		/// <param name="_seUserInsrtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeUserInsrtId(System.Decimal? _seUserInsrtId)
		{
			int count = -1;
			return GetBySeUserInsrtId(_seUserInsrtId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER1 key.
		///		FK_ED_STUD_COURSE_CHNG_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserInsrtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseChng> GetBySeUserInsrtId(TransactionManager transactionManager, System.Decimal? _seUserInsrtId)
		{
			int count = -1;
			return GetBySeUserInsrtId(transactionManager, _seUserInsrtId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER1 key.
		///		FK_ED_STUD_COURSE_CHNG_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserInsrtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeUserInsrtId(TransactionManager transactionManager, System.Decimal? _seUserInsrtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserInsrtId(transactionManager, _seUserInsrtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER1 key.
		///		fkEdStudCourseChngSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserInsrtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeUserInsrtId(System.Decimal? _seUserInsrtId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserInsrtId(null, _seUserInsrtId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER1 key.
		///		fkEdStudCourseChngSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserInsrtId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public TList<EdStudCourseChng> GetBySeUserInsrtId(System.Decimal? _seUserInsrtId, int start, int pageLength,out int count)
		{
			return GetBySeUserInsrtId(null, _seUserInsrtId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_CHNG_SE_USER1 key.
		///		FK_ED_STUD_COURSE_CHNG_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserInsrtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseChng objects.</returns>
		public abstract TList<EdStudCourseChng> GetBySeUserInsrtId(TransactionManager transactionManager, System.Decimal? _seUserInsrtId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCourseChng Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseChngKey key, int start, int pageLength)
		{
			return GetByEdStudCourseChngId(transactionManager, key.EdStudCourseChngId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public abstract TList<EdStudCourseChng> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="_edCodeCourseChngId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdCodeCourseChngId(System.Decimal _edCodeCourseChngId)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(null,_edCodeCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdCodeCourseChngId(System.Decimal _edCodeCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(null, _edCodeCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edCodeCourseChngId)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(transactionManager, _edCodeCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edCodeCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(transactionManager, _edCodeCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdCodeCourseChngId(System.Decimal _edCodeCourseChngId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseChngId(null, _edCodeCourseChngId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public abstract TList<EdStudCourseChng> GetByEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edCodeCourseChngId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(null,_edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public abstract TList<EdStudCourseChng> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(null,_edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public abstract TList<EdStudCourseChng> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null,_gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength, out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public abstract TList<EdStudCourseChng> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_CR_SUBJ_EDIT_REQ index.
		/// </summary>
		/// <param name="_edStudCourseChngId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseChng GetByEdStudCourseChngId(System.Decimal _edStudCourseChngId)
		{
			int count = -1;
			return GetByEdStudCourseChngId(null,_edStudCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CR_SUBJ_EDIT_REQ index.
		/// </summary>
		/// <param name="_edStudCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseChng GetByEdStudCourseChngId(System.Decimal _edStudCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseChngId(null, _edStudCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CR_SUBJ_EDIT_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseChngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseChng GetByEdStudCourseChngId(TransactionManager transactionManager, System.Decimal _edStudCourseChngId)
		{
			int count = -1;
			return GetByEdStudCourseChngId(transactionManager, _edStudCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CR_SUBJ_EDIT_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseChng GetByEdStudCourseChngId(TransactionManager transactionManager, System.Decimal _edStudCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseChngId(transactionManager, _edStudCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CR_SUBJ_EDIT_REQ index.
		/// </summary>
		/// <param name="_edStudCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseChng GetByEdStudCourseChngId(System.Decimal _edStudCourseChngId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseChngId(null, _edStudCourseChngId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CR_SUBJ_EDIT_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseChng GetByEdStudCourseChngId(TransactionManager transactionManager, System.Decimal _edStudCourseChngId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_COURSE_CHNG index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal _edCodeCourseChngId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(null,_edStudSemesterId, _edCourseId, _edCodeCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_CHNG index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal _edCodeCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(null, _edStudSemesterId, _edCourseId, _edCodeCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal _edCodeCourseChngId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(transactionManager, _edStudSemesterId, _edCourseId, _edCodeCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal _edCodeCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(transactionManager, _edStudSemesterId, _edCourseId, _edCodeCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_CHNG index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public TList<EdStudCourseChng> GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal _edCodeCourseChngId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(null, _edStudSemesterId, _edCourseId, _edCodeCourseChngId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_CHNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseChng&gt;"/> class.</returns>
		public abstract TList<EdStudCourseChng> GetByEdStudSemesterIdEdCourseIdEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseId, System.Decimal _edCodeCourseChngId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCourseChng&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCourseChng&gt;"/></returns>
		public static TList<EdStudCourseChng> Fill(IDataReader reader, TList<EdStudCourseChng> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCourseChng c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCourseChng")
					.Append("|").Append((System.Decimal)reader["ED_STUD_COURSE_CHNG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCourseChng>(
					key.ToString(), // EntityTrackingKey
					"EdStudCourseChng",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCourseChng();
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
					c.EdStudCourseChngId = (System.Decimal)reader["ED_STUD_COURSE_CHNG_ID"];
					c.OriginalEdStudCourseChngId = c.EdStudCourseChngId;
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.EdCourseSubId = Convert.IsDBNull(reader["ED_COURSE_SUB_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_SUB_ID"];
					c.EdCodeCourseChngId = (System.Decimal)reader["ED_CODE_COURSE_CHNG_ID"];
					c.EdCdeCourseChngRsnId = Convert.IsDBNull(reader["ED_CDE_COURSE_CHNG_RSN_ID"]) ? null : (System.Decimal?)reader["ED_CDE_COURSE_CHNG_RSN_ID"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.ReqStatusDate = Convert.IsDBNull(reader["REQ_STATUS_DATE"]) ? null : (System.DateTime?)reader["REQ_STATUS_DATE"];
					c.GsCodeReqStatusId = Convert.IsDBNull(reader["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)reader["GS_CODE_REQ_STATUS_ID"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Decimal?)reader["APPROVE_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.SeUserInsrtId = Convert.IsDBNull(reader["SE_USER_INSRT_ID"]) ? null : (System.Decimal?)reader["SE_USER_INSRT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCourseChng entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCourseChngId = (System.Decimal)reader[((int)EdStudCourseChngColumn.EdStudCourseChngId - 1)];
			entity.OriginalEdStudCourseChngId = (System.Decimal)reader["ED_STUD_COURSE_CHNG_ID"];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudCourseChngColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseChngColumn.AsFacultyInfoId - 1)];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudCourseChngColumn.EdStudSemesterId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EdStudCourseChngColumn.EdCourseId - 1)];
			entity.EdCourseSubId = (reader.IsDBNull(((int)EdStudCourseChngColumn.EdCourseSubId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseChngColumn.EdCourseSubId - 1)];
			entity.EdCodeCourseChngId = (System.Decimal)reader[((int)EdStudCourseChngColumn.EdCodeCourseChngId - 1)];
			entity.EdCdeCourseChngRsnId = (reader.IsDBNull(((int)EdStudCourseChngColumn.EdCdeCourseChngRsnId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseChngColumn.EdCdeCourseChngRsnId - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)EdStudCourseChngColumn.ReqDate - 1)];
			entity.ReqStatusDate = (reader.IsDBNull(((int)EdStudCourseChngColumn.ReqStatusDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseChngColumn.ReqStatusDate - 1)];
			entity.GsCodeReqStatusId = (reader.IsDBNull(((int)EdStudCourseChngColumn.GsCodeReqStatusId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseChngColumn.GsCodeReqStatusId - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EdStudCourseChngColumn.ApproveFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseChngColumn.ApproveFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudCourseChngColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudCourseChngColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudCourseChngColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseChngColumn.LastDate - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)EdStudCourseChngColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseChngColumn.SeFormId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudCourseChngColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseChngColumn.SeUserId - 1)];
			entity.SeUserInsrtId = (reader.IsDBNull(((int)EdStudCourseChngColumn.SeUserInsrtId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseChngColumn.SeUserInsrtId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCourseChng entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCourseChngId = (System.Decimal)dataRow["ED_STUD_COURSE_CHNG_ID"];
			entity.OriginalEdStudCourseChngId = (System.Decimal)dataRow["ED_STUD_COURSE_CHNG_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EdCourseSubId = Convert.IsDBNull(dataRow["ED_COURSE_SUB_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_SUB_ID"];
			entity.EdCodeCourseChngId = (System.Decimal)dataRow["ED_CODE_COURSE_CHNG_ID"];
			entity.EdCdeCourseChngRsnId = Convert.IsDBNull(dataRow["ED_CDE_COURSE_CHNG_RSN_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_COURSE_CHNG_RSN_ID"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.ReqStatusDate = Convert.IsDBNull(dataRow["REQ_STATUS_DATE"]) ? null : (System.DateTime?)dataRow["REQ_STATUS_DATE"];
			entity.GsCodeReqStatusId = Convert.IsDBNull(dataRow["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Decimal?)dataRow["APPROVE_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.SeUserInsrtId = Convert.IsDBNull(dataRow["SE_USER_INSRT_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_INSRT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseChng"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseChng Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseChng entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region EdCdeCourseChngRsnIdSource	
			if (CanDeepLoad(entity, "EdCdeCourseChngRsn|EdCdeCourseChngRsnIdSource", deepLoadType, innerList) 
				&& entity.EdCdeCourseChngRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeCourseChngRsnId ?? 0.0m);
				EdCdeCourseChngRsn tmpEntity = EntityManager.LocateEntity<EdCdeCourseChngRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeCourseChngRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeCourseChngRsnIdSource = tmpEntity;
				else
					entity.EdCdeCourseChngRsnIdSource = DataRepository.EdCdeCourseChngRsnProvider.GetByEdCdeCourseChngRsnId(transactionManager, (entity.EdCdeCourseChngRsnId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeCourseChngRsnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeCourseChngRsnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeCourseChngRsnProvider.DeepLoad(transactionManager, entity.EdCdeCourseChngRsnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeCourseChngRsnIdSource

			#region EdCodeCourseChngIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseChng|EdCodeCourseChngIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseChngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeCourseChngId;
				EdCodeCourseChng tmpEntity = EntityManager.LocateEntity<EdCodeCourseChng>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseChng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseChngIdSource = tmpEntity;
				else
					entity.EdCodeCourseChngIdSource = DataRepository.EdCodeCourseChngProvider.GetByEdCodeCourseChngId(transactionManager, entity.EdCodeCourseChngId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseChngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseChngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseChngProvider.DeepLoad(transactionManager, entity.EdCodeCourseChngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseChngIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
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

			#region EdCourseSubIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseSubIdSource", deepLoadType, innerList) 
				&& entity.EdCourseSubIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseSubId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseSubIdSource = tmpEntity;
				else
					entity.EdCourseSubIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseSubId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseSubIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseSubIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseSubIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseSubIdSource

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudSemesterId;
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource

			#region GsCodeReqStatusIdSource	
			if (CanDeepLoad(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReqStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeReqStatusId ?? 0.0m);
				GsCodeReqStatus tmpEntity = EntityManager.LocateEntity<GsCodeReqStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReqStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReqStatusIdSource = tmpEntity;
				else
					entity.GsCodeReqStatusIdSource = DataRepository.GsCodeReqStatusProvider.GetByGsCodeReqStatusId(transactionManager, (entity.GsCodeReqStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeReqStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeReqStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeReqStatusProvider.DeepLoad(transactionManager, entity.GsCodeReqStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeReqStatusIdSource

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

			#region SeUserInsrtIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserInsrtIdSource", deepLoadType, innerList) 
				&& entity.SeUserInsrtIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserInsrtId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserInsrtIdSource = tmpEntity;
				else
					entity.SeUserInsrtIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserInsrtId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserInsrtIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserInsrtIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserInsrtIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserInsrtIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudCourseChngId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByEdStudCourseChngId(transactionManager, entity.EdStudCourseChngId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCourseChng object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCourseChng instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseChng Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseChng entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region EdCdeCourseChngRsnIdSource
			if (CanDeepSave(entity, "EdCdeCourseChngRsn|EdCdeCourseChngRsnIdSource", deepSaveType, innerList) 
				&& entity.EdCdeCourseChngRsnIdSource != null)
			{
				DataRepository.EdCdeCourseChngRsnProvider.Save(transactionManager, entity.EdCdeCourseChngRsnIdSource);
				entity.EdCdeCourseChngRsnId = entity.EdCdeCourseChngRsnIdSource.EdCdeCourseChngRsnId;
			}
			#endregion 
			
			#region EdCodeCourseChngIdSource
			if (CanDeepSave(entity, "EdCodeCourseChng|EdCodeCourseChngIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseChngIdSource != null)
			{
				DataRepository.EdCodeCourseChngProvider.Save(transactionManager, entity.EdCodeCourseChngIdSource);
				entity.EdCodeCourseChngId = entity.EdCodeCourseChngIdSource.EdCodeCourseChngId;
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
			
			#region EdCourseSubIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseSubIdSource", deepSaveType, innerList) 
				&& entity.EdCourseSubIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseSubIdSource);
				entity.EdCourseSubId = entity.EdCourseSubIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region GsCodeReqStatusIdSource
			if (CanDeepSave(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReqStatusIdSource != null)
			{
				DataRepository.GsCodeReqStatusProvider.Save(transactionManager, entity.GsCodeReqStatusIdSource);
				entity.GsCodeReqStatusId = entity.GsCodeReqStatusIdSource.GsCodeReqStatusId;
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
			
			#region SeUserInsrtIdSource
			if (CanDeepSave(entity, "SeUser|SeUserInsrtIdSource", deepSaveType, innerList) 
				&& entity.SeUserInsrtIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserInsrtIdSource);
				entity.SeUserInsrtId = entity.SeUserInsrtIdSource.SeUserId;
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
						if(child.EdStudCourseChngIdSource != null)
						{
							child.EdStudCourseChngId = child.EdStudCourseChngIdSource.EdStudCourseChngId;
						}
						else
						{
							child.EdStudCourseChngId = entity.EdStudCourseChngId;
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
	
	#region EdStudCourseChngChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCourseChng</c>
	///</summary>
	public enum EdStudCourseChngChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdCdeCourseChngRsn</c> at EdCdeCourseChngRsnIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeCourseChngRsn))]
		EdCdeCourseChngRsn,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseChng</c> at EdCodeCourseChngIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseChng))]
		EdCodeCourseChng,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
		
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
		/// Collection of <c>EdStudCourseChng</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
	}
	
	#endregion EdStudCourseChngChildEntityTypes
	
	#region EdStudCourseChngFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCourseChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseChng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseChngFilterBuilder : SqlFilterBuilder<EdStudCourseChngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseChngFilterBuilder class.
		/// </summary>
		public EdStudCourseChngFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseChngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseChngFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseChngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseChngFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseChngFilterBuilder
	
	#region EdStudCourseChngParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCourseChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseChng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseChngParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCourseChngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseChngParameterBuilder class.
		/// </summary>
		public EdStudCourseChngParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseChngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseChngParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseChngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseChngParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseChngParameterBuilder
	
	#region EdStudCourseChngSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCourseChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseChng"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCourseChngSortBuilder : SqlSortBuilder<EdStudCourseChngColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseChngSqlSortBuilder class.
		/// </summary>
		public EdStudCourseChngSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCourseChngSortBuilder
	
} // end namespace
