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
	/// This class is the base class for any <see cref="FeeStudCoursesItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudCoursesItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudCoursesItem, UMIS_VER2.BusinessLyer.FeeStudCoursesItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudCoursesItemKey key)
		{
			return Delete(transactionManager, key.FeeStudCoursesItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudCoursesItemId">لازم نستخدم الجدول ده. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudCoursesItemId)
		{
			return Delete(null, _feeStudCoursesItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudCoursesItemId">لازم نستخدم الجدول ده. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudCoursesItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">KU</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">KU</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudCoursesItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_ACAD_YEAR key.
		///		fkFeeStudCoursesItemEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">KU</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_ACAD_YEAR key.
		///		fkFeeStudCoursesItemEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">KU</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public abstract TList<FeeStudCoursesItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudCoursesItem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_CODE_SEMESTER key.
		///		fkFeeStudCoursesItemEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_CODE_SEMESTER key.
		///		fkFeeStudCoursesItemEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public abstract TList<FeeStudCoursesItem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_COURSE key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_COURSE key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudCoursesItem> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_COURSE key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_COURSE key.
		///		fkFeeStudCoursesItemEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_COURSE key.
		///		fkFeeStudCoursesItemEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_COURSE key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public abstract TList<FeeStudCoursesItem> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_STUD key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_STUD key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudCoursesItem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_STUD key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_STUD key.
		///		fkFeeStudCoursesItemEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_STUD key.
		///		fkFeeStudCoursesItemEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_ED_STUD key.
		///		FK_FEE_STUD_COURSES_ITEM_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public abstract TList<FeeStudCoursesItem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_COURSES_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId">بند مصروف بالمقرر- اومصروف بالساعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_COURSES_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف بالمقرر- اومصروف بالساعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudCoursesItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_COURSES_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف بالمقرر- اومصروف بالساعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_CODE_ITEM key.
		///		fkFeeStudCoursesItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">بند مصروف بالمقرر- اومصروف بالساعة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_CODE_ITEM key.
		///		fkFeeStudCoursesItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">بند مصروف بالمقرر- اومصروف بالساعة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_COURSES_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف بالمقرر- اومصروف بالساعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public abstract TList<FeeStudCoursesItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_COURSES_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudFeeItemId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(_feeStudFeeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_COURSES_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudCoursesItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_COURSES_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkFeeStudCoursesItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkFeeStudCoursesItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public TList<FeeStudCoursesItem> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_COURSES_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_COURSES_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudCoursesItem objects.</returns>
		public abstract TList<FeeStudCoursesItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudCoursesItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudCoursesItemKey key, int start, int pageLength)
		{
			return GetByFeeStudCoursesItemId(transactionManager, key.FeeStudCoursesItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="_feeStudCoursesItemId">لازم نستخدم الجدول ده</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByFeeStudCoursesItemId(System.Decimal _feeStudCoursesItemId)
		{
			int count = -1;
			return GetByFeeStudCoursesItemId(null,_feeStudCoursesItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="_feeStudCoursesItemId">لازم نستخدم الجدول ده</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByFeeStudCoursesItemId(System.Decimal _feeStudCoursesItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudCoursesItemId(null, _feeStudCoursesItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudCoursesItemId">لازم نستخدم الجدول ده</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByFeeStudCoursesItemId(TransactionManager transactionManager, System.Decimal _feeStudCoursesItemId)
		{
			int count = -1;
			return GetByFeeStudCoursesItemId(transactionManager, _feeStudCoursesItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudCoursesItemId">لازم نستخدم الجدول ده</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByFeeStudCoursesItemId(TransactionManager transactionManager, System.Decimal _feeStudCoursesItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudCoursesItemId(transactionManager, _feeStudCoursesItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="_feeStudCoursesItemId">لازم نستخدم الجدول ده</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByFeeStudCoursesItemId(System.Decimal _feeStudCoursesItemId, int start, int pageLength, out int count)
		{
			return GetByFeeStudCoursesItemId(null, _feeStudCoursesItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudCoursesItemId">لازم نستخدم الجدول ده</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByFeeStudCoursesItemId(TransactionManager transactionManager, System.Decimal _feeStudCoursesItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId">KU</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(null,_edStudId, _edAcadYearId, _edCodeSemesterId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId">KU</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId">KU</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId">KU</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(transactionManager, _edStudId, _edAcadYearId, _edCodeSemesterId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId">KU</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(null, _edStudId, _edAcadYearId, _edCodeSemesterId, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_COURSES_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_edAcadYearId">KU</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_edCourseId">Modify :Register-add-delete-drop</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudCoursesItem GetByEdStudIdEdAcadYearIdEdCodeSemesterIdEdCourseId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudCoursesItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudCoursesItem&gt;"/></returns>
		public static TList<FeeStudCoursesItem> Fill(IDataReader reader, TList<FeeStudCoursesItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudCoursesItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudCoursesItem")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_COURSES_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudCoursesItem>(
					key.ToString(), // EntityTrackingKey
					"FeeStudCoursesItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudCoursesItem();
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
					c.FeeStudCoursesItemId = (System.Decimal)reader["FEE_STUD_COURSES_ITEM_ID"];
					c.OriginalFeeStudCoursesItemId = c.FeeStudCoursesItemId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.CrsFeeAmnt = (System.Decimal)reader["CRS_FEE_AMNT"];
					c.FeeCodeItemId = Convert.IsDBNull(reader["FEE_CODE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_ITEM_ID"];
					c.FeeStudFeeItemId = Convert.IsDBNull(reader["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_FEE_ITEM_ID"];
					c.SpoCrsFeeAmnt = (System.Decimal)reader["SPO_CRS_FEE_AMNT"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudCoursesItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudCoursesItemId = (System.Decimal)reader[((int)FeeStudCoursesItemColumn.FeeStudCoursesItemId - 1)];
			entity.OriginalFeeStudCoursesItemId = (System.Decimal)reader["FEE_STUD_COURSES_ITEM_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeStudCoursesItemColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)FeeStudCoursesItemColumn.EdCodeSemesterId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)FeeStudCoursesItemColumn.EdStudId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)FeeStudCoursesItemColumn.EdCourseId - 1)];
			entity.CrsFeeAmnt = (System.Decimal)reader[((int)FeeStudCoursesItemColumn.CrsFeeAmnt - 1)];
			entity.FeeCodeItemId = (reader.IsDBNull(((int)FeeStudCoursesItemColumn.FeeCodeItemId - 1)))?null:(System.Decimal?)reader[((int)FeeStudCoursesItemColumn.FeeCodeItemId - 1)];
			entity.FeeStudFeeItemId = (reader.IsDBNull(((int)FeeStudCoursesItemColumn.FeeStudFeeItemId - 1)))?null:(System.Decimal?)reader[((int)FeeStudCoursesItemColumn.FeeStudFeeItemId - 1)];
			entity.SpoCrsFeeAmnt = (System.Decimal)reader[((int)FeeStudCoursesItemColumn.SpoCrsFeeAmnt - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeStudCoursesItemColumn.Notes - 1)))?null:(System.String)reader[((int)FeeStudCoursesItemColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudCoursesItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudCoursesItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudCoursesItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudCoursesItemColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudCoursesItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudCoursesItemId = (System.Decimal)dataRow["FEE_STUD_COURSES_ITEM_ID"];
			entity.OriginalFeeStudCoursesItemId = (System.Decimal)dataRow["FEE_STUD_COURSES_ITEM_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.CrsFeeAmnt = (System.Decimal)dataRow["CRS_FEE_AMNT"];
			entity.FeeCodeItemId = Convert.IsDBNull(dataRow["FEE_CODE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_ITEM_ID"];
			entity.FeeStudFeeItemId = Convert.IsDBNull(dataRow["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.SpoCrsFeeAmnt = (System.Decimal)dataRow["SPO_CRS_FEE_AMNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudCoursesItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudCoursesItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudCoursesItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterIdSource

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

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
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

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeItemId ?? 0.0m);
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, (entity.FeeCodeItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudCoursesItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudCoursesItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudCoursesItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudCoursesItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
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
	
	#region FeeStudCoursesItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudCoursesItem</c>
	///</summary>
	public enum FeeStudCoursesItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>FeeStudFeeItem</c> at FeeStudFeeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudFeeItem))]
		FeeStudFeeItem,
	}
	
	#endregion FeeStudCoursesItemChildEntityTypes
	
	#region FeeStudCoursesItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudCoursesItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudCoursesItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudCoursesItemFilterBuilder : SqlFilterBuilder<FeeStudCoursesItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudCoursesItemFilterBuilder class.
		/// </summary>
		public FeeStudCoursesItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudCoursesItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudCoursesItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudCoursesItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudCoursesItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudCoursesItemFilterBuilder
	
	#region FeeStudCoursesItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudCoursesItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudCoursesItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudCoursesItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudCoursesItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudCoursesItemParameterBuilder class.
		/// </summary>
		public FeeStudCoursesItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudCoursesItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudCoursesItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudCoursesItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudCoursesItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudCoursesItemParameterBuilder
	
	#region FeeStudCoursesItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudCoursesItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudCoursesItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudCoursesItemSortBuilder : SqlSortBuilder<FeeStudCoursesItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudCoursesItemSqlSortBuilder class.
		/// </summary>
		public FeeStudCoursesItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudCoursesItemSortBuilder
	
} // end namespace
