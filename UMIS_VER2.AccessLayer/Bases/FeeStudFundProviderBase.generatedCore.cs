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
	/// This class is the base class for any <see cref="FeeStudFundProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudFundProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudFund, UMIS_VER2.BusinessLyer.FeeStudFundKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudFundKey key)
		{
			return Delete(transactionManager, key.FeeStudFundId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudFundId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudFundId)
		{
			return Delete(null, _feeStudFundId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFundId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudFundId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_FUND_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_FUND_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudFund> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_FUND_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_ACAD_YEAR key.
		///		fkFeeStudFundEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_ACAD_YEAR key.
		///		fkFeeStudFundEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_FUND_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public abstract TList<FeeStudFund> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_FUND_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_FUND_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudFund> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_FUND_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_CODE_SEMESTER key.
		///		fkFeeStudFundEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_CODE_SEMESTER key.
		///		fkFeeStudFundEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_FUND_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public abstract TList<FeeStudFund> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_STUD key.
		///		FK_FEE_STUD_FUND_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_STUD key.
		///		FK_FEE_STUD_FUND_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudFund> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_STUD key.
		///		FK_FEE_STUD_FUND_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_STUD key.
		///		fkFeeStudFundEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_STUD key.
		///		fkFeeStudFundEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_ED_STUD key.
		///		FK_FEE_STUD_FUND_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public abstract TList<FeeStudFund> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_FEE_CDE_FUND key.
		///		FK_FEE_STUD_FUND_FEE_CDE_FUND Description: 
		/// </summary>
		/// <param name="_feeCdeFundId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByFeeCdeFundId(System.Int32 _feeCdeFundId)
		{
			int count = -1;
			return GetByFeeCdeFundId(_feeCdeFundId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_FEE_CDE_FUND key.
		///		FK_FEE_STUD_FUND_FEE_CDE_FUND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeFundId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudFund> GetByFeeCdeFundId(TransactionManager transactionManager, System.Int32 _feeCdeFundId)
		{
			int count = -1;
			return GetByFeeCdeFundId(transactionManager, _feeCdeFundId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_FEE_CDE_FUND key.
		///		FK_FEE_STUD_FUND_FEE_CDE_FUND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeFundId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByFeeCdeFundId(TransactionManager transactionManager, System.Int32 _feeCdeFundId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeFundId(transactionManager, _feeCdeFundId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_FEE_CDE_FUND key.
		///		fkFeeStudFundFeeCdeFund Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeFundId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByFeeCdeFundId(System.Int32 _feeCdeFundId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeFundId(null, _feeCdeFundId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_FEE_CDE_FUND key.
		///		fkFeeStudFundFeeCdeFund Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeFundId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByFeeCdeFundId(System.Int32 _feeCdeFundId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeFundId(null, _feeCdeFundId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_FEE_CDE_FUND key.
		///		FK_FEE_STUD_FUND_FEE_CDE_FUND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeFundId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public abstract TList<FeeStudFund> GetByFeeCdeFundId(TransactionManager transactionManager, System.Int32 _feeCdeFundId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_GS_COUNTRY_NODE key.
		///		FK_FEE_STUD_FUND_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_GS_COUNTRY_NODE key.
		///		FK_FEE_STUD_FUND_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudFund> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_GS_COUNTRY_NODE key.
		///		FK_FEE_STUD_FUND_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_GS_COUNTRY_NODE key.
		///		fkFeeStudFundGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_GS_COUNTRY_NODE key.
		///		fkFeeStudFundGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public TList<FeeStudFund> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_FUND_GS_COUNTRY_NODE key.
		///		FK_FEE_STUD_FUND_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الدولة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudFund objects.</returns>
		public abstract TList<FeeStudFund> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudFund Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudFundKey key, int start, int pageLength)
		{
			return GetByFeeStudFundId(transactionManager, key.FeeStudFundId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_FUND index.
		/// </summary>
		/// <param name="_feeStudFundId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudFund GetByFeeStudFundId(System.Decimal _feeStudFundId)
		{
			int count = -1;
			return GetByFeeStudFundId(null,_feeStudFundId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_FUND index.
		/// </summary>
		/// <param name="_feeStudFundId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudFund GetByFeeStudFundId(System.Decimal _feeStudFundId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFundId(null, _feeStudFundId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_FUND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFundId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudFund GetByFeeStudFundId(TransactionManager transactionManager, System.Decimal _feeStudFundId)
		{
			int count = -1;
			return GetByFeeStudFundId(transactionManager, _feeStudFundId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_FUND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFundId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudFund GetByFeeStudFundId(TransactionManager transactionManager, System.Decimal _feeStudFundId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFundId(transactionManager, _feeStudFundId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_FUND index.
		/// </summary>
		/// <param name="_feeStudFundId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudFund GetByFeeStudFundId(System.Decimal _feeStudFundId, int start, int pageLength, out int count)
		{
			return GetByFeeStudFundId(null, _feeStudFundId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_FUND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFundId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudFund GetByFeeStudFundId(TransactionManager transactionManager, System.Decimal _feeStudFundId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudFund&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudFund&gt;"/></returns>
		public static TList<FeeStudFund> Fill(IDataReader reader, TList<FeeStudFund> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudFund c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudFund")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_FUND_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudFund>(
					key.ToString(), // EntityTrackingKey
					"FeeStudFund",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudFund();
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
					c.FeeStudFundId = (System.Decimal)reader["FEE_STUD_FUND_ID"];
					c.OriginalFeeStudFundId = c.FeeStudFundId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.FeeCdeFundId = (System.Int32)reader["FEE_CDE_FUND_ID"];
					c.EventFromDate = Convert.IsDBNull(reader["EVENT_FROM_DATE"]) ? null : (System.DateTime?)reader["EVENT_FROM_DATE"];
					c.EventToDate = Convert.IsDBNull(reader["EVENT_TO_DATE"]) ? null : (System.DateTime?)reader["EVENT_TO_DATE"];
					c.EventNameEn = Convert.IsDBNull(reader["EVENT_NAME_EN"]) ? null : (System.String)reader["EVENT_NAME_EN"];
					c.PaperNameEn = Convert.IsDBNull(reader["PAPER_NAME_EN"]) ? null : (System.String)reader["PAPER_NAME_EN"];
					c.TotalAmount = Convert.IsDBNull(reader["TOTAL_AMOUNT"]) ? null : (System.Decimal?)reader["TOTAL_AMOUNT"];
					c.FundAmount = Convert.IsDBNull(reader["FUND_AMOUNT"]) ? null : (System.Decimal?)reader["FUND_AMOUNT"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.MemoDate = Convert.IsDBNull(reader["MEMO_DATE"]) ? null : (System.DateTime?)reader["MEMO_DATE"];
					c.TransferFlg = Convert.IsDBNull(reader["TRANSFER_FLG"]) ? null : (System.Boolean?)reader["TRANSFER_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudFund entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudFundId = (System.Decimal)reader[((int)FeeStudFundColumn.FeeStudFundId - 1)];
			entity.OriginalFeeStudFundId = (System.Decimal)reader["FEE_STUD_FUND_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)FeeStudFundColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeStudFundColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)FeeStudFundColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)FeeStudFundColumn.EdCodeSemesterId - 1)];
			entity.FeeCdeFundId = (System.Int32)reader[((int)FeeStudFundColumn.FeeCdeFundId - 1)];
			entity.EventFromDate = (reader.IsDBNull(((int)FeeStudFundColumn.EventFromDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudFundColumn.EventFromDate - 1)];
			entity.EventToDate = (reader.IsDBNull(((int)FeeStudFundColumn.EventToDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudFundColumn.EventToDate - 1)];
			entity.EventNameEn = (reader.IsDBNull(((int)FeeStudFundColumn.EventNameEn - 1)))?null:(System.String)reader[((int)FeeStudFundColumn.EventNameEn - 1)];
			entity.PaperNameEn = (reader.IsDBNull(((int)FeeStudFundColumn.PaperNameEn - 1)))?null:(System.String)reader[((int)FeeStudFundColumn.PaperNameEn - 1)];
			entity.TotalAmount = (reader.IsDBNull(((int)FeeStudFundColumn.TotalAmount - 1)))?null:(System.Decimal?)reader[((int)FeeStudFundColumn.TotalAmount - 1)];
			entity.FundAmount = (reader.IsDBNull(((int)FeeStudFundColumn.FundAmount - 1)))?null:(System.Decimal?)reader[((int)FeeStudFundColumn.FundAmount - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)FeeStudFundColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)FeeStudFundColumn.GsCountryNodeId - 1)];
			entity.MemoDate = (reader.IsDBNull(((int)FeeStudFundColumn.MemoDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudFundColumn.MemoDate - 1)];
			entity.TransferFlg = (reader.IsDBNull(((int)FeeStudFundColumn.TransferFlg - 1)))?null:(System.Boolean?)reader[((int)FeeStudFundColumn.TransferFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeStudFundColumn.Notes - 1)))?null:(System.String)reader[((int)FeeStudFundColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudFundColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudFundColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudFundColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudFundColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudFund entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudFundId = (System.Decimal)dataRow["FEE_STUD_FUND_ID"];
			entity.OriginalFeeStudFundId = (System.Decimal)dataRow["FEE_STUD_FUND_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.FeeCdeFundId = (System.Int32)dataRow["FEE_CDE_FUND_ID"];
			entity.EventFromDate = Convert.IsDBNull(dataRow["EVENT_FROM_DATE"]) ? null : (System.DateTime?)dataRow["EVENT_FROM_DATE"];
			entity.EventToDate = Convert.IsDBNull(dataRow["EVENT_TO_DATE"]) ? null : (System.DateTime?)dataRow["EVENT_TO_DATE"];
			entity.EventNameEn = Convert.IsDBNull(dataRow["EVENT_NAME_EN"]) ? null : (System.String)dataRow["EVENT_NAME_EN"];
			entity.PaperNameEn = Convert.IsDBNull(dataRow["PAPER_NAME_EN"]) ? null : (System.String)dataRow["PAPER_NAME_EN"];
			entity.TotalAmount = Convert.IsDBNull(dataRow["TOTAL_AMOUNT"]) ? null : (System.Decimal?)dataRow["TOTAL_AMOUNT"];
			entity.FundAmount = Convert.IsDBNull(dataRow["FUND_AMOUNT"]) ? null : (System.Decimal?)dataRow["FUND_AMOUNT"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.MemoDate = Convert.IsDBNull(dataRow["MEMO_DATE"]) ? null : (System.DateTime?)dataRow["MEMO_DATE"];
			entity.TransferFlg = Convert.IsDBNull(dataRow["TRANSFER_FLG"]) ? null : (System.Boolean?)dataRow["TRANSFER_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudFund"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudFund Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudFund entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
				pkItems[0] = (entity.EdCodeSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterId ?? 0.0m));		
				
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

			#region FeeCdeFundIdSource	
			if (CanDeepLoad(entity, "FeeCdeFund|FeeCdeFundIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeFundIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCdeFundId;
				FeeCdeFund tmpEntity = EntityManager.LocateEntity<FeeCdeFund>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeFund), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeFundIdSource = tmpEntity;
				else
					entity.FeeCdeFundIdSource = DataRepository.FeeCdeFundProvider.GetByFeeCdeFundId(transactionManager, entity.FeeCdeFundId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeFundIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeFundIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeFundProvider.DeepLoad(transactionManager, entity.FeeCdeFundIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeFundIdSource

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeId ?? 0.0m));		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudFund object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudFund instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudFund Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudFund entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region FeeCdeFundIdSource
			if (CanDeepSave(entity, "FeeCdeFund|FeeCdeFundIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeFundIdSource != null)
			{
				DataRepository.FeeCdeFundProvider.Save(transactionManager, entity.FeeCdeFundIdSource);
				entity.FeeCdeFundId = entity.FeeCdeFundIdSource.FeeCdeFundId;
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
	
	#region FeeStudFundChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudFund</c>
	///</summary>
	public enum FeeStudFundChildEntityTypes
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
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>FeeCdeFund</c> at FeeCdeFundIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeFund))]
		FeeCdeFund,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
	}
	
	#endregion FeeStudFundChildEntityTypes
	
	#region FeeStudFundFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudFundColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudFund"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudFundFilterBuilder : SqlFilterBuilder<FeeStudFundColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudFundFilterBuilder class.
		/// </summary>
		public FeeStudFundFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudFundFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudFundFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudFundFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudFundFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudFundFilterBuilder
	
	#region FeeStudFundParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudFundColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudFund"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudFundParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudFundColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudFundParameterBuilder class.
		/// </summary>
		public FeeStudFundParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudFundParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudFundParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudFundParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudFundParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudFundParameterBuilder
	
	#region FeeStudFundSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudFundColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudFund"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudFundSortBuilder : SqlSortBuilder<FeeStudFundColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudFundSqlSortBuilder class.
		/// </summary>
		public FeeStudFundSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudFundSortBuilder
	
} // end namespace
