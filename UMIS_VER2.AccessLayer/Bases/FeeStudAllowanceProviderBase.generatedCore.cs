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
	/// This class is the base class for any <see cref="FeeStudAllowanceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudAllowanceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudAllowance, UMIS_VER2.BusinessLyer.FeeStudAllowanceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudAllowanceKey key)
		{
			return Delete(transactionManager, key.FeeStudAllowanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudAllowanceId">تحديد المبالغ المستحقة للطالب عن شهرPG. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudAllowanceId)
		{
			return Delete(null, _feeStudAllowanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudAllowanceId">تحديد المبالغ المستحقة للطالب عن شهرPG. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudAllowanceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_ALLOWANCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_ALLOWANCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudAllowance> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_ALLOWANCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_ACAD_YEAR key.
		///		fkFeeStudAllowanceEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_ACAD_YEAR key.
		///		fkFeeStudAllowanceEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_ACAD_YEAR key.
		///		FK_FEE_STUD_ALLOWANCE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public abstract TList<FeeStudAllowance> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_STUD key.
		///		FK_FEE_STUD_ALLOWANCE_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_STUD key.
		///		FK_FEE_STUD_ALLOWANCE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudAllowance> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_STUD key.
		///		FK_FEE_STUD_ALLOWANCE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_STUD key.
		///		fkFeeStudAllowanceEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_STUD key.
		///		fkFeeStudAllowanceEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_ED_STUD key.
		///		FK_FEE_STUD_ALLOWANCE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public abstract TList<FeeStudAllowance> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_FEE_CDE_ALLOWANCE key.
		///		FK_FEE_STUD_ALLOWANCE_FEE_CDE_ALLOWANCE Description: 
		/// </summary>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByFeeCdeAllowanceId(System.Int32 _feeCdeAllowanceId)
		{
			int count = -1;
			return GetByFeeCdeAllowanceId(_feeCdeAllowanceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_FEE_CDE_ALLOWANCE key.
		///		FK_FEE_STUD_ALLOWANCE_FEE_CDE_ALLOWANCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudAllowance> GetByFeeCdeAllowanceId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId)
		{
			int count = -1;
			return GetByFeeCdeAllowanceId(transactionManager, _feeCdeAllowanceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_FEE_CDE_ALLOWANCE key.
		///		FK_FEE_STUD_ALLOWANCE_FEE_CDE_ALLOWANCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByFeeCdeAllowanceId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeAllowanceId(transactionManager, _feeCdeAllowanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_FEE_CDE_ALLOWANCE key.
		///		fkFeeStudAllowanceFeeCdeAllowance Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByFeeCdeAllowanceId(System.Int32 _feeCdeAllowanceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeAllowanceId(null, _feeCdeAllowanceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_FEE_CDE_ALLOWANCE key.
		///		fkFeeStudAllowanceFeeCdeAllowance Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByFeeCdeAllowanceId(System.Int32 _feeCdeAllowanceId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeAllowanceId(null, _feeCdeAllowanceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_FEE_CDE_ALLOWANCE key.
		///		FK_FEE_STUD_ALLOWANCE_FEE_CDE_ALLOWANCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public abstract TList<FeeStudAllowance> GetByFeeCdeAllowanceId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_GS_CODE_CURRENCY key.
		///		FK_FEE_STUD_ALLOWANCE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_GS_CODE_CURRENCY key.
		///		FK_FEE_STUD_ALLOWANCE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudAllowance> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_GS_CODE_CURRENCY key.
		///		FK_FEE_STUD_ALLOWANCE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_GS_CODE_CURRENCY key.
		///		fkFeeStudAllowanceGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_GS_CODE_CURRENCY key.
		///		fkFeeStudAllowanceGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public TList<FeeStudAllowance> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_ALLOWANCE_GS_CODE_CURRENCY key.
		///		FK_FEE_STUD_ALLOWANCE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudAllowance objects.</returns>
		public abstract TList<FeeStudAllowance> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudAllowance Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudAllowanceKey key, int start, int pageLength)
		{
			return GetByFeeStudAllowanceId(transactionManager, key.FeeStudAllowanceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="_feeStudAllowanceId">تحديد المبالغ المستحقة للطالب عن شهرPG</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudAllowance GetByFeeStudAllowanceId(System.Decimal _feeStudAllowanceId)
		{
			int count = -1;
			return GetByFeeStudAllowanceId(null,_feeStudAllowanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="_feeStudAllowanceId">تحديد المبالغ المستحقة للطالب عن شهرPG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudAllowance GetByFeeStudAllowanceId(System.Decimal _feeStudAllowanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudAllowanceId(null, _feeStudAllowanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudAllowanceId">تحديد المبالغ المستحقة للطالب عن شهرPG</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudAllowance GetByFeeStudAllowanceId(TransactionManager transactionManager, System.Decimal _feeStudAllowanceId)
		{
			int count = -1;
			return GetByFeeStudAllowanceId(transactionManager, _feeStudAllowanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudAllowanceId">تحديد المبالغ المستحقة للطالب عن شهرPG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudAllowance GetByFeeStudAllowanceId(TransactionManager transactionManager, System.Decimal _feeStudAllowanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudAllowanceId(transactionManager, _feeStudAllowanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="_feeStudAllowanceId">تحديد المبالغ المستحقة للطالب عن شهرPG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudAllowance GetByFeeStudAllowanceId(System.Decimal _feeStudAllowanceId, int start, int pageLength, out int count)
		{
			return GetByFeeStudAllowanceId(null, _feeStudAllowanceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudAllowanceId">تحديد المبالغ المستحقة للطالب عن شهرPG</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudAllowance GetByFeeStudAllowanceId(TransactionManager transactionManager, System.Decimal _feeStudAllowanceId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="_monthId">الشهر 1-12</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudAllowance GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Int32? _monthId, System.Int32 _feeCdeAllowanceId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(null,_edAcadYearId, _edStudId, _monthId, _feeCdeAllowanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="_monthId">الشهر 1-12</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudAllowance GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Int32? _monthId, System.Int32 _feeCdeAllowanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(null, _edAcadYearId, _edStudId, _monthId, _feeCdeAllowanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="_monthId">الشهر 1-12</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudAllowance GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Int32? _monthId, System.Int32 _feeCdeAllowanceId)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(transactionManager, _edAcadYearId, _edStudId, _monthId, _feeCdeAllowanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="_monthId">الشهر 1-12</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudAllowance GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Int32? _monthId, System.Int32 _feeCdeAllowanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(transactionManager, _edAcadYearId, _edStudId, _monthId, _feeCdeAllowanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="_monthId">الشهر 1-12</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudAllowance GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Int32? _monthId, System.Int32 _feeCdeAllowanceId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(null, _edAcadYearId, _edStudId, _monthId, _feeCdeAllowanceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_ALLOWANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="_edStudId">PG Sponsored Student</param>
		/// <param name="_monthId">الشهر 1-12</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudAllowance GetByEdAcadYearIdEdStudIdMonthIdFeeCdeAllowanceId(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edStudId, System.Int32? _monthId, System.Int32 _feeCdeAllowanceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudAllowance&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudAllowance&gt;"/></returns>
		public static TList<FeeStudAllowance> Fill(IDataReader reader, TList<FeeStudAllowance> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudAllowance c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudAllowance")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_ALLOWANCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudAllowance>(
					key.ToString(), // EntityTrackingKey
					"FeeStudAllowance",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudAllowance();
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
					c.FeeStudAllowanceId = (System.Decimal)reader["FEE_STUD_ALLOWANCE_ID"];
					c.OriginalFeeStudAllowanceId = c.FeeStudAllowanceId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.MonthId = Convert.IsDBNull(reader["MONTH_ID"]) ? null : (System.Int32?)reader["MONTH_ID"];
					c.FeeCdeAllowanceId = (System.Int32)reader["FEE_CDE_ALLOWANCE_ID"];
					c.Amount = Convert.IsDBNull(reader["AMOUNT"]) ? null : (System.Decimal?)reader["AMOUNT"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.PayFlg = (System.Boolean)reader["PAY_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudAllowance entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudAllowanceId = (System.Decimal)reader[((int)FeeStudAllowanceColumn.FeeStudAllowanceId - 1)];
			entity.OriginalFeeStudAllowanceId = (System.Decimal)reader["FEE_STUD_ALLOWANCE_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)FeeStudAllowanceColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeStudAllowanceColumn.EdAcadYearId - 1)];
			entity.MonthId = (reader.IsDBNull(((int)FeeStudAllowanceColumn.MonthId - 1)))?null:(System.Int32?)reader[((int)FeeStudAllowanceColumn.MonthId - 1)];
			entity.FeeCdeAllowanceId = (System.Int32)reader[((int)FeeStudAllowanceColumn.FeeCdeAllowanceId - 1)];
			entity.Amount = (reader.IsDBNull(((int)FeeStudAllowanceColumn.Amount - 1)))?null:(System.Decimal?)reader[((int)FeeStudAllowanceColumn.Amount - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)FeeStudAllowanceColumn.GsCodeCurrencyId - 1)];
			entity.PayFlg = (System.Boolean)reader[((int)FeeStudAllowanceColumn.PayFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeStudAllowanceColumn.Notes - 1)))?null:(System.String)reader[((int)FeeStudAllowanceColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudAllowanceColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudAllowanceColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudAllowanceColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudAllowanceColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudAllowance entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudAllowanceId = (System.Decimal)dataRow["FEE_STUD_ALLOWANCE_ID"];
			entity.OriginalFeeStudAllowanceId = (System.Decimal)dataRow["FEE_STUD_ALLOWANCE_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.MonthId = Convert.IsDBNull(dataRow["MONTH_ID"]) ? null : (System.Int32?)dataRow["MONTH_ID"];
			entity.FeeCdeAllowanceId = (System.Int32)dataRow["FEE_CDE_ALLOWANCE_ID"];
			entity.Amount = Convert.IsDBNull(dataRow["AMOUNT"]) ? null : (System.Decimal?)dataRow["AMOUNT"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.PayFlg = (System.Boolean)dataRow["PAY_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudAllowance"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudAllowance Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudAllowance entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region FeeCdeAllowanceIdSource	
			if (CanDeepLoad(entity, "FeeCdeAllowance|FeeCdeAllowanceIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeAllowanceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCdeAllowanceId;
				FeeCdeAllowance tmpEntity = EntityManager.LocateEntity<FeeCdeAllowance>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeAllowance), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeAllowanceIdSource = tmpEntity;
				else
					entity.FeeCdeAllowanceIdSource = DataRepository.FeeCdeAllowanceProvider.GetByFeeCdeAllowanceId(transactionManager, entity.FeeCdeAllowanceId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeAllowanceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeAllowanceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeAllowanceProvider.DeepLoad(transactionManager, entity.FeeCdeAllowanceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeAllowanceIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeCurrencyId;
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.GsCodeCurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCurrencyIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudAllowance object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudAllowance instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudAllowance Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudAllowance entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region FeeCdeAllowanceIdSource
			if (CanDeepSave(entity, "FeeCdeAllowance|FeeCdeAllowanceIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeAllowanceIdSource != null)
			{
				DataRepository.FeeCdeAllowanceProvider.Save(transactionManager, entity.FeeCdeAllowanceIdSource);
				entity.FeeCdeAllowanceId = entity.FeeCdeAllowanceIdSource.FeeCdeAllowanceId;
			}
			#endregion 
			
			#region GsCodeCurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.GsCodeCurrencyIdSource);
				entity.GsCodeCurrencyId = entity.GsCodeCurrencyIdSource.GsCodeCurrencyId;
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
	
	#region FeeStudAllowanceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudAllowance</c>
	///</summary>
	public enum FeeStudAllowanceChildEntityTypes
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
		/// Composite Property for <c>FeeCdeAllowance</c> at FeeCdeAllowanceIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeAllowance))]
		FeeCdeAllowance,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
	}
	
	#endregion FeeStudAllowanceChildEntityTypes
	
	#region FeeStudAllowanceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudAllowanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudAllowance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudAllowanceFilterBuilder : SqlFilterBuilder<FeeStudAllowanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudAllowanceFilterBuilder class.
		/// </summary>
		public FeeStudAllowanceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudAllowanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudAllowanceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudAllowanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudAllowanceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudAllowanceFilterBuilder
	
	#region FeeStudAllowanceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudAllowanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudAllowance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudAllowanceParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudAllowanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudAllowanceParameterBuilder class.
		/// </summary>
		public FeeStudAllowanceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudAllowanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudAllowanceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudAllowanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudAllowanceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudAllowanceParameterBuilder
	
	#region FeeStudAllowanceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudAllowanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudAllowance"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudAllowanceSortBuilder : SqlSortBuilder<FeeStudAllowanceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudAllowanceSqlSortBuilder class.
		/// </summary>
		public FeeStudAllowanceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudAllowanceSortBuilder
	
} // end namespace
