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
	/// This class is the base class for any <see cref="SaVacationProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaVacationProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaVacation, UMIS_VER2.BusinessLyer.SaVacationKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationKey key)
		{
			return Delete(transactionManager, key.SaVacationId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saVacationId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saVacationId)
		{
			return Delete(null, _saVacationId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saVacationId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002e key.
		///		FK_AUTO_002e Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002e key.
		///		FK_AUTO_002e Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacation> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002e key.
		///		FK_AUTO_002e Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002e key.
		///		fkAuto002e Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002e key.
		///		fkAuto002e Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002e key.
		///		FK_AUTO_002e Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public abstract TList<SaVacation> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_GS_APPROVAL_H key.
		///		FK_SA_VACATION_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetByGsApprovalHId(System.Decimal? _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(_gsApprovalHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_GS_APPROVAL_H key.
		///		FK_SA_VACATION_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacation> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_GS_APPROVAL_H key.
		///		FK_SA_VACATION_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_GS_APPROVAL_H key.
		///		fkSaVacationGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetByGsApprovalHId(System.Decimal? _gsApprovalHId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_GS_APPROVAL_H key.
		///		fkSaVacationGsApprovalH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetByGsApprovalHId(System.Decimal? _gsApprovalHId, int start, int pageLength,out int count)
		{
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_GS_APPROVAL_H key.
		///		FK_SA_VACATION_GS_APPROVAL_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public abstract TList<SaVacation> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal? _gsApprovalHId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_JOB_START_STATMENT key.
		///		FK_SA_VACATION_SA_JOB_START_STATMENT Description: 
		/// </summary>
		/// <param name="_saJobStartStatmentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaJobStartStatmentId(System.Decimal? _saJobStartStatmentId)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(_saJobStartStatmentId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_JOB_START_STATMENT key.
		///		FK_SA_VACATION_SA_JOB_START_STATMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacation> GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal? _saJobStartStatmentId)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(transactionManager, _saJobStartStatmentId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_JOB_START_STATMENT key.
		///		FK_SA_VACATION_SA_JOB_START_STATMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal? _saJobStartStatmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(transactionManager, _saJobStartStatmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_JOB_START_STATMENT key.
		///		fkSaVacationSaJobStartStatment Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaJobStartStatmentId(System.Decimal? _saJobStartStatmentId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaJobStartStatmentId(null, _saJobStartStatmentId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_JOB_START_STATMENT key.
		///		fkSaVacationSaJobStartStatment Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaJobStartStatmentId(System.Decimal? _saJobStartStatmentId, int start, int pageLength,out int count)
		{
			return GetBySaJobStartStatmentId(null, _saJobStartStatmentId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_JOB_START_STATMENT key.
		///		FK_SA_VACATION_SA_JOB_START_STATMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public abstract TList<SaVacation> GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal? _saJobStartStatmentId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_STF_MEMBER key.
		///		FK_SA_VACATION_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_STF_MEMBER key.
		///		FK_SA_VACATION_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacation> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_STF_MEMBER key.
		///		FK_SA_VACATION_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_STF_MEMBER key.
		///		fkSaVacationSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_STF_MEMBER key.
		///		fkSaVacationSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_STF_MEMBER key.
		///		FK_SA_VACATION_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public abstract TList<SaVacation> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="_saVacationBylawsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaVacationBylawsId(System.Decimal _saVacationBylawsId)
		{
			int count = -1;
			return GetBySaVacationBylawsId(_saVacationBylawsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacation> GetBySaVacationBylawsId(TransactionManager transactionManager, System.Decimal _saVacationBylawsId)
		{
			int count = -1;
			return GetBySaVacationBylawsId(transactionManager, _saVacationBylawsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaVacationBylawsId(TransactionManager transactionManager, System.Decimal _saVacationBylawsId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBylawsId(transactionManager, _saVacationBylawsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_VACATION_BYLAWS key.
		///		fkSaVacationSaVacationBylaws Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaVacationBylawsId(System.Decimal _saVacationBylawsId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaVacationBylawsId(null, _saVacationBylawsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_VACATION_BYLAWS key.
		///		fkSaVacationSaVacationBylaws Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public TList<SaVacation> GetBySaVacationBylawsId(System.Decimal _saVacationBylawsId, int start, int pageLength,out int count)
		{
			return GetBySaVacationBylawsId(null, _saVacationBylawsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacation objects.</returns>
		public abstract TList<SaVacation> GetBySaVacationBylawsId(TransactionManager transactionManager, System.Decimal _saVacationBylawsId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaVacation Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationKey key, int start, int pageLength)
		{
			return GetBySaVacationId(transactionManager, key.SaVacationId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_VACATION index.
		/// </summary>
		/// <param name="_saVacationId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacation GetBySaVacationId(System.Decimal _saVacationId)
		{
			int count = -1;
			return GetBySaVacationId(null,_saVacationId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION index.
		/// </summary>
		/// <param name="_saVacationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacation GetBySaVacationId(System.Decimal _saVacationId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationId(null, _saVacationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacation GetBySaVacationId(TransactionManager transactionManager, System.Decimal _saVacationId)
		{
			int count = -1;
			return GetBySaVacationId(transactionManager, _saVacationId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacation GetBySaVacationId(TransactionManager transactionManager, System.Decimal _saVacationId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationId(transactionManager, _saVacationId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION index.
		/// </summary>
		/// <param name="_saVacationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacation GetBySaVacationId(System.Decimal _saVacationId, int start, int pageLength, out int count)
		{
			return GetBySaVacationId(null, _saVacationId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaVacation GetBySaVacationId(TransactionManager transactionManager, System.Decimal _saVacationId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaVacation&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaVacation&gt;"/></returns>
		public static TList<SaVacation> Fill(IDataReader reader, TList<SaVacation> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaVacation c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaVacation")
					.Append("|").Append((System.Decimal)reader["SA_VACATION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaVacation>(
					key.ToString(), // EntityTrackingKey
					"SaVacation",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaVacation();
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
					c.SaVacationId = (System.Decimal)reader["SA_VACATION_ID"];
					c.OriginalSaVacationId = c.SaVacationId;
					c.StartDate = (System.DateTime)reader["START_DATE"];
					c.EndDate = (System.DateTime)reader["END_DATE"];
					c.DecisionNum = Convert.IsDBNull(reader["DECISION_NUM"]) ? null : (System.String)reader["DECISION_NUM"];
					c.DecisionDate = Convert.IsDBNull(reader["DECISION_DATE"]) ? null : (System.DateTime?)reader["DECISION_DATE"];
					c.VacationDiscontinued = Convert.IsDBNull(reader["VACATION_DISCONTINUED"]) ? null : (System.Decimal?)reader["VACATION_DISCONTINUED"];
					c.VacationLocation = Convert.IsDBNull(reader["VACATION_LOCATION"]) ? null : (System.String)reader["VACATION_LOCATION"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.IsDuringAcademicYear = (System.Decimal)reader["IS_DURING_ACADEMIC_YEAR"];
					c.DoesAffectStaffStatus = (System.Decimal)reader["DOES_AFFECT_STAFF_STATUS"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaVacationBylawsId = (System.Decimal)reader["SA_VACATION_BYLAWS_ID"];
					c.SaJobStartStatmentId = Convert.IsDBNull(reader["SA_JOB_START_STATMENT_ID"]) ? null : (System.Decimal?)reader["SA_JOB_START_STATMENT_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.GsApprovalHId = Convert.IsDBNull(reader["GS_APPROVAL_H_ID"]) ? null : (System.Decimal?)reader["GS_APPROVAL_H_ID"];
					c.ActReturnDate = Convert.IsDBNull(reader["ACT_RETURN_DATE"]) ? null : (System.DateTime?)reader["ACT_RETURN_DATE"];
					c.ActEndDate = Convert.IsDBNull(reader["ACT_END_DATE"]) ? null : (System.DateTime?)reader["ACT_END_DATE"];
					c.AffectReturns = Convert.IsDBNull(reader["AFFECT_RETURNS"]) ? null : (System.Decimal?)reader["AFFECT_RETURNS"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaVacation entity)
		{
			if (!reader.Read()) return;
			
			entity.SaVacationId = (System.Decimal)reader[((int)SaVacationColumn.SaVacationId - 1)];
			entity.OriginalSaVacationId = (System.Decimal)reader["SA_VACATION_ID"];
			entity.StartDate = (System.DateTime)reader[((int)SaVacationColumn.StartDate - 1)];
			entity.EndDate = (System.DateTime)reader[((int)SaVacationColumn.EndDate - 1)];
			entity.DecisionNum = (reader.IsDBNull(((int)SaVacationColumn.DecisionNum - 1)))?null:(System.String)reader[((int)SaVacationColumn.DecisionNum - 1)];
			entity.DecisionDate = (reader.IsDBNull(((int)SaVacationColumn.DecisionDate - 1)))?null:(System.DateTime?)reader[((int)SaVacationColumn.DecisionDate - 1)];
			entity.VacationDiscontinued = (reader.IsDBNull(((int)SaVacationColumn.VacationDiscontinued - 1)))?null:(System.Decimal?)reader[((int)SaVacationColumn.VacationDiscontinued - 1)];
			entity.VacationLocation = (reader.IsDBNull(((int)SaVacationColumn.VacationLocation - 1)))?null:(System.String)reader[((int)SaVacationColumn.VacationLocation - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaVacationColumn.Comments - 1)))?null:(System.String)reader[((int)SaVacationColumn.Comments - 1)];
			entity.IsDuringAcademicYear = (System.Decimal)reader[((int)SaVacationColumn.IsDuringAcademicYear - 1)];
			entity.DoesAffectStaffStatus = (System.Decimal)reader[((int)SaVacationColumn.DoesAffectStaffStatus - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)SaVacationColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)SaVacationColumn.GsCountryNodeId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaVacationColumn.SaStfMemberId - 1)];
			entity.SaVacationBylawsId = (System.Decimal)reader[((int)SaVacationColumn.SaVacationBylawsId - 1)];
			entity.SaJobStartStatmentId = (reader.IsDBNull(((int)SaVacationColumn.SaJobStartStatmentId - 1)))?null:(System.Decimal?)reader[((int)SaVacationColumn.SaJobStartStatmentId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaVacationColumn.AsFacultyInfoId - 1)];
			entity.GsApprovalHId = (reader.IsDBNull(((int)SaVacationColumn.GsApprovalHId - 1)))?null:(System.Decimal?)reader[((int)SaVacationColumn.GsApprovalHId - 1)];
			entity.ActReturnDate = (reader.IsDBNull(((int)SaVacationColumn.ActReturnDate - 1)))?null:(System.DateTime?)reader[((int)SaVacationColumn.ActReturnDate - 1)];
			entity.ActEndDate = (reader.IsDBNull(((int)SaVacationColumn.ActEndDate - 1)))?null:(System.DateTime?)reader[((int)SaVacationColumn.ActEndDate - 1)];
			entity.AffectReturns = (reader.IsDBNull(((int)SaVacationColumn.AffectReturns - 1)))?null:(System.Decimal?)reader[((int)SaVacationColumn.AffectReturns - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaVacation entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaVacationId = (System.Decimal)dataRow["SA_VACATION_ID"];
			entity.OriginalSaVacationId = (System.Decimal)dataRow["SA_VACATION_ID"];
			entity.StartDate = (System.DateTime)dataRow["START_DATE"];
			entity.EndDate = (System.DateTime)dataRow["END_DATE"];
			entity.DecisionNum = Convert.IsDBNull(dataRow["DECISION_NUM"]) ? null : (System.String)dataRow["DECISION_NUM"];
			entity.DecisionDate = Convert.IsDBNull(dataRow["DECISION_DATE"]) ? null : (System.DateTime?)dataRow["DECISION_DATE"];
			entity.VacationDiscontinued = Convert.IsDBNull(dataRow["VACATION_DISCONTINUED"]) ? null : (System.Decimal?)dataRow["VACATION_DISCONTINUED"];
			entity.VacationLocation = Convert.IsDBNull(dataRow["VACATION_LOCATION"]) ? null : (System.String)dataRow["VACATION_LOCATION"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.IsDuringAcademicYear = (System.Decimal)dataRow["IS_DURING_ACADEMIC_YEAR"];
			entity.DoesAffectStaffStatus = (System.Decimal)dataRow["DOES_AFFECT_STAFF_STATUS"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaVacationBylawsId = (System.Decimal)dataRow["SA_VACATION_BYLAWS_ID"];
			entity.SaJobStartStatmentId = Convert.IsDBNull(dataRow["SA_JOB_START_STATMENT_ID"]) ? null : (System.Decimal?)dataRow["SA_JOB_START_STATMENT_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.GsApprovalHId = Convert.IsDBNull(dataRow["GS_APPROVAL_H_ID"]) ? null : (System.Decimal?)dataRow["GS_APPROVAL_H_ID"];
			entity.ActReturnDate = Convert.IsDBNull(dataRow["ACT_RETURN_DATE"]) ? null : (System.DateTime?)dataRow["ACT_RETURN_DATE"];
			entity.ActEndDate = Convert.IsDBNull(dataRow["ACT_END_DATE"]) ? null : (System.DateTime?)dataRow["ACT_END_DATE"];
			entity.AffectReturns = Convert.IsDBNull(dataRow["AFFECT_RETURNS"]) ? null : (System.Decimal?)dataRow["AFFECT_RETURNS"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacation"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacation Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacation entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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
				pkItems[0] = (entity.GsApprovalHId ?? 0.0m);
				GsApprovalH tmpEntity = EntityManager.LocateEntity<GsApprovalH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsApprovalH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsApprovalHIdSource = tmpEntity;
				else
					entity.GsApprovalHIdSource = DataRepository.GsApprovalHProvider.GetByGsApprovalHId(transactionManager, (entity.GsApprovalHId ?? 0.0m));		
				
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

			#region SaJobStartStatmentIdSource	
			if (CanDeepLoad(entity, "SaJobStartStatment|SaJobStartStatmentIdSource", deepLoadType, innerList) 
				&& entity.SaJobStartStatmentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaJobStartStatmentId ?? 0.0m);
				SaJobStartStatment tmpEntity = EntityManager.LocateEntity<SaJobStartStatment>(EntityLocator.ConstructKeyFromPkItems(typeof(SaJobStartStatment), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaJobStartStatmentIdSource = tmpEntity;
				else
					entity.SaJobStartStatmentIdSource = DataRepository.SaJobStartStatmentProvider.GetBySaJobStartStatmentId(transactionManager, (entity.SaJobStartStatmentId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobStartStatmentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaJobStartStatmentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaJobStartStatmentProvider.DeepLoad(transactionManager, entity.SaJobStartStatmentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaJobStartStatmentIdSource

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

			#region SaVacationBylawsIdSource	
			if (CanDeepLoad(entity, "SaVacationBylaws|SaVacationBylawsIdSource", deepLoadType, innerList) 
				&& entity.SaVacationBylawsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaVacationBylawsId;
				SaVacationBylaws tmpEntity = EntityManager.LocateEntity<SaVacationBylaws>(EntityLocator.ConstructKeyFromPkItems(typeof(SaVacationBylaws), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaVacationBylawsIdSource = tmpEntity;
				else
					entity.SaVacationBylawsIdSource = DataRepository.SaVacationBylawsProvider.GetBySaVacationBylawsId(transactionManager, entity.SaVacationBylawsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBylawsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaVacationBylawsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaVacationBylawsProvider.DeepLoad(transactionManager, entity.SaVacationBylawsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaVacationBylawsIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaVacationId methods when available
			
			#region SaVacationRenewCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationRenew>|SaVacationRenewCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationRenewCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationRenewCollection = DataRepository.SaVacationRenewProvider.GetBySaVacationId(transactionManager, entity.SaVacationId);

				if (deep && entity.SaVacationRenewCollection.Count > 0)
				{
					deepHandles.Add("SaVacationRenewCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationRenew>) DataRepository.SaVacationRenewProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationRenewCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaVacation object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaVacation instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacation Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacation entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsApprovalHIdSource
			if (CanDeepSave(entity, "GsApprovalH|GsApprovalHIdSource", deepSaveType, innerList) 
				&& entity.GsApprovalHIdSource != null)
			{
				DataRepository.GsApprovalHProvider.Save(transactionManager, entity.GsApprovalHIdSource);
				entity.GsApprovalHId = entity.GsApprovalHIdSource.GsApprovalHId;
			}
			#endregion 
			
			#region SaJobStartStatmentIdSource
			if (CanDeepSave(entity, "SaJobStartStatment|SaJobStartStatmentIdSource", deepSaveType, innerList) 
				&& entity.SaJobStartStatmentIdSource != null)
			{
				DataRepository.SaJobStartStatmentProvider.Save(transactionManager, entity.SaJobStartStatmentIdSource);
				entity.SaJobStartStatmentId = entity.SaJobStartStatmentIdSource.SaJobStartStatmentId;
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
			
			#region SaVacationBylawsIdSource
			if (CanDeepSave(entity, "SaVacationBylaws|SaVacationBylawsIdSource", deepSaveType, innerList) 
				&& entity.SaVacationBylawsIdSource != null)
			{
				DataRepository.SaVacationBylawsProvider.Save(transactionManager, entity.SaVacationBylawsIdSource);
				entity.SaVacationBylawsId = entity.SaVacationBylawsIdSource.SaVacationBylawsId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaVacationRenew>
				if (CanDeepSave(entity.SaVacationRenewCollection, "List<SaVacationRenew>|SaVacationRenewCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacationRenew child in entity.SaVacationRenewCollection)
					{
						if(child.SaVacationIdSource != null)
						{
							child.SaVacationId = child.SaVacationIdSource.SaVacationId;
						}
						else
						{
							child.SaVacationId = entity.SaVacationId;
						}

					}

					if (entity.SaVacationRenewCollection.Count > 0 || entity.SaVacationRenewCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationRenewProvider.Save(transactionManager, entity.SaVacationRenewCollection);
						
						deepHandles.Add("SaVacationRenewCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacationRenew >) DataRepository.SaVacationRenewProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationRenewCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaVacationChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaVacation</c>
	///</summary>
	public enum SaVacationChildEntityTypes
	{
		
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
		/// Composite Property for <c>SaJobStartStatment</c> at SaJobStartStatmentIdSource
		///</summary>
		[ChildEntityType(typeof(SaJobStartStatment))]
		SaJobStartStatment,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SaVacationBylaws</c> at SaVacationBylawsIdSource
		///</summary>
		[ChildEntityType(typeof(SaVacationBylaws))]
		SaVacationBylaws,
		///<summary>
		/// Collection of <c>SaVacation</c> as OneToMany for SaVacationRenewCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationRenew>))]
		SaVacationRenewCollection,
	}
	
	#endregion SaVacationChildEntityTypes
	
	#region SaVacationFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaVacationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacation"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationFilterBuilder : SqlFilterBuilder<SaVacationColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationFilterBuilder class.
		/// </summary>
		public SaVacationFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationFilterBuilder
	
	#region SaVacationParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaVacationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacation"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationParameterBuilder : ParameterizedSqlFilterBuilder<SaVacationColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationParameterBuilder class.
		/// </summary>
		public SaVacationParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationParameterBuilder
	
	#region SaVacationSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaVacationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacation"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaVacationSortBuilder : SqlSortBuilder<SaVacationColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationSqlSortBuilder class.
		/// </summary>
		public SaVacationSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaVacationSortBuilder
	
} // end namespace
