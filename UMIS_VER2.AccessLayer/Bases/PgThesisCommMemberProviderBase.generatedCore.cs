﻿#region Using directives

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
	/// This class is the base class for any <see cref="PgThesisCommMemberProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisCommMemberProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisCommMember, UMIS_VER2.BusinessLyer.PgThesisCommMemberKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommMemberKey key)
		{
			return Delete(transactionManager, key.PgThesisCommMemberId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisCommMemberId">اعضاء لجنة المناقشة والحكم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisCommMemberId)
		{
			return Delete(null, _pgThesisCommMemberId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommMemberId">اعضاء لجنة المناقشة والحكم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisCommMemberId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CDE_STF_ROLE key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgCdeStfRoleId(System.Int32 _pgCdeStfRoleId)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(_pgCdeStfRoleId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CDE_STF_ROLE key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommMember> GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32 _pgCdeStfRoleId)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(transactionManager, _pgCdeStfRoleId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CDE_STF_ROLE key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32 _pgCdeStfRoleId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(transactionManager, _pgCdeStfRoleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CDE_STF_ROLE key.
		///		fkPgThesisCommMemberPgCdeStfRole Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgCdeStfRoleId(System.Int32 _pgCdeStfRoleId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgCdeStfRoleId(null, _pgCdeStfRoleId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CDE_STF_ROLE key.
		///		fkPgThesisCommMemberPgCdeStfRole Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgCdeStfRoleId(System.Int32 _pgCdeStfRoleId, int start, int pageLength,out int count)
		{
			return GetByPgCdeStfRoleId(null, _pgCdeStfRoleId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CDE_STF_ROLE key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_CDE_STF_ROLE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public abstract TList<PgThesisCommMember> GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32 _pgCdeStfRoleId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_CODE_SUPERVISOR_CHG_RSN Description: 
		/// </summary>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgCodeSupervisorChgRsnId(System.Int32? _pgCodeSupervisorChgRsnId)
		{
			int count = -1;
			return GetByPgCodeSupervisorChgRsnId(_pgCodeSupervisorChgRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_CODE_SUPERVISOR_CHG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommMember> GetByPgCodeSupervisorChgRsnId(TransactionManager transactionManager, System.Int32? _pgCodeSupervisorChgRsnId)
		{
			int count = -1;
			return GetByPgCodeSupervisorChgRsnId(transactionManager, _pgCodeSupervisorChgRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_CODE_SUPERVISOR_CHG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgCodeSupervisorChgRsnId(TransactionManager transactionManager, System.Int32? _pgCodeSupervisorChgRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCodeSupervisorChgRsnId(transactionManager, _pgCodeSupervisorChgRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		fkPgThesisCommMemberPgCodeSupervisorChgRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgCodeSupervisorChgRsnId(System.Int32? _pgCodeSupervisorChgRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgCodeSupervisorChgRsnId(null, _pgCodeSupervisorChgRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		fkPgThesisCommMemberPgCodeSupervisorChgRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgCodeSupervisorChgRsnId(System.Int32? _pgCodeSupervisorChgRsnId, int start, int pageLength,out int count)
		{
			return GetByPgCodeSupervisorChgRsnId(null, _pgCodeSupervisorChgRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_CODE_SUPERVISOR_CHG_RSN key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_CODE_SUPERVISOR_CHG_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCodeSupervisorChgRsnId">كود سبب تعديل المشرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public abstract TList<PgThesisCommMember> GetByPgCodeSupervisorChgRsnId(TransactionManager transactionManager, System.Int32? _pgCodeSupervisorChgRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_EXT_MEMBER key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_EXT_MEMBER Description: 
		/// </summary>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgExtMemberId(System.Decimal? _pgExtMemberId)
		{
			int count = -1;
			return GetByPgExtMemberId(_pgExtMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_EXT_MEMBER key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_EXT_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommMember> GetByPgExtMemberId(TransactionManager transactionManager, System.Decimal? _pgExtMemberId)
		{
			int count = -1;
			return GetByPgExtMemberId(transactionManager, _pgExtMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_EXT_MEMBER key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_EXT_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgExtMemberId(TransactionManager transactionManager, System.Decimal? _pgExtMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgExtMemberId(transactionManager, _pgExtMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_EXT_MEMBER key.
		///		fkPgThesisCommMemberPgExtMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgExtMemberId(System.Decimal? _pgExtMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgExtMemberId(null, _pgExtMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_EXT_MEMBER key.
		///		fkPgThesisCommMemberPgExtMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgExtMemberId(System.Decimal? _pgExtMemberId, int start, int pageLength,out int count)
		{
			return GetByPgExtMemberId(null, _pgExtMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_EXT_MEMBER key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_EXT_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgExtMemberId">مسلسل مشرف/محكم خارجى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public abstract TList<PgThesisCommMember> GetByPgExtMemberId(TransactionManager transactionManager, System.Decimal? _pgExtMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgThesisCommId(System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(_pgThesisCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommMember> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_THESIS_COMM key.
		///		fkPgThesisCommMemberPgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_THESIS_COMM key.
		///		fkPgThesisCommMemberPgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_MEMBER_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public abstract TList<PgThesisCommMember> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_SA_STF_MEMBER key.
		///		FK_PG_THESIS_COMM_MEMBER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId">داخلي  يتم الاختيار من اعضاء هيئه التدريس</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_SA_STF_MEMBER key.
		///		FK_PG_THESIS_COMM_MEMBER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">داخلي  يتم الاختيار من اعضاء هيئه التدريس</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_SA_STF_MEMBER key.
		///		FK_PG_THESIS_COMM_MEMBER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">داخلي  يتم الاختيار من اعضاء هيئه التدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_SA_STF_MEMBER key.
		///		fkPgThesisCommMemberSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId">داخلي  يتم الاختيار من اعضاء هيئه التدريس</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_SA_STF_MEMBER key.
		///		fkPgThesisCommMemberSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId">داخلي  يتم الاختيار من اعضاء هيئه التدريس</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public TList<PgThesisCommMember> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_MEMBER_SA_STF_MEMBER key.
		///		FK_PG_THESIS_COMM_MEMBER_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">داخلي  يتم الاختيار من اعضاء هيئه التدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommMember objects.</returns>
		public abstract TList<PgThesisCommMember> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisCommMember Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommMemberKey key, int start, int pageLength)
		{
			return GetByPgThesisCommMemberId(transactionManager, key.PgThesisCommMemberId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_COMM_MEMBER index.
		/// </summary>
		/// <param name="_pgThesisCommMemberId">اعضاء لجنة المناقشة والحكم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommMember GetByPgThesisCommMemberId(System.Decimal _pgThesisCommMemberId)
		{
			int count = -1;
			return GetByPgThesisCommMemberId(null,_pgThesisCommMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_MEMBER index.
		/// </summary>
		/// <param name="_pgThesisCommMemberId">اعضاء لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommMember GetByPgThesisCommMemberId(System.Decimal _pgThesisCommMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommMemberId(null, _pgThesisCommMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommMemberId">اعضاء لجنة المناقشة والحكم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommMember GetByPgThesisCommMemberId(TransactionManager transactionManager, System.Decimal _pgThesisCommMemberId)
		{
			int count = -1;
			return GetByPgThesisCommMemberId(transactionManager, _pgThesisCommMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommMemberId">اعضاء لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommMember GetByPgThesisCommMemberId(TransactionManager transactionManager, System.Decimal _pgThesisCommMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommMemberId(transactionManager, _pgThesisCommMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_MEMBER index.
		/// </summary>
		/// <param name="_pgThesisCommMemberId">اعضاء لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommMember GetByPgThesisCommMemberId(System.Decimal _pgThesisCommMemberId, int start, int pageLength, out int count)
		{
			return GetByPgThesisCommMemberId(null, _pgThesisCommMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_MEMBER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommMemberId">اعضاء لجنة المناقشة والحكم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisCommMember GetByPgThesisCommMemberId(TransactionManager transactionManager, System.Decimal _pgThesisCommMemberId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisCommMember&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisCommMember&gt;"/></returns>
		public static TList<PgThesisCommMember> Fill(IDataReader reader, TList<PgThesisCommMember> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisCommMember c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisCommMember")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_COMM_MEMBER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisCommMember>(
					key.ToString(), // EntityTrackingKey
					"PgThesisCommMember",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisCommMember();
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
					c.PgThesisCommMemberId = (System.Decimal)reader["PG_THESIS_COMM_MEMBER_ID"];
					c.OriginalPgThesisCommMemberId = c.PgThesisCommMemberId;
					c.PgThesisCommId = (System.Decimal)reader["PG_THESIS_COMM_ID"];
					c.MemberTypeFlg = Convert.IsDBNull(reader["MEMBER_TYPE_FLG"]) ? null : (System.Int16?)reader["MEMBER_TYPE_FLG"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.PgExtMemberId = Convert.IsDBNull(reader["PG_EXT_MEMBER_ID"]) ? null : (System.Decimal?)reader["PG_EXT_MEMBER_ID"];
					c.PgCdeStfRoleId = (System.Int32)reader["PG_CDE_STF_ROLE_ID"];
					c.StartDate = Convert.IsDBNull(reader["START_DATE"]) ? null : (System.DateTime?)reader["START_DATE"];
					c.EndDate = Convert.IsDBNull(reader["END_DATE"]) ? null : (System.DateTime?)reader["END_DATE"];
					c.PgCodeSupervisorChgRsnId = Convert.IsDBNull(reader["PG_CODE_SUPERVISOR_CHG_RSN_ID"]) ? null : (System.Int32?)reader["PG_CODE_SUPERVISOR_CHG_RSN_ID"];
					c.MemberNameAr = Convert.IsDBNull(reader["MEMBER_NAME_AR"]) ? null : (System.String)reader["MEMBER_NAME_AR"];
					c.MemberNameEn = Convert.IsDBNull(reader["MEMBER_NAME_EN"]) ? null : (System.String)reader["MEMBER_NAME_EN"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisCommMember entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisCommMemberId = (System.Decimal)reader[((int)PgThesisCommMemberColumn.PgThesisCommMemberId - 1)];
			entity.OriginalPgThesisCommMemberId = (System.Decimal)reader["PG_THESIS_COMM_MEMBER_ID"];
			entity.PgThesisCommId = (System.Decimal)reader[((int)PgThesisCommMemberColumn.PgThesisCommId - 1)];
			entity.MemberTypeFlg = (reader.IsDBNull(((int)PgThesisCommMemberColumn.MemberTypeFlg - 1)))?null:(System.Int16?)reader[((int)PgThesisCommMemberColumn.MemberTypeFlg - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)PgThesisCommMemberColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)PgThesisCommMemberColumn.SaStfMemberId - 1)];
			entity.PgExtMemberId = (reader.IsDBNull(((int)PgThesisCommMemberColumn.PgExtMemberId - 1)))?null:(System.Decimal?)reader[((int)PgThesisCommMemberColumn.PgExtMemberId - 1)];
			entity.PgCdeStfRoleId = (System.Int32)reader[((int)PgThesisCommMemberColumn.PgCdeStfRoleId - 1)];
			entity.StartDate = (reader.IsDBNull(((int)PgThesisCommMemberColumn.StartDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommMemberColumn.StartDate - 1)];
			entity.EndDate = (reader.IsDBNull(((int)PgThesisCommMemberColumn.EndDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommMemberColumn.EndDate - 1)];
			entity.PgCodeSupervisorChgRsnId = (reader.IsDBNull(((int)PgThesisCommMemberColumn.PgCodeSupervisorChgRsnId - 1)))?null:(System.Int32?)reader[((int)PgThesisCommMemberColumn.PgCodeSupervisorChgRsnId - 1)];
			entity.MemberNameAr = (reader.IsDBNull(((int)PgThesisCommMemberColumn.MemberNameAr - 1)))?null:(System.String)reader[((int)PgThesisCommMemberColumn.MemberNameAr - 1)];
			entity.MemberNameEn = (reader.IsDBNull(((int)PgThesisCommMemberColumn.MemberNameEn - 1)))?null:(System.String)reader[((int)PgThesisCommMemberColumn.MemberNameEn - 1)];
			entity.IsActive = (reader.IsDBNull(((int)PgThesisCommMemberColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)PgThesisCommMemberColumn.IsActive - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisCommMemberColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommMemberColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisCommMemberColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisCommMemberColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisCommMember entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisCommMemberId = (System.Decimal)dataRow["PG_THESIS_COMM_MEMBER_ID"];
			entity.OriginalPgThesisCommMemberId = (System.Decimal)dataRow["PG_THESIS_COMM_MEMBER_ID"];
			entity.PgThesisCommId = (System.Decimal)dataRow["PG_THESIS_COMM_ID"];
			entity.MemberTypeFlg = Convert.IsDBNull(dataRow["MEMBER_TYPE_FLG"]) ? null : (System.Int16?)dataRow["MEMBER_TYPE_FLG"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.PgExtMemberId = Convert.IsDBNull(dataRow["PG_EXT_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["PG_EXT_MEMBER_ID"];
			entity.PgCdeStfRoleId = (System.Int32)dataRow["PG_CDE_STF_ROLE_ID"];
			entity.StartDate = Convert.IsDBNull(dataRow["START_DATE"]) ? null : (System.DateTime?)dataRow["START_DATE"];
			entity.EndDate = Convert.IsDBNull(dataRow["END_DATE"]) ? null : (System.DateTime?)dataRow["END_DATE"];
			entity.PgCodeSupervisorChgRsnId = Convert.IsDBNull(dataRow["PG_CODE_SUPERVISOR_CHG_RSN_ID"]) ? null : (System.Int32?)dataRow["PG_CODE_SUPERVISOR_CHG_RSN_ID"];
			entity.MemberNameAr = Convert.IsDBNull(dataRow["MEMBER_NAME_AR"]) ? null : (System.String)dataRow["MEMBER_NAME_AR"];
			entity.MemberNameEn = Convert.IsDBNull(dataRow["MEMBER_NAME_EN"]) ? null : (System.String)dataRow["MEMBER_NAME_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommMember"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisCommMember Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommMember entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgCdeStfRoleIdSource	
			if (CanDeepLoad(entity, "PgCdeStfRole|PgCdeStfRoleIdSource", deepLoadType, innerList) 
				&& entity.PgCdeStfRoleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgCdeStfRoleId;
				PgCdeStfRole tmpEntity = EntityManager.LocateEntity<PgCdeStfRole>(EntityLocator.ConstructKeyFromPkItems(typeof(PgCdeStfRole), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgCdeStfRoleIdSource = tmpEntity;
				else
					entity.PgCdeStfRoleIdSource = DataRepository.PgCdeStfRoleProvider.GetByPgCdeStfRoleId(transactionManager, entity.PgCdeStfRoleId);		
				
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

			#region PgThesisCommIdSource	
			if (CanDeepLoad(entity, "PgThesisComm|PgThesisCommIdSource", deepLoadType, innerList) 
				&& entity.PgThesisCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisCommId;
				PgThesisComm tmpEntity = EntityManager.LocateEntity<PgThesisComm>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisCommIdSource = tmpEntity;
				else
					entity.PgThesisCommIdSource = DataRepository.PgThesisCommProvider.GetByPgThesisCommId(transactionManager, entity.PgThesisCommId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisCommProvider.DeepLoad(transactionManager, entity.PgThesisCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisCommIdSource

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
			// Deep load child collections  - Call GetByPgThesisCommMemberId methods when available
			
			#region PgThesisCommRptCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisCommRpt>|PgThesisCommRptCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommRptCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommRptCollection = DataRepository.PgThesisCommRptProvider.GetByPgThesisCommMemberId(transactionManager, entity.PgThesisCommMemberId);

				if (deep && entity.PgThesisCommRptCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommRptCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommRpt>) DataRepository.PgThesisCommRptProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommRptCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisCommMember object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisCommMember instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisCommMember Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommMember entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region PgThesisCommIdSource
			if (CanDeepSave(entity, "PgThesisComm|PgThesisCommIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommIdSource != null)
			{
				DataRepository.PgThesisCommProvider.Save(transactionManager, entity.PgThesisCommIdSource);
				entity.PgThesisCommId = entity.PgThesisCommIdSource.PgThesisCommId;
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
	
			#region List<PgThesisCommRpt>
				if (CanDeepSave(entity.PgThesisCommRptCollection, "List<PgThesisCommRpt>|PgThesisCommRptCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisCommRpt child in entity.PgThesisCommRptCollection)
					{
						if(child.PgThesisCommMemberIdSource != null)
						{
							child.PgThesisCommMemberId = child.PgThesisCommMemberIdSource.PgThesisCommMemberId;
						}
						else
						{
							child.PgThesisCommMemberId = entity.PgThesisCommMemberId;
						}

					}

					if (entity.PgThesisCommRptCollection.Count > 0 || entity.PgThesisCommRptCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommRptProvider.Save(transactionManager, entity.PgThesisCommRptCollection);
						
						deepHandles.Add("PgThesisCommRptCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisCommRpt >) DataRepository.PgThesisCommRptProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommRptCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgThesisCommMemberChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisCommMember</c>
	///</summary>
	public enum PgThesisCommMemberChildEntityTypes
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
		/// Composite Property for <c>PgThesisComm</c> at PgThesisCommIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisComm))]
		PgThesisComm,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		///<summary>
		/// Collection of <c>PgThesisCommMember</c> as OneToMany for PgThesisCommRptCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommRpt>))]
		PgThesisCommRptCollection,
	}
	
	#endregion PgThesisCommMemberChildEntityTypes
	
	#region PgThesisCommMemberFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisCommMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisCommMemberFilterBuilder : SqlFilterBuilder<PgThesisCommMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommMemberFilterBuilder class.
		/// </summary>
		public PgThesisCommMemberFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisCommMemberFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommMemberFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisCommMemberFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisCommMemberFilterBuilder
	
	#region PgThesisCommMemberParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisCommMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommMember"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisCommMemberParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisCommMemberColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommMemberParameterBuilder class.
		/// </summary>
		public PgThesisCommMemberParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisCommMemberParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommMemberParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisCommMemberParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisCommMemberParameterBuilder
	
	#region PgThesisCommMemberSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisCommMemberColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommMember"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisCommMemberSortBuilder : SqlSortBuilder<PgThesisCommMemberColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommMemberSqlSortBuilder class.
		/// </summary>
		public PgThesisCommMemberSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisCommMemberSortBuilder
	
} // end namespace