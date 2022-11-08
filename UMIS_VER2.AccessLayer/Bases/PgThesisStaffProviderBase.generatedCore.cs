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
	/// This class is the base class for any <see cref="PgThesisStaffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisStaffProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisStaff, UMIS_VER2.BusinessLyer.PgThesisStaffKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStaffKey key)
		{
			return Delete(transactionManager, key.PgThesisStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisStaffId">CSS: المشرفين- المناقشين
		/// 		/// Ejust(general) : لجنة الاشراف- لجنة التحكيم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisStaffId)
		{
			return Delete(null, _pgThesisStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStaffId">CSS: المشرفين- المناقشين
		/// 		/// Ejust(general) : لجنة الاشراف- لجنة التحكيم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisStaffId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CDE_STF_ROLE key.
		///		FK_PG_THESIS_STAFF_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgCdeStfRoleId(System.Int32? _pgCdeStfRoleId)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(_pgCdeStfRoleId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CDE_STF_ROLE key.
		///		FK_PG_THESIS_STAFF_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStaff> GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32? _pgCdeStfRoleId)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(transactionManager, _pgCdeStfRoleId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CDE_STF_ROLE key.
		///		FK_PG_THESIS_STAFF_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32? _pgCdeStfRoleId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(transactionManager, _pgCdeStfRoleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CDE_STF_ROLE key.
		///		fkPgThesisStaffPgCdeStfRole Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgCdeStfRoleId(System.Int32? _pgCdeStfRoleId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgCdeStfRoleId(null, _pgCdeStfRoleId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CDE_STF_ROLE key.
		///		fkPgThesisStaffPgCdeStfRole Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgCdeStfRoleId(System.Int32? _pgCdeStfRoleId, int start, int pageLength,out int count)
		{
			return GetByPgCdeStfRoleId(null, _pgCdeStfRoleId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CDE_STF_ROLE key.
		///		FK_PG_THESIS_STAFF_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public abstract TList<PgThesisStaff> GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32? _pgCdeStfRoleId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		FK_PG_THESIS_STAFF_PG_CODE_SUPERVISOR_CHG_RSN Description: 
		/// </summary>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgCodeSupervisorChgRsnId(System.Int32? _pgCodeSupervisorChgRsnId)
		{
			int count = -1;
			return GetByPgCodeSupervisorChgRsnId(_pgCodeSupervisorChgRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		FK_PG_THESIS_STAFF_PG_CODE_SUPERVISOR_CHG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStaff> GetByPgCodeSupervisorChgRsnId(TransactionManager transactionManager, System.Int32? _pgCodeSupervisorChgRsnId)
		{
			int count = -1;
			return GetByPgCodeSupervisorChgRsnId(transactionManager, _pgCodeSupervisorChgRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		FK_PG_THESIS_STAFF_PG_CODE_SUPERVISOR_CHG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgCodeSupervisorChgRsnId(TransactionManager transactionManager, System.Int32? _pgCodeSupervisorChgRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeSupervisorChgRsnId(transactionManager, _pgCodeSupervisorChgRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		fkPgThesisStaffPgCodeSupervisorChgRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgCodeSupervisorChgRsnId(System.Int32? _pgCodeSupervisorChgRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgCodeSupervisorChgRsnId(null, _pgCodeSupervisorChgRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		fkPgThesisStaffPgCodeSupervisorChgRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgCodeSupervisorChgRsnId(System.Int32? _pgCodeSupervisorChgRsnId, int start, int pageLength,out int count)
		{
			return GetByPgCodeSupervisorChgRsnId(null, _pgCodeSupervisorChgRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		FK_PG_THESIS_STAFF_PG_CODE_SUPERVISOR_CHG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public abstract TList<PgThesisStaff> GetByPgCodeSupervisorChgRsnId(TransactionManager transactionManager, System.Int32? _pgCodeSupervisorChgRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_EXT_MEMBER key.
		///		FK_PG_THESIS_STAFF_PG_EXT_MEMBER Description: 
		/// </summary>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgExtMemberId(System.Decimal? _pgExtMemberId)
		{
			int count = -1;
			return GetByPgExtMemberId(_pgExtMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_EXT_MEMBER key.
		///		FK_PG_THESIS_STAFF_PG_EXT_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStaff> GetByPgExtMemberId(TransactionManager transactionManager, System.Decimal? _pgExtMemberId)
		{
			int count = -1;
			return GetByPgExtMemberId(transactionManager, _pgExtMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_EXT_MEMBER key.
		///		FK_PG_THESIS_STAFF_PG_EXT_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgExtMemberId(TransactionManager transactionManager, System.Decimal? _pgExtMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgExtMemberId(transactionManager, _pgExtMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_EXT_MEMBER key.
		///		fkPgThesisStaffPgExtMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgExtMemberId(System.Decimal? _pgExtMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgExtMemberId(null, _pgExtMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_EXT_MEMBER key.
		///		fkPgThesisStaffPgExtMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgExtMemberId(System.Decimal? _pgExtMemberId, int start, int pageLength,out int count)
		{
			return GetByPgExtMemberId(null, _pgExtMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_EXT_MEMBER key.
		///		FK_PG_THESIS_STAFF_PG_EXT_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public abstract TList<PgThesisStaff> GetByPgExtMemberId(TransactionManager transactionManager, System.Decimal? _pgExtMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STAFF_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">بيانات الرسالة او البحث العلمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STAFF_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة او البحث العلمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStaff> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STAFF_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة او البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_STUD key.
		///		fkPgThesisStaffPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة او البحث العلمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_STUD key.
		///		fkPgThesisStaffPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة او البحث العلمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STAFF_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة او البحث العلمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public abstract TList<PgThesisStaff> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_SUPERVISOR_COMM key.
		///		FK_PG_THESIS_STAFF_PG_THESIS_SUPERVISOR_COMM Description: 
		/// </summary>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgThesisSupervisorCommId(System.Decimal? _pgThesisSupervisorCommId)
		{
			int count = -1;
			return GetByPgThesisSupervisorCommId(_pgThesisSupervisorCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_SUPERVISOR_COMM key.
		///		FK_PG_THESIS_STAFF_PG_THESIS_SUPERVISOR_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStaff> GetByPgThesisSupervisorCommId(TransactionManager transactionManager, System.Decimal? _pgThesisSupervisorCommId)
		{
			int count = -1;
			return GetByPgThesisSupervisorCommId(transactionManager, _pgThesisSupervisorCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_SUPERVISOR_COMM key.
		///		FK_PG_THESIS_STAFF_PG_THESIS_SUPERVISOR_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgThesisSupervisorCommId(TransactionManager transactionManager, System.Decimal? _pgThesisSupervisorCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSupervisorCommId(transactionManager, _pgThesisSupervisorCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_SUPERVISOR_COMM key.
		///		fkPgThesisStaffPgThesisSupervisorComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgThesisSupervisorCommId(System.Decimal? _pgThesisSupervisorCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisSupervisorCommId(null, _pgThesisSupervisorCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_SUPERVISOR_COMM key.
		///		fkPgThesisStaffPgThesisSupervisorComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetByPgThesisSupervisorCommId(System.Decimal? _pgThesisSupervisorCommId, int start, int pageLength,out int count)
		{
			return GetByPgThesisSupervisorCommId(null, _pgThesisSupervisorCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_PG_THESIS_SUPERVISOR_COMM key.
		///		FK_PG_THESIS_STAFF_PG_THESIS_SUPERVISOR_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public abstract TList<PgThesisStaff> GetByPgThesisSupervisorCommId(TransactionManager transactionManager, System.Decimal? _pgThesisSupervisorCommId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_SA_STF_MEMBER key.
		///		FK_PG_THESIS_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId">عضو داخلى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_SA_STF_MEMBER key.
		///		FK_PG_THESIS_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">عضو داخلى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_SA_STF_MEMBER key.
		///		FK_PG_THESIS_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">عضو داخلى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_SA_STF_MEMBER key.
		///		fkPgThesisStaffSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId">عضو داخلى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_SA_STF_MEMBER key.
		///		fkPgThesisStaffSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId">عضو داخلى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public TList<PgThesisStaff> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STAFF_SA_STF_MEMBER key.
		///		FK_PG_THESIS_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">عضو داخلى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStaff objects.</returns>
		public abstract TList<PgThesisStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisStaff Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStaffKey key, int start, int pageLength)
		{
			return GetByPgThesisStaffId(transactionManager, key.PgThesisStaffId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_STAFF index.
		/// </summary>
		/// <param name="_pgThesisStaffId">CSS: المشرفين- المناقشين
		/// 		/// Ejust(general) : لجنة الاشراف- لجنة التحكيم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStaff GetByPgThesisStaffId(System.Decimal _pgThesisStaffId)
		{
			int count = -1;
			return GetByPgThesisStaffId(null,_pgThesisStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STAFF index.
		/// </summary>
		/// <param name="_pgThesisStaffId">CSS: المشرفين- المناقشين
		/// 		/// Ejust(general) : لجنة الاشراف- لجنة التحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStaff GetByPgThesisStaffId(System.Decimal _pgThesisStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStaffId(null, _pgThesisStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStaffId">CSS: المشرفين- المناقشين
		/// 		/// Ejust(general) : لجنة الاشراف- لجنة التحكيم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStaff GetByPgThesisStaffId(TransactionManager transactionManager, System.Decimal _pgThesisStaffId)
		{
			int count = -1;
			return GetByPgThesisStaffId(transactionManager, _pgThesisStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStaffId">CSS: المشرفين- المناقشين
		/// 		/// Ejust(general) : لجنة الاشراف- لجنة التحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStaff GetByPgThesisStaffId(TransactionManager transactionManager, System.Decimal _pgThesisStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStaffId(transactionManager, _pgThesisStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STAFF index.
		/// </summary>
		/// <param name="_pgThesisStaffId">CSS: المشرفين- المناقشين
		/// 		/// Ejust(general) : لجنة الاشراف- لجنة التحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStaff GetByPgThesisStaffId(System.Decimal _pgThesisStaffId, int start, int pageLength, out int count)
		{
			return GetByPgThesisStaffId(null, _pgThesisStaffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStaffId">CSS: المشرفين- المناقشين
		/// 		/// Ejust(general) : لجنة الاشراف- لجنة التحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisStaff GetByPgThesisStaffId(TransactionManager transactionManager, System.Decimal _pgThesisStaffId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisStaff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisStaff&gt;"/></returns>
		public static TList<PgThesisStaff> Fill(IDataReader reader, TList<PgThesisStaff> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisStaff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisStaff")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_STAFF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisStaff>(
					key.ToString(), // EntityTrackingKey
					"PgThesisStaff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisStaff();
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
					c.PgThesisStaffId = (System.Decimal)reader["PG_THESIS_STAFF_ID"];
					c.OriginalPgThesisStaffId = c.PgThesisStaffId;
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.PgThesisSupervisorCommId = Convert.IsDBNull(reader["PG_THESIS_SUPERVISOR_COMM_ID"]) ? null : (System.Decimal?)reader["PG_THESIS_SUPERVISOR_COMM_ID"];
					c.MemberTypeFlg = Convert.IsDBNull(reader["MEMBER_TYPE_FLG"]) ? null : (System.Int16?)reader["MEMBER_TYPE_FLG"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.PgExtMemberId = Convert.IsDBNull(reader["PG_EXT_MEMBER_ID"]) ? null : (System.Decimal?)reader["PG_EXT_MEMBER_ID"];
					c.PgCdeStfRoleId = Convert.IsDBNull(reader["PG_CDE_STF_ROLE_ID"]) ? null : (System.Int32?)reader["PG_CDE_STF_ROLE_ID"];
					c.MainFlg = (System.Boolean)reader["MAIN_FLG"];
					c.StaffRollId = (System.Decimal)reader["STAFF_ROLL_ID"];
					c.PgCodeSupervisorChgRsnId = Convert.IsDBNull(reader["PG_CODE_SUPERVISOR_CHG_RSN_ID"]) ? null : (System.Int32?)reader["PG_CODE_SUPERVISOR_CHG_RSN_ID"];
					c.StartDate = Convert.IsDBNull(reader["START_DATE"]) ? null : (System.DateTime?)reader["START_DATE"];
					c.EndDate = Convert.IsDBNull(reader["END_DATE"]) ? null : (System.DateTime?)reader["END_DATE"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisStaff entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisStaffId = (System.Decimal)reader[((int)PgThesisStaffColumn.PgThesisStaffId - 1)];
			entity.OriginalPgThesisStaffId = (System.Decimal)reader["PG_THESIS_STAFF_ID"];
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisStaffColumn.PgThesisStudId - 1)];
			entity.PgThesisSupervisorCommId = (reader.IsDBNull(((int)PgThesisStaffColumn.PgThesisSupervisorCommId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStaffColumn.PgThesisSupervisorCommId - 1)];
			entity.MemberTypeFlg = (reader.IsDBNull(((int)PgThesisStaffColumn.MemberTypeFlg - 1)))?null:(System.Int16?)reader[((int)PgThesisStaffColumn.MemberTypeFlg - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)PgThesisStaffColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStaffColumn.SaStfMemberId - 1)];
			entity.PgExtMemberId = (reader.IsDBNull(((int)PgThesisStaffColumn.PgExtMemberId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStaffColumn.PgExtMemberId - 1)];
			entity.PgCdeStfRoleId = (reader.IsDBNull(((int)PgThesisStaffColumn.PgCdeStfRoleId - 1)))?null:(System.Int32?)reader[((int)PgThesisStaffColumn.PgCdeStfRoleId - 1)];
			entity.MainFlg = (System.Boolean)reader[((int)PgThesisStaffColumn.MainFlg - 1)];
			entity.StaffRollId = (System.Decimal)reader[((int)PgThesisStaffColumn.StaffRollId - 1)];
			entity.PgCodeSupervisorChgRsnId = (reader.IsDBNull(((int)PgThesisStaffColumn.PgCodeSupervisorChgRsnId - 1)))?null:(System.Int32?)reader[((int)PgThesisStaffColumn.PgCodeSupervisorChgRsnId - 1)];
			entity.StartDate = (reader.IsDBNull(((int)PgThesisStaffColumn.StartDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStaffColumn.StartDate - 1)];
			entity.EndDate = (reader.IsDBNull(((int)PgThesisStaffColumn.EndDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStaffColumn.EndDate - 1)];
			entity.IsActive = (reader.IsDBNull(((int)PgThesisStaffColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)PgThesisStaffColumn.IsActive - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisStaffColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStaffColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisStaffColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStaffColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisStaff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisStaffId = (System.Decimal)dataRow["PG_THESIS_STAFF_ID"];
			entity.OriginalPgThesisStaffId = (System.Decimal)dataRow["PG_THESIS_STAFF_ID"];
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.PgThesisSupervisorCommId = Convert.IsDBNull(dataRow["PG_THESIS_SUPERVISOR_COMM_ID"]) ? null : (System.Decimal?)dataRow["PG_THESIS_SUPERVISOR_COMM_ID"];
			entity.MemberTypeFlg = Convert.IsDBNull(dataRow["MEMBER_TYPE_FLG"]) ? null : (System.Int16?)dataRow["MEMBER_TYPE_FLG"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.PgExtMemberId = Convert.IsDBNull(dataRow["PG_EXT_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["PG_EXT_MEMBER_ID"];
			entity.PgCdeStfRoleId = Convert.IsDBNull(dataRow["PG_CDE_STF_ROLE_ID"]) ? null : (System.Int32?)dataRow["PG_CDE_STF_ROLE_ID"];
			entity.MainFlg = (System.Boolean)dataRow["MAIN_FLG"];
			entity.StaffRollId = (System.Decimal)dataRow["STAFF_ROLL_ID"];
			entity.PgCodeSupervisorChgRsnId = Convert.IsDBNull(dataRow["PG_CODE_SUPERVISOR_CHG_RSN_ID"]) ? null : (System.Int32?)dataRow["PG_CODE_SUPERVISOR_CHG_RSN_ID"];
			entity.StartDate = Convert.IsDBNull(dataRow["START_DATE"]) ? null : (System.DateTime?)dataRow["START_DATE"];
			entity.EndDate = Convert.IsDBNull(dataRow["END_DATE"]) ? null : (System.DateTime?)dataRow["END_DATE"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStaff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisStaff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStaff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgCdeStfRoleIdSource	
			if (CanDeepLoad(entity, "PgCdeStfRole|PgCdeStfRoleIdSource", deepLoadType, innerList) 
				&& entity.PgCdeStfRoleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgCdeStfRoleId ?? (int)0);
				PgCdeStfRole tmpEntity = EntityManager.LocateEntity<PgCdeStfRole>(EntityLocator.ConstructKeyFromPkItems(typeof(PgCdeStfRole), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgCdeStfRoleIdSource = tmpEntity;
				else
					entity.PgCdeStfRoleIdSource = DataRepository.PgCdeStfRoleProvider.GetByPgCdeStfRoleId(transactionManager, (entity.PgCdeStfRoleId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgCdeStfRoleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgCdeStfRoleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgCdeStfRoleProvider.DeepLoad(transactionManager, entity.PgCdeStfRoleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgCdeStfRoleIdSource

			#region PgCodeSupervisorChgRsnIdSource	
			if (CanDeepLoad(entity, "PgCodeSupervisorChgRsn|PgCodeSupervisorChgRsnIdSource", deepLoadType, innerList) 
				&& entity.PgCodeSupervisorChgRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgCodeSupervisorChgRsnId ?? (int)0);
				PgCodeSupervisorChgRsn tmpEntity = EntityManager.LocateEntity<PgCodeSupervisorChgRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(PgCodeSupervisorChgRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgCodeSupervisorChgRsnIdSource = tmpEntity;
				else
					entity.PgCodeSupervisorChgRsnIdSource = DataRepository.PgCodeSupervisorChgRsnProvider.GetByPgCodeSupervisorChgRsnId(transactionManager, (entity.PgCodeSupervisorChgRsnId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgCodeSupervisorChgRsnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgCodeSupervisorChgRsnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgCodeSupervisorChgRsnProvider.DeepLoad(transactionManager, entity.PgCodeSupervisorChgRsnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgCodeSupervisorChgRsnIdSource

			#region PgExtMemberIdSource	
			if (CanDeepLoad(entity, "PgExtMember|PgExtMemberIdSource", deepLoadType, innerList) 
				&& entity.PgExtMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgExtMemberId ?? 0.0m);
				PgExtMember tmpEntity = EntityManager.LocateEntity<PgExtMember>(EntityLocator.ConstructKeyFromPkItems(typeof(PgExtMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgExtMemberIdSource = tmpEntity;
				else
					entity.PgExtMemberIdSource = DataRepository.PgExtMemberProvider.GetByPgExtMemberId(transactionManager, (entity.PgExtMemberId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgExtMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgExtMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgExtMemberProvider.DeepLoad(transactionManager, entity.PgExtMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgExtMemberIdSource

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

			#region PgThesisSupervisorCommIdSource	
			if (CanDeepLoad(entity, "PgThesisSupervisorComm|PgThesisSupervisorCommIdSource", deepLoadType, innerList) 
				&& entity.PgThesisSupervisorCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.PgThesisSupervisorCommId ?? 0.0m);
				PgThesisSupervisorComm tmpEntity = EntityManager.LocateEntity<PgThesisSupervisorComm>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisSupervisorComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisSupervisorCommIdSource = tmpEntity;
				else
					entity.PgThesisSupervisorCommIdSource = DataRepository.PgThesisSupervisorCommProvider.GetByPgThesisSupervisorCommId(transactionManager, (entity.PgThesisSupervisorCommId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSupervisorCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisSupervisorCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisSupervisorCommProvider.DeepLoad(transactionManager, entity.PgThesisSupervisorCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisSupervisorCommIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisStaff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisStaff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisStaff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStaff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgCdeStfRoleIdSource
			if (CanDeepSave(entity, "PgCdeStfRole|PgCdeStfRoleIdSource", deepSaveType, innerList) 
				&& entity.PgCdeStfRoleIdSource != null)
			{
				DataRepository.PgCdeStfRoleProvider.Save(transactionManager, entity.PgCdeStfRoleIdSource);
				entity.PgCdeStfRoleId = entity.PgCdeStfRoleIdSource.PgCdeStfRoleId;
			}
			#endregion 
			
			#region PgCodeSupervisorChgRsnIdSource
			if (CanDeepSave(entity, "PgCodeSupervisorChgRsn|PgCodeSupervisorChgRsnIdSource", deepSaveType, innerList) 
				&& entity.PgCodeSupervisorChgRsnIdSource != null)
			{
				DataRepository.PgCodeSupervisorChgRsnProvider.Save(transactionManager, entity.PgCodeSupervisorChgRsnIdSource);
				entity.PgCodeSupervisorChgRsnId = entity.PgCodeSupervisorChgRsnIdSource.PgCodeSupervisorChgRsnId;
			}
			#endregion 
			
			#region PgExtMemberIdSource
			if (CanDeepSave(entity, "PgExtMember|PgExtMemberIdSource", deepSaveType, innerList) 
				&& entity.PgExtMemberIdSource != null)
			{
				DataRepository.PgExtMemberProvider.Save(transactionManager, entity.PgExtMemberIdSource);
				entity.PgExtMemberId = entity.PgExtMemberIdSource.PgExtMemberId;
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
			
			#region PgThesisSupervisorCommIdSource
			if (CanDeepSave(entity, "PgThesisSupervisorComm|PgThesisSupervisorCommIdSource", deepSaveType, innerList) 
				&& entity.PgThesisSupervisorCommIdSource != null)
			{
				DataRepository.PgThesisSupervisorCommProvider.Save(transactionManager, entity.PgThesisSupervisorCommIdSource);
				entity.PgThesisSupervisorCommId = entity.PgThesisSupervisorCommIdSource.PgThesisSupervisorCommId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region PgThesisStaffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisStaff</c>
	///</summary>
	public enum PgThesisStaffChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgCdeStfRole</c> at PgCdeStfRoleIdSource
		///</summary>
		[ChildEntityType(typeof(PgCdeStfRole))]
		PgCdeStfRole,
		
		///<summary>
		/// Composite Property for <c>PgCodeSupervisorChgRsn</c> at PgCodeSupervisorChgRsnIdSource
		///</summary>
		[ChildEntityType(typeof(PgCodeSupervisorChgRsn))]
		PgCodeSupervisorChgRsn,
		
		///<summary>
		/// Composite Property for <c>PgExtMember</c> at PgExtMemberIdSource
		///</summary>
		[ChildEntityType(typeof(PgExtMember))]
		PgExtMember,
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		
		///<summary>
		/// Composite Property for <c>PgThesisSupervisorComm</c> at PgThesisSupervisorCommIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisSupervisorComm))]
		PgThesisSupervisorComm,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion PgThesisStaffChildEntityTypes
	
	#region PgThesisStaffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisStaffFilterBuilder : SqlFilterBuilder<PgThesisStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStaffFilterBuilder class.
		/// </summary>
		public PgThesisStaffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisStaffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisStaffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisStaffFilterBuilder
	
	#region PgThesisStaffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisStaffParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStaffParameterBuilder class.
		/// </summary>
		public PgThesisStaffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisStaffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisStaffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisStaffParameterBuilder
	
	#region PgThesisStaffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStaff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisStaffSortBuilder : SqlSortBuilder<PgThesisStaffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStaffSqlSortBuilder class.
		/// </summary>
		public PgThesisStaffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisStaffSortBuilder
	
} // end namespace
