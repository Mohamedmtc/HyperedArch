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
	/// This class is the base class for any <see cref="SaPunishmentProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaPunishmentProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaPunishment, UMIS_VER2.BusinessLyer.SaPunishmentKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishmentKey key)
		{
			return Delete(transactionManager, key.SaPunishmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saPunishmentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saPunishmentId)
		{
			return Delete(null, _saPunishmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saPunishmentId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0024 key.
		///		FK_AUTO_0024 Description: 
		/// </summary>
		/// <param name="_saCodePunishRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaCodePunishRsnId(System.Decimal _saCodePunishRsnId)
		{
			int count = -1;
			return GetBySaCodePunishRsnId(_saCodePunishRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0024 key.
		///		FK_AUTO_0024 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishRsnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		/// <remarks></remarks>
		public TList<SaPunishment> GetBySaCodePunishRsnId(TransactionManager transactionManager, System.Decimal _saCodePunishRsnId)
		{
			int count = -1;
			return GetBySaCodePunishRsnId(transactionManager, _saCodePunishRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0024 key.
		///		FK_AUTO_0024 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaCodePunishRsnId(TransactionManager transactionManager, System.Decimal _saCodePunishRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodePunishRsnId(transactionManager, _saCodePunishRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0024 key.
		///		fkAuto0024 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodePunishRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaCodePunishRsnId(System.Decimal _saCodePunishRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodePunishRsnId(null, _saCodePunishRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0024 key.
		///		fkAuto0024 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodePunishRsnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaCodePunishRsnId(System.Decimal _saCodePunishRsnId, int start, int pageLength,out int count)
		{
			return GetBySaCodePunishRsnId(null, _saCodePunishRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0024 key.
		///		FK_AUTO_0024 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public abstract TList<SaPunishment> GetBySaCodePunishRsnId(TransactionManager transactionManager, System.Decimal _saCodePunishRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_AS_FACULTY_INFO key.
		///		FK_SA_PUNISHMENT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_AS_FACULTY_INFO key.
		///		FK_SA_PUNISHMENT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		/// <remarks></remarks>
		public TList<SaPunishment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_AS_FACULTY_INFO key.
		///		FK_SA_PUNISHMENT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_AS_FACULTY_INFO key.
		///		fkSaPunishmentAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_AS_FACULTY_INFO key.
		///		fkSaPunishmentAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_AS_FACULTY_INFO key.
		///		FK_SA_PUNISHMENT_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public abstract TList<SaPunishment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_GS_APPROVAL_H key.
		///		FK_SA_PUNISHMENT_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetByGsApprovalHId(System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(_gsApprovalHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_GS_APPROVAL_H key.
		///		FK_SA_PUNISHMENT_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		/// <remarks></remarks>
		public TList<SaPunishment> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_GS_APPROVAL_H key.
		///		FK_SA_PUNISHMENT_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_GS_APPROVAL_H key.
		///		fkSaPunishmentGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_GS_APPROVAL_H key.
		///		fkSaPunishmentGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength,out int count)
		{
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_GS_APPROVAL_H key.
		///		FK_SA_PUNISHMENT_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public abstract TList<SaPunishment> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_PUNISH_BYLAW_AUTH key.
		///		FK_SA_PUNISHMENT_SA_PUNISH_BYLAW_AUTH Description: 
		/// </summary>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaPunishBylawAuthId(System.Decimal _saPunishBylawAuthId)
		{
			int count = -1;
			return GetBySaPunishBylawAuthId(_saPunishBylawAuthId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_PUNISH_BYLAW_AUTH key.
		///		FK_SA_PUNISHMENT_SA_PUNISH_BYLAW_AUTH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		/// <remarks></remarks>
		public TList<SaPunishment> GetBySaPunishBylawAuthId(TransactionManager transactionManager, System.Decimal _saPunishBylawAuthId)
		{
			int count = -1;
			return GetBySaPunishBylawAuthId(transactionManager, _saPunishBylawAuthId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_PUNISH_BYLAW_AUTH key.
		///		FK_SA_PUNISHMENT_SA_PUNISH_BYLAW_AUTH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaPunishBylawAuthId(TransactionManager transactionManager, System.Decimal _saPunishBylawAuthId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPunishBylawAuthId(transactionManager, _saPunishBylawAuthId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_PUNISH_BYLAW_AUTH key.
		///		fkSaPunishmentSaPunishBylawAuth Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaPunishBylawAuthId(System.Decimal _saPunishBylawAuthId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaPunishBylawAuthId(null, _saPunishBylawAuthId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_PUNISH_BYLAW_AUTH key.
		///		fkSaPunishmentSaPunishBylawAuth Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaPunishBylawAuthId(System.Decimal _saPunishBylawAuthId, int start, int pageLength,out int count)
		{
			return GetBySaPunishBylawAuthId(null, _saPunishBylawAuthId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_PUNISH_BYLAW_AUTH key.
		///		FK_SA_PUNISHMENT_SA_PUNISH_BYLAW_AUTH Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public abstract TList<SaPunishment> GetBySaPunishBylawAuthId(TransactionManager transactionManager, System.Decimal _saPunishBylawAuthId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_STF_MEMBER key.
		///		FK_SA_PUNISHMENT_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_STF_MEMBER key.
		///		FK_SA_PUNISHMENT_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		/// <remarks></remarks>
		public TList<SaPunishment> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_STF_MEMBER key.
		///		FK_SA_PUNISHMENT_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_STF_MEMBER key.
		///		fkSaPunishmentSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_STF_MEMBER key.
		///		fkSaPunishmentSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public TList<SaPunishment> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISHMENT_SA_STF_MEMBER key.
		///		FK_SA_PUNISHMENT_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishment objects.</returns>
		public abstract TList<SaPunishment> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaPunishment Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishmentKey key, int start, int pageLength)
		{
			return GetBySaPunishmentId(transactionManager, key.SaPunishmentId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_PUNISHMENT index.
		/// </summary>
		/// <param name="_saPunishmentId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishment GetBySaPunishmentId(System.Decimal _saPunishmentId)
		{
			int count = -1;
			return GetBySaPunishmentId(null,_saPunishmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISHMENT index.
		/// </summary>
		/// <param name="_saPunishmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishment GetBySaPunishmentId(System.Decimal _saPunishmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPunishmentId(null, _saPunishmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISHMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishment GetBySaPunishmentId(TransactionManager transactionManager, System.Decimal _saPunishmentId)
		{
			int count = -1;
			return GetBySaPunishmentId(transactionManager, _saPunishmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISHMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishment GetBySaPunishmentId(TransactionManager transactionManager, System.Decimal _saPunishmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPunishmentId(transactionManager, _saPunishmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISHMENT index.
		/// </summary>
		/// <param name="_saPunishmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishment GetBySaPunishmentId(System.Decimal _saPunishmentId, int start, int pageLength, out int count)
		{
			return GetBySaPunishmentId(null, _saPunishmentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISHMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaPunishment GetBySaPunishmentId(TransactionManager transactionManager, System.Decimal _saPunishmentId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaPunishment&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaPunishment&gt;"/></returns>
		public static TList<SaPunishment> Fill(IDataReader reader, TList<SaPunishment> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaPunishment c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaPunishment")
					.Append("|").Append((System.Decimal)reader["SA_PUNISHMENT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaPunishment>(
					key.ToString(), // EntityTrackingKey
					"SaPunishment",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaPunishment();
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
					c.SaPunishmentId = (System.Decimal)reader["SA_PUNISHMENT_ID"];
					c.OriginalSaPunishmentId = c.SaPunishmentId;
					c.DecisionNum = Convert.IsDBNull(reader["DECISION_NUM"]) ? null : (System.String)reader["DECISION_NUM"];
					c.DecisionDate = Convert.IsDBNull(reader["DECISION_DATE"]) ? null : (System.DateTime?)reader["DECISION_DATE"];
					c.DecisionSumm = Convert.IsDBNull(reader["DECISION_SUMM"]) ? null : (System.String)reader["DECISION_SUMM"];
					c.DaysNum = Convert.IsDBNull(reader["DAYS_NUM"]) ? null : (System.Decimal?)reader["DAYS_NUM"];
					c.PunishDate = (System.DateTime)reader["PUNISH_DATE"];
					c.CaseNum = Convert.IsDBNull(reader["CASE_NUM"]) ? null : (System.String)reader["CASE_NUM"];
					c.EraseDecisionNum = Convert.IsDBNull(reader["ERASE_DECISION_NUM"]) ? null : (System.String)reader["ERASE_DECISION_NUM"];
					c.EraseDecisionDate = Convert.IsDBNull(reader["ERASE_DECISION_DATE"]) ? null : (System.DateTime?)reader["ERASE_DECISION_DATE"];
					c.EraseDate = Convert.IsDBNull(reader["ERASE_DATE"]) ? null : (System.DateTime?)reader["ERASE_DATE"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaCodePunishRsnId = (System.Decimal)reader["SA_CODE_PUNISH_RSN_ID"];
					c.GsApprovalHId = (System.Decimal)reader["GS_APPROVAL_H_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.SaPunishBylawAuthId = (System.Decimal)reader["SA_PUNISH_BYLAW_AUTH_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaPunishment entity)
		{
			if (!reader.Read()) return;
			
			entity.SaPunishmentId = (System.Decimal)reader[((int)SaPunishmentColumn.SaPunishmentId - 1)];
			entity.OriginalSaPunishmentId = (System.Decimal)reader["SA_PUNISHMENT_ID"];
			entity.DecisionNum = (reader.IsDBNull(((int)SaPunishmentColumn.DecisionNum - 1)))?null:(System.String)reader[((int)SaPunishmentColumn.DecisionNum - 1)];
			entity.DecisionDate = (reader.IsDBNull(((int)SaPunishmentColumn.DecisionDate - 1)))?null:(System.DateTime?)reader[((int)SaPunishmentColumn.DecisionDate - 1)];
			entity.DecisionSumm = (reader.IsDBNull(((int)SaPunishmentColumn.DecisionSumm - 1)))?null:(System.String)reader[((int)SaPunishmentColumn.DecisionSumm - 1)];
			entity.DaysNum = (reader.IsDBNull(((int)SaPunishmentColumn.DaysNum - 1)))?null:(System.Decimal?)reader[((int)SaPunishmentColumn.DaysNum - 1)];
			entity.PunishDate = (System.DateTime)reader[((int)SaPunishmentColumn.PunishDate - 1)];
			entity.CaseNum = (reader.IsDBNull(((int)SaPunishmentColumn.CaseNum - 1)))?null:(System.String)reader[((int)SaPunishmentColumn.CaseNum - 1)];
			entity.EraseDecisionNum = (reader.IsDBNull(((int)SaPunishmentColumn.EraseDecisionNum - 1)))?null:(System.String)reader[((int)SaPunishmentColumn.EraseDecisionNum - 1)];
			entity.EraseDecisionDate = (reader.IsDBNull(((int)SaPunishmentColumn.EraseDecisionDate - 1)))?null:(System.DateTime?)reader[((int)SaPunishmentColumn.EraseDecisionDate - 1)];
			entity.EraseDate = (reader.IsDBNull(((int)SaPunishmentColumn.EraseDate - 1)))?null:(System.DateTime?)reader[((int)SaPunishmentColumn.EraseDate - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaPunishmentColumn.Comments - 1)))?null:(System.String)reader[((int)SaPunishmentColumn.Comments - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaPunishmentColumn.SaStfMemberId - 1)];
			entity.SaCodePunishRsnId = (System.Decimal)reader[((int)SaPunishmentColumn.SaCodePunishRsnId - 1)];
			entity.GsApprovalHId = (System.Decimal)reader[((int)SaPunishmentColumn.GsApprovalHId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaPunishmentColumn.AsFacultyInfoId - 1)];
			entity.SaPunishBylawAuthId = (System.Decimal)reader[((int)SaPunishmentColumn.SaPunishBylawAuthId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaPunishment entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaPunishmentId = (System.Decimal)dataRow["SA_PUNISHMENT_ID"];
			entity.OriginalSaPunishmentId = (System.Decimal)dataRow["SA_PUNISHMENT_ID"];
			entity.DecisionNum = Convert.IsDBNull(dataRow["DECISION_NUM"]) ? null : (System.String)dataRow["DECISION_NUM"];
			entity.DecisionDate = Convert.IsDBNull(dataRow["DECISION_DATE"]) ? null : (System.DateTime?)dataRow["DECISION_DATE"];
			entity.DecisionSumm = Convert.IsDBNull(dataRow["DECISION_SUMM"]) ? null : (System.String)dataRow["DECISION_SUMM"];
			entity.DaysNum = Convert.IsDBNull(dataRow["DAYS_NUM"]) ? null : (System.Decimal?)dataRow["DAYS_NUM"];
			entity.PunishDate = (System.DateTime)dataRow["PUNISH_DATE"];
			entity.CaseNum = Convert.IsDBNull(dataRow["CASE_NUM"]) ? null : (System.String)dataRow["CASE_NUM"];
			entity.EraseDecisionNum = Convert.IsDBNull(dataRow["ERASE_DECISION_NUM"]) ? null : (System.String)dataRow["ERASE_DECISION_NUM"];
			entity.EraseDecisionDate = Convert.IsDBNull(dataRow["ERASE_DECISION_DATE"]) ? null : (System.DateTime?)dataRow["ERASE_DECISION_DATE"];
			entity.EraseDate = Convert.IsDBNull(dataRow["ERASE_DATE"]) ? null : (System.DateTime?)dataRow["ERASE_DATE"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodePunishRsnId = (System.Decimal)dataRow["SA_CODE_PUNISH_RSN_ID"];
			entity.GsApprovalHId = (System.Decimal)dataRow["GS_APPROVAL_H_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.SaPunishBylawAuthId = (System.Decimal)dataRow["SA_PUNISH_BYLAW_AUTH_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPunishment"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPunishment Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishment entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodePunishRsnIdSource	
			if (CanDeepLoad(entity, "SaCodePunishRsn|SaCodePunishRsnIdSource", deepLoadType, innerList) 
				&& entity.SaCodePunishRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodePunishRsnId;
				SaCodePunishRsn tmpEntity = EntityManager.LocateEntity<SaCodePunishRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodePunishRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodePunishRsnIdSource = tmpEntity;
				else
					entity.SaCodePunishRsnIdSource = DataRepository.SaCodePunishRsnProvider.GetBySaCodePunishRsnId(transactionManager, entity.SaCodePunishRsnId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodePunishRsnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodePunishRsnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodePunishRsnProvider.DeepLoad(transactionManager, entity.SaCodePunishRsnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodePunishRsnIdSource

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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

			#region GsApprovalHIdSource	
			if (CanDeepLoad(entity, "GsApprovalH|GsApprovalHIdSource", deepLoadType, innerList) 
				&& entity.GsApprovalHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsApprovalHId;
				GsApprovalH tmpEntity = EntityManager.LocateEntity<GsApprovalH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsApprovalH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsApprovalHIdSource = tmpEntity;
				else
					entity.GsApprovalHIdSource = DataRepository.GsApprovalHProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsApprovalHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsApprovalHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsApprovalHProvider.DeepLoad(transactionManager, entity.GsApprovalHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsApprovalHIdSource

			#region SaPunishBylawAuthIdSource	
			if (CanDeepLoad(entity, "SaPunishBylawAuth|SaPunishBylawAuthIdSource", deepLoadType, innerList) 
				&& entity.SaPunishBylawAuthIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaPunishBylawAuthId;
				SaPunishBylawAuth tmpEntity = EntityManager.LocateEntity<SaPunishBylawAuth>(EntityLocator.ConstructKeyFromPkItems(typeof(SaPunishBylawAuth), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaPunishBylawAuthIdSource = tmpEntity;
				else
					entity.SaPunishBylawAuthIdSource = DataRepository.SaPunishBylawAuthProvider.GetBySaPunishBylawAuthId(transactionManager, entity.SaPunishBylawAuthId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishBylawAuthIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaPunishBylawAuthIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaPunishBylawAuthProvider.DeepLoad(transactionManager, entity.SaPunishBylawAuthIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaPunishBylawAuthIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaPunishment object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaPunishment instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPunishment Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishment entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodePunishRsnIdSource
			if (CanDeepSave(entity, "SaCodePunishRsn|SaCodePunishRsnIdSource", deepSaveType, innerList) 
				&& entity.SaCodePunishRsnIdSource != null)
			{
				DataRepository.SaCodePunishRsnProvider.Save(transactionManager, entity.SaCodePunishRsnIdSource);
				entity.SaCodePunishRsnId = entity.SaCodePunishRsnIdSource.SaCodePunishRsnId;
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
			
			#region GsApprovalHIdSource
			if (CanDeepSave(entity, "GsApprovalH|GsApprovalHIdSource", deepSaveType, innerList) 
				&& entity.GsApprovalHIdSource != null)
			{
				DataRepository.GsApprovalHProvider.Save(transactionManager, entity.GsApprovalHIdSource);
				entity.GsApprovalHId = entity.GsApprovalHIdSource.GsApprovalHId;
			}
			#endregion 
			
			#region SaPunishBylawAuthIdSource
			if (CanDeepSave(entity, "SaPunishBylawAuth|SaPunishBylawAuthIdSource", deepSaveType, innerList) 
				&& entity.SaPunishBylawAuthIdSource != null)
			{
				DataRepository.SaPunishBylawAuthProvider.Save(transactionManager, entity.SaPunishBylawAuthIdSource);
				entity.SaPunishBylawAuthId = entity.SaPunishBylawAuthIdSource.SaPunishBylawAuthId;
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
	
	#region SaPunishmentChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaPunishment</c>
	///</summary>
	public enum SaPunishmentChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodePunishRsn</c> at SaCodePunishRsnIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodePunishRsn))]
		SaCodePunishRsn,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>GsApprovalH</c> at GsApprovalHIdSource
		///</summary>
		[ChildEntityType(typeof(GsApprovalH))]
		GsApprovalH,
		
		///<summary>
		/// Composite Property for <c>SaPunishBylawAuth</c> at SaPunishBylawAuthIdSource
		///</summary>
		[ChildEntityType(typeof(SaPunishBylawAuth))]
		SaPunishBylawAuth,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion SaPunishmentChildEntityTypes
	
	#region SaPunishmentFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaPunishmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPunishment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPunishmentFilterBuilder : SqlFilterBuilder<SaPunishmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPunishmentFilterBuilder class.
		/// </summary>
		public SaPunishmentFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPunishmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPunishmentFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPunishmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPunishmentFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPunishmentFilterBuilder
	
	#region SaPunishmentParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaPunishmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPunishment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPunishmentParameterBuilder : ParameterizedSqlFilterBuilder<SaPunishmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPunishmentParameterBuilder class.
		/// </summary>
		public SaPunishmentParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPunishmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPunishmentParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPunishmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPunishmentParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPunishmentParameterBuilder
	
	#region SaPunishmentSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaPunishmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPunishment"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaPunishmentSortBuilder : SqlSortBuilder<SaPunishmentColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPunishmentSqlSortBuilder class.
		/// </summary>
		public SaPunishmentSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaPunishmentSortBuilder
	
} // end namespace
