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
	/// This class is the base class for any <see cref="AdmExamGrdngPkgDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmExamGrdngPkgDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl, UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtlKey key)
		{
			return Delete(transactionManager, key.AdmExamGrdngPkgDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admExamGrdngPkgDtlId">تفاصيل مجموعة تقديرات مقررات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admExamGrdngPkgDtlId)
		{
			return Delete(null, _admExamGrdngPkgDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgDtlId">تفاصيل مجموعة تقديرات مقررات. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByAdmCdeExamGrdngId(System.Decimal _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(_admCdeExamGrdngId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AdmExamGrdngPkgDtl> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal _admCdeExamGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeExamGrdngId(transactionManager, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_CDE_EXAM_GRDNG key.
		///		fkAdmExamGrdngPkgDtlAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByAdmCdeExamGrdngId(System.Decimal _admCdeExamGrdngId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_CDE_EXAM_GRDNG key.
		///		fkAdmExamGrdngPkgDtlAdmCdeExamGrdng Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByAdmCdeExamGrdngId(System.Decimal _admCdeExamGrdngId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeExamGrdngId(null, _admCdeExamGrdngId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_CDE_EXAM_GRDNG key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_CDE_EXAM_GRDNG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public abstract TList<AdmExamGrdngPkgDtl> GetByAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal _admCdeExamGrdngId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_EXAM_GRDNG_PKG key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByAdmExamGrdngPkgId(System.Decimal _admExamGrdngPkgId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(_admExamGrdngPkgId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_EXAM_GRDNG_PKG key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AdmExamGrdngPkgDtl> GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(transactionManager, _admExamGrdngPkgId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_EXAM_GRDNG_PKG key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(transactionManager, _admExamGrdngPkgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_EXAM_GRDNG_PKG key.
		///		fkAdmExamGrdngPkgDtlAdmExamGrdngPkg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByAdmExamGrdngPkgId(System.Decimal _admExamGrdngPkgId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmExamGrdngPkgId(null, _admExamGrdngPkgId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_EXAM_GRDNG_PKG key.
		///		fkAdmExamGrdngPkgDtlAdmExamGrdngPkg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByAdmExamGrdngPkgId(System.Decimal _admExamGrdngPkgId, int start, int pageLength,out int count)
		{
			return GetByAdmExamGrdngPkgId(null, _admExamGrdngPkgId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_EXAM_GRDNG_PKG key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_ADM_EXAM_GRDNG_PKG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public abstract TList<AdmExamGrdngPkgDtl> GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_GS_CODE_PASS_FAIL key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="_gsCodePassFailId">نجاح-رسوب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByGsCodePassFailId(System.Decimal _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(_gsCodePassFailId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_GS_CODE_PASS_FAIL key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId">نجاح-رسوب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AdmExamGrdngPkgDtl> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_GS_CODE_PASS_FAIL key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId">نجاح-رسوب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_GS_CODE_PASS_FAIL key.
		///		fkAdmExamGrdngPkgDtlGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId">نجاح-رسوب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByGsCodePassFailId(System.Decimal _gsCodePassFailId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_GS_CODE_PASS_FAIL key.
		///		fkAdmExamGrdngPkgDtlGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePassFailId">نجاح-رسوب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public TList<AdmExamGrdngPkgDtl> GetByGsCodePassFailId(System.Decimal _gsCodePassFailId, int start, int pageLength,out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_EXAM_GRDNG_PKG_DTL_GS_CODE_PASS_FAIL key.
		///		FK_ADM_EXAM_GRDNG_PKG_DTL_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId">نجاح-رسوب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl objects.</returns>
		public abstract TList<AdmExamGrdngPkgDtl> GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal _gsCodePassFailId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtlKey key, int start, int pageLength)
		{
			return GetByAdmExamGrdngPkgDtlId(transactionManager, key.AdmExamGrdngPkgDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="_admExamGrdngPkgDtlId">تفاصيل مجموعة تقديرات مقررات</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgDtlId(System.Decimal _admExamGrdngPkgDtlId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgDtlId(null,_admExamGrdngPkgDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="_admExamGrdngPkgDtlId">تفاصيل مجموعة تقديرات مقررات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgDtlId(System.Decimal _admExamGrdngPkgDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgDtlId(null, _admExamGrdngPkgDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgDtlId">تفاصيل مجموعة تقديرات مقررات</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgDtlId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgDtlId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgDtlId(transactionManager, _admExamGrdngPkgDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgDtlId">تفاصيل مجموعة تقديرات مقررات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgDtlId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgDtlId(transactionManager, _admExamGrdngPkgDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="_admExamGrdngPkgDtlId">تفاصيل مجموعة تقديرات مقررات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgDtlId(System.Decimal _admExamGrdngPkgDtlId, int start, int pageLength, out int count)
		{
			return GetByAdmExamGrdngPkgDtlId(null, _admExamGrdngPkgDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgDtlId">تفاصيل مجموعة تقديرات مقررات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgDtlId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgDtlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(System.Decimal _admExamGrdngPkgId, System.Decimal _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(null,_admExamGrdngPkgId, _admCdeExamGrdngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(System.Decimal _admExamGrdngPkgId, System.Decimal _admCdeExamGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(null, _admExamGrdngPkgId, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgId, System.Decimal _admCdeExamGrdngId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(transactionManager, _admExamGrdngPkgId, _admCdeExamGrdngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgId, System.Decimal _admCdeExamGrdngId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(transactionManager, _admExamGrdngPkgId, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(System.Decimal _admExamGrdngPkgId, System.Decimal _admCdeExamGrdngId, int start, int pageLength, out int count)
		{
			return GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(null, _admExamGrdngPkgId, _admCdeExamGrdngId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_EXAM_GRDNG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId">مجموعة تقديرات مقررات</param>
		/// <param name="_admCdeExamGrdngId">كود التقدير</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl GetByAdmExamGrdngPkgIdAdmCdeExamGrdngId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgId, System.Decimal _admCdeExamGrdngId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmExamGrdngPkgDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmExamGrdngPkgDtl&gt;"/></returns>
		public static TList<AdmExamGrdngPkgDtl> Fill(IDataReader reader, TList<AdmExamGrdngPkgDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmExamGrdngPkgDtl")
					.Append("|").Append((System.Decimal)reader["ADM_EXAM_GRDNG_PKG_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmExamGrdngPkgDtl>(
					key.ToString(), // EntityTrackingKey
					"AdmExamGrdngPkgDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl();
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
					c.AdmExamGrdngPkgDtlId = (System.Decimal)reader["ADM_EXAM_GRDNG_PKG_DTL_ID"];
					c.OriginalAdmExamGrdngPkgDtlId = c.AdmExamGrdngPkgDtlId;
					c.AdmExamGrdngPkgId = (System.Decimal)reader["ADM_EXAM_GRDNG_PKG_ID"];
					c.AdmCdeExamGrdngId = (System.Decimal)reader["ADM_CDE_EXAM_GRDNG_ID"];
					c.GrdngRnk = (System.Int32)reader["GRDNG_RNK"];
					c.GsCodePassFailId = (System.Decimal)reader["GS_CODE_PASS_FAIL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmExamGrdngPkgDtlId = (System.Decimal)reader[((int)AdmExamGrdngPkgDtlColumn.AdmExamGrdngPkgDtlId - 1)];
			entity.OriginalAdmExamGrdngPkgDtlId = (System.Decimal)reader["ADM_EXAM_GRDNG_PKG_DTL_ID"];
			entity.AdmExamGrdngPkgId = (System.Decimal)reader[((int)AdmExamGrdngPkgDtlColumn.AdmExamGrdngPkgId - 1)];
			entity.AdmCdeExamGrdngId = (System.Decimal)reader[((int)AdmExamGrdngPkgDtlColumn.AdmCdeExamGrdngId - 1)];
			entity.GrdngRnk = (System.Int32)reader[((int)AdmExamGrdngPkgDtlColumn.GrdngRnk - 1)];
			entity.GsCodePassFailId = (System.Decimal)reader[((int)AdmExamGrdngPkgDtlColumn.GsCodePassFailId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmExamGrdngPkgDtlId = (System.Decimal)dataRow["ADM_EXAM_GRDNG_PKG_DTL_ID"];
			entity.OriginalAdmExamGrdngPkgDtlId = (System.Decimal)dataRow["ADM_EXAM_GRDNG_PKG_DTL_ID"];
			entity.AdmExamGrdngPkgId = (System.Decimal)dataRow["ADM_EXAM_GRDNG_PKG_ID"];
			entity.AdmCdeExamGrdngId = (System.Decimal)dataRow["ADM_CDE_EXAM_GRDNG_ID"];
			entity.GrdngRnk = (System.Int32)dataRow["GRDNG_RNK"];
			entity.GsCodePassFailId = (System.Decimal)dataRow["GS_CODE_PASS_FAIL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeExamGrdngIdSource	
			if (CanDeepLoad(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdeExamGrdngId;
				AdmCdeExamGrdng tmpEntity = EntityManager.LocateEntity<AdmCdeExamGrdng>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeExamGrdng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeExamGrdngIdSource = tmpEntity;
				else
					entity.AdmCdeExamGrdngIdSource = DataRepository.AdmCdeExamGrdngProvider.GetByAdmCdeExamGrdngId(transactionManager, entity.AdmCdeExamGrdngId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeExamGrdngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeExamGrdngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeExamGrdngProvider.DeepLoad(transactionManager, entity.AdmCdeExamGrdngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeExamGrdngIdSource

			#region AdmExamGrdngPkgIdSource	
			if (CanDeepLoad(entity, "AdmExamGrdngPkg|AdmExamGrdngPkgIdSource", deepLoadType, innerList) 
				&& entity.AdmExamGrdngPkgIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmExamGrdngPkgId;
				AdmExamGrdngPkg tmpEntity = EntityManager.LocateEntity<AdmExamGrdngPkg>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmExamGrdngPkg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmExamGrdngPkgIdSource = tmpEntity;
				else
					entity.AdmExamGrdngPkgIdSource = DataRepository.AdmExamGrdngPkgProvider.GetByAdmExamGrdngPkgId(transactionManager, entity.AdmExamGrdngPkgId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmExamGrdngPkgIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmExamGrdngPkgIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmExamGrdngPkgProvider.DeepLoad(transactionManager, entity.AdmExamGrdngPkgIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmExamGrdngPkgIdSource

			#region GsCodePassFailIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|GsCodePassFailIdSource", deepLoadType, innerList) 
				&& entity.GsCodePassFailIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodePassFailId;
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePassFailIdSource = tmpEntity;
				else
					entity.GsCodePassFailIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePassFailIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePassFailIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.GsCodePassFailIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePassFailIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeExamGrdngIdSource
			if (CanDeepSave(entity, "AdmCdeExamGrdng|AdmCdeExamGrdngIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeExamGrdngIdSource != null)
			{
				DataRepository.AdmCdeExamGrdngProvider.Save(transactionManager, entity.AdmCdeExamGrdngIdSource);
				entity.AdmCdeExamGrdngId = entity.AdmCdeExamGrdngIdSource.AdmCdeExamGrdngId;
			}
			#endregion 
			
			#region AdmExamGrdngPkgIdSource
			if (CanDeepSave(entity, "AdmExamGrdngPkg|AdmExamGrdngPkgIdSource", deepSaveType, innerList) 
				&& entity.AdmExamGrdngPkgIdSource != null)
			{
				DataRepository.AdmExamGrdngPkgProvider.Save(transactionManager, entity.AdmExamGrdngPkgIdSource);
				entity.AdmExamGrdngPkgId = entity.AdmExamGrdngPkgIdSource.AdmExamGrdngPkgId;
			}
			#endregion 
			
			#region GsCodePassFailIdSource
			if (CanDeepSave(entity, "GsCodePassFail|GsCodePassFailIdSource", deepSaveType, innerList) 
				&& entity.GsCodePassFailIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.GsCodePassFailIdSource);
				entity.GsCodePassFailId = entity.GsCodePassFailIdSource.GsCodePassFailId;
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
	
	#region AdmExamGrdngPkgDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmExamGrdngPkgDtl</c>
	///</summary>
	public enum AdmExamGrdngPkgDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeExamGrdng</c> at AdmCdeExamGrdngIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeExamGrdng))]
		AdmCdeExamGrdng,
		
		///<summary>
		/// Composite Property for <c>AdmExamGrdngPkg</c> at AdmExamGrdngPkgIdSource
		///</summary>
		[ChildEntityType(typeof(AdmExamGrdngPkg))]
		AdmExamGrdngPkg,
		
		///<summary>
		/// Composite Property for <c>GsCodePassFail</c> at GsCodePassFailIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePassFail))]
		GsCodePassFail,
	}
	
	#endregion AdmExamGrdngPkgDtlChildEntityTypes
	
	#region AdmExamGrdngPkgDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmExamGrdngPkgDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmExamGrdngPkgDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmExamGrdngPkgDtlFilterBuilder : SqlFilterBuilder<AdmExamGrdngPkgDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgDtlFilterBuilder class.
		/// </summary>
		public AdmExamGrdngPkgDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmExamGrdngPkgDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmExamGrdngPkgDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmExamGrdngPkgDtlFilterBuilder
	
	#region AdmExamGrdngPkgDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmExamGrdngPkgDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmExamGrdngPkgDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmExamGrdngPkgDtlParameterBuilder : ParameterizedSqlFilterBuilder<AdmExamGrdngPkgDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgDtlParameterBuilder class.
		/// </summary>
		public AdmExamGrdngPkgDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmExamGrdngPkgDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmExamGrdngPkgDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmExamGrdngPkgDtlParameterBuilder
	
	#region AdmExamGrdngPkgDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmExamGrdngPkgDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmExamGrdngPkgDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmExamGrdngPkgDtlSortBuilder : SqlSortBuilder<AdmExamGrdngPkgDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgDtlSqlSortBuilder class.
		/// </summary>
		public AdmExamGrdngPkgDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmExamGrdngPkgDtlSortBuilder
	
} // end namespace
