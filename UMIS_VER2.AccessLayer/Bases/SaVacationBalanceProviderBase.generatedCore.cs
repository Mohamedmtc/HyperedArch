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
	/// This class is the base class for any <see cref="SaVacationBalanceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaVacationBalanceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaVacationBalance, UMIS_VER2.BusinessLyer.SaVacationBalanceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBalanceKey key)
		{
			return Delete(transactionManager, key.SaVacationBalanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saVacationBalanceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saVacationBalanceId)
		{
			return Delete(null, _saVacationBalanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saVacationBalanceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002f key.
		///		FK_AUTO_002f Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002f key.
		///		FK_AUTO_002f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationBalance> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002f key.
		///		FK_AUTO_002f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002f key.
		///		fkAuto002f Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002f key.
		///		fkAuto002f Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_002f key.
		///		FK_AUTO_002f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public abstract TList<SaVacationBalance> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_STF_MEMBER key.
		///		FK_SA_VACATION_BALANCE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_STF_MEMBER key.
		///		FK_SA_VACATION_BALANCE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationBalance> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_STF_MEMBER key.
		///		FK_SA_VACATION_BALANCE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_STF_MEMBER key.
		///		fkSaVacationBalanceSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_STF_MEMBER key.
		///		fkSaVacationBalanceSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_STF_MEMBER key.
		///		FK_SA_VACATION_BALANCE_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public abstract TList<SaVacationBalance> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BALANCE_H key.
		///		FK_SA_VACATION_BALANCE_SA_VACATION_BALANCE_H Description: 
		/// </summary>
		/// <param name="_saVacationBalanceHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaVacationBalanceHId(System.Decimal? _saVacationBalanceHId)
		{
			int count = -1;
			return GetBySaVacationBalanceHId(_saVacationBalanceHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BALANCE_H key.
		///		FK_SA_VACATION_BALANCE_SA_VACATION_BALANCE_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationBalance> GetBySaVacationBalanceHId(TransactionManager transactionManager, System.Decimal? _saVacationBalanceHId)
		{
			int count = -1;
			return GetBySaVacationBalanceHId(transactionManager, _saVacationBalanceHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BALANCE_H key.
		///		FK_SA_VACATION_BALANCE_SA_VACATION_BALANCE_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaVacationBalanceHId(TransactionManager transactionManager, System.Decimal? _saVacationBalanceHId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBalanceHId(transactionManager, _saVacationBalanceHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BALANCE_H key.
		///		fkSaVacationBalanceSaVacationBalanceH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationBalanceHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaVacationBalanceHId(System.Decimal? _saVacationBalanceHId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaVacationBalanceHId(null, _saVacationBalanceHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BALANCE_H key.
		///		fkSaVacationBalanceSaVacationBalanceH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationBalanceHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaVacationBalanceHId(System.Decimal? _saVacationBalanceHId, int start, int pageLength,out int count)
		{
			return GetBySaVacationBalanceHId(null, _saVacationBalanceHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BALANCE_H key.
		///		FK_SA_VACATION_BALANCE_SA_VACATION_BALANCE_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public abstract TList<SaVacationBalance> GetBySaVacationBalanceHId(TransactionManager transactionManager, System.Decimal? _saVacationBalanceHId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_BALANCE_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="_saVacationBylowId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaVacationBylowId(System.Decimal _saVacationBylowId)
		{
			int count = -1;
			return GetBySaVacationBylowId(_saVacationBylowId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_BALANCE_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylowId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationBalance> GetBySaVacationBylowId(TransactionManager transactionManager, System.Decimal _saVacationBylowId)
		{
			int count = -1;
			return GetBySaVacationBylowId(transactionManager, _saVacationBylowId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_BALANCE_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylowId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaVacationBylowId(TransactionManager transactionManager, System.Decimal _saVacationBylowId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBylowId(transactionManager, _saVacationBylowId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BYLAWS key.
		///		fkSaVacationBalanceSaVacationBylaws Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationBylowId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaVacationBylowId(System.Decimal _saVacationBylowId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaVacationBylowId(null, _saVacationBylowId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BYLAWS key.
		///		fkSaVacationBalanceSaVacationBylaws Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationBylowId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public TList<SaVacationBalance> GetBySaVacationBylowId(System.Decimal _saVacationBylowId, int start, int pageLength,out int count)
		{
			return GetBySaVacationBylowId(null, _saVacationBylowId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_BALANCE_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylowId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalance objects.</returns>
		public abstract TList<SaVacationBalance> GetBySaVacationBylowId(TransactionManager transactionManager, System.Decimal _saVacationBylowId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaVacationBalance Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBalanceKey key, int start, int pageLength)
		{
			return GetBySaVacationBalanceId(transactionManager, key.SaVacationBalanceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_VACATION_BALANCE index.
		/// </summary>
		/// <param name="_saVacationBalanceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBalance GetBySaVacationBalanceId(System.Decimal _saVacationBalanceId)
		{
			int count = -1;
			return GetBySaVacationBalanceId(null,_saVacationBalanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BALANCE index.
		/// </summary>
		/// <param name="_saVacationBalanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBalance GetBySaVacationBalanceId(System.Decimal _saVacationBalanceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBalanceId(null, _saVacationBalanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BALANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBalance GetBySaVacationBalanceId(TransactionManager transactionManager, System.Decimal _saVacationBalanceId)
		{
			int count = -1;
			return GetBySaVacationBalanceId(transactionManager, _saVacationBalanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BALANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBalance GetBySaVacationBalanceId(TransactionManager transactionManager, System.Decimal _saVacationBalanceId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBalanceId(transactionManager, _saVacationBalanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BALANCE index.
		/// </summary>
		/// <param name="_saVacationBalanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBalance GetBySaVacationBalanceId(System.Decimal _saVacationBalanceId, int start, int pageLength, out int count)
		{
			return GetBySaVacationBalanceId(null, _saVacationBalanceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BALANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaVacationBalance GetBySaVacationBalanceId(TransactionManager transactionManager, System.Decimal _saVacationBalanceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaVacationBalance&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaVacationBalance&gt;"/></returns>
		public static TList<SaVacationBalance> Fill(IDataReader reader, TList<SaVacationBalance> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaVacationBalance c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaVacationBalance")
					.Append("|").Append((System.Decimal)reader["SA_VACATION_BALANCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaVacationBalance>(
					key.ToString(), // EntityTrackingKey
					"SaVacationBalance",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaVacationBalance();
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
					c.SaVacationBalanceId = (System.Decimal)reader["SA_VACATION_BALANCE_ID"];
					c.OriginalSaVacationBalanceId = c.SaVacationBalanceId;
					c.CurrentBalance = (System.Decimal)reader["CURRENT_BALANCE"];
					c.DeductFromBalance = (System.Decimal)reader["DEDUCT_FROM_BALANCE"];
					c.TransferBalance = (System.Decimal)reader["TRANSFER_BALANCE"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.SaVacationBalanceHId = Convert.IsDBNull(reader["SA_VACATION_BALANCE_H_ID"]) ? null : (System.Decimal?)reader["SA_VACATION_BALANCE_H_ID"];
					c.PeriodFrom = (System.DateTime)reader["PERIOD_FROM"];
					c.PeriodTo = (System.DateTime)reader["PERIOD_TO"];
					c.SaVacationBylowId = (System.Decimal)reader["SA_VACATION_BYLOW_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaVacationBalance entity)
		{
			if (!reader.Read()) return;
			
			entity.SaVacationBalanceId = (System.Decimal)reader[((int)SaVacationBalanceColumn.SaVacationBalanceId - 1)];
			entity.OriginalSaVacationBalanceId = (System.Decimal)reader["SA_VACATION_BALANCE_ID"];
			entity.CurrentBalance = (System.Decimal)reader[((int)SaVacationBalanceColumn.CurrentBalance - 1)];
			entity.DeductFromBalance = (System.Decimal)reader[((int)SaVacationBalanceColumn.DeductFromBalance - 1)];
			entity.TransferBalance = (System.Decimal)reader[((int)SaVacationBalanceColumn.TransferBalance - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaVacationBalanceColumn.SaStfMemberId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)SaVacationBalanceColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)SaVacationBalanceColumn.AsFacultyInfoId - 1)];
			entity.SaVacationBalanceHId = (reader.IsDBNull(((int)SaVacationBalanceColumn.SaVacationBalanceHId - 1)))?null:(System.Decimal?)reader[((int)SaVacationBalanceColumn.SaVacationBalanceHId - 1)];
			entity.PeriodFrom = (System.DateTime)reader[((int)SaVacationBalanceColumn.PeriodFrom - 1)];
			entity.PeriodTo = (System.DateTime)reader[((int)SaVacationBalanceColumn.PeriodTo - 1)];
			entity.SaVacationBylowId = (System.Decimal)reader[((int)SaVacationBalanceColumn.SaVacationBylowId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaVacationBalance entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaVacationBalanceId = (System.Decimal)dataRow["SA_VACATION_BALANCE_ID"];
			entity.OriginalSaVacationBalanceId = (System.Decimal)dataRow["SA_VACATION_BALANCE_ID"];
			entity.CurrentBalance = (System.Decimal)dataRow["CURRENT_BALANCE"];
			entity.DeductFromBalance = (System.Decimal)dataRow["DEDUCT_FROM_BALANCE"];
			entity.TransferBalance = (System.Decimal)dataRow["TRANSFER_BALANCE"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.SaVacationBalanceHId = Convert.IsDBNull(dataRow["SA_VACATION_BALANCE_H_ID"]) ? null : (System.Decimal?)dataRow["SA_VACATION_BALANCE_H_ID"];
			entity.PeriodFrom = (System.DateTime)dataRow["PERIOD_FROM"];
			entity.PeriodTo = (System.DateTime)dataRow["PERIOD_TO"];
			entity.SaVacationBylowId = (System.Decimal)dataRow["SA_VACATION_BYLOW_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationBalance"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacationBalance Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBalance entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SaVacationBalanceHIdSource	
			if (CanDeepLoad(entity, "SaVacationBalanceH|SaVacationBalanceHIdSource", deepLoadType, innerList) 
				&& entity.SaVacationBalanceHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaVacationBalanceHId ?? 0.0m);
				SaVacationBalanceH tmpEntity = EntityManager.LocateEntity<SaVacationBalanceH>(EntityLocator.ConstructKeyFromPkItems(typeof(SaVacationBalanceH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaVacationBalanceHIdSource = tmpEntity;
				else
					entity.SaVacationBalanceHIdSource = DataRepository.SaVacationBalanceHProvider.GetBySaVacationBalanceHId(transactionManager, (entity.SaVacationBalanceHId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBalanceHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaVacationBalanceHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaVacationBalanceHProvider.DeepLoad(transactionManager, entity.SaVacationBalanceHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaVacationBalanceHIdSource

			#region SaVacationBylowIdSource	
			if (CanDeepLoad(entity, "SaVacationBylaws|SaVacationBylowIdSource", deepLoadType, innerList) 
				&& entity.SaVacationBylowIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaVacationBylowId;
				SaVacationBylaws tmpEntity = EntityManager.LocateEntity<SaVacationBylaws>(EntityLocator.ConstructKeyFromPkItems(typeof(SaVacationBylaws), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaVacationBylowIdSource = tmpEntity;
				else
					entity.SaVacationBylowIdSource = DataRepository.SaVacationBylawsProvider.GetBySaVacationBylawsId(transactionManager, entity.SaVacationBylowId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBylowIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaVacationBylowIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaVacationBylawsProvider.DeepLoad(transactionManager, entity.SaVacationBylowIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaVacationBylowIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaVacationBalance object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaVacationBalance instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacationBalance Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBalance entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region SaVacationBalanceHIdSource
			if (CanDeepSave(entity, "SaVacationBalanceH|SaVacationBalanceHIdSource", deepSaveType, innerList) 
				&& entity.SaVacationBalanceHIdSource != null)
			{
				DataRepository.SaVacationBalanceHProvider.Save(transactionManager, entity.SaVacationBalanceHIdSource);
				entity.SaVacationBalanceHId = entity.SaVacationBalanceHIdSource.SaVacationBalanceHId;
			}
			#endregion 
			
			#region SaVacationBylowIdSource
			if (CanDeepSave(entity, "SaVacationBylaws|SaVacationBylowIdSource", deepSaveType, innerList) 
				&& entity.SaVacationBylowIdSource != null)
			{
				DataRepository.SaVacationBylawsProvider.Save(transactionManager, entity.SaVacationBylowIdSource);
				entity.SaVacationBylowId = entity.SaVacationBylowIdSource.SaVacationBylawsId;
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
	
	#region SaVacationBalanceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaVacationBalance</c>
	///</summary>
	public enum SaVacationBalanceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SaVacationBalanceH</c> at SaVacationBalanceHIdSource
		///</summary>
		[ChildEntityType(typeof(SaVacationBalanceH))]
		SaVacationBalanceH,
		
		///<summary>
		/// Composite Property for <c>SaVacationBylaws</c> at SaVacationBylowIdSource
		///</summary>
		[ChildEntityType(typeof(SaVacationBylaws))]
		SaVacationBylaws,
	}
	
	#endregion SaVacationBalanceChildEntityTypes
	
	#region SaVacationBalanceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaVacationBalanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationBalance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationBalanceFilterBuilder : SqlFilterBuilder<SaVacationBalanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceFilterBuilder class.
		/// </summary>
		public SaVacationBalanceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationBalanceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationBalanceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationBalanceFilterBuilder
	
	#region SaVacationBalanceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaVacationBalanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationBalance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationBalanceParameterBuilder : ParameterizedSqlFilterBuilder<SaVacationBalanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceParameterBuilder class.
		/// </summary>
		public SaVacationBalanceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationBalanceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationBalanceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationBalanceParameterBuilder
	
	#region SaVacationBalanceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaVacationBalanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationBalance"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaVacationBalanceSortBuilder : SqlSortBuilder<SaVacationBalanceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceSqlSortBuilder class.
		/// </summary>
		public SaVacationBalanceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaVacationBalanceSortBuilder
	
} // end namespace
