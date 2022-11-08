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
	/// This class is the base class for any <see cref="ScHallRstrctonProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScHallRstrctonProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScHallRstrcton, UMIS_VER2.BusinessLyer.ScHallRstrctonKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHallRstrctonKey key)
		{
			return Delete(transactionManager, key.ScHallRstrctonId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scHallRstrctonId">تخصيص قاعة (لمقرر -طريقة تدريس معينة)- قسم معين. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scHallRstrctonId)
		{
			return Delete(null, _scHallRstrctonId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallRstrctonId">تخصيص قاعة (لمقرر -طريقة تدريس معينة)- قسم معين. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scHallRstrctonId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_COURSE_HALL_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="_edCodeCourseTeachingId">مسلسل طريقة التدريس داخل النظام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(_edCodeCourseTeachingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_COURSE_HALL_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">مسلسل طريقة التدريس داخل النظام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		/// <remarks></remarks>
		public TList<ScHallRstrcton> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_COURSE_HALL_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">مسلسل طريقة التدريس داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_CODE_COURSE_TEACHING key.
		///		fkScCourseHallEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId">مسلسل طريقة التدريس داخل النظام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_CODE_COURSE_TEACHING key.
		///		fkScCourseHallEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId">مسلسل طريقة التدريس داخل النظام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_COURSE_HALL_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">مسلسل طريقة التدريس داخل النظام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public abstract TList<ScHallRstrcton> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_COURSE key.
		///		FK_SC_COURSE_HALL_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">مسلسل المادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_COURSE key.
		///		FK_SC_COURSE_HALL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مسلسل المادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		/// <remarks></remarks>
		public TList<ScHallRstrcton> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_COURSE key.
		///		FK_SC_COURSE_HALL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مسلسل المادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_COURSE key.
		///		fkScCourseHallEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">مسلسل المادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_COURSE key.
		///		fkScCourseHallEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">مسلسل المادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ED_COURSE key.
		///		FK_SC_COURSE_HALL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">مسلسل المادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public abstract TList<ScHallRstrcton> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ENTITY_MAIN key.
		///		FK_SC_COURSE_HALL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">مسلسل القسم فى الشجرة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ENTITY_MAIN key.
		///		FK_SC_COURSE_HALL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">مسلسل القسم فى الشجرة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		/// <remarks></remarks>
		public TList<ScHallRstrcton> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ENTITY_MAIN key.
		///		FK_SC_COURSE_HALL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">مسلسل القسم فى الشجرة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ENTITY_MAIN key.
		///		fkScCourseHallEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">مسلسل القسم فى الشجرة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ENTITY_MAIN key.
		///		fkScCourseHallEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">مسلسل القسم فى الشجرة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_ENTITY_MAIN key.
		///		FK_SC_COURSE_HALL_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">مسلسل القسم فى الشجرة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public abstract TList<ScHallRstrcton> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_SC_HALL key.
		///		FK_SC_COURSE_HALL_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId">مسلسل بيانات القاعات الدراسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByScHallId(System.Decimal _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_SC_HALL key.
		///		FK_SC_COURSE_HALL_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">مسلسل بيانات القاعات الدراسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		/// <remarks></remarks>
		public TList<ScHallRstrcton> GetByScHallId(TransactionManager transactionManager, System.Decimal _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_SC_HALL key.
		///		FK_SC_COURSE_HALL_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">مسلسل بيانات القاعات الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByScHallId(TransactionManager transactionManager, System.Decimal _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_SC_HALL key.
		///		fkScCourseHallScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">مسلسل بيانات القاعات الدراسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByScHallId(System.Decimal _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_SC_HALL key.
		///		fkScCourseHallScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">مسلسل بيانات القاعات الدراسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public TList<ScHallRstrcton> GetByScHallId(System.Decimal _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_COURSE_HALL_SC_HALL key.
		///		FK_SC_COURSE_HALL_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">مسلسل بيانات القاعات الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScHallRstrcton objects.</returns>
		public abstract TList<ScHallRstrcton> GetByScHallId(TransactionManager transactionManager, System.Decimal _scHallId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScHallRstrcton Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHallRstrctonKey key, int start, int pageLength)
		{
			return GetByScHallRstrctonId(transactionManager, key.ScHallRstrctonId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_COURSE_HALL index.
		/// </summary>
		/// <param name="_scHallRstrctonId">تخصيص قاعة (لمقرر -طريقة تدريس معينة)- قسم معين</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallRstrcton GetByScHallRstrctonId(System.Decimal _scHallRstrctonId)
		{
			int count = -1;
			return GetByScHallRstrctonId(null,_scHallRstrctonId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_COURSE_HALL index.
		/// </summary>
		/// <param name="_scHallRstrctonId">تخصيص قاعة (لمقرر -طريقة تدريس معينة)- قسم معين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallRstrcton GetByScHallRstrctonId(System.Decimal _scHallRstrctonId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallRstrctonId(null, _scHallRstrctonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_COURSE_HALL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallRstrctonId">تخصيص قاعة (لمقرر -طريقة تدريس معينة)- قسم معين</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallRstrcton GetByScHallRstrctonId(TransactionManager transactionManager, System.Decimal _scHallRstrctonId)
		{
			int count = -1;
			return GetByScHallRstrctonId(transactionManager, _scHallRstrctonId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_COURSE_HALL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallRstrctonId">تخصيص قاعة (لمقرر -طريقة تدريس معينة)- قسم معين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallRstrcton GetByScHallRstrctonId(TransactionManager transactionManager, System.Decimal _scHallRstrctonId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallRstrctonId(transactionManager, _scHallRstrctonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_COURSE_HALL index.
		/// </summary>
		/// <param name="_scHallRstrctonId">تخصيص قاعة (لمقرر -طريقة تدريس معينة)- قسم معين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScHallRstrcton GetByScHallRstrctonId(System.Decimal _scHallRstrctonId, int start, int pageLength, out int count)
		{
			return GetByScHallRstrctonId(null, _scHallRstrctonId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_COURSE_HALL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallRstrctonId">تخصيص قاعة (لمقرر -طريقة تدريس معينة)- قسم معين</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScHallRstrcton GetByScHallRstrctonId(TransactionManager transactionManager, System.Decimal _scHallRstrctonId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScHallRstrcton&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScHallRstrcton&gt;"/></returns>
		public static TList<ScHallRstrcton> Fill(IDataReader reader, TList<ScHallRstrcton> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScHallRstrcton c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScHallRstrcton")
					.Append("|").Append((System.Decimal)reader["SC_HALL_RSTRCTON_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScHallRstrcton>(
					key.ToString(), // EntityTrackingKey
					"ScHallRstrcton",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScHallRstrcton();
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
					c.ScHallRstrctonId = (System.Decimal)reader["SC_HALL_RSTRCTON_ID"];
					c.OriginalScHallRstrctonId = c.ScHallRstrctonId;
					c.ScHallId = (System.Decimal)reader["SC_HALL_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.EdCodeCourseTeachingId = Convert.IsDBNull(reader["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_TEACHING_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.Xxxx = Convert.IsDBNull(reader["XXXX"]) ? null : (System.String)reader["XXXX"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScHallRstrcton entity)
		{
			if (!reader.Read()) return;
			
			entity.ScHallRstrctonId = (System.Decimal)reader[((int)ScHallRstrctonColumn.ScHallRstrctonId - 1)];
			entity.OriginalScHallRstrctonId = (System.Decimal)reader["SC_HALL_RSTRCTON_ID"];
			entity.ScHallId = (System.Decimal)reader[((int)ScHallRstrctonColumn.ScHallId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)ScHallRstrctonColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)ScHallRstrctonColumn.EdCourseId - 1)];
			entity.EdCodeCourseTeachingId = (reader.IsDBNull(((int)ScHallRstrctonColumn.EdCodeCourseTeachingId - 1)))?null:(System.Decimal?)reader[((int)ScHallRstrctonColumn.EdCodeCourseTeachingId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)ScHallRstrctonColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)ScHallRstrctonColumn.EntMainId - 1)];
			entity.Xxxx = (reader.IsDBNull(((int)ScHallRstrctonColumn.Xxxx - 1)))?null:(System.String)reader[((int)ScHallRstrctonColumn.Xxxx - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScHallRstrcton entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScHallRstrctonId = (System.Decimal)dataRow["SC_HALL_RSTRCTON_ID"];
			entity.OriginalScHallRstrctonId = (System.Decimal)dataRow["SC_HALL_RSTRCTON_ID"];
			entity.ScHallId = (System.Decimal)dataRow["SC_HALL_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.EdCodeCourseTeachingId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.Xxxx = Convert.IsDBNull(dataRow["XXXX"]) ? null : (System.String)dataRow["XXXX"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScHallRstrcton"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScHallRstrcton Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHallRstrcton entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeCourseTeachingIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseTeachingId ?? 0.0m);
				EdCodeCourseTeaching tmpEntity = EntityManager.LocateEntity<EdCodeCourseTeaching>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseTeaching), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseTeachingIdSource = tmpEntity;
				else
					entity.EdCodeCourseTeachingIdSource = DataRepository.EdCodeCourseTeachingProvider.GetByEdCodeCourseTeachingId(transactionManager, (entity.EdCodeCourseTeachingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseTeachingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseTeachingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseTeachingProvider.DeepLoad(transactionManager, entity.EdCodeCourseTeachingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseTeachingIdSource

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

			#region ScHallIdSource	
			if (CanDeepLoad(entity, "ScHall|ScHallIdSource", deepLoadType, innerList) 
				&& entity.ScHallIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScHallId;
				ScHall tmpEntity = EntityManager.LocateEntity<ScHall>(EntityLocator.ConstructKeyFromPkItems(typeof(ScHall), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScHallIdSource = tmpEntity;
				else
					entity.ScHallIdSource = DataRepository.ScHallProvider.GetByScHallId(transactionManager, entity.ScHallId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScHallIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScHallProvider.DeepLoad(transactionManager, entity.ScHallIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScHallIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScHallRstrcton object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScHallRstrcton instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScHallRstrcton Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScHallRstrcton entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeCourseTeachingIdSource
			if (CanDeepSave(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource != null)
			{
				DataRepository.EdCodeCourseTeachingProvider.Save(transactionManager, entity.EdCodeCourseTeachingIdSource);
				entity.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			
			#region ScHallIdSource
			if (CanDeepSave(entity, "ScHall|ScHallIdSource", deepSaveType, innerList) 
				&& entity.ScHallIdSource != null)
			{
				DataRepository.ScHallProvider.Save(transactionManager, entity.ScHallIdSource);
				entity.ScHallId = entity.ScHallIdSource.ScHallId;
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
	
	#region ScHallRstrctonChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScHallRstrcton</c>
	///</summary>
	public enum ScHallRstrctonChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseTeaching</c> at EdCodeCourseTeachingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseTeaching))]
		EdCodeCourseTeaching,
			
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
			
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
			
		///<summary>
		/// Composite Property for <c>ScHall</c> at ScHallIdSource
		///</summary>
		[ChildEntityType(typeof(ScHall))]
		ScHall,
		}
	
	#endregion ScHallRstrctonChildEntityTypes
	
	#region ScHallRstrctonFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScHallRstrctonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScHallRstrcton"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScHallRstrctonFilterBuilder : SqlFilterBuilder<ScHallRstrctonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScHallRstrctonFilterBuilder class.
		/// </summary>
		public ScHallRstrctonFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScHallRstrctonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScHallRstrctonFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScHallRstrctonFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScHallRstrctonFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScHallRstrctonFilterBuilder
	
	#region ScHallRstrctonParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScHallRstrctonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScHallRstrcton"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScHallRstrctonParameterBuilder : ParameterizedSqlFilterBuilder<ScHallRstrctonColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScHallRstrctonParameterBuilder class.
		/// </summary>
		public ScHallRstrctonParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScHallRstrctonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScHallRstrctonParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScHallRstrctonParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScHallRstrctonParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScHallRstrctonParameterBuilder
	
	#region ScHallRstrctonSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScHallRstrctonColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScHallRstrcton"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScHallRstrctonSortBuilder : SqlSortBuilder<ScHallRstrctonColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScHallRstrctonSqlSortBuilder class.
		/// </summary>
		public ScHallRstrctonSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScHallRstrctonSortBuilder
	
} // end namespace
