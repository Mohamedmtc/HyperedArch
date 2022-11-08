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
	/// This class is the base class for any <see cref="FeeAllowanceRuleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeAllowanceRuleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeAllowanceRule, UMIS_VER2.BusinessLyer.FeeAllowanceRuleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAllowanceRuleKey key)
		{
			return Delete(transactionManager, key.FeeAllowanceRuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeAllowanceRuleId">قواعد تحميل المرتبات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeAllowanceRuleId)
		{
			return Delete(null, _feeAllowanceRuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAllowanceRuleId">قواعد تحميل المرتبات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeAllowanceRuleId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_ADM_CDE_APP_TYPE key.
		///		FK_FEE_ALLOWANCE_RULE_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(_admCdeAppTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_ADM_CDE_APP_TYPE key.
		///		FK_FEE_ALLOWANCE_RULE_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeAllowanceRule> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_ADM_CDE_APP_TYPE key.
		///		FK_FEE_ALLOWANCE_RULE_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_ADM_CDE_APP_TYPE key.
		///		fkFeeAllowanceRuleAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_ADM_CDE_APP_TYPE key.
		///		fkFeeAllowanceRuleAdmCdeAppType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_ADM_CDE_APP_TYPE key.
		///		FK_FEE_ALLOWANCE_RULE_ADM_CDE_APP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public abstract TList<FeeAllowanceRule> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeAllowanceRule> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE key.
		///		fkFeeAllowanceRuleAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE key.
		///		fkFeeAllowanceRuleAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public abstract TList<FeeAllowanceRule> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeAllowanceRule> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE_CLASS key.
		///		fkFeeAllowanceRuleAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE_CLASS key.
		///		fkFeeAllowanceRuleAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_ALLOWANCE_RULE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public abstract TList<FeeAllowanceRule> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_FEE_CDE_ALLOWANCE key.
		///		FK_FEE_ALLOWANCE_RULE_FEE_CDE_ALLOWANCE Description: 
		/// </summary>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByFeeCdeAllowanceId(System.Int32 _feeCdeAllowanceId)
		{
			int count = -1;
			return GetByFeeCdeAllowanceId(_feeCdeAllowanceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_FEE_CDE_ALLOWANCE key.
		///		FK_FEE_ALLOWANCE_RULE_FEE_CDE_ALLOWANCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeAllowanceRule> GetByFeeCdeAllowanceId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId)
		{
			int count = -1;
			return GetByFeeCdeAllowanceId(transactionManager, _feeCdeAllowanceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_FEE_CDE_ALLOWANCE key.
		///		FK_FEE_ALLOWANCE_RULE_FEE_CDE_ALLOWANCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByFeeCdeAllowanceId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeAllowanceId(transactionManager, _feeCdeAllowanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_FEE_CDE_ALLOWANCE key.
		///		fkFeeAllowanceRuleFeeCdeAllowance Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByFeeCdeAllowanceId(System.Int32 _feeCdeAllowanceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeAllowanceId(null, _feeCdeAllowanceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_FEE_CDE_ALLOWANCE key.
		///		fkFeeAllowanceRuleFeeCdeAllowance Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByFeeCdeAllowanceId(System.Int32 _feeCdeAllowanceId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeAllowanceId(null, _feeCdeAllowanceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_FEE_CDE_ALLOWANCE key.
		///		FK_FEE_ALLOWANCE_RULE_FEE_CDE_ALLOWANCE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public abstract TList<FeeAllowanceRule> GetByFeeCdeAllowanceId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_CURRENCY key.
		///		FK_FEE_ALLOWANCE_RULE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_CURRENCY key.
		///		FK_FEE_ALLOWANCE_RULE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeAllowanceRule> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_CURRENCY key.
		///		FK_FEE_ALLOWANCE_RULE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_CURRENCY key.
		///		fkFeeAllowanceRuleGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_CURRENCY key.
		///		fkFeeAllowanceRuleGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_CURRENCY key.
		///		FK_FEE_ALLOWANCE_RULE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public abstract TList<FeeAllowanceRule> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_GENDER key.
		///		FK_FEE_ALLOWANCE_RULE_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_GENDER key.
		///		FK_FEE_ALLOWANCE_RULE_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeAllowanceRule> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_GENDER key.
		///		FK_FEE_ALLOWANCE_RULE_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_GENDER key.
		///		fkFeeAllowanceRuleGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_GENDER key.
		///		fkFeeAllowanceRuleGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public TList<FeeAllowanceRule> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ALLOWANCE_RULE_GS_CODE_GENDER key.
		///		FK_FEE_ALLOWANCE_RULE_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAllowanceRule objects.</returns>
		public abstract TList<FeeAllowanceRule> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeAllowanceRule Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAllowanceRuleKey key, int start, int pageLength)
		{
			return GetByFeeAllowanceRuleId(transactionManager, key.FeeAllowanceRuleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="_feeAllowanceRuleId">قواعد تحميل المرتبات</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAllowanceRule GetByFeeAllowanceRuleId(System.Int32 _feeAllowanceRuleId)
		{
			int count = -1;
			return GetByFeeAllowanceRuleId(null,_feeAllowanceRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="_feeAllowanceRuleId">قواعد تحميل المرتبات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAllowanceRule GetByFeeAllowanceRuleId(System.Int32 _feeAllowanceRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAllowanceRuleId(null, _feeAllowanceRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAllowanceRuleId">قواعد تحميل المرتبات</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAllowanceRule GetByFeeAllowanceRuleId(TransactionManager transactionManager, System.Int32 _feeAllowanceRuleId)
		{
			int count = -1;
			return GetByFeeAllowanceRuleId(transactionManager, _feeAllowanceRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAllowanceRuleId">قواعد تحميل المرتبات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAllowanceRule GetByFeeAllowanceRuleId(TransactionManager transactionManager, System.Int32 _feeAllowanceRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAllowanceRuleId(transactionManager, _feeAllowanceRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="_feeAllowanceRuleId">قواعد تحميل المرتبات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAllowanceRule GetByFeeAllowanceRuleId(System.Int32 _feeAllowanceRuleId, int start, int pageLength, out int count)
		{
			return GetByFeeAllowanceRuleId(null, _feeAllowanceRuleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAllowanceRuleId">قواعد تحميل المرتبات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeAllowanceRule GetByFeeAllowanceRuleId(TransactionManager transactionManager, System.Int32 _feeAllowanceRuleId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <param name="_housingFlg">داخلى1 - خارجى2-0default</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeAllowanceRule&gt;"/> class.</returns>
		public TList<FeeAllowanceRule> GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(System.Int32 _feeCdeAllowanceId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _gsCodeGenderId, System.Int16? _housingFlg, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(null,_feeCdeAllowanceId, _asCodeDegreeId, _asCodeDegreeClassId, _gsCodeGenderId, _housingFlg, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <param name="_housingFlg">داخلى1 - خارجى2-0default</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeAllowanceRule&gt;"/> class.</returns>
		public TList<FeeAllowanceRule> GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(System.Int32 _feeCdeAllowanceId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _gsCodeGenderId, System.Int16? _housingFlg, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(null, _feeCdeAllowanceId, _asCodeDegreeId, _asCodeDegreeClassId, _gsCodeGenderId, _housingFlg, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <param name="_housingFlg">داخلى1 - خارجى2-0default</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeAllowanceRule&gt;"/> class.</returns>
		public TList<FeeAllowanceRule> GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _gsCodeGenderId, System.Int16? _housingFlg, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(transactionManager, _feeCdeAllowanceId, _asCodeDegreeId, _asCodeDegreeClassId, _gsCodeGenderId, _housingFlg, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <param name="_housingFlg">داخلى1 - خارجى2-0default</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeAllowanceRule&gt;"/> class.</returns>
		public TList<FeeAllowanceRule> GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _gsCodeGenderId, System.Int16? _housingFlg, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(transactionManager, _feeCdeAllowanceId, _asCodeDegreeId, _asCodeDegreeClassId, _gsCodeGenderId, _housingFlg, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <param name="_housingFlg">داخلى1 - خارجى2-0default</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeAllowanceRule&gt;"/> class.</returns>
		public TList<FeeAllowanceRule> GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(System.Int32 _feeCdeAllowanceId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _gsCodeGenderId, System.Int16? _housingFlg, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(null, _feeCdeAllowanceId, _asCodeDegreeId, _asCodeDegreeClassId, _gsCodeGenderId, _housingFlg, _admCdeAppTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ALLOWANCE_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeAllowanceId">Constant :Payroll / Housing /Allowance / Others</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_gsCodeGenderId">ذكر - انثي</param>
		/// <param name="_housingFlg">داخلى1 - خارجى2-0default</param>
		/// <param name="_admCdeAppTypeId">فئه الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeAllowanceRule&gt;"/> class.</returns>
		public abstract TList<FeeAllowanceRule> GetByFeeCdeAllowanceIdAsCodeDegreeIdAsCodeDegreeClassIdGsCodeGenderIdHousingFlgAdmCdeAppTypeId(TransactionManager transactionManager, System.Int32 _feeCdeAllowanceId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _gsCodeGenderId, System.Int16? _housingFlg, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeAllowanceRule&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeAllowanceRule&gt;"/></returns>
		public static TList<FeeAllowanceRule> Fill(IDataReader reader, TList<FeeAllowanceRule> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeAllowanceRule c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeAllowanceRule")
					.Append("|").Append((System.Int32)reader["FEE_ALLOWANCE_RULE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeAllowanceRule>(
					key.ToString(), // EntityTrackingKey
					"FeeAllowanceRule",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeAllowanceRule();
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
					c.FeeAllowanceRuleId = (System.Int32)reader["FEE_ALLOWANCE_RULE_ID"];
					c.OriginalFeeAllowanceRuleId = c.FeeAllowanceRuleId;
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.AdmCdeAppTypeId = Convert.IsDBNull(reader["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_APP_TYPE_ID"];
					c.HousingFlg = Convert.IsDBNull(reader["HOUSING_FLG"]) ? null : (System.Int16?)reader["HOUSING_FLG"];
					c.FeeCdeAllowanceId = (System.Int32)reader["FEE_CDE_ALLOWANCE_ID"];
					c.Amount = Convert.IsDBNull(reader["AMOUNT"]) ? null : (System.Decimal?)reader["AMOUNT"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeAllowanceRule entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeAllowanceRuleId = (System.Int32)reader[((int)FeeAllowanceRuleColumn.FeeAllowanceRuleId - 1)];
			entity.OriginalFeeAllowanceRuleId = (System.Int32)reader["FEE_ALLOWANCE_RULE_ID"];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)FeeAllowanceRuleColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)FeeAllowanceRuleColumn.GsCodeGenderId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)FeeAllowanceRuleColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)FeeAllowanceRuleColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)FeeAllowanceRuleColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)FeeAllowanceRuleColumn.AsCodeDegreeId - 1)];
			entity.AdmCdeAppTypeId = (reader.IsDBNull(((int)FeeAllowanceRuleColumn.AdmCdeAppTypeId - 1)))?null:(System.Decimal?)reader[((int)FeeAllowanceRuleColumn.AdmCdeAppTypeId - 1)];
			entity.HousingFlg = (reader.IsDBNull(((int)FeeAllowanceRuleColumn.HousingFlg - 1)))?null:(System.Int16?)reader[((int)FeeAllowanceRuleColumn.HousingFlg - 1)];
			entity.FeeCdeAllowanceId = (System.Int32)reader[((int)FeeAllowanceRuleColumn.FeeCdeAllowanceId - 1)];
			entity.Amount = (reader.IsDBNull(((int)FeeAllowanceRuleColumn.Amount - 1)))?null:(System.Decimal?)reader[((int)FeeAllowanceRuleColumn.Amount - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)FeeAllowanceRuleColumn.GsCodeCurrencyId - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeAllowanceRuleColumn.Notes - 1)))?null:(System.String)reader[((int)FeeAllowanceRuleColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeAllowanceRuleColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeAllowanceRuleColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeAllowanceRuleColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeAllowanceRuleColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeAllowanceRule entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeAllowanceRuleId = (System.Int32)dataRow["FEE_ALLOWANCE_RULE_ID"];
			entity.OriginalFeeAllowanceRuleId = (System.Int32)dataRow["FEE_ALLOWANCE_RULE_ID"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.AdmCdeAppTypeId = Convert.IsDBNull(dataRow["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_APP_TYPE_ID"];
			entity.HousingFlg = Convert.IsDBNull(dataRow["HOUSING_FLG"]) ? null : (System.Int16?)dataRow["HOUSING_FLG"];
			entity.FeeCdeAllowanceId = (System.Int32)dataRow["FEE_CDE_ALLOWANCE_ID"];
			entity.Amount = Convert.IsDBNull(dataRow["AMOUNT"]) ? null : (System.Decimal?)dataRow["AMOUNT"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAllowanceRule"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeAllowanceRule Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAllowanceRule entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeAppTypeIdSource	
			if (CanDeepLoad(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeAppTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeAppTypeId ?? 0.0m);
				AdmCdeAppType tmpEntity = EntityManager.LocateEntity<AdmCdeAppType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeAppType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeAppTypeIdSource = tmpEntity;
				else
					entity.AdmCdeAppTypeIdSource = DataRepository.AdmCdeAppTypeProvider.GetByAdmCdeAppTypeId(transactionManager, (entity.AdmCdeAppTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeAppTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeAppTypeProvider.DeepLoad(transactionManager, entity.AdmCdeAppTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeAppTypeIdSource

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeId ?? 0.0m);
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, (entity.AsCodeDegreeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource

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

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeGenderId ?? 0.0m);
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, (entity.GsCodeGenderId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeGenderIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeGenderIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeGenderProvider.DeepLoad(transactionManager, entity.GsCodeGenderIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeGenderIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeAllowanceRule object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeAllowanceRule instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeAllowanceRule Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAllowanceRule entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeAppTypeIdSource
			if (CanDeepSave(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeAppTypeIdSource != null)
			{
				DataRepository.AdmCdeAppTypeProvider.Save(transactionManager, entity.AdmCdeAppTypeIdSource);
				entity.AdmCdeAppTypeId = entity.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
			}
			#endregion 
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
			}
			#endregion 
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
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
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
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
	
	#region FeeAllowanceRuleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeAllowanceRule</c>
	///</summary>
	public enum FeeAllowanceRuleChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeAppType</c> at AdmCdeAppTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeAppType))]
		AdmCdeAppType,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
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
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
	}
	
	#endregion FeeAllowanceRuleChildEntityTypes
	
	#region FeeAllowanceRuleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeAllowanceRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAllowanceRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeAllowanceRuleFilterBuilder : SqlFilterBuilder<FeeAllowanceRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAllowanceRuleFilterBuilder class.
		/// </summary>
		public FeeAllowanceRuleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeAllowanceRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeAllowanceRuleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeAllowanceRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeAllowanceRuleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeAllowanceRuleFilterBuilder
	
	#region FeeAllowanceRuleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeAllowanceRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAllowanceRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeAllowanceRuleParameterBuilder : ParameterizedSqlFilterBuilder<FeeAllowanceRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAllowanceRuleParameterBuilder class.
		/// </summary>
		public FeeAllowanceRuleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeAllowanceRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeAllowanceRuleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeAllowanceRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeAllowanceRuleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeAllowanceRuleParameterBuilder
	
	#region FeeAllowanceRuleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeAllowanceRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAllowanceRule"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeAllowanceRuleSortBuilder : SqlSortBuilder<FeeAllowanceRuleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAllowanceRuleSqlSortBuilder class.
		/// </summary>
		public FeeAllowanceRuleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeAllowanceRuleSortBuilder
	
} // end namespace
