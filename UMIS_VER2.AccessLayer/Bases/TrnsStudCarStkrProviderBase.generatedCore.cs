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
	/// This class is the base class for any <see cref="TrnsStudCarStkrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrnsStudCarStkrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.TrnsStudCarStkr, UMIS_VER2.BusinessLyer.TrnsStudCarStkrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsStudCarStkrKey key)
		{
			return Delete(transactionManager, key.TrnsStudCarStkrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_trnsStudCarStkrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _trnsStudCarStkrId)
		{
			return Delete(null, _trnsStudCarStkrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsStudCarStkrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _trnsStudCarStkrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_ACAD_YEAR key.
		///		FK_TRNS_STUD_CAR_STKR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_ACAD_YEAR key.
		///		FK_TRNS_STUD_CAR_STKR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudCarStkr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_ACAD_YEAR key.
		///		FK_TRNS_STUD_CAR_STKR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_ACAD_YEAR key.
		///		fkTrnsStudCarStkrEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_ACAD_YEAR key.
		///		fkTrnsStudCarStkrEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_ACAD_YEAR key.
		///		FK_TRNS_STUD_CAR_STKR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public abstract TList<TrnsStudCarStkr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_STUD key.
		///		FK_TRNS_STUD_CAR_STKR_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_STUD key.
		///		FK_TRNS_STUD_CAR_STKR_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudCarStkr> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_STUD key.
		///		FK_TRNS_STUD_CAR_STKR_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_STUD key.
		///		fkTrnsStudCarStkrEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_STUD key.
		///		fkTrnsStudCarStkrEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_ED_STUD key.
		///		FK_TRNS_STUD_CAR_STKR_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public abstract TList<TrnsStudCarStkr> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_GS_COUNTRY_NODE key.
		///		FK_TRNS_STUD_CAR_STKR_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_GS_COUNTRY_NODE key.
		///		FK_TRNS_STUD_CAR_STKR_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudCarStkr> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_GS_COUNTRY_NODE key.
		///		FK_TRNS_STUD_CAR_STKR_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_GS_COUNTRY_NODE key.
		///		fkTrnsStudCarStkrGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_GS_COUNTRY_NODE key.
		///		fkTrnsStudCarStkrGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_GS_COUNTRY_NODE key.
		///		FK_TRNS_STUD_CAR_STKR_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public abstract TList<TrnsStudCarStkr> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_SE_USER key.
		///		FK_TRNS_STUD_CAR_STKR_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_SE_USER key.
		///		FK_TRNS_STUD_CAR_STKR_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudCarStkr> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_SE_USER key.
		///		FK_TRNS_STUD_CAR_STKR_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_SE_USER key.
		///		fkTrnsStudCarStkrSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_SE_USER key.
		///		fkTrnsStudCarStkrSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_SE_USER key.
		///		FK_TRNS_STUD_CAR_STKR_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public abstract TList<TrnsStudCarStkr> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_TRNS_CDE_COLOR key.
		///		FK_TRNS_STUD_CAR_STKR_TRNS_CDE_COLOR Description: 
		/// </summary>
		/// <param name="_trnsCdeColorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByTrnsCdeColorId(System.Decimal? _trnsCdeColorId)
		{
			int count = -1;
			return GetByTrnsCdeColorId(_trnsCdeColorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_TRNS_CDE_COLOR key.
		///		FK_TRNS_STUD_CAR_STKR_TRNS_CDE_COLOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeColorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsStudCarStkr> GetByTrnsCdeColorId(TransactionManager transactionManager, System.Decimal? _trnsCdeColorId)
		{
			int count = -1;
			return GetByTrnsCdeColorId(transactionManager, _trnsCdeColorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_TRNS_CDE_COLOR key.
		///		FK_TRNS_STUD_CAR_STKR_TRNS_CDE_COLOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeColorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByTrnsCdeColorId(TransactionManager transactionManager, System.Decimal? _trnsCdeColorId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeColorId(transactionManager, _trnsCdeColorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_TRNS_CDE_COLOR key.
		///		fkTrnsStudCarStkrTrnsCdeColor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsCdeColorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByTrnsCdeColorId(System.Decimal? _trnsCdeColorId, int start, int pageLength)
		{
			int count =  -1;
			return GetByTrnsCdeColorId(null, _trnsCdeColorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_TRNS_CDE_COLOR key.
		///		fkTrnsStudCarStkrTrnsCdeColor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsCdeColorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public TList<TrnsStudCarStkr> GetByTrnsCdeColorId(System.Decimal? _trnsCdeColorId, int start, int pageLength,out int count)
		{
			return GetByTrnsCdeColorId(null, _trnsCdeColorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_STUD_CAR_STKR_TRNS_CDE_COLOR key.
		///		FK_TRNS_STUD_CAR_STKR_TRNS_CDE_COLOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeColorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsStudCarStkr objects.</returns>
		public abstract TList<TrnsStudCarStkr> GetByTrnsCdeColorId(TransactionManager transactionManager, System.Decimal? _trnsCdeColorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.TrnsStudCarStkr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsStudCarStkrKey key, int start, int pageLength)
		{
			return GetByTrnsStudCarStkrId(transactionManager, key.TrnsStudCarStkrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TRNS_STUD_CAR_STKR index.
		/// </summary>
		/// <param name="_trnsStudCarStkrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByTrnsStudCarStkrId(System.Decimal _trnsStudCarStkrId)
		{
			int count = -1;
			return GetByTrnsStudCarStkrId(null,_trnsStudCarStkrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_STUD_CAR_STKR index.
		/// </summary>
		/// <param name="_trnsStudCarStkrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByTrnsStudCarStkrId(System.Decimal _trnsStudCarStkrId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsStudCarStkrId(null, _trnsStudCarStkrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_STUD_CAR_STKR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsStudCarStkrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByTrnsStudCarStkrId(TransactionManager transactionManager, System.Decimal _trnsStudCarStkrId)
		{
			int count = -1;
			return GetByTrnsStudCarStkrId(transactionManager, _trnsStudCarStkrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_STUD_CAR_STKR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsStudCarStkrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByTrnsStudCarStkrId(TransactionManager transactionManager, System.Decimal _trnsStudCarStkrId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsStudCarStkrId(transactionManager, _trnsStudCarStkrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_STUD_CAR_STKR index.
		/// </summary>
		/// <param name="_trnsStudCarStkrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByTrnsStudCarStkrId(System.Decimal _trnsStudCarStkrId, int start, int pageLength, out int count)
		{
			return GetByTrnsStudCarStkrId(null, _trnsStudCarStkrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_STUD_CAR_STKR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsStudCarStkrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByTrnsStudCarStkrId(TransactionManager transactionManager, System.Decimal _trnsStudCarStkrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key STUD_CAR_STKR_CHECK index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_carNo"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByEdAcadYearIdEdStudIdCarNo(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.String _carNo)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdCarNo(null,_edAcadYearId, _edStudId, _carNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the STUD_CAR_STKR_CHECK index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_carNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByEdAcadYearIdEdStudIdCarNo(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.String _carNo, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdCarNo(null, _edAcadYearId, _edStudId, _carNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the STUD_CAR_STKR_CHECK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_carNo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByEdAcadYearIdEdStudIdCarNo(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.String _carNo)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdCarNo(transactionManager, _edAcadYearId, _edStudId, _carNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the STUD_CAR_STKR_CHECK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_carNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByEdAcadYearIdEdStudIdCarNo(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.String _carNo, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdCarNo(transactionManager, _edAcadYearId, _edStudId, _carNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the STUD_CAR_STKR_CHECK index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_carNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByEdAcadYearIdEdStudIdCarNo(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.String _carNo, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdStudIdCarNo(null, _edAcadYearId, _edStudId, _carNo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the STUD_CAR_STKR_CHECK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_carNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsStudCarStkr GetByEdAcadYearIdEdStudIdCarNo(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.String _carNo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TrnsStudCarStkr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TrnsStudCarStkr&gt;"/></returns>
		public static TList<TrnsStudCarStkr> Fill(IDataReader reader, TList<TrnsStudCarStkr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.TrnsStudCarStkr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TrnsStudCarStkr")
					.Append("|").Append((System.Decimal)reader["TRNS_STUD_CAR_STKR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<TrnsStudCarStkr>(
					key.ToString(), // EntityTrackingKey
					"TrnsStudCarStkr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.TrnsStudCarStkr();
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
					c.TrnsStudCarStkrId = (System.Decimal)reader["TRNS_STUD_CAR_STKR_ID"];
					c.OriginalTrnsStudCarStkrId = c.TrnsStudCarStkrId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.PrntFlg = (System.Decimal)reader["PRNT_FLG"];
					c.TrnsCdeColorId = Convert.IsDBNull(reader["TRNS_CDE_COLOR_ID"]) ? null : (System.Decimal?)reader["TRNS_CDE_COLOR_ID"];
					c.CarNo = (System.String)reader["CAR_NO"];
					c.OwnerName = Convert.IsDBNull(reader["OWNER_NAME"]) ? null : (System.String)reader["OWNER_NAME"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.PadgeTypeFlg = (System.Decimal)reader["PADGE_TYPE_FLG"];
					c.PadgeCode = Convert.IsDBNull(reader["PADGE_CODE"]) ? null : (System.String)reader["PADGE_CODE"];
					c.GsCountryNodeId = (System.Decimal)reader["GS_COUNTRY_NODE_ID"];
					c.CarModel = Convert.IsDBNull(reader["CAR_Model"]) ? null : (System.String)reader["CAR_Model"];
					c.EmployeeName = Convert.IsDBNull(reader["EMPLOYEE_NAME"]) ? null : (System.String)reader["EMPLOYEE_NAME"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.TrnsStudCarStkr entity)
		{
			if (!reader.Read()) return;
			
			entity.TrnsStudCarStkrId = (System.Decimal)reader[((int)TrnsStudCarStkrColumn.TrnsStudCarStkrId - 1)];
			entity.OriginalTrnsStudCarStkrId = (System.Decimal)reader["TRNS_STUD_CAR_STKR_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)TrnsStudCarStkrColumn.EdAcadYearId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)TrnsStudCarStkrColumn.EdStudId - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)TrnsStudCarStkrColumn.ReqDate - 1)];
			entity.PrntFlg = (System.Decimal)reader[((int)TrnsStudCarStkrColumn.PrntFlg - 1)];
			entity.TrnsCdeColorId = (reader.IsDBNull(((int)TrnsStudCarStkrColumn.TrnsCdeColorId - 1)))?null:(System.Decimal?)reader[((int)TrnsStudCarStkrColumn.TrnsCdeColorId - 1)];
			entity.CarNo = (System.String)reader[((int)TrnsStudCarStkrColumn.CarNo - 1)];
			entity.OwnerName = (reader.IsDBNull(((int)TrnsStudCarStkrColumn.OwnerName - 1)))?null:(System.String)reader[((int)TrnsStudCarStkrColumn.OwnerName - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)TrnsStudCarStkrColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)TrnsStudCarStkrColumn.SeUserId - 1)];
			entity.PadgeTypeFlg = (System.Decimal)reader[((int)TrnsStudCarStkrColumn.PadgeTypeFlg - 1)];
			entity.PadgeCode = (reader.IsDBNull(((int)TrnsStudCarStkrColumn.PadgeCode - 1)))?null:(System.String)reader[((int)TrnsStudCarStkrColumn.PadgeCode - 1)];
			entity.GsCountryNodeId = (System.Decimal)reader[((int)TrnsStudCarStkrColumn.GsCountryNodeId - 1)];
			entity.CarModel = (reader.IsDBNull(((int)TrnsStudCarStkrColumn.CarModel - 1)))?null:(System.String)reader[((int)TrnsStudCarStkrColumn.CarModel - 1)];
			entity.EmployeeName = (reader.IsDBNull(((int)TrnsStudCarStkrColumn.EmployeeName - 1)))?null:(System.String)reader[((int)TrnsStudCarStkrColumn.EmployeeName - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.TrnsStudCarStkr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TrnsStudCarStkrId = (System.Decimal)dataRow["TRNS_STUD_CAR_STKR_ID"];
			entity.OriginalTrnsStudCarStkrId = (System.Decimal)dataRow["TRNS_STUD_CAR_STKR_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.PrntFlg = (System.Decimal)dataRow["PRNT_FLG"];
			entity.TrnsCdeColorId = Convert.IsDBNull(dataRow["TRNS_CDE_COLOR_ID"]) ? null : (System.Decimal?)dataRow["TRNS_CDE_COLOR_ID"];
			entity.CarNo = (System.String)dataRow["CAR_NO"];
			entity.OwnerName = Convert.IsDBNull(dataRow["OWNER_NAME"]) ? null : (System.String)dataRow["OWNER_NAME"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.PadgeTypeFlg = (System.Decimal)dataRow["PADGE_TYPE_FLG"];
			entity.PadgeCode = Convert.IsDBNull(dataRow["PADGE_CODE"]) ? null : (System.String)dataRow["PADGE_CODE"];
			entity.GsCountryNodeId = (System.Decimal)dataRow["GS_COUNTRY_NODE_ID"];
			entity.CarModel = Convert.IsDBNull(dataRow["CAR_Model"]) ? null : (System.String)dataRow["CAR_Model"];
			entity.EmployeeName = Convert.IsDBNull(dataRow["EMPLOYEE_NAME"]) ? null : (System.String)dataRow["EMPLOYEE_NAME"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsStudCarStkr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsStudCarStkr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsStudCarStkr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCountryNodeId;
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource

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

			#region TrnsCdeColorIdSource	
			if (CanDeepLoad(entity, "TrnsCdeColor|TrnsCdeColorIdSource", deepLoadType, innerList) 
				&& entity.TrnsCdeColorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.TrnsCdeColorId ?? 0.0m);
				TrnsCdeColor tmpEntity = EntityManager.LocateEntity<TrnsCdeColor>(EntityLocator.ConstructKeyFromPkItems(typeof(TrnsCdeColor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.TrnsCdeColorIdSource = tmpEntity;
				else
					entity.TrnsCdeColorIdSource = DataRepository.TrnsCdeColorProvider.GetByTrnsCdeColorId(transactionManager, (entity.TrnsCdeColorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsCdeColorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.TrnsCdeColorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrnsCdeColorProvider.DeepLoad(transactionManager, entity.TrnsCdeColorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion TrnsCdeColorIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.TrnsStudCarStkr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.TrnsStudCarStkr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsStudCarStkr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsStudCarStkr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
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
			
			#region TrnsCdeColorIdSource
			if (CanDeepSave(entity, "TrnsCdeColor|TrnsCdeColorIdSource", deepSaveType, innerList) 
				&& entity.TrnsCdeColorIdSource != null)
			{
				DataRepository.TrnsCdeColorProvider.Save(transactionManager, entity.TrnsCdeColorIdSource);
				entity.TrnsCdeColorId = entity.TrnsCdeColorIdSource.TrnsCdeColorId;
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
	
	#region TrnsStudCarStkrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.TrnsStudCarStkr</c>
	///</summary>
	public enum TrnsStudCarStkrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		
		///<summary>
		/// Composite Property for <c>TrnsCdeColor</c> at TrnsCdeColorIdSource
		///</summary>
		[ChildEntityType(typeof(TrnsCdeColor))]
		TrnsCdeColor,
	}
	
	#endregion TrnsStudCarStkrChildEntityTypes
	
	#region TrnsStudCarStkrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrnsStudCarStkrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsStudCarStkr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsStudCarStkrFilterBuilder : SqlFilterBuilder<TrnsStudCarStkrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsStudCarStkrFilterBuilder class.
		/// </summary>
		public TrnsStudCarStkrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsStudCarStkrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsStudCarStkrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsStudCarStkrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsStudCarStkrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsStudCarStkrFilterBuilder
	
	#region TrnsStudCarStkrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrnsStudCarStkrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsStudCarStkr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsStudCarStkrParameterBuilder : ParameterizedSqlFilterBuilder<TrnsStudCarStkrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsStudCarStkrParameterBuilder class.
		/// </summary>
		public TrnsStudCarStkrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsStudCarStkrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsStudCarStkrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsStudCarStkrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsStudCarStkrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsStudCarStkrParameterBuilder
	
	#region TrnsStudCarStkrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrnsStudCarStkrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsStudCarStkr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrnsStudCarStkrSortBuilder : SqlSortBuilder<TrnsStudCarStkrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsStudCarStkrSqlSortBuilder class.
		/// </summary>
		public TrnsStudCarStkrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrnsStudCarStkrSortBuilder
	
} // end namespace
