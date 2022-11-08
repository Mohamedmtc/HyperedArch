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
	/// This class is the base class for any <see cref="EdStudCourseRplcProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseRplcProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCourseRplc, UMIS_VER2.BusinessLyer.EdStudCourseRplcKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRplcKey key)
		{
			return Delete(transactionManager, key.EdStudCourseRplcId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCourseRplcId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCourseRplcId)
		{
			return Delete(null, _edStudCourseRplcId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRplcId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCourseRplcId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE key.
		///		FK_ED_STUD_COURSE_RPLC_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdCourseOldId(System.Decimal _edCourseOldId)
		{
			int count = -1;
			return GetByEdCourseOldId(_edCourseOldId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE key.
		///		FK_ED_STUD_COURSE_RPLC_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRplc> GetByEdCourseOldId(TransactionManager transactionManager, System.Decimal _edCourseOldId)
		{
			int count = -1;
			return GetByEdCourseOldId(transactionManager, _edCourseOldId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE key.
		///		FK_ED_STUD_COURSE_RPLC_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdCourseOldId(TransactionManager transactionManager, System.Decimal _edCourseOldId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseOldId(transactionManager, _edCourseOldId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE key.
		///		fkEdStudCourseRplcEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseOldId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdCourseOldId(System.Decimal _edCourseOldId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseOldId(null, _edCourseOldId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE key.
		///		fkEdStudCourseRplcEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseOldId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdCourseOldId(System.Decimal _edCourseOldId, int start, int pageLength,out int count)
		{
			return GetByEdCourseOldId(null, _edCourseOldId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE key.
		///		FK_ED_STUD_COURSE_RPLC_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public abstract TList<EdStudCourseRplc> GetByEdCourseOldId(TransactionManager transactionManager, System.Decimal _edCourseOldId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_RPLC_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="_edCourseNewId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdCourseNewId(System.Decimal _edCourseNewId)
		{
			int count = -1;
			return GetByEdCourseNewId(_edCourseNewId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_RPLC_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseNewId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRplc> GetByEdCourseNewId(TransactionManager transactionManager, System.Decimal _edCourseNewId)
		{
			int count = -1;
			return GetByEdCourseNewId(transactionManager, _edCourseNewId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_RPLC_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdCourseNewId(TransactionManager transactionManager, System.Decimal _edCourseNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseNewId(transactionManager, _edCourseNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE1 key.
		///		fkEdStudCourseRplcEdCourse1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseNewId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdCourseNewId(System.Decimal _edCourseNewId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseNewId(null, _edCourseNewId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE1 key.
		///		fkEdStudCourseRplcEdCourse1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseNewId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdCourseNewId(System.Decimal _edCourseNewId, int start, int pageLength,out int count)
		{
			return GetByEdCourseNewId(null, _edCourseNewId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_COURSE1 key.
		///		FK_ED_STUD_COURSE_RPLC_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public abstract TList<EdStudCourseRplc> GetByEdCourseNewId(TransactionManager transactionManager, System.Decimal _edCourseNewId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_COURSE_RPLC_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_COURSE_RPLC_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRplc> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_COURSE_RPLC_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_STUD_SEMESTER key.
		///		fkEdStudCourseRplcEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_STUD_SEMESTER key.
		///		fkEdStudCourseRplcEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_COURSE_RPLC_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public abstract TList<EdStudCourseRplc> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_COURSE_RPLC_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_COURSE_RPLC_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRplc> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_COURSE_RPLC_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_GS_CODE_REQ_STATUS key.
		///		fkEdStudCourseRplcGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_GS_CODE_REQ_STATUS key.
		///		fkEdStudCourseRplcGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_GS_CODE_REQ_STATUS key.
		///		FK_ED_STUD_COURSE_RPLC_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public abstract TList<EdStudCourseRplc> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_SE_USER key.
		///		FK_ED_STUD_COURSE_RPLC_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_SE_USER key.
		///		FK_ED_STUD_COURSE_RPLC_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRplc> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_SE_USER key.
		///		FK_ED_STUD_COURSE_RPLC_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_SE_USER key.
		///		fkEdStudCourseRplcSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_SE_USER key.
		///		fkEdStudCourseRplcSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public TList<EdStudCourseRplc> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_RPLC_SE_USER key.
		///		FK_ED_STUD_COURSE_RPLC_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRplc objects.</returns>
		public abstract TList<EdStudCourseRplc> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCourseRplc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRplcKey key, int start, int pageLength)
		{
			return GetByEdStudCourseRplcId(transactionManager, key.EdStudCourseRplcId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="_edStudCourseRplcId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudCourseRplcId(System.Decimal _edStudCourseRplcId)
		{
			int count = -1;
			return GetByEdStudCourseRplcId(null,_edStudCourseRplcId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="_edStudCourseRplcId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudCourseRplcId(System.Decimal _edStudCourseRplcId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRplcId(null, _edStudCourseRplcId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRplcId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudCourseRplcId(TransactionManager transactionManager, System.Decimal _edStudCourseRplcId)
		{
			int count = -1;
			return GetByEdStudCourseRplcId(transactionManager, _edStudCourseRplcId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRplcId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudCourseRplcId(TransactionManager transactionManager, System.Decimal _edStudCourseRplcId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRplcId(transactionManager, _edStudCourseRplcId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="_edStudCourseRplcId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudCourseRplcId(System.Decimal _edStudCourseRplcId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRplcId(null, _edStudCourseRplcId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRplcId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudCourseRplcId(TransactionManager transactionManager, System.Decimal _edStudCourseRplcId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseNewId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudSemesterIdEdCourseNewId(System.Decimal _edStudSemesterId, System.Decimal _edCourseNewId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseNewId(null,_edStudSemesterId, _edCourseNewId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudSemesterIdEdCourseNewId(System.Decimal _edStudSemesterId, System.Decimal _edCourseNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseNewId(null, _edStudSemesterId, _edCourseNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseNewId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudSemesterIdEdCourseNewId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseNewId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseNewId(transactionManager, _edStudSemesterId, _edCourseNewId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudSemesterIdEdCourseNewId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseNewId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdCourseNewId(transactionManager, _edStudSemesterId, _edCourseNewId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudSemesterIdEdCourseNewId(System.Decimal _edStudSemesterId, System.Decimal _edCourseNewId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterIdEdCourseNewId(null, _edStudSemesterId, _edCourseNewId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_COURSE_RPLC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edCourseNewId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseRplc GetByEdStudSemesterIdEdCourseNewId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edCourseNewId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCourseRplc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCourseRplc&gt;"/></returns>
		public static TList<EdStudCourseRplc> Fill(IDataReader reader, TList<EdStudCourseRplc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCourseRplc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCourseRplc")
					.Append("|").Append((System.Decimal)reader["ED_STUD_COURSE_RPLC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCourseRplc>(
					key.ToString(), // EntityTrackingKey
					"EdStudCourseRplc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCourseRplc();
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
					c.EdStudCourseRplcId = (System.Decimal)reader["ED_STUD_COURSE_RPLC_ID"];
					c.OriginalEdStudCourseRplcId = c.EdStudCourseRplcId;
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.EdCourseOldId = (System.Decimal)reader["ED_COURSE_OLD_ID"];
					c.EdCourseNewId = (System.Decimal)reader["ED_COURSE_NEW_ID"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.ReqStatusDate = Convert.IsDBNull(reader["REQ_STATUS_DATE"]) ? null : (System.DateTime?)reader["REQ_STATUS_DATE"];
					c.GsCodeReqStatusId = Convert.IsDBNull(reader["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)reader["GS_CODE_REQ_STATUS_ID"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Decimal?)reader["APPROVE_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCourseRplc entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCourseRplcId = (System.Decimal)reader[((int)EdStudCourseRplcColumn.EdStudCourseRplcId - 1)];
			entity.OriginalEdStudCourseRplcId = (System.Decimal)reader["ED_STUD_COURSE_RPLC_ID"];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudCourseRplcColumn.EdStudSemesterId - 1)];
			entity.EdCourseOldId = (System.Decimal)reader[((int)EdStudCourseRplcColumn.EdCourseOldId - 1)];
			entity.EdCourseNewId = (System.Decimal)reader[((int)EdStudCourseRplcColumn.EdCourseNewId - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)EdStudCourseRplcColumn.ReqDate - 1)];
			entity.ReqStatusDate = (reader.IsDBNull(((int)EdStudCourseRplcColumn.ReqStatusDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseRplcColumn.ReqStatusDate - 1)];
			entity.GsCodeReqStatusId = (reader.IsDBNull(((int)EdStudCourseRplcColumn.GsCodeReqStatusId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRplcColumn.GsCodeReqStatusId - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)EdStudCourseRplcColumn.ApproveFlg - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRplcColumn.ApproveFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudCourseRplcColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudCourseRplcColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudCourseRplcColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRplcColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCourseRplc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCourseRplcId = (System.Decimal)dataRow["ED_STUD_COURSE_RPLC_ID"];
			entity.OriginalEdStudCourseRplcId = (System.Decimal)dataRow["ED_STUD_COURSE_RPLC_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.EdCourseOldId = (System.Decimal)dataRow["ED_COURSE_OLD_ID"];
			entity.EdCourseNewId = (System.Decimal)dataRow["ED_COURSE_NEW_ID"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.ReqStatusDate = Convert.IsDBNull(dataRow["REQ_STATUS_DATE"]) ? null : (System.DateTime?)dataRow["REQ_STATUS_DATE"];
			entity.GsCodeReqStatusId = Convert.IsDBNull(dataRow["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Decimal?)dataRow["APPROVE_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRplc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRplc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRplc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseOldIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseOldIdSource", deepLoadType, innerList) 
				&& entity.EdCourseOldIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseOldId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseOldIdSource = tmpEntity;
				else
					entity.EdCourseOldIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseOldId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOldIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseOldIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseOldIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseOldIdSource

			#region EdCourseNewIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseNewIdSource", deepLoadType, innerList) 
				&& entity.EdCourseNewIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseNewId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseNewIdSource = tmpEntity;
				else
					entity.EdCourseNewIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseNewId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseNewIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseNewIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseNewIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseNewIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCourseRplc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCourseRplc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRplc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRplc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseOldIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseOldIdSource", deepSaveType, innerList) 
				&& entity.EdCourseOldIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseOldIdSource);
				entity.EdCourseOldId = entity.EdCourseOldIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdCourseNewIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseNewIdSource", deepSaveType, innerList) 
				&& entity.EdCourseNewIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseNewIdSource);
				entity.EdCourseNewId = entity.EdCourseNewIdSource.EdCourseId;
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
	
	#region EdStudCourseRplcChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCourseRplc</c>
	///</summary>
	public enum EdStudCourseRplcChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseOldIdSource
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
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
	}
	
	#endregion EdStudCourseRplcChildEntityTypes
	
	#region EdStudCourseRplcFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCourseRplcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRplc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRplcFilterBuilder : SqlFilterBuilder<EdStudCourseRplcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRplcFilterBuilder class.
		/// </summary>
		public EdStudCourseRplcFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRplcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRplcFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRplcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRplcFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRplcFilterBuilder
	
	#region EdStudCourseRplcParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCourseRplcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRplc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRplcParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCourseRplcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRplcParameterBuilder class.
		/// </summary>
		public EdStudCourseRplcParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRplcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRplcParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRplcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRplcParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRplcParameterBuilder
	
	#region EdStudCourseRplcSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCourseRplcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRplc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCourseRplcSortBuilder : SqlSortBuilder<EdStudCourseRplcColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRplcSqlSortBuilder class.
		/// </summary>
		public EdStudCourseRplcSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCourseRplcSortBuilder
	
} // end namespace
