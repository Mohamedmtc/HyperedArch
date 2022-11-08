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
	/// This class is the base class for any <see cref="EdCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourse, UMIS_VER2.BusinessLyer.EdCourseKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseKey key)
		{
			return Delete(transactionManager, key.EdCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseId)
		{
			return Delete(null, _edCourseId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0006 key.
		///		FK_AUTO_0006 Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByGsCodeLanguageId(System.Decimal _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0006 key.
		///		FK_AUTO_0006 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourse> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0006 key.
		///		FK_AUTO_0006 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0006 key.
		///		fkAuto0006 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByGsCodeLanguageId(System.Decimal _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0006 key.
		///		fkAuto0006 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByGsCodeLanguageId(System.Decimal _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0006 key.
		///		FK_AUTO_0006 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public abstract TList<EdCourse> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal _gsCodeLanguageId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_COURSE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_COURSE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourse> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_COURSE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_CODE_DEGREE_CLASS key.
		///		fkEdCourseAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_CODE_DEGREE_CLASS key.
		///		fkEdCourseAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_CODE_DEGREE_CLASS key.
		///		FK_ED_COURSE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public abstract TList<EdCourse> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_FACULTY_INFO key.
		///		FK_ED_COURSE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_FACULTY_INFO key.
		///		FK_ED_COURSE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_FACULTY_INFO key.
		///		FK_ED_COURSE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_FACULTY_INFO key.
		///		fkEdCourseAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_FACULTY_INFO key.
		///		fkEdCourseAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_AS_FACULTY_INFO key.
		///		FK_ED_COURSE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public abstract TList<EdCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE key.
		///		FK_ED_COURSE_ED_CODE_COURSE Description: 
		/// </summary>
		/// <param name="_edCodeCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCodeCourseId(System.Decimal? _edCodeCourseId)
		{
			int count = -1;
			return GetByEdCodeCourseId(_edCodeCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE key.
		///		FK_ED_COURSE_ED_CODE_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourse> GetByEdCodeCourseId(TransactionManager transactionManager, System.Decimal? _edCodeCourseId)
		{
			int count = -1;
			return GetByEdCodeCourseId(transactionManager, _edCodeCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE key.
		///		FK_ED_COURSE_ED_CODE_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCodeCourseId(TransactionManager transactionManager, System.Decimal? _edCodeCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseId(transactionManager, _edCodeCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE key.
		///		fkEdCourseEdCodeCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCodeCourseId(System.Decimal? _edCodeCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseId(null, _edCodeCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE key.
		///		fkEdCourseEdCodeCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCodeCourseId(System.Decimal? _edCodeCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseId(null, _edCodeCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE key.
		///		FK_ED_COURSE_ED_CODE_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public abstract TList<EdCourse> GetByEdCodeCourseId(TransactionManager transactionManager, System.Decimal? _edCodeCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE_TYPE key.
		///		FK_ED_COURSE_ED_CODE_COURSE_TYPE Description: 
		/// </summary>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCodeCourseTypeId(System.Int32? _edCodeCourseTypeId)
		{
			int count = -1;
			return GetByEdCodeCourseTypeId(_edCodeCourseTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE_TYPE key.
		///		FK_ED_COURSE_ED_CODE_COURSE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourse> GetByEdCodeCourseTypeId(TransactionManager transactionManager, System.Int32? _edCodeCourseTypeId)
		{
			int count = -1;
			return GetByEdCodeCourseTypeId(transactionManager, _edCodeCourseTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE_TYPE key.
		///		FK_ED_COURSE_ED_CODE_COURSE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCodeCourseTypeId(TransactionManager transactionManager, System.Int32? _edCodeCourseTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTypeId(transactionManager, _edCodeCourseTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE_TYPE key.
		///		fkEdCourseEdCodeCourseType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCodeCourseTypeId(System.Int32? _edCodeCourseTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseTypeId(null, _edCodeCourseTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE_TYPE key.
		///		fkEdCourseEdCodeCourseType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCodeCourseTypeId(System.Int32? _edCodeCourseTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseTypeId(null, _edCodeCourseTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_CODE_COURSE_TYPE key.
		///		FK_ED_COURSE_ED_CODE_COURSE_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public abstract TList<EdCourse> GetByEdCodeCourseTypeId(TransactionManager transactionManager, System.Int32? _edCodeCourseTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_EXP_HDR key.
		///		FK_ED_COURSE_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="_edCourseExpHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCourseExpHdrId(System.Decimal? _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(_edCourseExpHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_EXP_HDR key.
		///		FK_ED_COURSE_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourse> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(transactionManager, _edCourseExpHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_EXP_HDR key.
		///		FK_ED_COURSE_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(transactionManager, _edCourseExpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_EXP_HDR key.
		///		fkEdCourseEdCourseExpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCourseExpHdrId(System.Decimal? _edCourseExpHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseExpHdrId(null, _edCourseExpHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_EXP_HDR key.
		///		fkEdCourseEdCourseExpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCourseExpHdrId(System.Decimal? _edCourseExpHdrId, int start, int pageLength,out int count)
		{
			return GetByEdCourseExpHdrId(null, _edCourseExpHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_EXP_HDR key.
		///		FK_ED_COURSE_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public abstract TList<EdCourse> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_PRFX1 key.
		///		FK_ED_COURSE_ED_COURSE_PRFX1 Description: 
		/// </summary>
		/// <param name="_edCoursePrfxId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCoursePrfxId(System.Decimal? _edCoursePrfxId)
		{
			int count = -1;
			return GetByEdCoursePrfxId(_edCoursePrfxId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_PRFX1 key.
		///		FK_ED_COURSE_ED_COURSE_PRFX1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourse> GetByEdCoursePrfxId(TransactionManager transactionManager, System.Decimal? _edCoursePrfxId)
		{
			int count = -1;
			return GetByEdCoursePrfxId(transactionManager, _edCoursePrfxId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_PRFX1 key.
		///		FK_ED_COURSE_ED_COURSE_PRFX1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCoursePrfxId(TransactionManager transactionManager, System.Decimal? _edCoursePrfxId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCoursePrfxId(transactionManager, _edCoursePrfxId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_PRFX1 key.
		///		fkEdCourseEdCoursePrfx1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCoursePrfxId(System.Decimal? _edCoursePrfxId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCoursePrfxId(null, _edCoursePrfxId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_PRFX1 key.
		///		fkEdCourseEdCoursePrfx1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEdCoursePrfxId(System.Decimal? _edCoursePrfxId, int start, int pageLength,out int count)
		{
			return GetByEdCoursePrfxId(null, _edCoursePrfxId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_COURSE_PRFX1 key.
		///		FK_ED_COURSE_ED_COURSE_PRFX1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCoursePrfxId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public abstract TList<EdCourse> GetByEdCoursePrfxId(TransactionManager transactionManager, System.Decimal? _edCoursePrfxId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ENTITY_MAIN key.
		///		FK_ED_COURSE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ENTITY_MAIN key.
		///		FK_ED_COURSE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourse> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ENTITY_MAIN key.
		///		FK_ED_COURSE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ENTITY_MAIN key.
		///		fkEdCourseEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ENTITY_MAIN key.
		///		fkEdCourseEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public TList<EdCourse> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_ENTITY_MAIN key.
		///		FK_ED_COURSE_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
		public abstract TList<EdCourse> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCourse Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseKey key, int start, int pageLength)
		{
			return GetByEdCourseId(transactionManager, key.EdCourseId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(null,_edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_COURSE index.
		/// </summary>
		/// <param name="_courseCode"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourse GetByCourseCode(System.String _courseCode)
		{
			int count = -1;
			return GetByCourseCode(null,_courseCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_COURSE index.
		/// </summary>
		/// <param name="_courseCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourse GetByCourseCode(System.String _courseCode, int start, int pageLength)
		{
			int count = -1;
			return GetByCourseCode(null, _courseCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_courseCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourse GetByCourseCode(TransactionManager transactionManager, System.String _courseCode)
		{
			int count = -1;
			return GetByCourseCode(transactionManager, _courseCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_courseCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourse GetByCourseCode(TransactionManager transactionManager, System.String _courseCode, int start, int pageLength)
		{
			int count = -1;
			return GetByCourseCode(transactionManager, _courseCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_COURSE index.
		/// </summary>
		/// <param name="_courseCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourse GetByCourseCode(System.String _courseCode, int start, int pageLength, out int count)
		{
			return GetByCourseCode(null, _courseCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_COURSE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_courseCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourse GetByCourseCode(TransactionManager transactionManager, System.String _courseCode, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourse&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourse&gt;"/></returns>
		public static TList<EdCourse> Fill(IDataReader reader, TList<EdCourse> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourse c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourse")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourse>(
					key.ToString(), // EntityTrackingKey
					"EdCourse",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourse();
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
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.OriginalEdCourseId = c.EdCourseId;
					c.EdCodeCourseId = Convert.IsDBNull(reader["ED_CODE_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_ID"];
					c.CourseCode = (System.String)reader["COURSE_CODE"];
					c.CourseDescrAr = (System.String)reader["COURSE_DESCR_AR"];
					c.CourseDescrEn = (System.String)reader["COURSE_DESCR_EN"];
					c.CreditHours = (System.Decimal)reader["CREDIT_HOURS"];
					c.CourseContentsAr = Convert.IsDBNull(reader["COURSE_CONTENTS_AR"]) ? null : (System.String)reader["COURSE_CONTENTS_AR"];
					c.CourseContentsEn = Convert.IsDBNull(reader["COURSE_CONTENTS_EN"]) ? null : (System.String)reader["COURSE_CONTENTS_EN"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.GsCodeLanguageId = (System.Decimal)reader["GS_CODE_LANGUAGE_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.PrereqCodeExp = Convert.IsDBNull(reader["PREREQ_CODE_EXP"]) ? null : (System.String)reader["PREREQ_CODE_EXP"];
					c.PrereqIdExp = Convert.IsDBNull(reader["PREREQ_ID_EXP"]) ? null : (System.String)reader["PREREQ_ID_EXP"];
					c.ElectFlg = Convert.IsDBNull(reader["ELECT_FLG"]) ? null : (System.Decimal?)reader["ELECT_FLG"];
					c.GsCourseElectTypeId = Convert.IsDBNull(reader["GS_COURSE_ELECT_TYPE_ID"]) ? null : (System.Decimal?)reader["GS_COURSE_ELECT_TYPE_ID"];
					c.EdCoursePrfxId = Convert.IsDBNull(reader["ED_COURSE_PRFX_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_PRFX_ID"];
					c.CrsNo = Convert.IsDBNull(reader["CRS_NO"]) ? null : (System.String)reader["CRS_NO"];
					c.PfFlg = Convert.IsDBNull(reader["PF_FLG"]) ? null : (System.Decimal?)reader["PF_FLG"];
					c.CrsLvl = Convert.IsDBNull(reader["CRS_LVL"]) ? null : (System.Decimal?)reader["CRS_LVL"];
					c.OnlineFlg = Convert.IsDBNull(reader["ONLINE_FLG"]) ? null : (System.Decimal?)reader["ONLINE_FLG"];
					c.StopMessage = Convert.IsDBNull(reader["STOP_MESSAGE"]) ? null : (System.String)reader["STOP_MESSAGE"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.EdCourseExpHdrId = Convert.IsDBNull(reader["ED_COURSE_EXP_HDR_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_EXP_HDR_ID"];
					c.LoadWithTrain = Convert.IsDBNull(reader["LOAD_WITH_TRAIN"]) ? null : (System.Decimal?)reader["LOAD_WITH_TRAIN"];
					c.ExamFlg = Convert.IsDBNull(reader["EXAM_FLG"]) ? null : (System.Decimal?)reader["EXAM_FLG"];
					c.FreeFlg = Convert.IsDBNull(reader["FREE_FLG"]) ? null : (System.Decimal?)reader["FREE_FLG"];
					c.IncmpltFlg = Convert.IsDBNull(reader["INCMPLT_FLG"]) ? null : (System.Decimal?)reader["INCMPLT_FLG"];
					c.DropFlg = Convert.IsDBNull(reader["DROP_FLG"]) ? null : (System.Decimal?)reader["DROP_FLG"];
					c.ExamHrs = Convert.IsDBNull(reader["EXAM_HRS"]) ? null : (System.Decimal?)reader["EXAM_HRS"];
					c.CrsWgt = Convert.IsDBNull(reader["CRS_WGT"]) ? null : (System.Decimal?)reader["CRS_WGT"];
					c.CourseDescrFr = Convert.IsDBNull(reader["COURSE_DESCR_FR"]) ? null : (System.String)reader["COURSE_DESCR_FR"];
					c.Ects = Convert.IsDBNull(reader["ECTS"]) ? null : (System.Decimal?)reader["ECTS"];
					c.LoadCrsCount = Convert.IsDBNull(reader["LOAD_CRS_COUNT"]) ? null : (System.Int32?)reader["LOAD_CRS_COUNT"];
					c.ExtndFlg = Convert.IsDBNull(reader["EXTND_FLG"]) ? null : (System.Boolean?)reader["EXTND_FLG"];
					c.CourseMod = Convert.IsDBNull(reader["Course_Mod"]) ? null : (System.String)reader["Course_Mod"];
					c.EdCodeCourseTypeId = Convert.IsDBNull(reader["ED_CODE_COURSE_TYPE_ID"]) ? null : (System.Int32?)reader["ED_CODE_COURSE_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourse entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseId = (System.Decimal)reader[((int)EdCourseColumn.EdCourseId - 1)];
			entity.OriginalEdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
			entity.EdCodeCourseId = (reader.IsDBNull(((int)EdCourseColumn.EdCodeCourseId - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.EdCodeCourseId - 1)];
			entity.CourseCode = (System.String)reader[((int)EdCourseColumn.CourseCode - 1)];
			entity.CourseDescrAr = (System.String)reader[((int)EdCourseColumn.CourseDescrAr - 1)];
			entity.CourseDescrEn = (System.String)reader[((int)EdCourseColumn.CourseDescrEn - 1)];
			entity.CreditHours = (System.Decimal)reader[((int)EdCourseColumn.CreditHours - 1)];
			entity.CourseContentsAr = (reader.IsDBNull(((int)EdCourseColumn.CourseContentsAr - 1)))?null:(System.String)reader[((int)EdCourseColumn.CourseContentsAr - 1)];
			entity.CourseContentsEn = (reader.IsDBNull(((int)EdCourseColumn.CourseContentsEn - 1)))?null:(System.String)reader[((int)EdCourseColumn.CourseContentsEn - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)EdCourseColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.EntMainId - 1)];
			entity.GsCodeLanguageId = (System.Decimal)reader[((int)EdCourseColumn.GsCodeLanguageId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdCourseColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.AsFacultyInfoId - 1)];
			entity.IsActive = (System.Decimal)reader[((int)EdCourseColumn.IsActive - 1)];
			entity.PrereqCodeExp = (reader.IsDBNull(((int)EdCourseColumn.PrereqCodeExp - 1)))?null:(System.String)reader[((int)EdCourseColumn.PrereqCodeExp - 1)];
			entity.PrereqIdExp = (reader.IsDBNull(((int)EdCourseColumn.PrereqIdExp - 1)))?null:(System.String)reader[((int)EdCourseColumn.PrereqIdExp - 1)];
			entity.ElectFlg = (reader.IsDBNull(((int)EdCourseColumn.ElectFlg - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.ElectFlg - 1)];
			entity.GsCourseElectTypeId = (reader.IsDBNull(((int)EdCourseColumn.GsCourseElectTypeId - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.GsCourseElectTypeId - 1)];
			entity.EdCoursePrfxId = (reader.IsDBNull(((int)EdCourseColumn.EdCoursePrfxId - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.EdCoursePrfxId - 1)];
			entity.CrsNo = (reader.IsDBNull(((int)EdCourseColumn.CrsNo - 1)))?null:(System.String)reader[((int)EdCourseColumn.CrsNo - 1)];
			entity.PfFlg = (reader.IsDBNull(((int)EdCourseColumn.PfFlg - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.PfFlg - 1)];
			entity.CrsLvl = (reader.IsDBNull(((int)EdCourseColumn.CrsLvl - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.CrsLvl - 1)];
			entity.OnlineFlg = (reader.IsDBNull(((int)EdCourseColumn.OnlineFlg - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.OnlineFlg - 1)];
			entity.StopMessage = (reader.IsDBNull(((int)EdCourseColumn.StopMessage - 1)))?null:(System.String)reader[((int)EdCourseColumn.StopMessage - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)EdCourseColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.AsCodeDegreeClassId - 1)];
			entity.EdCourseExpHdrId = (reader.IsDBNull(((int)EdCourseColumn.EdCourseExpHdrId - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.EdCourseExpHdrId - 1)];
			entity.LoadWithTrain = (reader.IsDBNull(((int)EdCourseColumn.LoadWithTrain - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.LoadWithTrain - 1)];
			entity.ExamFlg = (reader.IsDBNull(((int)EdCourseColumn.ExamFlg - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.ExamFlg - 1)];
			entity.FreeFlg = (reader.IsDBNull(((int)EdCourseColumn.FreeFlg - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.FreeFlg - 1)];
			entity.IncmpltFlg = (reader.IsDBNull(((int)EdCourseColumn.IncmpltFlg - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.IncmpltFlg - 1)];
			entity.DropFlg = (reader.IsDBNull(((int)EdCourseColumn.DropFlg - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.DropFlg - 1)];
			entity.ExamHrs = (reader.IsDBNull(((int)EdCourseColumn.ExamHrs - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.ExamHrs - 1)];
			entity.CrsWgt = (reader.IsDBNull(((int)EdCourseColumn.CrsWgt - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.CrsWgt - 1)];
			entity.CourseDescrFr = (reader.IsDBNull(((int)EdCourseColumn.CourseDescrFr - 1)))?null:(System.String)reader[((int)EdCourseColumn.CourseDescrFr - 1)];
			entity.Ects = (reader.IsDBNull(((int)EdCourseColumn.Ects - 1)))?null:(System.Decimal?)reader[((int)EdCourseColumn.Ects - 1)];
			entity.LoadCrsCount = (reader.IsDBNull(((int)EdCourseColumn.LoadCrsCount - 1)))?null:(System.Int32?)reader[((int)EdCourseColumn.LoadCrsCount - 1)];
			entity.ExtndFlg = (reader.IsDBNull(((int)EdCourseColumn.ExtndFlg - 1)))?null:(System.Boolean?)reader[((int)EdCourseColumn.ExtndFlg - 1)];
			entity.CourseMod = (reader.IsDBNull(((int)EdCourseColumn.CourseMod - 1)))?null:(System.String)reader[((int)EdCourseColumn.CourseMod - 1)];
			entity.EdCodeCourseTypeId = (reader.IsDBNull(((int)EdCourseColumn.EdCodeCourseTypeId - 1)))?null:(System.Int32?)reader[((int)EdCourseColumn.EdCodeCourseTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.OriginalEdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EdCodeCourseId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_ID"];
			entity.CourseCode = (System.String)dataRow["COURSE_CODE"];
			entity.CourseDescrAr = (System.String)dataRow["COURSE_DESCR_AR"];
			entity.CourseDescrEn = (System.String)dataRow["COURSE_DESCR_EN"];
			entity.CreditHours = (System.Decimal)dataRow["CREDIT_HOURS"];
			entity.CourseContentsAr = Convert.IsDBNull(dataRow["COURSE_CONTENTS_AR"]) ? null : (System.String)dataRow["COURSE_CONTENTS_AR"];
			entity.CourseContentsEn = Convert.IsDBNull(dataRow["COURSE_CONTENTS_EN"]) ? null : (System.String)dataRow["COURSE_CONTENTS_EN"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.GsCodeLanguageId = (System.Decimal)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
			entity.PrereqCodeExp = Convert.IsDBNull(dataRow["PREREQ_CODE_EXP"]) ? null : (System.String)dataRow["PREREQ_CODE_EXP"];
			entity.PrereqIdExp = Convert.IsDBNull(dataRow["PREREQ_ID_EXP"]) ? null : (System.String)dataRow["PREREQ_ID_EXP"];
			entity.ElectFlg = Convert.IsDBNull(dataRow["ELECT_FLG"]) ? null : (System.Decimal?)dataRow["ELECT_FLG"];
			entity.GsCourseElectTypeId = Convert.IsDBNull(dataRow["GS_COURSE_ELECT_TYPE_ID"]) ? null : (System.Decimal?)dataRow["GS_COURSE_ELECT_TYPE_ID"];
			entity.EdCoursePrfxId = Convert.IsDBNull(dataRow["ED_COURSE_PRFX_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_PRFX_ID"];
			entity.CrsNo = Convert.IsDBNull(dataRow["CRS_NO"]) ? null : (System.String)dataRow["CRS_NO"];
			entity.PfFlg = Convert.IsDBNull(dataRow["PF_FLG"]) ? null : (System.Decimal?)dataRow["PF_FLG"];
			entity.CrsLvl = Convert.IsDBNull(dataRow["CRS_LVL"]) ? null : (System.Decimal?)dataRow["CRS_LVL"];
			entity.OnlineFlg = Convert.IsDBNull(dataRow["ONLINE_FLG"]) ? null : (System.Decimal?)dataRow["ONLINE_FLG"];
			entity.StopMessage = Convert.IsDBNull(dataRow["STOP_MESSAGE"]) ? null : (System.String)dataRow["STOP_MESSAGE"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.EdCourseExpHdrId = Convert.IsDBNull(dataRow["ED_COURSE_EXP_HDR_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_EXP_HDR_ID"];
			entity.LoadWithTrain = Convert.IsDBNull(dataRow["LOAD_WITH_TRAIN"]) ? null : (System.Decimal?)dataRow["LOAD_WITH_TRAIN"];
			entity.ExamFlg = Convert.IsDBNull(dataRow["EXAM_FLG"]) ? null : (System.Decimal?)dataRow["EXAM_FLG"];
			entity.FreeFlg = Convert.IsDBNull(dataRow["FREE_FLG"]) ? null : (System.Decimal?)dataRow["FREE_FLG"];
			entity.IncmpltFlg = Convert.IsDBNull(dataRow["INCMPLT_FLG"]) ? null : (System.Decimal?)dataRow["INCMPLT_FLG"];
			entity.DropFlg = Convert.IsDBNull(dataRow["DROP_FLG"]) ? null : (System.Decimal?)dataRow["DROP_FLG"];
			entity.ExamHrs = Convert.IsDBNull(dataRow["EXAM_HRS"]) ? null : (System.Decimal?)dataRow["EXAM_HRS"];
			entity.CrsWgt = Convert.IsDBNull(dataRow["CRS_WGT"]) ? null : (System.Decimal?)dataRow["CRS_WGT"];
			entity.CourseDescrFr = Convert.IsDBNull(dataRow["COURSE_DESCR_FR"]) ? null : (System.String)dataRow["COURSE_DESCR_FR"];
			entity.Ects = Convert.IsDBNull(dataRow["ECTS"]) ? null : (System.Decimal?)dataRow["ECTS"];
			entity.LoadCrsCount = Convert.IsDBNull(dataRow["LOAD_CRS_COUNT"]) ? null : (System.Int32?)dataRow["LOAD_CRS_COUNT"];
			entity.ExtndFlg = Convert.IsDBNull(dataRow["EXTND_FLG"]) ? null : (System.Boolean?)dataRow["EXTND_FLG"];
			entity.CourseMod = Convert.IsDBNull(dataRow["Course_Mod"]) ? null : (System.String)dataRow["Course_Mod"];
			entity.EdCodeCourseTypeId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_TYPE_ID"]) ? null : (System.Int32?)dataRow["ED_CODE_COURSE_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourse"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourse Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourse entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeLanguageIdSource	
			if (CanDeepLoad(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepLoadType, innerList) 
				&& entity.GsCodeLanguageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeLanguageId;
				GsCodeLanguage tmpEntity = EntityManager.LocateEntity<GsCodeLanguage>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeLanguage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeLanguageIdSource = tmpEntity;
				else
					entity.GsCodeLanguageIdSource = DataRepository.GsCodeLanguageProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);		
				
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

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource

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

			#region EdCodeCourseIdSource	
			if (CanDeepLoad(entity, "EdCodeCourse|EdCodeCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseId ?? 0.0m);
				EdCodeCourse tmpEntity = EntityManager.LocateEntity<EdCodeCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseIdSource = tmpEntity;
				else
					entity.EdCodeCourseIdSource = DataRepository.EdCodeCourseProvider.GetByEdCodeCourseId(transactionManager, (entity.EdCodeCourseId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseProvider.DeepLoad(transactionManager, entity.EdCodeCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseIdSource

			#region EdCodeCourseTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseType|EdCodeCourseTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseTypeId ?? (int)0);
				EdCodeCourseType tmpEntity = EntityManager.LocateEntity<EdCodeCourseType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseTypeIdSource = tmpEntity;
				else
					entity.EdCodeCourseTypeIdSource = DataRepository.EdCodeCourseTypeProvider.GetByEdCodeCourseTypeId(transactionManager, (entity.EdCodeCourseTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseTypeProvider.DeepLoad(transactionManager, entity.EdCodeCourseTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseTypeIdSource

			#region EdCourseExpHdrIdSource	
			if (CanDeepLoad(entity, "EdCourseExpHdr|EdCourseExpHdrIdSource", deepLoadType, innerList) 
				&& entity.EdCourseExpHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseExpHdrId ?? 0.0m);
				EdCourseExpHdr tmpEntity = EntityManager.LocateEntity<EdCourseExpHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourseExpHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseExpHdrIdSource = tmpEntity;
				else
					entity.EdCourseExpHdrIdSource = DataRepository.EdCourseExpHdrProvider.GetByEdCourseExpHdrId(transactionManager, (entity.EdCourseExpHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseExpHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseExpHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseExpHdrProvider.DeepLoad(transactionManager, entity.EdCourseExpHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseExpHdrIdSource

			#region EdCoursePrfxIdSource	
			if (CanDeepLoad(entity, "EdCoursePrfx|EdCoursePrfxIdSource", deepLoadType, innerList) 
				&& entity.EdCoursePrfxIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCoursePrfxId ?? 0.0m);
				EdCoursePrfx tmpEntity = EntityManager.LocateEntity<EdCoursePrfx>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCoursePrfx), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCoursePrfxIdSource = tmpEntity;
				else
					entity.EdCoursePrfxIdSource = DataRepository.EdCoursePrfxProvider.GetByEdCoursePrfxId(transactionManager, (entity.EdCoursePrfxId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCoursePrfxIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCoursePrfxIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCoursePrfxProvider.DeepLoad(transactionManager, entity.EdCoursePrfxIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCoursePrfxIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainId ?? 0.0m));		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCourseId methods when available
			
			#region EdStudExmptCrsFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExmptCrsFrom>|EdStudExmptCrsFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptCrsFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExmptCrsFromCollection = DataRepository.EdStudExmptCrsFromProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudExmptCrsFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudExmptCrsFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExmptCrsFrom>) DataRepository.EdStudExmptCrsFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExmptCrsFromCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.WfCrsRsltApproveCollection = DataRepository.WfCrsRsltApproveProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.WfCrsRsltApproveCollection.Count > 0)
				{
					deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<WfCrsRsltApprove>) DataRepository.WfCrsRsltApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollectionGetByEdCourseOrgId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollectionGetByEdCourseOrgId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollectionGetByEdCourseOrgId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollectionGetByEdCourseOrgId = DataRepository.EdStudCourseRegProvider.GetByEdCourseOrgId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudCourseRegCollectionGetByEdCourseOrgId.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollectionGetByEdCourseOrgId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollectionGetByEdCourseOrgId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegPreCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegPreCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegPreCollection = DataRepository.EdStudCourseRegPreProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudCourseRegPreCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegPre>) DataRepository.EdStudCourseRegPreProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseTchngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseTchng>|EdCourseTchngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseTchngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseTchngCollection = DataRepository.EdCourseTchngProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseTchngCollection.Count > 0)
				{
					deepHandles.Add("EdCourseTchngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseTchng>) DataRepository.EdCourseTchngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseTchngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOfferingCourse>|EdOfferingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCourseCollection = DataRepository.EdOfferingCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdOfferingCourseCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOfferingCourse>) DataRepository.EdOfferingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseOrientCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOrient>|EdCourseOrientCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOrientCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOrientCollection = DataRepository.EdCourseOrientProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseOrientCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOrientCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOrient>) DataRepository.EdCourseOrientProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOrientCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdTrainStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTrainStud>|EdTrainStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTrainStudCollection = DataRepository.EdTrainStudProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdTrainStudCollection.Count > 0)
				{
					deepHandles.Add("EdTrainStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTrainStud>) DataRepository.EdTrainStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTrainStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseOutcomesTopicsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOutcomesTopicsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOutcomesTopicsCollection = DataRepository.EdCourseOutcomesTopicsProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseOutcomesTopicsCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOutcomesTopics>) DataRepository.EdCourseOutcomesTopicsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseWaitCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseWait>|EdStudCourseWaitCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseWaitCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseWaitCollection = DataRepository.EdStudCourseWaitProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudCourseWaitCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseWaitCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseWait>) DataRepository.EdStudCourseWaitProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseWaitCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamSchdlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamSchdl>|EdExamSchdlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamSchdlCollection = DataRepository.EdExamSchdlProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdExamSchdlCollection.Count > 0)
				{
					deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamSchdl>) DataRepository.EdExamSchdlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamSchdlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseTopicCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseTopic>|EdCourseTopicCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseTopicCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseTopicCollection = DataRepository.EdCourseTopicProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseTopicCollection.Count > 0)
				{
					deepHandles.Add("EdCourseTopicCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseTopic>) DataRepository.EdCourseTopicProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseTopicCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAssessCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAssessCourse>|EntPolicyAssessCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAssessCourseCollection = DataRepository.EntPolicyAssessCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EntPolicyAssessCourseCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAssessCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAssessCourse>) DataRepository.EntPolicyAssessCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAssessCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyGradingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingCourse>|EntPolicyGradingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingCourseCollection = DataRepository.EntPolicyGradingCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EntPolicyGradingCourseCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingCourse>) DataRepository.EntPolicyGradingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseBarredCollectionGetByEdBarredCourseId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseBarred>|EdCourseBarredCollectionGetByEdBarredCourseId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseBarredCollectionGetByEdBarredCourseId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseBarredCollectionGetByEdBarredCourseId = DataRepository.EdCourseBarredProvider.GetByEdBarredCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseBarredCollectionGetByEdBarredCourseId.Count > 0)
				{
					deepHandles.Add("EdCourseBarredCollectionGetByEdBarredCourseId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseBarred>) DataRepository.EdCourseBarredProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseBarredCollectionGetByEdBarredCourseId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseBarredCollectionGetByEdCourseId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseBarred>|EdCourseBarredCollectionGetByEdCourseId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseBarredCollectionGetByEdCourseId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseBarredCollectionGetByEdCourseId = DataRepository.EdCourseBarredProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseBarredCollectionGetByEdCourseId.Count > 0)
				{
					deepHandles.Add("EdCourseBarredCollectionGetByEdCourseId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseBarred>) DataRepository.EdCourseBarredProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseBarredCollectionGetByEdCourseId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisGrantStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisGrantStud>|PgThesisGrantStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisGrantStudCollection = DataRepository.PgThesisGrantStudProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.PgThesisGrantStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGrantStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGrantStud>) DataRepository.PgThesisGrantStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGrantStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudLatenessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudLateness>|EdStudLatenessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudLatenessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudLatenessCollection = DataRepository.EdStudLatenessProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudLatenessCollection.Count > 0)
				{
					deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLateness>) DataRepository.EdStudLatenessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLatenessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolcyGrdngCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGrdngCourse>|EntPolcyGrdngCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGrdngCourseCollection = DataRepository.EntPolcyGrdngCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EntPolcyGrdngCourseCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngCourse>) DataRepository.EntPolcyGrdngCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoContRmMemCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoContRmMemCourse>|CoContRmMemCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoContRmMemCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoContRmMemCourseCollection = DataRepository.CoContRmMemCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.CoContRmMemCourseCollection.Count > 0)
				{
					deepHandles.Add("CoContRmMemCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoContRmMemCourse>) DataRepository.CoContRmMemCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.CoContRmMemCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudCourseEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudCourseEval>|SvStudCourseEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCourseEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCourseEvalCollection = DataRepository.SvStudCourseEvalProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.SvStudCourseEvalCollection.Count > 0)
				{
					deepHandles.Add("SvStudCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudCourseEval>) DataRepository.SvStudCourseEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCourseEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseEquivCollectionGetByEdEquivCourseId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseEquiv>|EdCourseEquivCollectionGetByEdEquivCourseId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseEquivCollectionGetByEdEquivCourseId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseEquivCollectionGetByEdEquivCourseId = DataRepository.EdCourseEquivProvider.GetByEdEquivCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseEquivCollectionGetByEdEquivCourseId.Count > 0)
				{
					deepHandles.Add("EdCourseEquivCollectionGetByEdEquivCourseId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseEquiv>) DataRepository.EdCourseEquivProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseEquivCollectionGetByEdEquivCourseId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseRltdCollectionGetByEdCourse1Id
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseRltd>|EdCourseRltdCollectionGetByEdCourse1Id", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseRltdCollectionGetByEdCourse1Id' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseRltdCollectionGetByEdCourse1Id = DataRepository.EdCourseRltdProvider.GetByEdCourse1Id(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseRltdCollectionGetByEdCourse1Id.Count > 0)
				{
					deepHandles.Add("EdCourseRltdCollectionGetByEdCourse1Id",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseRltd>) DataRepository.EdCourseRltdProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseRltdCollectionGetByEdCourse1Id, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherCrsItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherCrsItem>|FeeStudVoucherCrsItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCrsItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCrsItemCollection = DataRepository.FeeStudVoucherCrsItemProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.FeeStudVoucherCrsItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCrsItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherCrsItem>) DataRepository.FeeStudVoucherCrsItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCrsItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudComp>|SvStudCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCompCollection = DataRepository.SvStudCompProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.SvStudCompCollection.Count > 0)
				{
					deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudComp>) DataRepository.SvStudCompProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCompCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseInfo>|EdCourseInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseInfoCollection = DataRepository.EdCourseInfoProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseInfoCollection.Count > 0)
				{
					deepHandles.Add("EdCourseInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseInfo>) DataRepository.EdCourseInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCrsFreeRstrctdCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCrsFreeRstrctd>|EdCrsFreeRstrctdCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCrsFreeRstrctdCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCrsFreeRstrctdCollection = DataRepository.EdCrsFreeRstrctdProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCrsFreeRstrctdCollection.Count > 0)
				{
					deepHandles.Add("EdCrsFreeRstrctdCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCrsFreeRstrctd>) DataRepository.EdCrsFreeRstrctdProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCrsFreeRstrctdCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamCourse>|AdmPlaceExamCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamCourseCollection = DataRepository.AdmPlaceExamCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.AdmPlaceExamCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamCourse>) DataRepository.AdmPlaceExamCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoCourseResultCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoCourseResult>|CoCourseResultCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoCourseResultCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoCourseResultCollection = DataRepository.CoCourseResultProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.CoCourseResultCollection.Count > 0)
				{
					deepHandles.Add("CoCourseResultCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoCourseResult>) DataRepository.CoCourseResultProvider.DeepLoad,
						new object[] { transactionManager, entity.CoCourseResultCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudCoursesItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudCoursesItem>|FeeStudCoursesItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudCoursesItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudCoursesItemCollection = DataRepository.FeeStudCoursesItemProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.FeeStudCoursesItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudCoursesItem>) DataRepository.FeeStudCoursesItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegTempCollection = DataRepository.EdStudCourseRegTempProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudCourseRegTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegTemp>) DataRepository.EdStudCourseRegTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseChngCollectionGetByEdCourseId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseChng>|EdStudCourseChngCollectionGetByEdCourseId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseChngCollectionGetByEdCourseId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseChngCollectionGetByEdCourseId = DataRepository.EdStudCourseChngProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudCourseChngCollectionGetByEdCourseId.Count > 0)
				{
					deepHandles.Add("EdStudCourseChngCollectionGetByEdCourseId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseChng>) DataRepository.EdStudCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseChngCollectionGetByEdCourseId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseChngCollectionGetByEdCourseSubId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseChng>|EdStudCourseChngCollectionGetByEdCourseSubId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseChngCollectionGetByEdCourseSubId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseChngCollectionGetByEdCourseSubId = DataRepository.EdStudCourseChngProvider.GetByEdCourseSubId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudCourseChngCollectionGetByEdCourseSubId.Count > 0)
				{
					deepHandles.Add("EdStudCourseChngCollectionGetByEdCourseSubId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseChng>) DataRepository.EdStudCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseChngCollectionGetByEdCourseSubId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExmptCrsToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExmptCrsTo>|EdStudExmptCrsToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptCrsToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExmptCrsToCollection = DataRepository.EdStudExmptCrsToProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudExmptCrsToCollection.Count > 0)
				{
					deepHandles.Add("EdStudExmptCrsToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExmptCrsTo>) DataRepository.EdStudExmptCrsToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExmptCrsToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoCrsRsltRaiseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoCrsRsltRaiseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoCrsRsltRaiseCollection = DataRepository.CoCrsRsltRaiseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.CoCrsRsltRaiseCollection.Count > 0)
				{
					deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoCrsRsltRaise>) DataRepository.CoCrsRsltRaiseProvider.DeepLoad,
						new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntMajorPhaseCrsExpCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMajorPhaseCrsExp>|EntMajorPhaseCrsExpCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMajorPhaseCrsExpCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMajorPhaseCrsExpCollection = DataRepository.EntMajorPhaseCrsExpProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EntMajorPhaseCrsExpCollection.Count > 0)
				{
					deepHandles.Add("EntMajorPhaseCrsExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMajorPhaseCrsExp>) DataRepository.EntMajorPhaseCrsExpProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMajorPhaseCrsExpCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOutcomeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOutcome>|EdOutcomeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOutcomeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOutcomeCollection = DataRepository.EdOutcomeProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdOutcomeCollection.Count > 0)
				{
					deepHandles.Add("EdOutcomeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOutcome>) DataRepository.EdOutcomeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOutcomeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamCrsOrderCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamCrsOrder>|EdExamCrsOrderCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamCrsOrderCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamCrsOrderCollection = DataRepository.EdExamCrsOrderProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdExamCrsOrderCollection.Count > 0)
				{
					deepHandles.Add("EdExamCrsOrderCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamCrsOrder>) DataRepository.EdExamCrsOrderProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamCrsOrderCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBranchCrsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBranchCrs>|EdBranchCrsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBranchCrsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBranchCrsCollection = DataRepository.EdBranchCrsProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdBranchCrsCollection.Count > 0)
				{
					deepHandles.Add("EdBranchCrsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBranchCrs>) DataRepository.EdBranchCrsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBranchCrsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSectionGroupHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSectionGroupHdrCollection = DataRepository.ScSectionGroupHdrProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.ScSectionGroupHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupHdr>) DataRepository.ScSectionGroupHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdProjStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdProjStud>|EdProjStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdProjStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdProjStudCollection = DataRepository.EdProjStudProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdProjStudCollection.Count > 0)
				{
					deepHandles.Add("EdProjStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdProjStud>) DataRepository.EdProjStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdProjStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCourseEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEval>|SvCourseEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalCollection = DataRepository.SvCourseEvalProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.SvCourseEvalCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEval>) DataRepository.SvCourseEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRplcCollectionGetByEdCourseOldId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRplc>|EdStudCourseRplcCollectionGetByEdCourseOldId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRplcCollectionGetByEdCourseOldId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRplcCollectionGetByEdCourseOldId = DataRepository.EdStudCourseRplcProvider.GetByEdCourseOldId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudCourseRplcCollectionGetByEdCourseOldId.Count > 0)
				{
					deepHandles.Add("EdStudCourseRplcCollectionGetByEdCourseOldId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRplc>) DataRepository.EdStudCourseRplcProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRplcCollectionGetByEdCourseOldId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollectionGetByEdCourseId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollectionGetByEdCourseId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollectionGetByEdCourseId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollectionGetByEdCourseId = DataRepository.EdStudCourseRegProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudCourseRegCollectionGetByEdCourseId.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollectionGetByEdCourseId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollectionGetByEdCourseId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScHallRsrvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScHallRsrv>|ScHallRsrvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallRsrvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScHallRsrvCollection = DataRepository.ScHallRsrvProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.ScHallRsrvCollection.Count > 0)
				{
					deepHandles.Add("ScHallRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScHallRsrv>) DataRepository.ScHallRsrvProvider.DeepLoad,
						new object[] { transactionManager, entity.ScHallRsrvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseRltdCollectionGetByEdCourse2Id
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseRltd>|EdCourseRltdCollectionGetByEdCourse2Id", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseRltdCollectionGetByEdCourse2Id' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseRltdCollectionGetByEdCourse2Id = DataRepository.EdCourseRltdProvider.GetByEdCourse2Id(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseRltdCollectionGetByEdCourse2Id.Count > 0)
				{
					deepHandles.Add("EdCourseRltdCollectionGetByEdCourse2Id",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseRltd>) DataRepository.EdCourseRltdProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseRltdCollectionGetByEdCourse2Id, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsence>|EdStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsenceCollection = DataRepository.EdStudAbsenceProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsence>) DataRepository.EdStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsFwCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsFwCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsFwCollection = DataRepository.EdStudAbsFwProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudAbsFwCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsFw>) DataRepository.EdStudAbsFwProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsFwCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCoursePkgDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgDtl>|EntCoursePkgDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgDtlCollection = DataRepository.EntCoursePkgDtlProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EntCoursePkgDtlCollection.Count > 0)
				{
					deepHandles.Add("EntCoursePkgDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgDtl>) DataRepository.EntCoursePkgDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRplcCollectionGetByEdCourseNewId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRplc>|EdStudCourseRplcCollectionGetByEdCourseNewId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRplcCollectionGetByEdCourseNewId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRplcCollectionGetByEdCourseNewId = DataRepository.EdStudCourseRplcProvider.GetByEdCourseNewId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudCourseRplcCollectionGetByEdCourseNewId.Count > 0)
				{
					deepHandles.Add("EdStudCourseRplcCollectionGetByEdCourseNewId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRplc>) DataRepository.EdStudCourseRplcProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRplcCollectionGetByEdCourseNewId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseEquivCollectionGetByEdCourseId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseEquiv>|EdCourseEquivCollectionGetByEdCourseId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseEquivCollectionGetByEdCourseId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseEquivCollectionGetByEdCourseId = DataRepository.EdCourseEquivProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseEquivCollectionGetByEdCourseId.Count > 0)
				{
					deepHandles.Add("EdCourseEquivCollectionGetByEdCourseId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseEquiv>) DataRepository.EdCourseEquivProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseEquivCollectionGetByEdCourseId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlSlotCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlSlotCollection = DataRepository.ScSchdlSlotProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.ScSchdlSlotCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlSlot>) DataRepository.ScSchdlSlotProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlSlotCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExcuseCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExcuseCourse>|EdStudExcuseCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExcuseCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExcuseCourseCollection = DataRepository.EdStudExcuseCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudExcuseCourseCollection.Count > 0)
				{
					deepHandles.Add("EdStudExcuseCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExcuseCourse>) DataRepository.EdStudExcuseCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExcuseCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvPollHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvPollHdr>|SvPollHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvPollHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvPollHdrCollection = DataRepository.SvPollHdrProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.SvPollHdrCollection.Count > 0)
				{
					deepHandles.Add("SvPollHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvPollHdr>) DataRepository.SvPollHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvPollHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppPlaceExamCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppPlaceExamCourse>|AdmAppPlaceExamCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPlaceExamCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppPlaceExamCourseCollection = DataRepository.AdmAppPlaceExamCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.AdmAppPlaceExamCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPlaceExamCourse>) DataRepository.AdmAppPlaceExamCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPlaceExamCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCrsAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCrsAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCrsAssessCollection = DataRepository.SeUserCrsAssessProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.SeUserCrsAssessCollection.Count > 0)
				{
					deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserCrsAssess>) DataRepository.SeUserCrsAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCrsAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseExpDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseExpDtl>|EdCourseExpDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseExpDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseExpDtlCollection = DataRepository.EdCourseExpDtlProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseExpDtlCollection.Count > 0)
				{
					deepHandles.Add("EdCourseExpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseExpDtl>) DataRepository.EdCourseExpDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseExpDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSectionGroupDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSectionGroupDtl>|ScSectionGroupDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSectionGroupDtlCollection = DataRepository.ScSectionGroupDtlProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.ScSectionGroupDtlCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupDtl>) DataRepository.ScSectionGroupDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoStudSecretNumCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoStudSecretNum>|CoStudSecretNumCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoStudSecretNumCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoStudSecretNumCollection = DataRepository.CoStudSecretNumProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.CoStudSecretNumCollection.Count > 0)
				{
					deepHandles.Add("CoStudSecretNumCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoStudSecretNum>) DataRepository.CoStudSecretNumProvider.DeepLoad,
						new object[] { transactionManager, entity.CoStudSecretNumCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadPlanDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlanDtl>|EdAcadPlanDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanDtlCollection = DataRepository.EdAcadPlanDtlProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdAcadPlanDtlCollection.Count > 0)
				{
					deepHandles.Add("EdAcadPlanDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlanDtl>) DataRepository.EdAcadPlanDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransToCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransToCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransToCourseCollection = DataRepository.AdmAppTransToCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.AdmAppTransToCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransToCourse>) DataRepository.AdmAppTransToCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseCoreqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseCoreq>|EdCourseCoreqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseCoreqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseCoreqCollection = DataRepository.EdCourseCoreqProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdCourseCoreqCollection.Count > 0)
				{
					deepHandles.Add("EdCourseCoreqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseCoreq>) DataRepository.EdCourseCoreqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseCoreqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppExmptCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppExmptCourse>|AdmAppExmptCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppExmptCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppExmptCourseCollection = DataRepository.AdmAppExmptCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.AdmAppExmptCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppExmptCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppExmptCourse>) DataRepository.AdmAppExmptCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppExmptCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCourseExpCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCourseExp>|FeeCourseExpCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCourseExpCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCourseExpCollection = DataRepository.FeeCourseExpProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.FeeCourseExpCollection.Count > 0)
				{
					deepHandles.Add("FeeCourseExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCourseExp>) DataRepository.FeeCourseExpProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCourseExpCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeBlockTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeBlockTrans>|SeBlockTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeBlockTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeBlockTransCollection = DataRepository.SeBlockTransProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.SeBlockTransCollection.Count > 0)
				{
					deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeBlockTrans>) DataRepository.SeBlockTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SeBlockTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupInfo>|ScGroupInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupInfoCollection = DataRepository.ScGroupInfoProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.ScGroupInfoCollection.Count > 0)
				{
					deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupInfo>) DataRepository.ScGroupInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvLecNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvLecNote>|SvLecNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvLecNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvLecNoteCollection = DataRepository.SvLecNoteProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.SvLecNoteCollection.Count > 0)
				{
					deepHandles.Add("SvLecNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvLecNote>) DataRepository.SvLecNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.SvLecNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyGradingLevelCoursesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingLevelCourses>|EntPolicyGradingLevelCoursesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingLevelCoursesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingLevelCoursesCollection = DataRepository.EntPolicyGradingLevelCoursesProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EntPolicyGradingLevelCoursesCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingLevelCoursesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingLevelCourses>) DataRepository.EntPolicyGradingLevelCoursesProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingLevelCoursesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStaffCoursePrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStaffCoursePref>|EdStaffCoursePrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStaffCoursePrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStaffCoursePrefCollection = DataRepository.EdStaffCoursePrefProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EdStaffCoursePrefCollection.Count > 0)
				{
					deepHandles.Add("EdStaffCoursePrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStaffCoursePref>) DataRepository.EdStaffCoursePrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStaffCoursePrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupDay>|ScGroupDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupDayCollection = DataRepository.ScGroupDayProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.ScGroupDayCollection.Count > 0)
				{
					deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupDay>) DataRepository.ScGroupDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCourseMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCourseMdData>|EntCourseMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCourseMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCourseMdDataCollection = DataRepository.EntCourseMdDataProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.EntCourseMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntCourseMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCourseMdData>) DataRepository.EntCourseMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCourseMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCodeEngTestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCodeEngTest>|AdmCodeEngTestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeEngTestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCodeEngTestCollection = DataRepository.AdmCodeEngTestProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);

				if (deep && entity.AdmCodeEngTestCollection.Count > 0)
				{
					deepHandles.Add("AdmCodeEngTestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCodeEngTest>) DataRepository.AdmCodeEngTestProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCodeEngTestCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourse object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourse instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourse Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourse entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeLanguageIdSource
			if (CanDeepSave(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepSaveType, innerList) 
				&& entity.GsCodeLanguageIdSource != null)
			{
				DataRepository.GsCodeLanguageProvider.Save(transactionManager, entity.GsCodeLanguageIdSource);
				entity.GsCodeLanguageId = entity.GsCodeLanguageIdSource.GsCodeLanguageId;
			}
			#endregion 
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
			}
			#endregion 
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region EdCodeCourseIdSource
			if (CanDeepSave(entity, "EdCodeCourse|EdCodeCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseIdSource != null)
			{
				DataRepository.EdCodeCourseProvider.Save(transactionManager, entity.EdCodeCourseIdSource);
				entity.EdCodeCourseId = entity.EdCodeCourseIdSource.EdCodeCourseId;
			}
			#endregion 
			
			#region EdCodeCourseTypeIdSource
			if (CanDeepSave(entity, "EdCodeCourseType|EdCodeCourseTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseTypeIdSource != null)
			{
				DataRepository.EdCodeCourseTypeProvider.Save(transactionManager, entity.EdCodeCourseTypeIdSource);
				entity.EdCodeCourseTypeId = entity.EdCodeCourseTypeIdSource.EdCodeCourseTypeId;
			}
			#endregion 
			
			#region EdCourseExpHdrIdSource
			if (CanDeepSave(entity, "EdCourseExpHdr|EdCourseExpHdrIdSource", deepSaveType, innerList) 
				&& entity.EdCourseExpHdrIdSource != null)
			{
				DataRepository.EdCourseExpHdrProvider.Save(transactionManager, entity.EdCourseExpHdrIdSource);
				entity.EdCourseExpHdrId = entity.EdCourseExpHdrIdSource.EdCourseExpHdrId;
			}
			#endregion 
			
			#region EdCoursePrfxIdSource
			if (CanDeepSave(entity, "EdCoursePrfx|EdCoursePrfxIdSource", deepSaveType, innerList) 
				&& entity.EdCoursePrfxIdSource != null)
			{
				DataRepository.EdCoursePrfxProvider.Save(transactionManager, entity.EdCoursePrfxIdSource);
				entity.EdCoursePrfxId = entity.EdCoursePrfxIdSource.EdCoursePrfxId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudExmptCrsFrom>
				if (CanDeepSave(entity.EdStudExmptCrsFromCollection, "List<EdStudExmptCrsFrom>|EdStudExmptCrsFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExmptCrsFrom child in entity.EdStudExmptCrsFromCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudExmptCrsFromCollection.Count > 0 || entity.EdStudExmptCrsFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExmptCrsFromProvider.Save(transactionManager, entity.EdStudExmptCrsFromCollection);
						
						deepHandles.Add("EdStudExmptCrsFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExmptCrsFrom >) DataRepository.EdStudExmptCrsFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExmptCrsFromCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
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
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollectionGetByEdCourseOrgId, "List<EdStudCourseReg>|EdStudCourseRegCollectionGetByEdCourseOrgId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollectionGetByEdCourseOrgId)
					{
						if(child.EdCourseOrgIdSource != null)
						{
							child.EdCourseOrgId = child.EdCourseOrgIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseOrgId = entity.EdCourseId;
						}

					}

					if (entity.EdStudCourseRegCollectionGetByEdCourseOrgId.Count > 0 || entity.EdStudCourseRegCollectionGetByEdCourseOrgId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollectionGetByEdCourseOrgId);
						
						deepHandles.Add("EdStudCourseRegCollectionGetByEdCourseOrgId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollectionGetByEdCourseOrgId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegPre>
				if (CanDeepSave(entity.EdStudCourseRegPreCollection, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegPre child in entity.EdStudCourseRegPreCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudCourseRegPreCollection.Count > 0 || entity.EdStudCourseRegPreCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegPreProvider.Save(transactionManager, entity.EdStudCourseRegPreCollection);
						
						deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegPre >) DataRepository.EdStudCourseRegPreProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseTchng>
				if (CanDeepSave(entity.EdCourseTchngCollection, "List<EdCourseTchng>|EdCourseTchngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseTchng child in entity.EdCourseTchngCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseTchngCollection.Count > 0 || entity.EdCourseTchngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseTchngProvider.Save(transactionManager, entity.EdCourseTchngCollection);
						
						deepHandles.Add("EdCourseTchngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseTchng >) DataRepository.EdCourseTchngProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseTchngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOfferingCourse>
				if (CanDeepSave(entity.EdOfferingCourseCollection, "List<EdOfferingCourse>|EdOfferingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOfferingCourse child in entity.EdOfferingCourseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdOfferingCourseCollection.Count > 0 || entity.EdOfferingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingCourseProvider.Save(transactionManager, entity.EdOfferingCourseCollection);
						
						deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOfferingCourse >) DataRepository.EdOfferingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseOrient>
				if (CanDeepSave(entity.EdCourseOrientCollection, "List<EdCourseOrient>|EdCourseOrientCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOrient child in entity.EdCourseOrientCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseOrientCollection.Count > 0 || entity.EdCourseOrientCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOrientProvider.Save(transactionManager, entity.EdCourseOrientCollection);
						
						deepHandles.Add("EdCourseOrientCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOrient >) DataRepository.EdCourseOrientProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOrientCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdTrainStud>
				if (CanDeepSave(entity.EdTrainStudCollection, "List<EdTrainStud>|EdTrainStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTrainStud child in entity.EdTrainStudCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdTrainStudCollection.Count > 0 || entity.EdTrainStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTrainStudProvider.Save(transactionManager, entity.EdTrainStudCollection);
						
						deepHandles.Add("EdTrainStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTrainStud >) DataRepository.EdTrainStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdTrainStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseOutcomesTopics>
				if (CanDeepSave(entity.EdCourseOutcomesTopicsCollection, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOutcomesTopics child in entity.EdCourseOutcomesTopicsCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseOutcomesTopicsCollection.Count > 0 || entity.EdCourseOutcomesTopicsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOutcomesTopicsProvider.Save(transactionManager, entity.EdCourseOutcomesTopicsCollection);
						
						deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOutcomesTopics >) DataRepository.EdCourseOutcomesTopicsProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseWait>
				if (CanDeepSave(entity.EdStudCourseWaitCollection, "List<EdStudCourseWait>|EdStudCourseWaitCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseWait child in entity.EdStudCourseWaitCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudCourseWaitCollection.Count > 0 || entity.EdStudCourseWaitCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseWaitProvider.Save(transactionManager, entity.EdStudCourseWaitCollection);
						
						deepHandles.Add("EdStudCourseWaitCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseWait >) DataRepository.EdStudCourseWaitProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseWaitCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdExamSchdl>
				if (CanDeepSave(entity.EdExamSchdlCollection, "List<EdExamSchdl>|EdExamSchdlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamSchdl child in entity.EdExamSchdlCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdExamSchdlCollection.Count > 0 || entity.EdExamSchdlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlCollection);
						
						deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamSchdl >) DataRepository.EdExamSchdlProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamSchdlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseTopic>
				if (CanDeepSave(entity.EdCourseTopicCollection, "List<EdCourseTopic>|EdCourseTopicCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseTopic child in entity.EdCourseTopicCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseTopicCollection.Count > 0 || entity.EdCourseTopicCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseTopicProvider.Save(transactionManager, entity.EdCourseTopicCollection);
						
						deepHandles.Add("EdCourseTopicCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseTopic >) DataRepository.EdCourseTopicProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseTopicCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAssessCourse>
				if (CanDeepSave(entity.EntPolicyAssessCourseCollection, "List<EntPolicyAssessCourse>|EntPolicyAssessCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAssessCourse child in entity.EntPolicyAssessCourseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EntPolicyAssessCourseCollection.Count > 0 || entity.EntPolicyAssessCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAssessCourseProvider.Save(transactionManager, entity.EntPolicyAssessCourseCollection);
						
						deepHandles.Add("EntPolicyAssessCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAssessCourse >) DataRepository.EntPolicyAssessCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAssessCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyGradingCourse>
				if (CanDeepSave(entity.EntPolicyGradingCourseCollection, "List<EntPolicyGradingCourse>|EntPolicyGradingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingCourse child in entity.EntPolicyGradingCourseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EntPolicyGradingCourseCollection.Count > 0 || entity.EntPolicyGradingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingCourseProvider.Save(transactionManager, entity.EntPolicyGradingCourseCollection);
						
						deepHandles.Add("EntPolicyGradingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingCourse >) DataRepository.EntPolicyGradingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseBarred>
				if (CanDeepSave(entity.EdCourseBarredCollectionGetByEdBarredCourseId, "List<EdCourseBarred>|EdCourseBarredCollectionGetByEdBarredCourseId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseBarred child in entity.EdCourseBarredCollectionGetByEdBarredCourseId)
					{
						if(child.EdBarredCourseIdSource != null)
						{
							child.EdBarredCourseId = child.EdBarredCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdBarredCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseBarredCollectionGetByEdBarredCourseId.Count > 0 || entity.EdCourseBarredCollectionGetByEdBarredCourseId.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseBarredProvider.Save(transactionManager, entity.EdCourseBarredCollectionGetByEdBarredCourseId);
						
						deepHandles.Add("EdCourseBarredCollectionGetByEdBarredCourseId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseBarred >) DataRepository.EdCourseBarredProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseBarredCollectionGetByEdBarredCourseId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseBarred>
				if (CanDeepSave(entity.EdCourseBarredCollectionGetByEdCourseId, "List<EdCourseBarred>|EdCourseBarredCollectionGetByEdCourseId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseBarred child in entity.EdCourseBarredCollectionGetByEdCourseId)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseBarredCollectionGetByEdCourseId.Count > 0 || entity.EdCourseBarredCollectionGetByEdCourseId.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseBarredProvider.Save(transactionManager, entity.EdCourseBarredCollectionGetByEdCourseId);
						
						deepHandles.Add("EdCourseBarredCollectionGetByEdCourseId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseBarred >) DataRepository.EdCourseBarredProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseBarredCollectionGetByEdCourseId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisGrantStud>
				if (CanDeepSave(entity.PgThesisGrantStudCollection, "List<PgThesisGrantStud>|PgThesisGrantStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGrantStud child in entity.PgThesisGrantStudCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.PgThesisGrantStudCollection.Count > 0 || entity.PgThesisGrantStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisGrantStudProvider.Save(transactionManager, entity.PgThesisGrantStudCollection);
						
						deepHandles.Add("PgThesisGrantStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisGrantStud >) DataRepository.PgThesisGrantStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisGrantStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudLateness>
				if (CanDeepSave(entity.EdStudLatenessCollection, "List<EdStudLateness>|EdStudLatenessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudLateness child in entity.EdStudLatenessCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudLatenessCollection.Count > 0 || entity.EdStudLatenessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudLatenessProvider.Save(transactionManager, entity.EdStudLatenessCollection);
						
						deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudLateness >) DataRepository.EdStudLatenessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudLatenessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolcyGrdngCourse>
				if (CanDeepSave(entity.EntPolcyGrdngCourseCollection, "List<EntPolcyGrdngCourse>|EntPolcyGrdngCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGrdngCourse child in entity.EntPolcyGrdngCourseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EntPolcyGrdngCourseCollection.Count > 0 || entity.EntPolcyGrdngCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGrdngCourseProvider.Save(transactionManager, entity.EntPolcyGrdngCourseCollection);
						
						deepHandles.Add("EntPolcyGrdngCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGrdngCourse >) DataRepository.EntPolcyGrdngCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGrdngCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoContRmMemCourse>
				if (CanDeepSave(entity.CoContRmMemCourseCollection, "List<CoContRmMemCourse>|CoContRmMemCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoContRmMemCourse child in entity.CoContRmMemCourseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.CoContRmMemCourseCollection.Count > 0 || entity.CoContRmMemCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoContRmMemCourseProvider.Save(transactionManager, entity.CoContRmMemCourseCollection);
						
						deepHandles.Add("CoContRmMemCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoContRmMemCourse >) DataRepository.CoContRmMemCourseProvider.DeepSave,
							new object[] { transactionManager, entity.CoContRmMemCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudCourseEval>
				if (CanDeepSave(entity.SvStudCourseEvalCollection, "List<SvStudCourseEval>|SvStudCourseEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudCourseEval child in entity.SvStudCourseEvalCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.SvStudCourseEvalCollection.Count > 0 || entity.SvStudCourseEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCourseEvalProvider.Save(transactionManager, entity.SvStudCourseEvalCollection);
						
						deepHandles.Add("SvStudCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudCourseEval >) DataRepository.SvStudCourseEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCourseEvalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseEquiv>
				if (CanDeepSave(entity.EdCourseEquivCollectionGetByEdEquivCourseId, "List<EdCourseEquiv>|EdCourseEquivCollectionGetByEdEquivCourseId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseEquiv child in entity.EdCourseEquivCollectionGetByEdEquivCourseId)
					{
						if(child.EdEquivCourseIdSource != null)
						{
							child.EdEquivCourseId = child.EdEquivCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdEquivCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseEquivCollectionGetByEdEquivCourseId.Count > 0 || entity.EdCourseEquivCollectionGetByEdEquivCourseId.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseEquivProvider.Save(transactionManager, entity.EdCourseEquivCollectionGetByEdEquivCourseId);
						
						deepHandles.Add("EdCourseEquivCollectionGetByEdEquivCourseId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseEquiv >) DataRepository.EdCourseEquivProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseEquivCollectionGetByEdEquivCourseId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseRltd>
				if (CanDeepSave(entity.EdCourseRltdCollectionGetByEdCourse1Id, "List<EdCourseRltd>|EdCourseRltdCollectionGetByEdCourse1Id", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseRltd child in entity.EdCourseRltdCollectionGetByEdCourse1Id)
					{
						if(child.EdCourse1IdSource != null)
						{
							child.EdCourse1Id = child.EdCourse1IdSource.EdCourseId;
						}
						else
						{
							child.EdCourse1Id = entity.EdCourseId;
						}

					}

					if (entity.EdCourseRltdCollectionGetByEdCourse1Id.Count > 0 || entity.EdCourseRltdCollectionGetByEdCourse1Id.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseRltdProvider.Save(transactionManager, entity.EdCourseRltdCollectionGetByEdCourse1Id);
						
						deepHandles.Add("EdCourseRltdCollectionGetByEdCourse1Id",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseRltd >) DataRepository.EdCourseRltdProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseRltdCollectionGetByEdCourse1Id, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucherCrsItem>
				if (CanDeepSave(entity.FeeStudVoucherCrsItemCollection, "List<FeeStudVoucherCrsItem>|FeeStudVoucherCrsItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherCrsItem child in entity.FeeStudVoucherCrsItemCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.FeeStudVoucherCrsItemCollection.Count > 0 || entity.FeeStudVoucherCrsItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherCrsItemProvider.Save(transactionManager, entity.FeeStudVoucherCrsItemCollection);
						
						deepHandles.Add("FeeStudVoucherCrsItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucherCrsItem >) DataRepository.FeeStudVoucherCrsItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCrsItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudComp>
				if (CanDeepSave(entity.SvStudCompCollection, "List<SvStudComp>|SvStudCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudComp child in entity.SvStudCompCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.SvStudCompCollection.Count > 0 || entity.SvStudCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCompProvider.Save(transactionManager, entity.SvStudCompCollection);
						
						deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudComp >) DataRepository.SvStudCompProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCompCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseInfo>
				if (CanDeepSave(entity.EdCourseInfoCollection, "List<EdCourseInfo>|EdCourseInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseInfo child in entity.EdCourseInfoCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseInfoCollection.Count > 0 || entity.EdCourseInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseInfoProvider.Save(transactionManager, entity.EdCourseInfoCollection);
						
						deepHandles.Add("EdCourseInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseInfo >) DataRepository.EdCourseInfoProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCrsFreeRstrctd>
				if (CanDeepSave(entity.EdCrsFreeRstrctdCollection, "List<EdCrsFreeRstrctd>|EdCrsFreeRstrctdCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCrsFreeRstrctd child in entity.EdCrsFreeRstrctdCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCrsFreeRstrctdCollection.Count > 0 || entity.EdCrsFreeRstrctdCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCrsFreeRstrctdProvider.Save(transactionManager, entity.EdCrsFreeRstrctdCollection);
						
						deepHandles.Add("EdCrsFreeRstrctdCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCrsFreeRstrctd >) DataRepository.EdCrsFreeRstrctdProvider.DeepSave,
							new object[] { transactionManager, entity.EdCrsFreeRstrctdCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPlaceExamCourse>
				if (CanDeepSave(entity.AdmPlaceExamCourseCollection, "List<AdmPlaceExamCourse>|AdmPlaceExamCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamCourse child in entity.AdmPlaceExamCourseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.AdmPlaceExamCourseCollection.Count > 0 || entity.AdmPlaceExamCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamCourseProvider.Save(transactionManager, entity.AdmPlaceExamCourseCollection);
						
						deepHandles.Add("AdmPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamCourse >) DataRepository.AdmPlaceExamCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoCourseResult>
				if (CanDeepSave(entity.CoCourseResultCollection, "List<CoCourseResult>|CoCourseResultCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoCourseResult child in entity.CoCourseResultCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.CoCourseResultCollection.Count > 0 || entity.CoCourseResultCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoCourseResultProvider.Save(transactionManager, entity.CoCourseResultCollection);
						
						deepHandles.Add("CoCourseResultCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoCourseResult >) DataRepository.CoCourseResultProvider.DeepSave,
							new object[] { transactionManager, entity.CoCourseResultCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudCoursesItem>
				if (CanDeepSave(entity.FeeStudCoursesItemCollection, "List<FeeStudCoursesItem>|FeeStudCoursesItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudCoursesItem child in entity.FeeStudCoursesItemCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.FeeStudCoursesItemCollection.Count > 0 || entity.FeeStudCoursesItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudCoursesItemProvider.Save(transactionManager, entity.FeeStudCoursesItemCollection);
						
						deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudCoursesItem >) DataRepository.FeeStudCoursesItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegTemp>
				if (CanDeepSave(entity.EdStudCourseRegTempCollection, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegTemp child in entity.EdStudCourseRegTempCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudCourseRegTempCollection.Count > 0 || entity.EdStudCourseRegTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegTempProvider.Save(transactionManager, entity.EdStudCourseRegTempCollection);
						
						deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegTemp >) DataRepository.EdStudCourseRegTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseChng>
				if (CanDeepSave(entity.EdStudCourseChngCollectionGetByEdCourseId, "List<EdStudCourseChng>|EdStudCourseChngCollectionGetByEdCourseId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseChng child in entity.EdStudCourseChngCollectionGetByEdCourseId)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudCourseChngCollectionGetByEdCourseId.Count > 0 || entity.EdStudCourseChngCollectionGetByEdCourseId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseChngProvider.Save(transactionManager, entity.EdStudCourseChngCollectionGetByEdCourseId);
						
						deepHandles.Add("EdStudCourseChngCollectionGetByEdCourseId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseChng >) DataRepository.EdStudCourseChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseChngCollectionGetByEdCourseId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseChng>
				if (CanDeepSave(entity.EdStudCourseChngCollectionGetByEdCourseSubId, "List<EdStudCourseChng>|EdStudCourseChngCollectionGetByEdCourseSubId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseChng child in entity.EdStudCourseChngCollectionGetByEdCourseSubId)
					{
						if(child.EdCourseSubIdSource != null)
						{
							child.EdCourseSubId = child.EdCourseSubIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseSubId = entity.EdCourseId;
						}

					}

					if (entity.EdStudCourseChngCollectionGetByEdCourseSubId.Count > 0 || entity.EdStudCourseChngCollectionGetByEdCourseSubId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseChngProvider.Save(transactionManager, entity.EdStudCourseChngCollectionGetByEdCourseSubId);
						
						deepHandles.Add("EdStudCourseChngCollectionGetByEdCourseSubId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseChng >) DataRepository.EdStudCourseChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseChngCollectionGetByEdCourseSubId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExmptCrsTo>
				if (CanDeepSave(entity.EdStudExmptCrsToCollection, "List<EdStudExmptCrsTo>|EdStudExmptCrsToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExmptCrsTo child in entity.EdStudExmptCrsToCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudExmptCrsToCollection.Count > 0 || entity.EdStudExmptCrsToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExmptCrsToProvider.Save(transactionManager, entity.EdStudExmptCrsToCollection);
						
						deepHandles.Add("EdStudExmptCrsToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExmptCrsTo >) DataRepository.EdStudExmptCrsToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExmptCrsToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseFrom>
				if (CanDeepSave(entity.EdStudIntTrnsCourseFromCollection, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseFrom child in entity.EdStudIntTrnsCourseFromCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudIntTrnsCourseFromCollection.Count > 0 || entity.EdStudIntTrnsCourseFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseFromProvider.Save(transactionManager, entity.EdStudIntTrnsCourseFromCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseFrom >) DataRepository.EdStudIntTrnsCourseFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoCrsRsltRaise>
				if (CanDeepSave(entity.CoCrsRsltRaiseCollection, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoCrsRsltRaise child in entity.CoCrsRsltRaiseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.CoCrsRsltRaiseCollection.Count > 0 || entity.CoCrsRsltRaiseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoCrsRsltRaiseProvider.Save(transactionManager, entity.CoCrsRsltRaiseCollection);
						
						deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoCrsRsltRaise >) DataRepository.CoCrsRsltRaiseProvider.DeepSave,
							new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntMajorPhaseCrsExp>
				if (CanDeepSave(entity.EntMajorPhaseCrsExpCollection, "List<EntMajorPhaseCrsExp>|EntMajorPhaseCrsExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMajorPhaseCrsExp child in entity.EntMajorPhaseCrsExpCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EntMajorPhaseCrsExpCollection.Count > 0 || entity.EntMajorPhaseCrsExpCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntMajorPhaseCrsExpProvider.Save(transactionManager, entity.EntMajorPhaseCrsExpCollection);
						
						deepHandles.Add("EntMajorPhaseCrsExpCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMajorPhaseCrsExp >) DataRepository.EntMajorPhaseCrsExpProvider.DeepSave,
							new object[] { transactionManager, entity.EntMajorPhaseCrsExpCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOutcome>
				if (CanDeepSave(entity.EdOutcomeCollection, "List<EdOutcome>|EdOutcomeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOutcome child in entity.EdOutcomeCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdOutcomeCollection.Count > 0 || entity.EdOutcomeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOutcomeProvider.Save(transactionManager, entity.EdOutcomeCollection);
						
						deepHandles.Add("EdOutcomeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOutcome >) DataRepository.EdOutcomeProvider.DeepSave,
							new object[] { transactionManager, entity.EdOutcomeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdExamCrsOrder>
				if (CanDeepSave(entity.EdExamCrsOrderCollection, "List<EdExamCrsOrder>|EdExamCrsOrderCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamCrsOrder child in entity.EdExamCrsOrderCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdExamCrsOrderCollection.Count > 0 || entity.EdExamCrsOrderCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamCrsOrderProvider.Save(transactionManager, entity.EdExamCrsOrderCollection);
						
						deepHandles.Add("EdExamCrsOrderCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamCrsOrder >) DataRepository.EdExamCrsOrderProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamCrsOrderCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdBranchCrs>
				if (CanDeepSave(entity.EdBranchCrsCollection, "List<EdBranchCrs>|EdBranchCrsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBranchCrs child in entity.EdBranchCrsCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdBranchCrsCollection.Count > 0 || entity.EdBranchCrsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBranchCrsProvider.Save(transactionManager, entity.EdBranchCrsCollection);
						
						deepHandles.Add("EdBranchCrsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBranchCrs >) DataRepository.EdBranchCrsProvider.DeepSave,
							new object[] { transactionManager, entity.EdBranchCrsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSectionGroupHdr>
				if (CanDeepSave(entity.ScSectionGroupHdrCollection, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupHdr child in entity.ScSectionGroupHdrCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.ScSectionGroupHdrCollection.Count > 0 || entity.ScSectionGroupHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSectionGroupHdrProvider.Save(transactionManager, entity.ScSectionGroupHdrCollection);
						
						deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSectionGroupHdr >) DataRepository.ScSectionGroupHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdProjStud>
				if (CanDeepSave(entity.EdProjStudCollection, "List<EdProjStud>|EdProjStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdProjStud child in entity.EdProjStudCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdProjStudCollection.Count > 0 || entity.EdProjStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdProjStudProvider.Save(transactionManager, entity.EdProjStudCollection);
						
						deepHandles.Add("EdProjStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdProjStud >) DataRepository.EdProjStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdProjStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvCourseEval>
				if (CanDeepSave(entity.SvCourseEvalCollection, "List<SvCourseEval>|SvCourseEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEval child in entity.SvCourseEvalCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.SvCourseEvalCollection.Count > 0 || entity.SvCourseEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCourseEvalProvider.Save(transactionManager, entity.SvCourseEvalCollection);
						
						deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCourseEval >) DataRepository.SvCourseEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvCourseEvalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRplc>
				if (CanDeepSave(entity.EdStudCourseRplcCollectionGetByEdCourseOldId, "List<EdStudCourseRplc>|EdStudCourseRplcCollectionGetByEdCourseOldId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRplc child in entity.EdStudCourseRplcCollectionGetByEdCourseOldId)
					{
						if(child.EdCourseOldIdSource != null)
						{
							child.EdCourseOldId = child.EdCourseOldIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseOldId = entity.EdCourseId;
						}

					}

					if (entity.EdStudCourseRplcCollectionGetByEdCourseOldId.Count > 0 || entity.EdStudCourseRplcCollectionGetByEdCourseOldId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRplcProvider.Save(transactionManager, entity.EdStudCourseRplcCollectionGetByEdCourseOldId);
						
						deepHandles.Add("EdStudCourseRplcCollectionGetByEdCourseOldId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRplc >) DataRepository.EdStudCourseRplcProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRplcCollectionGetByEdCourseOldId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollectionGetByEdCourseId, "List<EdStudCourseReg>|EdStudCourseRegCollectionGetByEdCourseId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollectionGetByEdCourseId)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudCourseRegCollectionGetByEdCourseId.Count > 0 || entity.EdStudCourseRegCollectionGetByEdCourseId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollectionGetByEdCourseId);
						
						deepHandles.Add("EdStudCourseRegCollectionGetByEdCourseId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollectionGetByEdCourseId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScHallRsrv>
				if (CanDeepSave(entity.ScHallRsrvCollection, "List<ScHallRsrv>|ScHallRsrvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScHallRsrv child in entity.ScHallRsrvCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.ScHallRsrvCollection.Count > 0 || entity.ScHallRsrvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScHallRsrvProvider.Save(transactionManager, entity.ScHallRsrvCollection);
						
						deepHandles.Add("ScHallRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScHallRsrv >) DataRepository.ScHallRsrvProvider.DeepSave,
							new object[] { transactionManager, entity.ScHallRsrvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseRltd>
				if (CanDeepSave(entity.EdCourseRltdCollectionGetByEdCourse2Id, "List<EdCourseRltd>|EdCourseRltdCollectionGetByEdCourse2Id", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseRltd child in entity.EdCourseRltdCollectionGetByEdCourse2Id)
					{
						if(child.EdCourse2IdSource != null)
						{
							child.EdCourse2Id = child.EdCourse2IdSource.EdCourseId;
						}
						else
						{
							child.EdCourse2Id = entity.EdCourseId;
						}

					}

					if (entity.EdCourseRltdCollectionGetByEdCourse2Id.Count > 0 || entity.EdCourseRltdCollectionGetByEdCourse2Id.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseRltdProvider.Save(transactionManager, entity.EdCourseRltdCollectionGetByEdCourse2Id);
						
						deepHandles.Add("EdCourseRltdCollectionGetByEdCourse2Id",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseRltd >) DataRepository.EdCourseRltdProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseRltdCollectionGetByEdCourse2Id, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsence>
				if (CanDeepSave(entity.EdStudAbsenceCollection, "List<EdStudAbsence>|EdStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsence child in entity.EdStudAbsenceCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudAbsenceCollection.Count > 0 || entity.EdStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsenceProvider.Save(transactionManager, entity.EdStudAbsenceCollection);
						
						deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsence >) DataRepository.EdStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsFw>
				if (CanDeepSave(entity.EdStudAbsFwCollection, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsFw child in entity.EdStudAbsFwCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudAbsFwCollection.Count > 0 || entity.EdStudAbsFwCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsFwProvider.Save(transactionManager, entity.EdStudAbsFwCollection);
						
						deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsFw >) DataRepository.EdStudAbsFwProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsFwCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCoursePkgDtl>
				if (CanDeepSave(entity.EntCoursePkgDtlCollection, "List<EntCoursePkgDtl>|EntCoursePkgDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgDtl child in entity.EntCoursePkgDtlCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EntCoursePkgDtlCollection.Count > 0 || entity.EntCoursePkgDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgDtlProvider.Save(transactionManager, entity.EntCoursePkgDtlCollection);
						
						deepHandles.Add("EntCoursePkgDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgDtl >) DataRepository.EntCoursePkgDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRplc>
				if (CanDeepSave(entity.EdStudCourseRplcCollectionGetByEdCourseNewId, "List<EdStudCourseRplc>|EdStudCourseRplcCollectionGetByEdCourseNewId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRplc child in entity.EdStudCourseRplcCollectionGetByEdCourseNewId)
					{
						if(child.EdCourseNewIdSource != null)
						{
							child.EdCourseNewId = child.EdCourseNewIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseNewId = entity.EdCourseId;
						}

					}

					if (entity.EdStudCourseRplcCollectionGetByEdCourseNewId.Count > 0 || entity.EdStudCourseRplcCollectionGetByEdCourseNewId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRplcProvider.Save(transactionManager, entity.EdStudCourseRplcCollectionGetByEdCourseNewId);
						
						deepHandles.Add("EdStudCourseRplcCollectionGetByEdCourseNewId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRplc >) DataRepository.EdStudCourseRplcProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRplcCollectionGetByEdCourseNewId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseEquiv>
				if (CanDeepSave(entity.EdCourseEquivCollectionGetByEdCourseId, "List<EdCourseEquiv>|EdCourseEquivCollectionGetByEdCourseId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseEquiv child in entity.EdCourseEquivCollectionGetByEdCourseId)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseEquivCollectionGetByEdCourseId.Count > 0 || entity.EdCourseEquivCollectionGetByEdCourseId.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseEquivProvider.Save(transactionManager, entity.EdCourseEquivCollectionGetByEdCourseId);
						
						deepHandles.Add("EdCourseEquivCollectionGetByEdCourseId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseEquiv >) DataRepository.EdCourseEquivProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseEquivCollectionGetByEdCourseId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSchdlSlot>
				if (CanDeepSave(entity.ScSchdlSlotCollection, "List<ScSchdlSlot>|ScSchdlSlotCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlSlot child in entity.ScSchdlSlotCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.ScSchdlSlotCollection.Count > 0 || entity.ScSchdlSlotCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlSlotProvider.Save(transactionManager, entity.ScSchdlSlotCollection);
						
						deepHandles.Add("ScSchdlSlotCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlSlot >) DataRepository.ScSchdlSlotProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlSlotCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExcuseCourse>
				if (CanDeepSave(entity.EdStudExcuseCourseCollection, "List<EdStudExcuseCourse>|EdStudExcuseCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExcuseCourse child in entity.EdStudExcuseCourseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudExcuseCourseCollection.Count > 0 || entity.EdStudExcuseCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExcuseCourseProvider.Save(transactionManager, entity.EdStudExcuseCourseCollection);
						
						deepHandles.Add("EdStudExcuseCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExcuseCourse >) DataRepository.EdStudExcuseCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExcuseCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvPollHdr>
				if (CanDeepSave(entity.SvPollHdrCollection, "List<SvPollHdr>|SvPollHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvPollHdr child in entity.SvPollHdrCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.SvPollHdrCollection.Count > 0 || entity.SvPollHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvPollHdrProvider.Save(transactionManager, entity.SvPollHdrCollection);
						
						deepHandles.Add("SvPollHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvPollHdr >) DataRepository.SvPollHdrProvider.DeepSave,
							new object[] { transactionManager, entity.SvPollHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppPlaceExamCourse>
				if (CanDeepSave(entity.AdmAppPlaceExamCourseCollection, "List<AdmAppPlaceExamCourse>|AdmAppPlaceExamCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPlaceExamCourse child in entity.AdmAppPlaceExamCourseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.AdmAppPlaceExamCourseCollection.Count > 0 || entity.AdmAppPlaceExamCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppPlaceExamCourseProvider.Save(transactionManager, entity.AdmAppPlaceExamCourseCollection);
						
						deepHandles.Add("AdmAppPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppPlaceExamCourse >) DataRepository.AdmAppPlaceExamCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppPlaceExamCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserCrsAssess>
				if (CanDeepSave(entity.SeUserCrsAssessCollection, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserCrsAssess child in entity.SeUserCrsAssessCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.SeUserCrsAssessCollection.Count > 0 || entity.SeUserCrsAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserCrsAssessProvider.Save(transactionManager, entity.SeUserCrsAssessCollection);
						
						deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserCrsAssess >) DataRepository.SeUserCrsAssessProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCrsAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseTo>
				if (CanDeepSave(entity.EdStudIntTrnsCourseToCollection, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseTo child in entity.EdStudIntTrnsCourseToCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStudIntTrnsCourseToCollection.Count > 0 || entity.EdStudIntTrnsCourseToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseToProvider.Save(transactionManager, entity.EdStudIntTrnsCourseToCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseTo >) DataRepository.EdStudIntTrnsCourseToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseExpDtl>
				if (CanDeepSave(entity.EdCourseExpDtlCollection, "List<EdCourseExpDtl>|EdCourseExpDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseExpDtl child in entity.EdCourseExpDtlCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseExpDtlCollection.Count > 0 || entity.EdCourseExpDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseExpDtlProvider.Save(transactionManager, entity.EdCourseExpDtlCollection);
						
						deepHandles.Add("EdCourseExpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseExpDtl >) DataRepository.EdCourseExpDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseExpDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSectionGroupDtl>
				if (CanDeepSave(entity.ScSectionGroupDtlCollection, "List<ScSectionGroupDtl>|ScSectionGroupDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupDtl child in entity.ScSectionGroupDtlCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.ScSectionGroupDtlCollection.Count > 0 || entity.ScSectionGroupDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSectionGroupDtlProvider.Save(transactionManager, entity.ScSectionGroupDtlCollection);
						
						deepHandles.Add("ScSectionGroupDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSectionGroupDtl >) DataRepository.ScSectionGroupDtlProvider.DeepSave,
							new object[] { transactionManager, entity.ScSectionGroupDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoStudSecretNum>
				if (CanDeepSave(entity.CoStudSecretNumCollection, "List<CoStudSecretNum>|CoStudSecretNumCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoStudSecretNum child in entity.CoStudSecretNumCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.CoStudSecretNumCollection.Count > 0 || entity.CoStudSecretNumCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoStudSecretNumProvider.Save(transactionManager, entity.CoStudSecretNumCollection);
						
						deepHandles.Add("CoStudSecretNumCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoStudSecretNum >) DataRepository.CoStudSecretNumProvider.DeepSave,
							new object[] { transactionManager, entity.CoStudSecretNumCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadPlanDtl>
				if (CanDeepSave(entity.EdAcadPlanDtlCollection, "List<EdAcadPlanDtl>|EdAcadPlanDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlanDtl child in entity.EdAcadPlanDtlCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdAcadPlanDtlCollection.Count > 0 || entity.EdAcadPlanDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanDtlProvider.Save(transactionManager, entity.EdAcadPlanDtlCollection);
						
						deepHandles.Add("EdAcadPlanDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlanDtl >) DataRepository.EdAcadPlanDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppTransToCourse>
				if (CanDeepSave(entity.AdmAppTransToCourseCollection, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransToCourse child in entity.AdmAppTransToCourseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.AdmAppTransToCourseCollection.Count > 0 || entity.AdmAppTransToCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransToCourseProvider.Save(transactionManager, entity.AdmAppTransToCourseCollection);
						
						deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransToCourse >) DataRepository.AdmAppTransToCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseCoreq>
				if (CanDeepSave(entity.EdCourseCoreqCollection, "List<EdCourseCoreq>|EdCourseCoreqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseCoreq child in entity.EdCourseCoreqCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdCourseCoreqCollection.Count > 0 || entity.EdCourseCoreqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseCoreqProvider.Save(transactionManager, entity.EdCourseCoreqCollection);
						
						deepHandles.Add("EdCourseCoreqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseCoreq >) DataRepository.EdCourseCoreqProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseCoreqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppExmptCourse>
				if (CanDeepSave(entity.AdmAppExmptCourseCollection, "List<AdmAppExmptCourse>|AdmAppExmptCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppExmptCourse child in entity.AdmAppExmptCourseCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.AdmAppExmptCourseCollection.Count > 0 || entity.AdmAppExmptCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppExmptCourseProvider.Save(transactionManager, entity.AdmAppExmptCourseCollection);
						
						deepHandles.Add("AdmAppExmptCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppExmptCourse >) DataRepository.AdmAppExmptCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppExmptCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeCourseExp>
				if (CanDeepSave(entity.FeeCourseExpCollection, "List<FeeCourseExp>|FeeCourseExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCourseExp child in entity.FeeCourseExpCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.FeeCourseExpCollection.Count > 0 || entity.FeeCourseExpCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCourseExpProvider.Save(transactionManager, entity.FeeCourseExpCollection);
						
						deepHandles.Add("FeeCourseExpCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCourseExp >) DataRepository.FeeCourseExpProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCourseExpCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeBlockTrans>
				if (CanDeepSave(entity.SeBlockTransCollection, "List<SeBlockTrans>|SeBlockTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeBlockTrans child in entity.SeBlockTransCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.SeBlockTransCollection.Count > 0 || entity.SeBlockTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeBlockTransProvider.Save(transactionManager, entity.SeBlockTransCollection);
						
						deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeBlockTrans >) DataRepository.SeBlockTransProvider.DeepSave,
							new object[] { transactionManager, entity.SeBlockTransCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupInfo>
				if (CanDeepSave(entity.ScGroupInfoCollection, "List<ScGroupInfo>|ScGroupInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupInfo child in entity.ScGroupInfoCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.ScGroupInfoCollection.Count > 0 || entity.ScGroupInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoCollection);
						
						deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupInfo >) DataRepository.ScGroupInfoProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvLecNote>
				if (CanDeepSave(entity.SvLecNoteCollection, "List<SvLecNote>|SvLecNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvLecNote child in entity.SvLecNoteCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.SvLecNoteCollection.Count > 0 || entity.SvLecNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvLecNoteProvider.Save(transactionManager, entity.SvLecNoteCollection);
						
						deepHandles.Add("SvLecNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvLecNote >) DataRepository.SvLecNoteProvider.DeepSave,
							new object[] { transactionManager, entity.SvLecNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyGradingLevelCourses>
				if (CanDeepSave(entity.EntPolicyGradingLevelCoursesCollection, "List<EntPolicyGradingLevelCourses>|EntPolicyGradingLevelCoursesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingLevelCourses child in entity.EntPolicyGradingLevelCoursesCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EntPolicyGradingLevelCoursesCollection.Count > 0 || entity.EntPolicyGradingLevelCoursesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingLevelCoursesProvider.Save(transactionManager, entity.EntPolicyGradingLevelCoursesCollection);
						
						deepHandles.Add("EntPolicyGradingLevelCoursesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingLevelCourses >) DataRepository.EntPolicyGradingLevelCoursesProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingLevelCoursesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStaffCoursePref>
				if (CanDeepSave(entity.EdStaffCoursePrefCollection, "List<EdStaffCoursePref>|EdStaffCoursePrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStaffCoursePref child in entity.EdStaffCoursePrefCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EdStaffCoursePrefCollection.Count > 0 || entity.EdStaffCoursePrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStaffCoursePrefProvider.Save(transactionManager, entity.EdStaffCoursePrefCollection);
						
						deepHandles.Add("EdStaffCoursePrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStaffCoursePref >) DataRepository.EdStaffCoursePrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStaffCoursePrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupDay>
				if (CanDeepSave(entity.ScGroupDayCollection, "List<ScGroupDay>|ScGroupDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupDay child in entity.ScGroupDayCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.ScGroupDayCollection.Count > 0 || entity.ScGroupDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupDayProvider.Save(transactionManager, entity.ScGroupDayCollection);
						
						deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupDay >) DataRepository.ScGroupDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCourseMdData>
				if (CanDeepSave(entity.EntCourseMdDataCollection, "List<EntCourseMdData>|EntCourseMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCourseMdData child in entity.EntCourseMdDataCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.EntCourseMdDataCollection.Count > 0 || entity.EntCourseMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCourseMdDataProvider.Save(transactionManager, entity.EntCourseMdDataCollection);
						
						deepHandles.Add("EntCourseMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCourseMdData >) DataRepository.EntCourseMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCourseMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCodeEngTest>
				if (CanDeepSave(entity.AdmCodeEngTestCollection, "List<AdmCodeEngTest>|AdmCodeEngTestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCodeEngTest child in entity.AdmCodeEngTestCollection)
					{
						if(child.EdCourseIdSource != null)
						{
							child.EdCourseId = child.EdCourseIdSource.EdCourseId;
						}
						else
						{
							child.EdCourseId = entity.EdCourseId;
						}

					}

					if (entity.AdmCodeEngTestCollection.Count > 0 || entity.AdmCodeEngTestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCodeEngTestProvider.Save(transactionManager, entity.AdmCodeEngTestCollection);
						
						deepHandles.Add("AdmCodeEngTestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCodeEngTest >) DataRepository.AdmCodeEngTestProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCodeEngTestCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCourseChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourse</c>
	///</summary>
	public enum EdCourseChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeLanguage</c> at GsCodeLanguageIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeLanguage))]
		GsCodeLanguage,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourse</c> at EdCodeCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourse))]
		EdCodeCourse,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseType</c> at EdCodeCourseTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseType))]
		EdCodeCourseType,
		
		///<summary>
		/// Composite Property for <c>EdCourseExpHdr</c> at EdCourseExpHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourseExpHdr))]
		EdCourseExpHdr,
		
		///<summary>
		/// Composite Property for <c>EdCoursePrfx</c> at EdCoursePrfxIdSource
		///</summary>
		[ChildEntityType(typeof(EdCoursePrfx))]
		EdCoursePrfx,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudExmptCrsFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExmptCrsFrom>))]
		EdStudExmptCrsFromCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for WfCrsRsltApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<WfCrsRsltApprove>))]
		WfCrsRsltApproveCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollectionGetByEdCourseOrgId,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudCourseRegPreCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegPre>))]
		EdStudCourseRegPreCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseTchngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseTchng>))]
		EdCourseTchngCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdOfferingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOfferingCourse>))]
		EdOfferingCourseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseOrientCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOrient>))]
		EdCourseOrientCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdTrainStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTrainStud>))]
		EdTrainStudCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseOutcomesTopicsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOutcomesTopics>))]
		EdCourseOutcomesTopicsCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudCourseWaitCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseWait>))]
		EdStudCourseWaitCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdExamSchdlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamSchdl>))]
		EdExamSchdlCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseTopicCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseTopic>))]
		EdCourseTopicCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EntPolicyAssessCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAssessCourse>))]
		EntPolicyAssessCourseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EntPolicyGradingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingCourse>))]
		EntPolicyGradingCourseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseBarredCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseBarred>))]
		EdCourseBarredCollectionGetByEdBarredCourseId,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseBarredCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseBarred>))]
		EdCourseBarredCollectionGetByEdCourseId,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for PgThesisGrantStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGrantStud>))]
		PgThesisGrantStudCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudLatenessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLateness>))]
		EdStudLatenessCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EntPolcyGrdngCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngCourse>))]
		EntPolcyGrdngCourseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for CoContRmMemCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoContRmMemCourse>))]
		CoContRmMemCourseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for SvStudCourseEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudCourseEval>))]
		SvStudCourseEvalCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseEquivCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseEquiv>))]
		EdCourseEquivCollectionGetByEdEquivCourseId,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseRltdCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseRltd>))]
		EdCourseRltdCollectionGetByEdCourse1Id,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for FeeStudVoucherCrsItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherCrsItem>))]
		FeeStudVoucherCrsItemCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for SvStudCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudComp>))]
		SvStudCompCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseInfo>))]
		EdCourseInfoCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCrsFreeRstrctdCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCrsFreeRstrctd>))]
		EdCrsFreeRstrctdCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for AdmPlaceExamCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamCourse>))]
		AdmPlaceExamCourseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for CoCourseResultCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoCourseResult>))]
		CoCourseResultCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for FeeStudCoursesItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudCoursesItem>))]
		FeeStudCoursesItemCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudCourseRegTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegTemp>))]
		EdStudCourseRegTempCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseChng>))]
		EdStudCourseChngCollectionGetByEdCourseId,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseChng>))]
		EdStudCourseChngCollectionGetByEdCourseSubId,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudExmptCrsToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExmptCrsTo>))]
		EdStudExmptCrsToCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for CoCrsRsltRaiseCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoCrsRsltRaise>))]
		CoCrsRsltRaiseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EntMajorPhaseCrsExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMajorPhaseCrsExp>))]
		EntMajorPhaseCrsExpCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdOutcomeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOutcome>))]
		EdOutcomeCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdExamCrsOrderCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamCrsOrder>))]
		EdExamCrsOrderCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdBranchCrsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBranchCrs>))]
		EdBranchCrsCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for ScSectionGroupHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupHdr>))]
		ScSectionGroupHdrCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdProjStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdProjStud>))]
		EdProjStudCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for SvCourseEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEval>))]
		SvCourseEvalCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudCourseRplcCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRplc>))]
		EdStudCourseRplcCollectionGetByEdCourseOldId,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollectionGetByEdCourseId,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for ScHallRsrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScHallRsrv>))]
		ScHallRsrvCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseRltdCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseRltd>))]
		EdCourseRltdCollectionGetByEdCourse2Id,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsence>))]
		EdStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudAbsFwCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsFw>))]
		EdStudAbsFwCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EntCoursePkgDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgDtl>))]
		EntCoursePkgDtlCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudCourseRplcCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRplc>))]
		EdStudCourseRplcCollectionGetByEdCourseNewId,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseEquivCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseEquiv>))]
		EdCourseEquivCollectionGetByEdCourseId,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for ScSchdlSlotCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlot>))]
		ScSchdlSlotCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudExcuseCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExcuseCourse>))]
		EdStudExcuseCourseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for SvPollHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvPollHdr>))]
		SvPollHdrCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for AdmAppPlaceExamCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPlaceExamCourse>))]
		AdmAppPlaceExamCourseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for SeUserCrsAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserCrsAssess>))]
		SeUserCrsAssessCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseExpDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseExpDtl>))]
		EdCourseExpDtlCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for ScSectionGroupDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupDtl>))]
		ScSectionGroupDtlCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for CoStudSecretNumCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoStudSecretNum>))]
		CoStudSecretNumCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdAcadPlanDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlanDtl>))]
		EdAcadPlanDtlCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for AdmAppTransToCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransToCourse>))]
		AdmAppTransToCourseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdCourseCoreqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseCoreq>))]
		EdCourseCoreqCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for AdmAppExmptCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppExmptCourse>))]
		AdmAppExmptCourseCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for FeeCourseExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCourseExp>))]
		FeeCourseExpCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for SeBlockTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeBlockTrans>))]
		SeBlockTransCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for ScGroupInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupInfo>))]
		ScGroupInfoCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for SvLecNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvLecNote>))]
		SvLecNoteCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EntPolicyGradingLevelCoursesCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingLevelCourses>))]
		EntPolicyGradingLevelCoursesCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EdStaffCoursePrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStaffCoursePref>))]
		EdStaffCoursePrefCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for ScGroupDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupDay>))]
		ScGroupDayCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for EntCourseMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCourseMdData>))]
		EntCourseMdDataCollection,
		///<summary>
		/// Collection of <c>EdCourse</c> as OneToMany for AdmCodeEngTestCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCodeEngTest>))]
		AdmCodeEngTestCollection,
	}
	
	#endregion EdCourseChildEntityTypes
	
	#region EdCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseFilterBuilder : SqlFilterBuilder<EdCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseFilterBuilder class.
		/// </summary>
		public EdCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseFilterBuilder
	
	#region EdCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseParameterBuilder class.
		/// </summary>
		public EdCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseParameterBuilder
	
	#region EdCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseSortBuilder : SqlSortBuilder<EdCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseSqlSortBuilder class.
		/// </summary>
		public EdCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseSortBuilder
	
} // end namespace
