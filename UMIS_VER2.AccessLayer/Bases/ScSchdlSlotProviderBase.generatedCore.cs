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
	/// This class is the base class for any <see cref="ScSchdlSlotProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScSchdlSlotProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScSchdlSlot, UMIS_VER2.BusinessLyer.ScSchdlSlotKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlSlotKey key)
		{
			return Delete(transactionManager, key.ScSchdlSlotId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scSchdlSlotId)
		{
			return Delete(null, _scSchdlSlotId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scSchdlSlotId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHDL_SLOT_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="_edCodeCourseTeachingId">طريقة التدريس: مقرر أو موضوع مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(_edCodeCourseTeachingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHDL_SLOT_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">طريقة التدريس: مقرر أو موضوع مقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlot> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHDL_SLOT_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">طريقة التدريس: مقرر أو موضوع مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_CODE_COURSE_TEACHING key.
		///		fkScSchdlSlotEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId">طريقة التدريس: مقرر أو موضوع مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_CODE_COURSE_TEACHING key.
		///		fkScSchdlSlotEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId">طريقة التدريس: مقرر أو موضوع مقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHDL_SLOT_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">طريقة التدريس: مقرر أو موضوع مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public abstract TList<ScSchdlSlot> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE key.
		///		FK_SC_SCHDL_SLOT_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId">المقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE key.
		///		FK_SC_SCHDL_SLOT_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">المقرر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlot> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE key.
		///		FK_SC_SCHDL_SLOT_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">المقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE key.
		///		fkScSchdlSlotEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">المقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE key.
		///		fkScSchdlSlotEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId">المقرر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE key.
		///		FK_SC_SCHDL_SLOT_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId">المقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public abstract TList<ScSchdlSlot> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE_TOPIC key.
		///		FK_SC_SCHDL_SLOT_ED_COURSE_TOPIC Description: 
		/// </summary>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCourseTopicId(System.Decimal? _edCourseTopicId)
		{
			int count = -1;
			return GetByEdCourseTopicId(_edCourseTopicId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE_TOPIC key.
		///		FK_SC_SCHDL_SLOT_ED_COURSE_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlot> GetByEdCourseTopicId(TransactionManager transactionManager, System.Decimal? _edCourseTopicId)
		{
			int count = -1;
			return GetByEdCourseTopicId(transactionManager, _edCourseTopicId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE_TOPIC key.
		///		FK_SC_SCHDL_SLOT_ED_COURSE_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCourseTopicId(TransactionManager transactionManager, System.Decimal? _edCourseTopicId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseTopicId(transactionManager, _edCourseTopicId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE_TOPIC key.
		///		fkScSchdlSlotEdCourseTopic Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCourseTopicId(System.Decimal? _edCourseTopicId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseTopicId(null, _edCourseTopicId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE_TOPIC key.
		///		fkScSchdlSlotEdCourseTopic Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByEdCourseTopicId(System.Decimal? _edCourseTopicId, int start, int pageLength,out int count)
		{
			return GetByEdCourseTopicId(null, _edCourseTopicId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_ED_COURSE_TOPIC key.
		///		FK_SC_SCHDL_SLOT_ED_COURSE_TOPIC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseTopicId">مواضيع المقرر الراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public abstract TList<ScSchdlSlot> GetByEdCourseTopicId(TransactionManager transactionManager, System.Decimal? _edCourseTopicId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_SCHDL_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="_gsCodeWeekDayId">يوم فى الاسبوع</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(_gsCodeWeekDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_SCHDL_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId">يوم فى الاسبوع</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlot> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_SCHDL_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId">يوم فى الاسبوع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_GS_CODE_WEEK_DAY key.
		///		fkScSchdlSlotGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId">يوم فى الاسبوع</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_GS_CODE_WEEK_DAY key.
		///		fkScSchdlSlotGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId">يوم فى الاسبوع</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId, int start, int pageLength,out int count)
		{
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_GS_CODE_WEEK_DAY key.
		///		FK_SC_SCHDL_SLOT_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId">يوم فى الاسبوع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public abstract TList<ScSchdlSlot> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_BUILDING key.
		///		FK_SC_SCHDL_SLOT_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId">المبنى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_BUILDING key.
		///		FK_SC_SCHDL_SLOT_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">المبنى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlot> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_BUILDING key.
		///		FK_SC_SCHDL_SLOT_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">المبنى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_BUILDING key.
		///		fkScSchdlSlotScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId">المبنى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_BUILDING key.
		///		fkScSchdlSlotScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId">المبنى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_BUILDING key.
		///		FK_SC_SCHDL_SLOT_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">المبنى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public abstract TList<ScSchdlSlot> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_CDE_ACTVTY key.
		///		FK_SC_SCHDL_SLOT_SC_CDE_ACTVTY Description: 
		/// </summary>
		/// <param name="_scCdeActvtyId">نشاط فى الجدول الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScCdeActvtyId(System.Decimal? _scCdeActvtyId)
		{
			int count = -1;
			return GetByScCdeActvtyId(_scCdeActvtyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_CDE_ACTVTY key.
		///		FK_SC_SCHDL_SLOT_SC_CDE_ACTVTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeActvtyId">نشاط فى الجدول الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlot> GetByScCdeActvtyId(TransactionManager transactionManager, System.Decimal? _scCdeActvtyId)
		{
			int count = -1;
			return GetByScCdeActvtyId(transactionManager, _scCdeActvtyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_CDE_ACTVTY key.
		///		FK_SC_SCHDL_SLOT_SC_CDE_ACTVTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeActvtyId">نشاط فى الجدول الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScCdeActvtyId(TransactionManager transactionManager, System.Decimal? _scCdeActvtyId, int start, int pageLength)
		{
			int count = -1;
			return GetByScCdeActvtyId(transactionManager, _scCdeActvtyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_CDE_ACTVTY key.
		///		fkScSchdlSlotScCdeActvty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scCdeActvtyId">نشاط فى الجدول الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScCdeActvtyId(System.Decimal? _scCdeActvtyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScCdeActvtyId(null, _scCdeActvtyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_CDE_ACTVTY key.
		///		fkScSchdlSlotScCdeActvty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scCdeActvtyId">نشاط فى الجدول الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScCdeActvtyId(System.Decimal? _scCdeActvtyId, int start, int pageLength,out int count)
		{
			return GetByScCdeActvtyId(null, _scCdeActvtyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_CDE_ACTVTY key.
		///		FK_SC_SCHDL_SLOT_SC_CDE_ACTVTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scCdeActvtyId">نشاط فى الجدول الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public abstract TList<ScSchdlSlot> GetByScCdeActvtyId(TransactionManager transactionManager, System.Decimal? _scCdeActvtyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_HALL key.
		///		FK_SC_SCHDL_SLOT_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId">القاعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_HALL key.
		///		FK_SC_SCHDL_SLOT_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">القاعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlot> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_HALL key.
		///		FK_SC_SCHDL_SLOT_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">القاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_HALL key.
		///		fkScSchdlSlotScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">القاعة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_HALL key.
		///		fkScSchdlSlotScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">القاعة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_HALL key.
		///		FK_SC_SCHDL_SLOT_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">القاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public abstract TList<ScSchdlSlot> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_SCHDL_HDR key.
		///		FK_SC_SCHDL_SLOT_SC_SCHDL_HDR Description: 
		/// </summary>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScSchdlHdrId(System.Decimal _scSchdlHdrId)
		{
			int count = -1;
			return GetByScSchdlHdrId(_scSchdlHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_SCHDL_HDR key.
		///		FK_SC_SCHDL_SLOT_SC_SCHDL_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlot> GetByScSchdlHdrId(TransactionManager transactionManager, System.Decimal _scSchdlHdrId)
		{
			int count = -1;
			return GetByScSchdlHdrId(transactionManager, _scSchdlHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_SCHDL_HDR key.
		///		FK_SC_SCHDL_SLOT_SC_SCHDL_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScSchdlHdrId(TransactionManager transactionManager, System.Decimal _scSchdlHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlHdrId(transactionManager, _scSchdlHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_SCHDL_HDR key.
		///		fkScSchdlSlotScSchdlHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScSchdlHdrId(System.Decimal _scSchdlHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScSchdlHdrId(null, _scSchdlHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_SCHDL_HDR key.
		///		fkScSchdlSlotScSchdlHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScSchdlHdrId(System.Decimal _scSchdlHdrId, int start, int pageLength,out int count)
		{
			return GetByScSchdlHdrId(null, _scSchdlHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_SCHDL_HDR key.
		///		FK_SC_SCHDL_SLOT_SC_SCHDL_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlHdrId">New Group Schedule</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public abstract TList<ScSchdlSlot> GetByScSchdlHdrId(TransactionManager transactionManager, System.Decimal _scSchdlHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_TCHNG_SLOT key.
		///		FK_SC_SCHDL_SLOT_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="_scTchngSlotId">حصص اليوم الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScTchngSlotId(System.Decimal _scTchngSlotId)
		{
			int count = -1;
			return GetByScTchngSlotId(_scTchngSlotId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_TCHNG_SLOT key.
		///		FK_SC_SCHDL_SLOT_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId">حصص اليوم الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		/// <remarks></remarks>
		public TList<ScSchdlSlot> GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal _scTchngSlotId)
		{
			int count = -1;
			return GetByScTchngSlotId(transactionManager, _scTchngSlotId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_TCHNG_SLOT key.
		///		FK_SC_SCHDL_SLOT_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId">حصص اليوم الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal _scTchngSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngSlotId(transactionManager, _scTchngSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_TCHNG_SLOT key.
		///		fkScSchdlSlotScTchngSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngSlotId">حصص اليوم الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScTchngSlotId(System.Decimal _scTchngSlotId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScTchngSlotId(null, _scTchngSlotId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_TCHNG_SLOT key.
		///		fkScSchdlSlotScTchngSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngSlotId">حصص اليوم الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public TList<ScSchdlSlot> GetByScTchngSlotId(System.Decimal _scTchngSlotId, int start, int pageLength,out int count)
		{
			return GetByScTchngSlotId(null, _scTchngSlotId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHDL_SLOT_SC_TCHNG_SLOT key.
		///		FK_SC_SCHDL_SLOT_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId">حصص اليوم الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSchdlSlot objects.</returns>
		public abstract TList<ScSchdlSlot> GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal _scTchngSlotId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScSchdlSlot Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlSlotKey key, int start, int pageLength)
		{
			return GetByScSchdlSlotId(transactionManager, key.ScSchdlSlotId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHDL_SLOT index.
		/// </summary>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlSlot GetByScSchdlSlotId(System.Decimal _scSchdlSlotId)
		{
			int count = -1;
			return GetByScSchdlSlotId(null,_scSchdlSlotId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_SLOT index.
		/// </summary>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlSlot GetByScSchdlSlotId(System.Decimal _scSchdlSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlSlotId(null, _scSchdlSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlSlot GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal _scSchdlSlotId)
		{
			int count = -1;
			return GetByScSchdlSlotId(transactionManager, _scSchdlSlotId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlSlot GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal _scSchdlSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlSlotId(transactionManager, _scSchdlSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_SLOT index.
		/// </summary>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSchdlSlot GetByScSchdlSlotId(System.Decimal _scSchdlSlotId, int start, int pageLength, out int count)
		{
			return GetByScSchdlSlotId(null, _scSchdlSlotId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHDL_SLOT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlSlotId">Modular/SY Student جدول مجموعة طلاب- او جدول مجموعة مقرر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScSchdlSlot GetByScSchdlSlotId(TransactionManager transactionManager, System.Decimal _scSchdlSlotId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScSchdlSlot&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScSchdlSlot&gt;"/></returns>
		public static TList<ScSchdlSlot> Fill(IDataReader reader, TList<ScSchdlSlot> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScSchdlSlot c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScSchdlSlot")
					.Append("|").Append((System.Decimal)reader["SC_SCHDL_SLOT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScSchdlSlot>(
					key.ToString(), // EntityTrackingKey
					"ScSchdlSlot",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScSchdlSlot();
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
					c.ScSchdlSlotId = (System.Decimal)reader["SC_SCHDL_SLOT_ID"];
					c.OriginalScSchdlSlotId = c.ScSchdlSlotId;
					c.ScSchdlHdrId = (System.Decimal)reader["SC_SCHDL_HDR_ID"];
					c.DayDate = Convert.IsDBNull(reader["DAY_DATE"]) ? null : (System.DateTime?)reader["DAY_DATE"];
					c.GsCodeWeekDayId = (System.Decimal)reader["GS_CODE_WEEK_DAY_ID"];
					c.ScTchngSlotId = (System.Decimal)reader["SC_TCHNG_SLOT_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.EdCourseTopicId = Convert.IsDBNull(reader["ED_COURSE_TOPIC_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_TOPIC_ID"];
					c.EdCodeCourseTeachingId = Convert.IsDBNull(reader["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_TEACHING_ID"];
					c.ScCdeActvtyId = Convert.IsDBNull(reader["SC_CDE_ACTVTY_ID"]) ? null : (System.Decimal?)reader["SC_CDE_ACTVTY_ID"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
					c.VacFlg = (System.Boolean)reader["VAC_FLG"];
					c.VacReason = Convert.IsDBNull(reader["VAC_REASON"]) ? null : (System.String)reader["VAC_REASON"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScSchdlSlot entity)
		{
			if (!reader.Read()) return;
			
			entity.ScSchdlSlotId = (System.Decimal)reader[((int)ScSchdlSlotColumn.ScSchdlSlotId - 1)];
			entity.OriginalScSchdlSlotId = (System.Decimal)reader["SC_SCHDL_SLOT_ID"];
			entity.ScSchdlHdrId = (System.Decimal)reader[((int)ScSchdlSlotColumn.ScSchdlHdrId - 1)];
			entity.DayDate = (reader.IsDBNull(((int)ScSchdlSlotColumn.DayDate - 1)))?null:(System.DateTime?)reader[((int)ScSchdlSlotColumn.DayDate - 1)];
			entity.GsCodeWeekDayId = (System.Decimal)reader[((int)ScSchdlSlotColumn.GsCodeWeekDayId - 1)];
			entity.ScTchngSlotId = (System.Decimal)reader[((int)ScSchdlSlotColumn.ScTchngSlotId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)ScSchdlSlotColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotColumn.EdCourseId - 1)];
			entity.EdCourseTopicId = (reader.IsDBNull(((int)ScSchdlSlotColumn.EdCourseTopicId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotColumn.EdCourseTopicId - 1)];
			entity.EdCodeCourseTeachingId = (reader.IsDBNull(((int)ScSchdlSlotColumn.EdCodeCourseTeachingId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotColumn.EdCodeCourseTeachingId - 1)];
			entity.ScCdeActvtyId = (reader.IsDBNull(((int)ScSchdlSlotColumn.ScCdeActvtyId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotColumn.ScCdeActvtyId - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)ScSchdlSlotColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotColumn.ScBuildingId - 1)];
			entity.ScHallId = (reader.IsDBNull(((int)ScSchdlSlotColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotColumn.ScHallId - 1)];
			entity.VacFlg = (System.Boolean)reader[((int)ScSchdlSlotColumn.VacFlg - 1)];
			entity.VacReason = (reader.IsDBNull(((int)ScSchdlSlotColumn.VacReason - 1)))?null:(System.String)reader[((int)ScSchdlSlotColumn.VacReason - 1)];
			entity.LastDate = (reader.IsDBNull(((int)ScSchdlSlotColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)ScSchdlSlotColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)ScSchdlSlotColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)ScSchdlSlotColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScSchdlSlot entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScSchdlSlotId = (System.Decimal)dataRow["SC_SCHDL_SLOT_ID"];
			entity.OriginalScSchdlSlotId = (System.Decimal)dataRow["SC_SCHDL_SLOT_ID"];
			entity.ScSchdlHdrId = (System.Decimal)dataRow["SC_SCHDL_HDR_ID"];
			entity.DayDate = Convert.IsDBNull(dataRow["DAY_DATE"]) ? null : (System.DateTime?)dataRow["DAY_DATE"];
			entity.GsCodeWeekDayId = (System.Decimal)dataRow["GS_CODE_WEEK_DAY_ID"];
			entity.ScTchngSlotId = (System.Decimal)dataRow["SC_TCHNG_SLOT_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.EdCourseTopicId = Convert.IsDBNull(dataRow["ED_COURSE_TOPIC_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_TOPIC_ID"];
			entity.EdCodeCourseTeachingId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.ScCdeActvtyId = Convert.IsDBNull(dataRow["SC_CDE_ACTVTY_ID"]) ? null : (System.Decimal?)dataRow["SC_CDE_ACTVTY_ID"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
			entity.VacFlg = (System.Boolean)dataRow["VAC_FLG"];
			entity.VacReason = Convert.IsDBNull(dataRow["VAC_REASON"]) ? null : (System.String)dataRow["VAC_REASON"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSchdlSlot"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSchdlSlot Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlSlot entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCourseTopicIdSource	
			if (CanDeepLoad(entity, "EdCourseTopic|EdCourseTopicIdSource", deepLoadType, innerList) 
				&& entity.EdCourseTopicIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseTopicId ?? 0.0m);
				EdCourseTopic tmpEntity = EntityManager.LocateEntity<EdCourseTopic>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourseTopic), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseTopicIdSource = tmpEntity;
				else
					entity.EdCourseTopicIdSource = DataRepository.EdCourseTopicProvider.GetByEdCourseTopicId(transactionManager, (entity.EdCourseTopicId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseTopicIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseTopicIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseTopicProvider.DeepLoad(transactionManager, entity.EdCourseTopicIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseTopicIdSource

			#region GsCodeWeekDayIdSource	
			if (CanDeepLoad(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepLoadType, innerList) 
				&& entity.GsCodeWeekDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeWeekDayId;
				GsCodeWeekDay tmpEntity = EntityManager.LocateEntity<GsCodeWeekDay>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeWeekDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeWeekDayIdSource = tmpEntity;
				else
					entity.GsCodeWeekDayIdSource = DataRepository.GsCodeWeekDayProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeWeekDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeWeekDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeWeekDayProvider.DeepLoad(transactionManager, entity.GsCodeWeekDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeWeekDayIdSource

			#region ScBuildingIdSource	
			if (CanDeepLoad(entity, "ScBuilding|ScBuildingIdSource", deepLoadType, innerList) 
				&& entity.ScBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScBuildingId ?? 0.0m);
				ScBuilding tmpEntity = EntityManager.LocateEntity<ScBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(ScBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScBuildingIdSource = tmpEntity;
				else
					entity.ScBuildingIdSource = DataRepository.ScBuildingProvider.GetByScBuildingId(transactionManager, (entity.ScBuildingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScBuildingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScBuildingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScBuildingProvider.DeepLoad(transactionManager, entity.ScBuildingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScBuildingIdSource

			#region ScCdeActvtyIdSource	
			if (CanDeepLoad(entity, "ScCdeActvty|ScCdeActvtyIdSource", deepLoadType, innerList) 
				&& entity.ScCdeActvtyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScCdeActvtyId ?? 0.0m);
				ScCdeActvty tmpEntity = EntityManager.LocateEntity<ScCdeActvty>(EntityLocator.ConstructKeyFromPkItems(typeof(ScCdeActvty), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScCdeActvtyIdSource = tmpEntity;
				else
					entity.ScCdeActvtyIdSource = DataRepository.ScCdeActvtyProvider.GetByScCdeActvtyId(transactionManager, (entity.ScCdeActvtyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScCdeActvtyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScCdeActvtyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScCdeActvtyProvider.DeepLoad(transactionManager, entity.ScCdeActvtyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScCdeActvtyIdSource

			#region ScHallIdSource	
			if (CanDeepLoad(entity, "ScHall|ScHallIdSource", deepLoadType, innerList) 
				&& entity.ScHallIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScHallId ?? 0.0m);
				ScHall tmpEntity = EntityManager.LocateEntity<ScHall>(EntityLocator.ConstructKeyFromPkItems(typeof(ScHall), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScHallIdSource = tmpEntity;
				else
					entity.ScHallIdSource = DataRepository.ScHallProvider.GetByScHallId(transactionManager, (entity.ScHallId ?? 0.0m));		
				
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

			#region ScSchdlHdrIdSource	
			if (CanDeepLoad(entity, "ScSchdlHdr|ScSchdlHdrIdSource", deepLoadType, innerList) 
				&& entity.ScSchdlHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScSchdlHdrId;
				ScSchdlHdr tmpEntity = EntityManager.LocateEntity<ScSchdlHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(ScSchdlHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScSchdlHdrIdSource = tmpEntity;
				else
					entity.ScSchdlHdrIdSource = DataRepository.ScSchdlHdrProvider.GetByScSchdlHdrId(transactionManager, entity.ScSchdlHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScSchdlHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScSchdlHdrProvider.DeepLoad(transactionManager, entity.ScSchdlHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScSchdlHdrIdSource

			#region ScTchngSlotIdSource	
			if (CanDeepLoad(entity, "ScTchngSlot|ScTchngSlotIdSource", deepLoadType, innerList) 
				&& entity.ScTchngSlotIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScTchngSlotId;
				ScTchngSlot tmpEntity = EntityManager.LocateEntity<ScTchngSlot>(EntityLocator.ConstructKeyFromPkItems(typeof(ScTchngSlot), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScTchngSlotIdSource = tmpEntity;
				else
					entity.ScTchngSlotIdSource = DataRepository.ScTchngSlotProvider.GetByScTchngSlotId(transactionManager, entity.ScTchngSlotId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngSlotIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScTchngSlotIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScTchngSlotProvider.DeepLoad(transactionManager, entity.ScTchngSlotIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScTchngSlotIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScSchdlSlotId methods when available
			
			#region EdStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsence>|EdStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsenceCollection = DataRepository.EdStudAbsenceProvider.GetByScSchdlSlotId(transactionManager, entity.ScSchdlSlotId);

				if (deep && entity.EdStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsence>) DataRepository.EdStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlSlotStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlSlotStaff>|ScSchdlSlotStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlSlotStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlSlotStaffCollection = DataRepository.ScSchdlSlotStaffProvider.GetByScSchdlSlotId(transactionManager, entity.ScSchdlSlotId);

				if (deep && entity.ScSchdlSlotStaffCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlSlotStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlSlotStaff>) DataRepository.ScSchdlSlotStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlSlotStaffCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudLatenessCollection = DataRepository.EdStudLatenessProvider.GetByScSchdlSlotId(transactionManager, entity.ScSchdlSlotId);

				if (deep && entity.EdStudLatenessCollection.Count > 0)
				{
					deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLateness>) DataRepository.EdStudLatenessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLatenessCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScSchdlSlot object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScSchdlSlot instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSchdlSlot Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSchdlSlot entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCourseTopicIdSource
			if (CanDeepSave(entity, "EdCourseTopic|EdCourseTopicIdSource", deepSaveType, innerList) 
				&& entity.EdCourseTopicIdSource != null)
			{
				DataRepository.EdCourseTopicProvider.Save(transactionManager, entity.EdCourseTopicIdSource);
				entity.EdCourseTopicId = entity.EdCourseTopicIdSource.EdCourseTopicId;
			}
			#endregion 
			
			#region GsCodeWeekDayIdSource
			if (CanDeepSave(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepSaveType, innerList) 
				&& entity.GsCodeWeekDayIdSource != null)
			{
				DataRepository.GsCodeWeekDayProvider.Save(transactionManager, entity.GsCodeWeekDayIdSource);
				entity.GsCodeWeekDayId = entity.GsCodeWeekDayIdSource.GsCodeWeekDayId;
			}
			#endregion 
			
			#region ScBuildingIdSource
			if (CanDeepSave(entity, "ScBuilding|ScBuildingIdSource", deepSaveType, innerList) 
				&& entity.ScBuildingIdSource != null)
			{
				DataRepository.ScBuildingProvider.Save(transactionManager, entity.ScBuildingIdSource);
				entity.ScBuildingId = entity.ScBuildingIdSource.ScBuildingId;
			}
			#endregion 
			
			#region ScCdeActvtyIdSource
			if (CanDeepSave(entity, "ScCdeActvty|ScCdeActvtyIdSource", deepSaveType, innerList) 
				&& entity.ScCdeActvtyIdSource != null)
			{
				DataRepository.ScCdeActvtyProvider.Save(transactionManager, entity.ScCdeActvtyIdSource);
				entity.ScCdeActvtyId = entity.ScCdeActvtyIdSource.ScCdeActvtyId;
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
			
			#region ScSchdlHdrIdSource
			if (CanDeepSave(entity, "ScSchdlHdr|ScSchdlHdrIdSource", deepSaveType, innerList) 
				&& entity.ScSchdlHdrIdSource != null)
			{
				DataRepository.ScSchdlHdrProvider.Save(transactionManager, entity.ScSchdlHdrIdSource);
				entity.ScSchdlHdrId = entity.ScSchdlHdrIdSource.ScSchdlHdrId;
			}
			#endregion 
			
			#region ScTchngSlotIdSource
			if (CanDeepSave(entity, "ScTchngSlot|ScTchngSlotIdSource", deepSaveType, innerList) 
				&& entity.ScTchngSlotIdSource != null)
			{
				DataRepository.ScTchngSlotProvider.Save(transactionManager, entity.ScTchngSlotIdSource);
				entity.ScTchngSlotId = entity.ScTchngSlotIdSource.ScTchngSlotId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudAbsence>
				if (CanDeepSave(entity.EdStudAbsenceCollection, "List<EdStudAbsence>|EdStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsence child in entity.EdStudAbsenceCollection)
					{
						if(child.ScSchdlSlotIdSource != null)
						{
							child.ScSchdlSlotId = child.ScSchdlSlotIdSource.ScSchdlSlotId;
						}
						else
						{
							child.ScSchdlSlotId = entity.ScSchdlSlotId;
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
				
	
			#region List<ScSchdlSlotStaff>
				if (CanDeepSave(entity.ScSchdlSlotStaffCollection, "List<ScSchdlSlotStaff>|ScSchdlSlotStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlSlotStaff child in entity.ScSchdlSlotStaffCollection)
					{
						if(child.ScSchdlSlotIdSource != null)
						{
							child.ScSchdlSlotId = child.ScSchdlSlotIdSource.ScSchdlSlotId;
						}
						else
						{
							child.ScSchdlSlotId = entity.ScSchdlSlotId;
						}

					}

					if (entity.ScSchdlSlotStaffCollection.Count > 0 || entity.ScSchdlSlotStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlSlotStaffProvider.Save(transactionManager, entity.ScSchdlSlotStaffCollection);
						
						deepHandles.Add("ScSchdlSlotStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlSlotStaff >) DataRepository.ScSchdlSlotStaffProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlSlotStaffCollection, deepSaveType, childTypes, innerList }
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
						if(child.ScSchdlSlotIdSource != null)
						{
							child.ScSchdlSlotId = child.ScSchdlSlotIdSource.ScSchdlSlotId;
						}
						else
						{
							child.ScSchdlSlotId = entity.ScSchdlSlotId;
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
	
	#region ScSchdlSlotChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScSchdlSlot</c>
	///</summary>
	public enum ScSchdlSlotChildEntityTypes
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
		/// Composite Property for <c>EdCourseTopic</c> at EdCourseTopicIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourseTopic))]
		EdCourseTopic,
		
		///<summary>
		/// Composite Property for <c>GsCodeWeekDay</c> at GsCodeWeekDayIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeWeekDay))]
		GsCodeWeekDay,
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		
		///<summary>
		/// Composite Property for <c>ScCdeActvty</c> at ScCdeActvtyIdSource
		///</summary>
		[ChildEntityType(typeof(ScCdeActvty))]
		ScCdeActvty,
		
		///<summary>
		/// Composite Property for <c>ScHall</c> at ScHallIdSource
		///</summary>
		[ChildEntityType(typeof(ScHall))]
		ScHall,
		
		///<summary>
		/// Composite Property for <c>ScSchdlHdr</c> at ScSchdlHdrIdSource
		///</summary>
		[ChildEntityType(typeof(ScSchdlHdr))]
		ScSchdlHdr,
		
		///<summary>
		/// Composite Property for <c>ScTchngSlot</c> at ScTchngSlotIdSource
		///</summary>
		[ChildEntityType(typeof(ScTchngSlot))]
		ScTchngSlot,
		///<summary>
		/// Collection of <c>ScSchdlSlot</c> as OneToMany for EdStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsence>))]
		EdStudAbsenceCollection,
		///<summary>
		/// Collection of <c>ScSchdlSlot</c> as OneToMany for ScSchdlSlotStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlSlotStaff>))]
		ScSchdlSlotStaffCollection,
		///<summary>
		/// Collection of <c>ScSchdlSlot</c> as OneToMany for EdStudLatenessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLateness>))]
		EdStudLatenessCollection,
	}
	
	#endregion ScSchdlSlotChildEntityTypes
	
	#region ScSchdlSlotFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScSchdlSlotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlSlot"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSchdlSlotFilterBuilder : SqlFilterBuilder<ScSchdlSlotColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotFilterBuilder class.
		/// </summary>
		public ScSchdlSlotFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSchdlSlotFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSchdlSlotFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSchdlSlotFilterBuilder
	
	#region ScSchdlSlotParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScSchdlSlotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlSlot"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSchdlSlotParameterBuilder : ParameterizedSqlFilterBuilder<ScSchdlSlotColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotParameterBuilder class.
		/// </summary>
		public ScSchdlSlotParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSchdlSlotParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSchdlSlotParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSchdlSlotParameterBuilder
	
	#region ScSchdlSlotSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScSchdlSlotColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSchdlSlot"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScSchdlSlotSortBuilder : SqlSortBuilder<ScSchdlSlotColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotSqlSortBuilder class.
		/// </summary>
		public ScSchdlSlotSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScSchdlSlotSortBuilder
	
} // end namespace
